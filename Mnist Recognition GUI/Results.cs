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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }


        public void ModifyResults(int totalImages, int correctImages, double accuracy)
        {
            LblTotalImagesVal.Text = totalImages.ToString();
            lblCorrectImagesVal.Text = correctImages.ToString();
            lblAccuracyVal.Text = accuracy.ToString() + "%";
        }

        private void Results_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
