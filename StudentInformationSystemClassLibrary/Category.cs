using Windows.UI;

namespace StudentInformationSystemClassLibrary
{
    public class Category:IICategory
    {
        public int CategoryId { get; set; }
        public Color Color { get; set; }
        public string Description { get; set; }
        public string MarkType { get; set; }
        public decimal Weight { get; set; }
        public decimal PercentOfGrade { get; set; }
        public int CountOfTasks { get; set; }
    }
}