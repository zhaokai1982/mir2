﻿namespace Server
{
    partial class GameShop
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
            this.GameShopListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GoldPrice_textbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.GPPrice_textbox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ItemDetails_gb = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Count_textbox = new System.Windows.Forms.TextBox();
            this.LeftinStock_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalSold_label = new System.Windows.Forms.Label();
            this.TopItem_checkbox = new System.Windows.Forms.CheckBox();
            this.DealofDay_checkbox = new System.Windows.Forms.CheckBox();
            this.Individual_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stock_textbox = new System.Windows.Forms.TextBox();
            this.Category_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Class_combo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CredxGold_textbox = new System.Windows.Forms.TextBox();
            this.ServerLog_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.ClassFilter_lb = new System.Windows.Forms.ComboBox();
            this.SectionFilter_lb = new System.Windows.Forms.ComboBox();
            this.CategoryFilter_lb = new System.Windows.Forms.ComboBox();
            this.ResetFilter_button = new System.Windows.Forms.Button();
            this.ItemDetails_gb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameShopListBox
            // 
            this.GameShopListBox.FormattingEnabled = true;
            this.GameShopListBox.ItemHeight = 12;
            this.GameShopListBox.Location = new System.Drawing.Point(12, 71);
            this.GameShopListBox.Name = "GameShopListBox";
            this.GameShopListBox.ScrollAlwaysVisible = true;
            this.GameShopListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.GameShopListBox.Size = new System.Drawing.Size(201, 340);
            this.GameShopListBox.TabIndex = 11;
            this.GameShopListBox.SelectedIndexChanged += new System.EventHandler(this.GameShopListBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 90;
            this.label14.Text = "黄金价格:";
            // 
            // GoldPrice_textbox
            // 
            this.GoldPrice_textbox.Location = new System.Drawing.Point(86, 94);
            this.GoldPrice_textbox.MaxLength = 0;
            this.GoldPrice_textbox.Name = "GoldPrice_textbox";
            this.GoldPrice_textbox.Size = new System.Drawing.Size(113, 21);
            this.GoldPrice_textbox.TabIndex = 86;
            this.GoldPrice_textbox.TextChanged += new System.EventHandler(this.GoldPrice_textbox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 91;
            this.label21.Text = "赊销价格:";
            // 
            // GPPrice_textbox
            // 
            this.GPPrice_textbox.Location = new System.Drawing.Point(86, 68);
            this.GPPrice_textbox.MaxLength = 0;
            this.GPPrice_textbox.Name = "GPPrice_textbox";
            this.GPPrice_textbox.Size = new System.Drawing.Size(113, 21);
            this.GPPrice_textbox.TabIndex = 87;
            this.GPPrice_textbox.TextChanged += new System.EventHandler(this.GPPrice_textbox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 148);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 93;
            this.label29.Text = "使用职业:";
            // 
            // ItemDetails_gb
            // 
            this.ItemDetails_gb.BackColor = System.Drawing.Color.White;
            this.ItemDetails_gb.Controls.Add(this.label6);
            this.ItemDetails_gb.Controls.Add(this.Count_textbox);
            this.ItemDetails_gb.Controls.Add(this.LeftinStock_label);
            this.ItemDetails_gb.Controls.Add(this.label3);
            this.ItemDetails_gb.Controls.Add(this.label5);
            this.ItemDetails_gb.Controls.Add(this.TotalSold_label);
            this.ItemDetails_gb.Controls.Add(this.TopItem_checkbox);
            this.ItemDetails_gb.Controls.Add(this.DealofDay_checkbox);
            this.ItemDetails_gb.Controls.Add(this.Individual_checkbox);
            this.ItemDetails_gb.Controls.Add(this.label1);
            this.ItemDetails_gb.Controls.Add(this.Stock_textbox);
            this.ItemDetails_gb.Controls.Add(this.GoldPrice_textbox);
            this.ItemDetails_gb.Controls.Add(this.label14);
            this.ItemDetails_gb.Controls.Add(this.label21);
            this.ItemDetails_gb.Controls.Add(this.Category_textbox);
            this.ItemDetails_gb.Controls.Add(this.GPPrice_textbox);
            this.ItemDetails_gb.Controls.Add(this.label4);
            this.ItemDetails_gb.Controls.Add(this.label29);
            this.ItemDetails_gb.Controls.Add(this.Class_combo);
            this.ItemDetails_gb.Location = new System.Drawing.Point(219, 75);
            this.ItemDetails_gb.Name = "ItemDetails_gb";
            this.ItemDetails_gb.Size = new System.Drawing.Size(267, 294);
            this.ItemDetails_gb.TabIndex = 98;
            this.ItemDetails_gb.TabStop = false;
            this.ItemDetails_gb.Text = "销售设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 117;
            this.label6.Text = "销售数量:";
            // 
            // Count_textbox
            // 
            this.Count_textbox.Location = new System.Drawing.Point(86, 118);
            this.Count_textbox.MaxLength = 0;
            this.Count_textbox.Name = "Count_textbox";
            this.Count_textbox.Size = new System.Drawing.Size(113, 21);
            this.Count_textbox.TabIndex = 116;
            this.Count_textbox.TextChanged += new System.EventHandler(this.Count_textbox_TextChanged);
            // 
            // LeftinStock_label
            // 
            this.LeftinStock_label.AutoSize = true;
            this.LeftinStock_label.Location = new System.Drawing.Point(83, 44);
            this.LeftinStock_label.Name = "LeftinStock_label";
            this.LeftinStock_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftinStock_label.Size = new System.Drawing.Size(23, 12);
            this.LeftinStock_label.TabIndex = 115;
            this.LeftinStock_label.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 114;
            this.label3.Text = "库存数量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 113;
            this.label5.Text = "销售价格:";
            // 
            // TotalSold_label
            // 
            this.TotalSold_label.AutoSize = true;
            this.TotalSold_label.Location = new System.Drawing.Point(82, 21);
            this.TotalSold_label.Name = "TotalSold_label";
            this.TotalSold_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalSold_label.Size = new System.Drawing.Size(23, 12);
            this.TotalSold_label.TabIndex = 112;
            this.TotalSold_label.Text = "100";
            // 
            // TopItem_checkbox
            // 
            this.TopItem_checkbox.AutoSize = true;
            this.TopItem_checkbox.Location = new System.Drawing.Point(132, 237);
            this.TopItem_checkbox.Name = "TopItem_checkbox";
            this.TopItem_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopItem_checkbox.Size = new System.Drawing.Size(78, 16);
            this.TopItem_checkbox.TabIndex = 106;
            this.TopItem_checkbox.Text = ":置顶商品";
            this.TopItem_checkbox.UseVisualStyleBackColor = true;
            this.TopItem_checkbox.CheckedChanged += new System.EventHandler(this.TopItem_checkbox_CheckedChanged);
            // 
            // DealofDay_checkbox
            // 
            this.DealofDay_checkbox.AutoSize = true;
            this.DealofDay_checkbox.Location = new System.Drawing.Point(21, 237);
            this.DealofDay_checkbox.Name = "DealofDay_checkbox";
            this.DealofDay_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DealofDay_checkbox.Size = new System.Drawing.Size(78, 16);
            this.DealofDay_checkbox.TabIndex = 105;
            this.DealofDay_checkbox.Text = ":商品上架";
            this.DealofDay_checkbox.UseVisualStyleBackColor = true;
            this.DealofDay_checkbox.CheckedChanged += new System.EventHandler(this.DealofDay_checkbox_CheckedChanged);
            // 
            // Individual_checkbox
            // 
            this.Individual_checkbox.AutoSize = true;
            this.Individual_checkbox.Location = new System.Drawing.Point(163, 197);
            this.Individual_checkbox.Name = "Individual_checkbox";
            this.Individual_checkbox.Size = new System.Drawing.Size(72, 16);
            this.Individual_checkbox.TabIndex = 110;
            this.Individual_checkbox.Text = "玩家限购";
            this.Individual_checkbox.UseVisualStyleBackColor = true;
            this.Individual_checkbox.CheckedChanged += new System.EventHandler(this.Individual_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 111;
            this.label1.Text = "库存;";
            // 
            // Stock_textbox
            // 
            this.Stock_textbox.Location = new System.Drawing.Point(86, 194);
            this.Stock_textbox.MaxLength = 0;
            this.Stock_textbox.Name = "Stock_textbox";
            this.Stock_textbox.Size = new System.Drawing.Size(72, 21);
            this.Stock_textbox.TabIndex = 109;
            this.Stock_textbox.TextChanged += new System.EventHandler(this.Stock_textbox_TextChanged);
            // 
            // Category_textbox
            // 
            this.Category_textbox.Location = new System.Drawing.Point(86, 169);
            this.Category_textbox.MaxLength = 0;
            this.Category_textbox.Name = "Category_textbox";
            this.Category_textbox.Size = new System.Drawing.Size(173, 21);
            this.Category_textbox.TabIndex = 108;
            this.Category_textbox.TextChanged += new System.EventHandler(this.Category_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 106;
            this.label4.Text = "商品分类:";
            // 
            // Class_combo
            // 
            this.Class_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_combo.FormattingEnabled = true;
            this.Class_combo.Items.AddRange(new object[] {
            "全部",
            "战士",
            "刺客",
            "道士",
            "魔法师",
            "弓箭手"});
            this.Class_combo.Location = new System.Drawing.Point(86, 144);
            this.Class_combo.Name = "Class_combo";
            this.Class_combo.Size = new System.Drawing.Size(173, 20);
            this.Class_combo.TabIndex = 105;
            this.Class_combo.SelectedIndexChanged += new System.EventHandler(this.Class_combo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CredxGold_textbox);
            this.groupBox3.Location = new System.Drawing.Point(219, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 63);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "游戏商店设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "信誉x黄金:";
            // 
            // CredxGold_textbox
            // 
            this.CredxGold_textbox.Location = new System.Drawing.Point(86, 22);
            this.CredxGold_textbox.MaxLength = 0;
            this.CredxGold_textbox.Name = "CredxGold_textbox";
            this.CredxGold_textbox.Size = new System.Drawing.Size(65, 21);
            this.CredxGold_textbox.TabIndex = 88;
            this.CredxGold_textbox.TextChanged += new System.EventHandler(this.CredxGold_textbox_TextChanged);
            // 
            // ServerLog_button
            // 
            this.ServerLog_button.Location = new System.Drawing.Point(220, 377);
            this.ServerLog_button.Name = "ServerLog_button";
            this.ServerLog_button.Size = new System.Drawing.Size(266, 34);
            this.ServerLog_button.TabIndex = 112;
            this.ServerLog_button.Text = "重置购买日志 (库存限制将重置)";
            this.ServerLog_button.UseVisualStyleBackColor = true;
            this.ServerLog_button.Click += new System.EventHandler(this.ServerLog_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(57, 417);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(87, 21);
            this.Remove_button.TabIndex = 106;
            this.Remove_button.Text = "移 除";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // ClassFilter_lb
            // 
            this.ClassFilter_lb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassFilter_lb.FormattingEnabled = true;
            this.ClassFilter_lb.Location = new System.Drawing.Point(12, 5);
            this.ClassFilter_lb.Name = "ClassFilter_lb";
            this.ClassFilter_lb.Size = new System.Drawing.Size(146, 20);
            this.ClassFilter_lb.TabIndex = 107;
            this.ClassFilter_lb.SelectedIndexChanged += new System.EventHandler(this.ClassFilter_lb_SelectedIndexChanged);
            // 
            // SectionFilter_lb
            // 
            this.SectionFilter_lb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectionFilter_lb.FormattingEnabled = true;
            this.SectionFilter_lb.Items.AddRange(new object[] {
            "All Items",
            "Top Items",
            "Sale Items",
            "New Items"});
            this.SectionFilter_lb.Location = new System.Drawing.Point(12, 26);
            this.SectionFilter_lb.Name = "SectionFilter_lb";
            this.SectionFilter_lb.Size = new System.Drawing.Size(146, 20);
            this.SectionFilter_lb.TabIndex = 108;
            this.SectionFilter_lb.SelectedIndexChanged += new System.EventHandler(this.SectionFilter_lb_SelectedIndexChanged);
            // 
            // CategoryFilter_lb
            // 
            this.CategoryFilter_lb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryFilter_lb.FormattingEnabled = true;
            this.CategoryFilter_lb.Location = new System.Drawing.Point(12, 47);
            this.CategoryFilter_lb.Name = "CategoryFilter_lb";
            this.CategoryFilter_lb.Size = new System.Drawing.Size(146, 20);
            this.CategoryFilter_lb.TabIndex = 109;
            this.CategoryFilter_lb.SelectedIndexChanged += new System.EventHandler(this.CategoryFilter_lb_SelectedIndexChanged);
            // 
            // ResetFilter_button
            // 
            this.ResetFilter_button.Location = new System.Drawing.Point(164, 4);
            this.ResetFilter_button.Name = "ResetFilter_button";
            this.ResetFilter_button.Size = new System.Drawing.Size(49, 64);
            this.ResetFilter_button.TabIndex = 110;
            this.ResetFilter_button.Text = "重 置";
            this.ResetFilter_button.UseVisualStyleBackColor = true;
            this.ResetFilter_button.Click += new System.EventHandler(this.ResetFilter_button_Click);
            // 
            // GameShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 442);
            this.Controls.Add(this.ServerLog_button);
            this.Controls.Add(this.ResetFilter_button);
            this.Controls.Add(this.CategoryFilter_lb);
            this.Controls.Add(this.SectionFilter_lb);
            this.Controls.Add(this.ClassFilter_lb);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ItemDetails_gb);
            this.Controls.Add(this.GameShopListBox);
            this.Name = "GameShop";
            this.Text = "游戏商店";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameShop_FormClosed);
            this.Load += new System.EventHandler(this.GameShop_Load);
            this.ItemDetails_gb.ResumeLayout(false);
            this.ItemDetails_gb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GameShopListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GoldPrice_textbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox GPPrice_textbox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox ItemDetails_gb;
        private System.Windows.Forms.ComboBox Class_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DealofDay_checkbox;
        private System.Windows.Forms.CheckBox TopItem_checkbox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.TextBox Category_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Individual_checkbox;
        private System.Windows.Forms.TextBox Stock_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CredxGold_textbox;
        private System.Windows.Forms.Label TotalSold_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftinStock_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Count_textbox;
        private System.Windows.Forms.ComboBox ClassFilter_lb;
        private System.Windows.Forms.ComboBox SectionFilter_lb;
        private System.Windows.Forms.ComboBox CategoryFilter_lb;
        private System.Windows.Forms.Button ResetFilter_button;
        private System.Windows.Forms.Button ServerLog_button;
    }
}