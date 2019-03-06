using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventre.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public Header Header { get; set; }
        public About About { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
    }
}