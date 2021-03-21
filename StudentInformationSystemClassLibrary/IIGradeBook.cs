namespace StudentInformationSystemClassLibrary
{
    public interface IIGradeBook
    {
        int Id { get; set; }

        string Comment { get; set; }

        string EndDateTime { get; set; }

        string StartDateTime { get; set; }

        int GradeBookNumber { get; set; }

        int LinkedGroup { get; set; }

        string Name { get; set; }

        int Period { get; set; }

        int SchoolCode { get; set; }

        string EducatorEmailAddress { get; set; }

        string EducatorName { get; set; }

        int EducatorNumber { get; set; }

    }
}