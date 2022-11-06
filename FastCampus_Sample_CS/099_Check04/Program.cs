using System;

namespace _099_Check04
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run()
        {
            Console.Write("{0}의 속도로 ", _Speed);
        }

        public virtual void Attack()
        {
            Console.WriteLine();

            if (this is Healer)
            {
                Console.WriteLine("[마법공격력 - {0}]으로", _Attack * _MP);
            }
            else
            {
                Console.WriteLine("[공격력 - {0}]으로", _Attack);
            }
        }
    }

    class Barbarien : Army
    {
        public Barbarien()
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;
            Console.WriteLine("Barbarien 생성되었습니다.");
        }
        public override void Run()
        {
            base.Run();
            {
                Console.WriteLine("Barbarien이 달려갑니다.  ");
            }
        }

        public override void Attack()
        {
            base.Attack();
            {
                Console.Write("Barbarien이 칼로 공격!!!  ");
            }
        }
    }

    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 100;
            _Speed = 10;
            _Attack = 200;
            Console.WriteLine("Giant가 생성됩니다.  ");

        }
        public override void Run()
        {
            base.Run();
            {
                Console.WriteLine("Giant이 달려갑니다.  ");
            }
        }

        public override void Attack()
        {
            base.Attack();
            {
                Console.Write("Giant 공격!!!  ");
            }
        }
    }

    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
            Console.WriteLine("Healer 생성되었습니다.  ");

        }
        public override void Run()
        {
            base.Run();
            {
                Console.Write("Healer이 날아갑니다.  ");
            }
        }

        public override void Attack()
        {
            base.Attack();
            {
                Console.Write("Healer 마법 공격!!!  ");
            }
        }
    }

    class UnitControl
    {
        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER
        }
        const int MAX = 10;
        Army[] arrArmys;
        int indexCount = 0;
        public UnitControl()
        {
            indexCount = 0;
            arrArmys = new Army[MAX];
        }

        public string Menu()
        {
            Console.WriteLine(" ++ 유닛 관리 시스템 ++");
            Console.WriteLine(" (1)생성 (2)달리기 (3)공격 (0:나가기)");

            return Console.ReadLine();
        }

        public void CreateUnitMenu()
        {
            Console.WriteLine(" ++ 유닛 생성++");
            Console.WriteLine(" (1)바바리안 (2)자이언트 (3)힐러 (0:뒤로가기)");

            UNIT selUnit = UNIT.NONE;
            string inputstr = Console.ReadLine();

            if (indexCount >= MAX)
            {
                Console.WriteLine(" ** 유닛 생성 불가 **({0}/{1})", indexCount, MAX);
                Console.WriteLine();
                return;
            }

            if (inputstr.Equals("1") || inputstr.Equals("2") || inputstr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputstr);//enum 사용법
            }
            else
            {
                selUnit = UNIT.NONE;
            }
            switch (selUnit)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BARBARIAN:
                    arrArmys[indexCount] = new Barbarien();
                    break;
                case UNIT.GIANT:
                    arrArmys[indexCount] = new Giant();
                    break;
                case UNIT.HEALER:
                    arrArmys[indexCount] = new Healer();
                    break;
                default:
                    break;
            }
            indexCount++;
        }

        public void UnitRunMenu()
        {
            Console.WriteLine("======> 유닛 달리기 ");
            Console.WriteLine(" (1)바바리안 (2)자이언츠 (3)힐러 (4)전체 달리기 (0:뒤로가기)");

            UNIT selUnit = UNIT.NONE;
            string inputstr = Console.ReadLine();

            if (inputstr.Equals("1") || inputstr.Equals("2") || inputstr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputstr);
                UnitRun(selUnit);
            }
            else if (inputstr.Equals("4"))
            {
                UnitRun();
            }
            else
            {
                Console.Clear();
            }
        }

        private void UnitRun()
        {
            for (int i = 0; i < indexCount; i++)
            {
                arrArmys[i].Run();
            }

        }

        private void UnitRun(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BARBARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarien)
                        {
                            arrArmys[i].Run();
                        }
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                        {
                            arrArmys[i].Run();
                        }
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                        {
                            arrArmys[i].Run();
                        }
                    }
                    break;
            }
        }

        public void UnitAttackMenu()
        {
            Console.WriteLine("======> 유닛 공격 ===>===> ");
            Console.WriteLine(" (1)바바리안 (2)자이언츠 (3)힐러 (4)전체 공격 (0:뒤로가기)");

            UNIT selUnit = UNIT.NONE;
            string inputstr = Console.ReadLine();

            if (inputstr.Equals("1") || inputstr.Equals("2") || inputstr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputstr);
                UnitAttack(selUnit);
            }
            else if (inputstr.Equals("4"))
            {
                UnitAttack();
            }
            else
            {
                Console.Clear();
            }
        }

        private void UnitAttack()
        {
            for (int i = 0; i < indexCount; i++)
            {
                arrArmys[i].Attack();
            }

        }

        private void UnitAttack(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BARBARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarien)
                        {
                            arrArmys[i].Attack();
                        }
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                        {
                            arrArmys[i].Attack();
                        }
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                        {
                            arrArmys[i].Attack();
                        }
                    }
                    break;
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            UnitControl control = new UnitControl();
            string selNumStr;
            bool isloop = true;

            while (isloop)
            {
                selNumStr = control.Menu();
                switch (selNumStr)
                {
                    case "1": //생성
                        control.CreateUnitMenu();
                        break;
                    case "2"://달리기
                        control.UnitRunMenu();
                        break;
                    case "3"://공격
                        control.UnitAttackMenu();
                        break;
                    default:
                        isloop = false;
                        break;
                }
            }
        }
    }
}
