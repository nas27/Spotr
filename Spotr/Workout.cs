namespace Spotr
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workout()
        {
            Exercises = new HashSet<Exercis>();
        }

        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public int User_Id { get; set; }

        public int Trainer_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercis> Exercises { get; set; }

        public virtual Trainer Trainer { get; set; }

        public virtual User User { get; set; }
    }
}
