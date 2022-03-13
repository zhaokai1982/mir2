using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Client.MirControls;
using Client.MirGraphics;
using Client.MirNetwork;
using Client.MirSounds;
using C = ClientPackets;
using S = ServerPackets;
using System.Threading;
namespace Client.MirScenes
{
    public class SelectScene : MirScene
    {

        public MirImageControl Background, Title;
        private NewCharacterDialog _character;

        public MirLabel ServerLabel;
        public MirAnimatedControl CharacterDisplay;
        public MirButton StartGameButton, NewCharacterButton, DeleteCharacterButton, CreditsButton, ExitGame;
        public CharacterButton[] CharacterButtons;
        public MirLabel LastAccessLabel, LastAccessLabelLabel;
        public List<SelectInfo> Characters = new List<SelectInfo>();
        private int _selected;

        public SelectScene(List<SelectInfo> characters)
        {
            SoundManager.PlaySound(SoundList.SelectMusic, true);
            Disposing += (o, e) => SoundManager.StopSound(SoundList.SelectMusic);

            Characters = characters;
            SortList();

            KeyPress += SelectScene_KeyPress;

            Background = new MirImageControl
            {
                Index = 65,
                Library = Libraries.Prguse,
                Parent = this,
            };

            Title = new MirImageControl   
            {
                Index = 40,
                Library = Libraries.Title,
                Parent = this,
                Location = new Point(600, 20)   //标题栏图片左侧边缘距离左侧边框位置
            };

            ServerLabel = new MirLabel
            {
                Location = new Point(560, 60),   //选择人物界面上方标题栏位置1280X768位置
                // Location = new Point(432, 60),//选择人物界面上方标题栏位置1024X768大小时位置(432, 60)为左右中心.公式=分辨率宽度/2-80
                Parent = Background,
                Size = new Size(155, 17),
                Text = "热血无限国际传奇Ⅱ",     //人物创建选择界面上方游戏标题
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            };

            var xPoint = ((Settings.ScreenWidth - 200) / 5);  //底部按钮左右均分位置

            StartGameButton = new MirButton
            {
                Enabled = false,
                HoverIndex = 341,
                Index = 340,
                Library = Libraries.Title,
                Location = new Point(100 + (xPoint * 1) - (xPoint / 2) - 50, Settings.ScreenHeight - 32),
                Parent = Background,
                PressedIndex = 342
            };
            StartGameButton.Click += (o, e) => StartGame();

            NewCharacterButton = new MirButton
            {
                HoverIndex = 344,
                Index = 343,
                Library = Libraries.Title,
                Location = new Point(100 + (xPoint * 2) - (xPoint / 2) - 50, Settings.ScreenHeight - 32),
                Parent = Background,
                PressedIndex = 345,
            };
            NewCharacterButton.Click += (o, e) => _character = new NewCharacterDialog { Parent = this };

            DeleteCharacterButton = new MirButton
            {
                HoverIndex = 347,
                Index = 346,
                Library = Libraries.Title,
                Location = new Point(100 + (xPoint * 3) - (xPoint / 2) - 50, Settings.ScreenHeight - 32),
                Parent = Background,
                PressedIndex = 348
            };
            DeleteCharacterButton.Click += (o, e) => DeleteCharacter();


            CreditsButton = new MirButton
            {
                HoverIndex = 350,
                Index = 349,
                Library = Libraries.Title,
                Location = new Point(100 + (xPoint * 4) - (xPoint / 2) - 50, Settings.ScreenHeight - 32),
                Parent = Background,
                PressedIndex = 351
            };
            CreditsButton.Click += (o, e) =>
            {

            };

            ExitGame = new MirButton
            {
                HoverIndex = 353,
                Index = 352,
                Library = Libraries.Title,
                Location = new Point(100 + (xPoint * 5) - (xPoint / 2) - 50, Settings.ScreenHeight - 32),
                Parent = Background,
                PressedIndex = 354
            };
            ExitGame.Click += (o, e) => Program.Form.Close();


            CharacterDisplay = new MirAnimatedControl   //选择人物展示动画
            {
                Animated = true,
                AnimationCount = 16,    //动画图片数量
                AnimationDelay = 150,  //动画延时250默认
                FadeIn = true,
                FadeInDelay = 275,  //淡入淡出延时75默认
                FadeInRate = 0.1F,
                Index = 220,
                Library = Libraries.ChrSel,
                Location = new Point(360, 450), //动画位置(距离左侧距离260, 距离顶部距离420)默认(260, 420)
                Parent = Background,
                UseOffSet = true,
                Visible = false
            };
            CharacterDisplay.AfterDraw += (o, e) =>
            {
                // if (_selected >= 0 && _selected < Characters.Count && characters[_selected].Class == MirClass.Wizard)
                Libraries.ChrSel.DrawBlend(CharacterDisplay.Index + 560, CharacterDisplay.DisplayLocationWithoutOffSet, Color.White, true);
            };

            CharacterButtons = new CharacterButton[4];//人物选择按钮创建4个 CharacterButton[4]

            CharacterButtons[0] = new CharacterButton
            {
                Location = new Point(637, 194),  //人物选择按钮位置
                Parent = Background,
                Sound = SoundList.ButtonA,
            };
            CharacterButtons[0].Click += (o, e) =>
            {
                if (characters.Count <= 0) return;

                _selected = 0;
                UpdateInterface();
            };

            CharacterButtons[1] = new CharacterButton
            {
                Location = new Point(637, 298),
                Parent = Background,
                Sound = SoundList.ButtonA,
            };
            CharacterButtons[1].Click += (o, e) =>
            {
                if (characters.Count <= 1) return;
                _selected = 1;
                UpdateInterface();
            };

            CharacterButtons[2] = new CharacterButton
            {
                Location = new Point(637, 402),
                Parent = Background,
                Sound = SoundList.ButtonA,
            };
            CharacterButtons[2].Click += (o, e) =>
            {
                if (characters.Count <= 2) return;

                _selected = 2;
                UpdateInterface();
            };

            CharacterButtons[3] = new CharacterButton
            {
                Location = new Point(637, 506),
                Parent = Background,
                Sound = SoundList.ButtonA,
            };
            CharacterButtons[3].Click += (o, e) =>
            {
                if (characters.Count <= 3) return;

                _selected = 3;
                UpdateInterface();
            };

            LastAccessLabel = new MirLabel  //205行起始
            {
                Location = new Point(265, 609),
                Parent = Background,
                Size = new Size(180, 21),
                DrawFormat = TextFormatFlags.Left | TextFormatFlags.VerticalCenter,
                Border = true,
            };
            LastAccessLabelLabel = new MirLabel
            {
                Location = new Point(-65, 0),
                Parent = LastAccessLabel,
                Text = "上次在线：",
                Size = new Size(100, 21),
                DrawFormat = TextFormatFlags.Left | TextFormatFlags.VerticalCenter,
                Border = true,
            };
            UpdateInterface();
        }

