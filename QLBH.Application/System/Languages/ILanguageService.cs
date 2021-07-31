using QLBH.ViewModels.Common;
using QLBH.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLBH.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}