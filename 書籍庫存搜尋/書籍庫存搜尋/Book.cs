using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 書籍庫存搜尋
{
    public enum BooksType
    {
        科技,
        小說,
        商管,
        歷史,
        文學,
        其他
    }
    
    class Book
    {
       public string ISDN;
       public string BookName;
       public string Author;
       public string Publish;//出版社
       public BooksType BookType;
       public int Price;
       public int StockAmount;//庫存量

        public Book(string ISDN, string BookName, string Author, string Publish,BooksType BookType, int Price,int StockAmount)
        {
            this.ISDN = ISDN;
            this.BookName = BookName;
            this.Author = Author;
            this.Publish = Publish;
            this.BookType = BookType;
            this.Price = Price;
            this.StockAmount = StockAmount;
        }
    }
}
