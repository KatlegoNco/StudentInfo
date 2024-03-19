class Program
{
    class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
    }

    static void Main(string[] args)
    {
        // Creating an array of Person objects
        Person[] people = new Person[3];

        // Populating the array with sample data
        people[0] = new Person { Name = "John Cena", DateOfBirth = new DateTime(1977, 4, 23), Gender = 'M' };
        people[1] = new Person { Name = "Bray Wyatt", DateOfBirth = new DateTime(1987, 5, 23), Gender = 'M' };
        people[2] = new Person { Name = "Dwayne 'The Rock' Johnson", DateOfBirth = new DateTime(1972, 5, 02), Gender = 'M' };


        // Outputting details for each person
        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine($"Person {i + 1}:");
            Console.WriteLine($"Name: {people[i].Name}");
            Console.WriteLine($"Date of Birth: {people[i].DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {people[i].Gender}");
            Console.WriteLine();
        }
    }
}
