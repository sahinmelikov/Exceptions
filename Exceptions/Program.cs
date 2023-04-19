using Exceptions.Exceptions;
using System.Security.Cryptography.X509Certificates;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
               Human human= new Human();
                Console.WriteLine("Enter your name");
                human.Name = Console.ReadLine();
                Console.WriteLine("Enter your Surname");
                human.Surname = Console.ReadLine();
                Console.WriteLine("Enter your Age");
                human.Age = Convert.ToInt32(Console.ReadLine());

                if (human.Age<=0)
                {
                    throw new AgeException("enter your age correctly");
                }

			}
			catch (AgeException ex) 
			{

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}