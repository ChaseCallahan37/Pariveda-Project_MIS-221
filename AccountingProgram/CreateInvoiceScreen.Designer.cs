namespace AccountingProgram
{
    partial class CreateInvoiceScreen
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
            this.components = new System.ComponentModel.Container();
            this.overallPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.saveIncoiceButton = new System.Windows.Forms.Button();
            this.invoiceTotalLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cutomerInfoPanel = new System.Windows.Forms.Panel();
            this.dateDuePicker = new System.Windows.Forms.DateTimePicker();
            this.dateSoldMenu = new System.Windows.Forms.DateTimePicker();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.itemsPurchasedPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deluxeBagTotal = new System.Windows.Forms.Label();
            this.delBagQuanTextBox = new System.Windows.Forms.TextBox();
            this.delBagLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.standardBagTotal = new System.Windows.Forms.Label();
            this.stanBagQuanTextBox = new System.Windows.Forms.TextBox();
            this.stanBagLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.luxuryBagTotal = new System.Windows.Forms.Label();
            this.luxBagQuanTextBox = new System.Windows.Forms.TextBox();
            this.luxBagLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityItemsPurchasedLabel = new System.Windows.Forms.Label();
            this.itemsPurchasedNameLabel = new System.Windows.Forms.Label();
            this.itemsPurchasedLabel = new System.Windows.Forms.Label();
            this.createInvoiceSubHeader = new System.Windows.Forms.Label();
            this.createInvoiceHeaderLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.overallPanel.SuspendLayout();
            this.cutomerInfoPanel.SuspendLayout();
            this.itemsPurchasedPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // overallPanel
            // 
            this.overallPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overallPanel.Controls.Add(this.backButton);
            this.overallPanel.Controls.Add(this.saveIncoiceButton);
            this.overallPanel.Controls.Add(this.invoiceTotalLabel);
            this.overallPanel.Controls.Add(this.label14);
            this.overallPanel.Controls.Add(this.cutomerInfoPanel);
            this.overallPanel.Controls.Add(this.itemsPurchasedPanel);
            this.overallPanel.Controls.Add(this.itemsPurchasedLabel);
            this.overallPanel.Controls.Add(this.createInvoiceSubHeader);
            this.overallPanel.Controls.Add(this.createInvoiceHeaderLabel);
            this.overallPanel.Location = new System.Drawing.Point(724, 11);
            this.overallPanel.Name = "overallPanel";
            this.overallPanel.Size = new System.Drawing.Size(484, 627);
            this.overallPanel.TabIndex = 0;
            this.overallPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.overallPanel_Paint);
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(70, 566);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 35);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Cancel";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveIncoiceButton
            // 
            this.saveIncoiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveIncoiceButton.Location = new System.Drawing.Point(250, 566);
            this.saveIncoiceButton.Name = "saveIncoiceButton";
            this.saveIncoiceButton.Size = new System.Drawing.Size(154, 35);
            this.saveIncoiceButton.TabIndex = 7;
            this.saveIncoiceButton.Text = "Save Invoice";
            this.saveIncoiceButton.UseVisualStyleBackColor = true;
            this.saveIncoiceButton.Click += new System.EventHandler(this.saveIncoiceButton_Click);
            // 
            // invoiceTotalLabel
            // 
            this.invoiceTotalLabel.BackColor = System.Drawing.SystemColors.Window;
            this.invoiceTotalLabel.Location = new System.Drawing.Point(320, 480);
            this.invoiceTotalLabel.Name = "invoiceTotalLabel";
            this.invoiceTotalLabel.Size = new System.Drawing.Size(87, 26);
            this.invoiceTotalLabel.TabIndex = 23;
            this.invoiceTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoiceTotalLabel.Click += new System.EventHandler(this.invoiceTotalLabel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(87, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Invoice Total";
            // 
            // cutomerInfoPanel
            // 
            this.cutomerInfoPanel.Controls.Add(this.dateDuePicker);
            this.cutomerInfoPanel.Controls.Add(this.dateSoldMenu);
            this.cutomerInfoPanel.Controls.Add(this.customerNameTextBox);
            this.cutomerInfoPanel.Controls.Add(this.label11);
            this.cutomerInfoPanel.Controls.Add(this.label12);
            this.cutomerInfoPanel.Controls.Add(this.label13);
            this.cutomerInfoPanel.Location = new System.Drawing.Point(16, 57);
            this.cutomerInfoPanel.Name = "cutomerInfoPanel";
            this.cutomerInfoPanel.Size = new System.Drawing.Size(452, 158);
            this.cutomerInfoPanel.TabIndex = 14;
            // 
            // dateDuePicker
            // 
            this.dateDuePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDuePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDuePicker.Location = new System.Drawing.Point(183, 128);
            this.dateDuePicker.Name = "dateDuePicker";
            this.dateDuePicker.Size = new System.Drawing.Size(139, 26);
            this.dateDuePicker.TabIndex = 3;
            this.dateDuePicker.ValueChanged += new System.EventHandler(this.dateDuePicker_ValueChanged);
            // 
            // dateSoldMenu
            // 
            this.dateSoldMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateSoldMenu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSoldMenu.Location = new System.Drawing.Point(183, 72);
            this.dateSoldMenu.Name = "dateSoldMenu";
            this.dateSoldMenu.Size = new System.Drawing.Size(139, 26);
            this.dateSoldMenu.TabIndex = 2;
            this.dateSoldMenu.ValueChanged += new System.EventHandler(this.dateSoldMenu_ValueChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(183, 14);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(266, 26);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(46, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "Date Sold";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(50, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Date Due";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(3, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "Customer Name";
            // 
            // itemsPurchasedPanel
            // 
            this.itemsPurchasedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsPurchasedPanel.Controls.Add(this.panel6);
            this.itemsPurchasedPanel.Controls.Add(this.panel5);
            this.itemsPurchasedPanel.Controls.Add(this.panel4);
            this.itemsPurchasedPanel.Controls.Add(this.label1);
            this.itemsPurchasedPanel.Controls.Add(this.quantityItemsPurchasedLabel);
            this.itemsPurchasedPanel.Controls.Add(this.itemsPurchasedNameLabel);
            this.itemsPurchasedPanel.Location = new System.Drawing.Point(66, 278);
            this.itemsPurchasedPanel.Name = "itemsPurchasedPanel";
            this.itemsPurchasedPanel.Size = new System.Drawing.Size(348, 171);
            this.itemsPurchasedPanel.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deluxeBagTotal);
            this.panel6.Controls.Add(this.delBagQuanTextBox);
            this.panel6.Controls.Add(this.delBagLabel);
            this.panel6.Location = new System.Drawing.Point(3, 122);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 46);
            this.panel6.TabIndex = 14;
            // 
            // deluxeBagTotal
            // 
            this.deluxeBagTotal.BackColor = System.Drawing.SystemColors.Window;
            this.deluxeBagTotal.Location = new System.Drawing.Point(261, 9);
            this.deluxeBagTotal.Name = "deluxeBagTotal";
            this.deluxeBagTotal.Size = new System.Drawing.Size(70, 26);
            this.deluxeBagTotal.TabIndex = 22;
            this.deluxeBagTotal.Click += new System.EventHandler(this.deluxeBagTotal_Click);
            // 
            // delBagQuanTextBox
            // 
            this.delBagQuanTextBox.Location = new System.Drawing.Point(154, 9);
            this.delBagQuanTextBox.Name = "delBagQuanTextBox";
            this.delBagQuanTextBox.Size = new System.Drawing.Size(70, 26);
            this.delBagQuanTextBox.TabIndex = 6;
            this.delBagQuanTextBox.TextChanged += new System.EventHandler(this.delBagQuanTextBox_TextChanged);
            // 
            // delBagLabel
            // 
            this.delBagLabel.AutoSize = true;
            this.delBagLabel.Location = new System.Drawing.Point(28, 12);
            this.delBagLabel.Name = "delBagLabel";
            this.delBagLabel.Size = new System.Drawing.Size(91, 20);
            this.delBagLabel.TabIndex = 19;
            this.delBagLabel.Text = "Deluxe Bag";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.standardBagTotal);
            this.panel5.Controls.Add(this.stanBagQuanTextBox);
            this.panel5.Controls.Add(this.stanBagLabel);
            this.panel5.Location = new System.Drawing.Point(3, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 46);
            this.panel5.TabIndex = 14;
            // 
            // standardBagTotal
            // 
            this.standardBagTotal.BackColor = System.Drawing.SystemColors.Window;
            this.standardBagTotal.Location = new System.Drawing.Point(261, 9);
            this.standardBagTotal.Name = "standardBagTotal";
            this.standardBagTotal.Size = new System.Drawing.Size(70, 26);
            this.standardBagTotal.TabIndex = 22;
            this.standardBagTotal.Click += new System.EventHandler(this.standardBagTotal_Click);
            // 
            // stanBagQuanTextBox
            // 
            this.stanBagQuanTextBox.Location = new System.Drawing.Point(154, 9);
            this.stanBagQuanTextBox.Name = "stanBagQuanTextBox";
            this.stanBagQuanTextBox.Size = new System.Drawing.Size(70, 26);
            this.stanBagQuanTextBox.TabIndex = 5;
            this.stanBagQuanTextBox.TextChanged += new System.EventHandler(this.stanBagQuanTextBox_TextChanged);
            // 
            // stanBagLabel
            // 
            this.stanBagLabel.AutoSize = true;
            this.stanBagLabel.Location = new System.Drawing.Point(28, 12);
            this.stanBagLabel.Name = "stanBagLabel";
            this.stanBagLabel.Size = new System.Drawing.Size(108, 20);
            this.stanBagLabel.TabIndex = 19;
            this.stanBagLabel.Text = "Standard Bag";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.luxuryBagTotal);
            this.panel4.Controls.Add(this.luxBagQuanTextBox);
            this.panel4.Controls.Add(this.luxBagLabel);
            this.panel4.Location = new System.Drawing.Point(3, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 46);
            this.panel4.TabIndex = 14;
            // 
            // luxuryBagTotal
            // 
            this.luxuryBagTotal.BackColor = System.Drawing.SystemColors.Window;
            this.luxuryBagTotal.Location = new System.Drawing.Point(261, 9);
            this.luxuryBagTotal.Name = "luxuryBagTotal";
            this.luxuryBagTotal.Size = new System.Drawing.Size(70, 26);
            this.luxuryBagTotal.TabIndex = 22;
            this.luxuryBagTotal.Click += new System.EventHandler(this.luxuryBagTotal_Click);
            // 
            // luxBagQuanTextBox
            // 
            this.luxBagQuanTextBox.Location = new System.Drawing.Point(154, 9);
            this.luxBagQuanTextBox.Name = "luxBagQuanTextBox";
            this.luxBagQuanTextBox.Size = new System.Drawing.Size(70, 26);
            this.luxBagQuanTextBox.TabIndex = 4;
            this.luxBagQuanTextBox.TextChanged += new System.EventHandler(this.luxBagQuanTextBox_TextChanged);
            // 
            // luxBagLabel
            // 
            this.luxBagLabel.AutoSize = true;
            this.luxBagLabel.Location = new System.Drawing.Point(28, 12);
            this.luxBagLabel.Name = "luxBagLabel";
            this.luxBagLabel.Size = new System.Drawing.Size(88, 20);
            this.luxBagLabel.TabIndex = 19;
            this.luxBagLabel.Text = "Luxury Bag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(272, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total";
            // 
            // quantityItemsPurchasedLabel
            // 
            this.quantityItemsPurchasedLabel.AutoSize = true;
            this.quantityItemsPurchasedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityItemsPurchasedLabel.Location = new System.Drawing.Point(160, 0);
            this.quantityItemsPurchasedLabel.Name = "quantityItemsPurchasedLabel";
            this.quantityItemsPurchasedLabel.Size = new System.Drawing.Size(70, 22);
            this.quantityItemsPurchasedLabel.TabIndex = 11;
            this.quantityItemsPurchasedLabel.Text = "Quantity";
            // 
            // itemsPurchasedNameLabel
            // 
            this.itemsPurchasedNameLabel.AutoSize = true;
            this.itemsPurchasedNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsPurchasedNameLabel.Location = new System.Drawing.Point(42, 0);
            this.itemsPurchasedNameLabel.Name = "itemsPurchasedNameLabel";
            this.itemsPurchasedNameLabel.Size = new System.Drawing.Size(53, 22);
            this.itemsPurchasedNameLabel.TabIndex = 13;
            this.itemsPurchasedNameLabel.Text = "Name";
            // 
            // itemsPurchasedLabel
            // 
            this.itemsPurchasedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsPurchasedLabel.Location = new System.Drawing.Point(136, 228);
            this.itemsPurchasedLabel.Name = "itemsPurchasedLabel";
            this.itemsPurchasedLabel.Size = new System.Drawing.Size(191, 39);
            this.itemsPurchasedLabel.TabIndex = 5;
            this.itemsPurchasedLabel.Text = "Items Purchased";
            this.itemsPurchasedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createInvoiceSubHeader
            // 
            this.createInvoiceSubHeader.AutoSize = true;
            this.createInvoiceSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceSubHeader.Location = new System.Drawing.Point(116, 29);
            this.createInvoiceSubHeader.Name = "createInvoiceSubHeader";
            this.createInvoiceSubHeader.Size = new System.Drawing.Size(243, 25);
            this.createInvoiceSubHeader.TabIndex = 1;
            this.createInvoiceSubHeader.Text = "Insert Information Below";
            this.createInvoiceSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createInvoiceHeaderLabel
            // 
            this.createInvoiceHeaderLabel.AutoSize = true;
            this.createInvoiceHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceHeaderLabel.Location = new System.Drawing.Point(147, 0);
            this.createInvoiceHeaderLabel.Name = "createInvoiceHeaderLabel";
            this.createInvoiceHeaderLabel.Size = new System.Drawing.Size(181, 29);
            this.createInvoiceHeaderLabel.TabIndex = 0;
            this.createInvoiceHeaderLabel.Text = "Create Invoice";
            this.createInvoiceHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createInvoiceHeaderLabel.Click += new System.EventHandler(this.createInvoiceHeaderLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(1823, 11);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Return";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // CreateInvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.overallPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 225);
            this.Name = "CreateInvoiceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create Invoice Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateInvoiceScreen_Load);
            this.overallPanel.ResumeLayout(false);
            this.overallPanel.PerformLayout();
            this.cutomerInfoPanel.ResumeLayout(false);
            this.cutomerInfoPanel.PerformLayout();
            this.itemsPurchasedPanel.ResumeLayout(false);
            this.itemsPurchasedPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel overallPanel;
        private System.Windows.Forms.Label createInvoiceSubHeader;
        private System.Windows.Forms.Label createInvoiceHeaderLabel;
        private System.Windows.Forms.Label itemsPurchasedLabel;
        private System.Windows.Forms.Panel itemsPurchasedPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label standardBagTotal;
        private System.Windows.Forms.TextBox stanBagQuanTextBox;
        private System.Windows.Forms.Label stanBagLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label luxuryBagTotal;
        private System.Windows.Forms.TextBox luxBagQuanTextBox;
        private System.Windows.Forms.Label luxBagLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantityItemsPurchasedLabel;
        private System.Windows.Forms.Label itemsPurchasedNameLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label deluxeBagTotal;
        private System.Windows.Forms.TextBox delBagQuanTextBox;
        private System.Windows.Forms.Label delBagLabel;
        private System.Windows.Forms.Panel cutomerInfoPanel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button saveIncoiceButton;
        private System.Windows.Forms.Label invoiceTotalLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker dateDuePicker;
        private System.Windows.Forms.DateTimePicker dateSoldMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clearButton;
    }
}