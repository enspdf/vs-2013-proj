using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Repository
    {
        public Demo GetDemo()
        {
            return new Demo
            {
                Message = "Hello Message",
                MessageHTML = "<h1>Html hello message</h1>"
            };
        }
    }
}
