using System;

namespace DesafioParImpar.CodeRefactoring{
    public class CodeRefacoring {
        public static void Execute() {

            int numberTests, i, x;

            Console.Write("Informe a quantidade de testes a serem feitas:");
            numberTests = int.Parse(Console.ReadLine());
            
            for (i = 0; i < numberTests; i++) {

                x = int.Parse(Console.ReadLine());

                if (IsEvenNull(x))
                    Console.WriteLine("NULL");

                else if (IsNumberEven(x)) {
                    Console.WriteLine(GetTypeEven(x));
                }

                else {
                    Console.WriteLine(GetTypeODD(x));
                }
            }
            Console.ReadLine();
        }

        private static bool IsEvenNull(int number){
            if (number == 0)
                return true;
            return false;
        }
        private static bool IsNumberEven(int number){
            if (number != 0 && number % 2 == 0)
                return true;
            return false;
        }
        private static bool IsEvenPositive(int number){
            return number > 0 ? true : false;
        }
        private static string GetTypeEven (int number) {
            if(IsEvenPositive(int))
                return "EVEN POSITIVE";
            return "EVEN NEGATIVE";
        }
        private static string GetTypeODD (int number) {
            if(IsEvenPositive(int))
                return "ODD POSITIVE";
            return "ODD NEGATIVE";
        }
    }
}