﻿
namespace Server
{
    partial class AccountInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AccountInfoPanel = new System.Windows.Forms.Panel();
            this.PasswordChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.PermBanButton = new System.Windows.Forms.Button();
            this.WeekBanButton = new System.Windows.Forms.Button();
            this.DayBanButton = new System.Windows.Forms.Button();
            this.BannedCheckBox = new System.Windows.Forms.CheckBox();
            this.ExpiryDateTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BanReasonTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LastDateTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LastIPTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CreationDateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CreationIPTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EMailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FilterPlayerTextBox = new System.Windows.Forms.TextBox();
            this.AccountInfoListView = new CustomFormControl.ListViewNF();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bannedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.banReasonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expiryDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatchFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.WipeCharButton = new System.Windows.Forms.Button();
            this.AccountInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 11);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 21);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "创建账号";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "筛选账号 ID:";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(95, 36);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(112, 21);
            this.FilterTextBox.TabIndex = 12;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(390, 34);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 21);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AccountInfoPanel
            // 
            this.AccountInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountInfoPanel.Controls.Add(this.PasswordChangeCheckBox);
            this.AccountInfoPanel.Controls.Add(this.setPasswordButton);
            this.AccountInfoPanel.Controls.Add(this.AdminCheckBox);
            this.AccountInfoPanel.Controls.Add(this.PermBanButton);
            this.AccountInfoPanel.Controls.Add(this.WeekBanButton);
            this.AccountInfoPanel.Controls.Add(this.DayBanButton);
            this.AccountInfoPanel.Controls.Add(this.BannedCheckBox);
            this.AccountInfoPanel.Controls.Add(this.ExpiryDateTextBox);
            this.AccountInfoPanel.Controls.Add(this.label14);
            this.AccountInfoPanel.Controls.Add(this.BanReasonTextBox);
            this.AccountInfoPanel.Controls.Add(this.label13);
            this.AccountInfoPanel.Controls.Add(this.LastDateTextBox);
            this.AccountInfoPanel.Controls.Add(this.label11);
            this.AccountInfoPanel.Controls.Add(this.LastIPTextBox);
            this.AccountInfoPanel.Controls.Add(this.label12);
            this.AccountInfoPanel.Controls.Add(this.CreationDateTextBox);
            this.AccountInfoPanel.Controls.Add(this.label9);
            this.AccountInfoPanel.Controls.Add(this.CreationIPTextBox);
            this.AccountInfoPanel.Controls.Add(this.label10);
            this.AccountInfoPanel.Controls.Add(this.EMailTextBox);
            this.AccountInfoPanel.Controls.Add(this.label8);
            this.AccountInfoPanel.Controls.Add(this.AnswerTextBox);
            this.AccountInfoPanel.Controls.Add(this.label7);
            this.AccountInfoPanel.Controls.Add(this.QuestionTextBox);
            this.AccountInfoPanel.Controls.Add(this.label6);
            this.AccountInfoPanel.Controls.Add(this.BirthDateTextBox);
            this.AccountInfoPanel.Controls.Add(this.label5);
            this.AccountInfoPanel.Controls.Add(this.UserNameTextBox);
            this.AccountInfoPanel.Controls.Add(this.label4);
            this.AccountInfoPanel.Controls.Add(this.label3);
            this.AccountInfoPanel.Controls.Add(this.AccountIDTextBox);
            this.AccountInfoPanel.Controls.Add(this.label2);
            this.AccountInfoPanel.Location = new System.Drawing.Point(12, 222);
            this.AccountInfoPanel.Name = "AccountInfoPanel";
            this.AccountInfoPanel.Size = new System.Drawing.Size(616, 193);
            this.AccountInfoPanel.TabIndex = 14;
            // 
            // PasswordChangeCheckBox
            // 
            this.PasswordChangeCheckBox.AutoSize = true;
            this.PasswordChangeCheckBox.Location = new System.Drawing.Point(179, 41);
            this.PasswordChangeCheckBox.Name = "PasswordChangeCheckBox";
            this.PasswordChangeCheckBox.Size = new System.Drawing.Size(96, 16);
            this.PasswordChangeCheckBox.TabIndex = 34;
            this.PasswordChangeCheckBox.Text = "登录更改密码";
            this.PasswordChangeCheckBox.UseVisualStyleBackColor = true;
            this.PasswordChangeCheckBox.CheckedChanged += new System.EventHandler(this.PasswordChangeCheckBox_CheckedChanged);
            // 
            // setPasswordButton
            // 
            this.setPasswordButton.Location = new System.Drawing.Point(72, 38);
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.Size = new System.Drawing.Size(96, 21);
            this.setPasswordButton.TabIndex = 33;
            this.setPasswordButton.Text = "添加密码";
            this.setPasswordButton.UseVisualStyleBackColor = true;
            this.setPasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(202, 16);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(84, 16);
            this.AdminCheckBox.TabIndex = 32;
            this.AdminCheckBox.Text = "授权管理员";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
            // 
            // PermBanButton
            // 
            this.PermBanButton.Location = new System.Drawing.Point(526, 166);
            this.PermBanButton.Name = "PermBanButton";
            this.PermBanButton.Size = new System.Drawing.Size(75, 21);
            this.PermBanButton.TabIndex = 31;
            this.PermBanButton.Text = "永久封禁";
            this.PermBanButton.UseVisualStyleBackColor = true;
            this.PermBanButton.Click += new System.EventHandler(this.PermBanButton_Click);
            // 
            // WeekBanButton
            // 
            this.WeekBanButton.Location = new System.Drawing.Point(443, 166);
            this.WeekBanButton.Name = "WeekBanButton";
            this.WeekBanButton.Size = new System.Drawing.Size(75, 21);
            this.WeekBanButton.TabIndex = 30;
            this.WeekBanButton.Text = "封禁一周";
            this.WeekBanButton.UseVisualStyleBackColor = true;
            this.WeekBanButton.Click += new System.EventHandler(this.WeekBanButton_Click);
            // 
            // DayBanButton
            // 
            this.DayBanButton.Location = new System.Drawing.Point(359, 166);
            this.DayBanButton.Name = "DayBanButton";
            this.DayBanButton.Size = new System.Drawing.Size(75, 21);
            this.DayBanButton.TabIndex = 29;
            this.DayBanButton.Text = "封禁一日";
            this.DayBanButton.UseVisualStyleBackColor = true;
            this.DayBanButton.Click += new System.EventHandler(this.DayBanButton_Click);
            // 
            // BannedCheckBox
            // 
            this.BannedCheckBox.AutoSize = true;
            this.BannedCheckBox.Location = new System.Drawing.Point(518, 144);
            this.BannedCheckBox.Name = "BannedCheckBox";
            this.BannedCheckBox.Size = new System.Drawing.Size(72, 16);
            this.BannedCheckBox.TabIndex = 28;
            this.BannedCheckBox.Text = "解除封禁";
            this.BannedCheckBox.UseVisualStyleBackColor = true;
            this.BannedCheckBox.CheckedChanged += new System.EventHandler(this.BannedCheckBox_CheckedChanged);
            // 
            // ExpiryDateTextBox
            // 
            this.ExpiryDateTextBox.Location = new System.Drawing.Point(388, 141);
            this.ExpiryDateTextBox.Name = "ExpiryDateTextBox";
            this.ExpiryDateTextBox.Size = new System.Drawing.Size(120, 21);
            this.ExpiryDateTextBox.TabIndex = 27;
            this.ExpiryDateTextBox.TextChanged += new System.EventHandler(this.ExpiryDateTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "封禁日期:";
            // 
            // BanReasonTextBox
            // 
            this.BanReasonTextBox.Location = new System.Drawing.Point(388, 115);
            this.BanReasonTextBox.Name = "BanReasonTextBox";
            this.BanReasonTextBox.Size = new System.Drawing.Size(225, 21);
            this.BanReasonTextBox.TabIndex = 25;
            this.BanReasonTextBox.TextChanged += new System.EventHandler(this.BanReasonTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "封禁原因:";
            // 
            // LastDateTextBox
            // 
            this.LastDateTextBox.Location = new System.Drawing.Point(387, 89);
            this.LastDateTextBox.Name = "LastDateTextBox";
            this.LastDateTextBox.ReadOnly = true;
            this.LastDateTextBox.Size = new System.Drawing.Size(145, 21);
            this.LastDateTextBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "登录日期:";
            // 
            // LastIPTextBox
            // 
            this.LastIPTextBox.Location = new System.Drawing.Point(388, 64);
            this.LastIPTextBox.Name = "LastIPTextBox";
            this.LastIPTextBox.ReadOnly = true;
            this.LastIPTextBox.Size = new System.Drawing.Size(144, 21);
            this.LastIPTextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "登录 IP:";
            // 
            // CreationDateTextBox
            // 
            this.CreationDateTextBox.Location = new System.Drawing.Point(388, 39);
            this.CreationDateTextBox.Name = "CreationDateTextBox";
            this.CreationDateTextBox.ReadOnly = true;
            this.CreationDateTextBox.Size = new System.Drawing.Size(144, 21);
            this.CreationDateTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "注册日期:";
            // 
            // CreationIPTextBox
            // 
            this.CreationIPTextBox.Location = new System.Drawing.Point(388, 13);
            this.CreationIPTextBox.Name = "CreationIPTextBox";
            this.CreationIPTextBox.ReadOnly = true;
            this.CreationIPTextBox.Size = new System.Drawing.Size(144, 21);
            this.CreationIPTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "注册 IP:";
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.Location = new System.Drawing.Point(72, 166);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(215, 21);
            this.EMailTextBox.TabIndex = 15;
            this.EMailTextBox.TextChanged += new System.EventHandler(this.EMailTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "注册邮箱:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(72, 141);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(155, 21);
            this.AnswerTextBox.TabIndex = 13;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "问题答案:";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(72, 114);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(155, 21);
            this.QuestionTextBox.TabIndex = 11;
            this.QuestionTextBox.TextChanged += new System.EventHandler(this.QuestionTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "找回问答:";
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.Location = new System.Drawing.Point(72, 89);
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.Size = new System.Drawing.Size(123, 21);
            this.BirthDateTextBox.TabIndex = 9;
            this.BirthDateTextBox.TextChanged += new System.EventHandler(this.BirthDateTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "出生日期:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(72, 62);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(123, 21);
            this.UserNameTextBox.TabIndex = 7;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓 名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密  码:";
            // 
            // AccountIDTextBox
            // 
            this.AccountIDTextBox.Location = new System.Drawing.Point(72, 13);
            this.AccountIDTextBox.Name = "AccountIDTextBox";
            this.AccountIDTextBox.Size = new System.Drawing.Size(123, 21);
            this.AccountIDTextBox.TabIndex = 3;
            this.AccountIDTextBox.TextChanged += new System.EventHandler(this.AccountIDTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "角色过滤:";
            // 
            // FilterPlayerTextBox
            // 
            this.FilterPlayerTextBox.Location = new System.Drawing.Point(276, 36);
            this.FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            this.FilterPlayerTextBox.Size = new System.Drawing.Size(108, 21);
            this.FilterPlayerTextBox.TabIndex = 16;
            // 
            // AccountInfoListView
            // 
            this.AccountInfoListView.AllowColumnReorder = true;
            this.AccountInfoListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.accountIDHeader,
            this.userNameHeader,
            this.adminHeader,
            this.bannedHeader,
            this.banReasonHeader,
            this.expiryDateHeader});
            this.AccountInfoListView.FullRowSelect = true;
            this.AccountInfoListView.GridLines = true;
            this.AccountInfoListView.HideSelection = false;
            this.AccountInfoListView.Location = new System.Drawing.Point(10, 60);
            this.AccountInfoListView.Name = "AccountInfoListView";
            this.AccountInfoListView.Size = new System.Drawing.Size(618, 156);
            this.AccountInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AccountInfoListView.TabIndex = 8;
            this.AccountInfoListView.UseCompatibleStateImageBehavior = false;
            this.AccountInfoListView.View = System.Windows.Forms.View.Details;
            this.AccountInfoListView.SelectedIndexChanged += new System.EventHandler(this.AccountInfoListView_SelectedIndexChanged);
            // 
            // indexHeader
            // 
            this.indexHeader.Text = "序号";
            // 
            // accountIDHeader
            // 
            this.accountIDHeader.Text = "登录账号";
            this.accountIDHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountIDHeader.Width = 95;
            // 
            // userNameHeader
            // 
            this.userNameHeader.Text = "姓名";
            this.userNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameHeader.Width = 75;
            // 
            // adminHeader
            // 
            this.adminHeader.Text = "是否管理";
            this.adminHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adminHeader.Width = 73;
            // 
            // bannedHeader
            // 
            this.bannedHeader.Text = "禁止登录";
            this.bannedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // banReasonHeader
            // 
            this.banReasonHeader.Text = "禁止原因";
            this.banReasonHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.banReasonHeader.Width = 90;
            // 
            // expiryDateHeader
            // 
            this.expiryDateHeader.Text = "禁止期限";
            this.expiryDateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expiryDateHeader.Width = 81;
            // 
            // MatchFilterCheckBox
            // 
            this.MatchFilterCheckBox.AutoSize = true;
            this.MatchFilterCheckBox.Location = new System.Drawing.Point(472, 36);
            this.MatchFilterCheckBox.Name = "MatchFilterCheckBox";
            this.MatchFilterCheckBox.Size = new System.Drawing.Size(72, 16);
            this.MatchFilterCheckBox.TabIndex = 17;
            this.MatchFilterCheckBox.Text = "相关角色";
            this.MatchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WipeCharButton
            // 
            this.WipeCharButton.Location = new System.Drawing.Point(93, 11);
            this.WipeCharButton.Name = "WipeCharButton";
            this.WipeCharButton.Size = new System.Drawing.Size(115, 21);
            this.WipeCharButton.TabIndex = 18;
            this.WipeCharButton.Text = "清除字符";
            this.WipeCharButton.UseVisualStyleBackColor = true;
            this.WipeCharButton.Click += new System.EventHandler(this.WipeCharButton_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.Controls.Add(this.WipeCharButton);
            this.Controls.Add(this.MatchFilterCheckBox);
            this.Controls.Add(this.FilterPlayerTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.AccountInfoPanel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AccountInfoListView);
            this.Name = "AccountInfoForm";
            this.Text = "账号信息表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountInfoForm_FormClosed);
            this.AccountInfoPanel.ResumeLayout(false);
            this.AccountInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private CustomFormControl.ListViewNF AccountInfoListView;
        private System.Windows.Forms.ColumnHeader indexHeader;
        private System.Windows.Forms.ColumnHeader accountIDHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.ColumnHeader userNameHeader;
        private System.Windows.Forms.ColumnHeader bannedHeader;
        private System.Windows.Forms.ColumnHeader banReasonHeader;
        private System.Windows.Forms.ColumnHeader expiryDateHeader;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel AccountInfoPanel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BirthDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastDateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LastIPTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreationDateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CreationIPTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExpiryDateTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BanReasonTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox BannedCheckBox;
        private System.Windows.Forms.Button PermBanButton;
        private System.Windows.Forms.Button WeekBanButton;
        private System.Windows.Forms.Button DayBanButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.ColumnHeader adminHeader;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FilterPlayerTextBox;
        private System.Windows.Forms.CheckBox MatchFilterCheckBox;
        private System.Windows.Forms.Button WipeCharButton;
        private System.Windows.Forms.Button setPasswordButton;
        private System.Windows.Forms.CheckBox PasswordChangeCheckBox;
    }
}