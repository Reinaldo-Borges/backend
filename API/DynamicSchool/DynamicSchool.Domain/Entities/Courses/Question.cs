using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Core.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Question : Entity
    {
      
        public string Code { get; private set; }
        public string Description { get; private set; }
        public TypeQuestionEnum TypeQuestion { get; private set; }
        public Guid LessonId { get; private set; }

        private List<ResponseQuestion> _responses;
        public ReadOnlyCollection<ResponseQuestion> Responses { get {return _responses?.AsReadOnly(); }}

        public Question(string description, TypeQuestionEnum typeQuestion, Guid lessonId)
        {
            Description = description;
            TypeQuestion = typeQuestion;
            LessonId = lessonId;
        }

        public Question SetResponse(ResponseQuestion response)
        {
            this._responses = null ?? new List<ResponseQuestion>();
            this._responses.Add(response);

            return this;
        }

        public Question SetResponse(List<ResponseQuestion> response)
        {
            this._responses = null ?? new List<ResponseQuestion>();
            this._responses.AddRange(response);

            return this;
        }
    }
}
