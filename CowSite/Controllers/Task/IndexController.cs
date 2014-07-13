﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CowSite.Controllers.Task
{
    public class IndexController : Controller
    {
        /// <summary>
        /// 任务列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View("~/Views/Task/Index.cshtml");
        }
        /// <summary>
        /// 发情/配种任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskInsemination()
        {
            return View("~/Views/Task/TaskInsemination.cshtml");
        }
        /// <summary>
        /// 妊检初检任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskInitialInspection()
        {
            return View("~/Views/Task/TaskInitialInspection.cshtml");
        }
        /// <summary>
        /// 妊检复检任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskReInspection()
        {
            return View("~/Views/Task/TaskReInspection.cshtml");
        }
        /// <summary>
        /// 产前21天任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskDay21ToBorn()
        {
            return View("~/Views/Task/TaskDay21ToBorn.cshtml");
        }
        /// <summary>
        /// 产前7天任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskDay7TorBorn()
        {
            return View("~/Views/Task/TaskDay7TorBorn.cshtml");
        }
        /// <summary>
        /// 产后3天任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskDay3AfterBorn()
        {
            return View("~/Views/Task/TaskDay3AfterBorn.cshtml");
        }
        /// <summary>
        /// 产后10天任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskDay10AfterBorn()
        {
            return View("~/Views/Task/TaskDay10AfterBorn.cshtml");
        }
        /// <summary>
        /// 产后15天任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskDay15AfterBorn()
        {
            return View("~/Views/Task/TaskDay15AfterBorn.cshtml");
        }
        /// <summary>
        /// 免疫任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskCompleteImmune()
        {
            return View("~/Views/Task/TaskCompleteImmune.cshtml");
        }
        /// <summary>
        /// 检疫任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskCompleteQuarantine()
        {
            return View("~/Views/Task/TaskCompleteQuarantine.cshtml");
        }
        /// <summary>
        /// 分群任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskCompleteGrouping()
        {
            return View("~/Views/Task/TaskCompleteGrouping.cshtml");
        }
        /// <summary>
        /// 犊牛饲喂任务单
        /// </summary>
        /// <returns></returns>
        public ActionResult TaskCompleteCalf()
        {
            return View("~/Views/Task/TaskCompleteCalf.cshtml");
        }
	}
}