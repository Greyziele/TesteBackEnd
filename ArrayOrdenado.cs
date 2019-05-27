using System;

namespace TesteBackEnd
{
    class arrayOrdenado
    {
        static void Main(string[] args)
        {

            //criando um arrey de 10 posições.
            int contador, contador2 = 0, contador3 = 0;
            int[] vetor = new int[10];

            Console.Write("Montando um array ordenado");

            Console.Write("\n\n");

            //recebendo valores para montar o array.
            for (contador = 0; contador < 10; contador++)
            {
                Console.Write("Informe o " + (contador + 1) + "º numero:");
                vetor[contador] = int.Parse(Console.ReadLine());
            }

            //chamada do método.

            Ordena(vetor);

            //exibindo ordenação.
            Console.Write("\n Sequencia ordenada: ");
            for (contador = 9; contador >= 0; contador--)
            {
                Console.Write("\n" + vetor[contador2]);
                contador2++;
            }

            SegundoMaiorNumero(vetor);

            Console.Write("\n\n");
            
                Console.Write("O segundo maior numero do array é: " + vetor[contador3]);
            
        }


        //ordenando os valores utilizando a variavel aux para realizar a troca.
        public static void Ordena(int[] vetor)
        {
            int cont1, cont2, aux;
            for (cont1 = 0; cont1 < 10; cont1++)
            {
                for (cont2 = 0; cont2 < 9; cont2++)
                {
                    if (vetor[cont2] > vetor[cont2 + 1])
                    {
                        aux = vetor[cont2];
                        vetor[cont2] = vetor[cont2 + 1];
                        vetor[cont2 + 1] = aux;

                    }
                }
            }
        }

        public static void SegundoMaiorNumero(int[] vetor)
        {

            int menorValor = vetor[0];

            for (int cont3 = 0; cont3 < 10; cont3++)
            {
                if (vetor[cont3] < menorValor)
                {
                    menorValor = vetor[cont3];
                }
            }

            int maiorValor = 0;

            for (int cont3 = 0; cont3 < 10; cont3++)
            {
                if (vetor[cont3] > maiorValor)
                {
                    maiorValor = vetor[cont3];
                }
            }

            int segundoMaiorValor = 0;

            for (int cont3 = 0; cont3 < 10; cont3++)
            {
                if ((vetor[cont3] > menorValor) & (vetor[cont3] != maiorValor))
                {
                    segundoMaiorValor = vetor[cont3];

                }

            }

        }
    }
}
