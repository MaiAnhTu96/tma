using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface ibook
    {
        string this[int index]
        {
            get; set;
        }
        string Title
        {
            get; set;
        }
        string Author
        {
            get; set;
        }
        string Publisher
        {
            get; set;
        }
        string ISBN
        {
            get; set;
        }
        int Year
        {
            get; set;
        }
        void show();
    } //INTERFACE (PROPERTY,METHOD)

    class book : ibook //LOP BOOK KE THUA IBOOK
    {
        #region        //REGION DINH NGHIA DU LIEU KHAC CHO BOOK ~ IBOOK

        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        private ArrayList chapter = new ArrayList();

        #endregion

        #region        //REGION DINH NGHIA LAI DU LIEU PROPERTY CUA INTERFACE (IBOOK)
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public string Title
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public string Publisher
        {
            get; set;
        }
        public string ISBN
        {
            get; set;
        }
        public int Year
        {
            get; set;
        }

        public void show()  //SHOW INFOMATION ABOUT BOOK
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Title    :" + title);
            Console.WriteLine("Author   :" + author);
            Console.WriteLine("Publisher:" + publisher);
            Console.WriteLine("Year     :" + year);
            Console.WriteLine("ISBN     :" + isbn);
            Console.WriteLine("Chapter:  : ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\tCHUONG {0} {1}", i + 1, chapter[i]);
            Console.WriteLine("---------------------------");
        }
        public void input() //XUAT DANH SACH BOOK
        {
            Console.Write("Title    : ");
            title = Console.ReadLine();
            Console.Write("Author   : ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN     : ");
            isbn = Console.ReadLine();
            Console.Write("Year     : ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Da Nhap Sach Thanh Cong\nNhan 2 lan de ket thuc");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }
        class booklist      //CLASS THAO TAC DS SACH
        {
            private ArrayList list = new ArrayList(); //MANG ARRAY
            public void addbook()
            {
                book b = new book();
                b.input();
                list.Add(b);
            } //Them Book
            public void inputlist()
            {
                int n;
                Console.Write("So luong of books: ");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    addbook();
                    n--;
                }
            } //Them 1 luong n sach
            public void showlist()
            {
                foreach (book b in list)
                    b.show();
            } //Xuat DS n sach
            
        } //CLASS BOOKLIST QUAN LY DANH SACH DOI TUONG BOOK
        class program
        {
            static void Main(string[] args)     //HAM CHINH
            {
                booklist b1 = new booklist();
                b1.inputlist();

                b1.showlist();

                Console.ReadLine();
            }
        }    
    }
}
#endregion
