using DynamicSchool.Core.DomainObjects;
using System;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class ResponseQuestion : Entity
    {       
        public string Description { get; private set; }

        public bool IsTrue { get; private set;  }

        public int? Order { get; private set; }

        public string Reason { get; private set; }

        public Guid QuestionId  { get; private set; }

        public ResponseQuestion(string description, bool isTrue, Guid questionId)
        {            
            Description = description;
            IsTrue = isTrue;
            QuestionId = questionId;
        }

        public ResponseQuestion SetDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public ResponseQuestion SetReason(string reason)
        {
            this.Reason = reason;
            return this;
        }

        public ResponseQuestion SetOrder(int? order)
        {
            this.Order = order;
            return this;
        }
    }
}
