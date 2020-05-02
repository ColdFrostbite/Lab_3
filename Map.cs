using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    struct Map
    {
        int size;
        int[,] map;

        public Map(int size)
        {
            this.size = size;
            map = new int[size, size];
        }

        public void Set(Cord xy, int value)
        {
            if (xy.OnTheBoard(size))
                map[xy.x, xy.y] = value;
        }

        public int Get(Cord xy)
        {
            if (xy.OnTheBoard(size))
                return map[xy.x, xy.y];
            return 0;
        }

        public void Copy(Cord from, Cord to)
        {
            Set(to, Get(from));
        }
    }
}
