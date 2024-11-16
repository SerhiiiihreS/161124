using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void CurTime()
            {
                DateTime time = DateTime.Now;
                Console.WriteLine(time.Hour + ":" + time.Minute + ":" + time.Second);
            }

            void CurDate()
            {
                DateTime date = DateTime.Now;
                Console.WriteLine(date);           
            }

            Action action = new Action(CurTime);
            Action action1 = new Action(CurDate);

            action.Invoke();
            action1.Invoke();
        }
    }
}
