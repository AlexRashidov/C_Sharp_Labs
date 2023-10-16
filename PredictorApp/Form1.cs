using System;
using System.Drawing;
using System.Windows.Forms;

namespace PredictorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void predictionButton_Click(object sender, EventArgs e)
        {
            predictionLabel.TextAlign = ContentAlignment.MiddleCenter;
            if (questionTextBox.Text != "" && questionTextBox.Text != null)
            {
                predictionLabel.Text = Program.GetPrediction();
            }
            else
            {
                predictionLabel.ForeColor = Color.Red;
                predictionLabel.Text = "ERROR: QUESTION IS EMPTY";
            }
            
        }
        

        private void predictionButtonX_Click(object sender, EventArgs e)
        {
            double probability;

            try
            {
                if(!Double.TryParse(userProbabilityTextBox.Text, out probability)) throw new Exception();

                string asnwer = answer.Text;

                predictionLabel.TextAlign = ContentAlignment.MiddleCenter;

                if (questionTextBox.Text != "" && questionTextBox.Text != null)
                {
                    predictionLabel.Text = Program.GetPredictionX(asnwer, probability);
                }

                else
                {
                    predictionLabel.ForeColor = Color.Red;
                    predictionLabel.Text = "ERROR: QUESTION IS EMPTY";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void predictionButtonY_Click(object sender, EventArgs e)
        {
            string asnwer = questionTextBox.Text;

            predictionLabel.TextAlign = ContentAlignment.MiddleCenter;
            if (questionTextBox.Text != "" && questionTextBox.Text != null)
            {
                predictionLabel.Text = Program.GetPredictionY(asnwer);
            }
            else
            {
                predictionLabel.ForeColor = Color.Red;
                predictionLabel.Text = "ERROR: QUESTION IS EMPTY";
            }
        }
    }
}
