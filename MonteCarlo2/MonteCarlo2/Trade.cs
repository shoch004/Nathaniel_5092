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
    
    public partial class Trade
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public string InstrumentType { get; set; }
        public double Price { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Options Option { get; set; }
        public virtual Stocks Stock { get; set; }
    }
}