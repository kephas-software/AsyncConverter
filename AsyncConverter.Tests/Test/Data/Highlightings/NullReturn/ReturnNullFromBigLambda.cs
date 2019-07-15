﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public void Test()
        {
            Test2(() =>
                  {
                      Test();
                      return null;
                  });
        }

        public void Test2(Func<Task> func)
        {
            func().Wait();
        }
    }
}
