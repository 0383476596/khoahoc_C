using System;

namespace Khoahoc_C
{
    class Program
    {
        static void Main()
        {    //Phan1_1();
             //Phan1_2();
            Phan1_3();


        }
        static void Phan1_1()
        {
            //Buổi 2: Biến, Hằng và các toán 
            //Các in ra màn hình: Ví dụ: "Chao mung den trung tam lap trinh spec " 
            //Console.Write("Chao mung den trung tam lap trinh spec ");
            //Console.ReadLine();

            //Khai báo biến
            //<Kiểu dữ liệu> _Tenbien [= Gán giá trị];
            //string _str = "abc";
            //int _int1 = 2;
            // int _int2 = 2;
            //double _dou = 2.2;
            //TH1: In chuỗi
            // Console.Write("Chuoi vua khai bao:" + _str);
            //TH2: In số thực, số nguyên
            // Console.Write("_So nguyen vua khai bao: {0} và {1} ", _int1, _dou);
            //Console.write(_dou);
            //Console.ReadLine();
        }
        //Cấu trúc: static void TenFunction(){Vùng Code;}

        static void Phan1_2()
        {
            ////Nhập và đọc chuỗi vừa nhập vào màn hình, 
            //Console.Write("Ho va Ten cua ban la gi ? Ten Minh la: ");
            //string _HoTen = Console.ReadLine();
            //Console.Write("xin chao ban " + _HoTen);
            //Console.Write("SO ky tu trong ten cua ban la: {0}\n", _HoTen.Length);
            //Console.Write("ho ten in thuong: {0}\n", _HoTen.Length);
            //Console.Write("HO TEN IN HOA: {0}\n", _HoTen.)
        }


        static void Phan1_3()
        {
            //Toán tử 
            Console.Write("Moi nhap so nguyen can kiem tra, N = ");
            string _str_SoNguyen = Console.ReadLine(); // đọc kí tự mà mình vừa ghi ra màn hình.
            int _int_SoNguyen = Convert.ToInt32(_str_SoNguyen); //chuyển kiểu biến từ chuổi sang số nguyên.
            //Toán tử 3 ngôi :
            //a) kiểm tra chẵn lẻ
            string _KetQua_A = (_int_SoNguyen % 2 == 0) ? "So chan":"so le";
            Console.WriteLine("So N = {0} la {1} , _int_SoNguyen, _KetQua_A);
             //b) kiểm tra âm dương
            string _KetQua_B = (_int_SoNguyen >= 0) ? "So Duong" : " So Am ";
            Console.WriteLine("So N = {0} la {1} , _int_SoNguyen, _KetQua_B);

            Console.ReadLine();

        } 







       



    }
}      


        

    


