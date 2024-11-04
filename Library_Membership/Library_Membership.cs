using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Repositories;

namespace Library_Membership
{
    internal class Library_Membership
    {
        static void Main(string[] args)
        {
            // Book Repository Usage

            var bookRepository = new BookRepository();

            // Fetching book by ID

            var result = bookRepository.GetById(10);

            if (result.Success)
            {
                Console.WriteLine(result.Data.BookName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            // Fetching book by Name

            var res = bookRepository.GetByName("Book 1");

            if (res.Success)
            {
                Console.WriteLine(res.Data.BookName);
            }
            else
            {
                Console.WriteLine(res.Message);
            }

            // Member Repository Usage

            var memberRepository = new MemberRepository();

            // Fetching member by Name

            var memberResult = memberRepository.GetByName("Gatha");

            if (memberResult.Success)
            {
                Console.WriteLine(memberResult.Data.BookId);
                Console.WriteLine(memberResult.Data.Email);
            }
            else
            {
                Console.WriteLine(memberResult.Message);
            }

            // Fetching member by Email

            var memberByEmail = memberRepository.GetByEmail("gg@gamil.com");

            if (memberByEmail.Success)
            {
                Console.WriteLine(memberByEmail.Data.Name);
            }
            else
            {
                Console.WriteLine(memberByEmail.Message);
            }
        }
    }
}
