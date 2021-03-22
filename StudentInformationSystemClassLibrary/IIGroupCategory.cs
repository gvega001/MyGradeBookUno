namespace StudentInformationSystemClassLibrary
{
    public interface IIGroupCategory
    {
        string GroupCategoryId { get; set; }
        string AccountId { get; set; }
        string CourseId { get; set; }
        bool Active { get; set; }
        string CategoryName { get; set; }
    }
}