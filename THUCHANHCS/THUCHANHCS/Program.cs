using System;
using System.Collections.Generic;
using System.Text;

namespace THUCHANHCS
{
    public class HocSinh //Truongdulieu
    {
        private int ID;
        private string Ten;
        private string Khoa;
        private float Diem;

        public HocSinh() //Constructor kothamso
        {
            ID = 1;
            Ten = "Mai Anh Tu";
            Khoa = "CNTT";
            Diem = 10;
        }

        public HocSinh(HocSinh hs) //Constructor saochep
        {
            ID = hs.ID;
            Ten = hs.Ten;
            Khoa = hs.Khoa;
            Diem = hs.Diem;
        }

        public HocSinh(int id, string ten, string khoa, float diem) //Constructor
        {
            ID = id;
            Ten = ten;
            Khoa = khoa;
            Diem = diem;            
        }

        //Property dung truy xuat du lieu cac field private
        public int HSID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string HSTEN
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public string HSKHOA
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float HSDIEM
        {
            get { return Diem; }
            set { Diem = value; }
        }

        public void Hienthi() //SHOW INFORMATION SV
        {
            Console.WriteLine("MSSV    : {0}", this.HSID);
            Console.WriteLine("HO & TEN: {0}", this.HSTEN);
            Console.WriteLine("KHOA    : {0}", this.HSKHOA);
            Console.WriteLine("DIEM    : {0}", this.HSDIEM);
        }
    }
    public class Tester
    {
        public static void Main() // Ham Main Chinh
        {
            HocSinh[] DSSV;
            int n;

            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());

            DSSV = new HocSinh[n]; //Tao mang n phan tu

            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new HocSinh(); //Tao doi tuong SV

                Console.Write("NHAP TEN SV {0}: ", i + 1);
                DSSV[i].HSTEN = Console.ReadLine();     //Doc chuoi gan NAME(string)

                Console.Write("NHAP MSSV      : ");
                DSSV[i].HSID = int.Parse(Console.ReadLine());   //chuyen doi chuoi MSSV -> so nguyen MSSV

                Console.Write("NHAP KHOA      : ");
                DSSV[i].HSKHOA = Console.ReadLine();    //Doc chuoi gan vao KHOA(string)

                Console.Write("NHAP DIEM      : ");
                DSSV[i].HSDIEM = int.Parse(Console.ReadLine()); //chuyen doi chuoi DIEM -> so nguyen DIEM
            }

            //XUAT DSSV
            Console.WriteLine("*************DSSV**************");
            foreach (HocSinh hs in DSSV) //Vong lap foreach lap qua cac muc trong mang hay tap hop
                hs.Hienthi();            //Thuc hien thong qua voi tung muc trong mang hay tap hop
            Console.ReadLine();          //Dung man hinh
        }
    }
}
