namespace DjangoAPIClient
{
    partial class IdTypeForm
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
            this.titleLB = new System.Windows.Forms.Label();
            this.regexTB = new System.Windows.Forms.TextBox();
            this.regexLB = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.cancelBT = new System.Windows.Forms.Button();
            this.acceptBT = new System.Windows.Forms.Button();
            this.createidtypeGB = new System.Windows.Forms.GroupBox();
            this.nameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.regextEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearBT = new System.Windows.Forms.Button();
            this.createidtypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regextEP)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(117, 11);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(238, 25);
            this.titleLB.TabIndex = 14;
            this.titleLB.Text = "CREATE NEW IDTYPE";
            // 
            // regexTB
            // 
            this.regexTB.Location = new System.Drawing.Point(257, 65);
            this.regexTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regexTB.Name = "regexTB";
            this.regexTB.Size = new System.Drawing.Size(149, 22);
            this.regexTB.TabIndex = 18;
            // 
            // regexLB
            // 
            this.regexLB.AutoSize = true;
            this.regexLB.Location = new System.Drawing.Point(37, 70);
            this.regexLB.Name = "regexLB";
            this.regexLB.Size = new System.Drawing.Size(52, 17);
            this.regexLB.TabIndex = 17;
            this.regexLB.Text = "Regex:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(258, 22);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(149, 22);
            this.nameTB.TabIndex = 16;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(37, 25);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(49, 17);
            this.nameLB.TabIndex = 15;
            this.nameLB.Text = "Name:";
            // 
            // cancelBT
            // 
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelBT.Location = new System.Drawing.Point(253, 188);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(109, 37);
            this.cancelBT.TabIndex = 20;
            this.cancelBT.Text = "CANCEL";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // acceptBT
            // 
            this.acceptBT.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.acceptBT.Location = new System.Drawing.Point(368, 188);
            this.acceptBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptBT.Name = "acceptBT";
            this.acceptBT.Size = new System.Drawing.Size(109, 37);
            this.acceptBT.TabIndex = 19;
            this.acceptBT.Text = "ACCEPT";
            this.acceptBT.UseVisualStyleBackColor = true;
            // 
            // createidtypeGB
            // 
            this.createidtypeGB.Controls.Add(this.regexTB);
            this.createidtypeGB.Controls.Add(this.nameLB);
            this.createidtypeGB.Controls.Add(this.nameTB);
            this.createidtypeGB.Controls.Add(this.regexLB);
            this.createidtypeGB.Location = new System.Drawing.Point(16, 52);
            this.createidtypeGB.Margin = new System.Windows.Forms.Padding(4);
            this.createidtypeGB.Name = "createidtypeGB";
            this.createidtypeGB.Padding = new System.Windows.Forms.Padding(4);
            this.createidtypeGB.Size = new System.Drawing.Size(461, 113);
            this.createidtypeGB.TabIndex = 21;
            this.createidtypeGB.TabStop = false;
            // 
            // nameEP
            // 
            this.nameEP.ContainerControl = this;
            // 
            // regextEP
            // 
            this.regextEP.ContainerControl = this;
            // 
            // clearBT
            // 
            this.clearBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearBT.Location = new System.Drawing.Point(16, 188);
            this.clearBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(109, 37);
            this.clearBT.TabIndex = 22;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = false;
            // 
            // IdTypeForm
            // 
            this.AcceptButton = this.acceptBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBT;
            this.ClientSize = new System.Drawing.Size(505, 245);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.createidtypeGB);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.acceptBT);
            this.Controls.Add(this.titleLB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CREATE A NEW IDTYPE";
            this.Load += new System.EventHandler(this.IdTypeForm_Load);
            this.createidtypeGB.ResumeLayout(false);
            this.createidtypeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regextEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.TextBox regexTB;
        private System.Windows.Forms.Label regexLB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button acceptBT;
        private System.Windows.Forms.GroupBox createidtypeGB;
        private System.Windows.Forms.ErrorProvider nameEP;
        private System.Windows.Forms.ErrorProvider regextEP;
        private System.Windows.Forms.Button clearBT;
    }
}