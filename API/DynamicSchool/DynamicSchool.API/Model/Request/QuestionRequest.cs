using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.API.Model.Request
{
    public class QuestionRequest : BaseRequest
    {
        public string Code { get;  set; }
        public string Description { get;  set; }
        public int TypeQuestion { get;  set; }
        public Guid LessonId { get;  set; }
    }
}
