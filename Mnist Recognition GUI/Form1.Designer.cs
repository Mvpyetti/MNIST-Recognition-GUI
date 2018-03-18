namespace Mnist_Recognition_GUI
{
    partial class MnistMain
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
            this.MNISTImage = new System.Windows.Forms.PictureBox();
            this.BtnTestNeuralNetwork = new System.Windows.Forms.Button();
            this.BtnTrainNN = new System.Windows.Forms.Button();
            this.txtEpoch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNeuronCnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActFunc = new System.Windows.Forms.ComboBox();
            this.txtMiniBatch = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.WaitingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MNISTImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MNISTImage
            // 
            this.MNISTImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MNISTImage.Location = new System.Drawing.Point(330, 23);
            this.MNISTImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MNISTImage.MaximumSize = new System.Drawing.Size(315, 341);
            this.MNISTImage.Name = "MNISTImage";
            this.MNISTImage.Size = new System.Drawing.Size(315, 341);
            this.MNISTImage.TabIndex = 0;
            this.MNISTImage.TabStop = false;
            // 
            // BtnTestNeuralNetwork
            // 
            this.BtnTestNeuralNetwork.Enabled = false;
            this.BtnTestNeuralNetwork.Location = new System.Drawing.Point(34, 304);
            this.BtnTestNeuralNetwork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTestNeuralNetwork.Name = "BtnTestNeuralNetwork";
            this.BtnTestNeuralNetwork.Size = new System.Drawing.Size(259, 63);
            this.BtnTestNeuralNetwork.TabIndex = 1;
            this.BtnTestNeuralNetwork.Text = "Test Neural Network";
            this.BtnTestNeuralNetwork.UseVisualStyleBackColor = true;
            this.BtnTestNeuralNetwork.Click += new System.EventHandler(this.BtnTestNeuralNetwork_Click);
            // 
            // BtnTrainNN
            // 
            this.BtnTrainNN.Location = new System.Drawing.Point(37, 219);
            this.BtnTrainNN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTrainNN.Name = "BtnTrainNN";
            this.BtnTrainNN.Size = new System.Drawing.Size(256, 63);
            this.BtnTrainNN.TabIndex = 3;
            this.BtnTrainNN.Text = "Train Neural Network";
            this.BtnTrainNN.UseVisualStyleBackColor = true;
            this.BtnTrainNN.Click += new System.EventHandler(this.BtnTrainNN_Click);
            // 
            // txtEpoch
            // 
            this.txtEpoch.Location = new System.Drawing.Point(34, 41);
            this.txtEpoch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEpoch.Name = "txtEpoch";
            this.txtEpoch.Size = new System.Drawing.Size(94, 20);
            this.txtEpoch.TabIndex = 4;
            this.txtEpoch.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Epoch Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Activation Function:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Neuron Count";
            // 
            // txtNeuronCnt
            // 
            this.txtNeuronCnt.Location = new System.Drawing.Point(34, 158);
            this.txtNeuronCnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNeuronCnt.Name = "txtNeuronCnt";
            this.txtNeuronCnt.Size = new System.Drawing.Size(94, 20);
            this.txtNeuronCnt.TabIndex = 9;
            this.txtNeuronCnt.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MiniBatch Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eta:";
            // 
            // txtActFunc
            // 
            this.txtActFunc.AllowDrop = true;
            this.txtActFunc.FormattingEnabled = true;
            this.txtActFunc.Items.AddRange(new object[] {
            "TANH",
            "SIGMOID",
            "DOUBLE SIG",
            "ReLU"});
            this.txtActFunc.Location = new System.Drawing.Point(37, 98);
            this.txtActFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActFunc.Name = "txtActFunc";
            this.txtActFunc.Size = new System.Drawing.Size(92, 21);
            this.txtActFunc.TabIndex = 14;
            this.txtActFunc.Text = "TANH";
            // 
            // txtMiniBatch
            // 
            this.txtMiniBatch.Location = new System.Drawing.Point(188, 100);
            this.txtMiniBatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiniBatch.Name = "txtMiniBatch";
            this.txtMiniBatch.Size = new System.Drawing.Size(94, 20);
            this.txtMiniBatch.TabIndex = 15;
            this.txtMiniBatch.Text = "1";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(188, 41);
            this.txtEta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(94, 20);
            this.txtEta.TabIndex = 16;
            this.txtEta.Text = ".05";
            // 
            // WaitingLabel
            // 
            this.WaitingLabel.AutoSize = true;
            this.WaitingLabel.Location = new System.Drawing.Point(34, 188);
            this.WaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WaitingLabel.Name = "WaitingLabel";
            this.WaitingLabel.Size = new System.Drawing.Size(0, 13);
            this.WaitingLabel.TabIndex = 17;
            // 
            // MnistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 405);
            this.Controls.Add(this.WaitingLabel);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtMiniBatch);
            this.Controls.Add(this.txtActFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNeuronCnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEpoch);
            this.Controls.Add(this.BtnTrainNN);
            this.Controls.Add(this.BtnTestNeuralNetwork);
            this.Controls.Add(this.MNISTImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MnistMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mnist Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MNISTImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MNISTImage;
        private System.Windows.Forms.Button BtnTestNeuralNetwork;
        private System.Windows.Forms.Button BtnTrainNN;
        private System.Windows.Forms.TextBox txtEpoch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNeuronCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtActFunc;
        private System.Windows.Forms.TextBox txtMiniBatch;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label WaitingLabel;
    }
}

