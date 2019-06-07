namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gonderen")]
    public partial class gonderen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gonderen()
        {
            kargoozellik = new HashSet<kargoozellik>();
            kargotakip = new HashSet<kargotakip>();
        }

        [Key]
        public int gid { get; set; }

        [StringLength(50)]
        public string gtc { get; set; }

        [StringLength(50)]
        public string gadi { get; set; }

        [StringLength(50)]
        public string gsoyadi { get; set; }

        [StringLength(50)]
        public string gtelefon { get; set; }

        [StringLength(50)]
        public string gbayi { get; set; }

        [StringLength(50)]
        public string gtarih { get; set; }

        [StringLength(50)]
        public string gadres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kargoozellik> kargoozellik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kargotakip> kargotakip { get; set; }
    }
}
