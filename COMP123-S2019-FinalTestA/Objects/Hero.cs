using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Student Name:
 * Student ID:
 * Description: This is the hero data container class
 */


namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        // Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Physical abilities
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }
        public string Fighting { get; set; }

        //Mental abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Pysche { get; set; }
        public string Popularity { get; set; }

        //Power List
        List<Power> Powers;

        //Constructor
        Hero()
        {
            //instantiates an empty Power List
            Powers = new List<Power>();
        }
    }
}
