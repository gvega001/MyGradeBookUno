namespace StudentInformationSystemClassLibrary
{
    public class GradeBook: IIGradeBook
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public string EndDateTime { get; set; }

        public string StartDateTime { get; set; }

        public int GradeBookNumber { get; set; }

        public int LinkedGroup { get; set; }

        public string Name { get; set; }

        public int Period { get; set; }

        public int SchoolCode { get; set; }

        public string EducatorEmailAddress { get; set; }

        public string EducatorName { get; set; }

        public int EducatorNumber { get; set; }
    }
}