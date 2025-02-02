﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    partial class MapInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MapTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.MusicTextBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.MineComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BigMapTextBox = new System.Windows.Forms.TextBox();
            this.LightsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MapIndexTextBox = new System.Windows.Forms.TextBox();
            this.MiniMapTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MapNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.NoReincarnation = new System.Windows.Forms.CheckBox();
            this.NoTownTeleportCheckbox = new System.Windows.Forms.CheckBox();
            this.NoFightCheckbox = new System.Windows.Forms.CheckBox();
            this.NeedBridleCheckbox = new System.Windows.Forms.CheckBox();
            this.NoMountCheckbox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MapDarkLighttextBox = new System.Windows.Forms.TextBox();
            this.NoNamesCheckbox = new System.Windows.Forms.CheckBox();
            this.NoDropMonsterCheckbox = new System.Windows.Forms.CheckBox();
            this.NoDropPlayerCheckbox = new System.Windows.Forms.CheckBox();
            this.NoThrowItemCheckbox = new System.Windows.Forms.CheckBox();
            this.NoPositionCheckbox = new System.Windows.Forms.CheckBox();
            this.NoDrugCheckbox = new System.Windows.Forms.CheckBox();
            this.NoRecallCheckbox = new System.Windows.Forms.CheckBox();
            this.NoEscapeCheckbox = new System.Windows.Forms.CheckBox();
            this.NoRandomCheckbox = new System.Windows.Forms.CheckBox();
            this.LightningTextbox = new System.Windows.Forms.TextBox();
            this.FireTextbox = new System.Windows.Forms.TextBox();
            this.NoReconnectTextbox = new System.Windows.Forms.TextBox();
            this.LightningCheckbox = new System.Windows.Forms.CheckBox();
            this.FireCheckbox = new System.Windows.Forms.CheckBox();
            this.FightCheckbox = new System.Windows.Forms.CheckBox();
            this.NoReconnectCheckbox = new System.Windows.Forms.CheckBox();
            this.NoTeleportCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RemoveSZButton = new System.Windows.Forms.Button();
            this.AddSZButton = new System.Windows.Forms.Button();
            this.SafeZoneInfoPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.SZYTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SZXTextBox = new System.Windows.Forms.TextBox();
            this.StartPointCheckBox = new System.Windows.Forms.CheckBox();
            this.SafeZoneInfoListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RPasteButton = new System.Windows.Forms.Button();
            this.RCopyButton = new System.Windows.Forms.Button();
            this.RemoveRButton = new System.Windows.Forms.Button();
            this.AddRButton = new System.Windows.Forms.Button();
            this.RespawnInfoListBox = new System.Windows.Forms.ListBox();
            this.RespawnInfoPanel = new System.Windows.Forms.Panel();
            this.chkrespawnsave = new System.Windows.Forms.CheckBox();
            this.chkRespawnEnableTick = new System.Windows.Forms.CheckBox();
            this.Randomtextbox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.RoutePathTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.DirectionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MonsterInfoComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SpreadTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RYTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RXTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RemoveMButton = new System.Windows.Forms.Button();
            this.AddMButton = new System.Windows.Forms.Button();
            this.MovementInfoPanel = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.BigMapIconTextBox = new System.Windows.Forms.TextBox();
            this.ShowBigMapCheckBox = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ConquestComboBox = new System.Windows.Forms.ComboBox();
            this.NeedMoveMCheckBox = new System.Windows.Forms.CheckBox();
            this.NeedHoleMCheckBox = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DestMapComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DestYTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.DestXTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SourceYTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SourceXTextBox = new System.Windows.Forms.TextBox();
            this.MovementInfoListBox = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.MZDeletebutton = new System.Windows.Forms.Button();
            this.MZAddbutton = new System.Windows.Forms.Button();
            this.MineZonepanel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.MineZoneComboBox = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.MZYtextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.MZSizetextBox = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.MZXtextBox = new System.Windows.Forms.TextBox();
            this.MZListlistBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MapInfoListBox = new System.Windows.Forms.ListBox();
            this.PasteMapButton = new System.Windows.Forms.Button();
            this.CopyMapButton = new System.Windows.Forms.Button();
            this.ImportMapInfoButton = new System.Windows.Forms.Button();
            this.ExportMapInfoButton = new System.Windows.Forms.Button();
            this.ImportMongenButton = new System.Windows.Forms.Button();
            this.ExportMongenButton = new System.Windows.Forms.Button();
            this.VisualizerButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MapTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SafeZoneInfoPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.RespawnInfoPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.MovementInfoPanel.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.MineZonepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapTabs
            // 
            this.MapTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapTabs.Controls.Add(this.tabPage1);
            this.MapTabs.Controls.Add(this.tabPage6);
            this.MapTabs.Controls.Add(this.tabPage3);
            this.MapTabs.Controls.Add(this.tabPage2);
            this.MapTabs.Controls.Add(this.tabPage4);
            this.MapTabs.Controls.Add(this.tabPage7);
            this.MapTabs.Location = new System.Drawing.Point(207, 57);
            this.MapTabs.Name = "MapTabs";
            this.MapTabs.SelectedIndex = 0;
            this.MapTabs.Size = new System.Drawing.Size(540, 252);
            this.MapTabs.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.MusicTextBox);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.MineComboBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.BigMapTextBox);
            this.tabPage1.Controls.Add(this.LightsComboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MapIndexTextBox);
            this.tabPage1.Controls.Add(this.MiniMapTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.MapNameTextBox);
            this.tabPage1.Controls.Add(this.FileNameTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地图参数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "背景音乐:";
            // 
            // MusicTextBox
            // 
            this.MusicTextBox.Location = new System.Drawing.Point(82, 192);
            this.MusicTextBox.Name = "MusicTextBox";
            this.MusicTextBox.Size = new System.Drawing.Size(92, 21);
            this.MusicTextBox.TabIndex = 17;
            this.MusicTextBox.TextChanged += new System.EventHandler(this.MusicTextBox_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(20, 169);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 16;
            this.label33.Text = "挖矿机制:";
            // 
            // MineComboBox
            // 
            this.MineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MineComboBox.FormattingEnabled = true;
            this.MineComboBox.Location = new System.Drawing.Point(82, 166);
            this.MineComboBox.Name = "MineComboBox";
            this.MineComboBox.Size = new System.Drawing.Size(92, 20);
            this.MineComboBox.TabIndex = 15;
            this.MineComboBox.SelectedIndexChanged += new System.EventHandler(this.MineComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "大地图号:";
            // 
            // BigMapTextBox
            // 
            this.BigMapTextBox.Location = new System.Drawing.Point(82, 115);
            this.BigMapTextBox.MaxLength = 5;
            this.BigMapTextBox.Name = "BigMapTextBox";
            this.BigMapTextBox.Size = new System.Drawing.Size(37, 21);
            this.BigMapTextBox.TabIndex = 13;
            this.BigMapTextBox.TextChanged += new System.EventHandler(this.BigMapTextBox_TextChanged);
            // 
            // LightsComboBox
            // 
            this.LightsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LightsComboBox.FormattingEnabled = true;
            this.LightsComboBox.Location = new System.Drawing.Point(82, 141);
            this.LightsComboBox.Name = "LightsComboBox";
            this.LightsComboBox.Size = new System.Drawing.Size(92, 20);
            this.LightsComboBox.TabIndex = 11;
            this.LightsComboBox.SelectedIndexChanged += new System.EventHandler(this.LightsComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "地图光照:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "地图编号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "小地图号:";
            // 
            // MapIndexTextBox
            // 
            this.MapIndexTextBox.Location = new System.Drawing.Point(82, 14);
            this.MapIndexTextBox.Name = "MapIndexTextBox";
            this.MapIndexTextBox.ReadOnly = true;
            this.MapIndexTextBox.Size = new System.Drawing.Size(47, 21);
            this.MapIndexTextBox.TabIndex = 0;
            // 
            // MiniMapTextBox
            // 
            this.MiniMapTextBox.Location = new System.Drawing.Point(82, 89);
            this.MiniMapTextBox.MaxLength = 5;
            this.MiniMapTextBox.Name = "MiniMapTextBox";
            this.MiniMapTextBox.Size = new System.Drawing.Size(37, 21);
            this.MiniMapTextBox.TabIndex = 9;
            this.MiniMapTextBox.TextChanged += new System.EventHandler(this.MiniMapTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "地图文件名:";
            // 
            // MapNameTextBox
            // 
            this.MapNameTextBox.Location = new System.Drawing.Point(82, 65);
            this.MapNameTextBox.Name = "MapNameTextBox";
            this.MapNameTextBox.Size = new System.Drawing.Size(92, 21);
            this.MapNameTextBox.TabIndex = 2;
            this.MapNameTextBox.TextChanged += new System.EventHandler(this.MapNameTextBox_TextChanged);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(82, 41);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(47, 21);
            this.FileNameTextBox.TabIndex = 1;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "地图名称:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.NoReincarnation);
            this.tabPage6.Controls.Add(this.NoTownTeleportCheckbox);
            this.tabPage6.Controls.Add(this.NoFightCheckbox);
            this.tabPage6.Controls.Add(this.NeedBridleCheckbox);
            this.tabPage6.Controls.Add(this.NoMountCheckbox);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.MapDarkLighttextBox);
            this.tabPage6.Controls.Add(this.NoNamesCheckbox);
            this.tabPage6.Controls.Add(this.NoDropMonsterCheckbox);
            this.tabPage6.Controls.Add(this.NoDropPlayerCheckbox);
            this.tabPage6.Controls.Add(this.NoThrowItemCheckbox);
            this.tabPage6.Controls.Add(this.NoPositionCheckbox);
            this.tabPage6.Controls.Add(this.NoDrugCheckbox);
            this.tabPage6.Controls.Add(this.NoRecallCheckbox);
            this.tabPage6.Controls.Add(this.NoEscapeCheckbox);
            this.tabPage6.Controls.Add(this.NoRandomCheckbox);
            this.tabPage6.Controls.Add(this.LightningTextbox);
            this.tabPage6.Controls.Add(this.FireTextbox);
            this.tabPage6.Controls.Add(this.NoReconnectTextbox);
            this.tabPage6.Controls.Add(this.LightningCheckbox);
            this.tabPage6.Controls.Add(this.FireCheckbox);
            this.tabPage6.Controls.Add(this.FightCheckbox);
            this.tabPage6.Controls.Add(this.NoReconnectCheckbox);
            this.tabPage6.Controls.Add(this.NoTeleportCheckbox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(532, 226);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "地图属性";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // NoReincarnation
            // 
            this.NoReincarnation.AutoSize = true;
            this.NoReincarnation.Location = new System.Drawing.Point(15, 183);
            this.NoReincarnation.Name = "NoReincarnation";
            this.NoReincarnation.Size = new System.Drawing.Size(72, 16);
            this.NoReincarnation.TabIndex = 45;
            this.NoReincarnation.Text = "无法复生";
            this.NoReincarnation.UseVisualStyleBackColor = true;
            this.NoReincarnation.CheckedChanged += new System.EventHandler(this.NoReincarnation_CheckedChanged);
            // 
            // NoTownTeleportCheckbox
            // 
            this.NoTownTeleportCheckbox.AutoSize = true;
            this.NoTownTeleportCheckbox.Location = new System.Drawing.Point(340, 110);
            this.NoTownTeleportCheckbox.Name = "NoTownTeleportCheckbox";
            this.NoTownTeleportCheckbox.Size = new System.Drawing.Size(72, 16);
            this.NoTownTeleportCheckbox.TabIndex = 44;
            this.NoTownTeleportCheckbox.Text = "没有传送";
            this.NoTownTeleportCheckbox.UseVisualStyleBackColor = true;
            this.NoTownTeleportCheckbox.CheckedChanged += new System.EventHandler(this.NoTownTeleportCheckbox_CheckedChanged);
            // 
            // NoFightCheckbox
            // 
            this.NoFightCheckbox.AutoSize = true;
            this.NoFightCheckbox.Location = new System.Drawing.Point(174, 126);
            this.NoFightCheckbox.Name = "NoFightCheckbox";
            this.NoFightCheckbox.Size = new System.Drawing.Size(84, 16);
            this.NoFightCheckbox.TabIndex = 43;
            this.NoFightCheckbox.Text = "无法PK战斗";
            this.NoFightCheckbox.UseVisualStyleBackColor = true;
            this.NoFightCheckbox.CheckedChanged += new System.EventHandler(this.NoFightCheckbox_CheckedChanged);
            // 
            // NeedBridleCheckbox
            // 
            this.NeedBridleCheckbox.AutoSize = true;
            this.NeedBridleCheckbox.Location = new System.Drawing.Point(174, 148);
            this.NeedBridleCheckbox.Name = "NeedBridleCheckbox";
            this.NeedBridleCheckbox.Size = new System.Drawing.Size(108, 16);
            this.NeedBridleCheckbox.TabIndex = 42;
            this.NeedBridleCheckbox.Text = "坐骑需佩戴缰绳";
            this.NeedBridleCheckbox.UseVisualStyleBackColor = true;
            this.NeedBridleCheckbox.CheckedChanged += new System.EventHandler(this.NeedBridleCheckbox_CheckedChanged);
            // 
            // NoMountCheckbox
            // 
            this.NoMountCheckbox.AutoSize = true;
            this.NoMountCheckbox.Location = new System.Drawing.Point(174, 104);
            this.NoMountCheckbox.Name = "NoMountCheckbox";
            this.NoMountCheckbox.Size = new System.Drawing.Size(72, 16);
            this.NoMountCheckbox.TabIndex = 41;
            this.NoMountCheckbox.Text = "无法乘骑";
            this.NoMountCheckbox.UseVisualStyleBackColor = true;
            this.NoMountCheckbox.CheckedChanged += new System.EventHandler(this.NoMountCheckbox_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(338, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 40;
            this.label19.Text = "地图黑暗";
            // 
            // MapDarkLighttextBox
            // 
            this.MapDarkLighttextBox.Location = new System.Drawing.Point(443, 84);
            this.MapDarkLighttextBox.Name = "MapDarkLighttextBox";
            this.MapDarkLighttextBox.Size = new System.Drawing.Size(49, 21);
            this.MapDarkLighttextBox.TabIndex = 39;
            this.MapDarkLighttextBox.TextChanged += new System.EventHandler(this.MapDarkLighttextBox_TextChanged);
            // 
            // NoNamesCheckbox
            // 
            this.NoNamesCheckbox.AutoSize = true;
            this.NoNamesCheckbox.Location = new System.Drawing.Point(174, 82);
            this.NoNamesCheckbox.Name = "NoNamesCheckbox";
            this.NoNamesCheckbox.Size = new System.Drawing.Size(84, 16);
            this.NoNamesCheckbox.TabIndex = 38;
            this.NoNamesCheckbox.Text = "不显示名字";
            this.NoNamesCheckbox.UseVisualStyleBackColor = true;
            this.NoNamesCheckbox.CheckedChanged += new System.EventHandler(this.NoNamesCheckbox_CheckedChanged);
            // 
            // NoDropMonsterCheckbox
            // 
            this.NoDropMonsterCheckbox.AutoSize = true;
            this.NoDropMonsterCheckbox.Location = new System.Drawing.Point(174, 60);
            this.NoDropMonsterCheckbox.Name = "NoDropMonsterCheckbox";
            this.NoDropMonsterCheckbox.Size = new System.Drawing.Size(114, 16);
            this.NoDropMonsterCheckbox.TabIndex = 37;
            this.NoDropMonsterCheckbox.Text = "不掉装备 (怪物)";
            this.NoDropMonsterCheckbox.UseVisualStyleBackColor = true;
            this.NoDropMonsterCheckbox.CheckedChanged += new System.EventHandler(this.NoDropMonsterCheckbox_CheckedChanged);
            // 
            // NoDropPlayerCheckbox
            // 
            this.NoDropPlayerCheckbox.AutoSize = true;
            this.NoDropPlayerCheckbox.Location = new System.Drawing.Point(174, 38);
            this.NoDropPlayerCheckbox.Name = "NoDropPlayerCheckbox";
            this.NoDropPlayerCheckbox.Size = new System.Drawing.Size(114, 16);
            this.NoDropPlayerCheckbox.TabIndex = 36;
            this.NoDropPlayerCheckbox.Text = "不掉装备 (玩家)";
            this.NoDropPlayerCheckbox.UseVisualStyleBackColor = true;
            this.NoDropPlayerCheckbox.CheckedChanged += new System.EventHandler(this.NoDropPlayerCheckbox_CheckedChanged);
            // 
            // NoThrowItemCheckbox
            // 
            this.NoThrowItemCheckbox.AutoSize = true;
            this.NoThrowItemCheckbox.Location = new System.Drawing.Point(174, 16);
            this.NoThrowItemCheckbox.Name = "NoThrowItemCheckbox";
            this.NoThrowItemCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoThrowItemCheckbox.TabIndex = 35;
            this.NoThrowItemCheckbox.Text = "禁止投掷物品";
            this.NoThrowItemCheckbox.UseVisualStyleBackColor = true;
            this.NoThrowItemCheckbox.CheckedChanged += new System.EventHandler(this.NoThrowItemCheckbox_CheckedChanged);
            // 
            // NoPositionCheckbox
            // 
            this.NoPositionCheckbox.AutoSize = true;
            this.NoPositionCheckbox.Location = new System.Drawing.Point(15, 148);
            this.NoPositionCheckbox.Name = "NoPositionCheckbox";
            this.NoPositionCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoPositionCheckbox.TabIndex = 34;
            this.NoPositionCheckbox.Text = "无法使用探测";
            this.NoPositionCheckbox.UseVisualStyleBackColor = true;
            this.NoPositionCheckbox.CheckedChanged += new System.EventHandler(this.NoPositionCheckbox_CheckedChanged);
            // 
            // NoDrugCheckbox
            // 
            this.NoDrugCheckbox.AutoSize = true;
            this.NoDrugCheckbox.Location = new System.Drawing.Point(16, 126);
            this.NoDrugCheckbox.Name = "NoDrugCheckbox";
            this.NoDrugCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoDrugCheckbox.TabIndex = 33;
            this.NoDrugCheckbox.Text = "无法使用药品";
            this.NoDrugCheckbox.UseVisualStyleBackColor = true;
            this.NoDrugCheckbox.CheckedChanged += new System.EventHandler(this.NoDrugCheckbox_CheckedChanged);
            // 
            // NoRecallCheckbox
            // 
            this.NoRecallCheckbox.AutoSize = true;
            this.NoRecallCheckbox.Location = new System.Drawing.Point(16, 104);
            this.NoRecallCheckbox.Name = "NoRecallCheckbox";
            this.NoRecallCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoRecallCheckbox.TabIndex = 32;
            this.NoRecallCheckbox.Text = "无法记忆召唤";
            this.NoRecallCheckbox.UseVisualStyleBackColor = true;
            this.NoRecallCheckbox.CheckedChanged += new System.EventHandler(this.NoRecallCheckbox_CheckedChanged);
            // 
            // NoEscapeCheckbox
            // 
            this.NoEscapeCheckbox.AutoSize = true;
            this.NoEscapeCheckbox.Location = new System.Drawing.Point(16, 82);
            this.NoEscapeCheckbox.Name = "NoEscapeCheckbox";
            this.NoEscapeCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoEscapeCheckbox.TabIndex = 31;
            this.NoEscapeCheckbox.Text = "无法地牢逃脱";
            this.NoEscapeCheckbox.UseVisualStyleBackColor = true;
            this.NoEscapeCheckbox.CheckedChanged += new System.EventHandler(this.NoEscapeCheckbox_CheckedChanged);
            // 
            // NoRandomCheckbox
            // 
            this.NoRandomCheckbox.AutoSize = true;
            this.NoRandomCheckbox.Location = new System.Drawing.Point(16, 60);
            this.NoRandomCheckbox.Name = "NoRandomCheckbox";
            this.NoRandomCheckbox.Size = new System.Drawing.Size(96, 16);
            this.NoRandomCheckbox.TabIndex = 30;
            this.NoRandomCheckbox.Text = "无法使用随机";
            this.NoRandomCheckbox.UseVisualStyleBackColor = true;
            this.NoRandomCheckbox.CheckedChanged += new System.EventHandler(this.NoRandomCheckbox_CheckedChanged);
            // 
            // LightningTextbox
            // 
            this.LightningTextbox.Location = new System.Drawing.Point(443, 60);
            this.LightningTextbox.Name = "LightningTextbox";
            this.LightningTextbox.Size = new System.Drawing.Size(49, 21);
            this.LightningTextbox.TabIndex = 29;
            this.LightningTextbox.TextChanged += new System.EventHandler(this.LightningTextbox_TextChanged);
            // 
            // FireTextbox
            // 
            this.FireTextbox.Location = new System.Drawing.Point(443, 38);
            this.FireTextbox.Name = "FireTextbox";
            this.FireTextbox.Size = new System.Drawing.Size(49, 21);
            this.FireTextbox.TabIndex = 28;
            this.FireTextbox.TextChanged += new System.EventHandler(this.FireTextbox_TextChanged);
            // 
            // NoReconnectTextbox
            // 
            this.NoReconnectTextbox.Location = new System.Drawing.Point(109, 36);
            this.NoReconnectTextbox.Name = "NoReconnectTextbox";
            this.NoReconnectTextbox.Size = new System.Drawing.Size(49, 21);
            this.NoReconnectTextbox.TabIndex = 27;
            this.NoReconnectTextbox.TextChanged += new System.EventHandler(this.NoReconnectTextbox_TextChanged);
            // 
            // LightningCheckbox
            // 
            this.LightningCheckbox.AutoSize = true;
            this.LightningCheckbox.Location = new System.Drawing.Point(341, 60);
            this.LightningCheckbox.Name = "LightningCheckbox";
            this.LightningCheckbox.Size = new System.Drawing.Size(84, 16);
            this.LightningCheckbox.TabIndex = 26;
            this.LightningCheckbox.Text = "地图有闪电";
            this.LightningCheckbox.UseVisualStyleBackColor = true;
            this.LightningCheckbox.CheckedChanged += new System.EventHandler(this.LightningCheckbox_CheckedChanged);
            // 
            // FireCheckbox
            // 
            this.FireCheckbox.AutoSize = true;
            this.FireCheckbox.Location = new System.Drawing.Point(341, 38);
            this.FireCheckbox.Name = "FireCheckbox";
            this.FireCheckbox.Size = new System.Drawing.Size(72, 16);
            this.FireCheckbox.TabIndex = 25;
            this.FireCheckbox.Text = "地面喷火";
            this.FireCheckbox.UseVisualStyleBackColor = true;
            this.FireCheckbox.CheckStateChanged += new System.EventHandler(this.FireCheckbox_CheckStateChanged);
            // 
            // FightCheckbox
            // 
            this.FightCheckbox.AutoSize = true;
            this.FightCheckbox.Location = new System.Drawing.Point(341, 15);
            this.FightCheckbox.Name = "FightCheckbox";
            this.FightCheckbox.Size = new System.Drawing.Size(72, 16);
            this.FightCheckbox.TabIndex = 23;
            this.FightCheckbox.Text = "竞赛战斗";
            this.FightCheckbox.UseVisualStyleBackColor = true;
            this.FightCheckbox.CheckedChanged += new System.EventHandler(this.FightCheckbox_CheckedChanged);
            // 
            // NoReconnectCheckbox
            // 
            this.NoReconnectCheckbox.AutoSize = true;
            this.NoReconnectCheckbox.Location = new System.Drawing.Point(16, 38);
            this.NoReconnectCheckbox.Name = "NoReconnectCheckbox";
            this.NoReconnectCheckbox.Size = new System.Drawing.Size(72, 16);
            this.NoReconnectCheckbox.TabIndex = 22;
            this.NoReconnectCheckbox.Text = "掉线退出";
            this.NoReconnectCheckbox.UseVisualStyleBackColor = true;
            this.NoReconnectCheckbox.CheckedChanged += new System.EventHandler(this.NoReconnectCheckbox_CheckedChanged);
            // 
            // NoTeleportCheckbox
            // 
            this.NoTeleportCheckbox.AutoSize = true;
            this.NoTeleportCheckbox.Location = new System.Drawing.Point(16, 16);
            this.NoTeleportCheckbox.Name = "NoTeleportCheckbox";
            this.NoTeleportCheckbox.Size = new System.Drawing.Size(60, 16);
            this.NoTeleportCheckbox.TabIndex = 21;
            this.NoTeleportCheckbox.Text = "无传送";
            this.NoTeleportCheckbox.UseVisualStyleBackColor = true;
            this.NoTeleportCheckbox.CheckedChanged += new System.EventHandler(this.NoTeleportCheckbox_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RemoveSZButton);
            this.tabPage3.Controls.Add(this.AddSZButton);
            this.tabPage3.Controls.Add(this.SafeZoneInfoPanel);
            this.tabPage3.Controls.Add(this.SafeZoneInfoListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(532, 226);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "安全区域";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RemoveSZButton
            // 
            this.RemoveSZButton.Location = new System.Drawing.Point(108, 6);
            this.RemoveSZButton.Name = "RemoveSZButton";
            this.RemoveSZButton.Size = new System.Drawing.Size(75, 21);
            this.RemoveSZButton.TabIndex = 8;
            this.RemoveSZButton.Text = "Remove";
            this.RemoveSZButton.UseVisualStyleBackColor = true;
            this.RemoveSZButton.Click += new System.EventHandler(this.RemoveSZButton_Click);
            // 
            // AddSZButton
            // 
            this.AddSZButton.Location = new System.Drawing.Point(6, 6);
            this.AddSZButton.Name = "AddSZButton";
            this.AddSZButton.Size = new System.Drawing.Size(75, 21);
            this.AddSZButton.TabIndex = 7;
            this.AddSZButton.Text = "Add";
            this.AddSZButton.UseVisualStyleBackColor = true;
            this.AddSZButton.Click += new System.EventHandler(this.AddSZButton_Click);
            // 
            // SafeZoneInfoPanel
            // 
            this.SafeZoneInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SafeZoneInfoPanel.Controls.Add(this.label12);
            this.SafeZoneInfoPanel.Controls.Add(this.SZYTextBox);
            this.SafeZoneInfoPanel.Controls.Add(this.label14);
            this.SafeZoneInfoPanel.Controls.Add(this.SizeTextBox);
            this.SafeZoneInfoPanel.Controls.Add(this.label17);
            this.SafeZoneInfoPanel.Controls.Add(this.SZXTextBox);
            this.SafeZoneInfoPanel.Controls.Add(this.StartPointCheckBox);
            this.SafeZoneInfoPanel.Enabled = false;
            this.SafeZoneInfoPanel.Location = new System.Drawing.Point(189, 32);
            this.SafeZoneInfoPanel.Name = "SafeZoneInfoPanel";
            this.SafeZoneInfoPanel.Size = new System.Drawing.Size(197, 128);
            this.SafeZoneInfoPanel.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "Y:";
            // 
            // SZYTextBox
            // 
            this.SZYTextBox.Location = new System.Drawing.Point(147, 20);
            this.SZYTextBox.MaxLength = 5;
            this.SZYTextBox.Name = "SZYTextBox";
            this.SZYTextBox.Size = new System.Drawing.Size(37, 21);
            this.SZYTextBox.TabIndex = 3;
            this.SZYTextBox.TextChanged += new System.EventHandler(this.SZYTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "Size:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(61, 44);
            this.SizeTextBox.MaxLength = 5;
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(37, 21);
            this.SizeTextBox.TabIndex = 4;
            this.SizeTextBox.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "X:";
            // 
            // SZXTextBox
            // 
            this.SZXTextBox.Location = new System.Drawing.Point(61, 20);
            this.SZXTextBox.MaxLength = 5;
            this.SZXTextBox.Name = "SZXTextBox";
            this.SZXTextBox.Size = new System.Drawing.Size(37, 21);
            this.SZXTextBox.TabIndex = 2;
            this.SZXTextBox.TextChanged += new System.EventHandler(this.SZXTextBox_TextChanged);
            // 
            // StartPointCheckBox
            // 
            this.StartPointCheckBox.AutoSize = true;
            this.StartPointCheckBox.Location = new System.Drawing.Point(61, 82);
            this.StartPointCheckBox.Name = "StartPointCheckBox";
            this.StartPointCheckBox.Size = new System.Drawing.Size(90, 16);
            this.StartPointCheckBox.TabIndex = 5;
            this.StartPointCheckBox.Text = "Start Point";
            this.StartPointCheckBox.UseVisualStyleBackColor = true;
            this.StartPointCheckBox.CheckedChanged += new System.EventHandler(this.StartPointCheckBox_CheckedChanged);
            // 
            // SafeZoneInfoListBox
            // 
            this.SafeZoneInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SafeZoneInfoListBox.FormattingEnabled = true;
            this.SafeZoneInfoListBox.ItemHeight = 12;
            this.SafeZoneInfoListBox.Location = new System.Drawing.Point(6, 32);
            this.SafeZoneInfoListBox.Name = "SafeZoneInfoListBox";
            this.SafeZoneInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SafeZoneInfoListBox.Size = new System.Drawing.Size(177, 124);
            this.SafeZoneInfoListBox.TabIndex = 9;
            this.SafeZoneInfoListBox.SelectedIndexChanged += new System.EventHandler(this.SafeZoneInfoListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RPasteButton);
            this.tabPage2.Controls.Add(this.RCopyButton);
            this.tabPage2.Controls.Add(this.RemoveRButton);
            this.tabPage2.Controls.Add(this.AddRButton);
            this.tabPage2.Controls.Add(this.RespawnInfoListBox);
            this.tabPage2.Controls.Add(this.RespawnInfoPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "怪物攻城";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RPasteButton
            // 
            this.RPasteButton.Location = new System.Drawing.Point(270, 6);
            this.RPasteButton.Name = "RPasteButton";
            this.RPasteButton.Size = new System.Drawing.Size(75, 21);
            this.RPasteButton.TabIndex = 22;
            this.RPasteButton.Text = "粘 贴";
            this.RPasteButton.UseVisualStyleBackColor = true;
            this.RPasteButton.Click += new System.EventHandler(this.RPasteButton_Click);
            // 
            // RCopyButton
            // 
            this.RCopyButton.Location = new System.Drawing.Point(189, 6);
            this.RCopyButton.Name = "RCopyButton";
            this.RCopyButton.Size = new System.Drawing.Size(75, 21);
            this.RCopyButton.TabIndex = 21;
            this.RCopyButton.Text = "复 制";
            this.RCopyButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRButton
            // 
            this.RemoveRButton.Location = new System.Drawing.Point(108, 6);
            this.RemoveRButton.Name = "RemoveRButton";
            this.RemoveRButton.Size = new System.Drawing.Size(75, 21);
            this.RemoveRButton.TabIndex = 16;
            this.RemoveRButton.Text = "删 除";
            this.RemoveRButton.UseVisualStyleBackColor = true;
            this.RemoveRButton.Click += new System.EventHandler(this.RemoveRButton_Click);
            // 
            // AddRButton
            // 
            this.AddRButton.Location = new System.Drawing.Point(6, 6);
            this.AddRButton.Name = "AddRButton";
            this.AddRButton.Size = new System.Drawing.Size(75, 21);
            this.AddRButton.TabIndex = 15;
            this.AddRButton.Text = "添 加";
            this.AddRButton.UseVisualStyleBackColor = true;
            this.AddRButton.Click += new System.EventHandler(this.AddRButton_Click);
            // 
            // RespawnInfoListBox
            // 
            this.RespawnInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RespawnInfoListBox.FormattingEnabled = true;
            this.RespawnInfoListBox.ItemHeight = 12;
            this.RespawnInfoListBox.Location = new System.Drawing.Point(6, 32);
            this.RespawnInfoListBox.Name = "RespawnInfoListBox";
            this.RespawnInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RespawnInfoListBox.Size = new System.Drawing.Size(260, 136);
            this.RespawnInfoListBox.TabIndex = 14;
            this.RespawnInfoListBox.SelectedIndexChanged += new System.EventHandler(this.RespawnInfoListBox_SelectedIndexChanged);
            // 
            // RespawnInfoPanel
            // 
            this.RespawnInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RespawnInfoPanel.Controls.Add(this.chkrespawnsave);
            this.RespawnInfoPanel.Controls.Add(this.chkRespawnEnableTick);
            this.RespawnInfoPanel.Controls.Add(this.Randomtextbox);
            this.RespawnInfoPanel.Controls.Add(this.label23);
            this.RespawnInfoPanel.Controls.Add(this.label34);
            this.RespawnInfoPanel.Controls.Add(this.RoutePathTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label24);
            this.RespawnInfoPanel.Controls.Add(this.DirectionTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label8);
            this.RespawnInfoPanel.Controls.Add(this.DelayTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label7);
            this.RespawnInfoPanel.Controls.Add(this.MonsterInfoComboBox);
            this.RespawnInfoPanel.Controls.Add(this.label6);
            this.RespawnInfoPanel.Controls.Add(this.SpreadTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label9);
            this.RespawnInfoPanel.Controls.Add(this.RYTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label10);
            this.RespawnInfoPanel.Controls.Add(this.CountTextBox);
            this.RespawnInfoPanel.Controls.Add(this.label13);
            this.RespawnInfoPanel.Controls.Add(this.RXTextBox);
            this.RespawnInfoPanel.Enabled = false;
            this.RespawnInfoPanel.Location = new System.Drawing.Point(272, 32);
            this.RespawnInfoPanel.Name = "RespawnInfoPanel";
            this.RespawnInfoPanel.Size = new System.Drawing.Size(254, 189);
            this.RespawnInfoPanel.TabIndex = 11;
            // 
            // chkrespawnsave
            // 
            this.chkrespawnsave.AutoSize = true;
            this.chkrespawnsave.Location = new System.Drawing.Point(25, 101);
            this.chkrespawnsave.Name = "chkrespawnsave";
            this.chkrespawnsave.Size = new System.Drawing.Size(72, 16);
            this.chkrespawnsave.TabIndex = 25;
            this.chkrespawnsave.Text = "重启复生";
            this.chkrespawnsave.UseVisualStyleBackColor = true;
            this.chkrespawnsave.CheckedChanged += new System.EventHandler(this.chkrespawnsave_CheckedChanged);
            // 
            // chkRespawnEnableTick
            // 
            this.chkRespawnEnableTick.AutoSize = true;
            this.chkRespawnEnableTick.Location = new System.Drawing.Point(25, 85);
            this.chkRespawnEnableTick.Name = "chkRespawnEnableTick";
            this.chkRespawnEnableTick.Size = new System.Drawing.Size(150, 16);
            this.chkRespawnEnableTick.TabIndex = 24;
            this.chkRespawnEnableTick.Text = "Use tickbased respawn";
            this.chkRespawnEnableTick.UseVisualStyleBackColor = true;
            this.chkRespawnEnableTick.CheckedChanged += new System.EventHandler(this.chkRespawnEnableTick_CheckedChanged);
            // 
            // Randomtextbox
            // 
            this.Randomtextbox.Location = new System.Drawing.Point(158, 120);
            this.Randomtextbox.MaxLength = 10;
            this.Randomtextbox.Multiline = true;
            this.Randomtextbox.Name = "Randomtextbox";
            this.Randomtextbox.Size = new System.Drawing.Size(37, 19);
            this.Randomtextbox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.Randomtextbox, "Allows random + or - added to each spawn time");
            this.Randomtextbox.TextChanged += new System.EventHandler(this.RandomTextBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(135, 123);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 22;
            this.label23.Text = "R:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(22, 147);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 12);
            this.label34.TabIndex = 21;
            this.label34.Text = "路线:";
            // 
            // RoutePathTextBox
            // 
            this.RoutePathTextBox.Location = new System.Drawing.Point(65, 144);
            this.RoutePathTextBox.Name = "RoutePathTextBox";
            this.RoutePathTextBox.Size = new System.Drawing.Size(130, 21);
            this.RoutePathTextBox.TabIndex = 20;
            this.RoutePathTextBox.TextChanged += new System.EventHandler(this.RoutePathTextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 18;
            this.label24.Text = "终点:";
            // 
            // DirectionTextBox
            // 
            this.DirectionTextBox.Location = new System.Drawing.Point(65, 168);
            this.DirectionTextBox.MaxLength = 5;
            this.DirectionTextBox.Name = "DirectionTextBox";
            this.DirectionTextBox.Size = new System.Drawing.Size(37, 21);
            this.DirectionTextBox.TabIndex = 17;
            this.DirectionTextBox.TextChanged += new System.EventHandler(this.DirectionTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "延时:";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(65, 120);
            this.DelayTextBox.MaxLength = 10;
            this.DelayTextBox.Multiline = true;
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(62, 19);
            this.DelayTextBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.DelayTextBox, "if you use tick based spawn: this is ignored!");
            this.DelayTextBox.TextChanged += new System.EventHandler(this.DelayTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "怪物选择:";
            // 
            // MonsterInfoComboBox
            // 
            this.MonsterInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonsterInfoComboBox.FormattingEnabled = true;
            this.MonsterInfoComboBox.Location = new System.Drawing.Point(65, 12);
            this.MonsterInfoComboBox.Name = "MonsterInfoComboBox";
            this.MonsterInfoComboBox.Size = new System.Drawing.Size(130, 20);
            this.MonsterInfoComboBox.TabIndex = 13;
            this.MonsterInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.MonsterInfoComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "范围:";
            // 
            // SpreadTextBox
            // 
            this.SpreadTextBox.Location = new System.Drawing.Point(158, 61);
            this.SpreadTextBox.MaxLength = 5;
            this.SpreadTextBox.Name = "SpreadTextBox";
            this.SpreadTextBox.Size = new System.Drawing.Size(37, 21);
            this.SpreadTextBox.TabIndex = 11;
            this.SpreadTextBox.TextChanged += new System.EventHandler(this.SpreadTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "坐标Y:";
            // 
            // RYTextBox
            // 
            this.RYTextBox.Location = new System.Drawing.Point(158, 37);
            this.RYTextBox.MaxLength = 5;
            this.RYTextBox.Name = "RYTextBox";
            this.RYTextBox.Size = new System.Drawing.Size(37, 21);
            this.RYTextBox.TabIndex = 3;
            this.RYTextBox.TextChanged += new System.EventHandler(this.RYTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "数量:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(65, 61);
            this.CountTextBox.MaxLength = 5;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(37, 21);
            this.CountTextBox.TabIndex = 4;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "坐标X:";
            // 
            // RXTextBox
            // 
            this.RXTextBox.Location = new System.Drawing.Point(65, 37);
            this.RXTextBox.MaxLength = 5;
            this.RXTextBox.Name = "RXTextBox";
            this.RXTextBox.Size = new System.Drawing.Size(37, 21);
            this.RXTextBox.TabIndex = 2;
            this.RXTextBox.TextChanged += new System.EventHandler(this.RXTextBox_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RemoveMButton);
            this.tabPage4.Controls.Add(this.AddMButton);
            this.tabPage4.Controls.Add(this.MovementInfoPanel);
            this.tabPage4.Controls.Add(this.MovementInfoListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(532, 226);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "地图跨越";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RemoveMButton
            // 
            this.RemoveMButton.Location = new System.Drawing.Point(108, 6);
            this.RemoveMButton.Name = "RemoveMButton";
            this.RemoveMButton.Size = new System.Drawing.Size(75, 21);
            this.RemoveMButton.TabIndex = 12;
            this.RemoveMButton.Text = "删 除";
            this.RemoveMButton.UseVisualStyleBackColor = true;
            this.RemoveMButton.Click += new System.EventHandler(this.RemoveMButton_Click);
            // 
            // AddMButton
            // 
            this.AddMButton.Location = new System.Drawing.Point(6, 6);
            this.AddMButton.Name = "AddMButton";
            this.AddMButton.Size = new System.Drawing.Size(75, 21);
            this.AddMButton.TabIndex = 11;
            this.AddMButton.Text = "添 加";
            this.AddMButton.UseVisualStyleBackColor = true;
            this.AddMButton.Click += new System.EventHandler(this.AddMButton_Click);
            // 
            // MovementInfoPanel
            // 
            this.MovementInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovementInfoPanel.Controls.Add(this.label26);
            this.MovementInfoPanel.Controls.Add(this.BigMapIconTextBox);
            this.MovementInfoPanel.Controls.Add(this.ShowBigMapCheckBox);
            this.MovementInfoPanel.Controls.Add(this.label25);
            this.MovementInfoPanel.Controls.Add(this.ConquestComboBox);
            this.MovementInfoPanel.Controls.Add(this.NeedMoveMCheckBox);
            this.MovementInfoPanel.Controls.Add(this.NeedHoleMCheckBox);
            this.MovementInfoPanel.Controls.Add(this.label22);
            this.MovementInfoPanel.Controls.Add(this.DestMapComboBox);
            this.MovementInfoPanel.Controls.Add(this.label18);
            this.MovementInfoPanel.Controls.Add(this.DestYTextBox);
            this.MovementInfoPanel.Controls.Add(this.label21);
            this.MovementInfoPanel.Controls.Add(this.DestXTextBox);
            this.MovementInfoPanel.Controls.Add(this.label16);
            this.MovementInfoPanel.Controls.Add(this.SourceYTextBox);
            this.MovementInfoPanel.Controls.Add(this.label20);
            this.MovementInfoPanel.Controls.Add(this.SourceXTextBox);
            this.MovementInfoPanel.Enabled = false;
            this.MovementInfoPanel.Location = new System.Drawing.Point(239, 32);
            this.MovementInfoPanel.Name = "MovementInfoPanel";
            this.MovementInfoPanel.Size = new System.Drawing.Size(269, 189);
            this.MovementInfoPanel.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.label26.Location = new System.Drawing.Point(168, 165);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 23;
            this.label26.Text = "Icon:";
            // 
            // BigMapIconTextBox
            // 
            this.BigMapIconTextBox.Location = new System.Drawing.Point(207, 161);
            this.BigMapIconTextBox.MaxLength = 5;
            this.BigMapIconTextBox.Name = "BigMapIconTextBox";
            this.BigMapIconTextBox.Size = new System.Drawing.Size(37, 21);
            this.BigMapIconTextBox.TabIndex = 22;
            this.BigMapIconTextBox.TextChanged += new System.EventHandler(this.BigMapIconTextBox_TextChanged);
            // 
            // ShowBigMapCheckBox
            // 
            this.ShowBigMapCheckBox.AutoSize = true;
            this.ShowBigMapCheckBox.Location = new System.Drawing.Point(62, 164);
            this.ShowBigMapCheckBox.Name = "ShowBigMapCheckBox";
            this.ShowBigMapCheckBox.Size = new System.Drawing.Size(84, 16);
            this.ShowBigMapCheckBox.TabIndex = 21;
            this.ShowBigMapCheckBox.Text = "大地图显示";
            this.ShowBigMapCheckBox.UseVisualStyleBackColor = true;
            this.ShowBigMapCheckBox.CheckedChanged += new System.EventHandler(this.ShowBigMapCheckBox_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 126);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 20;
            this.label25.Text = "城堡战争:";
            // 
            // ConquestComboBox
            // 
            this.ConquestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConquestComboBox.FormattingEnabled = true;
            this.ConquestComboBox.Location = new System.Drawing.Point(65, 123);
            this.ConquestComboBox.Name = "ConquestComboBox";
            this.ConquestComboBox.Size = new System.Drawing.Size(182, 20);
            this.ConquestComboBox.TabIndex = 19;
            this.ConquestComboBox.SelectedIndexChanged += new System.EventHandler(this.ConquestComboBox_SelectedIndexChanged);
            // 
            // NeedMoveMCheckBox
            // 
            this.NeedMoveMCheckBox.AutoSize = true;
            this.NeedMoveMCheckBox.Location = new System.Drawing.Point(156, 92);
            this.NeedMoveMCheckBox.Name = "NeedMoveMCheckBox";
            this.NeedMoveMCheckBox.Size = new System.Drawing.Size(72, 16);
            this.NeedMoveMCheckBox.TabIndex = 18;
            this.NeedMoveMCheckBox.Text = "需要移动";
            this.NeedMoveMCheckBox.UseVisualStyleBackColor = true;
            this.NeedMoveMCheckBox.CheckedChanged += new System.EventHandler(this.NeedScriptMCheckBox_CheckedChanged);
            // 
            // NeedHoleMCheckBox
            // 
            this.NeedHoleMCheckBox.AutoSize = true;
            this.NeedHoleMCheckBox.Location = new System.Drawing.Point(62, 92);
            this.NeedHoleMCheckBox.Name = "NeedHoleMCheckBox";
            this.NeedHoleMCheckBox.Size = new System.Drawing.Size(72, 16);
            this.NeedHoleMCheckBox.TabIndex = 17;
            this.NeedHoleMCheckBox.Text = "需要洞口";
            this.NeedHoleMCheckBox.UseVisualStyleBackColor = true;
            this.NeedHoleMCheckBox.CheckedChanged += new System.EventHandler(this.NeedHoleMCheckBox_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 12);
            this.label22.TabIndex = 16;
            this.label22.Text = "地图:";
            // 
            // DestMapComboBox
            // 
            this.DestMapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestMapComboBox.FormattingEnabled = true;
            this.DestMapComboBox.Location = new System.Drawing.Point(64, 30);
            this.DestMapComboBox.Name = "DestMapComboBox";
            this.DestMapComboBox.Size = new System.Drawing.Size(182, 20);
            this.DestMapComboBox.TabIndex = 15;
            this.DestMapComboBox.SelectedIndexChanged += new System.EventHandler(this.DestMapComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(107, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "到达 Y:";
            // 
            // DestYTextBox
            // 
            this.DestYTextBox.Location = new System.Drawing.Point(157, 55);
            this.DestYTextBox.MaxLength = 5;
            this.DestYTextBox.Name = "DestYTextBox";
            this.DestYTextBox.Size = new System.Drawing.Size(37, 21);
            this.DestYTextBox.TabIndex = 12;
            this.DestYTextBox.TextChanged += new System.EventHandler(this.DestYTextBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Location = new System.Drawing.Point(12, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 12);
            this.label21.TabIndex = 13;
            this.label21.Text = "到达 X:";
            // 
            // DestXTextBox
            // 
            this.DestXTextBox.Location = new System.Drawing.Point(62, 55);
            this.DestXTextBox.MaxLength = 5;
            this.DestXTextBox.Name = "DestXTextBox";
            this.DestXTextBox.Size = new System.Drawing.Size(37, 21);
            this.DestXTextBox.TabIndex = 11;
            this.DestXTextBox.TextChanged += new System.EventHandler(this.DestXTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "起点 Y:";
            // 
            // SourceYTextBox
            // 
            this.SourceYTextBox.Location = new System.Drawing.Point(157, 6);
            this.SourceYTextBox.MaxLength = 5;
            this.SourceYTextBox.Name = "SourceYTextBox";
            this.SourceYTextBox.Size = new System.Drawing.Size(37, 21);
            this.SourceYTextBox.TabIndex = 3;
            this.SourceYTextBox.TextChanged += new System.EventHandler(this.SourceYTextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 3;
            this.label20.Text = "起点 X:";
            // 
            // SourceXTextBox
            // 
            this.SourceXTextBox.Location = new System.Drawing.Point(62, 6);
            this.SourceXTextBox.MaxLength = 5;
            this.SourceXTextBox.Name = "SourceXTextBox";
            this.SourceXTextBox.Size = new System.Drawing.Size(37, 21);
            this.SourceXTextBox.TabIndex = 2;
            this.SourceXTextBox.TextChanged += new System.EventHandler(this.SourceXTextBox_TextChanged);
            // 
            // MovementInfoListBox
            // 
            this.MovementInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovementInfoListBox.FormattingEnabled = true;
            this.MovementInfoListBox.ItemHeight = 12;
            this.MovementInfoListBox.Location = new System.Drawing.Point(6, 32);
            this.MovementInfoListBox.Name = "MovementInfoListBox";
            this.MovementInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MovementInfoListBox.Size = new System.Drawing.Size(227, 160);
            this.MovementInfoListBox.TabIndex = 13;
            this.MovementInfoListBox.SelectedIndexChanged += new System.EventHandler(this.MovementInfoListBox_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.MZDeletebutton);
            this.tabPage7.Controls.Add(this.MZAddbutton);
            this.tabPage7.Controls.Add(this.MineZonepanel);
            this.tabPage7.Controls.Add(this.MZListlistBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(532, 226);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "地图雷区";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // MZDeletebutton
            // 
            this.MZDeletebutton.Location = new System.Drawing.Point(108, 6);
            this.MZDeletebutton.Name = "MZDeletebutton";
            this.MZDeletebutton.Size = new System.Drawing.Size(75, 21);
            this.MZDeletebutton.TabIndex = 12;
            this.MZDeletebutton.Text = "删 除";
            this.MZDeletebutton.UseVisualStyleBackColor = true;
            this.MZDeletebutton.Click += new System.EventHandler(this.MZDeletebutton_Click);
            // 
            // MZAddbutton
            // 
            this.MZAddbutton.Location = new System.Drawing.Point(6, 6);
            this.MZAddbutton.Name = "MZAddbutton";
            this.MZAddbutton.Size = new System.Drawing.Size(75, 21);
            this.MZAddbutton.TabIndex = 11;
            this.MZAddbutton.Text = "添 加";
            this.MZAddbutton.UseVisualStyleBackColor = false;
            this.MZAddbutton.Click += new System.EventHandler(this.MZAddbutton_Click);
            // 
            // MineZonepanel
            // 
            this.MineZonepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MineZonepanel.Controls.Add(this.label27);
            this.MineZonepanel.Controls.Add(this.MineZoneComboBox);
            this.MineZonepanel.Controls.Add(this.label30);
            this.MineZonepanel.Controls.Add(this.MZYtextBox);
            this.MineZonepanel.Controls.Add(this.label31);
            this.MineZonepanel.Controls.Add(this.MZSizetextBox);
            this.MineZonepanel.Controls.Add(this.label32);
            this.MineZonepanel.Controls.Add(this.MZXtextBox);
            this.MineZonepanel.Enabled = false;
            this.MineZonepanel.Location = new System.Drawing.Point(189, 32);
            this.MineZonepanel.Name = "MineZonepanel";
            this.MineZonepanel.Size = new System.Drawing.Size(241, 128);
            this.MineZonepanel.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 14;
            this.label27.Text = "类型选择:";
            // 
            // MineZoneComboBox
            // 
            this.MineZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MineZoneComboBox.FormattingEnabled = true;
            this.MineZoneComboBox.Location = new System.Drawing.Point(78, 13);
            this.MineZoneComboBox.Name = "MineZoneComboBox";
            this.MineZoneComboBox.Size = new System.Drawing.Size(124, 20);
            this.MineZoneComboBox.TabIndex = 13;
            this.MineZoneComboBox.SelectedIndexChanged += new System.EventHandler(this.MineZoneComboBox_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(121, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 12);
            this.label30.TabIndex = 10;
            this.label30.Text = "位置Y:";
            // 
            // MZYtextBox
            // 
            this.MZYtextBox.Location = new System.Drawing.Point(165, 51);
            this.MZYtextBox.MaxLength = 5;
            this.MZYtextBox.Name = "MZYtextBox";
            this.MZYtextBox.Size = new System.Drawing.Size(37, 21);
            this.MZYtextBox.TabIndex = 3;
            this.MZYtextBox.TextChanged += new System.EventHandler(this.MZYtextBox_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(34, 92);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 12);
            this.label31.TabIndex = 8;
            this.label31.Text = "范围:";
            // 
            // MZSizetextBox
            // 
            this.MZSizetextBox.Location = new System.Drawing.Point(78, 89);
            this.MZSizetextBox.MaxLength = 5;
            this.MZSizetextBox.Name = "MZSizetextBox";
            this.MZSizetextBox.Size = new System.Drawing.Size(37, 21);
            this.MZSizetextBox.TabIndex = 4;
            this.MZSizetextBox.TextChanged += new System.EventHandler(this.MZSizetextBox_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(34, 54);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 12);
            this.label32.TabIndex = 3;
            this.label32.Text = "位置X:";
            // 
            // MZXtextBox
            // 
            this.MZXtextBox.Location = new System.Drawing.Point(78, 50);
            this.MZXtextBox.MaxLength = 5;
            this.MZXtextBox.Name = "MZXtextBox";
            this.MZXtextBox.Size = new System.Drawing.Size(37, 21);
            this.MZXtextBox.TabIndex = 2;
            this.MZXtextBox.TextChanged += new System.EventHandler(this.MZXtextBox_TextChanged);
            // 
            // MZListlistBox
            // 
            this.MZListlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MZListlistBox.FormattingEnabled = true;
            this.MZListlistBox.ItemHeight = 12;
            this.MZListlistBox.Location = new System.Drawing.Point(6, 32);
            this.MZListlistBox.Name = "MZListlistBox";
            this.MZListlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MZListlistBox.Size = new System.Drawing.Size(177, 124);
            this.MZListlistBox.TabIndex = 13;
            this.MZListlistBox.SelectedIndexChanged += new System.EventHandler(this.MZListlistBox_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(126, 30);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 21);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "移 除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 21);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "增加地图";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MapInfoListBox
            // 
            this.MapInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MapInfoListBox.FormattingEnabled = true;
            this.MapInfoListBox.ItemHeight = 12;
            this.MapInfoListBox.Location = new System.Drawing.Point(12, 57);
            this.MapInfoListBox.Name = "MapInfoListBox";
            this.MapInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MapInfoListBox.Size = new System.Drawing.Size(189, 244);
            this.MapInfoListBox.TabIndex = 7;
            this.MapInfoListBox.SelectedIndexChanged += new System.EventHandler(this.MapInfoListBox_SelectedIndexChanged);
            // 
            // PasteMapButton
            // 
            this.PasteMapButton.Location = new System.Drawing.Point(288, 30);
            this.PasteMapButton.Name = "PasteMapButton";
            this.PasteMapButton.Size = new System.Drawing.Size(75, 21);
            this.PasteMapButton.TabIndex = 24;
            this.PasteMapButton.Text = "粘 贴";
            this.PasteMapButton.UseVisualStyleBackColor = true;
            this.PasteMapButton.Click += new System.EventHandler(this.PasteMapButton_Click);
            // 
            // CopyMapButton
            // 
            this.CopyMapButton.Location = new System.Drawing.Point(207, 30);
            this.CopyMapButton.Name = "CopyMapButton";
            this.CopyMapButton.Size = new System.Drawing.Size(75, 21);
            this.CopyMapButton.TabIndex = 23;
            this.CopyMapButton.Text = "复 制";
            this.CopyMapButton.UseVisualStyleBackColor = true;
            // 
            // ImportMapInfoButton
            // 
            this.ImportMapInfoButton.Location = new System.Drawing.Point(564, 4);
            this.ImportMapInfoButton.Name = "ImportMapInfoButton";
            this.ImportMapInfoButton.Size = new System.Drawing.Size(87, 21);
            this.ImportMapInfoButton.TabIndex = 25;
            this.ImportMapInfoButton.Text = "导入地图配置";
            this.ImportMapInfoButton.UseVisualStyleBackColor = true;
            this.ImportMapInfoButton.Click += new System.EventHandler(this.ImportMapInfoButton_Click);
            // 
            // ExportMapInfoButton
            // 
            this.ExportMapInfoButton.Location = new System.Drawing.Point(564, 30);
            this.ExportMapInfoButton.Name = "ExportMapInfoButton";
            this.ExportMapInfoButton.Size = new System.Drawing.Size(87, 21);
            this.ExportMapInfoButton.TabIndex = 26;
            this.ExportMapInfoButton.Text = "导出地图配置";
            this.ExportMapInfoButton.UseVisualStyleBackColor = true;
            this.ExportMapInfoButton.Click += new System.EventHandler(this.ExportMapInfoButton_Click);
            // 
            // ImportMongenButton
            // 
            this.ImportMongenButton.Location = new System.Drawing.Point(657, 3);
            this.ImportMongenButton.Name = "ImportMongenButton";
            this.ImportMongenButton.Size = new System.Drawing.Size(86, 21);
            this.ImportMongenButton.TabIndex = 27;
            this.ImportMongenButton.Text = "导入怪物刷新";
            this.ImportMongenButton.UseVisualStyleBackColor = true;
            this.ImportMongenButton.Click += new System.EventHandler(this.ImportMonGenButton_Click);
            // 
            // ExportMongenButton
            // 
            this.ExportMongenButton.Location = new System.Drawing.Point(657, 30);
            this.ExportMongenButton.Name = "ExportMongenButton";
            this.ExportMongenButton.Size = new System.Drawing.Size(86, 21);
            this.ExportMongenButton.TabIndex = 28;
            this.ExportMongenButton.Text = "导出怪物刷新";
            this.ExportMongenButton.UseVisualStyleBackColor = true;
            this.ExportMongenButton.Click += new System.EventHandler(this.ExportMonGenButton_Click);
            // 
            // VisualizerButton
            // 
            this.VisualizerButton.Location = new System.Drawing.Point(369, 30);
            this.VisualizerButton.Name = "VisualizerButton";
            this.VisualizerButton.Size = new System.Drawing.Size(75, 21);
            this.VisualizerButton.TabIndex = 31;
            this.VisualizerButton.Text = "地图查看器";
            this.VisualizerButton.UseVisualStyleBackColor = true;
            this.VisualizerButton.Click += new System.EventHandler(this.VisualizerButton_Click);
            // 
            // MapInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 310);
            this.Controls.Add(this.VisualizerButton);
            this.Controls.Add(this.ExportMongenButton);
            this.Controls.Add(this.ImportMongenButton);
            this.Controls.Add(this.ExportMapInfoButton);
            this.Controls.Add(this.ImportMapInfoButton);
            this.Controls.Add(this.PasteMapButton);
            this.Controls.Add(this.CopyMapButton);
            this.Controls.Add(this.MapTabs);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MapInfoListBox);
            this.Name = "MapInfoForm";
            this.Text = "地图配置管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapInfoForm_FormClosed);
            this.MapTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.SafeZoneInfoPanel.ResumeLayout(false);
            this.SafeZoneInfoPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.RespawnInfoPanel.ResumeLayout(false);
            this.RespawnInfoPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.MovementInfoPanel.ResumeLayout(false);
            this.MovementInfoPanel.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.MineZonepanel.ResumeLayout(false);
            this.MineZonepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MapTabs;
        private TabPage tabPage3;
        private Button RemoveSZButton;
        private Button AddSZButton;
        private Panel SafeZoneInfoPanel;
        private Label label12;
        private TextBox SZYTextBox;
        private Label label14;
        private TextBox SizeTextBox;
        private Label label17;
        private TextBox SZXTextBox;
        private CheckBox StartPointCheckBox;
        private ListBox SafeZoneInfoListBox;
        private TabPage tabPage2;
        private Button RPasteButton;
        private Button RCopyButton;
        private Button RemoveRButton;
        private Button AddRButton;
        private ListBox RespawnInfoListBox;
        private Panel RespawnInfoPanel;
        private Label label24;
        private TextBox DirectionTextBox;
        private Label label8;
        private TextBox DelayTextBox;
        private Label label7;
        private ComboBox MonsterInfoComboBox;
        private Label label6;
        private TextBox SpreadTextBox;
        private Label label9;
        private TextBox RYTextBox;
        private Label label10;
        private TextBox CountTextBox;
        private Label label13;
        private TextBox RXTextBox;
        private TabPage tabPage4;
        private Button RemoveMButton;
        private Button AddMButton;
        private Panel MovementInfoPanel;
        private Label label22;
        private ComboBox DestMapComboBox;
        private Label label18;
        private TextBox DestYTextBox;
        private Label label21;
        private TextBox DestXTextBox;
        private Label label16;
        private TextBox SourceYTextBox;
        private Label label20;
        private TextBox SourceXTextBox;
        private ListBox MovementInfoListBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox MapInfoListBox;
        private Button PasteMapButton;
        private Button CopyMapButton;
        private TabPage tabPage1;
        private Label label15;
        private TextBox BigMapTextBox;
        private ComboBox LightsComboBox;
        private Label label5;
        private Label label1;
        private Label label4;
        private TextBox MapIndexTextBox;
        private TextBox MiniMapTextBox;
        private Label label2;
        private TextBox MapNameTextBox;
        private TextBox FileNameTextBox;
        private Label label3;
        private TabPage tabPage6;
        private CheckBox LightningCheckbox;
        private CheckBox FireCheckbox;
        private CheckBox FightCheckbox;
        private CheckBox NoReconnectCheckbox;
        private CheckBox NoTeleportCheckbox;
        private TextBox LightningTextbox;
        private TextBox FireTextbox;
        private TextBox NoReconnectTextbox;
        private CheckBox NoNamesCheckbox;
        private CheckBox NoDropMonsterCheckbox;
        private CheckBox NoDropPlayerCheckbox;
        private CheckBox NoThrowItemCheckbox;
        private CheckBox NoPositionCheckbox;
        private CheckBox NoDrugCheckbox;
        private CheckBox NoRecallCheckbox;
        private CheckBox NoEscapeCheckbox;
        private CheckBox NoRandomCheckbox;
        private CheckBox NeedHoleMCheckBox;
        private Button ImportMapInfoButton;
        private Button ExportMapInfoButton;
        private Label label19;
        private TextBox MapDarkLighttextBox;
        private TabPage tabPage7;
        private Button MZDeletebutton;
        private Button MZAddbutton;
        private Panel MineZonepanel;
        private Label label30;
        private TextBox MZYtextBox;
        private Label label31;
        private TextBox MZSizetextBox;
        private Label label32;
        private TextBox MZXtextBox;
        private ListBox MZListlistBox;
        private ComboBox MineComboBox;
        private ComboBox MineZoneComboBox;
        private Label label27;
        private Label label33;
        private Button ImportMongenButton;
        private Button ExportMongenButton;
        private Button VisualizerButton;
        private CheckBox NeedBridleCheckbox;
        private CheckBox NoMountCheckbox;
        private Label label34;
        private TextBox RoutePathTextBox;
        private CheckBox NoFightCheckbox;
        private CheckBox NeedMoveMCheckBox;
        private Label label11;
        private TextBox MusicTextBox;
        private Label label23;
        private TextBox Randomtextbox;
        private ToolTip toolTip1;
        private CheckBox chkrespawnsave;
        private CheckBox chkRespawnEnableTick;
        private ComboBox ConquestComboBox;
        private Label label25;
        private CheckBox NoTownTeleportCheckbox;
        private CheckBox NoReincarnation;
        private Label label26;
        private TextBox BigMapIconTextBox;
        private CheckBox ShowBigMapCheckBox;
    }
}