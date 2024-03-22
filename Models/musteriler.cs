using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarantiKitap.Models
{
    internal class musteriler
    {
        [Key]
        public int ID { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
    }
}
