﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classes
{
    public class Book
    {
        public int Price { get; set; }
        public string Title { get; set; }

        public string ISBN { get; set; }

        public Book(int price, string title, string iSBN)
        {
            Price = price;
            Title = title;
            ISBN = iSBN;
        }



        //konstruktor


    }
}
