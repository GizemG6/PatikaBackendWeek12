using CodeFirstBasic.Model.Context;

namespace CodeFirstBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CodeFirstDbContext())
            {
                // Create database
                context.Database.EnsureCreated();
                Console.WriteLine("Veritabanı başarıyla oluşturuldu.");
            }
        }
    }
}
