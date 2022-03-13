using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.MirControls;
using Client.MirGraphics;
using Client.MirNetwork;
using Client.MirObjects;
using Client.MirSounds;
using S = ServerPackets;
using C = ClientPackets;

namespace Client.MirScenes.Dialogs
{
    public sealed class HelpDialog : MirImageControl
    {
        public List<HelpPage> Pages = new List<HelpPage>();

        public MirButton CloseButton, NextButton, PreviousButton;
        public MirLabel PageLabel;
        public HelpPage CurrentPage;

        public int CurrentPageNumber = 0;

        public HelpDialog()
        {
            Index = 920;
            Library = Libraries.Prguse;
            Movable = true;
            Sort = true;

            Location = Center;

            MirImageControl TitleLabel = new MirImageControl
            {
                Index = 57,
                Library = Libraries.Title,
                Location = new Point(18, 9),
                Parent = this
            };

            PreviousButton = new MirButton
            {
                Index = 240,
                HoverIndex = 241,
                PressedIndex = 242,
                Library = Libraries.Prguse2,
                Parent = this,
                Size = new Size(16, 16),
                Location = new Point(210, 485),
                Sound = SoundList.ButtonA,
            };
            PreviousButton.Click += (o, e) =>
            {
                CurrentPageNumber--;

                if (CurrentPageNumber < 0) CurrentPageNumber = Pages.Count - 1;

                DisplayPage(CurrentPageNumber);
            };

            NextButton = new MirButton
            {
                Index = 243,
                HoverIndex = 244,
                PressedIndex = 245,
                Library = Libraries.Prguse2,
                Parent = this,
                Size = new Size(16, 16),
                Location = new Point(310, 485),
                Sound = SoundList.ButtonA,
            };
            NextButton.Click += (o, e) =>
            {
                CurrentPageNumber++;

                if (CurrentPageNumber > Pages.Count - 1) CurrentPageNumber = 0;

                DisplayPage(CurrentPageNumber);
            };

            PageLabel = new MirLabel
            {
                Text = "",
                Font = new Font(Settings.FontName, 9F),
                DrawFormat = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter,
                Parent = this,
                NotControl = true,
                Location = new Point(230, 480),
                Size = new Size(80, 20)
            };

            CloseButton = new MirButton
            {
                HoverIndex = 361,
                Index = 360,
                Location = new Point(509, 3),
                Library = Libraries.Prguse2,
                Parent = this,
                PressedIndex = 362,
                Sound = SoundList.ButtonA,
            };
            CloseButton.Click += (o, e) => Hide();

            LoadImagePages();

            DisplayPage();
        }

