using System;

namespace DynamicSchool.Domain.DTO.Course
{
    public class ResponseDTO
    {	
		public Guid Id { get; set; }
		public string Description { get; set; }
		public bool IsTrue { get; set; }
		public int NumberOrder { get; set; }
		public string Reason { get; set; }
		public DateTime CreationDate { get; set; }
		public Guid QuestionId { get; set; }
	}
}
