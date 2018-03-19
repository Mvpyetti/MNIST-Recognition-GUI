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
    public enum Mode
    {
        TRAINING,
        TESTING
    };

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

            //These will be our hard-coded file names. We do this for now because program doesnt work with other files yet.
            string strTrainingInFile = "train-images.idx3-ubyte";
            string strTrainingLblFile = "train-labels.idx1-ubyte";


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
            GenerateLoadingImgTxt(ref tempNeuralNetwork);

            Cursor.Current = Cursors.Default;

            epochSize = tempNeuralNetwork.GetEpochSize();
            totalImages = tempNeuralNetwork.GetTotalImages();

            Task trainingTask = new Task(() => { tempNeuralNetwork.TrainNetwork(); } );
            trainingTask.Start();

            //While the Network is training with read inputs and labels, display a loading screen 
            LoadingScreen currLoadingScreen = new LoadingScreen();
            currLoadingScreen.Show(this);

            while (!(tempNeuralNetwork.FinishedTraining()))
            {
                currLoadingScreen.AdjustLoadBar(tempNeuralNetwork.GetImagesRead(), totalImages, tempNeuralNetwork.GetEpochIterator(), epochSize, Mode.TRAINING);
            }
            await trainingTask;
            currLoadingScreen.Close();
            EnableActions();
            PrimeNeuralNetwork = tempNeuralNetwork;
        }


        private async void BtnTestNeuralNetwork_Click(object sender, EventArgs e)
        {
            //This function will only be called if a neural network has been trained.
            //Now we want to train a set of images 
            int totalImages = 0;
            bool gotImages = false;
            bool gotLabels = false;

            string strTestingInFile = "t10k-images.idx3-ubyte";
            string strTestinglblFile = "t10k-labels.idx1-ubyte";

            PrimeNeuralNetwork.SetEpochCount(1);
            Task<bool> gettingImagesTask = new Task<bool>(() => { return PrimeNeuralNetwork.ReadImages(strTestingInFile); });
            Task<bool> gettingLabelsTask = new Task<bool>(() => { return PrimeNeuralNetwork.ReadLabels(strTestinglblFile); });
            gettingImagesTask.Start();
            gettingLabelsTask.Start();

            Cursor.Current = Cursors.WaitCursor;

            DisableActions();
            
            //NOTE: the following function will only end when Images and Labels are done being read
            GenerateLoadingImgTxt(ref PrimeNeuralNetwork);

            gotImages = await gettingImagesTask;
            gotLabels = await gettingLabelsTask;

            Cursor.Current = Cursors.Default;

            totalImages = PrimeNeuralNetwork.GetTotalImages();

            //Since the testing images and labels have been read, we can now begin testing
            Task taskTestingNetwork = new Task(() => { PrimeNeuralNetwork.TestNetwork(); });
            taskTestingNetwork.Start();

            //Generate a testing loading bar screen
            LoadingScreen currLoadingScreen = new LoadingScreen();
            currLoadingScreen.Show(this);

            while(!PrimeNeuralNetwork.FinishedTesting())
            {
                currLoadingScreen.AdjustLoadBar(PrimeNeuralNetwork.GetImagesRead(), totalImages, 0, totalImages, Mode.TESTING);
            }

            await taskTestingNetwork;
            currLoadingScreen.Close();

            DisplayResults();
            EnableActions();

        }

        private void GenerateLoadingImgTxt(ref MnistWrapper.MnistWrapperClass currNetwork)
        {
            int counter = 0;
            while (!currNetwork.FinishedReadingImages() || !currNetwork.FinishedReadingLabels())
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
            WaitingLabel.Text = "";
        }

        private void DisplayResults()
        {
            Results newResults = new Results();
            newResults.ModifyResults(PrimeNeuralNetwork.GetTotalImages(), PrimeNeuralNetwork.GetCorrectImages(), PrimeNeuralNetwork.GetAccuracy());
            newResults.Show(this);
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
