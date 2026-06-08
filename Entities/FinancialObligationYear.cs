

namespace NSF_JSON_Reader.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class FinancialObligationYear
    {
        [Key]
        public int ObligationId { get; set; }

        public int FiscalYear { get; set; }

        public double ObligatedAmount { get; set; }

        public int AwardId { get; set; }

        [ForeignKey("AwardId")]
        public virtual Award Award { get; set; }
    }

}
