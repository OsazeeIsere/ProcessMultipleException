using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessMultipleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Handling multiple exception");
            Car myCar = new Car("Bitto", 50);
            //try { 
            myCar.Accelerate(90);
                
           // }
            ////catch(CarIsDeadException e) when(e.ErrorTimeStamp.DayOfWeek!=DayOfWeek.Friday)
            //{
            //    //Console.WriteLine(e.Message);
            //    //do any partial processing of this error
            //    //and pass the buck
            //    try
            //    {
            //        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //    }
            //    catch(Exception e2)
            //    {
            //        //throw an excepltion that records the rew exception
            //        //as well as the message of the first excepltion
            //        throw new CarIsDeadException(e.Message, e2);

            //    }
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    //this will always happen. Exception or not
            //    myCar.CrankTunes(false);

            //}
            Console.ReadLine();

        }
    }
}
