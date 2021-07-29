using System;
using System.Collections.Generic;

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
            Dado meuDado = new Dado();

            Escrever("Digite o Número de lados");
            meuDado.QuantidadeDeLados = Convert.ToInt32(Console.ReadLine());
            if (meuDado.QuantidadeDeLados > 100)
            {
                Escrever("O valor não pode ser maior q 100!!! ");
                MainRolarDdo();
            }
            //string teste = Escrever(texto); ??
            
            Escrever($"O Número digitado foi {meuDado.QuantidadeDeLados}");
            Escrever("Digite quantas vezes vc quer rolar o dado?");
            meuDado.Roladas = Convert.ToInt32(Console.ReadLine());

            // int[] valorDasRoladas; --> usando array
            //valorDasRoladas = new int[100]; --> usando array
            List<int> listavalorDasRoladas = new List<int>();
            // int soma = 0; --> usando array


            for (int i = 0; i <= meuDado.Roladas - 1; i++)
            {
                meuDado.RolarDado();
                Escrever($"O Número rolado foi {meuDado.NumeroRolado}");
                // valorDasRoladas[i] = meuDado.NumeroRolado; --> usando array
                Escrever($"Valor {meuDado.NumeroRolado} está armazenado na posiçao {i} da Var valorDasRoladas");
                //soma = soma + valorDasRoladas[i]; --> usando array
                listavalorDasRoladas.Add(meuDado.NumeroRolado);

            }

            int somalista = 0;
            foreach (int valor in listavalorDasRoladas)
            {
                somalista += valor;
            }

            //Escrever($"Asoma é {soma}"); --> usando array
            Escrever($"Asoma é {somalista}");



            int parOuimpar = meuDado.NumeroRolado; //pq não deixou colocar meuDado.NumeroRolado como parametro ??
            NumeroPar(parOuimpar);

            RolarDeNovo();
        }

        

        static string Escrever(string texto)
        {
            Console.WriteLine(texto);
            return texto;
        }

        static int NumeroPar(int parOuimpar) //podia ser void?? pq não deixou colocar meuDado.NumeroRolado como parametro??
        {
            if (parOuimpar % 2 == 0)
            {
                Escrever("Número PAR");
            }
            else
            {
                Escrever("Número IMPAR");
            }
            return parOuimpar;
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
