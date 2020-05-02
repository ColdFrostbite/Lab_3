using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    struct Cord
    {
       
        
            public int x;
            public int y;

            public Cord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Cord(int size)
            {
                x = size - 1;
                y = size - 1;
            }

            public bool OnTheBoard(int size)
            {
                if (x < 0 || x > size - 1) return false;
                if (y < 0 || y > size - 1) return false;
                return true;
            }

            public IEnumerable<Cord> YieldCord(int size)
            {
                for (y = 0; y < size; y++)
                    for (x = 0; x < size; x++)
                        yield return this;
            }

            public Cord Add(int sx, int sy)
            {
                return new Cord(x + sx, y + sy);
            }
        
    }
}
