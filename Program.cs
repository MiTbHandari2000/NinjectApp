using Ninject;
using System.Reflection;

namespace NinjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            IProduct _objIpro = _Kernal.Get<IProduct>();

            BL objbl = new BL(_objIpro);


            objbl.Insert();
            Console.ReadLine();
        }
    }
}