using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;

namespace _075_CheckPoint03
{
    internal class Program
    {
        const int MAPX = 7;
        const int MAPY = 24;
        const int DELAY_TIME = 300;
        static void Updateview(char[] tile, int[,] map)
        {

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    int tileIndex = map[i, j];
                    Console.Write(tile[tileIndex]);

                    if (j == map.GetLength(1) - 1)
                    {
                        Console.WriteLine();

                    }
                }

            }
        }

        static void Clearview()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void UpdateGo(int[] arrIndex, int[,] map)
        {
           for(int i = 0; i < arrIndex.Length; i++)
                {
                    int indexMaxX = i + 1;
                    int indexMaxY = arrIndex[i];

                    int temp = map[indexMaxX,indexMaxY];
                    map[indexMaxX,indexMaxY+1] = temp;
                    map[indexMaxX,arrIndex[i]] = 0;
                    if (arrIndex[i] < 23)
                    arrIndex[i]++;
                }
        }

        static bool UpdateRandomGo(int[] arrIndex, int[,] map, Random rnd)
        {
            bool isFinish = false;

            for (int i = 0; i < arrIndex.Length; i++)
            {
                if (arrIndex[i] >= 22)
                {
                    isFinish = true;
                    break;
                }
            }


            int rndIndex = rnd.Next(0, 5);

            int indexY = arrIndex[rndIndex];

            int temp = map[rndIndex + 1, indexY];
            map[rndIndex + 1, indexY + 1] = temp;
            map[rndIndex + 1, indexY] = 0;

            arrIndex[rndIndex]++;

            return isFinish;
        }


        static void Main(string[] args)
        {


            //char[] tile=   0    1    2    3    4    5    6    7    
            char[] tile = {' ', '-', '|', '1', '2', '3', '4', '5'};

            int[,] map = new int[MAPX, MAPY]
            {
              // 0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, //0
                {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //1
                {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //2
                {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //3
                {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //4
                {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //5
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}  //6
             };

            int[] arrIndex = {0, 0, 0, 0, 0};

            bool isFinish = false;
            
            Random rnd = new Random();

            while(true)
            {
                UpdateGo(arrIndex,map);
                Updateview(tile, map);
                isFinish = UpdateRandomGo(arrIndex, map, rnd);

                Console.WriteLine();

                if (isFinish)
                {
                    for (int i = 0; i < arrIndex.Length; i++)
                    {
                        if (arrIndex[i] >= 22)
                        {
                            Console.Write("달리기 결과: {0} ", (i + 1));
                            break;
                        }
                    }
                    Console.Write("\n다시 시작하려면 0을 입력");

                    int inputstr = int.Parse(Console.ReadLine());

                    if(inputstr == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("나가기");
                        break;
                    }
                }

                Clearview();

                
            }


        } 
    }
}
