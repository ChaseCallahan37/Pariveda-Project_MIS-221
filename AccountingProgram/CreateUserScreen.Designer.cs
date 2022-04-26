namespace AccountingProgram
{
    partial class CreateUserScreen
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
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.creationPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.creationPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(1284, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 49);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Back";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.UseWaitCursor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // creationPanel
            // 
            this.creationPanel.Controls.Add(this.cancelButton);
            this.creationPanel.Controls.Add(this.saveButton);
            this.creationPanel.Controls.Add(this.jobTitleComboBox);
            this.creationPanel.Controls.Add(this.jobTitleLabel);
            this.creationPanel.Controls.Add(this.passwordTextBox);
            this.creationPanel.Controls.Add(this.label3);
            this.creationPanel.Controls.Add(this.usernameTextBox);
            this.creationPanel.Controls.Add(this.label5);
            this.creationPanel.Controls.Add(this.nameTextBox);
            this.creationPanel.Controls.Add(this.label1);
            this.creationPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.creationPanel.Location = new System.Drawing.Point(89, 49);
            this.creationPanel.Name = "creationPanel";
            this.creationPanel.Size = new System.Drawing.Size(401, 561);
            this.creationPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(69, 469);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 39);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(240, 469);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 39);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Items.AddRange(new object[] {
            "human resource",
            "accountant",
            "admin"});
            this.jobTitleComboBox.Location = new System.Drawing.Point(124, 336);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(239, 28);
            this.jobTitleComboBox.TabIndex = 8;
            this.jobTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(27, 344);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(68, 20);
            this.jobTitleLabel.TabIndex = 16;
            this.jobTitleLabel.Text = "Job Title";
            this.jobTitleLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Location = new System.Drawing.Point(124, 235);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(239, 26);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Location = new System.Drawing.Point(124, 142);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(239, 26);
            this.usernameTextBox.TabIndex = 13;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Location = new System.Drawing.Point(124, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(239, 26);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.creationPanel);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Location = new System.Drawing.Point(722, 77);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(523, 640);
            this.mainPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.button1);
            this.centerPanel.Controls.Add(this.label6);
            this.centerPanel.Controls.Add(this.mainPanel);
            this.centerPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1946, 1106);
            this.centerPanel.TabIndex = 7;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1815, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Return";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1946, 61);
            this.label6.TabIndex = 7;
            this.label6.Text = "User Creation Form";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseWaitCursor = true;
            // 
            // CreateUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateUserScreen";
            this.Text = "Create User Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateUserScreen_Load);
            this.creationPanel.ResumeLayout(false);
            this.creationPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel creationPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jobTitleComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}