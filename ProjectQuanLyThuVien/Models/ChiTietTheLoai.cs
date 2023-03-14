namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietTheLoai")]
    public partial class ChiTietTheLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietTheLoai()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        public int TheLoai_ID { get; set; }

        [StringLength(100)]
        public string TheLoai_Ten { get; set; }

        [StringLength(100)]
        public string ThongTinTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
