using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_delegateParam
{
    delegate void delegateFUNC(); //void형 파라미터도 없음 -> 어떤것들이와도 참조가 가능

    class MessageProcess
    {
        delegateFUNC CallOkFunc;
        delegateFUNC CallcancelFunc;

        public void messgae(string msg, delegateFUNC okFunc, delegateFUNC cancelFunc)
        {
            CallOkFunc = okFunc;
            CallcancelFunc = cancelFunc;

            Console.WriteLine("Message: " + msg + "(0: ok, 1 : cancel");

            string inputStr = Console.ReadLine();

            if(inputStr.Equals("0"))
            {
                CallOkFunc();
            }
            else
            {
                CallcancelFunc();
            }

        }

    }

    internal class Program
    {
        static void Callok()
        {
            Console.WriteLine("callok");
        }

        static void Callcancel()
        {
            Console.WriteLine("callCancel");

        }
        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();
            //msg.messgae("Test Massage", Callok, Callcancel);
            msg.messgae("Test Massage", 
                delegate()
                {
                    Console.WriteLine("Call INDELEGATE");
                },
                Callcancel);

        }
    }
}
