namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kullanici")]
    public partial class kullanici
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kullaniciid { get; set; }

        [StringLength(50)]
        public string kadi { get; set; }

        [StringLength(50)]
        public string ksifre { get; set; }
    }
}
