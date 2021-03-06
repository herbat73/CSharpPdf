﻿using System.Collections.Generic;
using CSharpPdf.Logger;
using CSharpPdf.Encoder;
using CSharpPdf.Error;
using CSharpPdf.Font;
using CSharpPdf.Objects;
using CSharpPdf.Streams;
using CSharpPdf.Types;

namespace CSharpPdf.Dict
{
    public class HPDF_Dict : HPDF_Object
    {
        public List<HPDF_DictElement> List;	
    	public int Filter; 
    	public HPDF_Error Error;  
    	public HPDF_FontAttr Attr; 	
    	public HPDF_Stream Stream;

        private readonly string[] HPDF_INFO_ATTR_NAMES = { "CreationDate", "ModDate", "Author", "Creator", "Producer", "Title", "Subject", "Keywords" };

        public HPDF_Dict()
        {
            LibLogger.Debug(this.GetType(), "ctor");

            Header = new HPDF_Obj_Header
            {
                ObjClass = HPDF_Obj_Header.HPDF_OCLASS_DICT
            };

            List = new List<HPDF_DictElement>();
            Filter = HPDF_Stream.HPDF_STREAM_FILTER_NONE;
            Error = new HPDF_Error();
        }

        public HPDF_DictElement GetElement(string key)
        {
            LibLogger.Debug(this.GetType(), $"GetElement key {key}");

            for (int i = 0 ; i < List.Count; i++ ) 
			{
                var el  = List[i];
                if (el.Key == key)
                    return el;
            }
            return null;
        }

        public void HPDF_Dict_Add(string key, HPDF_Object obj)
        {
            LibLogger.Debug(this.GetType(), $"HPDF_Dict_Add key {key} obj.Header.ObjId {obj.Header.ObjId}");

            HPDF_Obj_Header header = obj.Header;
            HPDF_DictElement element;

            if ((header.ObjId & HPDF_Obj_Header.HPDF_OTYPE_DIRECT) != 0)
                Error = new HPDF_Error("HPDF_Dict_Add line - invalid object", HPDF_Error.HPDF_INVALID_OBJECT, 0);

            if (key == null)
                Error = new HPDF_Error("HPDF_Dict_Add line - invalid object", HPDF_Error.HPDF_INVALID_OBJECT, 0);

            if (List.Count >= HPDF_Consts.HPDF_LIMIT_MAX_DICT_ELEMENT)
            {
                LibLogger.Debug(this.GetType(), " HPDF_Dict_Add exceed limitatin of dict count(" + HPDF_Consts.HPDF_LIMIT_MAX_DICT_ELEMENT.ToString() + ")");
                Error = new HPDF_Error("HPDF_Dict_Add line - invalid object", HPDF_Error.HPDF_DICT_COUNT_ERR, 0);
            }

            /* check whether there is an object which has same name */
            element = GetElement(key);

            if (element!=null)
            {
                element.Value = null;
            }
            else
            {
                element = new HPDF_DictElement
                {
                    Key = key,
                    Value = null
                };

                List.Add(element);
            }

            if ((header.ObjId & HPDF_Obj_Header.HPDF_OTYPE_INDIRECT)!=0)
            {
                var proxy = new HPDF_Proxy(obj);
                element.Value = proxy;
                proxy.Header.ObjId |= HPDF_Obj_Header.HPDF_OTYPE_DIRECT;
            }
            else
            {
                element.Value = obj;
                header.ObjId |= HPDF_Obj_Header.HPDF_OTYPE_DIRECT;
            }
        }

        public void HPDF_Dict_AddName(string key, string value)
		{
            HPDF_Name name = new HPDF_Name(value);
            HPDF_Dict_Add(key, name);
        }

        public void HPDF_Dict_AddNumber(string key, int value)
	    {
	    	var number = new HPDF_Number(value);
            HPDF_Dict_Add(key, number);
        }

        public HPDF_Object HPDF_Dict_GetItem(string key, uint objClass)
        {
            LibLogger.Debug(this.GetType(), $"HPDF_Dict_GetItem key {key} objClass {objClass}");

            var element = GetElement(key);
            HPDF_Object obj = new HPDF_Object();

            if (element!=null && key==element.Key)
            {
                var header = element.Value.Header;

                if (header.ObjClass == HPDF_Obj_Header.HPDF_OCLASS_PROXY)
                {
                    HPDF_Proxy p = new HPDF_Proxy(element.Value);
                    header = p.Header;
                    obj = p.Obj;
                }
                else
                    obj = element.Value;

                if ((Header.ObjClass & HPDF_Obj_Header.HPDF_OCLASS_ANY) != objClass)
                {
                    Error = new HPDF_Error("HPDF_Dict_GetItem", HPDF_Error.HPDF_DICT_ITEM_UNEXPECTED_TYPE, 0);
                }
            }

            return obj;
        }

        public void HPDF_Dict_RemoveElement(string key)
        {
    	    for (int i = 0; i<List.Count; i++)
    	    {
	            var element = List[i];
	            if (element.Key==key)
	            {
                    List.Remove(element);
                }
	        }
        }

        public string HPDF_Dict_GetKeyByObj(HPDF_Object obj)
        {
            for (int i = 0; i < List.Count; i++)
            {
                var element = List[i];
                var header = element.Value.Header;

                if (header.ObjClass == HPDF_Obj_Header.HPDF_OCLASS_PROXY)
                {
                    HPDF_Proxy p = new HPDF_Proxy(element.Value);

                    if (p.Obj == obj)
                        return element.Key;
                }
                else
                {
                    if (element.Value == obj)
                        return element.Key;
                }
            }

            return null;
        }

        public void HPDF_Dict_AddReal(string key, double value)
	    {
		    var real = new HPDF_Real(value);
		    HPDF_Dict_Add(key, real);
        }

        public void HPDF_Info_SetInfoAttr(int type, string value, HPDF_Encoder encoder)
        {

        }

    }
}
