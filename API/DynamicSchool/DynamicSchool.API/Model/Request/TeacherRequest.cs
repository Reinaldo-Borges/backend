using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.API.Model.Request
{
    public class TeacherRequest
    {
        public Guid Id { get;  set; }
        public DateTime CreationDate { get;  set; }
        public StatusEntityEnum StatusEntity { get; set; }
        public string Name { get;  set; }
        public string Document { get;  set; }
        public string Email { get;  set; }
        public string CellPhone { get;  set; }
        public DateTime BirthDay { get;  set; }
        public string Resume { get;  set; }
        public Guid ClientOrigin { get;  set; }
    }
}
