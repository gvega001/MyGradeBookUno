using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInformationSystemClassLibrary
{
    public class Assignment :IIAssignment
    {
        public int Id { get; set; }

        public int AssignmentNumber { get; set; }

        public string AllowStudentUpload { get; set; }

        public DateTime TimeDueDateTime { get; set; }

        public string Title { get; set; }

        public string AssignmentNickName { get; set; }

        public string Comment { get; set; }

        public string TeacherInstructions { get; set; }

        public DateTime DateAssigned { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime DisplayOnDateTime { get; set; }

        public string Description { get; set; }

        public string LearnManagementId { get; set; }

        public string Category { get; set; }

        public bool Formative { get; set; }

        public bool Summative { get; set; }

        public int GradeBookNum { get; set; }

        public bool Graded { get; set; }

        public double AssignmentWeight { get; set; }


        public bool GradeByStandards { get; set; }

        public bool EasyGraderSetId { get; set; }


        public double TotalPointsPossible { get; set; }

        public double NumberCorrect { get; set; }
        public double Weight { get; set; }

        public bool HasRubric { get; set; }

        public bool UploadDocuments { get; set; }

        public bool VisibleToParents { get; set; }
    }
}
