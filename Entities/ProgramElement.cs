

namespace NSF_JSON_Reader.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProgramElement
    {
        [Key]
        public int ProgramElementId { get; set; }

        [MaxLength(50)]
        public string ProgramElementCode { get; set; }

        [MaxLength(100)]
        public string ProgramElementName { get; set; }

        public virtual ICollection<AwardProgramElement> AwardProgramElements { get; set; } = new List<AwardProgramElement>();


    }

}
