/*

wrong:

int 5minutos;
int salário;
int salario do funcionario;

correct:
int _5minutos;
int salario;
int salarioDoFuncionario;

• Camel Case: lastName (parâmetros de métodos, variáveis dentro de
métodos)

• Pascal Case: LastName (namespaces, classe, properties e métodos)

• Padrão _lastName (atributos "internos" da classe)

Example in Csharp

namespace Curso
{
	class ContaBancaria
	{
		public string Titular { get; set; }
		private double _saldo;

		public void Deposito(double quantia)
		{
			_saldo += quantia;
		}

		public double GetSaldo()
		{
			return _saldo;
		}
	}
}

*/