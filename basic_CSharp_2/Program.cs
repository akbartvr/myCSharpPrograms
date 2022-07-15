using System;

namespace basic_CSharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of personnels:");
            int number = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"please enter person {i+1} name:");
                string name = Console.ReadLine();
                Console.WriteLine($"please enter person {i+1} family:");
                string family = Console.ReadLine();
                Console.WriteLine($"please enter person {i+1} website:");
                string website = Console.ReadLine();

                Person person = new Person(name, family, website);
                people[i] = person;
            }
            foreach (Person person in people)
            {
                Console.WriteLine($"name is: {person.name} family is: {person.family} website is: {person.website}");
            }
        }
    }
}
