using System.Threading.Tasks;

namespace NavMemLeak.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
