//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyFastFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        public int Ma { get; set; }
        public int MaKhachHang { get; set; }
        public Nullable<System.DateTime> NgayDatHang { get; set; }
        public Nullable<decimal> PhiGiao { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string ApDungVoucher { get; set; }
        public string ThanhToan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
    }
}
