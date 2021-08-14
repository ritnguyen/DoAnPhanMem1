namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string pass { get; set; }

        [Required]
        [StringLength(50)]
        public string typeUser { get; set; }
    }
}
