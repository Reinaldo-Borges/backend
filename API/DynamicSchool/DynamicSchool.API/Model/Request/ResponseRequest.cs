using System;

namespace DynamicSchool.API.Model.Request
{
    public class ResponseRequest : BaseRequest
    {
        public string Description { get; set; }

        public bool IsTrue { get; set; }

        public int? Order { get; set; }

        public string Reason { get; set; }

        public Guid QuestionId { get; set; }
    }
}
