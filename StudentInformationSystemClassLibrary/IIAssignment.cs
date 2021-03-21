using System;

namespace StudentInformationSystemClassLibrary
{
    public interface IIAssignment
    {
        int Id { get; set; }

        int AssignmentNumber { get; set; }

        string AllowStudentUpload { get; set; }

        DateTime TimeDueDateTime { get; set; }

        string Title { get; set; }

        string AssignmentNickName { get; set; }

        string Comment { get; set; }

        string TeacherInstructions { get; set; }

        DateTime DateAssigned { get; set; }

        DateTime DueDate { get; set; }

        DateTime DisplayOnDateTime { get; set; }

        string Description { get; set; }

        string LearnManagementId { get; set; }

        string Category { get; set; }

        bool Formative { get; set; }

        bool Summative { get; set; }

        int GradeBookNum { get; set; }

        bool Graded { get; set; }

        double AssignmentWeight { get; set; }


        bool GradeByStandards { get; set; }

        bool EasyGraderSetId { get; set; }


        double TotalPointsPossible { get; set; }

        double NumberCorrect { get; set; }
        double Weight { get; set; }

        bool HasRubric { get; set; }

        bool UploadDocuments { get; set; }

        bool VisibleToParents { get; set; }

    }
}