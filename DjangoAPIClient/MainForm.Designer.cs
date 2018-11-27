namespace DjangoAPIClient
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectsGET = new System.Windows.Forms.Button();
            this.subjectGET = new System.Windows.Forms.Button();
            this.getGB = new System.Windows.Forms.GroupBox();
            this.idtypesGET = new System.Windows.Forms.Button();
            this.idtypeGET = new System.Windows.Forms.Button();
            this.subjectsbyphoneGET = new System.Windows.Forms.Button();
            this.subjectsbyidcardtypeGET = new System.Windows.Forms.Button();
            this.subjectsbyemailGET = new System.Windows.Forms.Button();
            this.subjectsbyfullnameGET = new System.Windows.Forms.Button();
            this.subjectsbygenderGET = new System.Windows.Forms.Button();
            this.subjectsbycountryGET = new System.Windows.Forms.Button();
            this.subjectsbybirthdateGET = new System.Windows.Forms.Button();
            this.subjectsbyregdateGET = new System.Windows.Forms.Button();
            this.subjectbyidcardGET = new System.Windows.Forms.Button();
            this.createGB = new System.Windows.Forms.GroupBox();
            this.idtypeCREATE = new System.Windows.Forms.Button();
            this.subjectCREATE = new System.Windows.Forms.Button();
            this.updateGB = new System.Windows.Forms.GroupBox();
            this.idtypeUPDATE = new System.Windows.Forms.Button();
            this.subjectUPDATE = new System.Windows.Forms.Button();
            this.deleteGB = new System.Windows.Forms.GroupBox();
            this.idtypeDELETE = new System.Windows.Forms.Button();
            this.subjectDELETE = new System.Windows.Forms.Button();
            this.errorsTB = new System.Windows.Forms.TextBox();
            this.titleLB = new System.Windows.Forms.Label();
            this.responseGB = new System.Windows.Forms.GroupBox();
            this.errorsGB = new System.Windows.Forms.GroupBox();
            this.filterGB = new System.Windows.Forms.GroupBox();
            this.filteridcardtypeTB = new System.Windows.Forms.TextBox();
            this.filterphoneTB = new System.Windows.Forms.TextBox();
            this.filteremailTB = new System.Windows.Forms.TextBox();
            this.filterfullnameTB = new System.Windows.Forms.TextBox();
            this.filtergenderTB = new System.Windows.Forms.TextBox();
            this.filtercountryTB = new System.Windows.Forms.TextBox();
            this.filterbirthdateTB = new System.Windows.Forms.TextBox();
            this.filterregdateTB = new System.Windows.Forms.TextBox();
            this.filteridcardTB = new System.Windows.Forms.TextBox();
            this.responseDGV = new System.Windows.Forms.DataGridView();
            this.getGB.SuspendLayout();
            this.createGB.SuspendLayout();
            this.updateGB.SuspendLayout();
            this.deleteGB.SuspendLayout();
            this.responseGB.SuspendLayout();
            this.errorsGB.SuspendLayout();
            this.filterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsGET
            // 
            this.subjectsGET.Location = new System.Drawing.Point(20, 18);
            this.subjectsGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsGET.Name = "subjectsGET";
            this.subjectsGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsGET.TabIndex = 0;
            this.subjectsGET.Text = "SUBJECTS";
            this.subjectsGET.UseVisualStyleBackColor = true;
            this.subjectsGET.Click += new System.EventHandler(this.SubjectListGET_Click);
            // 
            // subjectGET
            // 
            this.subjectGET.Location = new System.Drawing.Point(20, 59);
            this.subjectGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectGET.Name = "subjectGET";
            this.subjectGET.Size = new System.Drawing.Size(152, 34);
            this.subjectGET.TabIndex = 2;
            this.subjectGET.Text = "SUBJECT";
            this.subjectGET.UseVisualStyleBackColor = true;
            this.subjectGET.Click += new System.EventHandler(this.SubjectGET_Click);
            // 
            // getGB
            // 
            this.getGB.Controls.Add(this.idtypesGET);
            this.getGB.Controls.Add(this.idtypeGET);
            this.getGB.Controls.Add(this.subjectsGET);
            this.getGB.Controls.Add(this.subjectGET);
            this.getGB.Location = new System.Drawing.Point(9, 112);
            this.getGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getGB.Name = "getGB";
            this.getGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getGB.Size = new System.Drawing.Size(355, 103);
            this.getGB.TabIndex = 7;
            this.getGB.TabStop = false;
            this.getGB.Text = "GET";
            // 
            // idtypesGET
            // 
            this.idtypesGET.Location = new System.Drawing.Point(181, 18);
            this.idtypesGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypesGET.Name = "idtypesGET";
            this.idtypesGET.Size = new System.Drawing.Size(152, 34);
            this.idtypesGET.TabIndex = 12;
            this.idtypesGET.Text = "IDTYPES";
            this.idtypesGET.UseVisualStyleBackColor = true;
            this.idtypesGET.Click += new System.EventHandler(this.IdTypesGET_Click);
            // 
            // idtypeGET
            // 
            this.idtypeGET.Location = new System.Drawing.Point(181, 59);
            this.idtypeGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypeGET.Name = "idtypeGET";
            this.idtypeGET.Size = new System.Drawing.Size(152, 34);
            this.idtypeGET.TabIndex = 11;
            this.idtypeGET.Text = "IDTYPE";
            this.idtypeGET.UseVisualStyleBackColor = true;
            this.idtypeGET.Click += new System.EventHandler(this.IdtypeGET_Click);
            // 
            // subjectsbyphoneGET
            // 
            this.subjectsbyphoneGET.Location = new System.Drawing.Point(20, 306);
            this.subjectsbyphoneGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbyphoneGET.Name = "subjectsbyphoneGET";
            this.subjectsbyphoneGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbyphoneGET.TabIndex = 21;
            this.subjectsbyphoneGET.Text = "PHONE";
            this.subjectsbyphoneGET.UseVisualStyleBackColor = true;
            this.subjectsbyphoneGET.Click += new System.EventHandler(this.SubjectsByPhoneGET_Click);
            // 
            // subjectsbyidcardtypeGET
            // 
            this.subjectsbyidcardtypeGET.Location = new System.Drawing.Point(20, 348);
            this.subjectsbyidcardtypeGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbyidcardtypeGET.Name = "subjectsbyidcardtypeGET";
            this.subjectsbyidcardtypeGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbyidcardtypeGET.TabIndex = 20;
            this.subjectsbyidcardtypeGET.Text = "IDCARD TYPE";
            this.subjectsbyidcardtypeGET.UseVisualStyleBackColor = true;
            this.subjectsbyidcardtypeGET.Click += new System.EventHandler(this.SubjectsByIdCardTypeGET_Click);
            // 
            // subjectsbyemailGET
            // 
            this.subjectsbyemailGET.Location = new System.Drawing.Point(20, 266);
            this.subjectsbyemailGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbyemailGET.Name = "subjectsbyemailGET";
            this.subjectsbyemailGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbyemailGET.TabIndex = 19;
            this.subjectsbyemailGET.Text = "EMAIL";
            this.subjectsbyemailGET.UseVisualStyleBackColor = true;
            this.subjectsbyemailGET.Click += new System.EventHandler(this.SubjectsByEmailGET_Click);
            // 
            // subjectsbyfullnameGET
            // 
            this.subjectsbyfullnameGET.Location = new System.Drawing.Point(20, 225);
            this.subjectsbyfullnameGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbyfullnameGET.Name = "subjectsbyfullnameGET";
            this.subjectsbyfullnameGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbyfullnameGET.TabIndex = 18;
            this.subjectsbyfullnameGET.Text = "FULLNAME";
            this.subjectsbyfullnameGET.UseVisualStyleBackColor = true;
            this.subjectsbyfullnameGET.Click += new System.EventHandler(this.SubjectsByFullNameGET_Click);
            // 
            // subjectsbygenderGET
            // 
            this.subjectsbygenderGET.Location = new System.Drawing.Point(20, 183);
            this.subjectsbygenderGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbygenderGET.Name = "subjectsbygenderGET";
            this.subjectsbygenderGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbygenderGET.TabIndex = 17;
            this.subjectsbygenderGET.Text = "GENDER";
            this.subjectsbygenderGET.UseVisualStyleBackColor = true;
            this.subjectsbygenderGET.Click += new System.EventHandler(this.SubjectsByGenderGET_Click);
            // 
            // subjectsbycountryGET
            // 
            this.subjectsbycountryGET.Location = new System.Drawing.Point(20, 143);
            this.subjectsbycountryGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbycountryGET.Name = "subjectsbycountryGET";
            this.subjectsbycountryGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbycountryGET.TabIndex = 16;
            this.subjectsbycountryGET.Text = "COUNTRY";
            this.subjectsbycountryGET.UseVisualStyleBackColor = true;
            this.subjectsbycountryGET.Click += new System.EventHandler(this.SubjectsByCountryGET_Click);
            // 
            // subjectsbybirthdateGET
            // 
            this.subjectsbybirthdateGET.Location = new System.Drawing.Point(20, 102);
            this.subjectsbybirthdateGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbybirthdateGET.Name = "subjectsbybirthdateGET";
            this.subjectsbybirthdateGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbybirthdateGET.TabIndex = 15;
            this.subjectsbybirthdateGET.Text = "BIRTHDATE";
            this.subjectsbybirthdateGET.UseVisualStyleBackColor = true;
            this.subjectsbybirthdateGET.Click += new System.EventHandler(this.SubjectsByBirthdateGET_Click);
            // 
            // subjectsbyregdateGET
            // 
            this.subjectsbyregdateGET.Location = new System.Drawing.Point(20, 60);
            this.subjectsbyregdateGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectsbyregdateGET.Name = "subjectsbyregdateGET";
            this.subjectsbyregdateGET.Size = new System.Drawing.Size(152, 34);
            this.subjectsbyregdateGET.TabIndex = 14;
            this.subjectsbyregdateGET.Text = "REGDATE";
            this.subjectsbyregdateGET.UseVisualStyleBackColor = true;
            this.subjectsbyregdateGET.Click += new System.EventHandler(this.SubjectsByRegdateGET_Click);
            // 
            // subjectbyidcardGET
            // 
            this.subjectbyidcardGET.Location = new System.Drawing.Point(20, 20);
            this.subjectbyidcardGET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectbyidcardGET.Name = "subjectbyidcardGET";
            this.subjectbyidcardGET.Size = new System.Drawing.Size(152, 34);
            this.subjectbyidcardGET.TabIndex = 13;
            this.subjectbyidcardGET.Text = "IDCARD";
            this.subjectbyidcardGET.UseVisualStyleBackColor = true;
            this.subjectbyidcardGET.Click += new System.EventHandler(this.SubjectByIdCardGET_Click);
            // 
            // createGB
            // 
            this.createGB.Controls.Add(this.idtypeCREATE);
            this.createGB.Controls.Add(this.subjectCREATE);
            this.createGB.Location = new System.Drawing.Point(9, 46);
            this.createGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGB.Name = "createGB";
            this.createGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGB.Size = new System.Drawing.Size(355, 63);
            this.createGB.TabIndex = 8;
            this.createGB.TabStop = false;
            this.createGB.Text = "CREATE";
            // 
            // idtypeCREATE
            // 
            this.idtypeCREATE.Location = new System.Drawing.Point(181, 18);
            this.idtypeCREATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypeCREATE.Name = "idtypeCREATE";
            this.idtypeCREATE.Size = new System.Drawing.Size(152, 34);
            this.idtypeCREATE.TabIndex = 10;
            this.idtypeCREATE.Text = "IDTYPE";
            this.idtypeCREATE.UseVisualStyleBackColor = true;
            this.idtypeCREATE.Click += new System.EventHandler(this.IdtypeCREATE_Click);
            // 
            // subjectCREATE
            // 
            this.subjectCREATE.Location = new System.Drawing.Point(20, 18);
            this.subjectCREATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectCREATE.Name = "subjectCREATE";
            this.subjectCREATE.Size = new System.Drawing.Size(152, 34);
            this.subjectCREATE.TabIndex = 7;
            this.subjectCREATE.Text = "SUBJECT";
            this.subjectCREATE.UseVisualStyleBackColor = true;
            this.subjectCREATE.Click += new System.EventHandler(this.SubjectCREATE_Click);
            // 
            // updateGB
            // 
            this.updateGB.Controls.Add(this.idtypeUPDATE);
            this.updateGB.Controls.Add(this.subjectUPDATE);
            this.updateGB.Location = new System.Drawing.Point(9, 666);
            this.updateGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateGB.Name = "updateGB";
            this.updateGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateGB.Size = new System.Drawing.Size(355, 62);
            this.updateGB.TabIndex = 9;
            this.updateGB.TabStop = false;
            this.updateGB.Text = "UPDATE";
            // 
            // idtypeUPDATE
            // 
            this.idtypeUPDATE.Location = new System.Drawing.Point(179, 18);
            this.idtypeUPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypeUPDATE.Name = "idtypeUPDATE";
            this.idtypeUPDATE.Size = new System.Drawing.Size(152, 34);
            this.idtypeUPDATE.TabIndex = 12;
            this.idtypeUPDATE.Text = "IDTYPE";
            this.idtypeUPDATE.UseVisualStyleBackColor = true;
            this.idtypeUPDATE.Click += new System.EventHandler(this.IdTypeUPDATE_Click);
            // 
            // subjectUPDATE
            // 
            this.subjectUPDATE.Location = new System.Drawing.Point(20, 18);
            this.subjectUPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectUPDATE.Name = "subjectUPDATE";
            this.subjectUPDATE.Size = new System.Drawing.Size(152, 34);
            this.subjectUPDATE.TabIndex = 7;
            this.subjectUPDATE.Text = "SUBJECT";
            this.subjectUPDATE.UseVisualStyleBackColor = true;
            this.subjectUPDATE.Click += new System.EventHandler(this.SubjectUPDATE_Click);
            // 
            // deleteGB
            // 
            this.deleteGB.Controls.Add(this.idtypeDELETE);
            this.deleteGB.Controls.Add(this.subjectDELETE);
            this.deleteGB.Location = new System.Drawing.Point(9, 732);
            this.deleteGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteGB.Name = "deleteGB";
            this.deleteGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteGB.Size = new System.Drawing.Size(355, 62);
            this.deleteGB.TabIndex = 10;
            this.deleteGB.TabStop = false;
            this.deleteGB.Text = "DELETE";
            // 
            // idtypeDELETE
            // 
            this.idtypeDELETE.Location = new System.Drawing.Point(179, 18);
            this.idtypeDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtypeDELETE.Name = "idtypeDELETE";
            this.idtypeDELETE.Size = new System.Drawing.Size(152, 34);
            this.idtypeDELETE.TabIndex = 11;
            this.idtypeDELETE.Text = "IDTYPE";
            this.idtypeDELETE.UseVisualStyleBackColor = true;
            this.idtypeDELETE.Click += new System.EventHandler(this.IdtypeDELETE_Click);
            // 
            // subjectDELETE
            // 
            this.subjectDELETE.Location = new System.Drawing.Point(20, 18);
            this.subjectDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectDELETE.Name = "subjectDELETE";
            this.subjectDELETE.Size = new System.Drawing.Size(149, 34);
            this.subjectDELETE.TabIndex = 7;
            this.subjectDELETE.Text = "SUBJECT";
            this.subjectDELETE.UseVisualStyleBackColor = true;
            this.subjectDELETE.Click += new System.EventHandler(this.SubjectDELETE_Click);
            // 
            // errorsTB
            // 
            this.errorsTB.Location = new System.Drawing.Point(7, 25);
            this.errorsTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorsTB.Multiline = true;
            this.errorsTB.Name = "errorsTB";
            this.errorsTB.Size = new System.Drawing.Size(1099, 142);
            this.errorsTB.TabIndex = 11;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(592, 11);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(265, 25);
            this.titleLB.TabIndex = 16;
            this.titleLB.Text = "TESTING GDPR-APP-API";
            // 
            // responseGB
            // 
            this.responseGB.Controls.Add(this.responseDGV);
            this.responseGB.Location = new System.Drawing.Point(369, 46);
            this.responseGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.responseGB.Name = "responseGB";
            this.responseGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.responseGB.Size = new System.Drawing.Size(1128, 569);
            this.responseGB.TabIndex = 18;
            this.responseGB.TabStop = false;
            this.responseGB.Text = "RESPONSE";
            // 
            // errorsGB
            // 
            this.errorsGB.Controls.Add(this.errorsTB);
            this.errorsGB.Location = new System.Drawing.Point(369, 618);
            this.errorsGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorsGB.Name = "errorsGB";
            this.errorsGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorsGB.Size = new System.Drawing.Size(1128, 175);
            this.errorsGB.TabIndex = 19;
            this.errorsGB.TabStop = false;
            this.errorsGB.Text = "ERRORS";
            // 
            // filterGB
            // 
            this.filterGB.Controls.Add(this.filteridcardtypeTB);
            this.filterGB.Controls.Add(this.filterphoneTB);
            this.filterGB.Controls.Add(this.filteremailTB);
            this.filterGB.Controls.Add(this.filterfullnameTB);
            this.filterGB.Controls.Add(this.filtergenderTB);
            this.filterGB.Controls.Add(this.filtercountryTB);
            this.filterGB.Controls.Add(this.filterbirthdateTB);
            this.filterGB.Controls.Add(this.filterregdateTB);
            this.filterGB.Controls.Add(this.filteridcardTB);
            this.filterGB.Controls.Add(this.subjectsbyphoneGET);
            this.filterGB.Controls.Add(this.subjectsbyemailGET);
            this.filterGB.Controls.Add(this.subjectsbyidcardtypeGET);
            this.filterGB.Controls.Add(this.subjectbyidcardGET);
            this.filterGB.Controls.Add(this.subjectsbyregdateGET);
            this.filterGB.Controls.Add(this.subjectsbyfullnameGET);
            this.filterGB.Controls.Add(this.subjectsbybirthdateGET);
            this.filterGB.Controls.Add(this.subjectsbygenderGET);
            this.filterGB.Controls.Add(this.subjectsbycountryGET);
            this.filterGB.Location = new System.Drawing.Point(9, 220);
            this.filterGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterGB.Name = "filterGB";
            this.filterGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterGB.Size = new System.Drawing.Size(355, 441);
            this.filterGB.TabIndex = 20;
            this.filterGB.TabStop = false;
            this.filterGB.Text = "FILTER BY";
            // 
            // filteridcardtypeTB
            // 
            this.filteridcardtypeTB.Location = new System.Drawing.Point(181, 354);
            this.filteridcardtypeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteridcardtypeTB.Name = "filteridcardtypeTB";
            this.filteridcardtypeTB.Size = new System.Drawing.Size(149, 22);
            this.filteridcardtypeTB.TabIndex = 30;
            // 
            // filterphoneTB
            // 
            this.filterphoneTB.Location = new System.Drawing.Point(181, 313);
            this.filterphoneTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterphoneTB.Name = "filterphoneTB";
            this.filterphoneTB.Size = new System.Drawing.Size(149, 22);
            this.filterphoneTB.TabIndex = 29;
            // 
            // filteremailTB
            // 
            this.filteremailTB.Location = new System.Drawing.Point(184, 272);
            this.filteremailTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteremailTB.Name = "filteremailTB";
            this.filteremailTB.Size = new System.Drawing.Size(149, 22);
            this.filteremailTB.TabIndex = 28;
            // 
            // filterfullnameTB
            // 
            this.filterfullnameTB.Location = new System.Drawing.Point(185, 231);
            this.filterfullnameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterfullnameTB.Name = "filterfullnameTB";
            this.filterfullnameTB.Size = new System.Drawing.Size(149, 22);
            this.filterfullnameTB.TabIndex = 27;
            // 
            // filtergenderTB
            // 
            this.filtergenderTB.Location = new System.Drawing.Point(185, 190);
            this.filtergenderTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filtergenderTB.Name = "filtergenderTB";
            this.filtergenderTB.Size = new System.Drawing.Size(149, 22);
            this.filtergenderTB.TabIndex = 26;
            // 
            // filtercountryTB
            // 
            this.filtercountryTB.Location = new System.Drawing.Point(185, 149);
            this.filtercountryTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filtercountryTB.Name = "filtercountryTB";
            this.filtercountryTB.Size = new System.Drawing.Size(149, 22);
            this.filtercountryTB.TabIndex = 25;
            // 
            // filterbirthdateTB
            // 
            this.filterbirthdateTB.Location = new System.Drawing.Point(184, 108);
            this.filterbirthdateTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterbirthdateTB.Name = "filterbirthdateTB";
            this.filterbirthdateTB.Size = new System.Drawing.Size(149, 22);
            this.filterbirthdateTB.TabIndex = 24;
            // 
            // filterregdateTB
            // 
            this.filterregdateTB.Location = new System.Drawing.Point(185, 66);
            this.filterregdateTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterregdateTB.Name = "filterregdateTB";
            this.filterregdateTB.Size = new System.Drawing.Size(149, 22);
            this.filterregdateTB.TabIndex = 23;
            // 
            // filteridcardTB
            // 
            this.filteridcardTB.Location = new System.Drawing.Point(185, 26);
            this.filteridcardTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filteridcardTB.Name = "filteridcardTB";
            this.filteridcardTB.Size = new System.Drawing.Size(149, 22);
            this.filteridcardTB.TabIndex = 22;
            // 
            // responseDGV
            // 
            this.responseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responseDGV.Location = new System.Drawing.Point(7, 20);
            this.responseDGV.Name = "responseDGV";
            this.responseDGV.RowTemplate.Height = 24;
            this.responseDGV.Size = new System.Drawing.Size(1115, 536);
            this.responseDGV.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 804);
            this.Controls.Add(this.filterGB);
            this.Controls.Add(this.errorsGB);
            this.Controls.Add(this.responseGB);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.deleteGB);
            this.Controls.Add(this.updateGB);
            this.Controls.Add(this.createGB);
            this.Controls.Add(this.getGB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTING GDPR-APP-API";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.getGB.ResumeLayout(false);
            this.createGB.ResumeLayout(false);
            this.updateGB.ResumeLayout(false);
            this.deleteGB.ResumeLayout(false);
            this.responseGB.ResumeLayout(false);
            this.errorsGB.ResumeLayout(false);
            this.errorsGB.PerformLayout();
            this.filterGB.ResumeLayout(false);
            this.filterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subjectsGET;
        private System.Windows.Forms.Button subjectGET;
        private System.Windows.Forms.GroupBox getGB;
        private System.Windows.Forms.GroupBox createGB;
        private System.Windows.Forms.Button subjectCREATE;
        private System.Windows.Forms.GroupBox updateGB;
        private System.Windows.Forms.Button subjectUPDATE;
        private System.Windows.Forms.GroupBox deleteGB;
        private System.Windows.Forms.Button subjectDELETE;
        private System.Windows.Forms.Button idtypeCREATE;
        private System.Windows.Forms.Button idtypeDELETE;
        private System.Windows.Forms.Button idtypeUPDATE;
        private System.Windows.Forms.TextBox errorsTB;
        private System.Windows.Forms.Button idtypesGET;
        private System.Windows.Forms.Button idtypeGET;
        private System.Windows.Forms.Button subjectbyidcardGET;
        private System.Windows.Forms.Button subjectsbyregdateGET;
        private System.Windows.Forms.Button subjectsbybirthdateGET;
        private System.Windows.Forms.Button subjectsbycountryGET;
        private System.Windows.Forms.Button subjectsbygenderGET;
        private System.Windows.Forms.Button subjectsbyfullnameGET;
        private System.Windows.Forms.Button subjectsbyemailGET;
        private System.Windows.Forms.Button subjectsbyidcardtypeGET;
        private System.Windows.Forms.Button subjectsbyphoneGET;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.GroupBox responseGB;
        private System.Windows.Forms.GroupBox errorsGB;
        private System.Windows.Forms.GroupBox filterGB;
        private System.Windows.Forms.TextBox filteridcardtypeTB;
        private System.Windows.Forms.TextBox filterphoneTB;
        private System.Windows.Forms.TextBox filteremailTB;
        private System.Windows.Forms.TextBox filterfullnameTB;
        private System.Windows.Forms.TextBox filtergenderTB;
        private System.Windows.Forms.TextBox filtercountryTB;
        private System.Windows.Forms.TextBox filterbirthdateTB;
        private System.Windows.Forms.TextBox filterregdateTB;
        private System.Windows.Forms.TextBox filteridcardTB;
        private System.Windows.Forms.DataGridView responseDGV;
    }
}

