using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("PDT0507")]
    public class PDT0507
    {
        [Key]
        public string PDTID { get; set; }
        public string PDTName { get; set; }
    }
}