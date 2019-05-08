using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp

{
    class Animal
    {
        public string Kingdom { get; set; } // Mammals, Fish, Birds
        public string Habitat { get; set; } // Land, Water, Air
        public string Region { get; set; } // Hot, Warm, Cold, Ice

        public string Marry()
        {
            if (Kingdom == "Mammals") return "Will Give Birth";
            else if (Kingdom == "Fish") return "Will Lay Small Eggs";
            else return "Will Have Yellow Chicken";
        }

        /// <summary>
        /// Define Animal.Habitat as {Land, Water, Air}
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public virtual string Activity()
        {
            switch (Habitat)
            {
                case "Land": return "The Animal Runs";
                case "Water": return "The Animal Swims";
                case "Air": return "The Animal Flies";
                default: return "Do your unknown activity";
            }
        }
    }
}
