using System.Collections.Generic;
using System.Threading.Tasks;

using NavMemLeak.Core.Models;

namespace NavMemLeak.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();
}
