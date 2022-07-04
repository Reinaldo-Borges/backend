using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.Domain.DTO.Course
{
    public class QuestionDTO
    {
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public TypeQuestionEnum TypeQuestion { get; set; }
		public DateTime CreationDate { get; set; }
		public Guid LessonId { get; set; }

	}
}
