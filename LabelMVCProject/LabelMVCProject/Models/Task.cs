using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabelMVCProject.Models
{
    public class Task
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public List<Rule> Rules { get; set; }
    }

    public class Rule
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Patten { get; set; }
        public List<LabelInfo> Labels { get; set; }
    }

    public class LabelInfo
    {
        public string Label { get; set; }
        public string ClassID { get; set; }
    }
}