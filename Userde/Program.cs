using System;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo pi = new PersonInfo();
            pi.getinfo();
            readxl rxl = new readxl();
            rxl.readXLS(@"C:\Users\Public\Downloads\UserInfo.xlsx");
            //Console.WriteLine("Hello World!");
        }
    }
}
