namespace StudentInformationSystemClassLibrary
{
    public class Group:IIGroup
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string GroupName { get; set; }
        public int MaxMembership { get; set; }

        public bool Available { get; set; }
    }
}