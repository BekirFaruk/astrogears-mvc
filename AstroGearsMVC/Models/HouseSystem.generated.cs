//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AstroGearsMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HouseSystem
    {
        public HouseSystem()
        {
            this.ChartHouses = new HashSet<ChartHouse>();
            this.RelocatedChartHouses = new HashSet<RelocatedChartHous>();
        }
    
        public byte HouseSystemId { get; set; }
        public string HouseSystemName { get; set; }
    
        public virtual ICollection<ChartHouse> ChartHouses { get; set; }
        public virtual ICollection<RelocatedChartHous> RelocatedChartHouses { get; set; }
    }
}
