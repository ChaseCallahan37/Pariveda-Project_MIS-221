namespace AccountingProgram
{
    partial class PayrollScreen
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
            this.clearButton = new System.Windows.Forms.Button();
            this.viewPayrollTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.editPayrollPanel = new System.Windows.Forms.Panel();
            this.deletePayrollButton = new System.Windows.Forms.Button();
            this.payrollEditIdTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.deletePayrollPanel = new System.Windows.Forms.Panel();
            this.editPayrollButton = new System.Windows.Forms.Button();
            this.editPayrollIdButton = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.runPayrollRadio = new System.Windows.Forms.RadioButton();
            this.deletePayrollId = new System.Windows.Forms.RadioButton();
            this.editPayrollRadio = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.payrollHoursSearchTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.employeeNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.processPayrollPanel = new System.Windows.Forms.Panel();
            this.Process = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.editPayrollPanel.SuspendLayout();
            this.deletePayrollPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.processPayrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(181, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Back";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // viewPayrollTextBox
            // 
            this.viewPayrollTextBox.Enabled = false;
            this.viewPayrollTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPayrollTextBox.Location = new System.Drawing.Point(33, 53);
            this.viewPayrollTextBox.Multiline = true;
            this.viewPayrollTextBox.Name = "viewPayrollTextBox";
            this.viewPayrollTextBox.Size = new System.Drawing.Size(1481, 670);
            this.viewPayrollTextBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.editPayrollPanel);
            this.panel7.Controls.Add(this.deletePayrollPanel);
            this.panel7.Controls.Add(this.clearButton);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.processPayrollPanel);
            this.panel7.Controls.Add(this.label29);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1673, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(273, 1106);
            this.panel7.TabIndex = 9;
            // 
            // editPayrollPanel
            // 
            this.editPayrollPanel.Controls.Add(this.deletePayrollButton);
            this.editPayrollPanel.Controls.Add(this.payrollEditIdTextBox);
            this.editPayrollPanel.Controls.Add(this.label20);
            this.editPayrollPanel.Controls.Add(this.label21);
            this.editPayrollPanel.Location = new System.Drawing.Point(14, 583);
            this.editPayrollPanel.Name = "editPayrollPanel";
            this.editPayrollPanel.Size = new System.Drawing.Size(242, 252);
            this.editPayrollPanel.TabIndex = 7;
            // 
            // deletePayrollButton
            // 
            this.deletePayrollButton.Location = new System.Drawing.Point(18, 178);
            this.deletePayrollButton.Name = "deletePayrollButton";
            this.deletePayrollButton.Size = new System.Drawing.Size(148, 52);
            this.deletePayrollButton.TabIndex = 11;
            this.deletePayrollButton.Text = "Delete";
            this.deletePayrollButton.UseVisualStyleBackColor = true;
            this.deletePayrollButton.Click += new System.EventHandler(this.deletePayrollButton_Click);
            // 
            // payrollEditIdTextBox
            // 
            this.payrollEditIdTextBox.Location = new System.Drawing.Point(8, 108);
            this.payrollEditIdTextBox.Name = "payrollEditIdTextBox";
            this.payrollEditIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.payrollEditIdTextBox.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(187, 40);
            this.label20.TabIndex = 0;
            this.label20.Text = "Enter the Id of the payroll\r\nyou would like to delete";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(16, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 22);
            this.label21.TabIndex = 9;
            this.label21.Text = "ID Number";
            // 
            // deletePayrollPanel
            // 
            this.deletePayrollPanel.Controls.Add(this.editPayrollButton);
            this.deletePayrollPanel.Controls.Add(this.editPayrollIdButton);
            this.deletePayrollPanel.Controls.Add(this.label22);
            this.deletePayrollPanel.Controls.Add(this.label23);
            this.deletePayrollPanel.Location = new System.Drawing.Point(14, 583);
            this.deletePayrollPanel.Name = "deletePayrollPanel";
            this.deletePayrollPanel.Size = new System.Drawing.Size(242, 252);
            this.deletePayrollPanel.TabIndex = 8;
            // 
            // editPayrollButton
            // 
            this.editPayrollButton.Location = new System.Drawing.Point(18, 178);
            this.editPayrollButton.Name = "editPayrollButton";
            this.editPayrollButton.Size = new System.Drawing.Size(148, 52);
            this.editPayrollButton.TabIndex = 11;
            this.editPayrollButton.Text = "Edit";
            this.editPayrollButton.UseVisualStyleBackColor = true;
            // 
            // editPayrollIdButton
            // 
            this.editPayrollIdButton.Location = new System.Drawing.Point(8, 108);
            this.editPayrollIdButton.Name = "editPayrollIdButton";
            this.editPayrollIdButton.Size = new System.Drawing.Size(100, 26);
            this.editPayrollIdButton.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 60);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the Id of the payroll\r\nyou would like to edit\r\n\r\n";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(16, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 22);
            this.label23.TabIndex = 9;
            this.label23.Text = "ID Number";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.runPayrollRadio);
            this.panel10.Controls.Add(this.deletePayrollId);
            this.panel10.Controls.Add(this.editPayrollRadio);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel10.Location = new System.Drawing.Point(14, 315);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(222, 217);
            this.panel10.TabIndex = 8;
            // 
            // runPayrollRadio
            // 
            this.runPayrollRadio.AutoSize = true;
            this.runPayrollRadio.Location = new System.Drawing.Point(3, 163);
            this.runPayrollRadio.Name = "runPayrollRadio";
            this.runPayrollRadio.Size = new System.Drawing.Size(114, 24);
            this.runPayrollRadio.TabIndex = 11;
            this.runPayrollRadio.TabStop = true;
            this.runPayrollRadio.Text = "Run Payroll";
            this.runPayrollRadio.UseVisualStyleBackColor = true;
            this.runPayrollRadio.CheckedChanged += new System.EventHandler(this.runPayrollRadio_CheckedChanged);
            // 
            // deletePayrollId
            // 
            this.deletePayrollId.AutoSize = true;
            this.deletePayrollId.Location = new System.Drawing.Point(3, 108);
            this.deletePayrollId.Name = "deletePayrollId";
            this.deletePayrollId.Size = new System.Drawing.Size(131, 24);
            this.deletePayrollId.TabIndex = 10;
            this.deletePayrollId.TabStop = true;
            this.deletePayrollId.Text = "Delete Payroll";
            this.deletePayrollId.UseVisualStyleBackColor = true;
            this.deletePayrollId.CheckedChanged += new System.EventHandler(this.deletePayrollId_CheckedChanged);
            // 
            // editPayrollRadio
            // 
            this.editPayrollRadio.AutoSize = true;
            this.editPayrollRadio.Location = new System.Drawing.Point(3, 58);
            this.editPayrollRadio.Name = "editPayrollRadio";
            this.editPayrollRadio.Size = new System.Drawing.Size(112, 24);
            this.editPayrollRadio.TabIndex = 9;
            this.editPayrollRadio.TabStop = true;
            this.editPayrollRadio.Text = "Edit Payroll";
            this.editPayrollRadio.UseVisualStyleBackColor = true;
            this.editPayrollRadio.CheckedChanged += new System.EventHandler(this.editPayrollRadio_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(197, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "What would you like to do?";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.payrollHoursSearchTextBox);
            this.panel11.Controls.Add(this.label27);
            this.panel11.Controls.Add(this.employeeNameSearchTextBox);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel11.Location = new System.Drawing.Point(22, 107);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(190, 171);
            this.panel11.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 63);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 20);
            this.label25.TabIndex = 8;
            this.label25.Text = "Enter Hours Worked";
            // 
            // payrollHoursSearchTextBox
            // 
            this.payrollHoursSearchTextBox.Location = new System.Drawing.Point(21, 85);
            this.payrollHoursSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payrollHoursSearchTextBox.Name = "payrollHoursSearchTextBox";
            this.payrollHoursSearchTextBox.Size = new System.Drawing.Size(148, 26);
            this.payrollHoursSearchTextBox.TabIndex = 7;
            this.payrollHoursSearchTextBox.TextChanged += new System.EventHandler(this.payrollHoursSearchTextBox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 6);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(168, 20);
            this.label27.TabIndex = 1;
            this.label27.Text = "Enter Employee Name";
            // 
            // employeeNameSearchTextBox
            // 
            this.employeeNameSearchTextBox.Location = new System.Drawing.Point(21, 32);
            this.employeeNameSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeNameSearchTextBox.Name = "employeeNameSearchTextBox";
            this.employeeNameSearchTextBox.Size = new System.Drawing.Size(148, 26);
            this.employeeNameSearchTextBox.TabIndex = 6;
            this.employeeNameSearchTextBox.TextChanged += new System.EventHandler(this.employeeNameSearchTextBox_TextChanged);
            // 
            // processPayrollPanel
            // 
            this.processPayrollPanel.Controls.Add(this.Process);
            this.processPayrollPanel.Controls.Add(this.label28);
            this.processPayrollPanel.Location = new System.Drawing.Point(14, 583);
            this.processPayrollPanel.Name = "processPayrollPanel";
            this.processPayrollPanel.Size = new System.Drawing.Size(242, 252);
            this.processPayrollPanel.TabIndex = 9;
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(34, 107);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(148, 52);
            this.Process.TabIndex = 11;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 80);
            this.label28.TabIndex = 0;
            this.label28.Text = "Would you like to\r\nProcess Payroll?\r\n\r\n\r\n";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.Location = new System.Drawing.Point(70, 66);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 20);
            this.label29.TabIndex = 0;
            this.label29.Text = "Search";
            // 
            // PayrollScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.viewPayrollTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayrollScreen";
            this.Text = "PayrollScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PayrollScreen_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.editPayrollPanel.ResumeLayout(false);
            this.editPayrollPanel.PerformLayout();
            this.deletePayrollPanel.ResumeLayout(false);
            this.deletePayrollPanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.processPayrollPanel.ResumeLayout(false);
            this.processPayrollPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox viewPayrollTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel editPayrollPanel;
        private System.Windows.Forms.Button deletePayrollButton;
        private System.Windows.Forms.TextBox payrollEditIdTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel deletePayrollPanel;
        private System.Windows.Forms.Button editPayrollButton;
        private System.Windows.Forms.TextBox editPayrollIdButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton runPayrollRadio;
        private System.Windows.Forms.RadioButton deletePayrollId;
        private System.Windows.Forms.RadioButton editPayrollRadio;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox payrollHoursSearchTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox employeeNameSearchTextBox;
        private System.Windows.Forms.Panel processPayrollPanel;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}