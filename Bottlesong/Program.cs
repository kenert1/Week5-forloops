using System;

namespace Bottlesong
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 99; i > 0; i--)
            {
                if(i != 1) 
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.\n take one down and pass it around, {i - 1} bottles of beer on the wall ");

                }
                else
                {
                    Console.WriteLine($"{i} bottle of beer on the wall, {i} bottle of beer.\n take one down and pass it around, no more beer bottles on the wall");


                }
             }
  
        } 

