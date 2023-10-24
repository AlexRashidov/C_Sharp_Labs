using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cheatcs2;

namespace PredictorApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static string GetPrediction()
        {
            Predictor predictor = new Predictor();
            return predictor.EquallyProbability();
        }

        public static string GetPredictionX(string inputString, double probable)
        {
            //List<string> list = new List<string>() { "123", "asd" ,"нЕТ", "qweqweqwe"};
            Predictor predictor = new Predictor();
            return predictor.ProbabilityX(inputString, probable);
        }
        public static string GetPredictionY(string inputString)
        {
            //List<string> list = new List<string>() { "123", "asd" ,"нЕТ", "qweqweqwe"};
            Predictor predictor = new Predictor();
            return predictor.ProbabilityY(inputString);
        }


    }
}
