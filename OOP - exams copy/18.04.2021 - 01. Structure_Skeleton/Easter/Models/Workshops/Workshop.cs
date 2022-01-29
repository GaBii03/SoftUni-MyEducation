using System;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;

namespace Easter.Models.Workshops
{
    public class Workshop :IWorkshop
    {
        public Workshop()
        {
        }

        public void Color(IEgg egg, IBunny bunny)
        {
             while (egg.IsDone() || bunny.Energy==0 || bunny.Dyes.Count == 0)
             {
                 egg.GetColored();
             }
        }
    }
}
