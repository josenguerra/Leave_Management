using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Application.Responses;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
