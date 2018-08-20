using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********

            for ( int contadorLinha=0; contadorLinha >= 10; contadorLinha++) 
                {
                    for( int contadorColuna =0; contadorColuna <= contadorLinha; contadorColuna++)
                    {
                    Console.Write("*");
                    }
                Console.WriteLine();
               
                }
            Console.ReadLine();
        }
    }
}
    }
}
