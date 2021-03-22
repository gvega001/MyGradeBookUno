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
      
    }
}