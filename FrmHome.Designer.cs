

namespace NSF_JSON_Reader
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPath = new Label();
            txtPath = new TextBox();
            btnLoad = new Button();
            lblFolders = new Label();
            lblFiles = new Label();
            txtFolders = new TextBox();
            txtFiles = new TextBox();
            lblDBSetup = new Label();
            lblServer = new Label();
            txtServer = new TextBox();
            lblDBName = new Label();
            txtDBName = new TextBox();
            lblUserID = new Label();
            txtUserID = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnDBTest = new Button();
            SuspendLayout();
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(12, 9);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(511, 25);
            lblPath.TabIndex = 0;
            lblPath.Text = "Enter the file path containing the the JSON  files and/or folders.\r\n";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 37);
            txtPath.Multiline = true;
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(574, 60);
            txtPath.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 113);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Files";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblFolders
            // 
            lblFolders.AutoSize = true;
            lblFolders.Location = new Point(12, 174);
            lblFolders.Name = "lblFolders";
            lblFolders.Size = new Size(212, 25);
            lblFolders.TabIndex = 3;
            lblFolders.Text = "Number of folders found";
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(308, 174);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(288, 25);
            lblFiles.TabIndex = 4;
            lblFiles.Text = "Number of files found and loaded ";
            // 
            // txtFolders
            // 
            txtFolders.Location = new Point(12, 202);
            txtFolders.Name = "txtFolders";
            txtFolders.ReadOnly = true;
            txtFolders.Size = new Size(268, 31);
            txtFolders.TabIndex = 5;
            // 
            // txtFiles
            // 
            txtFiles.Location = new Point(308, 202);
            txtFiles.Name = "txtFiles";
            txtFiles.ReadOnly = true;
            txtFiles.Size = new Size(278, 31);
            txtFiles.TabIndex = 6;
            // 
            // lblDBSetup
            // 
            lblDBSetup.AutoSize = true;
            lblDBSetup.Location = new Point(697, 9);
            lblDBSetup.Name = "lblDBSetup";
            lblDBSetup.Size = new Size(137, 25);
            lblDBSetup.TabIndex = 7;
            lblDBSetup.Text = "Database Setup";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(697, 40);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(185, 25);
            lblServer.TabIndex = 8;
            lblServer.Text = "Server Name/Address";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(697, 68);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(714, 31);
            txtServer.TabIndex = 9;
            // 
            // lblDBName
            // 
            lblDBName.AutoSize = true;
            lblDBName.Location = new Point(697, 113);
            lblDBName.Name = "lblDBName";
            lblDBName.Size = new Size(86, 25);
            lblDBName.TabIndex = 10;
            lblDBName.Text = "Database";
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(697, 151);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(714, 31);
            txtDBName.TabIndex = 11;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(697, 205);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(70, 25);
            lblUserID.TabIndex = 12;
            lblUserID.Text = "User ID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(697, 253);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(348, 31);
            txtUserID.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(1063, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1063, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(348, 31);
            txtPassword.TabIndex = 15;
            // 
            // btnDBTest
            // 
            btnDBTest.Location = new Point(697, 314);
            btnDBTest.Name = "btnDBTest";
            btnDBTest.Size = new Size(714, 34);
            btnDBTest.TabIndex = 16;
            btnDBTest.Text = "Test DB Connection";
            btnDBTest.UseVisualStyleBackColor = true;
            btnDBTest.Click += btnDBTest_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 680);
            Controls.Add(btnDBTest);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(txtDBName);
            Controls.Add(lblDBName);
            Controls.Add(txtServer);
            Controls.Add(lblServer);
            Controls.Add(lblDBSetup);
            Controls.Add(txtFiles);
            Controls.Add(txtFolders);
            Controls.Add(lblFiles);
            Controls.Add(lblFolders);
            Controls.Add(btnLoad);
            Controls.Add(txtPath);
            Controls.Add(lblPath);
            Name = "FrmHome";
            Text = "NSF JSON Reader";
            Load += FrmHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label lblPath;
        private TextBox txtPath;
        private Button btnLoad;
        private Label lblFolders;
        private Label lblFiles;
        private TextBox txtFolders;
        private TextBox txtFiles;
        private Label lblDBSetup;
        private Label lblServer;
        private TextBox txtServer;
        private Label lblDBName;
        private TextBox txtDBName;
        private Label lblUserID;
        private TextBox txtUserID;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnDBTest;
    }
}
