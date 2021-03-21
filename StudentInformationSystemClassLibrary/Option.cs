namespace StudentInformationSystemClassLibrary
{
    public class Option:IIOption
    {

        public bool DisplayAssignmentPercentGrade { get; set; }
        public bool DisplayGradeBookMark { get; set; }
        public bool DisplayAssignmentData { get; set; }
        public bool CountMissingAssignmentsTowardsGradeCalc { get; set; }

        enum DisplayGrades
        {
            Decimal, Percentage, Letter
        }
    }
}