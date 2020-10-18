using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sinavolusturma.Entities
{
    [Table("question")]
    public class question
    {
        [Key]
        public int Id { get; set; }
        public string baslik { get; set; }
        public string metin { get; set; }
        public string birSoru{ get; set; }
        public string birA { get; set; }
        public string birB { get; set; }
        public string birC { get; set; }
        public string birD { get; set; }
        public string birDogru { get; set; }
        public string ikiSoru { get; set; }
        public string ikiA { get; set; }
        public string ikiB { get; set; }
        public string ikiC { get; set; }
        public string ikiD { get; set; }
        public string ikiDogru { get; set; }
        public string ucSoru { get; set; }
        public string ucA { get; set; }
        public string ucB { get; set; }
        public string ucC { get; set; }
        public string ucD { get; set; }
        public string ucDogru { get; set; }
        public string dortSoru { get; set; }
        public string dortA { get; set; }
        public string dortB { get; set; }
        public string dortC { get; set; }
        public string dortD { get; set; }
        public string dortDogru { get; set; }
        public string tarih { get; set; }


    }
}
