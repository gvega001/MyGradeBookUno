using System;

namespace StudentInformationSystemClassLibrary
{
    public class Enrollment:IIEnrollment
    {
        public string EnrollmentId { get; set; }
        public string RootAccount { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string UserId { get; set; }
        public string UserIntegrationId { get; set; }
        public string RoleId { get; set; }
        public string SectionId { get; set; }
        public bool Active { get; set; }
        public bool EnrollmentCompleted { get; set; }
        public string AssociatedUserId { get; set; }
        public bool LimitSectionPrivileges { get; set; }
    }
}