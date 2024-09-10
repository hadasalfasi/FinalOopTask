using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class Game
    {
        public BasicPlayer[] players { get; set; }

        public BaseCard[] Cards { get; set; }
        public int index { get; set; }
        //איתחול שחקנים
        public void RestartPC()
        {

            int p;
            Console.WriteLine("enter num of players: \n and num of cards types\n");
            players = new BasicPlayer[int.Parse(Console.ReadLine())+1];
            Cards = new BaseCard[16];
            Cards[0] = new SignCard('@', "blue");
            Cards[1] = new SignCard('@', "blue");
            Cards[2] = new SignCard('#', "red");
            Cards[3] = new SignCard('#', "red");
            Cards[4] = new SignCard('$', "yello");
            Cards[5] = new SignCard('$', "yello");
            Cards[6] = new LetterCard('A');
            Cards[7] = new LetterCard('A');
            Cards[8] = new LetterCard('B');
            Cards[9] = new LetterCard('B');
            Cards[10] = new LetterCard('C');
            Cards[11] = new LetterCard('C');
            Cards[12] = new ExersizeCard("7+3", "10");
            Cards[13] = new ExersizeCard("7+3", "10");
            Cards[14] = new ExersizeCard("12*3", "36");
            Cards[15] = new ExersizeCard("12*3", "36");
            //איתחול של השחקנים
            for (int i = 1; i < players.Length; i++)
            {
                do
                {
                    Console.WriteLine("if the user number :" + i + "is person press 1 \ncomputer pres 2");
                    p = int.Parse(Console.ReadLine());
                }
                while (p > 2 || p<= 0);
                switch (p)
                {
                    case 1:
                        {
                            players[i] = new UserPlayer();
                            players[i].SETNAME();
                        }
                        break;
                    case 2:
                        players[i] = new ComputerPlayer();
                        break;

                }

            }
        }
        public void Pers(BasicPlayer b, BaseCard card1,BaseCard card2)
        {
            b.Points++;
            card1.IsChoosen = true;
            card2.IsChoosen = true;
            for (int i = 0; i < 8; i++)
            {
                if (b.GuesCard[i] == null)
                {
                    b.GuesCard[i] = card1;
                    break;
                }
            }
        }
        public void TheWinner()
        {
            int max = 0, p = -1;
            for (int i = 1; i < players.Length; i++)
            {
                if (players[i].Points > max)
                {
                    max = players[i].Points;
                    p = i;
                }
            }
            Console.WriteLine("the winner player is: " + players[p].Name + "whith: " + max + "points!!!!!!!");
        }
        public void MainGame()
        {   
            Board b = new Board();
            RestartPC();
            b.Restart(Cards);
            bool flag = false;
            int[] arr1 = new int[2];
            int[] arr2 = new int[2];
            while (flag == false)
            {
                for (int i = 1; i < players.Length && b.ExistCard() == true; i++)
                {
                    Console.WriteLine("the player now is: " + players[i].Name);
                    b.DrewBoard();
                    do
                    {
                        arr1 = players[i].ChooseCard(4);
                    }
                    while (b.IsValid(arr1[0], arr1[1]) == false);
                    b.mat[arr1[0], arr1[1]].Cover = true;
                    b.DrewBoard();
           
                    do
                    {
                        arr2 = players[i].ChooseCard(4);
                    }
                    while (b.IsValid(arr2[0], arr2[1]) == false || ( arr2[0] == arr1[0] && arr2[1] == arr1[1]));
                    b.mat[arr2[0], arr2[1]].Cover = true;
                    b.DrewBoard();
                    if (b.mat[arr1[0], arr1[1]].IsEquals(b.mat[arr2[0], arr2[1]]))
                    {
                        Pers(players[i], b.mat[arr1[0], arr1[1]], b.mat[arr2[0], arr2[1]]);
                        
                    }
                    b.mat[arr1[0], arr1[1]].Cover = false;
                    b.mat[arr1[0], arr1[1]].Cover = false;
                    Console.WriteLine();
                }
                if (b.ExistCard() == false)
                {
                    flag = true;
                }

            }
            TheWinner();
        }

    }
}
