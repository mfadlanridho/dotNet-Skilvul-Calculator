using System;
using Skilvul;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for addition!");
            Console.WriteLine("Press 2 for substraction!");
            Console.WriteLine("Press 3 for multiplication!");
            Console.WriteLine("Press 4 for division!");
    
            int input;
            if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 4) {
                float n1, n2;
                Console.WriteLine("Enter first input!");
                
                if (float.TryParse(Console.ReadLine(), out n1)) {
                    Console.WriteLine("Enter second input!");

                    if (float.TryParse(Console.ReadLine(), out n2)) { 
                        MyMath math = new MyMath(n1, n2);

                        string res = "The result is ";
                        switch (input) {
                            case 1:
                                res += math.Add();
                                break;
                            case 2:
                                res += math.Substract();
                                break;
                            case 3:
                                res += math.Multiply();
                                break;
                            case 4:
                                res += math.Divide();
                                break;
                        }
                        Console.WriteLine(res);
                    } 
                    else {
                        Console.WriteLine("Invalid input");
                    }
                } else {
                    Console.WriteLine("Invalid input");
                }
            } else {
                Console.WriteLine("Invalid input");
            }
        }
    }
}