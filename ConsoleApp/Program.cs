// See https://aka.ms/new-console-template for more information

using ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new MyDbContext())
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Add a new person
            var person = new Person { Name = "John Doe", Gender = 'M' };
            context.People.Add(person);
            context.SaveChanges();

          
            // Retrieve and display all people
            var people = context.People.ToList();
            foreach (var p in people)
            {
                Console.WriteLine($"Person ID: {p.PersonId}, Name: {p.Name}, Gender: {p.Gender}");
            }
        }
    }
}
