//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doAnChuyenNghanh02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAMMOI
    {
        public int IDSP { get; set; }
        public string GHICHU { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