        private void LoadImagePages()
        {
            Point location = new Point(12, 35);

            Dictionary<string, string> keybinds = new Dictionary<string, string>();

            List<HelpPage> imagePages = new List<HelpPage> { 
                new HelpPage("快捷键设置信息", -1, new ShortcutPage1 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("快捷键设置信息", -1, new ShortcutPage2 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("聊天快捷方式", -1, new ShortcutPage3 { Parent = this } ) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("移动行走示例", 0, null) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("主动攻击方式", 1, null) { Parent = this, Location = location, Visible = false }, 
                new HelpPage("拾取挖取物品", 2, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("使用补充类物品", 3, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("学习设置技能", 4, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("技能施展攻击", 5, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("补充魔法药品", 6, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("聊天对话", 7, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("组队好友", 8, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("装备持久提示", 9, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("购买物品", 10, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("出售交易物品", 11, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("修理修补装备", 12, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("买卖交易物品", 13, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("查看他人信息", 14, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 15, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 16, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 17, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 18, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 19, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("个人及装备信息", 20, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("任务接取递交查看", 21, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("任务接取递交查看", 22, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("任务接取递交查看", 23, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("任务接取递交查看", 24, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("坐骑相关使用", 25, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("坐骑装备使用", 26, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("钓鱼系统", 27, null) { Parent = this, Location = location, Visible = false },
                new HelpPage("装备宝石镶嵌", 28, null) { Parent = this, Location = location, Visible = false },
            };

            Pages.AddRange(imagePages);
        }


        public void DisplayPage(string pageName)
        {
            if (Pages.Count < 1) return;

            for (int i = 0; i < Pages.Count; i++)
            {
                if (Pages[i].Title.ToLower() != pageName.ToLower()) continue;

                DisplayPage(i);
                break;
            }
        }

        public void DisplayPage(int id = 0)
        {
            if (Pages.Count < 1) return;

            if (id > Pages.Count - 1) id = Pages.Count - 1;
            if (id < 0) id = 0;

            if (CurrentPage != null)
            {
                CurrentPage.Visible = false;
                if (CurrentPage.Page != null) CurrentPage.Page.Visible = false;
            }

            CurrentPage = Pages[id];

            if (CurrentPage == null) return;

            CurrentPage.Visible = true;
            if (CurrentPage.Page != null) CurrentPage.Page.Visible = true;
            CurrentPageNumber = id;

            CurrentPage.PageTitleLabel.Text = id + 1 + ". " + CurrentPage.Title;

            PageLabel.Text = string.Format("{0} / {1}", id + 1, Pages.Count);

            Show();
        }


        public void Toggle()
        {
            if (!Visible)
                Show();
            else
                Hide();
        }
    }

    public class ShortcutPage1 : ShortcutInfoPage
    {
        public ShortcutPage1()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Exit), "退出游戏"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Logout), "退出当前角色"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Bar1Skill1) + "-" + CMain.InputKeys.GetKey(KeybindOptions.Bar1Skill8), "技能按钮"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Inventory), "查看背包窗口（打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Equipment), "个人状态窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Skills), "技能条显示 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Group), "组队窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Trade), "交易窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Friends), "好友窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Minimap), "小地图显示 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Guilds), "工会窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.GameShop), "游戏商店 （打开/关闭）"));
            //Shortcuts.Add(new ShortcutInfo("K", "游戏排行榜 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Relationship), "夫妻结婚窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Belt), "物品快捷栏 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Options), "游戏设置窗口 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Help), "打开帮助 （打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Mount), "坐骑 / 上下坐骑"));

            LoadKeyBinds();
        }
    }
    public class ShortcutPage2 : ShortcutInfoPage
    {
        public ShortcutPage2()
        {
            Shortcuts = new List<ShortcutInfo>();
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.ChangePetmode), "切换宠物攻击模式"));
            //Shortcuts.Add(new ShortcutInfo("Ctrl + F", "Change the font in the chat box"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.ChangeAttackmode), "切换玩家攻击模式"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.AttackmodePeace), "和平模式-只攻击怪物"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.AttackmodeGroup), "小组模式-攻击除小组成员以外的所有玩家"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.AttackmodeGuild), "公会模式-攻击除公会成员以外的所玩家"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.AttackmodeRedbrown), "善/恶模式-只攻击PK的玩家和怪物"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.AttackmodeAll), "所有攻击模式-攻击所有对象"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Bigmap), "显示所在位置大地图"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Skillbar), "显示技能栏"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Autorun), "自动跟随跑步前进，不需要按住鼠标右键跑步前进。 开/关"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Cameramode), "显示/隐藏所有操作界面，只显示画面，适合截图录像等"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Pickup), "拾取/地面脚下的物品，或切换技能栏需设置。"));
            Shortcuts.Add(new ShortcutInfo("Ctrl + 鼠标右键", "查看其他玩家装备界面"));
            //Shortcuts.Add(new ShortcutInfo("F12", "聊天宏"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Screenshot), "屏幕抓图"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Fishing), "打开/关闭钓鱼窗口"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.Mentor), "师徒系统（打开/关闭）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.CreaturePickup), "宠物拾取（多鼠标目标）"));
            Shortcuts.Add(new ShortcutInfo(CMain.InputKeys.GetKey(KeybindOptions.CreatureAutoPickup), "宠物拾取（单鼠标目标）)"));

            LoadKeyBinds();
        }
    }
    public class ShortcutPage3 : ShortcutInfoPage
    {
        public ShortcutPage3()
        {
            Shortcuts = new List<ShortcutInfo>();
            //Shortcuts.Add(new ShortcutInfo("` / Ctrl", "更改技能栏"));
            Shortcuts.Add(new ShortcutInfo("/(他人名字)", "和他人发送私密对话"));
            Shortcuts.Add(new ShortcutInfo("!(内容)", "向附近的人喊话"));
            Shortcuts.Add(new ShortcutInfo("!~(内容)", "行会聊天"));

            LoadKeyBinds();
        }
    }

    public class ShortcutInfo
    {
        public string Shortcut { get; set; }
        public string Information { get; set; }

        public ShortcutInfo(string shortcut, string info)
        {
            Shortcut = shortcut.Replace("\n", " + ");
            Information = info;
        }
    }

    public class ShortcutInfoPage : MirControl
    {
        protected List<ShortcutInfo> Shortcuts = new List<ShortcutInfo>();

        public ShortcutInfoPage()
        {
            Visible = false;

            MirLabel shortcutTitleLabel = new MirLabel
            {
                Text = "快捷菜单",
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                ForeColour = Color.White,
                Font = new Font(Settings.FontName, 10F),
                Parent = this,
                AutoSize = true,
                Location = new Point(13, 75),
                Size = new Size(100, 30)
            };

            MirLabel infoTitleLabel = new MirLabel
            {
                Text = "信息",
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                ForeColour = Color.White,
                Font = new Font(Settings.FontName, 10F),
                Parent = this,
                AutoSize = true,
                Location = new Point(114, 75),
                Size = new Size(405, 30)
            };
        }

        public void LoadKeyBinds()
        {
            if (Shortcuts == null) return;

            for (int i = 0; i < Shortcuts.Count; i++)
            {
                MirLabel shortcutLabel = new MirLabel
                {
                    Text = Shortcuts[i].Shortcut,
                    ForeColour = Color.Yellow,
                    DrawFormat = TextFormatFlags.VerticalCenter,
                    Font = new Font(Settings.FontName, 9F),
                    Parent = this,
                    AutoSize = true,
                    Location = new Point(18, 107 + (20 * i)),
                    Size = new Size(95, 23),
                };

                MirLabel informationLabel = new MirLabel
                {
                    Text = Shortcuts[i].Information,
                    DrawFormat = TextFormatFlags.VerticalCenter,
                    ForeColour = Color.White,
                    Font = new Font(Settings.FontName, 9F),
                    Parent = this,
                    AutoSize = true,
                    Location = new Point(119, 107 + (20 * i)),
                    Size = new Size(400, 23),
                };
            }  
        }
    }

    public class HelpPage : MirControl
    {
        public string Title;
        public int ImageID;
        public MirControl Page;

        public MirLabel PageTitleLabel;

        public HelpPage(string title, int imageID, MirControl page)
        {
            Title = title;
            ImageID = imageID;
            Page = page;

            NotControl = true;
            Size = new System.Drawing.Size(508, 396 + 40);

            BeforeDraw += HelpPage_BeforeDraw;

            PageTitleLabel = new MirLabel
            {
                Text = Title,
                Font = new Font(Settings.FontName, 10F, FontStyle.Bold),
                DrawFormat = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                Parent = this,
                Size = new System.Drawing.Size(242, 30),
                Location = new Point(135, 4)
            };
        }

        void HelpPage_BeforeDraw(object sender, EventArgs e)
        {
            if (ImageID < 0) return;

            Libraries.Help.Draw(ImageID, new Point(DisplayLocation.X, DisplayLocation.Y + 40), Color.White, false);
        }
    }
}
