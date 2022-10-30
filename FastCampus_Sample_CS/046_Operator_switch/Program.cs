using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name : _046_Operator_switch
//DESK : enum데이터 선언 후 switch문 사용하기

namespace _046_Operator_switch
{
    internal class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT,
        }
        static void Main(string[] args)
        {
            DAY_OF_WEEK dayofWeek = DAY_OF_WEEK.MON;
            string dayString = "";

            switch(dayofWeek)
            {
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAY_OF_WEEK.MON:
                    dayString = "월";
                    break ;
                case DAY_OF_WEEK.TUE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WED:
                    dayString = "수";
                    break;  

            }
            Console.WriteLine("요일은 {0}", dayString);

        }
    }
}
