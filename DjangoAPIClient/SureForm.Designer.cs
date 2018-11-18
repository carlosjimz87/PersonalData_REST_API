namespace DjangoAPIClient
{
    partial class SureForm
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
            this.titleLB = new System.Windows.Forms.Label();
            this.sureLB = new System.Windows.Forms.Label();
            this.cancelBT = new System.Windows.Forms.Button();
            this.acceptBT = new System.Windows.Forms.Button();
            this.sure2LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(138, 18);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(233, 25);
            this.titleLB.TabIndex = 15;
            this.titleLB.Text = "REMOVING SUBJECT";
            // 
            // sureLB
            // 
            this.sureLB.AutoSize = true;
            this.sureLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLB.Location = new System.Drawing.Point(38, 86);
            this.sureLB.Name = "sureLB";
            this.sureLB.Size = new System.Drawing.Size(427, 20);
            this.sureLB.TabIndex = 16;
            this.sureLB.Text = "You´re going to REMOVE a Subject instance on the DB.";
            // 
            // cancelBT
            // 
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBT.Location = new System.Drawing.Point(128, 177);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(109, 37);
            this.cancelBT.TabIndex = 22;
            this.cancelBT.Text = "CANCEL";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // acceptBT
            // 
            this.acceptBT.Location = new System.Drawing.Point(263, 177);
            this.acceptBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptBT.Name = "acceptBT";
            this.acceptBT.Size = new System.Drawing.Size(109, 37);
            this.acceptBT.TabIndex = 21;
            this.acceptBT.Text = "ACCEPT";
            this.acceptBT.UseVisualStyleBackColor = true;
            // 
            // sure2LB
            // 
            this.sure2LB.AutoSize = true;
            this.sure2LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sure2LB.Location = new System.Drawing.Point(192, 119);
            this.sure2LB.Name = "sure2LB";
            this.sure2LB.Size = new System.Drawing.Size(113, 20);
            this.sure2LB.TabIndex = 23;
            this.sure2LB.Text = "Are you sure?";
            // 
            // SureForm
            // 
            this.AcceptButton = this.acceptBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBT;
            this.ClientSize = new System.Drawing.Size(505, 245);
            this.Controls.Add(this.sure2LB);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.acceptBT);
            this.Controls.Add(this.sureLB);
            this.Controls.Add(this.titleLB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REMOVING SUBJECT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label sureLB;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button acceptBT;
        private System.Windows.Forms.Label sure2LB;
    }
}