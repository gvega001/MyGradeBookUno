

using System;

namespace StudentInformationSystemClassLibrary
{
    public interface IICourse
    {
        string CourseId { get; set; }
        string ShortName { get; set; }
        string LongName { get; set; }
        string AccountId { get; set; }
        string TermId { get; set; }
        bool Active { get; set; }
        bool CourseDeleted { get; set; }
        bool Completed { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string BluePrintCourseId { get; set; }
    }
}