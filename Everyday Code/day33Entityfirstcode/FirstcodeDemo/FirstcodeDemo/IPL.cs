using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstcodeDemo
{
    public class IPL
    {
        [Key]//it will say that team id is a primary key
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Captain { get; set; }

        public string State { get; set; }
    }
}
