using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spelmonosub
{
    public class Alfred: Actor
    {
        
        public override void Draw()
        {

        }
        public override void Update()
        {
            position.Y++;
        }
    }
}