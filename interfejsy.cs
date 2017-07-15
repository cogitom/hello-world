using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejsycwiczenie
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingsIHave
        {
            get
            {
                return "Duże buty";
            }
        }
                  
        public void Honk()
        {
            Console.Write("Tut, tut, tut");
        }

        public void TalkAboutYourself()
        {
            Console.Write("Jestem " + Name + " i mam " + Height + " wzrostu.");
        }
    }
}
