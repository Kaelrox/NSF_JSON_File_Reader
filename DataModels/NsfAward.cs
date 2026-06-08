
public class NsfAward
{
    public string awardNumber { get; set; }
    public string agencyId { get; set; }
    public string tranType { get; set; }
    public string orgCode { get; set; }
    public string cdfaNumber    { get; set; }
    public string title { get; set; }
    public string awardInstrumentText { get; set; }
    public decimal intendedAmount { get; set; }
    public decimal awardAmount { get; set; }
    public DateTime startDate { get; set; }
    public DateTime? endDate { get; set; } 
    public string abstractNarration { get; set; }
    public Person programManager    { get; set; }
    public string awardeeName { get; set; }
    public string awardeeStateCode { get; set; }
    public List<ProgramElement> programElements { get; set; }
    public List<ProgramReference> programReferences { get; set; }
    public string directorateAbbreviation { get; set; }
    public string orgDirectorateLongName { get; set; }
    public string divisionAbbreviation { get; set; }
    public string orgDivisionLongName { get; set; }
    public string awdAgcyCode { get; set; }
    public string fundAgcyCode { get; set; }
    public string projectOutcomesReport { get; set; }
    public List<Person> investigators { get; set; }
    public List<FinancialObligationYear> financialObligations { get; set; }
    public List<PrimaryProgramFundingSource> appFundSources { get; set; }
    public Institution institution { get; set; }
    public Institution perfInstitution { get; set; }
}

