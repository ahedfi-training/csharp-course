namespace CodeFirstWithExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserProfileID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
