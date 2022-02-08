using System;

namespace Calculadora.ConsoleApp
{
    public class program
    {
        static void main(string[] args)
        {

            string opcao = "";
            bool tentenovamente = false;
            do
            {
                Console.WriteLine("CALCULADORA TOP 1,2");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para sair");
                opcao = Console.ReadLine();
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("digite uma opção valida");
                    Console.ResetColor();
                    Console.ReadLine();
                    tentenovamente = true;
                    
                }
                else if (opcao == "5")
                {
                    break;

                }
                else
                {

                    Console.WriteLine("Digite os Numeros");
                    Console.WriteLine("Digite o Primeiro Numero");
                    string strPrimeiroNumero = Console.ReadLine();
                    Console.WriteLine("Digite O Segundo Numero");
                    string strSegundoNumero = Console.ReadLine();
                    double primeironumero = System.Convert.ToDouble(strPrimeiroNumero);
                    double segundonmero = System.Convert.ToDouble(strSegundoNumero);

                    double resultadoOperacao = 0;


                    if (opcao == "1")
                    {

                        resultadoOperacao = primeironumero + segundonmero;

                    }
                    else if (opcao == "2")
                    {

                        resultadoOperacao = primeironumero - segundonmero;

                    }
                    else if (opcao == "3")
                    {

                        resultadoOperacao = primeironumero * segundonmero;

                    }
                    else if (opcao == "4")
                    {
                        if (primeironumero == 0 || segundonmero == 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Conta invalida, sua conta possui um 0");

                        }
                        else
                        {

                            resultadoOperacao = primeironumero / segundonmero;

                        }
                    }
                    Console.WriteLine(resultadoOperacao);
                    Console.ReadLine();


                }
            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || tentenovamente == true);





















        }

    }
}
