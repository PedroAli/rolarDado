using System;

namespace RolarDado
{
    class Program
    {
        static void Main(string[] args)
        {
            MainRolarDdo(); // não consegui chamar o main?
        }

        static void MainRolarDdo()
        {
            Escrever("Digite o Número de lados");
            int quantidadeDeLados = Convert.ToInt32(Console.ReadLine());
            if (quantidadeDeLados > 100)
            {
                Escrever("O valor não pode ser maior q 100!!! ");
                MainRolarDdo();
            }
            //string teste = Escrever(texto); ??
            Escrever($"O Número digitado foi {quantidadeDeLados}");
            int NumeroRolado = RolarDado(quantidadeDeLados);

            Escrever($"O Número rolado foi {NumeroRolado}");

            NumeroPar(quantidadeDeLados);

            RolarDeNovo();
        }

        static int RolarDado(int quantidadeDeLados)
        {
            Random rd = new Random();
            int NumeroRolado = rd.Next(1, quantidadeDeLados + 1); //Numerorolado e Numerorolado não são os mesmos, return??
            return NumeroRolado;

        }

        static string Escrever(string texto)
        {
            Console.WriteLine(texto);
            return texto;
        }

        static int NumeroPar(int NumeroRolado) //podia ser void??
        {
            if (NumeroRolado % 2 == 0)
            {
                Escrever("Número PAR");
            }
            else
            {
                Escrever("Número IMPAR");
            }
            return NumeroRolado;
        }

        static void RolarDeNovo()
        {
            Escrever("Rolar de Novo? S/N");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                MainRolarDdo();
            }
        }
    }
}
