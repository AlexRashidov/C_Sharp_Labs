using cheatcs2;

List<string> list = new List<string>() { "Да", "Нет", "Не знаю", "Возможно", "Точно" };

Predictor pr = new Predictor(list);

Console.WriteLine(pr.EquallyProbability());
