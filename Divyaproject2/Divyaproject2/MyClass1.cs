using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class MyClass
    {
        private string Author_name;
        private int Total_articles;

        public MyClass(String a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
    }
}

