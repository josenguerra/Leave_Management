using LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
