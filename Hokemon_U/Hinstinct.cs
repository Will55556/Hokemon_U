using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hinstinct : Hokemon //The colon means that it is inheriting from the Hokemon class. 
    {
        
        private string team = "Hinstinct";

        public void Aboutt()
        {
            Console.WriteLine("I am {0}, part of team {1}!!", Name, team);
        }
    }
}

