using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20419695_HW03.Models
{
    public class CombinedViewModel
    {
        public IPagedList<book> Book { get; set; }
        public IPagedList<student> Student { get; set; }
        public IEnumerable<borrow> Borrow { get; set; }
    }
}