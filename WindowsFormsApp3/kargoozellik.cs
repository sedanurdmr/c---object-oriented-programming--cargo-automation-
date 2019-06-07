namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kargoozellik")]
    public partial class kargoozellik
    {
        [Key]
        public int kid { get; set; }

        [StringLength(50)]
        public string kurun { get; set; }

        [StringLength(50)]
        public string kadet { get; set; }

        [StringLength(50)]
        public string kagirlik { get; set; }

        [StringLength(50)]
        public string kucret { get; set; }

        public int? gid { get; set; }

        public virtual gonderen gonderen { get; set; }
    }
}
