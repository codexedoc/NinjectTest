using Ninject;
using System;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var kernel = new StandardKernel();
            kernel.Bind<IPersonFormatter>().To<PersonFormatter>();
            var personFormatter = kernel.Get<IPersonFormatter>();

            Person p = new Person(29, "Khalid", "Liari", personFormatter);
            Console.WriteLine(p.PrintPersonData());
            Console.ReadLine();

        }
    }
}
