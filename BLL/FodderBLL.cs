﻿using DairyCow.DAL;
using DairyCow.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace DairyCow.BLL
{
    public class FodderBLL
    {
        FodderDAL dalFodder = new FodderDAL();
        /// <summary>
        /// 获取配方中可以在牧场匹配的牧场饲料list
        /// </summary>
        /// <param name="formulaID"></param>
        /// <param name="pastureID"></param>
        /// <returns></returns>
        public List<PastureFodder> GetMappedPastureFodders(int formulaID,int pastureID)
        {
            List<Fodder> sList = GetFodderList(formulaID);
            List<PastureFodder> pList = new List<PastureFodder>();
            foreach (Fodder item in sList)
            {
                PastureFodder p = MapToPastureFodder(item, pastureID);
                if (p!=null)
                {
                    pList.Add(p);
                }
            }
            return pList;
        }

        /// <summary>
        /// 获取牧场所有饲料list
        /// </summary>
        /// <param name="pastureID"></param>
        /// <returns></returns>
        public List<PastureFodder> GetPastureFodders(int pastureID)
        {
            DataTable fodder = this.dalFodder.GetPastureFodderTable(pastureID);

            List<PastureFodder> lstFodder = new List<PastureFodder>();
            foreach (DataRow darFodder in fodder.Rows)
            {
                PastureFodder fodderItem = WrapPastureFodder(darFodder);
                lstFodder.Add(fodderItem);
            }
            return lstFodder;
        }
        /// <summary>
        /// 获取某配方的标准饲料list
        /// </summary>
        /// <param name="formulaID"></param>
        /// <returns></returns>
        public List<Fodder> GetFodderList(int formulaID)
        {
            DataTable fodder = this.dalFodder.GetStandardFodderTable(formulaID);

            List<Fodder> lstFodder = new List<Fodder>();
            foreach (DataRow darFodder in fodder.Rows)
            {
                Fodder fodderItem = WrapStandardFodder(darFodder);
                lstFodder.Add(fodderItem);
            }

            return lstFodder;
        }
        /// <summary>
        /// 封装牧场饲料
        /// </summary>
        /// <param name="fodderRow"></param>
        /// <returns></returns>
        public PastureFodder WrapPastureFodder(DataRow fodderRow)
        {
            PastureFodder f = new PastureFodder();
            if (fodderRow != null)
            {
                f.FodderID = Convert.ToInt32(fodderRow["FodderID"]);
                f.FodderName = fodderRow["FodderName"].ToString();
                f.Description = fodderRow["Description"].ToString();
                f.IsCurrent = Convert.ToInt32(fodderRow["IsCurrent"]) == 1 ? true : false;
                f.SysFodderID = Convert.ToInt32(fodderRow["SysFodderID"]);
                f.Quantity = Convert.ToDouble(fodderRow["Quantity"]);
                f.Price = Convert.ToDouble(fodderRow["Price"]);
                f.PastureID = Convert.ToInt32(fodderRow["PastureID"]);
            }
            return f;
        }
        
        public Fodder WrapStandardFodder(DataRow fodderRow)
        {
            Fodder fodderItem = new Fodder();
            if (fodderRow != null)
            {
                fodderItem.ID = Convert.ToInt32(fodderRow["FodderID"]);
                fodderItem.Name = fodderRow["FodderName"].ToString();
                fodderItem.Quantity = Convert.ToInt32(fodderRow["Quantity"]);
            }
            return fodderItem;
        }

        public PastureFodder MapToPastureFodder(Fodder standardFodder, int pastureID)
        {
            PastureFodder p=GetPastureFodders(pastureID).Find(p => p.PastureID == pastureID && p.SysFodderID == standardFodder.ID);
            return p;
        }
     
        public int InsertFodder(Fodder f)
        {
            int temp = 0;
            temp = dalFodder.InsertStandardFodder(f.Name,
                                                    f.Description,
                                                    f.RefPrice,
                                                    f.DM,
                                                    f.NND,
                                                    f.Ca,
                                                    f.P,
                                                    f.CP,
                                                    f.CF,
                                                    f.Fat,
                                                    f.NFE,
                                                    f.ASH,
                                                    f.NDF,
                                                    f.ADF,
                                                    f.NPP,
                                                    f.Arg,
                                                    f.His,
                                                    f.Ile,
                                                    f.Leu,
                                                    f.Lys,
                                                    f.Met,
                                                    f.Cys,
                                                    f.Phe,
                                                    f.Tyr,
                                                    f.Thr,
                                                    f.Trp,
                                                    f.Val,
                                                    f.Na,
                                                    f.Cl,
                                                    f.Mg,
                                                    f.K,
                                                    f.Fe,
                                                    f.Cu,
                                                    f.Mn,
                                                    f.Zn,
                                                    f.Se);
            return temp;
        }
    }
}
