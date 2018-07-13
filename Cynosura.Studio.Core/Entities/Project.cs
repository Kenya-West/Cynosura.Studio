using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cynosura.Studio.Core.Entities
{
    public class Project : BaseEntity
    {
        public int Id { get; set; }
		[Required()]
		[StringLength(50)]
		public string Name { get; set; }
		[Required()]
		[StringLength(200)]
		public string Path { get; set; }
    }
}
