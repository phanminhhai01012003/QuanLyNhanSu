//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.CapNhatTrinhDoHocVans = new HashSet<CapNhatTrinhDoHocVan>();
            this.LuanChuyenNhanViens = new HashSet<LuanChuyenNhanVien>();
        }
    
        public string MaNhanVien { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string sdt_NhanVien { get; set; }
        public string MaChucVuNV { get; set; }
        public bool TrangThai { get; set; }
        public string MaPhongBan { get; set; }
        public string MaHopDong { get; set; }
        public string MaChuyenNganh { get; set; }
        public string MaTrinhDoHocVan { get; set; }
        public string CMND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapNhatTrinhDoHocVan> CapNhatTrinhDoHocVans { get; set; }
        public virtual ChucVuNhanVien ChucVuNhanVien { get; set; }
        public virtual ChuyenNganh ChuyenNganh { get; set; }
        public virtual HopDong HopDong { get; set; }
        public virtual KyLuat KyLuat { get; set; }
        public virtual KhenThuong KhenThuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuanChuyenNhanVien> LuanChuyenNhanViens { get; set; }
        public virtual Luong Luong { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual ThoiViec ThoiViec { get; set; }
        public virtual TrinhDoHocVan TrinhDoHocVan { get; set; }
    }
}
