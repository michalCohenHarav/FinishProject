//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            this.StockDetails = new HashSet<StockDetail>();
        }
    
        public int ModeID { get; set; }
        public string CompName { get; set; }
        public Nullable<int> CompID { get; set; }
        public Nullable<double> PriceBuy { get; set; }
        public Nullable<int> MatchId { get; set; }
        public Nullable<bool> WaterSafe { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Matche Matche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDetail> StockDetails { get; set; }
    }
}
