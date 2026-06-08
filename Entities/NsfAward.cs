


namespace NSF_JSON_Reader.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /*Note: The NSF Schema  has proven to be more  aspirational rather than authoritative.
            This means many of the field  described as required in the schema often come
            up as null in the actual json. This  causes issues with EF retrieval especially.
            As a stop gap measure many fields are nullable strings*/
    public class Award
    {
        [Key]
        public int AwardId { get; set; }

        [Required]
        [MaxLength(50)]
        public string NSFAwdId { get; set; }

        [MaxLength(10)]
        public string? AgencyId { get; set; }

        [MaxLength(10)]
        public string? TranType { get; set; }

        [MaxLength(10)]
        public string? OrgCode { get; set; }

        [MaxLength(1000)]
        public string? CfdaNumber { get; set; }

        [MaxLength(500)]
        public string? Title { get; set; }

        [MaxLength(100)]
        public string? AwardInstrumentText { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal IntendedAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AwardAmount { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string? AbstractNarration { get; set; }

        [MaxLength(20)]
        public string? DirectorateAbbreviation { get; set; }

        [MaxLength(200)]
        public string? OrgDirectorateLongName { get; set; }

        [MaxLength(20)]
        public string? DivisionAbbreviation { get; set; }

        [MaxLength(200)]
        public string? OrgDivisionLongName { get; set; }

        [MaxLength(10)]
        public string? AwdAgcyCode { get; set; }

        [MaxLength(10)]
        public string? FundAgcyCode { get; set; }

        public string? ProjectOutcomesReport { get; set; }

        [MaxLength(200)]
        public string? AwardeeName { get; set; }

        [MaxLength(10)]
        public string? AwardeeStateCode { get; set; }

       // public virtual ICollection<ProgramElement> ProgramElements { get; set; }
       // public virtual ICollection<ProgramReference> ProgramReferences { get; set; }
       // public virtual ICollection<Person> Investigators { get; set; }
        public virtual ICollection<FinancialObligationYear> FinancialObligations { get; set; }
        //public virtual ICollection<PrimaryProgramFundingSource> AppFundSources { get; set; }

        public virtual ICollection<AwardInstitution> AwardInstitutions { get; set; }
        public virtual ICollection<AwardPerson> AwardPersons { get; set; }
        public virtual ICollection<AwardProgramElement> AwardProgramElements { get; set; }
        public virtual ICollection<AwardProgramReference> AwardProgramReferences { get; set; }
        public virtual ICollection<AwardFundingSource> AwardFundingSources { get; set; }


        public int? InstitutionId { get; set; }
        [ForeignKey("InstitutionId")]
        public virtual Institution Institution { get; set; }

        public int? PerfInstitutionId { get; set; }
        [ForeignKey("PerfInstitutionId")]
        public virtual Institution PerfInstitution { get; set; }

        public int? ProgramManagerId { get; set; }
        [ForeignKey("ProgramManagerId")]
        public virtual Person ProgramManager { get; set; }
    }
}
