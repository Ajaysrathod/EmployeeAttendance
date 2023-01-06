namespace EmployeeAttendance
{
    public class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Emoplyee is Present");
            }
            else
            {
                Console.WriteLine("Emoplyee is Absent");
            }
            Console.WriteLine("Hello, World!");

        }
    }
}