using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class Fibby
    {

        public int afib;
        public int bfib;
        public List<int> FibList { get; set; }

        public List<int> FibListSequence(int limit)
        {
            FibList.Add(afib);
                for(int i = 0; i < limit; i++)
                {
                    int temp = afib;
                    afib = bfib;
                    bfib = temp + bfib;
                    FibList.Add(afib);
                }
            return FibList;
            }

           
        }
    }

