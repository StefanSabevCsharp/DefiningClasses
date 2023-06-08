namespace DefiningClasses
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];
                double tirePressure1 = double.Parse(info[5]);
                int tire1Agen = int.Parse(info[6]);
                double tirePressure2 = double.Parse(info[7]);
                int tire2Agen = int.Parse(info[8]);
                double tirePressure3 = double.Parse(info[9]);
                int tire3Agen = int.Parse(info[10]);
                double tirePressure4 = double.Parse(info[11]);
                int tire4Agen = int.Parse(info[12]);
                
                Car car = new Car(model, new Engine(engineSpeed, enginePower), new Tire[4]
                {
                    new Tire(tire1Agen,tirePressure1),
                    new Tire(tire2Agen,tirePressure2),
                    new Tire(tire3Agen,tirePressure3),
                    new Tire(tire4Agen,tirePressure4)
                }, new Cargo(cargoType, cargoWeight));
                cars.Add(car);

            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {

                cars = cars.Where(c => c.Cargo.Type == "fragile").Where(c => c.Tires[0].Pressure < 1 || c.Tires[1].Pressure < 1 || c.Tires[2].Pressure < 1 || c.Tires[3].Pressure < 1).ToList();
                foreach (Car car in cars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                cars = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();
                foreach (Car car in cars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}