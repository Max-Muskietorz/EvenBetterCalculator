using System;
using System.Reflection.Metadata.Ecma335;

namespace EvenBetterCalculator{

    class EvenBetterCalculator{

        static void Main(string[] args){
            Console.WriteLine("Hello and welcome to the calculator");
            bool isRunning = true;

            while (isRunning){
                int num1 = 0;
                int num2 = 0;
                string operating = "";
                int result = 0;
                
                Console.WriteLine($"The result of this equation is: {num1} {operating} {num2} is: {result}");
            }

        }

        static int getNumber(string prompt){
            int number;
            Console.WriteLine(prompt)

            while(!int.TryParse(Console.ReadLine(), out number)){
                Console.WriteLine("Please return a valid number");
            }
                return number;
        }

        static string getOperator(){
            Console.WriteLine("please choose your desired operator");
            Console.WriteLine("For addtion enter +\nfor subtraction enter -,\nfor multiplication enter *,\nfor division please enter /");
            string operating;
            while(true){
                operating = Console.ReadLine();
                if (operating == "+" || operating == "-" || operating == "*" || operating == "/"){
                    break;
                }
                Console.WriteLine("Please enter a valid operation");   
            }
            return operating;
        }



    }
}