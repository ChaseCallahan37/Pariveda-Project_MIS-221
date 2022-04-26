namespace AccountingProgram
{
    partial class MainScreen
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.employeeButton = new System.Windows.Forms.Button();
            this.usersScreenButton = new System.Windows.Forms.Button();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Label();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayUserLabel = new System.Windows.Forms.Label();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.leftPanel.Controls.Add(this.menuPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(253, 1106);
            this.leftPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.employeeButton);
            this.menuPanel.Controls.Add(this.usersScreenButton);
            this.menuPanel.Controls.Add(this.invoiceButton);
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Location = new System.Drawing.Point(3, 132);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(242, 541);
            this.menuPanel.TabIndex = 0;
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.Silver;
            this.employeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeButton.Location = new System.Drawing.Point(23, 211);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(193, 68);
            this.employeeButton.TabIndex = 4;
            this.employeeButton.Text = "Handle\r\nEmployees\r\n";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // usersScreenButton
            // 
            this.usersScreenButton.BackColor = System.Drawing.Color.Silver;
            this.usersScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersScreenButton.Location = new System.Drawing.Point(23, 386);
            this.usersScreenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersScreenButton.Name = "usersScreenButton";
            this.usersScreenButton.Size = new System.Drawing.Size(193, 68);
            this.usersScreenButton.TabIndex = 2;
            this.usersScreenButton.Text = "Handle\r\nUsers";
            this.usersScreenButton.UseVisualStyleBackColor = false;
            this.usersScreenButton.Click += new System.EventHandler(this.usersScreenButton_Click);
            // 
            // invoiceButton
            // 
            this.invoiceButton.BackColor = System.Drawing.Color.Silver;
            this.invoiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoiceButton.Location = new System.Drawing.Point(23, 52);
            this.invoiceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(193, 68);
            this.invoiceButton.TabIndex = 1;
            this.invoiceButton.Text = "Handle\r\nInvoices";
            this.invoiceButton.UseVisualStyleBackColor = false;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(18, 1);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(209, 29);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Choose An Option";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Silver;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(0, 236);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(193, 68);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.Controls.Add(this.usersButton);
            this.mainPanel.Controls.Add(this.userInfoPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(253, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1693, 1106);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // usersButton
            // 
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Image = global::AccountingProgram.Properties.Resources.PiggyBank__;
            this.usersButton.Location = new System.Drawing.Point(231, 243);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(1093, 726);
            this.usersButton.TabIndex = 5;
            this.usersButton.Text = "Welcome to your\r\naccounting system!";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usersButton.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userInfoPanel.Controls.Add(this.editProfileButton);
            this.userInfoPanel.Controls.Add(this.clearButton);
            this.userInfoPanel.Controls.Add(this.logoutButton);
            this.userInfoPanel.Controls.Add(this.displayUserLabel);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInfoPanel.Location = new System.Drawing.Point(1474, 0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(219, 1106);
            this.userInfoPanel.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(161, 0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(58, 49);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "X";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayUserLabel
            // 
            this.displayUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUserLabel.Location = new System.Drawing.Point(0, 68);
            this.displayUserLabel.Name = "displayUserLabel";
            this.displayUserLabel.Size = new System.Drawing.Size(203, 70);
            this.displayUserLabel.TabIndex = 3;
            this.displayUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayUserLabel.Click += new System.EventHandler(this.displayUserLabel_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.BackColor = System.Drawing.Color.Silver;
            this.editProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfileButton.Location = new System.Drawing.Point(0, 158);
            this.editProfileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(193, 68);
            this.editProfileButton.TabIndex = 4;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = false;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label displayUserLabel;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label usersButton;
        private System.Windows.Forms.Button usersScreenButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button editProfileButton;
    }
}