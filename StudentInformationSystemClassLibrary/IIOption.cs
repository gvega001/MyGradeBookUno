namespace StudentInformationSystemClassLibrary
{
    public interface IIOption
    {
        bool DisplayAssignmentPercentGrade { get; set; }
        bool DisplayGradeBookMark { get; set; }
        bool DisplayAssignmentData { get; set; }
        bool CountMissingAssignmentsTowardsGradeCalc { get; set; }

    }
}