using ExercicioLógicaUm.Entities;
using ExercicioLógicaUm.Entities.Enums;

namespace ExercicioLogicaUm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite a quantidade de operações que deseja realizar");
                int n = int.Parse(Console.ReadLine());

                List<Calculadora> list = new List<Calculadora>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Digite o primeiro numero:");
                    float numeroUm = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero:");
                    float numeroDois = float.Parse(Console.ReadLine());

                    Console.WriteLine("Escolha a operação que deseja realizar: Adicao/subtracao/multiplicacao/divisao/potenciacao/raiz");
                    Operacoes operacoes = Enum.Parse<Operacoes>(Console.ReadLine());

                    Calculadora calc = new Calculadora(numeroUm, numeroDois, operacoes);

                    if (operacoes == Operacoes.Adicao)
                        calc.Adicao();

                    else if (operacoes == Operacoes.Subtracao)
                        calc.Subtracao();

                    else if (operacoes == Operacoes.Multiplicacao)
                        calc.Multipicacao();

                    else if (operacoes == Operacoes.Divisao)
                        calc.Divisao();

                    else if (operacoes == Operacoes.Potenciacao)
                        calc.Potenciacao();

                    else if (operacoes == Operacoes.Raiz)
                        calc.RaizQuadrada();

                    list.Add(calc);

                    Console.WriteLine();
                    Console.WriteLine(calc);
                }

                Console.WriteLine();
                Console.WriteLine("Histórico de resultados:" );
                list.ForEach(Console.WriteLine);

                Console.WriteLine("Deseja continuar? S/N");
                char cont = char.Parse(Console.ReadLine());

                if (cont == 'n' || cont == 'N')
                    break;
            }

        }
    }
}