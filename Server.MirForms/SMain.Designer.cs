using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    partial class SMain
    {
        /// <summary>
        /// 必需的设计器变量.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源.
        /// </summary>
        /// <param name="disposing">如果应处置托管资源，则为true；否则, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 设计器支持所需的方法-不修改
        /// 此方法的内容与代码编辑器一起使用。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DebugLogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GlobalMessageButton = new System.Windows.Forms.Button();
            this.GlobalMessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatLogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PlayersOnlineListView = new CustomFormControl.ListViewNF();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.PlayersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MonsterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CycleDelayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadNPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterExperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragonSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fishingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refiningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conquestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respawnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterTunerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // 主要标签
            // 
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Controls.Add(this.tabPage4);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 25);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(485, 313);
            this.MainTabs.TabIndex = 5;
            // 
            // 选项卡第1页
            // 
            this.tabPage1.Controls.Add(this.LogTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "监测日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 日志文本框
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(471, 281);
            this.LogTextBox.TabIndex = 2;
            // 
            // 选项卡第2页
            // 
            this.tabPage2.Controls.Add(this.DebugLogTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报错日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 调试日志文本框
            // 
            this.DebugLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugLogTextBox.Location = new System.Drawing.Point(3, 3);
            this.DebugLogTextBox.Multiline = true;
            this.DebugLogTextBox.Name = "DebugLogTextBox";
            this.DebugLogTextBox.ReadOnly = true;
            this.DebugLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugLogTextBox.Size = new System.Drawing.Size(471, 281);
            this.DebugLogTextBox.TabIndex = 3;
            // 
            // 选项卡第3页
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.ChatLogTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "聊天日志";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // 分组框1
            // 
            this.groupBox1.Controls.Add(this.GlobalMessageButton);
            this.groupBox1.Controls.Add(this.GlobalMessageTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送服务器消息";
            // 
            // 全局消息按钮
            // 
            this.GlobalMessageButton.Location = new System.Drawing.Point(392, 13);
            this.GlobalMessageButton.Name = "GlobalMessageButton";
            this.GlobalMessageButton.Size = new System.Drawing.Size(73, 22);
            this.GlobalMessageButton.TabIndex = 0;
            this.GlobalMessageButton.Text = "发 送";
            this.GlobalMessageButton.UseVisualStyleBackColor = true;
            this.GlobalMessageButton.Click += new System.EventHandler(this.GlobalMessageButton_Click);
            // 
            // 消息框
            // 
            this.GlobalMessageTextBox.Location = new System.Drawing.Point(6, 16);
            this.GlobalMessageTextBox.Name = "GlobalMessageTextBox";
            this.GlobalMessageTextBox.Size = new System.Drawing.Size(380, 21);
            this.GlobalMessageTextBox.TabIndex = 0;
            // 
            // 聊天记录文本框
            // 
            this.ChatLogTextBox.Location = new System.Drawing.Point(3, 3);
            this.ChatLogTextBox.Multiline = true;
            this.ChatLogTextBox.Name = "ChatLogTextBox";
            this.ChatLogTextBox.ReadOnly = true;
            this.ChatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatLogTextBox.Size = new System.Drawing.Size(471, 249);
            this.ChatLogTextBox.TabIndex = 4;
            // 
            // 选项卡4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.PlayersOnlineListView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 287);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "在线玩家管理";
            // 
            // 玩家在线观看
            // 
            this.PlayersOnlineListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PlayersOnlineListView.BackColor = System.Drawing.SystemColors.Window;
            this.PlayersOnlineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.nameHeader,
            this.levelHeader,
            this.classHeader,
            this.genderHeader});
            this.PlayersOnlineListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersOnlineListView.FullRowSelect = true;
            this.PlayersOnlineListView.GridLines = true;
            this.PlayersOnlineListView.HideSelection = false;
            this.PlayersOnlineListView.Location = new System.Drawing.Point(3, 3);
            this.PlayersOnlineListView.Name = "PlayersOnlineListView";
            this.PlayersOnlineListView.Size = new System.Drawing.Size(471, 281);
            this.PlayersOnlineListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PlayersOnlineListView.TabIndex = 0;
            this.PlayersOnlineListView.UseCompatibleStateImageBehavior = false;
            this.PlayersOnlineListView.View = System.Windows.Forms.View.Details;
            this.PlayersOnlineListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PlayersOnlineListView_ColumnWidthChanging);
            this.PlayersOnlineListView.SelectedIndexChanged += new System.EventHandler(this.PlayersOnlineListView_SelectedIndexChanged);
            this.PlayersOnlineListView.DoubleClick += new System.EventHandler(this.PlayersOnlineListView_DoubleClick);
            // 
            // 索引头
            // 
            this.indexHeader.Text = "序号";
            this.indexHeader.Width = 71;
            // 
            // 名字头
            // 
            this.nameHeader.Text = "名字";
            this.nameHeader.Width = 93;
            // 
            // 等级标题
            // 
            this.levelHeader.Text = "等级";
            this.levelHeader.Width = 90;
            // 
            // 职业标题
            // 
            this.classHeader.Text = "职业";
            this.classHeader.Width = 100;
            // 
            // genderHeader
            // 
            this.genderHeader.Text = "性别";
            this.genderHeader.Width = 98;
            // 
            // 状态栏
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayersLabel,
            this.MonsterLabel,
            this.ConnectionsLabel,
            this.CycleDelayLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 338);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(485, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "statusStrip1";
            // 
            // 玩家标签
            // 
            this.PlayersLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(62, 21);
            this.PlayersLabel.Text = "玩家数: 0";
            // 
            // 怪物标签
            // 
            this.MonsterLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.MonsterLabel.Name = "MonsterLabel";
            this.MonsterLabel.Size = new System.Drawing.Size(62, 21);
            this.MonsterLabel.Text = "怪物数: 0";
            // 
            // 连接标签
            // 
            this.ConnectionsLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ConnectionsLabel.Name = "ConnectionsLabel";
            this.ConnectionsLabel.Size = new System.Drawing.Size(74, 21);
            this.ConnectionsLabel.Text = "网络连接: 0";
            // 
            // 循环播放标签
            // 
            this.CycleDelayLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.CycleDelayLabel.Name = "CycleDelayLabel";
            this.CycleDelayLabel.Size = new System.Drawing.Size(74, 21);
            this.CycleDelayLabel.Text = "循环延迟: 0";
            // 
            // 主菜单
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.databaseFormsToolStripMenuItem,
            this.configToolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(485, 25);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 控制工具条菜单项
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem,
            this.stopServerToolStripMenuItem,
            this.rebootServerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reloadNPCsToolStripMenuItem,
            this.reloadDropsToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeServerToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.controlToolStripMenuItem.Text = "服务控制";
            // 
            // 启动服务器工具条菜单项
            // 
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startServerToolStripMenuItem.Text = "启动服务";
            this.startServerToolStripMenuItem.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
            // 
            // 停止服务器工具条菜单项
            // 
            this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopServerToolStripMenuItem.Text = "暂停服务";
            this.stopServerToolStripMenuItem.Click += new System.EventHandler(this.stopServerToolStripMenuItem_Click);
            // 
            // 重新启动服务器工具条菜单项
            // 
            this.rebootServerToolStripMenuItem.Name = "rebootServerToolStripMenuItem";
            this.rebootServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebootServerToolStripMenuItem.Text = "重启服务器";
            this.rebootServerToolStripMenuItem.Click += new System.EventHandler(this.rebootServerToolStripMenuItem_Click);
            // 
            // 工具条菜单项1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 重新加载NPC工具条菜单项
            // 
            this.reloadNPCsToolStripMenuItem.Name = "reloadNPCsToolStripMenuItem";
            this.reloadNPCsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadNPCsToolStripMenuItem.Text = "重新加载NPC设置";
            this.reloadNPCsToolStripMenuItem.Click += new System.EventHandler(this.reloadNPCsToolStripMenuItem_Click);
            // 
            // 重新加载爆率菜单项
            // 
            this.reloadDropsToolStripMenuItem.Name = "reloadDropsToolStripMenuItem";
            this.reloadDropsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadDropsToolStripMenuItem.Text = "重新加载爆率参数";
            this.reloadDropsToolStripMenuItem.Click += new System.EventHandler(this.reloadDropsToolStripMenuItem_Click);
            // 
            // 工具条分离器1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 关闭服务器工具条菜单项
            // 
            this.closeServerToolStripMenuItem.Name = "closeServerToolStripMenuItem";
            this.closeServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeServerToolStripMenuItem.Text = "关闭服务器程序";
            this.closeServerToolStripMenuItem.Click += new System.EventHandler(this.closeServerToolStripMenuItem_Click);
            // 
            // 帐户工具条菜单项
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.accountToolStripMenuItem.Text = "账户管理";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // 数据库窗体工具条菜单项
            // 
            this.databaseFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapInfoToolStripMenuItem,
            this.itemInfoToolStripMenuItem,
            this.monsterInfoToolStripMenuItem,
            this.nPCInfoToolStripMenuItem,
            this.questInfoToolStripMenuItem,
            this.magicInfoToolStripMenuItem,
            this.gameshopToolStripMenuItem,
            this.itemNEWToolStripMenuItem,
            this.monsterExperimentalToolStripMenuItem});
            this.databaseFormsToolStripMenuItem.Name = "databaseFormsToolStripMenuItem";
            this.databaseFormsToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.databaseFormsToolStripMenuItem.Text = "数据库管理";
            // 
            // 地图信息工具条菜单项
            // 
            this.mapInfoToolStripMenuItem.Name = "mapInfoToolStripMenuItem";
            this.mapInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mapInfoToolStripMenuItem.Text = "地图参数设置";
            this.mapInfoToolStripMenuItem.Click += new System.EventHandler(this.mapInfoToolStripMenuItem_Click);
            // 
            // 项目信息工具条菜单项
            // 
            this.itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            this.itemInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemInfoToolStripMenuItem.Text = "物品数据管理";
            this.itemInfoToolStripMenuItem.Click += new System.EventHandler(this.itemInfoToolStripMenuItem_Click);
            // 
            // 怪物信息工具条菜单项
            // 
            this.monsterInfoToolStripMenuItem.Name = "monsterInfoToolStripMenuItem";
            this.monsterInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monsterInfoToolStripMenuItem.Text = "怪物参数设置";
            this.monsterInfoToolStripMenuItem.Click += new System.EventHandler(this.monsterInfoToolStripMenuItem_Click);
            // 
            // NPC信息工具条菜单项
            // 
            this.nPCInfoToolStripMenuItem.Name = "nPCInfoToolStripMenuItem";
            this.nPCInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPCInfoToolStripMenuItem.Text = "配置管理NPC";
            this.nPCInfoToolStripMenuItem.Click += new System.EventHandler(this.nPCInfoToolStripMenuItem_Click);
            // 
            // 此信息工具条菜单项
            // 
            this.questInfoToolStripMenuItem.Name = "questInfoToolStripMenuItem";
            this.questInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.questInfoToolStripMenuItem.Text = "任务设定管理";
            this.questInfoToolStripMenuItem.Click += new System.EventHandler(this.questInfoToolStripMenuItem_Click);
            // 
            // 魔法信息工具条菜单项
            // 
            this.magicInfoToolStripMenuItem.Name = "magicInfoToolStripMenuItem";
            this.magicInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.magicInfoToolStripMenuItem.Text = "技能数据设置";
            this.magicInfoToolStripMenuItem.Click += new System.EventHandler(this.magicInfoToolStripMenuItem_Click);
            // 
            // 游戏商店工具条菜单项
            // 
            this.gameshopToolStripMenuItem.Name = "gameshopToolStripMenuItem";
            this.gameshopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameshopToolStripMenuItem.Text = "游戏商店管理";
            this.gameshopToolStripMenuItem.Click += new System.EventHandler(this.gameshopToolStripMenuItem_Click);
            // 
            // 物品工具条菜单项
            // 
            this.itemNEWToolStripMenuItem.Name = "itemNEWToolStripMenuItem";
            this.itemNEWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemNEWToolStripMenuItem.Text = "物品数据管理";
            this.itemNEWToolStripMenuItem.Click += new System.EventHandler(this.itemNEWToolStripMenuItem_Click);
            // 
            // 怪物管理数据库工具条菜单项
            // 
            this.monsterExperimentalToolStripMenuItem.Name = "monsterExperimentalToolStripMenuItem";
            this.monsterExperimentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monsterExperimentalToolStripMenuItem.Text = "怪物数据库管理";
            this.monsterExperimentalToolStripMenuItem.Click += new System.EventHandler(this.monsterExperimentalToolStripMenuItem_Click);
            // 
            // 配置工具条菜单项1
            // 
            this.configToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.monsterTunerToolStripMenuItem});
            this.configToolStripMenuItem1.Name = "configToolStripMenuItem1";
            this.configToolStripMenuItem1.Size = new System.Drawing.Size(80, 21);
            this.configToolStripMenuItem1.Text = "服务器配置";
            // 
            // 系统工具条菜单项
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragonSystemToolStripMenuItem,
            this.miningToolStripMenuItem,
            this.guildsToolStripMenuItem,
            this.fishingToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.refiningToolStripMenuItem,
            this.relationshipToolStripMenuItem,
            this.mentorToolStripMenuItem,
            this.gemToolStripMenuItem,
            this.conquestToolStripMenuItem,
            this.respawnsToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.systemToolStripMenuItem.Text = "功能参数设置";
            // 
            // 龙的系统工具条菜单项
            // 
            this.dragonSystemToolStripMenuItem.Name = "dragonSystemToolStripMenuItem";
            this.dragonSystemToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dragonSystemToolStripMenuItem.Text = "火龙设定";
            this.dragonSystemToolStripMenuItem.Click += new System.EventHandler(this.dragonSystemToolStripMenuItem_Click);
            // 
            // 最小化工具条菜单项
            // 
            this.miningToolStripMenuItem.Name = "miningToolStripMenuItem";
            this.miningToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.miningToolStripMenuItem.Text = "挖矿设定";
            this.miningToolStripMenuItem.Click += new System.EventHandler(this.miningToolStripMenuItem_Click);
            // 
            // 公会工具条菜单项
            // 
            this.guildsToolStripMenuItem.Name = "guildsToolStripMenuItem";
            this.guildsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.guildsToolStripMenuItem.Text = "工会管理";
            this.guildsToolStripMenuItem.Click += new System.EventHandler(this.guildsToolStripMenuItem_Click);
            // 
            // 钓鱼工具条菜单项
            // 
            this.fishingToolStripMenuItem.Name = "fishingToolStripMenuItem";
            this.fishingToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fishingToolStripMenuItem.Text = "钓鱼系统";
            this.fishingToolStripMenuItem.Click += new System.EventHandler(this.fishingToolStripMenuItem_Click);
            // 
            // 邮件工具条菜单
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mailToolStripMenuItem.Text = "邮件设定";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // 商品工具条菜单项
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.goodsToolStripMenuItem.Text = "商店设置";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // 精炼工具条菜单项
            // 
            this.refiningToolStripMenuItem.Name = "refiningToolStripMenuItem";
            this.refiningToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.refiningToolStripMenuItem.Text = "升级精炼";
            this.refiningToolStripMenuItem.Click += new System.EventHandler(this.refiningToolStripMenuItem_Click);
            // 
            // 关系工具条菜单项
            // 
            this.relationshipToolStripMenuItem.Name = "relationshipToolStripMenuItem";
            this.relationshipToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.relationshipToolStripMenuItem.Text = "关系系统";
            this.relationshipToolStripMenuItem.Click += new System.EventHandler(this.relationshipToolStripMenuItem_Click);
            // 
            // 导师条菜单项mentor
            // 
            this.mentorToolStripMenuItem.Name = "mentorToolStripMenuItem";
            this.mentorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mentorToolStripMenuItem.Text = "拜师设置";
            this.mentorToolStripMenuItem.Click += new System.EventHandler(this.mentorToolStripMenuItem_Click);
            // 
            // 宝石系统工具条菜单项
            // 
            this.gemToolStripMenuItem.Name = "gemToolStripMenuItem";
            this.gemToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.gemToolStripMenuItem.Text = "宝石系统";
            this.gemToolStripMenuItem.Click += new System.EventHandler(this.gemToolStripMenuItem_Click);
            // 
            // 攻城战工具条菜单项
            // 
            this.conquestToolStripMenuItem.Name = "conquestToolStripMenuItem";
            this.conquestToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.conquestToolStripMenuItem.Text = "城堡设置";
            this.conquestToolStripMenuItem.Click += new System.EventHandler(this.conquestToolStripMenuItem_Click);
            // 
            // 复活工具条菜单项
            // 
            this.respawnsToolStripMenuItem.Name = "respawnsToolStripMenuItem";
            this.respawnsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.respawnsToolStripMenuItem.Text = "SpawnTick";
            this.respawnsToolStripMenuItem.Click += new System.EventHandler(this.respawnsToolStripMenuItem_Click);
            // 
            // 服务器工具菜单
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serverToolStripMenuItem.Text = "网络参数配置";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // 平衡工具条菜单
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balanceToolStripMenuItem.Text = "游戏平衡配置";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // 怪物调谐器工具条菜单
            // 
            this.monsterTunerToolStripMenuItem.Name = "monsterTunerToolStripMenuItem";
            this.monsterTunerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monsterTunerToolStripMenuItem.Text = "怪物数据调整";
            this.monsterTunerToolStripMenuItem.Click += new System.EventHandler(this.monsterTunerToolStripMenuItem_Click);
            // 
            // 界面分子
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // 菜单条
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 364);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SMain";
            this.Text = "ZK游戏服务系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMain_FormClosing);
            this.Load += new System.EventHandler(this.SMain_Load);
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl MainTabs;
        private TabPage tabPage1;
        private TextBox LogTextBox;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel PlayersLabel;
        private ToolStripStatusLabel MonsterLabel;
        private ToolStripStatusLabel ConnectionsLabel;
        private MenuStrip MainMenu;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem startServerToolStripMenuItem;
        private ToolStripMenuItem stopServerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem closeServerToolStripMenuItem;
        private Timer InterfaceTimer;
        private TabPage tabPage2;
        private TextBox DebugLogTextBox;
        private TabPage tabPage3;
        private TextBox ChatLogTextBox;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem databaseFormsToolStripMenuItem;
        private ToolStripMenuItem mapInfoToolStripMenuItem;
        private ToolStripMenuItem itemInfoToolStripMenuItem;
        private ToolStripMenuItem monsterInfoToolStripMenuItem;
        private ToolStripMenuItem nPCInfoToolStripMenuItem;
        private ToolStripMenuItem questInfoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem1;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem dragonSystemToolStripMenuItem;
        private ToolStripMenuItem guildsToolStripMenuItem;
        private ToolStripMenuItem miningToolStripMenuItem;
        private ToolStripMenuItem fishingToolStripMenuItem;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private Button GlobalMessageButton;
        private TextBox GlobalMessageTextBox;
        private CustomFormControl.ListViewNF PlayersOnlineListView;
        private ColumnHeader nameHeader;
        private ColumnHeader levelHeader;
        private ColumnHeader classHeader;
        private ColumnHeader genderHeader;
        private ColumnHeader indexHeader;
        private ToolStripMenuItem mailToolStripMenuItem;
        private ToolStripMenuItem goodsToolStripMenuItem;
        private ToolStripStatusLabel CycleDelayLabel;
        private ToolStripMenuItem magicInfoToolStripMenuItem;
        private ToolStripMenuItem refiningToolStripMenuItem;
        private ToolStripMenuItem relationshipToolStripMenuItem;
        private ToolStripMenuItem mentorToolStripMenuItem;
        private ToolStripMenuItem gameshopToolStripMenuItem;
        private ToolStripMenuItem gemToolStripMenuItem;
        private ToolStripMenuItem conquestToolStripMenuItem;
        private ToolStripMenuItem rebootServerToolStripMenuItem;
        private ToolStripMenuItem respawnsToolStripMenuItem;
        private ToolStripMenuItem monsterTunerToolStripMenuItem;
        private ToolStripMenuItem reloadNPCsToolStripMenuItem;
        private ToolStripMenuItem reloadDropsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itemNEWToolStripMenuItem;
        private ToolStripMenuItem monsterExperimentalToolStripMenuItem;
    }
}

