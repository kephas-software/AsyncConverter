﻿using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public Task Main(string[] args)
        {
            return Task.CompletedTask;
        }
    }
}
