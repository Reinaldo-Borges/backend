using DynamicSchool.Core.Enum;
using System;
using System.Collections.Generic;

namespace DynamicSchool.API.Model.Response
{
    public class QuestionResponse
    {
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public TypeQuestionEnum TypeQuestion { get; set; }
		public DateTime CreationDate { get; set; }
		public Guid LessonId { get; set; }
		public List<ResponseResponse> Responses { get; set; }

	}

	public class ResponseResponse
    {
		public Guid ResponseId { get; set; }
		public string ResponseDescription { get; set; }
		public bool IsTrue { get; set; }
		public int NumberOrder { get; set; }
		public string Reason { get; set; }
		public Guid QuestionId { get; set; }

	}
}
