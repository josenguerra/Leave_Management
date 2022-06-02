using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Application.DTOs.LeaveAllocation
{
    public interface ILeaveAllocationDto
    {
        public int LeaveTypeId { get; set; }
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
    }
}
