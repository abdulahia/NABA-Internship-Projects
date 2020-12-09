using OfficeOpenXml;
using System.IO;
using System;

namespace UserDetails
{
    public class PersonInfo
    {
        private string firstname;
        private string lastname;
        
   
            public void getinfo()
            {


                Console.WriteLine(" Enter First Name:");
                string userInfo = Console.ReadLine();
                Console.WriteLine(" Enter Last Name:");
                string userInfo1 = Console.ReadLine();


            // }
            //public void info(string userInfo, string userInfo1)
            //{
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage UserDetail = new ExcelPackage();
                ExcelWorksheet works = UserDetail.Workbook.Worksheets.Add("Person Info");
                using (ExcelRange Rng = works.Cells[1, 1])
                {
                    Rng.Value = "First Name";
                    Rng.Style.Font.Size = 10;
                }
                using (ExcelRange Rng = works.Cells[2, 1])
                {
                    Rng.Value = userInfo;
                    Rng.Style.Font.Size = 10;
                }

                using (ExcelRange Rng = works.Cells[1, 2])
                {
                    Rng.Value = "Last Name" ;
                    Rng.Style.Font.Size = 10;
                }
                using (ExcelRange Rng = works.Cells[2, 2])
                {
                    Rng.Value = userInfo1;
                    Rng.Style.Font.Size = 10;
                }


                works.Protection.IsProtected = false;
                works.Protection.AllowSelectLockedCells = false;
                UserDetail.SaveAs(new FileInfo(@"C:\Users\Public\Downloads\UserInfo.xlsx"));
            }



        }



    }


