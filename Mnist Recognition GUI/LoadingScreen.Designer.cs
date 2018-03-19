namespace Mnist_Recognition_GUI
{
    partial class LoadingScreen
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
            this.LoadBar = new System.Windows.Forms.ProgressBar();
            this.lblEpochload = new System.Windows.Forms.Label();
            this.LblldImage = new System.Windows.Forms.Label();
            this.LblLdTraining = new System.Windows.Forms.Label();
            this.LblLdEpochVal = new System.Windows.Forms.Label();
            this.LblldImageVal = new System.Windows.Forms.Label();
            this.LblldPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadBar
            // 
            this.LoadBar.Location = new System.Drawing.Point(49, 33);
            this.LoadBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadBar.Name = "LoadBar";
            this.LoadBar.Size = new System.Drawing.Size(425, 50);
            this.LoadBar.TabIndex = 0;
            // 
            // lblEpochload
            // 
            this.lblEpochload.AutoSize = true;
            this.lblEpochload.Location = new System.Drawing.Point(45, 89);
            this.lblEpochload.Name = "lblEpochload";
            this.lblEpochload.Size = new System.Drawing.Size(52, 17);
            this.lblEpochload.TabIndex = 1;
            this.lblEpochload.Text = "Epoch:";
            // 
            // LblldImage
            // 
            this.LblldImage.AutoSize = true;
            this.LblldImage.Location = new System.Drawing.Point(324, 89);
            this.LblldImage.Name = "LblldImage";
            this.LblldImage.Size = new System.Drawing.Size(50, 17);
            this.LblldImage.TabIndex = 2;
            this.LblldImage.Text = "Image:";
            // 
            // LblLdTraining
            // 
            this.LblLdTraining.AutoSize = true;
            this.LblLdTraining.Location = new System.Drawing.Point(216, 10);
            this.LblLdTraining.Name = "LblLdTraining";
            this.LblLdTraining.Size = new System.Drawing.Size(72, 17);
            this.LblLdTraining.TabIndex = 3;
            this.LblLdTraining.Text = "Training...";
            // 
            // LblLdEpochVal
            // 
            this.LblLdEpochVal.AutoSize = true;
            this.LblLdEpochVal.Location = new System.Drawing.Point(105, 86);
            this.LblLdEpochVal.Name = "LblLdEpochVal";
            this.LblLdEpochVal.Size = new System.Drawing.Size(0, 17);
            this.LblLdEpochVal.TabIndex = 4;
            // 
            // LblldImageVal
            // 
            this.LblldImageVal.AutoSize = true;
            this.LblldImageVal.Location = new System.Drawing.Point(381, 89);
            this.LblldImageVal.Name = "LblldImageVal";
            this.LblldImageVal.Size = new System.Drawing.Size(0, 17);
            this.LblldImageVal.TabIndex = 5;
            // 
            // LblldPercentage
            // 
            this.LblldPercentage.AutoSize = true;
            this.LblldPercentage.Location = new System.Drawing.Point(232, 48);
            this.LblldPercentage.Name = "LblldPercentage";
            this.LblldPercentage.Size = new System.Drawing.Size(40, 17);
            this.LblldPercentage.TabIndex = 6;
            this.LblldPercentage.Text = "0.0%";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(531, 116);
            this.Controls.Add(this.LblldPercentage);
            this.Controls.Add(this.LblldImageVal);
            this.Controls.Add(this.LblLdEpochVal);
            this.Controls.Add(this.LblLdTraining);
            this.Controls.Add(this.LblldImage);
            this.Controls.Add(this.lblEpochload);
            this.Controls.Add(this.LoadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadBar;
        private System.Windows.Forms.Label lblEpochload;
        private System.Windows.Forms.Label LblldImage;
        private System.Windows.Forms.Label LblLdTraining;
        private System.Windows.Forms.Label LblLdEpochVal;
        private System.Windows.Forms.Label LblldImageVal;
        private System.Windows.Forms.Label LblldPercentage;
    }
}