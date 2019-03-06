using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventre.Models
{
    public class Header
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string SubTitle { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string DatePlace { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }
    }
}