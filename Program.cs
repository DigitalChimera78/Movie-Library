using System;

namespace Movie_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\nlog.config";
            var logger = NLog.Web.NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();

            Console.WriteLine("Enter 1 to add a movie to the list.");
            Console.WriteLine("Enter 2 to list all movies.");
            Console.WriteLine("Enter anything else to quit.");

            string resp = Console.ReadLine();

            if (resp == "1")
            {
                // TODO: add movies
            }
            else if (resp == "2")
            {
                // TODO: list movies
            }
        }
    }
}
