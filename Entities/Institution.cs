
namespace NSF_JSON_Reader.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Institution
    {
        [Key]
        public int InstitutionId { get; set; }

        [MaxLength(200)]
        public string InstitutionName { get; set; }

        [MaxLength(200)]
        public string StreetAddress { get; set; }

        [MaxLength(200)]
        public string StreetAddress2 { get; set; }

        [MaxLength(100)]
        public string CityName { get; set; }

        [MaxLength(10)]
        public string StateCode { get; set; }

        [MaxLength(100)]
        public string StateName { get; set; }

        [MaxLength(20)]
        public string PhoneNum { get; set; }

        [MaxLength(20)]
        public string ZipCode { get; set; }

        [MaxLength(100)]
        public string CountryName { get; set; }

        [MaxLength(20)]
        public string CongressionalDistrictCode { get; set; }

        [MaxLength(20)]
        public string StateCongressionalDistCode { get; set; }

        [MaxLength(100)]
        public string? PerformanceCountryName { get; set; }

        [MaxLength(10)]
        public string? PerformanceCountryFlag { get; set; }

        [MaxLength(100)]
        [Required]
        public string UeiNumber { get; set; }

        [MaxLength(100)]
        public string ParentUeiNumber { get; set; }

        public virtual ICollection<AwardInstitution> AwardInstitutions { get; set; } = new List<AwardInstitution>();
    }




}
