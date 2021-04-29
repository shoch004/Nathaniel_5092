//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonteCarlo2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Options
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Options()
        {
            this.Trades = new HashSet<Trade>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public byte[] isCall { get; set; }
        public double Strike { get; set; }
        public int StockID { get; set; }
        public double Expiration { get; set; }
        public Nullable<double> Rebate { get; set; }
        public Nullable<double> Barrier { get; set; }
        public int TBillId { get; set; }
    
        public virtual Stocks Stock { get; set; }
        public virtual TBill TBill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trade> Trades { get; set; }
    }
}
