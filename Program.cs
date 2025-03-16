double valorDolar = 0.0, cotação= 0.0, valorReal = 0.0;

Console.Write("Insira um valor em dolar: ");
valorDolar= double.Parse(Console.ReadLine());

Console.Write("Insira a cotação atual: ");
cotação= double.Parse(Console.ReadLine());

valorReal= valorDolar * cotação;

Console.WriteLine($"Você tem: BRL {valorReal.ToString("F2")}");

