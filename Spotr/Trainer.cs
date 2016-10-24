namespace Spotr
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            Workouts = new HashSet<Workout>();
        }

        public int Id { get; set; }

        public double Rating { get; set; }

        [Required]
        public string Specialty { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public int GoalWeight { get; set; }

        public double Height { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Skill { get; set; }

        public int Specialties_Id { get; set; }

        public virtual Specialty Specialty1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
