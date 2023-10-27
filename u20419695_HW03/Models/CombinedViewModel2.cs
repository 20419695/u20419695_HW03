using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace u20419695_HW03.Models
{
    public class CombinedViewModel2
    {
        public IPagedList<author> Author { get; set; }
        public IPagedList<borrow> Borrow { get; set; }
        public IPagedList<type> Type { get; set; }
    }
}