        private void SelectScene_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (StartGameButton.Enabled)
                StartGame();
            e.Handled = true;
        }


        public void SortList()
        {
            if (Characters != null)
                Characters.Sort((c1, c2) => c2.LastAccess.CompareTo(c1.LastAccess));
        }


        public void StartGame()
        {
            if (!Libraries.Loaded)
            {
                MirMessageBox message = new MirMessageBox(string.Format("请稍候，游戏正在加载... {0:##0}%", Libraries.Progress / (double)Libraries.Count * 100), MirMessageBoxButtons.Cancel);

                message.BeforeDraw += (o, e) => message.Label.Text = string.Format("请稍候，游戏正在加载... {0:##0}%", Libraries.Progress / (double)Libraries.Count * 100);

                message.AfterDraw += (o, e) =>
                {
                    if (!Libraries.Loaded) return;
                    message.Dispose();
                    StartGame();
                };

                message.Show();

                return;
            }
            StartGameButton.Enabled = false;

            Network.Enqueue(new C.StartGame
            {
                CharacterIndex = Characters[_selected].Index
            });
        }

        public override void Process()
        {


        }
        public override void ProcessPacket(Packet p)
        {
            switch (p.Index)
            {
                case (short)ServerPacketIds.NewCharacter:
                    NewCharacter((S.NewCharacter)p);
                    break;
                case (short)ServerPacketIds.NewCharacterSuccess:
                    NewCharacter((S.NewCharacterSuccess)p);
                    break;
                case (short)ServerPacketIds.DeleteCharacter:
                    DeleteCharacter((S.DeleteCharacter)p);
                    break;
                case (short)ServerPacketIds.DeleteCharacterSuccess:
                    DeleteCharacter((S.DeleteCharacterSuccess)p);
                    break;
                case (short)ServerPacketIds.StartGame:
                    StartGame((S.StartGame)p);
                    break;
                case (short)ServerPacketIds.StartGameBanned:
                    StartGame((S.StartGameBanned)p);
                    break;
                case (short)ServerPacketIds.StartGameDelay:
                    StartGame((S.StartGameDelay)p);
                    break;
                default:
                    base.ProcessPacket(p);
                    break;
            }
        }

