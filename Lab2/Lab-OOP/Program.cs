using System;

namespace ArithmeticProgressionApp
{
    class ArithmeticProgression
    {
        private int _firstTerm; 
        private int _difference; 
        private int _numTerms; 

        public void InputData()
        {
            Console.Write("(a): ");
            _firstTerm = int.Parse(Console.ReadLine());

            Console.Write("(d): ");
            _difference = int.Parse(Console.ReadLine());

            Console.Write("(n): ");
            _numTerms = int.Parse(Console.ReadLine());

            if (_numTerms <= 0)
            {
                throw new ArgumentException("Incorrect number.");
            }
        }

        public int CalculateSum()
        {
            return (_numTerms * (2 * _firstTerm + (_numTerms - 1) * _difference)) / 2;
        }
    }

    class Program
    {
        static void Main()
        {
                ArithmeticProgression progression = new ArithmeticProgression();

                progression.InputData();

                int sum = progression.CalculateSum();
                Console.WriteLine($"sum of the arithmetic progression is: {sum}");
        }
    }
}