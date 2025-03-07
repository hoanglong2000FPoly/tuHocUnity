using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.PhuongLinh
{
    class Player
    {
       


        public String Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }
        public int Level { get; set; }

        public Player(string name, int age, double score, int level)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
            this.Level = level;
        }

        public Player()
        {
        }
    }
   
        
    
}
