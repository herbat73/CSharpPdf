using CSharpPdf.Dict;
using CSharpPdf.Encrypt;
using CSharpPdf.Error;
using CSharpPdf.Objects;
using CSharpPdf.Streams;
using System.Collections.Generic;
using CSharpPdf.Logger;

namespace CSharpPdf.Xref
{
    public class HPDF_Xref
    {
        public const string HPDF_FREE_ENTRY      = "f";
		public const string HPDF_IN_USE_ENTRY    = "n";

        public HPDF_Error Error; 
      	public int StartOffset; 
      	public List<HPDF_Xref_Entry> Entries;
      	public int Addr; 
      	public HPDF_Xref Prev; 
      	public HPDF_Dict Trailer;

        public HPDF_Xref(int offset = 0)
        {
            LibLogger.Debug(this.GetType(), " HPDF_Xref_New\n");

            HPDF_Xref_Entry newEntry;    
    
            StartOffset = offset;
            Entries = new List<HPDF_Xref_Entry>();
            Addr = 0;

            if (StartOffset == 0)
            {
                newEntry = new HPDF_Xref_Entry
                {
                    EntryTyp = HPDF_FREE_ENTRY,
                    ByteOffset = 0,
                    GenNo = HPDF_Consts.HPDF_MAX_GENERATION_NUM,
                    Obj = null
                };

                Entries.Add(newEntry);
            }

            Trailer = new HPDF_Dict();
            Error = new HPDF_Error();
        }

        public double HPDF_Xref_Free()
        {
            LibLogger.Debug(this.GetType(), "HPDF_Xref_Free");

            HPDF_Xref lxref = this;
            while (lxref != null)
            {
                /* delete all objects belong to the xref. */

                if (lxref.Entries.Count>0)
                {
                    for (int i= 0; i < lxref.Entries.Count; i++) 
		            {
                        var entry = lxref.HPDF_Xref_GetEntry(i);
                        if (entry.Obj!=null)
                        {
                            //HPDF_Obj_ForceFree (xref->mmgr, entry->obj);
                            entry.Obj = null;
                        }
                        // HPDF_FreeMem (xref->mmgr, entry);
                    }
                    ///HPDF_List_Free(xref->entries);
                    lxref.Entries = null;
                }

                if (lxref.Trailer!=null)
                {
                    //     HPDF_Dict_Free (xref->trailer);
                    lxref.Trailer = null;
                }

                var tmpXref = lxref.Prev;
                //HPDF_FreeMem (xref->mmgr, xref);
                lxref = null;
                lxref = tmpXref;
            }

            return HPDF_Consts.HPDF_OK;
        }

        public void HPDF_Xref_Add(HPDF_Object obj)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Xref_Add");

            if (obj==null)
            {
                throw new HPDF_Error("HPDF_Xref_Add", HPDF_Error.HPDF_INVALID_OBJECT, 0);
            }

            var header = obj.Header;

            if ((header.ObjId & HPDF_Obj_Header.HPDF_OTYPE_DIRECT)!=0 ||
                (header.ObjId & HPDF_Obj_Header.HPDF_OTYPE_INDIRECT)!=0)
            {
                throw new HPDF_Error("HPDF_Xref_Add", HPDF_Error.HPDF_INVALID_OBJECT, 0);
            }

            if (Entries.Count >= HPDF_Consts.HPDF_LIMIT_MAX_XREF_ELEMENT)
            {
                throw new HPDF_Error("HPDF_Xref_Add", HPDF_Error.HPDF_XREF_COUNT_ERR, 0);
            }

            var entry = new HPDF_Xref_Entry
            {
                EntryTyp = HPDF_IN_USE_ENTRY,
                ByteOffset = 0,
                GenNo = 0,
                Obj = obj
            };

            Entries.Add(entry);

            header.ObjId = (uint)(StartOffset + Entries.Count - 1 + (int)HPDF_Obj_Header.HPDF_OTYPE_INDIRECT);
            header.GenNo = entry.GenNo;
        } 

        private HPDF_Xref_Entry HPDF_Xref_GetEntry(int index) 
		{
			return Entries[index];
		}

        public HPDF_Xref_Entry HPDF_Xref_GetEntryByObjectId(uint objId)
        {
            LibLogger.Debug(this.GetType(), "HPDF_Xref_GetEntryByObjectId");

            HPDF_Xref tmpXref = this;

            while (tmpXref!=null)
            {
                uint i;

                if (tmpXref.Entries.Count + tmpXref.StartOffset > objId)
                {
                    throw new HPDF_Error("HPDF_Xref_GetEntryByObjectId", HPDF_Error.HPDF_INVALID_OBJ_ID, 0);
                }

                if (tmpXref.StartOffset < objId)
                {
                    for (i = 0; i < tmpXref.Entries.Count; i++)
                    {
                        if (tmpXref.StartOffset + i == objId)
                        {
                            HPDF_Xref_Entry entry  = tmpXref.HPDF_Xref_GetEntry((int)i);
                            return entry;
                        }
                    }
                }

                tmpXref = tmpXref.Prev;
            }

            return null;
        }

        private void WriteTrailer(HPDF_Stream stream)  
	    {
            LibLogger.Debug(this.GetType(), " WriteTrailer");
            int maxObjId =	(int)Entries.Count + StartOffset;
 
            Trailer.HPDF_Dict_AddNumber("Size", maxObjId) ;
			            
	        if (Prev!=null)
	        {
                Trailer.HPDF_Dict_AddNumber("Prev", Prev.Addr);
	        }

            stream.HPDF_Stream_WriteStr(HPDF_Utils.ParseString("trailer\\012") );
	        
	        //trailer.HPDF_Dict_Write ( stream, null);
	        stream.HPDF_Dict_Write(Trailer, null as HPDF_Encrypt ) ; 
	        
	        stream.HPDF_Stream_WriteStr(HPDF_Utils.ParseString ( "\\012startxref\\012"));
	        
	        stream.HPDF_Stream_WriteUInt((uint)Addr);
	        	
	        stream.HPDF_Stream_WriteStr(HPDF_Utils.ParseString("\\012%%EOF\\012"));
		
	    }
    }
}
