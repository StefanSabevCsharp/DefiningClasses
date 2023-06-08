
namespace DefiningClasses
{
    public class Family
    {
        List<Person> persons;
        public List<Person> members { get; set; }
        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            members.Add(member);

        }
       public Person GetOldestMember()

        {
            List<Person> oldest = members.OrderByDescending(m => m.Age).Take(1).ToList();

            return oldest[0];
        }
        //public List<Person> GetPersonsOver30Years(List<Person> persons)
        //{
        //    List<Person> result = new List<Person>();
        //    result = persons.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        //    return result;
        //}
    }
}
