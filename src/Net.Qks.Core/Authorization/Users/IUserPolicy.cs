﻿using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Net.Qks.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
