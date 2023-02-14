using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>
    {
        bool Success { get; }
        T Data { get; }
        string Message { get; }
    }
}
