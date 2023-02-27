using System.Threading;
using System.Threading.Tasks;

namespace EtoZhePackageOpenAI.Abstractions
{
    public interface IOpenAIHandler
    {
        Task<string> HandleOpenAIRequest(string question, CancellationToken cancellationToken);
    }
}
