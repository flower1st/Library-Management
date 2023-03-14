namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuatThuVien")]
    public partial class LuatThuVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LuatThuVien()
        {
            PhieuPhats = new HashSet<PhieuPhat>();
        }

        [Key]
        [StringLength(10)]
        public string LuatThuVien_ID { get; set; }

        [StringLength(200)]
        public string ThongTinDieuLuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuPhat> PhieuPhats { get; set; }
    }
}
