﻿using DairyCow.BLL;
using DairyCow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CowSite.Controllers.Task
{
    public class TaskDay7ToBornController : Controller
    {

        public JsonResult LoadTask(string taskID)
        {
            TaskBLL bll = new TaskBLL();
            DairyTask v;
            v = bll.GetTaskByID(Convert.ToInt32(taskID));
            string displayEarNum = CowBLL.ConvertEarNumToDisplayEarNum(v.EarNum);

            UserBLL u = new UserBLL();
          
            return Json(new
            {
                EarNum = v.EarNum,
                DisplayEarNum = displayEarNum,
                ArrivalTime = v.ArrivalTime.ToString("yyyy-MM-dd"),
                Operator = v.OperatorID
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveTask()
        {
            try
            {

                TaskBLL bll = new TaskBLL();
                DairyTask v = bll.GetTaskByID(Convert.ToInt32(Request.Form["id"]));
                v.ArrivalTime = DateTime.Parse(Request.Form["start"]);
                v.CompleteTime = DateTime.Parse(Request.Form["end"]);
                v.OperatorID = Convert.ToInt32(Request.Form["operatorName"]);
                int house = Convert.ToInt32(Request.Form["house"]);
                int group = Convert.ToInt32(Request.Form["group"]);
                bll.CompleteDay7ToBorn(v, house, group);

            }
            catch (Exception)
            {
                //todo dehua
            }
            return Json(new { status = 0 }, JsonRequestBehavior.AllowGet);
        }
    }
}