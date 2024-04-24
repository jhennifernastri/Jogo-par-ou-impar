using System;

namespace ProvaQuestao1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            int pontoJogador = 0;
            int pontoComputador = 0;
            int respostaUsuario = 1;

            do
            {
                Console.Write("Você quer par (p) ou ímpar (i)?");
                string opcaoJogador = Console.ReadLine().ToUpper();

                if (opcaoJogador == "P" ||  opcaoJogador == "I")
                {
                    Console.Write("Informe um número inteiro entre 0 e 100: ");
                    int numeroJogador = int.Parse(Console.ReadLine());

                    if (numeroJogador >= 0 && numeroJogador < 101)
                    {

                        Random roleta = new Random();
                        int numeroComputador = roleta.Next(100);
                        Console.WriteLine($"\nA escolha do computador é: {numeroComputador}");

                        if ((numeroJogador + numeroComputador) % 2 == 0)
                        {
                            if (opcaoJogador == "P")
                            {
                                Console.WriteLine("Jogador ganhou");
                                pontoJogador++;
                            }
                            else
                            {
                                Console.WriteLine("Computador ganhou");
                                pontoComputador++;
                            }
                        }
                        else
                        {
                            if (opcaoJogador == "I")
                            {
                                Console.WriteLine("Jogador ganhou");
                                pontoJogador++;
                            }
                            else
                            {
                                Console.WriteLine("Computador ganhou");
                                pontoComputador++;
                            }

                        }

                        Console.WriteLine("\nVocê deseja continuar? 0-Não 1-Sim");
                        respostaUsuario = int.Parse(Console.ReadLine());

                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida. Por favor, digite um valor entre 0 e 100");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Resposta inválida. Por favor, digite par (p) ou ímpar (i)");
                    continue;

                }

            } while (respostaUsuario == 1);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------------------RESULTADO------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine($"----------Jogador: {pontoJogador} x Computador: {pontoComputador}---------");

            if (pontoJogador > pontoComputador)
                Console.WriteLine("---------------Jogador Ganhou----------------");
            else if (pontoJogador < pontoComputador)
                Console.WriteLine("--------------Computador Ganhou--------------");
            else                                 
                Console.WriteLine("-------------------Empate--------------------");


            Console.WriteLine("\n------------Aperte ENTER para sair-----------");
            Console.ReadLine();

        }
    }
}
