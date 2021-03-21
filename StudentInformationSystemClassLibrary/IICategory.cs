using Windows.UI;

namespace StudentInformationSystemClassLibrary
{
    public interface IICategory
    {
        int CategoryId { get; set; }
        Color Color { get; set; }
        string Description { get; set; }
        string MarkType { get; set; }
        decimal Weight { get; set; }
        decimal PercentOfGrade { get; set; }
        int CountOfTasks { get; set; }
    }
}