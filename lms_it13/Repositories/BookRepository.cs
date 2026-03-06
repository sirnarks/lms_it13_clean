using System.Collections.Generic;
<<<<<<< HEAD
=======
using lms_it13.Models;
>>>>>>> @{-1}

namespace lms_it13.Repositories
{
    public static class BookRepository
    {
        public static List<Book> Books = new List<Book>
        {
<<<<<<< HEAD
            new Book { Id = "1", Title = "C# Basics", Author = "John Doe", Quantity = 5 },
            new Book { Id = "2", Title = "OOP Concepts", Author = "Jane Smith", Quantity = 3 }
=======
            new Book { BookID = 1, Title = "C# Basics", Author = "John Doe", Quantity = 5 },
            new Book { BookID = 2, Title = "OOP Concepts", Author = "Jane Smith", Quantity = 3 }
>>>>>>> @{-1}
        };
    }
}