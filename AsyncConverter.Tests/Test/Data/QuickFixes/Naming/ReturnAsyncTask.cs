﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task Test{caret}()
        {
            await Task.Delay(1000);
        }
    }
}
