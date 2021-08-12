using System;

namespace Interfaces
{
     class Customer : IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get ; set ; }
        public string Address { get; internal set; }

       
    }
}
