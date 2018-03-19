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

        public void AdjustLoadBar(int imagesRead, int totalImages, int epochIterator, int epochSize, Mode currMode)
        {
            LoadBar.Value = imagesRead * LoadBar.Maximum / totalImages;
            if(currMode == Mode.TRAINING)
            {
                LblLdEpochVal.Text = epochIterator.ToString();
                LblldImageVal.Text = (imagesRead % epochSize).ToString();
            }
            else
            {
                if (currMode == Mode.TESTING)
                {
                    lblEpochload.Text = " ";
                    LblldImageVal.Text = imagesRead.ToString();
                }
            }
            LblldPercentage.Text = Math.Round((imagesRead / (double)totalImages * 100),2).ToString() + "%";
            Application.DoEvents();
        }


        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
