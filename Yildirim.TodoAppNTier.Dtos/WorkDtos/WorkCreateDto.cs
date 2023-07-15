using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yildirim.TodoAppNTier.Dtos.İnterfaces;

namespace Yildirim.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto :IDto
    {
        //[Required(ErrorMessage ="Definition is requried")]
        public string Definition { get; set; }
        public bool IsCompeleted { get; set; }
    }
}
