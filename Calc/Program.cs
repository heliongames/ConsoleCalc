using System;

namespace Calc
{
    class Program
    {
        static float firstNum;
        static float secondNum;
        static string operor;
        
        static void Main(string[] args)
        {
            DoCalc();
        }

        private static void DoCalc()
        {
            ResetCalc();
            Console.WriteLine("Please enter first number:");
            ConsoleReaderForNumbers();
            Console.WriteLine("Please enter math operator:");
            ConsoleReaderForOperator();
            Console.WriteLine("Please enter second number:");
            ConsoleReaderForNumbers();
            Console.WriteLine("Result: " + DoResults());
            Console.WriteLine("\n\n");
            DoCalc();
        }
        private static void ResetCalc()
        {
            operor = "";
            firstNum = 0f;
            secondNum = 0f;
        }

        private static float DoResults()
        {
            float _results = 0f;
            if(operor == "+")
            {
                _results = firstNum + secondNum;
            }
            else if(operor == "/")
            {
                _results = firstNum / secondNum;
            }
            else if(operor == "*")
            {
                _results = firstNum * secondNum;
            }
            else if(operor == "-")
            {
                _results = firstNum - secondNum;
            }
            return _results;
        }

        private static void ConsoleReaderForNumbers()
        {
            string _consoleInput = Console.ReadLine();
            float _number;
            if (float.TryParse(_consoleInput, out _number))
            {
                if(firstNum == 0f)
                {
                    firstNum = _number;
                } 
                else if (secondNum == 0f)
                {
                    if(operor == "/" && _number == 0f)
                    {
                        Console.WriteLine("Division by zero is prohibited. Please enter other number");
                        ConsoleReaderForNumbers();
                    } 
                    else 
                    {
                        secondNum = _number;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter only number");
                ConsoleReaderForNumbers();
            }
        }
        
        private static void ConsoleReaderForOperator()
        {
            string _consoleInput = Console.ReadLine();
            if (_consoleInput == "+" || _consoleInput == "/" || _consoleInput == "*" || _consoleInput == "-")
            {
                operor = _consoleInput;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter math operator");
                ConsoleReaderForOperator();
            }
        }
    }
}
