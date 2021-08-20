using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public void Save()
        {
             
        }
        public void Delete()
        {

        }
    }
    class Student:Customer
    {
        public new void Save()
        {
            Customer customer = new Customer();
            
        }

    }

    internal class Course
    {
        public string Name { get; set; }
    }

   /* class Coursee
    {
        public string Name { get; set; }
        private class NestedClass
        {

        }
    }
     üst seviyeli bir class private olamaz // iç içe classlarda olabilir
     public ya da internal */


    // public erişim





}
