using System;
using System.Collections.Generic;
using System.Text;

//std::vector -> List<T>
//std::list -> LinkedList<T>
//std::map -> SortedDictionary<Tkey, Tvalue>
//std::set -> SortedSet<T>
//std::unordered_set -> HashSet<T>
//std::multiset -> SortedDictionary<Tkey, int> (int keeping count of the number of Tkeys)
//std::unordered_map -> Dictionary<TKey, TValue>

namespace CSharpPdf.Types
{
    public class HPDF_DashMode
    {
        public int[] Ptn { get; set; }
        public int NumPtn { get; set; }
        public int Phase { get; set; }

        public HPDF_DashMode(int[]  ptn  = null , int numPtn = 0, int phase = 0)
        {
            Ptn = ptn;
            NumPtn = numPtn;
            Phase = phase;
        }

        public static HPDF_DashMode getZeroDashMode() 
		{
            var ret = new HPDF_DashMode
            {
                Ptn = new int[8],
                NumPtn = 0,
                Phase = 0
            };
            return ret; 
		}
}
}
