using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class Hold
    {
        public int Id { get; set; }
        public virtual LibraryAsset GetLibraryAsset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}
