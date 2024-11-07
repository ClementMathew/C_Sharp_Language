using System.Collections.Generic;
using System.Linq;
using Library_Membership.Data;
using Library_Membership.Entities;

namespace Library_Membership.Repositories
{
    internal class BookRepository
    {
        // Method to retrieve all books

        public GenericResponse<List<Books>> GetAllBooks()
        {
            List<Books> books = DataStore.Books;

            return new GenericResponse<List<Books>>
            {
                Success = true,
                Data = books
            };
        }

        // Method to retrieve a book by its ID

        public GenericResponse<Books> GetById(int id)
        {
            Books book = DataStore.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available"
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = book
            };
        }

        // Method to retrieve a book by its name

        public GenericResponse<Books> GetByName(string name)
        {
            Books book = DataStore.Books.FirstOrDefault(x => x.BookName == name);

            if (book == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available"
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = book
            };
        }
    }
}
