using AutoMapper;
using LeaveManagement.Application.DTOs.LeaveAllocation;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region LeaveRequest Mappings
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            #endregion LeaveRequest

            #region Leave Allocation Mappings
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            #endregion

            #region Leave Type Mappings
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap(); 
            #endregion
        }
    }
}
