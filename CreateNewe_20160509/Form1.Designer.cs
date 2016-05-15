namespace CreateNewe_20160509
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAccountSignIn = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.txtBoxSignIn = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPasswrd = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepartureDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReturnDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1170, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAccountSignIn
            // 
            this.lblAccountSignIn.AutoSize = true;
            this.lblAccountSignIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountSignIn.Location = new System.Drawing.Point(13, 58);
            this.lblAccountSignIn.Name = "lblAccountSignIn";
            this.lblAccountSignIn.Size = new System.Drawing.Size(84, 15);
            this.lblAccountSignIn.TabIndex = 1;
            this.lblAccountSignIn.Text = "Account Sign in";
            // 
            // txtBoxSignIn
            // 
            this.txtBoxSignIn.Location = new System.Drawing.Point(119, 55);
            this.txtBoxSignIn.Name = "txtBoxSignIn";
            this.txtBoxSignIn.Size = new System.Drawing.Size(314, 20);
            this.txtBoxSignIn.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.Location = new System.Drawing.Point(13, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Account Password";
            // 
            // txtBoxPasswrd
            // 
            this.txtBoxPasswrd.Location = new System.Drawing.Point(119, 89);
            this.txtBoxPasswrd.Name = "txtBoxPasswrd";
            this.txtBoxPasswrd.PasswordChar = '*';
            this.txtBoxPasswrd.Size = new System.Drawing.Size(314, 20);
            this.txtBoxPasswrd.TabIndex = 4;
            this.txtBoxPasswrd.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(451, 55);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(72, 54);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDeparture);
            this.groupBox1.Controls.Add(this.ReturnDateTimePicker2);
            this.groupBox1.Controls.Add(this.DepartureDateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(13, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DepartureDateTimePicker1
            // 
            this.DepartureDateTimePicker1.Location = new System.Drawing.Point(215, 19);
            this.DepartureDateTimePicker1.Name = "DepartureDateTimePicker1";
            this.DepartureDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DepartureDateTimePicker1.TabIndex = 0;
            // 
            // ReturnDateTimePicker2
            // 
            this.ReturnDateTimePicker2.Location = new System.Drawing.Point(215, 58);
            this.ReturnDateTimePicker2.Name = "ReturnDateTimePicker2";
            this.ReturnDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.ReturnDateTimePicker2.TabIndex = 1;
            this.ReturnDateTimePicker2.ValueChanged += new System.EventHandler(this.ReturnDateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Flight(s)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "One Way Flight",
            "With Return Flight"});
            this.comboBox1.Location = new System.Drawing.Point(119, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeparture.Location = new System.Drawing.Point(6, 24);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(59, 15);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Departure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Return:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CreateNewe_20160509.Properties.Resources.glider_h6w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 595);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtBoxPasswrd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxSignIn);
            this.Controls.Add(this.lblAccountSignIn);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Flights";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAccountSignIn;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TextBox txtBoxSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPasswrd;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ReturnDateTimePicker2;
        private System.Windows.Forms.DateTimePicker DepartureDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeparture;
    }
}

