

namespace NSF_JSON_Reader.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProgramReference
    {
        [Key]
        public int ProgramReferenceId { get; set; }

        [MaxLength(50)]
        public string ProgramReferenceCode { get; set; }

        [MaxLength(100)]
        public string ProgramReferenceName { get; set; }


        public virtual ICollection<AwardProgramReference> AwardProgramReferences { get; set; } = new List<AwardProgramReference>();
    }

}