        private void NewCharacter(S.NewCharacter p)
        {
            _character.OKButton.Enabled = true;

            switch (p.Result)
            {
                case 0:
                    MirMessageBox.Show("当前已禁止创建新角色.");
                    _character.Dispose();
                    break;
                case 1:
                    MirMessageBox.Show("您使用的角色名称不可用.");
                    _character.NameTextBox.SetFocus();
                    break;
                case 2:
                    MirMessageBox.Show("您选择的人物性别不存在.\n 请联系管理员寻求帮助.");
                    break;
                case 3:
                    MirMessageBox.Show("您选择的职业不存在.\n 请联系管理员寻求帮助.");
                    break;
                case 4:
                    MirMessageBox.Show("您的角色已经满了只能使用 " + Globals.MaxCharacterCount + " 角色.");
                    _character.Dispose();
                    break;
                case 5:
                    MirMessageBox.Show("该角色名称已经被使用，请更换.");
                    _character.NameTextBox.SetFocus();
                    break;
            }


        }
        private void NewCharacter(S.NewCharacterSuccess p)
        {
            _character.Dispose();
            MirMessageBox.Show("您的角色已创建成功.");

            Characters.Insert(0, p.CharInfo);
            _selected = 0;
            UpdateInterface();
        }

        private void DeleteCharacter()
        {
            if (_selected < 0 || _selected >= Characters.Count) return;

            MirMessageBox message = new MirMessageBox(string.Format("是否确实要删除该角色{0}?", Characters[_selected].Name), MirMessageBoxButtons.YesNo);
            int index = Characters[_selected].Index;

            message.YesButton.Click += (o1, e1) =>
            {
                MirInputBox inputBox = new MirInputBox("请输入角色名称进行确认.");
                inputBox.OKButton.Click += (o, e) =>
                {
                    string name = Characters[_selected].Name.ToString();

                    if (inputBox.InputTextBox.Text == name)
                    {
                        DeleteCharacterButton.Enabled = false;
                        Network.Enqueue(new C.DeleteCharacter { CharacterIndex = index });
                    }
                    else
                    {
                        MirMessageBox failedMessage = new MirMessageBox(string.Format("输入名称错误."), MirMessageBoxButtons.OK);
                        failedMessage.Show();
                    }
                    inputBox.Dispose();
                };
                inputBox.Show();
            };
            message.Show();
        }

        private void DeleteCharacter(S.DeleteCharacter p)
        {
            DeleteCharacterButton.Enabled = true;
            switch (p.Result)
            {
                case 0:
                    MirMessageBox.Show("删除的角色当前处于禁用状态.");
                    break;
                case 1:
                    MirMessageBox.Show("您选择的角色不存在.\n 请联系管理员寻求帮助.");
                    break;
            }
        }
        private void DeleteCharacter(S.DeleteCharacterSuccess p)
        {
            DeleteCharacterButton.Enabled = true;
            MirMessageBox.Show("您的角色已成功删除，删除后不可恢复.");

            for (int i = 0; i < Characters.Count; i++)
                if (Characters[i].Index == p.CharacterIndex)
                {
                    Characters.RemoveAt(i);
                    break;
                }

            UpdateInterface();
        }

