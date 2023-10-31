namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Student student = new();
                Console.WriteLine("Input Age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input name: ");
                Student.Name = Console.ReadLine();

                Console.WriteLine("Input surname: ");
                Student.SurName = Console.ReadLine();

                Console.WriteLine("Input group name: ");
                student.GroupNo = Console.ReadLine();

                Console.WriteLine(student.Id + "." + Student.FullName() + " " + student.Age + " " + student.GroupNo);

                Console.WriteLine("Check Fullname: ");
                Console.WriteLine(Student.CheckFullname(Console.ReadLine()));
                Console.WriteLine("Check GroupName: ");
                Console.WriteLine(Student.CheckGroupName(Console.ReadLine()));
            }

        }
    }
}