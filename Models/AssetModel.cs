using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvenManager.wwwroot.Models
{
    public class AssetModel
    {
        public int ID { get; set; }

        //[Required]
        [MinLength(2, ErrorMessage = "Item Name needs to be at least 2 characters.")]
        [MaxLength(20, ErrorMessage ="Item Name No longer than 20 characters.")]
        public string Item { get; set; }

        //[Required]
        public string Category { get; set; }

        //[Required]
        public string SerialNo { get; set; }

        [DataType(DataType.Date)]
        //[Required]
        public DateTime AcquiredDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime AllocatedDate { get; set; }

        public Boolean InStock { get; set; }

        public string Owner { get; set; }
    }
}
