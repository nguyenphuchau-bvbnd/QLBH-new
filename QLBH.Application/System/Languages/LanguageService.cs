using QLBH.Data.EF;
using QLBH.ViewModels.Common;
using QLBH.ViewModels.System.Languages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        //private readonly IConfiguration _config;
        private readonly QLBHDbContext _context;

        public LanguageService(QLBHDbContext context)//--,
            //IConfiguration config)
        {
            //_config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}