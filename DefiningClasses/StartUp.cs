using System.Diagnostics.CodeAnalysis;

namespace DefiningClasses
{
    internal class StartUp
    {
        public static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
           
            //Family family = new Family();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    Person person = new Person(info[0],int.Parse(info[1]));
            //    family.AddMember(person);

                
            //}
            ////Person oldest = family.GetOldestMember();
            ////Console.WriteLine($"{oldest.Name} {oldest.Age}");
          
            //List<Person> personsOver30 = new List<Person>();
            //personsOver30 = family.members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            //foreach (Person person in personsOver30)
            //{
            //    Console.WriteLine($"{person.Name} - {person.Age}");
            //}
            
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carName = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1Km = double.Parse(carInfo[2]);
                Car car = new Car(carName,fuelAmount,fuelConsumptionFor1Km);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] info = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carName = info[1];
                double kmToDrive = double.Parse(info[2]);
                Car car = cars.Find(c => c.Model == carName);
                car.Drive(car,kmToDrive);
               

                command = Console.ReadLine();
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

