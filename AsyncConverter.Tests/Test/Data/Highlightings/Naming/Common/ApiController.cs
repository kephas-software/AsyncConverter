﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    using System.Web.Http;
    public class Class : ApiController
    {
        public async Task Test()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
    }
}

namespace System.Web.Http
{
    public class ApiController
    { }
}