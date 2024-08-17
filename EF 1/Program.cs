using EF_1.Contexts;
using EF_1.Entites;

namespace EF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ITIcontext())
            {
                //Cteate
                //var student = new Student
                //{

                //    Name = "John",
                //    Age = 20,
                //};
                //context.Students.Add(student);


                //Retrive
                //var x = context.Students
                //      .Select(x => x);
                //foreach (var item in x)
                //{
                //    Console.WriteLine(item);
                //}

                //Update





                //context.SaveChanges();
            }

        }
    }
}
