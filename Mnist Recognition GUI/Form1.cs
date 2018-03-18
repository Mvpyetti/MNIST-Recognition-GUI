using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Mnist_Recognition_GUI
{

    public partial class MnistMain : Form
    {
        int intNeuronCnt;
        double dblEta;
        double dblMiniBatchCnt;
        double dblEpochCount;
        string actFunc;
        MnistWrapper.MnistWrapperClass PrimeNeuralNetwork;
 
        public MnistMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BtnTrainNN_Click(object sender, EventArgs e)
        {
            int totalImages = 0;
            int epochSize = 0;

            bool readImages = false;
            bool readLabels = false;

            //These will be our hard-coded file names. We do this for now because program doesnt work with other files yet.
            string strTrainingInFile = "train-images.idx3-ubyte";
            string strTrainingLblFile = "train-labels.idx1-ubyte";
            string strTestingInFile = "t10k-images.idx3-ubyte";
            string strTestinglblFile = "t10k-labels.idx1-ubyte";
            string strOutputFile = "TestResults.txt";


            //Obtain Hyper Parameters from GUI
            dblEta = double.Parse(txtEta.Text);
            intNeuronCnt = int.Parse(txtNeuronCnt.Text);
            dblMiniBatchCnt = double.Parse(txtMiniBatch.Text);
            dblEpochCount = double.Parse(txtEpoch.Text);
            actFunc = txtActFunc.Text;
            
            //Declare tempNeuralNetwork class(C++) and set all the hyper parameters
            MnistWrapper.MnistWrapperClass tempNeuralNetwork = new MnistWrapper.MnistWrapperClass();
            tempNeuralNetwork.SetActFunc(actFunc);
            tempNeuralNetwork.SetEpochCount(dblEpochCount);
            tempNeuralNetwork.SetNeuronCount(intNeuronCnt);
            tempNeuralNetwork.SetEta(dblEta);

            //Obtain the images and labels from the given file names
            Task<bool> gettingImagesTask = new Task<bool>(() => { return tempNeuralNetwork.ReadImages(strTrainingInFile); });
            Task<bool> gettingLabelsTask = new Task<bool>(() => { return tempNeuralNetwork.ReadLabels(strTrainingLblFile); });
            gettingImagesTask.Start();
            gettingLabelsTask.Start();

            Cursor.Current = Cursors.WaitCursor;

            DisableActions();
            int counter = 0;
            while(!tempNeuralNetwork.FinishedReadingImages() || !tempNeuralNetwork.FinishedReadingLabels())
            {
                switch (counter)
                {
                    case 0:
                        WaitingLabel.Text = "Loading images and labels from local folder.";
                        counter++;
                        break;
                    case 1:
                        WaitingLabel.Text = "Loading images and labels from local folder..";
                        counter++;
                        break;
                    case 2:
                        WaitingLabel.Text = "Loading images and labels from local folder...";
                        counter = 0;
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            readLabels = await gettingLabelsTask;
            readImages = await gettingImagesTask;
            WaitingLabel.Text = "";
            Cursor.Current = Cursors.Default;

            epochSize = tempNeuralNetwork.GetEpochSize();
            totalImages = tempNeuralNetwork.GetTotalImages();

            Task trainingTask = new Task(() => { tempNeuralNetwork.TrainNetwork(); } );
            trainingTask.Start();

            LoadingScreen currLoadingScreen = new LoadingScreen();
            currLoadingScreen.Show(this);

            while (!(tempNeuralNetwork.FinishedTraining()))
            {
                currLoadingScreen.AdjustLoadBar(tempNeuralNetwork.GetImagesRead(), totalImages, tempNeuralNetwork.GetEpochIterator(), epochSize);
            }
            currLoadingScreen.Close();
            EnableActions();
            PrimeNeuralNetwork = tempNeuralNetwork;
        }


        private void BtnTestNeuralNetwork_Click(object sender, EventArgs e)
        {
           //This function will only be called if a neural network has been trained.
           //Now we want to train a set of images 
        }

        private void DisableActions()
        {
            BtnTrainNN.Enabled = false;
            BtnTestNeuralNetwork.Enabled = false;
            txtActFunc.Enabled = false;
            txtMiniBatch.Enabled = false;
            txtNeuronCnt.Enabled = false;
            txtEta.Enabled = false;
            txtActFunc.Enabled = false;
            txtEpoch.Enabled = false;
        }

        private void EnableActions()
        {
            BtnTrainNN.Enabled = true;
            BtnTestNeuralNetwork.Enabled = true;
            txtActFunc.Enabled = true;
            txtMiniBatch.Enabled = true;
            txtNeuronCnt.Enabled = true;
            txtEta.Enabled = true;
            txtActFunc.Enabled = true;
            txtEpoch.Enabled = true;
        }
    }
}
