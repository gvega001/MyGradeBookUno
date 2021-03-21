namespace StudentInformationSystemClassLibrary
{
    public interface IIPreferences
    {
        int GradeBookId { get; set; }

        bool CalculateGradesBeforeCurrentDate { get; set; }

        bool DisplayPointTotalsWithCalculatedGrades { get; set; }

        bool DisplayCurrentlyActiveStudents { get; set; }

        bool TeachersAssistantsInRosters { get; set; }

        bool DefaultShareComments { get; set; } 

        bool SortAssignmentsAscending { get; set; }
    }
}