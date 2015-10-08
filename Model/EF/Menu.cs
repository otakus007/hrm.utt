namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string Name { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        [StringLength(50)]
        public string CssClass { get; set; }
    }
}
