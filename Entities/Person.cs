

namespace NSF_JSON_Reader.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string MidInit { get; set; }

        [MaxLength(10)]
        public string SufxName { get; set; }

        [MaxLength(150)]
        public string FullName { get; set; }

        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(20)]
        public string NsfId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<AwardPerson> AwardPersons { get; set; } = new List<AwardPerson>();
    }

}
