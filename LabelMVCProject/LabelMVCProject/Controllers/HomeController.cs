using LabelMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabelMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public JsonResult GetTasks()
        //{
        //    var label1 = new Label() { Type = "checkbox", InnerHtml = "True", ClassID = "classID1" };
        //    var label2 = new Label() { Type = "checkbox", InnerHtml = "False", ClassID = "classID2" };
        //    var label3 = new Label() { Type = "text", InnerHtml = "Edit: ", ClassID = "classID3" };
        //    var label4 = new Label() { Type = "text", InnerHtml = "Delete: ", ClassID = "classID4" };
        //    var label5 = new Label() { Type = "checkbox", InnerHtml = "True", ClassID = "classID5" };
        //    var label6 = new Label() { Type = "checkbox", InnerHtml = "False", ClassID = "classID6" };
        //    var labels1 = new List<Label>();
        //    labels1.Add(label1);
        //    labels1.Add(label2);
        //    var labels2 = new List<Label>();
        //    labels2.Add(label3);
        //    labels2.Add(label4);
        //    var labels3 = new List<Label>();
        //    labels3.Add(label5);
        //    labels3.Add(label6);
        //    var rule1 = new Rule() { RuleName = "Rule1", Patten = "", Labels = labels1 };
        //    var rule2 = new Rule() { RuleName = "Rule2", Patten = "", Labels = labels2 };
        //    var rule3 = new Rule() { RuleName = "Rule3", Patten = "", Labels = labels3 };
        //    var rules = new List<Rule>();
        //    rules.Add(rule1);
        //    rules.Add(rule2);
        //    rules.Add(rule3);
        //    var task = new Task() { Num = 1, ID = 001, Name = "小冰诗歌", Content = "古佛洞的尽头是低矮的棚屋", Rules = rules };
        //    var tasks = new List<Task>();
        //    tasks.Add(task);
        //    return Json(tasks, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult TaskDetail()
        {
            //http request get json
            var label1 = new Label() { InnerHtml = "True", ClassID = "true" };
            var label2 = new Label() { InnerHtml = "False", ClassID = "false" };
            var label3 = new Label() { InnerHtml = "Edit: ", ClassID = "edit" };
            var label4 = new Label() { InnerHtml = "Delete: ", ClassID = "delete" };
            var label5 = new Label() { InnerHtml = "暴力", ClassID = "classID5" };
            var label6 = new Label() { InnerHtml = "色情", ClassID = "classID6" };
            var label7 = new Label() { InnerHtml = "犯罪", ClassID = "classID7" };
            var label8 = new Label() { InnerHtml = "赌博", ClassID = "classID8" };
            var labels1 = new List<Label>();
            labels1.Add(label1);
            labels1.Add(label2);
            var labels2 = new List<Label>();
            labels2.Add(label3);
            labels2.Add(label4);
            var labels3 = new List<Label>();
            labels3.Add(label5);
            labels3.Add(label7);
            labels3.Add(label6);
            labels3.Add(label8);
            var labels4 = new List<Label>();
            labels4.Add(label5);
            labels4.Add(label7);
            labels4.Add(label6);
            labels4.Add(label8);
            var rule1 = new Rule() { RuleName = "Rule1", Patten = "", Labels = labels1, Type = "text" };
            var rule2 = new Rule() { RuleName = "Rule2", Patten = "", Labels = labels2, Type = "radio" };
            var rule3 = new Rule() { RuleName = "Rule3", Patten = "", Labels = labels3, Type = "checkbox" };
            var rule4 = new Rule() { RuleName = "Rule4", Patten = "", Labels = labels4, Type = "select" };
            var rules = new List<Rule>();
            rules.Add(rule1);
            rules.Add(rule2);
            rules.Add(rule3);
            rules.Add(rule4);
            var task = new Task() { Num = 1, Name = "小冰诗歌", Content = "古佛洞的尽头是低矮的棚屋", Rules = rules };
            var tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(task);
            }
            //ViewData["tasks"] = tasks;
            return View(tasks);
        }

        public ActionResult TaskHistoryDetail()
        {
            return View();
        }
    }
}