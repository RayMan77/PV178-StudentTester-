﻿using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using DAL.Entities;

namespace BL.DTO
{
	public class ThematicAreaDTO
	{
		public int Id { get; set; }
		
		public string Name { get; set; }

		public List<QuestionDTO> Questions { get; set; }

		public List<TestTemplateDTO> Tests { get; set; } 

		public ThematicAreaDTO()
		{
			Questions = new List<QuestionDTO>();
			Tests=new List<TestTemplateDTO>();
		}

		public override bool Equals(object obj)
		{
			var dto = obj as ThematicAreaDTO;
			return dto != null && dto.Name.Equals(Name);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}