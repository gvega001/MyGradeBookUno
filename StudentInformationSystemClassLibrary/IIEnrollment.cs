using System;

namespace StudentInformationSystemClassLibrary
{
    public interface IIEnrollment
    {
        string EnrollmentId { get; set; }
        string RootAccount { get; set; }
        DateTime StartDateTime { get; set; }
        DateTime EndDateTime { get; set; }
        string UserId { get; set; }
        string UserIntegrationId { get; set; }
        string RoleId { get; set; }
        string SectionId { get; set; }
        bool Active { get; set; }
        bool EnrollmentCompleted { get; set; }
        string AssociatedUserId { get; set; }
        bool LimitSectionPrivileges { get; set; }
    }
}