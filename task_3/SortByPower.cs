
using System.Collections.Generic;

namespace task_3
{
    public class SortByPower : IComparer<Device>
    {
     
        public int Compare(Device o1, Device o2)
        {
            return o1.getPower().CompareTo(o2.getPower());
        }

    }
}
