namespace DjangoAPIClient
{
    partial class SubjectForm
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
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameLB = new System.Windows.Forms.Label();
            this.secondsurnameLB = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.secondsurnameTB = new System.Windows.Forms.TextBox();
            this.idLB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.genderLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.birthdateLB = new System.Windows.Forms.Label();
            this.birthdateDP = new System.Windows.Forms.DateTimePicker();
            this.registrationdateLB = new System.Windows.Forms.Label();
            this.registrationdateDP = new System.Windows.Forms.DateTimePicker();
            this.contactpermissionLB = new System.Windows.Forms.Label();
            this.contactpermissionKB = new System.Windows.Forms.CheckBox();
            this.emailLB = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.nameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.acceptBT = new System.Windows.Forms.Button();
            this.createsubjectGB = new System.Windows.Forms.GroupBox();
            this.idtypeCB = new System.Windows.Forms.ComboBox();
            this.idtypeLB = new System.Windows.Forms.Label();
            this.countryCB = new System.Windows.Forms.ComboBox();
            this.countryLB = new System.Windows.Forms.Label();
            this.surnameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.secondsurnameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.idEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.consentfileTB = new System.Windows.Forms.TextBox();
            this.consentfileBT = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nameEP)).BeginInit();
            this.createsubjectGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surnameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsurnameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEP)).BeginInit();
            this.SuspendLayout();
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(358, 227);
            this.genderCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(149, 24);
            this.genderCB.TabIndex = 8;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(44, 36);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(49, 17);
            this.nameLB.TabIndex = 2;
            this.nameLB.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(182, 32);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(325, 22);
            this.nameTB.TabIndex = 3;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // surnameLB
            // 
            this.surnameLB.AutoSize = true;
            this.surnameLB.Location = new System.Drawing.Point(44, 71);
            this.surnameLB.Name = "surnameLB";
            this.surnameLB.Size = new System.Drawing.Size(69, 17);
            this.surnameLB.TabIndex = 5;
            this.surnameLB.Text = "Surname:";
            // 
            // secondsurnameLB
            // 
            this.secondsurnameLB.AutoSize = true;
            this.secondsurnameLB.Location = new System.Drawing.Point(44, 110);
            this.secondsurnameLB.Name = "secondsurnameLB";
            this.secondsurnameLB.Size = new System.Drawing.Size(117, 17);
            this.secondsurnameLB.TabIndex = 6;
            this.secondsurnameLB.Text = "SecondSurname:";
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(182, 71);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(325, 22);
            this.surnameTB.TabIndex = 4;
            this.surnameTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            this.surnameTB.Leave += new System.EventHandler(this.surnameTB_Leave);
            // 
            // secondsurnameTB
            // 
            this.secondsurnameTB.Location = new System.Drawing.Point(182, 110);
            this.secondsurnameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondsurnameTB.Name = "secondsurnameTB";
            this.secondsurnameTB.Size = new System.Drawing.Size(325, 22);
            this.secondsurnameTB.TabIndex = 5;
            this.secondsurnameTB.TextChanged += new System.EventHandler(this.secondsurnameTB_TextChanged);
            this.secondsurnameTB.Leave += new System.EventHandler(this.secondsurnameTB_Leave);
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Location = new System.Drawing.Point(44, 151);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(25, 17);
            this.idLB.TabIndex = 9;
            this.idLB.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(358, 151);
            this.idTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(149, 22);
            this.idTB.TabIndex = 6;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // genderLB
            // 
            this.genderLB.AutoSize = true;
            this.genderLB.Location = new System.Drawing.Point(44, 227);
            this.genderLB.Name = "genderLB";
            this.genderLB.Size = new System.Drawing.Size(60, 17);
            this.genderLB.TabIndex = 11;
            this.genderLB.Text = "Gender:";
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(188, 11);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(261, 25);
            this.titleLB.TabIndex = 16;
            this.titleLB.Text = "CREATE NEW SUBJECT";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Location = new System.Drawing.Point(44, 305);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(53, 17);
            this.phoneLB.TabIndex = 15;
            this.phoneLB.Text = "Phone:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(358, 305);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(149, 22);
            this.phoneTB.TabIndex = 10;
            this.phoneTB.TextChanged += new System.EventHandler(this.phoneTB_TextChanged);
            this.phoneTB.Leave += new System.EventHandler(this.phoneTB_Leave);
            // 
            // birthdateLB
            // 
            this.birthdateLB.AutoSize = true;
            this.birthdateLB.Location = new System.Drawing.Point(44, 387);
            this.birthdateLB.Name = "birthdateLB";
            this.birthdateLB.Size = new System.Drawing.Size(69, 17);
            this.birthdateLB.TabIndex = 17;
            this.birthdateLB.Text = "Birthdate:";
            // 
            // birthdateDP
            // 
            this.birthdateDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateDP.Location = new System.Drawing.Point(358, 387);
            this.birthdateDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthdateDP.Name = "birthdateDP";
            this.birthdateDP.Size = new System.Drawing.Size(149, 22);
            this.birthdateDP.TabIndex = 12;
            this.birthdateDP.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // registrationdateLB
            // 
            this.registrationdateLB.AutoSize = true;
            this.registrationdateLB.Location = new System.Drawing.Point(44, 430);
            this.registrationdateLB.Name = "registrationdateLB";
            this.registrationdateLB.Size = new System.Drawing.Size(118, 17);
            this.registrationdateLB.TabIndex = 19;
            this.registrationdateLB.Text = "RegistrationDate:";
            // 
            // registrationdateDP
            // 
            this.registrationdateDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registrationdateDP.Location = new System.Drawing.Point(358, 425);
            this.registrationdateDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationdateDP.Name = "registrationdateDP";
            this.registrationdateDP.Size = new System.Drawing.Size(149, 22);
            this.registrationdateDP.TabIndex = 13;
            this.registrationdateDP.Value = new System.DateTime(2018, 11, 8, 0, 0, 0, 0);
            // 
            // contactpermissionLB
            // 
            this.contactpermissionLB.AutoSize = true;
            this.contactpermissionLB.Location = new System.Drawing.Point(44, 470);
            this.contactpermissionLB.Name = "contactpermissionLB";
            this.contactpermissionLB.Size = new System.Drawing.Size(129, 17);
            this.contactpermissionLB.TabIndex = 21;
            this.contactpermissionLB.Text = "ContactPermission:";
            // 
            // contactpermissionKB
            // 
            this.contactpermissionKB.AutoSize = true;
            this.contactpermissionKB.Location = new System.Drawing.Point(489, 470);
            this.contactpermissionKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactpermissionKB.Name = "contactpermissionKB";
            this.contactpermissionKB.Size = new System.Drawing.Size(18, 17);
            this.contactpermissionKB.TabIndex = 14;
            this.contactpermissionKB.UseVisualStyleBackColor = true;
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(44, 348);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(46, 17);
            this.emailLB.TabIndex = 23;
            this.emailLB.Text = "Email:";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(358, 345);
            this.emailTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(149, 22);
            this.emailTB.TabIndex = 11;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // nameEP
            // 
            this.nameEP.ContainerControl = this;
            // 
            // cancelBT
            // 
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBT.Location = new System.Drawing.Point(364, 615);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(109, 37);
            this.cancelBT.TabIndex = 16;
            this.cancelBT.Text = "CANCEL";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // clearBT
            // 
            this.clearBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearBT.Location = new System.Drawing.Point(45, 615);
            this.clearBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(109, 37);
            this.clearBT.TabIndex = 15;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = false;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // acceptBT
            // 
            this.acceptBT.Location = new System.Drawing.Point(479, 615);
            this.acceptBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptBT.Name = "acceptBT";
            this.acceptBT.Size = new System.Drawing.Size(109, 37);
            this.acceptBT.TabIndex = 17;
            this.acceptBT.Text = "ACCEPT";
            this.acceptBT.UseVisualStyleBackColor = true;
            this.acceptBT.Click += new System.EventHandler(this.acceptBT_Click);
            // 
            // createsubjectGB
            // 
            this.createsubjectGB.Controls.Add(this.consentfileBT);
            this.createsubjectGB.Controls.Add(this.consentfileTB);
            this.createsubjectGB.Controls.Add(this.label1);
            this.createsubjectGB.Controls.Add(this.idtypeCB);
            this.createsubjectGB.Controls.Add(this.idtypeLB);
            this.createsubjectGB.Controls.Add(this.countryCB);
            this.createsubjectGB.Controls.Add(this.countryLB);
            this.createsubjectGB.Controls.Add(this.emailTB);
            this.createsubjectGB.Controls.Add(this.genderCB);
            this.createsubjectGB.Controls.Add(this.emailLB);
            this.createsubjectGB.Controls.Add(this.nameLB);
            this.createsubjectGB.Controls.Add(this.nameTB);
            this.createsubjectGB.Controls.Add(this.contactpermissionKB);
            this.createsubjectGB.Controls.Add(this.surnameLB);
            this.createsubjectGB.Controls.Add(this.contactpermissionLB);
            this.createsubjectGB.Controls.Add(this.secondsurnameLB);
            this.createsubjectGB.Controls.Add(this.registrationdateDP);
            this.createsubjectGB.Controls.Add(this.surnameTB);
            this.createsubjectGB.Controls.Add(this.registrationdateLB);
            this.createsubjectGB.Controls.Add(this.secondsurnameTB);
            this.createsubjectGB.Controls.Add(this.birthdateDP);
            this.createsubjectGB.Controls.Add(this.idLB);
            this.createsubjectGB.Controls.Add(this.birthdateLB);
            this.createsubjectGB.Controls.Add(this.idTB);
            this.createsubjectGB.Controls.Add(this.phoneTB);
            this.createsubjectGB.Controls.Add(this.genderLB);
            this.createsubjectGB.Controls.Add(this.phoneLB);
            this.createsubjectGB.Location = new System.Drawing.Point(31, 41);
            this.createsubjectGB.Margin = new System.Windows.Forms.Padding(4);
            this.createsubjectGB.Name = "createsubjectGB";
            this.createsubjectGB.Padding = new System.Windows.Forms.Padding(4);
            this.createsubjectGB.Size = new System.Drawing.Size(557, 549);
            this.createsubjectGB.TabIndex = 24;
            this.createsubjectGB.TabStop = false;
            // 
            // idtypeCB
            // 
            this.idtypeCB.FormattingEnabled = true;
            this.idtypeCB.Items.AddRange(new object[] {
            "Spain",
            "Cuba",
            "United States",
            "Sweden"});
            this.idtypeCB.Location = new System.Drawing.Point(357, 188);
            this.idtypeCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypeCB.Name = "idtypeCB";
            this.idtypeCB.Size = new System.Drawing.Size(149, 24);
            this.idtypeCB.TabIndex = 7;
            // 
            // idtypeLB
            // 
            this.idtypeLB.AutoSize = true;
            this.idtypeLB.Location = new System.Drawing.Point(43, 191);
            this.idtypeLB.Name = "idtypeLB";
            this.idtypeLB.Size = new System.Drawing.Size(61, 17);
            this.idtypeLB.TabIndex = 26;
            this.idtypeLB.Text = "ID Type:";
            // 
            // countryCB
            // 
            this.countryCB.FormattingEnabled = true;
            this.countryCB.Items.AddRange(new object[] {
            "Spain",
            "Cuba",
            "United States",
            "Sweden"});
            this.countryCB.Location = new System.Drawing.Point(358, 268);
            this.countryCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryCB.Name = "countryCB";
            this.countryCB.Size = new System.Drawing.Size(149, 24);
            this.countryCB.TabIndex = 9;
            // 
            // countryLB
            // 
            this.countryLB.AutoSize = true;
            this.countryLB.Location = new System.Drawing.Point(44, 271);
            this.countryLB.Name = "countryLB";
            this.countryLB.Size = new System.Drawing.Size(61, 17);
            this.countryLB.TabIndex = 24;
            this.countryLB.Text = "Country:";
            // 
            // surnameEP
            // 
            this.surnameEP.ContainerControl = this;
            // 
            // secondsurnameEP
            // 
            this.secondsurnameEP.ContainerControl = this;
            // 
            // idEP
            // 
            this.idEP.ContainerControl = this;
            // 
            // phoneEP
            // 
            this.phoneEP.ContainerControl = this;
            // 
            // emailEP
            // 
            this.emailEP.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "ConsentFile:";
            // 
            // consentfileTB
            // 
            this.consentfileTB.Location = new System.Drawing.Point(182, 506);
            this.consentfileTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consentfileTB.Name = "consentfileTB";
            this.consentfileTB.Size = new System.Drawing.Size(277, 22);
            this.consentfileTB.TabIndex = 28;
            // 
            // consentfileBT
            // 
            this.consentfileBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consentfileBT.Location = new System.Drawing.Point(465, 499);
            this.consentfileBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consentfileBT.Name = "consentfileBT";
            this.consentfileBT.Size = new System.Drawing.Size(42, 30);
            this.consentfileBT.TabIndex = 29;
            this.consentfileBT.Text = "...";
            this.consentfileBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consentfileBT.UseVisualStyleBackColor = true;
            this.consentfileBT.Click += new System.EventHandler(this.consentfileBT_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 678);
            this.Controls.Add(this.createsubjectGB);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.acceptBT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CREATE A NEW SUBJECT";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameEP)).EndInit();
            this.createsubjectGB.ResumeLayout(false);
            this.createsubjectGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surnameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsurnameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label surnameLB;
        private System.Windows.Forms.Label secondsurnameLB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox secondsurnameTB;
        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label genderLB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label birthdateLB;
        private System.Windows.Forms.DateTimePicker birthdateDP;
        private System.Windows.Forms.Label registrationdateLB;
        private System.Windows.Forms.DateTimePicker registrationdateDP;
        private System.Windows.Forms.Label contactpermissionLB;
        private System.Windows.Forms.CheckBox contactpermissionKB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.ErrorProvider nameEP;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button acceptBT;
        private System.Windows.Forms.GroupBox createsubjectGB;
        private System.Windows.Forms.Label countryLB;
        private System.Windows.Forms.ComboBox countryCB;
        private System.Windows.Forms.ComboBox idtypeCB;
        private System.Windows.Forms.Label idtypeLB;
        private System.Windows.Forms.ErrorProvider surnameEP;
        private System.Windows.Forms.ErrorProvider secondsurnameEP;
        private System.Windows.Forms.ErrorProvider idEP;
        private System.Windows.Forms.ErrorProvider phoneEP;
        private System.Windows.Forms.ErrorProvider emailEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consentfileTB;
        private System.Windows.Forms.Button consentfileBT;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}