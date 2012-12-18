namespace CodeStore
{
    partial class frmScript
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblSubHead = new System.Windows.Forms.Label();
            this.grpConfirm = new System.Windows.Forms.GroupBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.tbxServerName = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxDBName = new System.Windows.Forms.TextBox();
            this.grpScript = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.grpConfirm.SuspendLayout();
            this.grpScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHead.Location = new System.Drawing.Point(12, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(295, 64);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "CodeStore";
            // 
            // lblSubHead
            // 
            this.lblSubHead.AutoSize = true;
            this.lblSubHead.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHead.ForeColor = System.Drawing.Color.White;
            this.lblSubHead.Location = new System.Drawing.Point(138, 73);
            this.lblSubHead.Name = "lblSubHead";
            this.lblSubHead.Size = new System.Drawing.Size(415, 29);
            this.lblSubHead.TabIndex = 4;
            this.lblSubHead.Text = "Please confirm the information below.";
            // 
            // grpConfirm
            // 
            this.grpConfirm.BackColor = System.Drawing.Color.White;
            this.grpConfirm.Controls.Add(this.tbxDBName);
            this.grpConfirm.Controls.Add(this.tbxDestination);
            this.grpConfirm.Controls.Add(this.tbxServerName);
            this.grpConfirm.Controls.Add(this.btnContinue);
            this.grpConfirm.Controls.Add(this.btnGoBack);
            this.grpConfirm.Controls.Add(this.lblDestination);
            this.grpConfirm.Controls.Add(this.lblDBName);
            this.grpConfirm.Controls.Add(this.lblServerName);
            this.grpConfirm.Location = new System.Drawing.Point(12, 105);
            this.grpConfirm.Name = "grpConfirm";
            this.grpConfirm.Size = new System.Drawing.Size(720, 235);
            this.grpConfirm.TabIndex = 5;
            this.grpConfirm.TabStop = false;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(11, 20);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(174, 31);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "ServerName:";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.Location = new System.Drawing.Point(11, 61);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(218, 31);
            this.lblDBName.TabIndex = 1;
            this.lblDBName.Text = "Database Name:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(11, 102);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(159, 31);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(0, 206);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(360, 29);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(360, 206);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(360, 29);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // tbxServerName
            // 
            this.tbxServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxServerName.Location = new System.Drawing.Point(228, 20);
            this.tbxServerName.Name = "tbxServerName";
            this.tbxServerName.ReadOnly = true;
            this.tbxServerName.Size = new System.Drawing.Size(486, 26);
            this.tbxServerName.TabIndex = 5;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestination.Location = new System.Drawing.Point(228, 102);
            this.tbxDestination.Multiline = true;
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.ReadOnly = true;
            this.tbxDestination.Size = new System.Drawing.Size(486, 98);
            this.tbxDestination.TabIndex = 6;
            // 
            // tbxDBName
            // 
            this.tbxDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDBName.Location = new System.Drawing.Point(228, 61);
            this.tbxDBName.Name = "tbxDBName";
            this.tbxDBName.ReadOnly = true;
            this.tbxDBName.Size = new System.Drawing.Size(486, 26);
            this.tbxDBName.TabIndex = 7;
            // 
            // grpScript
            // 
            this.grpScript.BackColor = System.Drawing.Color.White;
            this.grpScript.Controls.Add(this.tbxOutput);
            this.grpScript.Controls.Add(this.btnClose);
            this.grpScript.Location = new System.Drawing.Point(12, 105);
            this.grpScript.Name = "grpScript";
            this.grpScript.Size = new System.Drawing.Size(720, 235);
            this.grpScript.TabIndex = 8;
            this.grpScript.TabStop = false;
            this.grpScript.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(0, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(720, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(6, 10);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(708, 196);
            this.tbxOutput.TabIndex = 1;
            this.tbxOutput.TextChanged += new System.EventHandler(this.tbxOutput_TextChanged);
            // 
            // frmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(744, 352);
            this.Controls.Add(this.grpScript);
            this.Controls.Add(this.grpConfirm);
            this.Controls.Add(this.lblSubHead);
            this.Controls.Add(this.lblHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScript";
            this.grpConfirm.ResumeLayout(false);
            this.grpConfirm.PerformLayout();
            this.grpScript.ResumeLayout(false);
            this.grpScript.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblSubHead;
        private System.Windows.Forms.GroupBox grpConfirm;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox tbxDBName;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxServerName;
        private System.Windows.Forms.GroupBox grpScript;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxOutput;
    }
}