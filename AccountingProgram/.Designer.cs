namespace AccountingProgram
{
    partial class viewInvoiceScreen
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.invoiceInteractionPanel = new System.Windows.Forms.Panel();
            this.editInvoicePanel = new System.Windows.Forms.Panel();
            this.editInvoiceButton = new System.Windows.Forms.Button();
            this.editInvoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createInvoicePanel = new System.Windows.Forms.Panel();
            this.createInvoiceButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteInvoicePanel = new System.Windows.Forms.Panel();
            this.invoiceDeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteInvoiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeChoicePanel = new System.Windows.Forms.Panel();
            this.createInvoiceRadio = new System.Windows.Forms.RadioButton();
            this.deleteInvoiceRadio = new System.Windows.Forms.RadioButton();
            this.editInvoiceRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.companySearchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.viewTextBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeAllWindows = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.viewInvoiceLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.invoiceInteractionPanel.SuspendLayout();
            this.editInvoicePanel.SuspendLayout();
            this.createInvoicePanel.SuspendLayout();
            this.deleteInvoicePanel.SuspendLayout();
            this.employeeChoicePanel.SuspendLayout();
            this.companySearchPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.viewTextBox);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1946, 1106);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1632, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 1106);
            this.panel1.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.invoiceInteractionPanel);
            this.searchPanel.Controls.Add(this.employeeChoicePanel);
            this.searchPanel.Controls.Add(this.companySearchPanel);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(16, 152);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(289, 742);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // invoiceInteractionPanel
            // 
            this.invoiceInteractionPanel.Controls.Add(this.editInvoicePanel);
            this.invoiceInteractionPanel.Controls.Add(this.createInvoicePanel);
            this.invoiceInteractionPanel.Controls.Add(this.deleteInvoicePanel);
            this.invoiceInteractionPanel.Location = new System.Drawing.Point(6, 417);
            this.invoiceInteractionPanel.Name = "invoiceInteractionPanel";
            this.invoiceInteractionPanel.Size = new System.Drawing.Size(283, 296);
            this.invoiceInteractionPanel.TabIndex = 10;
            // 
            // editInvoicePanel
            // 
            this.editInvoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editInvoicePanel.Controls.Add(this.editInvoiceButton);
            this.editInvoicePanel.Controls.Add(this.editInvoiceIdTextBox);
            this.editInvoicePanel.Controls.Add(this.label7);
            this.editInvoicePanel.Controls.Add(this.label8);
            this.editInvoicePanel.Location = new System.Drawing.Point(12, 3);
            this.editInvoicePanel.Name = "editInvoicePanel";
            this.editInvoicePanel.Size = new System.Drawing.Size(242, 252);
            this.editInvoicePanel.TabIndex = 8;
            // 
            // editInvoiceButton
            // 
            this.editInvoiceButton.Location = new System.Drawing.Point(16, 178);
            this.editInvoiceButton.Name = "editInvoiceButton";
            this.editInvoiceButton.Size = new System.Drawing.Size(148, 52);
            this.editInvoiceButton.TabIndex = 11;
            this.editInvoiceButton.Text = "Edit";
            this.editInvoiceButton.UseVisualStyleBackColor = true;
            this.editInvoiceButton.Click += new System.EventHandler(this.editInvoiceButton_Click_1);
            // 
            // editInvoiceIdTextBox
            // 
            this.editInvoiceIdTextBox.Location = new System.Drawing.Point(16, 126);
            this.editInvoiceIdTextBox.Name = "editInvoiceIdTextBox";
            this.editInvoiceIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.editInvoiceIdTextBox.TabIndex = 10;
            this.editInvoiceIdTextBox.TextChanged += new System.EventHandler(this.editEmployeeTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 60);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter the Id of the invoice\r\nyou would like to edit\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(16, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Number";
            // 
            // createInvoicePanel
            // 
            this.createInvoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createInvoicePanel.Controls.Add(this.createInvoiceButton);
            this.createInvoicePanel.Controls.Add(this.label9);
            this.createInvoicePanel.Location = new System.Drawing.Point(12, 18);
            this.createInvoicePanel.Name = "createInvoicePanel";
            this.createInvoicePanel.Size = new System.Drawing.Size(242, 180);
            this.createInvoicePanel.TabIndex = 9;
            // 
            // createInvoiceButton
            // 
            this.createInvoiceButton.Location = new System.Drawing.Point(18, 103);
            this.createInvoiceButton.Name = "createInvoiceButton";
            this.createInvoiceButton.Size = new System.Drawing.Size(148, 52);
            this.createInvoiceButton.TabIndex = 11;
            this.createInvoiceButton.Text = "Create";
            this.createInvoiceButton.UseVisualStyleBackColor = true;
            this.createInvoiceButton.Click += new System.EventHandler(this.createInvoiceButton_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 80);
            this.label9.TabIndex = 0;
            this.label9.Text = "Would you like to\r\nCreate an Invoice?\r\n\r\n\r\n";
            // 
            // deleteInvoicePanel
            // 
            this.deleteInvoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteInvoicePanel.Controls.Add(this.invoiceDeleteIdTextBox);
            this.deleteInvoicePanel.Controls.Add(this.deleteInvoiceButton);
            this.deleteInvoicePanel.Controls.Add(this.label5);
            this.deleteInvoicePanel.Controls.Add(this.label6);
            this.deleteInvoicePanel.Location = new System.Drawing.Point(12, 18);
            this.deleteInvoicePanel.Name = "deleteInvoicePanel";
            this.deleteInvoicePanel.Size = new System.Drawing.Size(242, 252);
            this.deleteInvoicePanel.TabIndex = 7;
            // 
            // invoiceDeleteIdTextBox
            // 
            this.invoiceDeleteIdTextBox.Location = new System.Drawing.Point(18, 111);
            this.invoiceDeleteIdTextBox.Name = "invoiceDeleteIdTextBox";
            this.invoiceDeleteIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.invoiceDeleteIdTextBox.TabIndex = 10;
            this.invoiceDeleteIdTextBox.TextChanged += new System.EventHandler(this.employeeDeleteIdTextBox_TextChanged);
            // 
            // deleteInvoiceButton
            // 
            this.deleteInvoiceButton.Location = new System.Drawing.Point(18, 163);
            this.deleteInvoiceButton.Name = "deleteInvoiceButton";
            this.deleteInvoiceButton.Size = new System.Drawing.Size(148, 52);
            this.deleteInvoiceButton.TabIndex = 11;
            this.deleteInvoiceButton.Text = "Delete";
            this.deleteInvoiceButton.UseVisualStyleBackColor = true;
            this.deleteInvoiceButton.Click += new System.EventHandler(this.deleteInvoiceButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter the Id of the employee\r\nyou would like to delete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(18, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID Number";
            // 
            // employeeChoicePanel
            // 
            this.employeeChoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeChoicePanel.Controls.Add(this.createInvoiceRadio);
            this.employeeChoicePanel.Controls.Add(this.deleteInvoiceRadio);
            this.employeeChoicePanel.Controls.Add(this.editInvoiceRadio);
            this.employeeChoicePanel.Controls.Add(this.label4);
            this.employeeChoicePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeeChoicePanel.Location = new System.Drawing.Point(18, 172);
            this.employeeChoicePanel.Name = "employeeChoicePanel";
            this.employeeChoicePanel.Size = new System.Drawing.Size(217, 216);
            this.employeeChoicePanel.TabIndex = 9;
            // 
            // createInvoiceRadio
            // 
            this.createInvoiceRadio.AutoSize = true;
            this.createInvoiceRadio.Location = new System.Drawing.Point(3, 163);
            this.createInvoiceRadio.Name = "createInvoiceRadio";
            this.createInvoiceRadio.Size = new System.Drawing.Size(160, 24);
            this.createInvoiceRadio.TabIndex = 11;
            this.createInvoiceRadio.TabStop = true;
            this.createInvoiceRadio.Text = "Create An Invoice";
            this.createInvoiceRadio.UseVisualStyleBackColor = true;
            this.createInvoiceRadio.CheckedChanged += new System.EventHandler(this.createInvoiceRadio_CheckedChanged);
            // 
            // deleteInvoiceRadio
            // 
            this.deleteInvoiceRadio.AutoSize = true;
            this.deleteInvoiceRadio.Location = new System.Drawing.Point(3, 108);
            this.deleteInvoiceRadio.Name = "deleteInvoiceRadio";
            this.deleteInvoiceRadio.Size = new System.Drawing.Size(159, 24);
            this.deleteInvoiceRadio.TabIndex = 10;
            this.deleteInvoiceRadio.TabStop = true;
            this.deleteInvoiceRadio.Text = "Delete An Invoice";
            this.deleteInvoiceRadio.UseVisualStyleBackColor = true;
            this.deleteInvoiceRadio.CheckedChanged += new System.EventHandler(this.deleteInvoiceRadio_CheckedChanged);
            // 
            // editInvoiceRadio
            // 
            this.editInvoiceRadio.AutoSize = true;
            this.editInvoiceRadio.Location = new System.Drawing.Point(3, 58);
            this.editInvoiceRadio.Name = "editInvoiceRadio";
            this.editInvoiceRadio.Size = new System.Drawing.Size(140, 24);
            this.editInvoiceRadio.TabIndex = 9;
            this.editInvoiceRadio.TabStop = true;
            this.editInvoiceRadio.Text = "Edit An Invoice";
            this.editInvoiceRadio.UseVisualStyleBackColor = true;
            this.editInvoiceRadio.CheckedChanged += new System.EventHandler(this.editInvoiceRadio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "What would you like to do?";
            // 
            // companySearchPanel
            // 
            this.companySearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySearchPanel.Controls.Add(this.label1);
            this.companySearchPanel.Controls.Add(this.searchInvoiceTextBox);
            this.companySearchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.companySearchPanel.Location = new System.Drawing.Point(18, 45);
            this.companySearchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companySearchPanel.Name = "companySearchPanel";
            this.companySearchPanel.Size = new System.Drawing.Size(190, 105);
            this.companySearchPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Customer Name";
            // 
            // searchInvoiceTextBox
            // 
            this.searchInvoiceTextBox.Location = new System.Drawing.Point(20, 46);
            this.searchInvoiceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchInvoiceTextBox.Name = "searchInvoiceTextBox";
            this.searchInvoiceTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchInvoiceTextBox.TabIndex = 6;
            this.searchInvoiceTextBox.TextChanged += new System.EventHandler(this.searchInvoiceTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(0, 0);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(289, 51);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // viewTextBox
            // 
            this.viewTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewTextBox.Enabled = false;
            this.viewTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTextBox.Location = new System.Drawing.Point(13, 169);
            this.viewTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewTextBox.Multiline = true;
            this.viewTextBox.Name = "viewTextBox";
            this.viewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewTextBox.Size = new System.Drawing.Size(1612, 913);
            this.viewTextBox.TabIndex = 0;
            this.viewTextBox.TextChanged += new System.EventHandler(this.viewTextBox_TextChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topPanel.Controls.Add(this.closeAllWindows);
            this.topPanel.Controls.Add(this.clearButton);
            this.topPanel.Controls.Add(this.viewInvoiceLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1946, 142);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // closeAllWindows
            // 
            this.closeAllWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeAllWindows.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAllWindows.Location = new System.Drawing.Point(1855, 12);
            this.closeAllWindows.Name = "closeAllWindows";
            this.closeAllWindows.Size = new System.Drawing.Size(58, 49);
            this.closeAllWindows.TabIndex = 5;
            this.closeAllWindows.Text = "X";
            this.closeAllWindows.UseVisualStyleBackColor = false;
            this.closeAllWindows.Click += new System.EventHandler(this.closeAllWindows_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(1812, 78);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 49);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Return";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // viewInvoiceLabel
            // 
            this.viewInvoiceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvoiceLabel.Location = new System.Drawing.Point(0, 0);
            this.viewInvoiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewInvoiceLabel.Name = "viewInvoiceLabel";
            this.viewInvoiceLabel.Size = new System.Drawing.Size(1946, 35);
            this.viewInvoiceLabel.TabIndex = 0;
            this.viewInvoiceLabel.Text = "Invoice Screen";
            this.viewInvoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewInvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 110);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewInvoiceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View Invoice";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.invoiceInteractionPanel.ResumeLayout(false);
            this.editInvoicePanel.ResumeLayout(false);
            this.editInvoicePanel.PerformLayout();
            this.createInvoicePanel.ResumeLayout(false);
            this.createInvoicePanel.PerformLayout();
            this.deleteInvoicePanel.ResumeLayout(false);
            this.deleteInvoicePanel.PerformLayout();
            this.employeeChoicePanel.ResumeLayout(false);
            this.employeeChoicePanel.PerformLayout();
            this.companySearchPanel.ResumeLayout(false);
            this.companySearchPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label viewInvoiceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel companySearchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInvoiceTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox viewTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button closeAllWindows;
        private System.Windows.Forms.Panel employeeChoicePanel;
        private System.Windows.Forms.RadioButton createInvoiceRadio;
        private System.Windows.Forms.RadioButton deleteInvoiceRadio;
        private System.Windows.Forms.RadioButton editInvoiceRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel invoiceInteractionPanel;
        private System.Windows.Forms.Panel deleteInvoicePanel;
        private System.Windows.Forms.Button editInvoiceButton;
        private System.Windows.Forms.Panel editInvoicePanel;
        private System.Windows.Forms.Button deleteInvoiceButton;
        private System.Windows.Forms.TextBox editInvoiceIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox invoiceDeleteIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel createInvoicePanel;
        private System.Windows.Forms.Button createInvoiceButton;
        private System.Windows.Forms.Label label9;
    }
}