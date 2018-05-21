using CSharpPdf.error;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpPdf.objects
{
    public class HPDF_List
    {
        public uint blockSiz; 
      	public uint itemsPerBlock;
        public List<HPDF_Object> Obj;

        public HPDF_List(uint pItemsPerBlock)
        {
            itemsPerBlock = pItemsPerBlock;
        }

        public void HPDF_List_Add(HPDF_Object item) 
        {
            Obj.Add(item);
        }

        public void HPDF_List_Insert(HPDF_Object target, HPDF_Object item) 
		{
			int targetIdx	= HPDF_List_Find( target ) ;
            HPDF_Object lastItem	= Obj[Obj.Count - 1]; 
			int i;

            Trace.WriteLine(" HPDF_List_Insert");
			
			if (targetIdx < 0)
				throw new HPDF_Error("HPDF_List_Insert", HPDF_Error.HPDF_ITEM_NOT_FOUND, 0);
			
			/* move the item of the list to behind one by one. */
			for (i = Obj.Count - 2; i >= targetIdx; i--)
                Obj[i + 1] = Obj[i];

            Obj[targetIdx] = item;
			
			HPDF_List_Add (lastItem);
		}

        public int HPDF_List_Find(object item)
		{
						
			Trace.WriteLine(" HPDF_List_Find");
			
			for (int i= 0; i< Obj.Count; i++) {
				if (Obj[i] == item)
					return i;
			}
			
			return -1;
		}

        public object HPDF_List_ItemAt(int i) 
        {
        	return Obj[i]; 
        }

        public void HPDF_List_Free()
		{		
		}
    }
}
