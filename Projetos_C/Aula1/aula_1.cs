using System;
using System.Collections.Generic;

namespace Projetos_C
{
    class aula1
    {
        static void Main(string[] args)
        {
            int opcao = 0;
                  

           while(opcao != 4){

            Console.WriteLine("Digite a opcao desejada\nDigite 1 para exercicio de media\nDigite 2 para o exercicio de matriz\nDigite 3 para o exercicio de lista\nDigite 4 para sair\nSua escolha: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao){
                case  1:
                    aula1.calcMedia();
                    break;
                case  2:
                    aula1.diagMatriz();
                    break;
                case  3:
                    aula1.listSoma();
                    break;
                
                case  4:
                    break;
                           
                }

            }
        }

            public static void calcMedia(){
                double[] vet = new double[4];
                int count = 0;
                double soma =0;
                double media;

                Console.WriteLine("\nDigite os 4 valores para calculo da media:");
                while (count < 4){
                    Console.WriteLine("Digite o valor"+" "+ (count+1));
                    vet[count] = Convert.ToDouble(Console.ReadLine());
                    count++;
                }
                for (int i =0;i<vet.Length;i++){

                     soma = soma + vet[i];

                }

                media = soma/vet.Length;

                Console.WriteLine("A media eh: "+" "+media);
                Console.WriteLine("Digite enter para continuar...");
                Console.ReadLine();
            }

            public static void diagMatriz(){
                Console.WriteLine("Digite a ordem da matriz quadrada");
                int tam = Convert.ToInt32(Console.ReadLine());
                Random randNum = new Random();

                int[,] mat2 = {{1,2,3},{4,5,6},{7,8,9}};

                int[,] matriz = new int[tam,tam];
                for (int i=0; i<tam;i++){
                    for (int j=0; j<tam; j++){
                        matriz[i,j] = randNum.Next();
                    }
                }

                for (int i=0; i<tam;i++){
                    Console.WriteLine($"Diagonal({i}:{i}) valor: {matriz[i,i]}");                    
            }
            
            Console.WriteLine("Digite enter para continuar...");
            Console.ReadLine();
        } 

            public static void listSoma(){
                
                Random randNum = new Random();
                Console.WriteLine("\nDigite o tamanho da lista desejada: ");
                int tam = Convert.ToInt32(Console.ReadLine());
                List<int> lista = new List<int>();
                
                int soma =0;

                for (int i =0; i<tam;i++){
                    lista.Add(randNum.Next());
                }
                Console.WriteLine("\n Os valores da lista sao: ");
                foreach(int valor in lista){
                    soma = soma + valor;
                    Console.WriteLine(valor);
                }
                Console.WriteLine($"\nA soma dos valores eh: {soma}\n");
                Console.WriteLine("Digite enter para continuar...");
                Console.ReadLine();



            }  
                    
        }
    }
    

