using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class Board
    {
        public int SizeOfBoard { get; set; }
       
        public BaseCard[] ArrCard { get; set; }
        public BaseCard[,] mat { get; set; }

        public Board()
        {
            SizeOfBoard = 4;
            mat = new BaseCard[SizeOfBoard, SizeOfBoard];
        }
        public void Restart(BaseCard[] arr)
        {
            int a, b;
            Random r = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <1; j++)
                {
                    do
                    {
                        a = r.Next(SizeOfBoard);
                        b = r.Next(SizeOfBoard);
                    }
                    while (mat[a, b] != null);
                    mat[a,b] = arr[i];
                }
            }
        }
        public void DrewBoard()
        {
            for (int i = 0; i < SizeOfBoard; i++)
            {
                for (int j = 0; j < SizeOfBoard; j++)
                {
                    if (mat[i, j].Cover == true)
                    {
                        if (mat[i, j] is LetterCard)
                        Console.Write(" "+(mat[i,j]as LetterCard).Letter+" |");
                        if (mat[i, j] is SignCard)
                            Console.Write(" "+(mat[i, j] as SignCard).Sign+" |");
                        if (mat[i, j] is ExersizeCard)
                            Console.Write(" "+(mat[i, j] as ExersizeCard).exersize+" |");
                    }
                    else
                    {
                        if (mat[i, j].IsChoosen == true)
                            Console.Write("   ");
                        else
                            Console.Write(i + "," + j);
                        Console.Write("|");

                    }
                  
                }
                Console.WriteLine(  );
                Console.WriteLine("-----------------------");
            }

        }
        public bool IsValid(int i, int j)
        {
            if (mat[i, j].IsChoosen == true)
                return false;
            return true;
        }
        public bool ExistCard()
        {
            for (int i = 0; i < SizeOfBoard; i++)
            {
                for (int j   = 0; j < SizeOfBoard; j++)
                {
                    if (mat[i, j].IsChoosen == false)
                        return true;
                }
            }
            return false;
        }
    }
}
