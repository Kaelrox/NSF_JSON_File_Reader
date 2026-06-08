

namespace NSF_JSON_Reader.Entities
{
    public class AwardProgramReference
    {
        public int AwardId { get; set; }
        public Award Award { get; set; }

        public int ProgramReferenceId { get; set; }
        public ProgramReference ProgramReference { get; set; }
    }

}
