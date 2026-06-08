

namespace NSF_JSON_Reader.Entities
{
    public class AwardPerson
    {
        public int AwardId { get; set; }
        public Award Award { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
