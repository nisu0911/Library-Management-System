using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entity;
using DAL;

namespace BLL
{
    public class BLLBook
    {
        LibraryMSEntities _db = new LibraryMSEntities();
        public List<BookDetails> getBooks()
        {
            List<BookDetails> lst = new List<BookDetails>();
            List<getBooks_Result> lstbk = _db.getBooks().ToList();
            foreach (getBooks_Result item in lstbk)
            {
                lst.Add(new BookDetails() { BookID = item.BookID, BookName = item.BookName, ISBN = item.ISBN, Author = item.Author, IsReference = item.IsReference, AddedDate = item.AddedDate});
            }
            return lst;
        }
        public int addBook(BookDetails bd, StockDetails sd)
        {
            var book = _db.addBook(bd.BookName, bd.Author, bd.ISBN, bd.Photo, bd.IsReference, bd.AddedDate);
            /*var bookList = _db.getBooks().Last();
            var stock = _db.getStock(bookList.BookID);
            if (stock != null)
            {

            }
            else
            {
                _db.addStock(bookList.BookID, sd.Quantity);
            }*/
            if (book != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public BookDetails getBookByID(int bookID)
        {
            BookDetails lst = new BookDetails();
            var lstbk = _db.getBookByID(bookID).ToList();
            foreach (getBookByID_Result item in lstbk)
            {
                lst.BookID = item.BookID;
                lst.Author = item.Author;
                lst.ISBN = item.ISBN;
                lst.Photo = item.Photo;
                lst.IsReference = item.IsReference;
                lst.AddedDate =item.AddedDate;
            }
            return lst;
        }
        public int updateBook(BookDetails bd)
        {
            var book = _db.updateBook(bd.BookID, bd.Author, bd.BookName, bd.ISBN, bd.Photo.ToString(), bd.IsReference, bd.AddedDate);
            if (book != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int deleteBook(BookDetails bookID)
        {
            var book = _db.deleteBook(Convert.ToInt32 (bookID));
            if (book != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
