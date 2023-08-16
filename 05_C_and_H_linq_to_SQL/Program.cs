using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linq_to_SQL
{
    internal class Program
    {
        static void ShowBooksPageMoreThanValue(LibraryDbContext db, int value)
        {
            var BooksPageMore100 = db.Books.Where(x => x.CountPages > value).OrderBy(x => x.CountPages);
        }
        static void BooksNameStartedOnLetter(LibraryDbContext db, char letter) 
        {
            var BookNameStartedOnLetter = db.Books.Where(x => x.Name.ToLower()[0] == letter);

        }
        static void BookByAuthor(LibraryDbContext db, string Name, string Surname) 
        {
            var BooKSameAuthor = db.Books.Where(x => x.Author.Name == Name && x.Author.Surname == Surname);

        }
        static void BooksCountryAuthor(LibraryDbContext db, string CountryName) 
        {
            var BooksUkrainianAuthor = db.Books.Where(x => x.Author.Country.Name == CountryName).OrderBy(x => x.Name);
        
        }
        static void BooksNameLength(LibraryDbContext db, int countSymbols) 
        {
            var BooksNameLength = db.Books.Where(x => x.Name.Length < countSymbols);

        }
        static void BookMaxPagesAllAuthorCountriesExpect(LibraryDbContext db, string CountryName) 
        {
            var BooksNotAmericanAuthor = db.Books.Where(x => x.Author.Country.Name == CountryName);
            var BookMaxCountPages = BooksNotAmericanAuthor.Max(x => x.CountPages);
        }
        static void AuthorMinBooks(LibraryDbContext db) 
        {
            var AuthorMinBooks = db.Authors.Min(x => x.Books.Count);

        }
        static void AuthorsAllCountriesExpect(LibraryDbContext db) 
        {
            var NotAmericanAuthors = db.Authors.Where(x => x.Country.Name != "USA").OrderBy(x => x.Name);

        }
        static void MostPopularCountry(LibraryDbContext db) 
        {
            var MostPopularCountry = db.Countries.Max(x => x.Authors);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            LibraryDbContext db = new LibraryDbContext();

            //1.Метод повертає всі книги, кількість сторінок в яких більше за певне значення
            //2.Метод повертає всі книги, ім’я яких починається на літеру певну літеру,
            //регістр не враховується
            //3.Метод повертає всі книги автора по імені та прізвищу
            //4.Метод повертає всі книги авторів певної країни розташованих в алфавітному
            //порядку
            //5.Метод повертає всі книги, ім’я в яких складається менше ніж з N символів
            //6.Метод повертає книгу з максимальною кількістю сторінок авторів певної
            //країни
            //7.Метод повертає автора, який має найменше книг в базі даних
            //8.Метод повертає країну, авторів якої є найбільше в базі

        }
    }
}
