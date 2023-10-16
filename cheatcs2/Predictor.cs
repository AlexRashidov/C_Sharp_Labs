//namespace cheatcs2
//{
//    public class Predictor
//    {
//        private List<string> _answers;

//        public Predictor(List<string>? answers = null)
//        {
//            this._answers = answers ?? new List<string>() { "Да", "Нет" };
//        }

//        public string EquallyProbability()
//        {
//            Random r = new Random();
//            int dr = r.Next(0, _answers.Count - 1);
//            return _answers[dr];
//        }

//        public string ProbabilityX(string inputString, double probable)
//        {
//            if (inputString == "" || !_answers.Contains(inputString))
//            {
//                throw new Exception("Error: The answer is not in the list!");
//            }
//            else
//            {
//                /*  
//                    1. 1 - probable, остальное поделить на кол-во элементов - 1
//                    2. Если падает меньше либо равно, чем probable, тогда выводим probable, если больше чем probable, тогда
//                        1. Вычитаем probable из рандома
//                        2. Прогоняем через for до тех пор, пока рандом - probable не будет меньше i*ср.вероятность, затем выводим _answers[i]
//                */
                                
//                double average = (1 - probable) / (_answers.Count - 1);
//                Random random = new Random();
//                double randomDouble = random.NextDouble();
//                if (randomDouble > probable)
//                {
//                    for (int i = 0; i < _answers.Count; i++)
//                    {
//                        bool exit = false;
//                        if (randomDouble - probable < i * average)
//                        {
//                            exit = true;
//                            inputString = _answers[i];
//                        }
//                        if (exit) { break; }
//                    }
//                }

//                return inputString;
//            }
//        }

//        public string ProbabilityY(string inputString) 
//        {
//            if (inputString == "")
//            {
//                throw new Exception("Error: The answer is not in the list!");
//            }
//            else
//            {
//                string maxPredict = "";
//                foreach (string predict in _answers)
//                {
//                    if (predict.Length > maxPredict.Length)
//                    {
//                        maxPredict = predict;
//                    }
//                }

//                Random random = new Random();

//                int wordsCount = inputString.Split(' ').Length;
//                if (wordsCount > maxPredict.Length)
//                {
//                    return ProbabilityX(_answers[random.Next(_answers.Count)], random.NextDouble());
//                }
//                else
//                {
//                    return ProbabilityX(_answers[random.Next(_answers.Count)], 0.1);
//                }
//            }
//        }

//        public override string ToString()
//        {
//            return $"Answers: {String.Join(", ", this._answers)}";
//        }
//    }
//}