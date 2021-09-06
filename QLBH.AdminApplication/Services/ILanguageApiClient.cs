using QLBH.ViewModels.Common;
using QLBH.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.AdminApplication.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}