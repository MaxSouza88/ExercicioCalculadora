using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculadora
{
    internal class Program
    {
        enum Menu { Adição = 1, Subtração, Divisão, Multiplicação, SAIR}
        
        static void Main(string[] args)
        {

            bool escolhaSair = false;
            while (!escolhaSair) { 

                Console.WriteLine("Bem Vindo a minha calculadora \nEscolha uma opção:");
                Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - SAIR");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao) 
                {
                    case Menu.SAIR:
                        escolhaSair = true;
                        Console.WriteLine("Voce escolheu a opção: " + opcao);
                        break;

                    case Menu.Adição:

                        Console.WriteLine("Voce escolheu a opção: " + opcao);

                        Console.WriteLine("Digite o primeiro Número:");
                        float num1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o primeiro Número:");
                        float num2 = float.Parse(Console.ReadLine());
                        float resultadoSoma = (float)num1 + num2;

                        Console.WriteLine("A soma dos numeros informados é: " + resultadoSoma);
                        
                        break;

                    case Menu.Subtração:
                        
                        Console.WriteLine("Voce escolheu a opção" + opcao);

                        Console.WriteLine("Digite o primeiro Número:");
                        float numS1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o primeiro Número:");
                        float numS2 = float.Parse(Console.ReadLine());
                        float resultadoSubtracao = (float)numS1 - numS2;

                        Console.WriteLine("A soma dos numeros informados é: " + resultadoSubtracao);

                        break;

                    case Menu.Divisão:
                        
                        Console.WriteLine("Voce escolheu a opção" + opcao);
                        Console.WriteLine("Digite o primeiro Número:");
                        float numD1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o primeiro Número:");
                        float numD2 = float.Parse(Console.ReadLine());
                        float resultadoDivisao = (float)numD1 / numD2;

                        Console.WriteLine("A soma dos numeros informados é: " + resultadoDivisao);

                        break;

                    case Menu.Multiplicação:
                        
                        Console.WriteLine("Voce escolheu a opção" + opcao);
                        Console.WriteLine("Digite o primeiro Número:");
                        float numM1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o primeiro Número:");
                        float numM2 = float.Parse(Console.ReadLine());
                        float resultadoMultiplicação = (float)numM1 * numM2;

                        Console.WriteLine("A soma dos numeros informados é: " + resultadoMultiplicação);

                        break;

                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
