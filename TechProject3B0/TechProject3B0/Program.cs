﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject3B0
{
    class Program
    {
        static void Main(string[] args)
        {
          
                
                   Console.WriteLine("Let's iterate through the elements in the array with a For Loop");
                   
                    int[] countdown = new int[26];
                 
                    int pop_array = 0;
                    // Iterate through the array using a For Loop
                    for (int i = 0; i < 26; i++)
                    {
                        countdown[i] = pop_array;
                        Console.Write("Element value = " + i);
                Console.WriteLine();
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
               
            
         
         


        }
    }
}
