namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("alici")]
    public partial class alici
    {
        [Key]
        public int aid { get; set; }

        [StringLength(50)]
        public string atc { get; set; }

        [StringLength(50)]
        public string aadi { get; set; }

        [StringLength(50)]
        public string asoyadi { get; set; }

        [StringLength(50)]
        public string atelefon { get; set; }

        [StringLength(50)]
        public string abayi { get; set; }

        [StringLength(50)]
        public string aadres { get; set; }
    }
}
