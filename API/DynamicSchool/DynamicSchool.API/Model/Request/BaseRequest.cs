using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.API.Model.Request
{
    public class BaseRequest
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public StatusEntityEnum StatusEntity { get; set; }
    }
}
