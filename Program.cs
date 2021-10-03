using System;
using System.Collections.Generic;
namespace alpha_test
{
  public class Program
    {
        static void Main(string[] args)
        {

            dynamic k = new Ctest();
           
            read1(k);
          /* List <ok> MyList = new List<ok>();
            
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                ok k = new ok();
                MyList.Add(k);
                MyList[i - 1].nhap();
            }
            for (int i = 1; i <= MyList.Count; i++)
                MyList[i - 1].xuat();
           
       /*    try
            {
                
                if (n<3)
                {
                    Exception MyException = new Exception(" haha");
                    throw MyException;
                }    
                    
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }*/


        }
    }
}