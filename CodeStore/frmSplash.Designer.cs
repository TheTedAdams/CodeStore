namespace CodeStore
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.Title = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabScript = new System.Windows.Forms.TabPage();
            this.btnSetDestinationFolder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxDatabaseName = new System.Windows.Forms.ComboBox();
            this.btnScript = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSpecifyDestination = new System.Windows.Forms.CheckBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDeploy = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.checkSpecifyLogLocation = new System.Windows.Forms.CheckBox();
            this.btnFindScriptLocation = new System.Windows.Forms.Button();
            this.tbxDeployScriptLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDeployServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabScript.SuspendLayout();
            this.tabDeploy.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(295, 64);
            this.Title.TabIndex = 0;
            this.Title.Text = "CodeStore";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.White;
            this.lblPrompt.Location = new System.Drawing.Point(138, 73);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(298, 29);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "What would you like to do?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabScript);
            this.tabControl1.Controls.Add(this.tabDeploy);
            this.tabControl1.Location = new System.Drawing.Point(12, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 235);
            this.tabControl1.TabIndex = 4;
            // 
            // tabScript
            // 
            this.tabScript.Controls.Add(this.btnSetDestinationFolder);
            this.tabScript.Controls.Add(this.lblStatus);
            this.tabScript.Controls.Add(this.cbxDatabaseName);
            this.tabScript.Controls.Add(this.btnScript);
            this.tabScript.Controls.Add(this.label4);
            this.tabScript.Controls.Add(this.cbxSpecifyDestination);
            this.tabScript.Controls.Add(this.tbxDestination);
            this.tabScript.Controls.Add(this.label3);
            this.tabScript.Controls.Add(this.label2);
            this.tabScript.Controls.Add(this.tbxServerName);
            this.tabScript.Controls.Add(this.label1);
            this.tabScript.Location = new System.Drawing.Point(4, 22);
            this.tabScript.Name = "tabScript";
            this.tabScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabScript.Size = new System.Drawing.Size(712, 209);
            this.tabScript.TabIndex = 0;
            this.tabScript.Text = "Script";
            this.tabScript.UseVisualStyleBackColor = true;
            // 
            // btnSetDestinationFolder
            // 
            this.btnSetDestinationFolder.Enabled = false;
            this.btnSetDestinationFolder.Location = new System.Drawing.Point(627, 128);
            this.btnSetDestinationFolder.Name = "btnSetDestinationFolder";
            this.btnSetDestinationFolder.Size = new System.Drawing.Size(25, 20);
            this.btnSetDestinationFolder.TabIndex = 11;
            this.btnSetDestinationFolder.Text = "...";
            this.btnSetDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSetDestinationFolder.Click += new System.EventHandler(this.btnSetDestinationFolder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(109, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // cbxDatabaseName
            // 
            this.cbxDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDatabaseName.FormattingEnabled = true;
            this.cbxDatabaseName.Location = new System.Drawing.Point(109, 50);
            this.cbxDatabaseName.Name = "cbxDatabaseName";
            this.cbxDatabaseName.Size = new System.Drawing.Size(543, 21);
            this.cbxDatabaseName.TabIndex = 9;
            this.cbxDatabaseName.TextChanged += new System.EventHandler(this.cbxDatabaseName_TextChanged);
            // 
            // btnScript
            // 
            this.btnScript.Location = new System.Drawing.Point(515, 154);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(137, 23);
            this.btnScript.TabIndex = 8;
            this.btnScript.Text = "Script Database";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note: If a destination is not specified the scripts will be placed in the folder " +
    "where this .exe is located.";
            // 
            // cbxSpecifyDestination
            // 
            this.cbxSpecifyDestination.AutoSize = true;
            this.cbxSpecifyDestination.Location = new System.Drawing.Point(109, 88);
            this.cbxSpecifyDestination.Name = "cbxSpecifyDestination";
            this.cbxSpecifyDestination.Size = new System.Drawing.Size(132, 17);
            this.cbxSpecifyDestination.TabIndex = 6;
            this.cbxSpecifyDestination.Text = "Specify a Destination?";
            this.cbxSpecifyDestination.UseVisualStyleBackColor = true;
            this.cbxSpecifyDestination.CheckedChanged += new System.EventHandler(this.cbxSpecifyDestination_CheckedChanged);
            // 
            // tbxDestination
            // 
            this.tbxDestination.Enabled = false;
            this.tbxDestination.Location = new System.Drawing.Point(109, 128);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(512, 20);
            this.tbxDestination.TabIndex = 5;
            this.tbxDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxServerName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name:";
            // 
            // tbxServerName
            // 
            this.tbxServerName.Location = new System.Drawing.Point(109, 19);
            this.tbxServerName.Name = "tbxServerName";
            this.tbxServerName.Size = new System.Drawing.Size(543, 20);
            this.tbxServerName.TabIndex = 1;
            this.tbxServerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxServerName_KeyPress);
            this.tbxServerName.Leave += new System.EventHandler(this.tbxServerName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // tabDeploy
            // 
            this.tabDeploy.Controls.Add(this.label7);
            this.tabDeploy.Controls.Add(this.checkSpecifyLogLocation);
            this.tabDeploy.Controls.Add(this.btnFindScriptLocation);
            this.tabDeploy.Controls.Add(this.tbxDeployScriptLocation);
            this.tabDeploy.Controls.Add(this.label6);
            this.tabDeploy.Controls.Add(this.tbxDeployServer);
            this.tabDeploy.Controls.Add(this.label5);
            this.tabDeploy.Location = new System.Drawing.Point(4, 22);
            this.tabDeploy.Name = "tabDeploy";
            this.tabDeploy.Size = new System.Drawing.Size(712, 209);
            this.tabDeploy.TabIndex = 1;
            this.tabDeploy.Text = "Deploy";
            this.tabDeploy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-1, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(713, 186);
            this.label7.TabIndex = 8;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // checkSpecifyLogLocation
            // 
            this.checkSpecifyLogLocation.AutoSize = true;
            this.checkSpecifyLogLocation.Enabled = false;
            this.checkSpecifyLogLocation.Location = new System.Drawing.Point(109, 72);
            this.checkSpecifyLogLocation.Name = "checkSpecifyLogLocation";
            this.checkSpecifyLogLocation.Size = new System.Drawing.Size(175, 17);
            this.checkSpecifyLogLocation.TabIndex = 7;
            this.checkSpecifyLogLocation.Text = "Specify Deployment Locations?";
            this.checkSpecifyLogLocation.UseVisualStyleBackColor = true;
            // 
            // btnFindScriptLocation
            // 
            this.btnFindScriptLocation.Enabled = false;
            this.btnFindScriptLocation.Location = new System.Drawing.Point(622, 45);
            this.btnFindScriptLocation.Name = "btnFindScriptLocation";
            this.btnFindScriptLocation.Size = new System.Drawing.Size(30, 20);
            this.btnFindScriptLocation.TabIndex = 6;
            this.btnFindScriptLocation.Text = "...";
            this.btnFindScriptLocation.UseVisualStyleBackColor = true;
            this.btnFindScriptLocation.Click += new System.EventHandler(this.btnFindScriptLocation_Click);
            // 
            // tbxDeployScriptLocation
            // 
            this.tbxDeployScriptLocation.Enabled = false;
            this.tbxDeployScriptLocation.Location = new System.Drawing.Point(109, 45);
            this.tbxDeployScriptLocation.Name = "tbxDeployScriptLocation";
            this.tbxDeployScriptLocation.Size = new System.Drawing.Size(507, 20);
            this.tbxDeployScriptLocation.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Script Location:";
            // 
            // tbxDeployServer
            // 
            this.tbxDeployServer.Enabled = false;
            this.tbxDeployServer.Location = new System.Drawing.Point(109, 19);
            this.tbxDeployServer.Name = "tbxDeployServer";
            this.tbxDeployServer.Size = new System.Drawing.Size(543, 20);
            this.tbxDeployServer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Server Name:";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(744, 352);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeStore";
            this.tabControl1.ResumeLayout(false);
            this.tabScript.ResumeLayout(false);
            this.tabScript.PerformLayout();
            this.tabDeploy.ResumeLayout(false);
            this.tabDeploy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxSpecifyDestination;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnScript;
        private System.Windows.Forms.ComboBox cbxDatabaseName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage tabDeploy;
        private System.Windows.Forms.TextBox tbxDeployServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDeployScriptLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindScriptLocation;
        private System.Windows.Forms.CheckBox checkSpecifyLogLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSetDestinationFolder;
    }
}

