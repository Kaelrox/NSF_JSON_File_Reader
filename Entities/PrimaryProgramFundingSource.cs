

namespace NSF_JSON_Reader.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PrimaryProgramFundingSource
    {
        [Key]
        public int FundingSourceId { get; set; }

        [MaxLength(50)]
        public string ApplicationCode { get; set; }

        [MaxLength(100)]
        public string ApplicationName { get; set; }

        [MaxLength(50)]
        public string ApplicationSymbId { get; set; }

        [MaxLength(50)]
        public string FundingCode { get; set; }

        [MaxLength(100)]
        public string FundingName { get; set; }

        [MaxLength(50)]
        public string FundingSymbId { get; set; }


        public virtual ICollection<AwardFundingSource> AwardFundingSources { get; set; } = new List<AwardFundingSource>();

    }

}
