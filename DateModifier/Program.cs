namespace DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
           double difference =  CalculateDifferenceInDays(firstDate, secondDate);
            Console.WriteLine(Math.Abs((int)difference));

        }
        public static double CalculateDifferenceInDays(string firstDate, string secondDate)
        {
            DateTime day = DateTime.Parse(firstDate);
            DateTime day2 = DateTime.Parse(secondDate);
            double difference = (day - day2).TotalDays;
            return difference;
        }
    }
}