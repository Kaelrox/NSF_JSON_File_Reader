

namespace NSF_JSON_Reader.Entities
{
    public class AwardInstitution
    {
        public int AwardId { get; set; }
        public Award Award { get; set; }

        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
