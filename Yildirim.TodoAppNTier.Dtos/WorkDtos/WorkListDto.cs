using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yildirim.TodoAppNTier.Dtos.İnterfaces;

namespace Yildirim.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkListDto :IDto
    {
            public int Id { get; set; }
            public string Definition { get; set; }
            public bool IsCompeleted { get; set; }
        
    }
}
