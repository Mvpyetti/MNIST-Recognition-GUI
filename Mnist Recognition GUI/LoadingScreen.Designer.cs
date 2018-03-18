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
            this.TrainingLoadBar = new System.Windows.Forms.ProgressBar();
            this.lblEpochload = new System.Windows.Forms.Label();
            this.LblldImage = new System.Windows.Forms.Label();
            this.LblLdTraining = new System.Windows.Forms.Label();
            this.LblLdEpochVal = new System.Windows.Forms.Label();
            this.LblldImageVal = new System.Windows.Forms.Label();
            this.LblldPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrainingLoadBar
            // 
            this.TrainingLoadBar.Location = new System.Drawing.Point(37, 27);
            this.TrainingLoadBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrainingLoadBar.Name = "TrainingLoadBar";
            this.TrainingLoadBar.Size = new System.Drawing.Size(319, 41);
            this.TrainingLoadBar.TabIndex = 0;
            // 
            // lblEpochload
            // 
            this.lblEpochload.AutoSize = true;
            this.lblEpochload.Location = new System.Drawing.Point(34, 72);
            this.lblEpochload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpochload.Name = "lblEpochload";
            this.lblEpochload.Size = new System.Drawing.Size(41, 13);
            this.lblEpochload.TabIndex = 1;
            this.lblEpochload.Text = "Epoch:";
            // 
            // LblldImage
            // 
            this.LblldImage.AutoSize = true;
            this.LblldImage.Location = new System.Drawing.Point(243, 72);
            this.LblldImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblldImage.Name = "LblldImage";
            this.LblldImage.Size = new System.Drawing.Size(39, 13);
            this.LblldImage.TabIndex = 2;
            this.LblldImage.Text = "Image:";
            // 
            // LblLdTraining
            // 
            this.LblLdTraining.AutoSize = true;
            this.LblLdTraining.Location = new System.Drawing.Point(162, 8);
            this.LblLdTraining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLdTraining.Name = "LblLdTraining";
            this.LblLdTraining.Size = new System.Drawing.Size(54, 13);
            this.LblLdTraining.TabIndex = 3;
            this.LblLdTraining.Text = "Training...";
            // 
            // LblLdEpochVal
            // 
            this.LblLdEpochVal.AutoSize = true;
            this.LblLdEpochVal.Location = new System.Drawing.Point(79, 70);
            this.LblLdEpochVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLdEpochVal.Name = "LblLdEpochVal";
            this.LblLdEpochVal.Size = new System.Drawing.Size(0, 13);
            this.LblLdEpochVal.TabIndex = 4;
            // 
            // LblldImageVal
            // 
            this.LblldImageVal.AutoSize = true;
            this.LblldImageVal.Location = new System.Drawing.Point(286, 72);
            this.LblldImageVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblldImageVal.Name = "LblldImageVal";
            this.LblldImageVal.Size = new System.Drawing.Size(0, 13);
            this.LblldImageVal.TabIndex = 5;
            // 
            // LblldPercentage
            // 
            this.LblldPercentage.AutoSize = true;
            this.LblldPercentage.Location = new System.Drawing.Point(174, 39);
            this.LblldPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblldPercentage.Name = "LblldPercentage";
            this.LblldPercentage.Size = new System.Drawing.Size(30, 13);
            this.LblldPercentage.TabIndex = 6;
            this.LblldPercentage.Text = "0.0%";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(398, 94);
            this.Controls.Add(this.LblldPercentage);
            this.Controls.Add(this.LblldImageVal);
            this.Controls.Add(this.LblLdEpochVal);
            this.Controls.Add(this.LblLdTraining);
            this.Controls.Add(this.LblldImage);
            this.Controls.Add(this.lblEpochload);
            this.Controls.Add(this.TrainingLoadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar TrainingLoadBar;
        private System.Windows.Forms.Label lblEpochload;
        private System.Windows.Forms.Label LblldImage;
        private System.Windows.Forms.Label LblLdTraining;
        private System.Windows.Forms.Label LblLdEpochVal;
        private System.Windows.Forms.Label LblldImageVal;
        private System.Windows.Forms.Label LblldPercentage;
    }
}