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
        public string Item { get; set; }
        public string Category { get; set; }
        public string SerialNo { get; set; }
        [DataType(DataType.Date)]
        public DateTime AcquiredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AllocatedDate { get; set; }
        public Boolean InStock { get; set; }
        public string Owner { get; set; }
    }
}
