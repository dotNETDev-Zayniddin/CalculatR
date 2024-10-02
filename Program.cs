using System;
namespace Calculatr{
    public class Program{
        static void Main(string[] args){
            System.Console.Write("Enter a first number: ");
            string tempfirstNumber = Console.ReadLine();
            int firstNumber = Convert.ToInt32(tempfirstNumber);
            System.Console.Write("Enter the second one: ");
            string tempsecondNumber = Console.ReadLine();
            int secondNumber = Convert.ToInt32(tempsecondNumber);
            System.Console.WriteLine($"First number is greater than 2nd number: {firstNumber > secondNumber}");
            System.Console.WriteLine($"1st number is greater than or equlat to 2nd number: {firstNumber >= secondNumber}");
            System.Console.WriteLine($"1st number less than 2nd number: {firstNumber < secondNumber}");
            System.Console.WriteLine($"1st number less or equal to 2nd number: {firstNumber <= secondNumber}");
            System.Console.WriteLine($"Numbers are equal: {firstNumber == secondNumber}");
            System.Console.WriteLine($"Numbers are not equal: {firstNumber != secondNumber}");

        }
    }
}