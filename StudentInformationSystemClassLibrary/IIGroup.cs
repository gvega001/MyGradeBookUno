using System.Xml;
using System;

namespace StudentInformationSystemClassLibrary
{
    public interface IIGroup
    {
        int CategoryId { get; set; }
        string CategoryName { get; set; }

        string GroupName { get; set; }
        int MaxMembership { get; set; }

        bool Available { get; set; }
        string AccountId { get; set; }
        string CourseId { get; set; }
        bool Active { get; set; }
    }
}