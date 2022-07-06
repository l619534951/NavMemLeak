using System;

namespace NavMemLeak.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
