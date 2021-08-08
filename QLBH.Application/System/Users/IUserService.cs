using QLBH.ViewModels.Common;
using QLBH.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Application.System.Users
{
    public interface IUserService
    {
        //Task<string> Authencate(LoginRequest request);
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        //Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        //Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);

        //Task<ApiResult<UserVm>> GetById(Guid id);

        //Task<ApiResult<bool>> Delete(Guid id);

        //Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}