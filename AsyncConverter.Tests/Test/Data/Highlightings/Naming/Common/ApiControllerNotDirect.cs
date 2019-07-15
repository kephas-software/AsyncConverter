﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    using System.Web.Http;
    public class ClassBase : ApiController
    {
        public async Task Test()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
    }

    public class Class : ClassBase
    {
        public async Task Test2()
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