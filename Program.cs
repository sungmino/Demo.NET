using System;

namespace ConsoleApp1
{
    class Program
    {
        //Method-Delegate: Ham uy quyen
        public delegate void ShowLog(string message);
        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0} ", s));
            Console.ResetColor();
        }
        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Warning: {0}", s));
            Console.ResetColor();
        }
        //Khai baos ham co tham so la delegate
        static void TinhTog(int a, int b, Action<string> callback)
        {
            int c = a * b;
            //Goi delegate
            callback("Tong la: " + c);
            //Hoac
            callback.Invoke("Tong la: " + c);

        }

        static double NamBK(double numner)
        {
            double ketqua = numner * numner;
            return ketqua; //Ham ket thuc va tra ve gia tri cho ham

        }
        static void Main(string[] args)
        {
            //Goi ham delegate
            ShowLog showLog;
            showLog = Info; //showLog gan bang phuong thuc Info
            showLog("Sung Mi No"); //Thi hanh delegate chinh la thi hanh Info

            showLog = Warning; //showLog gan bang phuong thuc Warning
            showLog("Lop CNTT2.01-K61");

            //Gan 1 phuong thuc Anonymou(nac danh) cho delegate
            showLog += (x) => { Console.WriteLine(string.Format("===>{0}<===", x)); };
            showLog("Le Dinh Duc");
            //Goi ham chua tham so delegate
            TinhTog(13, 34, Info);
            TinhTog(184, 23, Warning);

            //--------------------------------------------------------
            //Demo 1
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Console demo in C#\r");
            Console.WriteLine("---------------------\n");

            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Ask the User to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add ");
            Console.WriteLine("\ts - Subtrack");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option? ");

            //use a switch statement to do the part. Su dung 1 cau lenh de chuyen doi toan
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;

            }
            //wait for the user to respond befor closing. cho nguoi dung phan hoi truoc khi dong
            Console.WriteLine("Next demo 2...........................................");

            //----------------------------------------------------------------------
            //Demo 2
            //Nhap du lieu
            string userLogin;
            Console.Write("Nhap username: ");
            userLogin = Console.ReadLine();
            Console.WriteLine($"Ten nhap vao la: {userLogin}");
            Console.WriteLine("Ten nhap vao la: " + userLogin);

            Console.Write("Nhap mot so thuc: ");

            //Nhap chuoi va chuyen chuoi do thanh so thuc 
            double dinput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"So da nhap la: {dinput}");
            Console.WriteLine("Next demo 3...................");

            //------------------------------------------------------------------
            //Demo 3
            Console.WriteLine("Demo 3...");
            double bq = NamBK(5); //Goi ham
            Console.WriteLine("Binh phuong cua 5 la: " + bq);

            //Goi phuong thuc cung namespace va de public
            Demo.Hello();

            var max = Demo.Max(23494774, 844729282);
            Console.WriteLine(max);
            long thetich = Demo.TheTich(33);
            Console.WriteLine(thetich);

            //Dong chuong trinh
            Console.Write("Press any key to end demo...");
            Console.ReadKey();

        }

    }
}
