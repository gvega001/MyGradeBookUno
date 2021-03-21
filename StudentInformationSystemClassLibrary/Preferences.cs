namespace StudentInformationSystemClassLibrary
{
    public class Preferences: IIPreferences
    {
        public int GradeBookId { get; set; }
        public bool CalculateGradesBeforeCurrentDate { get; set; }

        public bool DisplayPointTotalsWithCalculatedGrades { get; set; }

        public bool DisplayCurrentlyActiveStudents { get; set; }

        public bool TeachersAssistantsInRosters { get; set; }

        public bool DefaultShareComments { get; set; }
        public bool SortAssignmentsAscending { get; set; }
    }
}