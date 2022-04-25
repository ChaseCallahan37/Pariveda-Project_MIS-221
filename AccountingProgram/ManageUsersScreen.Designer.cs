namespace AccountingProgram
{
    partial class ManageUsersScreen
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
            this.viewUsersTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBack = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.companySearchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.companySearchPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(1799, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Back";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // viewUsersTextBox
            // 
            this.viewUsersTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewUsersTextBox.Enabled = false;
            this.viewUsersTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersTextBox.Location = new System.Drawing.Point(12, 115);
            this.viewUsersTextBox.Multiline = true;
            this.viewUsersTextBox.Name = "viewUsersTextBox";
            this.viewUsersTextBox.ReadOnly = true;
            this.viewUsersTextBox.Size = new System.Drawing.Size(1575, 772);
            this.viewUsersTextBox.TabIndex = 5;
            this.viewUsersTextBox.WordWrap = false;
            this.viewUsersTextBox.TextChanged += new System.EventHandler(this.viewUsersTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.goBack);
            this.panel1.Controls.Add(this.createUserButton);
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 899);
            this.panel1.TabIndex = 6;
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goBack.Location = new System.Drawing.Point(197, 13);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(58, 49);
            this.goBack.TabIndex = 5;
            this.goBack.Text = "X";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserButton.Location = new System.Drawing.Point(44, 698);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(105, 63);
            this.createUserButton.TabIndex = 4;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.panel2);
            this.searchPanel.Controls.Add(this.companySearchPanel);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchPanel.Location = new System.Drawing.Point(17, 164);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(230, 513);
            this.searchPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.editUserButton);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(18, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 284);
            this.panel2.TabIndex = 8;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserButton.Location = new System.Drawing.Point(9, 215);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(85, 42);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Location = new System.Drawing.Point(9, 101);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(187, 26);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // editUserButton
            // 
            this.editUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUserButton.Location = new System.Drawing.Point(9, 159);
            this.editUserButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(84, 34);
            this.editUserButton.TabIndex = 5;
            this.editUserButton.Text = "Edit";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // companySearchPanel
            // 
            this.companySearchPanel.Controls.Add(this.label1);
            this.companySearchPanel.Controls.Add(this.userSearchButton);
            this.companySearchPanel.Controls.Add(this.searchUserTextBox);
            this.companySearchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.companySearchPanel.Location = new System.Drawing.Point(18, 45);
            this.companySearchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companySearchPanel.Name = "companySearchPanel";
            this.companySearchPanel.Size = new System.Drawing.Size(190, 154);
            this.companySearchPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter User\'s Name";
            // 
            // userSearchButton
            // 
            this.userSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSearchButton.Location = new System.Drawing.Point(21, 109);
            this.userSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userSearchButton.Name = "userSearchButton";
            this.userSearchButton.Size = new System.Drawing.Size(112, 35);
            this.userSearchButton.TabIndex = 3;
            this.userSearchButton.Text = "Search";
            this.userSearchButton.UseVisualStyleBackColor = true;
            this.userSearchButton.Click += new System.EventHandler(this.userSearchButton_Click);
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchUserTextBox.Location = new System.Drawing.Point(21, 32);
            this.searchUserTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchUserTextBox.TabIndex = 6;
            this.searchUserTextBox.TextChanged += new System.EventHandler(this.searchUserTextBox_TextChanged);
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Users";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1619, 100);
            this.topPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(25, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Username to\r\nedit or delete\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.DimGray;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(154, 81);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(101, 49);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ManageUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1886, 899);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewUsersTextBox);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageUsersScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageUsersScreen_Load);
            this.panel1.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.companySearchPanel.ResumeLayout(false);
            this.companySearchPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox viewUsersTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Panel companySearchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.TextBox searchUserTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnButton;
    }
}