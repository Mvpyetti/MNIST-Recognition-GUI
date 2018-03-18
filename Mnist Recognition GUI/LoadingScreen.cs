using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnist_Recognition_GUI
{
    public partial class LoadingScreen : Form
    {

        public LoadingScreen()
        {
            InitializeComponent();
        }

        public void AdjustLoadBar(int imagesRead, int totalImages, int epochIterator, int epochSize)
        {
            TrainingLoadBar.Value = imagesRead * TrainingLoadBar.Maximum / totalImages;
            LblLdEpochVal.Text = epochIterator.ToString();
            LblldImageVal.Text = (imagesRead % epochSize).ToString();
            LblldPercentage.Text = Math.Round((imagesRead / (double)totalImages * 100),2).ToString() + "%";
            Application.DoEvents();
        }


        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