        private void StartGame(S.StartGameDelay p)
        {
            StartGameButton.Enabled = true;

            long time = CMain.Time + p.Milliseconds;

            MirMessageBox message = new MirMessageBox(string.Format("您不能再登录此角色{0}秒.", Math.Ceiling(p.Milliseconds / 1000M)));

            message.BeforeDraw += (o, e) => message.Label.Text = string.Format("您不能再登录此角色{0}秒.", Math.Ceiling((time - CMain.Time) / 1000M));


            message.AfterDraw += (o, e) =>
            {
                if (CMain.Time <= time) return;
                message.Dispose();
                StartGame();
            };

            message.Show();
        }
        public void StartGame(S.StartGameBanned p)
        {
            StartGameButton.Enabled = true;

            TimeSpan d = p.ExpiryDate - CMain.Now;
            MirMessageBox.Show(string.Format("这个帐号已被禁止的.\n\n原因: {0}\n到期日期: {1}\n剩余时间: {2:#,##0} 小时, {3} 分钟, {4} 秒", p.Reason,
                                             p.ExpiryDate, Math.Floor(d.TotalHours), d.Minutes, d.Seconds));
        }
        public void StartGame(S.StartGame p)
        {
            StartGameButton.Enabled = true;

            switch (p.Result)
            {
                case 0:
                    MirMessageBox.Show("启动游戏当前处于禁用状态.");
                    break;
                case 1:
                    MirMessageBox.Show("你没有登录.");
                    break;
                case 2:
                    MirMessageBox.Show("找不到你的角色.");
                    break;
                case 3:
                    MirMessageBox.Show("未找到可活动地图/或进入的起点.");
                    break;
                case 4:

                    if (p.Resolution < Settings.Resolution || Settings.Resolution == 0) Settings.Resolution = p.Resolution;

                    switch (Settings.Resolution)
                    {
                        default:
                        case 1024:
                            Settings.Resolution = 1024;
                            CMain.SetResolution(1280, 768);  //默认 1024，768 进入画面大小
                            break;
                        case 1280:
                            CMain.SetResolution(1280, 800);
                            break;
                        case 1366:
                            CMain.SetResolution(1366, 768);
                            break;
                        case 1920:
                            CMain.SetResolution(1920, 1080);
                            break;
                    }

                    ActiveScene = new GameScene();
                    Dispose();
                    break;
            }
        }
        private void UpdateInterface()
        {
            for (int i = 0; i < CharacterButtons.Length; i++)
            {
                CharacterButtons[i].Selected = i == _selected;
                CharacterButtons[i].Update(i >= Characters.Count ? null : Characters[i]);
            }

            if (_selected >= 0 && _selected < Characters.Count)
            {
                CharacterDisplay.Visible = true;
                //CharacterDisplay.Index = ((byte)Characters[_selected].Class + 1) * 20 + (byte)Characters[_selected].Gender * 280; 

                switch ((MirClass)Characters[_selected].Class)
                {
                    case MirClass.Warrior:
                        CharacterDisplay.Index = (byte)Characters[_selected].Gender == 0 ? 20 : 300; //220 : 500;
                        break;
                    case MirClass.Wizard:
                        CharacterDisplay.Index = (byte)Characters[_selected].Gender == 0 ? 40 : 320; //240 : 520;
                        break;
                    case MirClass.Taoist:
                        CharacterDisplay.Index = (byte)Characters[_selected].Gender == 0 ? 60 : 340; //260 : 540;
                        break;
                    case MirClass.Assassin:
                        CharacterDisplay.Index = (byte)Characters[_selected].Gender == 0 ? 80 : 360; //280 : 560;
                        break;
                    case MirClass.Archer:
                        CharacterDisplay.Index = (byte)Characters[_selected].Gender == 0 ? 100 : 140; //160 : 180;
                        break;
                }

                LastAccessLabel.Text = Characters[_selected].LastAccess == DateTime.MinValue ? "没有记录" : Characters[_selected].LastAccess.ToString();
                LastAccessLabel.Visible = true;
                LastAccessLabelLabel.Visible = true;
                StartGameButton.Enabled = true;
            }
            else
            {
                CharacterDisplay.Visible = false;
                LastAccessLabel.Visible = false;
                LastAccessLabelLabel.Visible = false;
                StartGameButton.Enabled = false;
            }
        }


        #region Disposable
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Background = null;
                _character = null;

