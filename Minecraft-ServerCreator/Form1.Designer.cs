namespace Minecraft_ServerCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InstallContainer = new System.Windows.Forms.Panel();
            this.RunServer = new System.Windows.Forms.Button();
            this.setupserver = new System.Windows.Forms.Button();
            this.InstallServer = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.selectedDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discordjoin = new System.Windows.Forms.Button();
            this.InstallContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstallContainer
            // 
            this.InstallContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InstallContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InstallContainer.Controls.Add(this.RunServer);
            this.InstallContainer.Controls.Add(this.setupserver);
            this.InstallContainer.Controls.Add(this.InstallServer);
            this.InstallContainer.Controls.Add(this.DirectoryButton);
            this.InstallContainer.Controls.Add(this.selectedDirectoryTextBox);
            this.InstallContainer.Location = new System.Drawing.Point(3, 31);
            this.InstallContainer.Name = "InstallContainer";
            this.InstallContainer.Size = new System.Drawing.Size(327, 171);
            this.InstallContainer.TabIndex = 0;
            // 
            // RunServer
            // 
            this.RunServer.Location = new System.Drawing.Point(216, 30);
            this.RunServer.Name = "RunServer";
            this.RunServer.Size = new System.Drawing.Size(86, 23);
            this.RunServer.TabIndex = 5;
            this.RunServer.Text = "Run Server";
            this.RunServer.UseVisualStyleBackColor = true;
            this.RunServer.Click += new System.EventHandler(this.RunServer_Click);
            // 
            // setupserver
            // 
            this.setupserver.Location = new System.Drawing.Point(122, 30);
            this.setupserver.Name = "setupserver";
            this.setupserver.Size = new System.Drawing.Size(88, 23);
            this.setupserver.TabIndex = 4;
            this.setupserver.Text = "Auto Setup";
            this.setupserver.UseVisualStyleBackColor = true;
            this.setupserver.Click += new System.EventHandler(this.SetupServer_Click);
            // 
            // InstallServer
            // 
            this.InstallServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InstallServer.Location = new System.Drawing.Point(19, 30);
            this.InstallServer.Name = "InstallServer";
            this.InstallServer.Size = new System.Drawing.Size(97, 23);
            this.InstallServer.TabIndex = 3;
            this.InstallServer.Text = "Install Server";
            this.InstallServer.UseVisualStyleBackColor = true;
            this.InstallServer.Click += new System.EventHandler(this.InstallServer_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryButton.Location = new System.Drawing.Point(3, 141);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(79, 23);
            this.DirectoryButton.TabIndex = 2;
            this.DirectoryButton.Text = "Set Directory";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
            // 
            // selectedDirectoryTextBox
            // 
            this.selectedDirectoryTextBox.Location = new System.Drawing.Point(88, 142);
            this.selectedDirectoryTextBox.Name = "selectedDirectoryTextBox";
            this.selectedDirectoryTextBox.Size = new System.Drawing.Size(232, 22);
            this.selectedDirectoryTextBox.TabIndex = 1;
            this.selectedDirectoryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.Color.White;
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(336, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(406, 340);
            this.outputListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vanilla Server Installer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discordjoin
            // 
            this.discordjoin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordjoin.Location = new System.Drawing.Point(83, 323);
            this.discordjoin.Name = "discordjoin";
            this.discordjoin.Size = new System.Drawing.Size(155, 23);
            this.discordjoin.TabIndex = 3;
            this.discordjoin.Text = "Join Our Discord";
            this.discordjoin.UseVisualStyleBackColor = true;
            this.discordjoin.Click += new System.EventHandler(this.discordjoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(746, 358);
            this.Controls.Add(this.discordjoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.InstallContainer);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Minecraft Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.InstallContainer.ResumeLayout(false);
            this.InstallContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InstallContainer;
        private System.Windows.Forms.TextBox selectedDirectoryTextBox;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.Button InstallServer;
        private System.Windows.Forms.Button setupserver;
        private System.Windows.Forms.Button RunServer;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discordjoin;
    }
}

