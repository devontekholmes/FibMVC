using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FibMVC;
using FibMVC.Biz;

namespace FibMVC.Models
{
    public class FibList
    {
        public List<int> FibSeq { get; set; }
        public int limit { get; set; }

        public FibList()
        {
            
        }

        public FibList(int l)
        {
            limit = l;
            Fibby FS = new Fibby();
           // FibSeq = FibListSequence(l); //Had problems with including my FibMVC.Biz
        }

        public void FibTest()
        {
            Fibby FST = new Fibby();
            //FibSeq = FibListSequence(15); //Had problems with including my FibMVC.Biz
        }

    }
}