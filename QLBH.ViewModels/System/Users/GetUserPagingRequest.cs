using QLBH.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}