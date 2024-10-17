using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Part2.Models
{
    internal class Book
    {
        private string _name;
        private string _author;
        public bool IsAvailable=true;
        
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            

        }
        public   void GetInfo()
        {

            Console.WriteLine($"Name: {Name}  Author: {Author} Isavailable:{IsAvailable}");
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("düzgün ad daxil edin!");
                }
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value.Length >= 2)
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("düzgün müellif daxil edin!");
                }
            }
        }
       
       


    }
}
