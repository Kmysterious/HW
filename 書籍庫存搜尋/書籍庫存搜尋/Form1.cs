using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 書籍庫存搜尋
{
    public partial class Form1 : Form
    {
        List<Book> Books;
        public Form1()
        {
            InitializeComponent();
            Books = new List<Book>();

            Book[] books = new Book[10];
            books[0] = new Book("S0001", "睡虎傳", "梅鳴恣", "堅鍛", BooksType.小說, 200, 5);
            books[1] = new Book("S0002", "老娘", "布織蹈", "覺傳", BooksType.文學, 160, 0);
            books[2] = new Book("S0003", "危機分1", "巫冥誓", "凍梨", BooksType.其他, 120, 1);
            books[3] = new Book("S0004", "Date Big", "臥旺樂", "傾紋", BooksType.科技, 450, 15);
            books[4] = new Book("D0011", "創業", "沃示邪", "覺傳", BooksType.商管, 600, 3);
            books[5] = new Book("D0021", "蟑螂進化史", "壯稻投", "凍梨", BooksType.歷史, 230, 6);
            books[6] = new Book("R0101", "經濟", "沃示邪", "堅鍛", BooksType.商管, 500, 8);
            books[7] = new Book("R0021", "危機分2", "巫冥誓", "覺傳", BooksType.其他, 100, 2);
            books[8] = new Book("R0002", "三狗演藝", "梅鳴恣", "凍梨", BooksType.小說, 250, 0);
            books[9] = new Book("G0200", "暈到死10", "梅鳴恣", "傾紋", BooksType.科技, 1200, 7);

            for (int i = 0; i < books.Length; i++)
            {
                Books.Add(books[i]);
            }

            panel1.Location = new Point(151, 32);
            panel2.Location = new Point(151, 32);
            panel3.Location = new Point(151, 32);

            panel1.Visible = false;
            panel2.Visible = false;

            label1.Text = "";
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                ButtonReSet();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                ButtonReSet();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                ButtonReSet();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //456
            if (radioButton4.Checked == true)
            {
                BookPricePo(100,199);
            }
            if (radioButton5.Checked == true)
            {
                BookPricePo(200, 399);
            }
            if (radioButton6.Checked == true)
            {
                BookPricePo(400, 99999);
            }


            if (checkBox1.Checked == true)
            {
                BookPublishPo(checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                BookPublishPo(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                BookPublishPo(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                BookPublishPo(checkBox4.Text);
            }


            if (checkBox5.Checked == true)
            {
                BookTypePo(BooksType.文學);
            }
            if (checkBox6.Checked == true)
            {
                BookTypePo(BooksType.商管);
            }
            if (checkBox7.Checked == true)
            {
                BookTypePo(BooksType.小說);
            }
            if (checkBox8.Checked == true)
            {
                BookTypePo(BooksType.科技);
            }
            if (checkBox9.Checked == true)
            {
                BookTypePo(BooksType.其他);
            }
            if (checkBox10.Checked == true)
            {
                BookTypePo(BooksType.歷史);
            }

        }

        private void BookPricePo(int MinPrice,int MaxPrice)
        {
            
            foreach (Book book in Books)
            {
                if (book.Price >= MinPrice && book.Price <= MaxPrice)
                {
                    label1.Text += "書名：" + book.BookName + "  ISDN：" + book.ISDN + "  作者：" + book.Author + "  類型：" + book.BookType + "  出版社：" + book.Publish + "  價格：" + book.Price + "  庫存：" + book.StockAmount + Environment.NewLine;
                }
            }
        }

        private void BookPublishPo(string Publish)
        {
            foreach (Book book in Books)
            {
                if (book.Publish.Equals(Publish))
                {
                    label1.Text += "書名：" + book.BookName + "  ISDN：" + book.ISDN + "  作者：" + book.Author + "  類型：" + book.BookType + "  出版社：" + book.Publish + "  價格：" + book.Price + "  庫存：" + book.StockAmount + Environment.NewLine;
                }
            }
        }

        private void BookTypePo(BooksType type)
        {
            foreach (Book book in Books)
            {
                if (book.BookType == type)
                {
                    label1.Text += "書名：" + book.BookName + "  ISDN：" + book.ISDN + "  作者：" + book.Author + "  類型：" + book.BookType + "  出版社：" + book.Publish + "  價格：" + book.Price + "  庫存：" + book.StockAmount + Environment.NewLine;
                }
            }
        }

        private void ButtonReSet()
        {
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            label1.Text = "";
        }
    }
}
