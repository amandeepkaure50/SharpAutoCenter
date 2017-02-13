namespace Sharp_Auto_Center
{
    partial class SharpAutoCenterForm
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
            this.sharpAutoCentreDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBasePrice = new System.Windows.Forms.TextBox();
            this.textAdditionalOptions = new System.Windows.Forms.TextBox();
            this.texSubTotal = new System.Windows.Forms.TextBox();
            this.textSalesTax = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textTradeInAllowance = new System.Windows.Forms.TextBox();
            this.textAmountDue = new System.Windows.Forms.TextBox();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.additionalOptionsLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.additionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.computerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoSystemcheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.customizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.additionalItemsGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShowShortcutKeys = false;
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBasePrice
            // 
            this.textBasePrice.Location = new System.Drawing.Point(192, 75);
            this.textBasePrice.Name = "textBasePrice";
            this.textBasePrice.Size = new System.Drawing.Size(157, 26);
            this.textBasePrice.TabIndex = 1;
            this.textBasePrice.Text = "0.00";
            this.textBasePrice.Leave += new System.EventHandler(this.ValidateTextBox_TextChanged);
            // 
            // textAdditionalOptions
            // 
            this.textAdditionalOptions.Location = new System.Drawing.Point(192, 116);
            this.textAdditionalOptions.Name = "textAdditionalOptions";
            this.textAdditionalOptions.ReadOnly = true;
            this.textAdditionalOptions.Size = new System.Drawing.Size(157, 26);
            this.textAdditionalOptions.TabIndex = 2;
            this.textAdditionalOptions.Text = "0.00";
            // 
            // texSubTotal
            // 
            this.texSubTotal.Location = new System.Drawing.Point(192, 158);
            this.texSubTotal.Name = "texSubTotal";
            this.texSubTotal.ReadOnly = true;
            this.texSubTotal.Size = new System.Drawing.Size(157, 26);
            this.texSubTotal.TabIndex = 3;
            this.texSubTotal.Text = "0.00";
            // 
            // textSalesTax
            // 
            this.textSalesTax.Location = new System.Drawing.Point(192, 199);
            this.textSalesTax.Name = "textSalesTax";
            this.textSalesTax.Size = new System.Drawing.Size(157, 26);
            this.textSalesTax.TabIndex = 4;
            this.textSalesTax.Text = "0.00";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(192, 240);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(157, 26);
            this.textTotal.TabIndex = 5;
            this.textTotal.Text = "0.00";
            // 
            // textTradeInAllowance
            // 
            this.textTradeInAllowance.Location = new System.Drawing.Point(192, 281);
            this.textTradeInAllowance.Name = "textTradeInAllowance";
            this.textTradeInAllowance.Size = new System.Drawing.Size(157, 26);
            this.textTradeInAllowance.TabIndex = 6;
            this.textTradeInAllowance.Text = "0";
            // 
            // textAmountDue
            // 
            this.textAmountDue.Location = new System.Drawing.Point(192, 323);
            this.textAmountDue.Name = "textAmountDue";
            this.textAmountDue.ReadOnly = true;
            this.textAmountDue.Size = new System.Drawing.Size(157, 26);
            this.textAmountDue.TabIndex = 7;
            this.textAmountDue.Text = "0.00";
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(83, 81);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(93, 20);
            this.basePriceLabel.TabIndex = 8;
            this.basePriceLabel.Text = "Base Price :";
            // 
            // additionalOptionsLabel
            // 
            this.additionalOptionsLabel.AutoSize = true;
            this.additionalOptionsLabel.Location = new System.Drawing.Point(30, 122);
            this.additionalOptionsLabel.Name = "additionalOptionsLabel";
            this.additionalOptionsLabel.Size = new System.Drawing.Size(146, 20);
            this.additionalOptionsLabel.TabIndex = 9;
            this.additionalOptionsLabel.Text = "Additional Options :";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(91, 164);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(85, 20);
            this.subTotalLabel.TabIndex = 10;
            this.subTotalLabel.Text = "Sub Total :";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(44, 205);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(132, 20);
            this.salesTaxLabel.TabIndex = 11;
            this.salesTaxLabel.Text = "Sales Tax (13%) :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(124, 246);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(52, 20);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total :";
            // 
            // tradeInAllowanceLabel
            // 
            this.tradeInAllowanceLabel.AutoSize = true;
            this.tradeInAllowanceLabel.Location = new System.Drawing.Point(25, 287);
            this.tradeInAllowanceLabel.Name = "tradeInAllowanceLabel";
            this.tradeInAllowanceLabel.Size = new System.Drawing.Size(151, 20);
            this.tradeInAllowanceLabel.TabIndex = 13;
            this.tradeInAllowanceLabel.Text = "Trade-in Allowance :";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(68, 323);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(107, 20);
            this.amountDueLabel.TabIndex = 14;
            this.amountDueLabel.Text = "Amount Due :";
            // 
            // additionalItemsGroupBox
            // 
            this.additionalItemsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.additionalItemsGroupBox.Controls.Add(this.computerNavigationCheckBox);
            this.additionalItemsGroupBox.Controls.Add(this.leatherInteriorCheckBox);
            this.additionalItemsGroupBox.Controls.Add(this.stereoSystemcheckBox);
            this.additionalItemsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.additionalItemsGroupBox.Location = new System.Drawing.Point(381, 69);
            this.additionalItemsGroupBox.Name = "additionalItemsGroupBox";
            this.additionalItemsGroupBox.Size = new System.Drawing.Size(220, 191);
            this.additionalItemsGroupBox.TabIndex = 15;
            this.additionalItemsGroupBox.TabStop = false;
            this.additionalItemsGroupBox.Text = "Additional Items";
            // 
            // computerNavigationCheckBox
            // 
            this.computerNavigationCheckBox.AutoSize = true;
            this.computerNavigationCheckBox.Location = new System.Drawing.Point(19, 130);
            this.computerNavigationCheckBox.Name = "computerNavigationCheckBox";
            this.computerNavigationCheckBox.Size = new System.Drawing.Size(183, 24);
            this.computerNavigationCheckBox.TabIndex = 2;
            this.computerNavigationCheckBox.Text = "Computer Navigation";
            this.computerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.computerNavigationCheckBox.CheckedChanged += new System.EventHandler(this.Checkbox_checkChanged);
            // 
            // leatherInteriorCheckBox
            // 
            this.leatherInteriorCheckBox.AutoSize = true;
            this.leatherInteriorCheckBox.Location = new System.Drawing.Point(19, 89);
            this.leatherInteriorCheckBox.Name = "leatherInteriorCheckBox";
            this.leatherInteriorCheckBox.Size = new System.Drawing.Size(144, 24);
            this.leatherInteriorCheckBox.TabIndex = 1;
            this.leatherInteriorCheckBox.Text = "Leather Interior";
            this.leatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.leatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this.Checkbox_checkChanged);
            // 
            // stereoSystemcheckBox
            // 
            this.stereoSystemcheckBox.AutoSize = true;
            this.stereoSystemcheckBox.Location = new System.Drawing.Point(19, 46);
            this.stereoSystemcheckBox.Name = "stereoSystemcheckBox";
            this.stereoSystemcheckBox.Size = new System.Drawing.Size(140, 24);
            this.stereoSystemcheckBox.TabIndex = 0;
            this.stereoSystemcheckBox.Text = "Stereo System";
            this.stereoSystemcheckBox.UseVisualStyleBackColor = true;
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customizedDetailingRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.pearlizedRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardRadioButton);
            this.exteriorFinishGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(381, 275);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(220, 166);
            this.exteriorFinishGroupBox.TabIndex = 16;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // customizedDetailingRadioButton
            // 
            this.customizedDetailingRadioButton.AutoSize = true;
            this.customizedDetailingRadioButton.Location = new System.Drawing.Point(19, 125);
            this.customizedDetailingRadioButton.Name = "customizedDetailingRadioButton";
            this.customizedDetailingRadioButton.Size = new System.Drawing.Size(184, 24);
            this.customizedDetailingRadioButton.TabIndex = 2;
            this.customizedDetailingRadioButton.Text = "Customized Detailing";
            this.customizedDetailingRadioButton.UseVisualStyleBackColor = true;
            this.customizedDetailingRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // pearlizedRadioButton
            // 
            this.pearlizedRadioButton.AutoSize = true;
            this.pearlizedRadioButton.Location = new System.Drawing.Point(19, 85);
            this.pearlizedRadioButton.Name = "pearlizedRadioButton";
            this.pearlizedRadioButton.Size = new System.Drawing.Size(99, 24);
            this.pearlizedRadioButton.TabIndex = 1;
            this.pearlizedRadioButton.Text = "Pearlized";
            this.pearlizedRadioButton.UseVisualStyleBackColor = true;
            this.pearlizedRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Location = new System.Drawing.Point(19, 42);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(100, 24);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(25, 507);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(150, 39);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 507);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 39);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(441, 507);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 39);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SharpAutoCenterForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 558);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.additionalItemsGroupBox);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeInAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.additionalOptionsLabel);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.textAmountDue);
            this.Controls.Add(this.textTradeInAllowance);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textSalesTax);
            this.Controls.Add(this.texSubTotal);
            this.Controls.Add(this.textAdditionalOptions);
            this.Controls.Add(this.textBasePrice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SharpAutoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp_Auto_Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SharpAutoCenterForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.additionalItemsGroupBox.ResumeLayout(false);
            this.additionalItemsGroupBox.PerformLayout();
            this.exteriorFinishGroupBox.ResumeLayout(false);
            this.exteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog sharpAutoCentreDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBasePrice;
        private System.Windows.Forms.TextBox textAdditionalOptions;
        private System.Windows.Forms.TextBox texSubTotal;
        private System.Windows.Forms.TextBox textSalesTax;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textTradeInAllowance;
        private System.Windows.Forms.TextBox textAmountDue;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Label additionalOptionsLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeInAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.GroupBox additionalItemsGroupBox;
        private System.Windows.Forms.CheckBox computerNavigationCheckBox;
        private System.Windows.Forms.CheckBox leatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox stereoSystemcheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton customizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton pearlizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

