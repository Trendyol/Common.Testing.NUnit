﻿using System.Threading.Tasks;
using Moq.Language;
using Moq.Language.Flow;

namespace Common.Testing.NUnit
{
    public static class MoqExtensions
    {
        public static IReturnsResult<TMock> ReturnsAsync<TMock, TResult>(
            this IReturns<TMock, Task<TResult>> setup, TResult value)
            where TMock : class
        {
            return setup.Returns(Task.FromResult(value));
        }
    }
}