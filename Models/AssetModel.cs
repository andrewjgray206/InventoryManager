using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InvenManager.Models;

namespace InvenManager.wwwroot.Models
{
    public class AssetModel
    {
        public int ID { get; set; }

        //[Required]
        [MinLength(2, ErrorMessage = "Item Name needs to be at least 2 characters.")]
        [MaxLength(20, ErrorMessage ="Item Name No longer than 20 characters.")] //backend and frontend validation.
        public string Item { get; set; }

        //[Required]
        public string Category { get; set; }

        //[Required]
        public string SerialNo { get; set; }

        [DataType(DataType.Date)]
        //[Required]
        //[DisplayFormat="Acquired Date"]
        public DateTime AcquiredDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="Allocated Date")]
        public DateTime AllocatedDate { get; set; }

        //[DisplayFormat="In Stock?"]
        public Boolean InStock { get; set; }

        public Owner Owner { get; set; }
    }
}
