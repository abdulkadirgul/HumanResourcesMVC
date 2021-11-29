using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class MailTemplate:BaseEntity
    {
        [Display(Name ="Konu")]
        public string Subject { get; set; }

        [Display(Name ="İçerik")]
        public string Content { get; set; }
    }
}
