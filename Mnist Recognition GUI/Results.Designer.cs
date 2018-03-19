namespace Mnist_Recognition_GUI
{
    partial class Results
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
            this.lblTotalImages = new System.Windows.Forms.Label();
            this.lblCorrectImages = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblAccuracyVal = new System.Windows.Forms.Label();
            this.lblCorrectImagesVal = new System.Windows.Forms.Label();
            this.LblTotalImagesVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalImages
            // 
            this.lblTotalImages.AutoSize = true;
            this.lblTotalImages.Location = new System.Drawing.Point(63, 13);
            this.lblTotalImages.Name = "lblTotalImages";
            this.lblTotalImages.Size = new System.Drawing.Size(93, 17);
            this.lblTotalImages.TabIndex = 0;
            this.lblTotalImages.Text = "Total Images:";
            // 
            // lblCorrectImages
            // 
            this.lblCorrectImages.AutoSize = true;
            this.lblCorrectImages.Location = new System.Drawing.Point(63, 42);
            this.lblCorrectImages.Name = "lblCorrectImages";
            this.lblCorrectImages.Size = new System.Drawing.Size(107, 17);
            this.lblCorrectImages.TabIndex = 1;
            this.lblCorrectImages.Text = "Correct Images:";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(63, 74);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(70, 17);
            this.lblAccuracy.TabIndex = 2;
            this.lblAccuracy.Text = "Accuracy:";
            // 
            // lblAccuracyVal
            // 
            this.lblAccuracyVal.AutoSize = true;
            this.lblAccuracyVal.Location = new System.Drawing.Point(178, 74);
            this.lblAccuracyVal.Name = "lblAccuracyVal";
            this.lblAccuracyVal.Size = new System.Drawing.Size(16, 17);
            this.lblAccuracyVal.TabIndex = 5;
            this.lblAccuracyVal.Text = "0";
            // 
            // lblCorrectImagesVal
            // 
            this.lblCorrectImagesVal.AutoSize = true;
            this.lblCorrectImagesVal.Location = new System.Drawing.Point(178, 42);
            this.lblCorrectImagesVal.Name = "lblCorrectImagesVal";
            this.lblCorrectImagesVal.Size = new System.Drawing.Size(16, 17);
            this.lblCorrectImagesVal.TabIndex = 4;
            this.lblCorrectImagesVal.Text = "0";
            // 
            // LblTotalImagesVal
            // 
            this.LblTotalImagesVal.AutoSize = true;
            this.LblTotalImagesVal.Location = new System.Drawing.Point(178, 13);
            this.LblTotalImagesVal.Name = "LblTotalImagesVal";
            this.LblTotalImagesVal.Size = new System.Drawing.Size(16, 17);
            this.LblTotalImagesVal.TabIndex = 3;
            this.LblTotalImagesVal.Text = "0";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(338, 113);
            this.Controls.Add(this.lblAccuracyVal);
            this.Controls.Add(this.lblCorrectImagesVal);
            this.Controls.Add(this.LblTotalImagesVal);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblCorrectImages);
            this.Controls.Add(this.lblTotalImages);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalImages;
        private System.Windows.Forms.Label lblCorrectImages;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblAccuracyVal;
        private System.Windows.Forms.Label lblCorrectImagesVal;
        private System.Windows.Forms.Label LblTotalImagesVal;
    }
}