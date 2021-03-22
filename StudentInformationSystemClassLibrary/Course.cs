using System;

namespace StudentInformationSystemClassLibrary
{
    public class Course:IICourse
    {
        public string CourseId { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string AccountId { get; set; }
        public string TermId { get; set; }
        public bool Active { get; set; }
        public bool CourseDeleted { get; set; }
        public bool Completed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BluePrintCourseId { get; set; }
    }
}