﻿using LeaveManagement.Application.Models;

namespace LeaveManagement.Application.Contracts.Infrastrucutre
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
