﻿

using System;
using Colecoes.Helper;

namespace Colecoes
{

    class Program

        {
                 static void Main(string[] args)
            {
                //Ordenando via  Bubble sort 
                 OperacoesArray  op = new OperacoesArray();
                 int[] array = new int[5] {6, 3, 8, 1, 9};

                System.Console.WriteLine("Array Original: ");
                op.imprimirArray(array);
                op.Ordenar(ref array);
                // op.OrdenarBubbleSort(ref array);

                System.Console.WriteLine("Array ordenado: ");
                op.imprimirArray(array);


            }

    
        }

    }
    
    
    //array multidimensional
    // int[,] matriz = new int[4,2]

    // {
    //     {8,8},
    //     {10,20},
    //     {50,100},
    //     {90,200}
    // };
    // for (int i = 0; i < matriz.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matriz.GetLength(1); j++)
    //     {
    //         System.Console.WriteLine(matriz[i,j]);
            
    //     }
        
    // }

    //     Percorrendo um array
    //     int[]arrayInteiros = new int[3];
    //     arrayInteiros[0] = 10;
    //     arrayInteiros[1] = 20;
    //     arrayInteiros[2] = 30;
    //     System.Console.WriteLine("Percorrendo o array pelo for");
    //     for (int i = 0; i <arrayInteiros.Length ; i++)
    //     {
    //         System.Console.WriteLine(arrayInteiros[i]);  
    //     }
    //     System.Console.WriteLine("Percorrendo o array pelo Foreach");
    // foreach (int item in arrayInteiros)
    // {
    //     System.Console.WriteLine(item);
        
    // }
        