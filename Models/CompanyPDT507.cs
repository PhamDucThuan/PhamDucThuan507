using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("CompanyPDT507")]
    public class CompanyPDT507
    {
        [Key]
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
    }
}