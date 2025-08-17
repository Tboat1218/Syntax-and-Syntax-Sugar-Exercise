namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = answer < 9
                ? $"{answer} is less than nine"
                : $"{answer} is reater or equal to nine";
            Console.WriteLine(response);



        }
    }
}
