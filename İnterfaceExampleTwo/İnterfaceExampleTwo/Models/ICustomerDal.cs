using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceExampleTwo.Models
{
     interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }

    class OracCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Add");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
