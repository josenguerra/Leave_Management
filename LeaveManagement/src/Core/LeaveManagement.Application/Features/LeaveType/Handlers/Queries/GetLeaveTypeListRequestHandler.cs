﻿using AutoMapper;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Application.Features.LeaveType.Requests.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
