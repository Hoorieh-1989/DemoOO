using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classes
{
    internal class Order
    {
        public DateTime OrderDate { get; set; }
        public Customer Customer{ get; set; }

        public List<Book> OrderedBooks  { get; set; }

        public Order(DateTime orderDate, Customer customer, List<Book> orderedBooks)
        {
            OrderDate = orderDate;
            Customer = customer;
            OrderedBooks = orderedBooks;
        }
    }
}
