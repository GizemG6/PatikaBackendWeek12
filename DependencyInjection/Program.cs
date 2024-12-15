namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Teacher instance
            IOgretmen teacher = new Teacher("Yiğit", "Hacıefendioğlu");

            // Inject Teacher instance into ClassRoom
            ClassRoom classRoom = new ClassRoom(teacher);

            // Display Teacher Info
            Console.WriteLine(classRoom.GetTeacherInfo());
        }
    }
}
