using System;

namespace baitaptinhso
{
    class Program
    {
        static void Main(string[] args)
        {
          int A, B;
          int tong, hieu, tich;
          double thuong;
          string strA, strB;
          bool xt1, xt2;

          Console.Write("nhap so A: ");
          strA = Console.ReadLine();
          Console.Write("nhap so B: ");
          strB = Console.ReadLine();

          xt1 = int.TryParse(strA, out A);
          Console.Write("So a nhap vao la hahahaha: " ); Console.WriteLine(xt1 == true ? "dung" : "sai");
          xt2 = int.TryParse(strB, out B);
          Console.Write("So b nhap vao la: " ); Console.WriteLine(xt2 == true ? "dung" : "sai");
          
          tong = A+B;
          hieu = A-B;
          tich = A*B;
          thuong = (double)A/B;

          Console.WriteLine(" Tong = " + tong);
          Console.WriteLine(" Hieu = " + hieu);
          Console.WriteLine(" Tich = " + tich);
          Console.WriteLine(" Thuong = " + thuong);
        }
    }
}