                ServerLabel = null;
                CharacterDisplay = null;
                StartGameButton = null;
                NewCharacterButton = null;
                DeleteCharacterButton = null;
                CreditsButton = null;
                ExitGame = null;
                CharacterButtons = null;
                LastAccessLabel = null; LastAccessLabelLabel = null;
                Characters = null;
                _selected = 0;
            }

            base.Dispose(disposing);
        }
        #endregion
        public sealed class NewCharacterDialog : MirImageControl
        {                                                  //增加 \u0391-\uFFE5 支持建立角色时，支持非英文字符以外的其他文字
            private static readonly Regex Reg = new Regex(@"^[A-Za-z0-9-\u0391-\uFFE5]{" + Globals.MinCharacterNameLength + "," + Globals.MaxCharacterNameLength + "}$");

            public MirImageControl TitleLabel;
            public MirAnimatedControl CharacterDisplay;

            public MirButton OKButton,
                             CancelButton,
                             WarriorButton,
                             WizardButton,
                             TaoistButton,
                             AssassinButton,
                             ArcherButton,
                             MaleButton,
                             FemaleButton;

            public MirTextBox NameTextBox;

            public MirLabel Description;

            private MirClass _class;
            private MirGender _gender;

            #region Descriptions
            public const string WarriorDescription =
                "勇士是一个充满力量和活力的阶层。它们不容易在战斗中被杀死，并且具有能够使用的优势" +
                " 各种重型武器和盔甲。因此，战士喜欢基于近战物理伤害的攻击。他们的能力很弱" +
                " 然而，攻击是专门为战士开发的各种设备，补充了他们在远程作战中的弱点.";

            public const string WizardDescription =
                "魔法师是一个体力和耐力都很低的职业，但他们有使用强大法术的能力。他们的攻击法术非常有效，但是" +
                " 因为施放这些法术需要时间，它们很可能会让自己处于被敌人攻击的状态。因此，身体比较虚弱的魔法师" +
                " 必须瞄准敌人从安全距离攻击敌人.";

            public const string TaoistDescription =
                "道家在天文学、医学和其他方面都有很好的纪律性，除了穆公。而不是直接与敌人交战，他们的" +
                " 特长在于为盟友提供支持。道家可以召唤强大的生物，对魔法有很高的抵抗力，是一个职业" +
                " 具有良好的进攻和防守能力.";

            public const string AssassinDescription =
                "刺客是一个秘密组织的成员，他们的历史相对未知。他们能够隐藏自己并进行攻击" +
                " 在别人看不见的情况下，这自然使他们擅长快速杀戮。他们有必要避免与敌人交战" +
                " 由于生命力和力量较弱，有多个敌人.";

            public const string ArcherDescription =
                "弓箭手是一个非常精确和强大的职业，他们使用强大的弓箭技能在射程中造成非凡的伤害。很像" +
                " 作为巫师，他们依靠敏锐的直觉来躲避迎面而来的攻击，因为他们倾向于让自己面对正面攻击。然而，他们的" +
                " 身体的力量和致命的目标使他们能够向任何被他们击中的人灌输恐惧.";

            #endregion

            public NewCharacterDialog()
            {
                Index = 73;
                Library = Libraries.Prguse;
                Location = new Point((Settings.ScreenWidth - Size.Width) / 2, (Settings.ScreenHeight - Size.Height) / 2);
                Modal = true;

                TitleLabel = new MirImageControl
                {
                    Index = 20,
                    Library = Libraries.Title,
                    Location = new Point(206, 11),
                    Parent = this,
                };

                CancelButton = new MirButton
                {
                    HoverIndex = 281,
                    Index = 280,
                    Library = Libraries.Title,
                    Location = new Point(425, 425),
                    Parent = this,
                    PressedIndex = 282
                };
                CancelButton.Click += (o, e) => Dispose();


                OKButton = new MirButton
                {
                    Enabled = false,
                    HoverIndex = 361,
                    Index = 360,
                    Library = Libraries.Title,
                    Location = new Point(160, 425),
                    Parent = this,
                    PressedIndex = 362,
                };
                OKButton.Click += (o, e) => CreateCharacter();

                NameTextBox = new MirTextBox
                {
                    Location = new Point(325, 268),
                    Parent = this,
                    Size = new Size(240, 20),
                    MaxLength = Globals.MaxCharacterNameLength
                };
                NameTextBox.TextBox.KeyPress += TextBox_KeyPress;
                NameTextBox.TextBox.TextChanged += CharacterNameTextBox_TextChanged;
                NameTextBox.SetFocus();

                CharacterDisplay = new MirAnimatedControl
                {
                    Animated = true,
                    AnimationCount = 16,
                    AnimationDelay = 250,
                    Index = 20,
                    Library = Libraries.ChrSel,
                    Location = new Point(120, 250),
                    Parent = this,
                    UseOffSet = true,
                };
                CharacterDisplay.AfterDraw += (o, e) =>
                {
                    if (_class == MirClass.Wizard)
                        Libraries.ChrSel.DrawBlend(CharacterDisplay.Index + 560, CharacterDisplay.DisplayLocationWithoutOffSet, Color.White, true);
                };


                WarriorButton = new MirButton
                {
                    HoverIndex = 2427,
                    Index = 2427,
                    Library = Libraries.Prguse,
                    Location = new Point(323, 296),
                    Parent = this,
                    PressedIndex = 2428,
                    Sound = SoundList.ButtonA,
                };
                WarriorButton.Click += (o, e) =>
                {
                    _class = MirClass.Warrior;
                    UpdateInterface();
                };


                WizardButton = new MirButton
                {
                    HoverIndex = 2430,
                    Index = 2429,
                    Library = Libraries.Prguse,
                    Location = new Point(373, 296),
                    Parent = this,
                    PressedIndex = 2431,
                    Sound = SoundList.ButtonA,
                };
                WizardButton.Click += (o, e) =>
                {
                    _class = MirClass.Wizard;
                    UpdateInterface();
                };


                TaoistButton = new MirButton
                {
                    HoverIndex = 2433,
                    Index = 2432,
                    Library = Libraries.Prguse,
                    Location = new Point(423, 296),
                    Parent = this,
                    PressedIndex = 2434,
                    Sound = SoundList.ButtonA,
                };
                TaoistButton.Click += (o, e) =>
                {
                    _class = MirClass.Taoist;
                    UpdateInterface();
                };

                AssassinButton = new MirButton
                {
                    HoverIndex = 2436,
                    Index = 2435,
                    Library = Libraries.Prguse,
                    Location = new Point(473, 296),
                    Parent = this,
                    PressedIndex = 2437,
                    Sound = SoundList.ButtonA,
                };
                AssassinButton.Click += (o, e) =>
                {
                    _class = MirClass.Assassin;
                    UpdateInterface();
                };

                ArcherButton = new MirButton
                {
                    HoverIndex = 2439,
                    Index = 2438,
                    Library = Libraries.Prguse,
                    Location = new Point(523, 296),
                    Parent = this,
                    PressedIndex = 2440,
                    Sound = SoundList.ButtonA,
                };
                ArcherButton.Click += (o, e) =>
                {
                    _class = MirClass.Archer;
                    UpdateInterface();
                };


                MaleButton = new MirButton
                {
                    HoverIndex = 2421,
                    Index = 2421,
                    Library = Libraries.Prguse,
                    Location = new Point(323, 343),
                    Parent = this,
                    PressedIndex = 2422,
                    Sound = SoundList.ButtonA,
                };
                MaleButton.Click += (o, e) =>
                {
                    _gender = MirGender.Male;
                    UpdateInterface();
                };

                FemaleButton = new MirButton
                {
                    HoverIndex = 2424,
                    Index = 2423,
                    Library = Libraries.Prguse,
                    Location = new Point(373, 343),
                    Parent = this,
                    PressedIndex = 2425,
                    Sound = SoundList.ButtonA,
                };
                FemaleButton.Click += (o, e) =>
                {
                    _gender = MirGender.Female;
                    UpdateInterface();
                };

                Description = new MirLabel
                {
                    Border = true,
                    Location = new Point(279, 70),
                    Parent = this,
                    Size = new Size(278, 170),
                    Text = WarriorDescription,
                };
            }

            private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (sender == null) return;
                if (e.KeyChar != (char)Keys.Enter) return;
                e.Handled = true;

                if (OKButton.Enabled)
                    OKButton.InvokeMouseClick(null);
            }
            private void CharacterNameTextBox_TextChanged(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    OKButton.Enabled = false;
                    NameTextBox.Border = false;
                }
                else if (!Reg.IsMatch(NameTextBox.Text))
                {
                    OKButton.Enabled = false;
                    NameTextBox.Border = true;
                    NameTextBox.BorderColour = Color.Red;
                }
                else
                {
                    OKButton.Enabled = true;
                    NameTextBox.Border = true;
                    NameTextBox.BorderColour = Color.Green;
                }
            }

            private void CreateCharacter()
            {
                OKButton.Enabled = false;

                Network.Enqueue(new C.NewCharacter
                {
                    Name = NameTextBox.Text,
                    Class = _class,
                    Gender = _gender
                });
            }

            private void UpdateInterface()
            {
                MaleButton.Index = 2420;
                FemaleButton.Index = 2423;

                WarriorButton.Index = 2426;
                WizardButton.Index = 2429;
                TaoistButton.Index = 2432;
                AssassinButton.Index = 2435;
                ArcherButton.Index = 2438;

                switch (_gender)
                {
                    case MirGender.Male:
                        MaleButton.Index = 2421;
                        break;
                    case MirGender.Female:
                        FemaleButton.Index = 2424;
                        break;
                }

                switch (_class)
                {
                    case MirClass.Warrior:
                        WarriorButton.Index = 2427;
                        Description.Text = WarriorDescription;
                        CharacterDisplay.Index = (byte)_gender == 0 ? 20 : 300; //220 : 500;
                        break;
                    case MirClass.Wizard:
                        WizardButton.Index = 2430;
                        Description.Text = WizardDescription;
                        CharacterDisplay.Index = (byte)_gender == 0 ? 40 : 320; //240 : 520;
                        break;
                    case MirClass.Taoist:
                        TaoistButton.Index = 2433;
                        Description.Text = TaoistDescription;
                        CharacterDisplay.Index = (byte)_gender == 0 ? 60 : 340; //260 : 540;
                        break;
                    case MirClass.Assassin:
                        AssassinButton.Index = 2436;
                        Description.Text = AssassinDescription;
                        CharacterDisplay.Index = (byte)_gender == 0 ? 80 : 360; //280 : 560;
                        break;
                    case MirClass.Archer:
                        ArcherButton.Index = 2439;
                        Description.Text = ArcherDescription;
                        CharacterDisplay.Index = (byte)_gender == 0 ? 100 : 140; //160 : 180;
                        break;
                }

                //CharacterDisplay.Index = ((byte)_class + 1) * 20 + (byte)_gender * 280;
            }
        }
        public sealed class CharacterButton : MirImageControl
        {
            public MirLabel NameLabel, LevelLabel, ClassLabel;
            public bool Selected;

            public CharacterButton()
            {
                Index = 44; //45 locked
                Library = Libraries.Prguse;
                Sound = SoundList.ButtonA;

                NameLabel = new MirLabel
                {
                    Location = new Point(107, 9),
                    Parent = this,
                    NotControl = true,
                    Size = new Size(170, 18)
                };

                LevelLabel = new MirLabel
                {
                    Location = new Point(107, 28),
                    Parent = this,
                    NotControl = true,
                    Size = new Size(30, 18)
                };

                ClassLabel = new MirLabel
                {
                    Location = new Point(178, 28),
                    Parent = this,
                    NotControl = true,
                    Size = new Size(100, 18)
                };
            }

            public void Update(SelectInfo info)
            {
                if (info == null)
                {
                    Index = 44;
                    Library = Libraries.Prguse;
                    NameLabel.Text = string.Empty;
                    LevelLabel.Text = string.Empty;
                    ClassLabel.Text = string.Empty;

                    NameLabel.Visible = false;
                    LevelLabel.Visible = false;
                    ClassLabel.Visible = false;

                    return;
                }

                Library = Libraries.Title;

                Index = 660 + (byte)info.Class;

                if (Selected) Index += 5;


                NameLabel.Text = info.Name;
                LevelLabel.Text = info.Level.ToString();
                ClassLabel.Text = info.Class.ToString();

                NameLabel.Visible = true;
                LevelLabel.Visible = true;
                ClassLabel.Visible = true;
            }
        }
    }
}
