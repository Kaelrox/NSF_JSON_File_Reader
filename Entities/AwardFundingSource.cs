

namespace NSF_JSON_Reader.Entities
{
    public class AwardFundingSource
    {
        public int AwardId { get; set; }
        public Award Award { get; set; }

        public int FundingSourceId { get; set; }
        public PrimaryProgramFundingSource FundingSource { get; set; }
    }
}
