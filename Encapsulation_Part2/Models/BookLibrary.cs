using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_Part2.Models
{
    internal class BookLibrary
    {
        
        private  Book[] _books = new Book[0];
        public string Name;
        public Book[] Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }
        }
      
        public BookLibrary() {
            

        }
        public void  Add(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            Books[Books.Length - 1] = book;
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"elave olunanalar: {Books[i].Name}, {Books[i].Author}");


            }

        }
        public void RemoveBook(string name)
        {
            
            int j = 0;
            Book[] newArr = new Book[Books.Length - 1];

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != name)
                {
                    if (j < newArr.Length)  
                    {
                        newArr[j] = Books[i];
                        j++;
                    }
                }
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].IsAvailable)
                {
                    Console.WriteLine(" qalan kitablar: " + Books[i].Name);
                }
            }
        }
        
        public void BorrowBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if(name == Books[i].Name)
                {
                    if (Books[i].IsAvailable)
                    {
                        Books[i].IsAvailable = false;
                        Console.WriteLine($"oxucu {Books[i].Name} kitabını götürdü");
                    }
                 

                }
                 
            }
        }


        public void ReturnBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Name)
                {
                    if (!Books[i].IsAvailable)
                    {
                        Books[i].IsAvailable = true;
                        Console.WriteLine($"oxucu {Books[i].Name} kitabını qaytardı kitab elcatandır");
                    }


                }

            }
        }

        public void SearchByAuthor(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Author)
                {
                    Console.WriteLine($"müellif {Books[i].Author} in bütün eserleri:");
                    Console.WriteLine($"{Books[i].Name}");


                }
              
                
            }
        }

    }
}
