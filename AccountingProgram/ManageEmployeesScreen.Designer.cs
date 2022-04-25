namespace AccountingProgram
{
    partial class ManageEmployeesScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewEmployeeSearchTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editEmployeePanel = new System.Windows.Forms.Panel();
            this.deleteEmployeePanel = new System.Windows.Forms.Panel();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.employeeDeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editEmployee = new System.Windows.Forms.Button();
            this.editEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createEmployeePanel = new System.Windows.Forms.Panel();
            this.createEmployee = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeChoicePanel = new System.Windows.Forms.Panel();
            this.createEmployeeRadio = new System.Windows.Forms.RadioButton();
            this.deleteEmployeeRadio = new System.Windows.Forms.RadioButton();
            this.editEmployeeRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.companySearchPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchIdemployeeTextBox = new System.Windows.Forms.TextBox();
            this.searchEmployeeDeptTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmployeesTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeAllWindows = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.editEmployeePanel.SuspendLayout();
            this.deleteEmployeePanel.SuspendLayout();
            this.createEmployeePanel.SuspendLayout();
            this.employeeChoicePanel.SuspendLayout();
            this.companySearchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewEmployeeSearchTextBox
            // 
            this.viewEmployeeSearchTextBox.Enabled = false;
            this.viewEmployeeSearchTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmployeeSearchTextBox.Location = new System.Drawing.Point(12, 106);
            this.viewEmployeeSearchTextBox.Multiline = true;
            this.viewEmployeeSearchTextBox.Name = "viewEmployeeSearchTextBox";
            this.viewEmployeeSearchTextBox.Size = new System.Drawing.Size(1624, 988);
            this.viewEmployeeSearchTextBox.TabIndex = 8;
            this.viewEmployeeSearchTextBox.TextChanged += new System.EventHandler(this.viewEmployeeSearchTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.viewEmployeeSearchTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1946, 1106);
            this.panel3.TabIndex = 10;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.panel2);
            this.searchPanel.Controls.Add(this.employeeChoicePanel);
            this.searchPanel.Controls.Add(this.companySearchPanel);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(4, 139);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(273, 834);
            this.searchPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editEmployeePanel);
            this.panel2.Controls.Add(this.createEmployeePanel);
            this.panel2.Location = new System.Drawing.Point(18, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 386);
            this.panel2.TabIndex = 7;
            // 
            // editEmployeePanel
            // 
            this.editEmployeePanel.Controls.Add(this.deleteEmployeePanel);
            this.editEmployeePanel.Controls.Add(this.editEmployee);
            this.editEmployeePanel.Controls.Add(this.editEmployeeTextBox);
            this.editEmployeePanel.Controls.Add(this.label7);
            this.editEmployeePanel.Controls.Add(this.label8);
            this.editEmployeePanel.Location = new System.Drawing.Point(7, 12);
            this.editEmployeePanel.Name = "editEmployeePanel";
            this.editEmployeePanel.Size = new System.Drawing.Size(242, 252);
            this.editEmployeePanel.TabIndex = 8;
            this.editEmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editEmployeePanel_Paint);
            // 
            // deleteEmployeePanel
            // 
            this.deleteEmployeePanel.Controls.Add(this.deleteEmployeeButton);
            this.deleteEmployeePanel.Controls.Add(this.employeeDeleteIdTextBox);
            this.deleteEmployeePanel.Controls.Add(this.label5);
            this.deleteEmployeePanel.Controls.Add(this.label6);
            this.deleteEmployeePanel.Location = new System.Drawing.Point(0, 0);
            this.deleteEmployeePanel.Name = "deleteEmployeePanel";
            this.deleteEmployeePanel.Size = new System.Drawing.Size(242, 252);
            this.deleteEmployeePanel.TabIndex = 7;
            this.deleteEmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deleteEmployeePanel_Paint);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(8, 178);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(148, 52);
            this.deleteEmployeeButton.TabIndex = 11;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // employeeDeleteIdTextBox
            // 
            this.employeeDeleteIdTextBox.Location = new System.Drawing.Point(8, 108);
            this.employeeDeleteIdTextBox.Name = "employeeDeleteIdTextBox";
            this.employeeDeleteIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.employeeDeleteIdTextBox.TabIndex = 10;
            this.employeeDeleteIdTextBox.TextChanged += new System.EventHandler(this.employeeDeleteIdTextBox_TextChanged);
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
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID Number";
            // 
            // editEmployee
            // 
            this.editEmployee.Location = new System.Drawing.Point(18, 178);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(148, 52);
            this.editEmployee.TabIndex = 11;
            this.editEmployee.Text = "Edit";
            this.editEmployee.UseVisualStyleBackColor = true;
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // editEmployeeTextBox
            // 
            this.editEmployeeTextBox.Location = new System.Drawing.Point(8, 108);
            this.editEmployeeTextBox.Name = "editEmployeeTextBox";
            this.editEmployeeTextBox.Size = new System.Drawing.Size(100, 26);
            this.editEmployeeTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 60);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter the Id of the employee\r\nyou would like to edit\r\n\r\n";
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
            // createEmployeePanel
            // 
            this.createEmployeePanel.Controls.Add(this.createEmployee);
            this.createEmployeePanel.Controls.Add(this.label9);
            this.createEmployeePanel.Location = new System.Drawing.Point(10, 15);
            this.createEmployeePanel.Name = "createEmployeePanel";
            this.createEmployeePanel.Size = new System.Drawing.Size(242, 252);
            this.createEmployeePanel.TabIndex = 9;
            // 
            // createEmployee
            // 
            this.createEmployee.Location = new System.Drawing.Point(34, 107);
            this.createEmployee.Name = "createEmployee";
            this.createEmployee.Size = new System.Drawing.Size(148, 52);
            this.createEmployee.TabIndex = 11;
            this.createEmployee.Text = "Create";
            this.createEmployee.UseVisualStyleBackColor = true;
            this.createEmployee.Click += new System.EventHandler(this.createEmployee_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 80);
            this.label9.TabIndex = 0;
            this.label9.Text = "Would you like to\r\nCreate an Employee?\r\n\r\n\r\n";
            // 
            // employeeChoicePanel
            // 
            this.employeeChoicePanel.Controls.Add(this.createEmployeeRadio);
            this.employeeChoicePanel.Controls.Add(this.deleteEmployeeRadio);
            this.employeeChoicePanel.Controls.Add(this.editEmployeeRadio);
            this.employeeChoicePanel.Controls.Add(this.label4);
            this.employeeChoicePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeeChoicePanel.Location = new System.Drawing.Point(18, 225);
            this.employeeChoicePanel.Name = "employeeChoicePanel";
            this.employeeChoicePanel.Size = new System.Drawing.Size(222, 225);
            this.employeeChoicePanel.TabIndex = 8;
            // 
            // createEmployeeRadio
            // 
            this.createEmployeeRadio.AutoSize = true;
            this.createEmployeeRadio.Location = new System.Drawing.Point(3, 163);
            this.createEmployeeRadio.Name = "createEmployeeRadio";
            this.createEmployeeRadio.Size = new System.Drawing.Size(156, 24);
            this.createEmployeeRadio.TabIndex = 11;
            this.createEmployeeRadio.TabStop = true;
            this.createEmployeeRadio.Text = "Create Employee";
            this.createEmployeeRadio.UseVisualStyleBackColor = true;
            this.createEmployeeRadio.CheckedChanged += new System.EventHandler(this.createEmployeeRadio_CheckedChanged);
            // 
            // deleteEmployeeRadio
            // 
            this.deleteEmployeeRadio.AutoSize = true;
            this.deleteEmployeeRadio.Location = new System.Drawing.Point(3, 108);
            this.deleteEmployeeRadio.Name = "deleteEmployeeRadio";
            this.deleteEmployeeRadio.Size = new System.Drawing.Size(155, 24);
            this.deleteEmployeeRadio.TabIndex = 10;
            this.deleteEmployeeRadio.TabStop = true;
            this.deleteEmployeeRadio.Text = "Delete Employee";
            this.deleteEmployeeRadio.UseVisualStyleBackColor = true;
            this.deleteEmployeeRadio.CheckedChanged += new System.EventHandler(this.deleteEmployeeRadio_CheckedChanged);
            // 
            // editEmployeeRadio
            // 
            this.editEmployeeRadio.AutoSize = true;
            this.editEmployeeRadio.Location = new System.Drawing.Point(3, 58);
            this.editEmployeeRadio.Name = "editEmployeeRadio";
            this.editEmployeeRadio.Size = new System.Drawing.Size(136, 24);
            this.editEmployeeRadio.TabIndex = 9;
            this.editEmployeeRadio.TabStop = true;
            this.editEmployeeRadio.Text = "Edit Employee";
            this.editEmployeeRadio.UseVisualStyleBackColor = true;
            this.editEmployeeRadio.CheckedChanged += new System.EventHandler(this.editEmployeeRadio_CheckedChanged);
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
            this.companySearchPanel.Controls.Add(this.label3);
            this.companySearchPanel.Controls.Add(this.searchIdemployeeTextBox);
            this.companySearchPanel.Controls.Add(this.searchEmployeeDeptTextBox);
            this.companySearchPanel.Controls.Add(this.label2);
            this.companySearchPanel.Controls.Add(this.label1);
            this.companySearchPanel.Controls.Add(this.searchEmployeesTextBox);
            this.companySearchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.companySearchPanel.Location = new System.Drawing.Point(18, 45);
            this.companySearchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companySearchPanel.Name = "companySearchPanel";
            this.companySearchPanel.Size = new System.Drawing.Size(218, 187);
            this.companySearchPanel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Employee Dept";
            // 
            // searchIdemployeeTextBox
            // 
            this.searchIdemployeeTextBox.Location = new System.Drawing.Point(21, 148);
            this.searchIdemployeeTextBox.Name = "searchIdemployeeTextBox";
            this.searchIdemployeeTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchIdemployeeTextBox.TabIndex = 6;
            // 
            // searchEmployeeDeptTextBox
            // 
            this.searchEmployeeDeptTextBox.Location = new System.Drawing.Point(21, 85);
            this.searchEmployeeDeptTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchEmployeeDeptTextBox.Name = "searchEmployeeDeptTextBox";
            this.searchEmployeeDeptTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchEmployeeDeptTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Employee Name";
            // 
            // searchEmployeesTextBox
            // 
            this.searchEmployeesTextBox.Location = new System.Drawing.Point(23, 31);
            this.searchEmployeesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchEmployeesTextBox.Name = "searchEmployeesTextBox";
            this.searchEmployeesTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchEmployeesTextBox.TabIndex = 6;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchLabel.Location = new System.Drawing.Point(69, 20);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeAllWindows);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1656, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 1106);
            this.panel1.TabIndex = 11;
            // 
            // closeAllWindows
            // 
            this.closeAllWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeAllWindows.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAllWindows.Location = new System.Drawing.Point(213, 3);
            this.closeAllWindows.Name = "closeAllWindows";
            this.closeAllWindows.Size = new System.Drawing.Size(58, 49);
            this.closeAllWindows.TabIndex = 8;
            this.closeAllWindows.Text = "X";
            this.closeAllWindows.UseVisualStyleBackColor = false;
            this.closeAllWindows.Click += new System.EventHandler(this.closeAllWindows_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Return";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1946, 100);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 37);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employees";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageEmployeesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployeesScreen";
            this.Text = "ManageEmployeesScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.editEmployeePanel.ResumeLayout(false);
            this.editEmployeePanel.PerformLayout();
            this.deleteEmployeePanel.ResumeLayout(false);
            this.deleteEmployeePanel.PerformLayout();
            this.createEmployeePanel.ResumeLayout(false);
            this.createEmployeePanel.PerformLayout();
            this.employeeChoicePanel.ResumeLayout(false);
            this.employeeChoicePanel.PerformLayout();
            this.companySearchPanel.ResumeLayout(false);
            this.companySearchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox viewEmployeeSearchTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel employeeChoicePanel;
        private System.Windows.Forms.Panel companySearchPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchIdemployeeTextBox;
        private System.Windows.Forms.TextBox searchEmployeeDeptTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchEmployeesTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton createEmployeeRadio;
        private System.Windows.Forms.RadioButton deleteEmployeeRadio;
        private System.Windows.Forms.RadioButton editEmployeeRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel deleteEmployeePanel;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.TextBox employeeDeleteIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel editEmployeePanel;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.TextBox editEmployeeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel createEmployeePanel;
        private System.Windows.Forms.Button createEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeAllWindows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
    }
}