using CodeFirstRelation.Model.Context;

namespace CodeFirstRelation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a database context
            using (var context = new CodeFirstDbContext())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Print success message
                Console.WriteLine("Database has been successfully created!");
            }
        }
    }
}
