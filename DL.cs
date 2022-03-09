using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectApp
{
    class DL : IProduct
    {
        public string InsertProduct()
        {
            string value = "Dependency injection using Ninject";
            return value;
        }
    }
}
