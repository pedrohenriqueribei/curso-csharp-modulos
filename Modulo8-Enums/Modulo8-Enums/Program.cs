using Modulo8_Enums.Entidades;
using Modulo8_Enums.Entidades.Enums;

namespace Modulo8_Enums
{
	class MyClass
	{
		static void Main(string[] args)
		{
			OrdemDeServico os = new OrdemDeServico
			{
				Id = 1080,
				Moment = DateTime.Now,
				Status = StatusEnum.PagamentoPendente
			};

            Console.WriteLine(os);


			string str = StatusEnum.PagamentoPendente.ToString();

            Console.WriteLine(str);


			StatusEnum status = Enum.Parse<StatusEnum>("Entregue");

			Console.WriteLine(status);
		}
	}
}