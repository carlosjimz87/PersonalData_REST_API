namespace DjangoAPIClient
{
    partial class ChooseObject
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
            this.resultLB = new System.Windows.Forms.ListBox();
            this.titleLB = new System.Windows.Forms.Label();
            this.cancelBT = new System.Windows.Forms.Button();
            this.acceptBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLB
            // 
            this.resultLB.FormattingEnabled = true;
            this.resultLB.ItemHeight = 20;
            this.resultLB.Location = new System.Drawing.Point(30, 86);
            this.resultLB.Name = "resultLB";
            this.resultLB.Size = new System.Drawing.Size(394, 264);
            this.resultLB.TabIndex = 0;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(25, 25);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(399, 29);
            this.titleLB.TabIndex = 17;
            this.titleLB.Text = "CHOOSE A SUBJECT TO SHOW";
            // 
            // cancelBT
            // 
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBT.Location = new System.Drawing.Point(172, 374);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(123, 46);
            this.cancelBT.TabIndex = 1;
            this.cancelBT.Text = "CANCEL";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // acceptBT
            // 
            this.acceptBT.Location = new System.Drawing.Point(301, 374);
            this.acceptBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptBT.Name = "acceptBT";
            this.acceptBT.Size = new System.Drawing.Size(123, 46);
            this.acceptBT.TabIndex = 2;
            this.acceptBT.Text = "ACCEPT";
            this.acceptBT.UseVisualStyleBackColor = true;
            // 
            // ChooseObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.acceptBT);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.resultLB);
            this.Name = "ChooseObject";
            this.Text = "CHOOSE A SUBJECT TO SHOW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultLB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button acceptBT;
    }
}