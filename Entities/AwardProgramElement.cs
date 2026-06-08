

namespace NSF_JSON_Reader.Entities
{
    public class AwardProgramElement
    {
        public int AwardId { get; set; }
        public Award Award { get; set; }

        public int ProgramElementId { get; set; }
        public ProgramElement ProgramElement { get; set; }
    }
}
