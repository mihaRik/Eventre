using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventre.Models
{
    public class Speaker
    {
        public Speaker()
        {
            Talks = new HashSet<Talk>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Fullname { get; set; }

        [Required, StringLength(100)]
        public string Profession { get; set; }

        [Required, StringLength(100)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }

        [Required, StringLength(100)]
        public string Facebook { get; set; }

        [Required, StringLength(100)]
        public string Twitter { get; set; }

        [Required, StringLength(100)]
        public string LinkedIn { get; set; }

        [Required, StringLength(100)]
        public string Pinterest { get; set; }

        public virtual ICollection<Talk> Talks { get; set; }
    }
}