using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.PhuongLinh
{
    class PlayGame
    {
        public static void Main()
            
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ban muon them bao nhieu nguoi choi? ");
            Player[] player = new Player[int.Parse( Console.ReadLine())];
            for (int i = 0; i < player.Length; i++)
            {
                
                Console.WriteLine("Mời bạn nhập tên người chơi thứ " + (i + 1) + ":");
                string Name = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tuổi người chơi thứ " + (i + 1) + ":");
                int Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập điểm người chơi thứ " + (i + 1) + ":");
                double Score = double.Parse(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập level người chơi thứ " + (i + 1) + ":");
                int Level = int.Parse(Console.ReadLine());
                player[i] = new Player(Name, Age, Score, Level);

            }
            Console.WriteLine("Danh sach nguoi choi");
            foreach (var item in player)
            {
                Console.WriteLine("Ten = " +item.Name);
                Console.WriteLine("Tuoi = " +item.Age);
                Console.WriteLine("Diem thi = " + item.Score);
                Console.WriteLine("Level = "+ item.Level);
                
            }
        }


    }
}
