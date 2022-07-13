using System;



	class ejecicio01deiniguezoscar
	{

		static void Main(string[] args)
		{
			double dolaroficial;
			double dolarparalelo;
			double euro;
			int pesos;
			Console.Write(" ingrese la cantidad de dinero en pesos:");
			pesos = int.Parse(Console.ReadLine());
			dolaroficial = pesos * 230;
			dolarparalelo = pesos * 280;
			euro = dolaroficial * dolarparalelo;
			Console.WriteLine(" en el mercado de dolar oficial con pesos podes comprar esta cantidad de dolares:" + dolaroficial);
			Console.WriteLine(" con pesos podes comprar esta cantidad de dolares paralelo:" + dolarparalelo);
			Console.WriteLine("con pesos podes comprar esta cantidad de euros :" + euro);
		}

	}

}

