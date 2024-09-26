namespace How_to_use_Github_with_Visual_Studio_2022
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int firstNumber = int.Parse(input[0]);
            int secondNumber = int.Parse(input[1]);


            Console.WriteLine($"Sum = {Math.Sum(firstNumber, secondNumber)}");

            Console.WriteLine($"Mul = {Math.Mul(firstNumber, secondNumber)}");



        }
    }
}
