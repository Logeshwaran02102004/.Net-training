namespace WindowsFormsApp1
{
    partial class mainform
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
            this.Welcomelbe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcomelbe
            // 
            this.Welcomelbe.AutoSize = true;
            this.Welcomelbe.Location = new System.Drawing.Point(369, 77);
            this.Welcomelbe.Name = "Welcomelbe";
            this.Welcomelbe.Size = new System.Drawing.Size(51, 20);
            this.Welcomelbe.TabIndex = 0;
            this.Welcomelbe.Text = "label1";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcomelbe);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbe;
    }
}