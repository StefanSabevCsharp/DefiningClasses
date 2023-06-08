
namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);
                string engineDisplacement = "n/a";
                string engineEfficiency = "n/a";
                if (engineInfo.Length == 3)
                {
                    engineEfficiency = engineInfo[2];
                    
                }
                else if (engineInfo.Length == 4)
                {
                    engineDisplacement = engineInfo[2];
                    engineEfficiency = engineInfo[3];
                }
                Engine engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                engines.Add(engine);

            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineName = carInfo[1];
                string weight = "n/a";
                string color = "n/a";
                if (carInfo.Length == 3)
                {
                    weight = carInfo[2];

                }
                else if (carInfo.Length == 4)
                {
                    weight = carInfo[2];
                    color = carInfo[3];
                }
                Engine current = engines.First(name => name.Model == engineName);
                Car car = new Car (model,current, weight, color);
                cars.Add(car);
               
            }
           
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
