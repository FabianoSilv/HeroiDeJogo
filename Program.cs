using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HeroiDeJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja iniciar o jogo? digite s ou pressione qualquer tecla pra sair");
            string iniciar = Console.ReadLine();

            if (iniciar == "s")
            {

                Hero hero1 = new Hero();
                Hero.IdadeDoHeroi();
                Console.WriteLine("Digite o nome do Heroi");
                Hero.Nome = Console.ReadLine();
                Hero.TipoDeHeroi();
                Hero.MostrarCaracteristicas();
            }
            else
            {
                Console.WriteLine("Você não quis iniciar");
                Console.ReadLine();
            }
        }
    }

    public class Hero
    {
        public static string Nome;
        public static int Idade;
        public static string Tipo;
        public static string Atak;


        public static void IdadeDoHeroi()
        {

            Console.WriteLine("Você é maior de 18? Digite s ou n");
            string restrincao = Console.ReadLine();

            if (restrincao == "s")
            {
                Console.WriteLine("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());

                Idade = idade;
            }
            else
            {
                Console.WriteLine("Ver como faz pra encerrar o programa aqui.");
            }


        }

        public static void TipoDeHeroi()
        {
            string classe = "Nenhuma";

            Console.WriteLine("Escolha o numero da classe: \n 1 - Mago \n 2 - Guerreiro \n 3 - Ninja \n 4 - Monge");
            int selecClasse = int.Parse(Console.ReadLine());

            switch (selecClasse)
            {
                case 1:
                    classe = "Mago";
                    break;

                case 2:
                    classe = "Guerreiro";
                    break;

                case 3:
                    classe = "Ninja";
                    break;
                case 4:
                    classe = "Monge";
                    break;
                default:
                    break;
            }

            Tipo = classe;
            TipoDeAtak();
        }
        private static void TipoDeAtak()
        {

            string atak = Tipo;

            if (atak == "Mago")
            {
                atak = "magia";
            }
            else if (atak == "Guerreiro")
            {
                atak = "espada";
            }
            else if (atak == "Ninja")
            {
                atak = "shuriken";
            }
            else if (atak == "Monge")
            {
                atak = "artes marciais";
            }
            Atak = atak;
        }

        public static void MostrarCaracteristicas()
        {
            Console.WriteLine($"O nome do seu heroi é {Nome} sua idade é {Idade} ");
                Console.WriteLine($" {Tipo} atacou usando {Atak}");
            Console.ReadLine();
        }
    }

}

