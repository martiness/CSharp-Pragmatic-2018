namespace HelloWorld
{
    partial class MainWindow
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFormatDisk = new System.Windows.Forms.Button();
            this.btnShowForm = new System.Windows.Forms.Button();
            this.btnShowModalForm = new System.Windows.Forms.Button();
            this.cbGDPR = new System.Windows.Forms.CheckBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.gbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(27, 60);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(860, 31);
            this.tbUsername.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(22, 204);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 55);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "$>";
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(917, 53);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(145, 45);
            this.btnSayHello.TabIndex = 3;
            this.btnSayHello.Text = "Say Hello :) ";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(917, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFormatDisk
            // 
            this.btnFormatDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFormatDisk.Location = new System.Drawing.Point(437, 342);
            this.btnFormatDisk.Name = "btnFormatDisk";
            this.btnFormatDisk.Size = new System.Drawing.Size(146, 45);
            this.btnFormatDisk.TabIndex = 5;
            this.btnFormatDisk.Text = "Format Disk";
            this.btnFormatDisk.UseVisualStyleBackColor = true;
            this.btnFormatDisk.Click += new System.EventHandler(this.btnFormatDisk_Click);
            // 
            // btnShowForm
            // 
            this.btnShowForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowForm.Location = new System.Drawing.Point(27, 342);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(152, 45);
            this.btnShowForm.TabIndex = 6;
            this.btnShowForm.Text = "Show Form";
            this.btnShowForm.UseVisualStyleBackColor = true;
            this.btnShowForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowModalForm
            // 
            this.btnShowModalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowModalForm.Location = new System.Drawing.Point(200, 342);
            this.btnShowModalForm.Name = "btnShowModalForm";
            this.btnShowModalForm.Size = new System.Drawing.Size(216, 45);
            this.btnShowModalForm.TabIndex = 7;
            this.btnShowModalForm.Text = "Show Modal Form";
            this.btnShowModalForm.UseVisualStyleBackColor = true;
            this.btnShowModalForm.Click += new System.EventHandler(this.btnShowModalForm_Click);
            // 
            // cbGDPR
            // 
            this.cbGDPR.AutoSize = true;
            this.cbGDPR.Location = new System.Drawing.Point(27, 111);
            this.cbGDPR.Name = "cbGDPR";
            this.cbGDPR.Size = new System.Drawing.Size(349, 29);
            this.cbGDPR.TabIndex = 8;
            this.cbGDPR.Text = "I\'ve read and I agree with GDPR";
            this.cbGDPR.UseVisualStyleBackColor = true;
            this.cbGDPR.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(23, 34);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(90, 29);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(23, 85);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(114, 29);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbMale);
            this.gbSex.Controls.Add(this.rbFemale);
            this.gbSex.Location = new System.Drawing.Point(878, 162);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(184, 126);
            this.gbSex.TabIndex = 11;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Sex";
            this.gbSex.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 411);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.cbGDPR);
            this.Controls.Add(this.btnShowModalForm);
            this.Controls.Add(this.btnShowForm);
            this.Controls.Add(this.btnFormatDisk);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "MainWindow";
            this.Text = "Hello World Playground";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Click += new System.EventHandler(this.MainWindow_Click);
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFormatDisk;
        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.Button btnShowModalForm;
        private System.Windows.Forms.CheckBox cbGDPR;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox gbSex;
    }
}

