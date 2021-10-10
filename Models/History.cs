using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvenManager.wwwroot.Models;

namespace InvenManager.Models
{
    public class History
    {
        public int ListID { get; set; }
        public int AssetID { get; set; }

        public List<HistoryEntry> Entries { get; set; }

    }

    public class HistoryEntry //the list of what History will be made of.
    {
        public int EntryID { get; set; }
        public DateTime ChangeDate { get; set; }

        public AssetModel assetInformation { get; set; } //change history stored in the Asset object in each entry.

    }
}
