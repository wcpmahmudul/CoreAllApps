using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.WebApi.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
