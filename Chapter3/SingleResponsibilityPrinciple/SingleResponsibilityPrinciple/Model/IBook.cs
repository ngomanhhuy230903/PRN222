using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Model
{
    interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        double Price { get; set; }
    }
}

