using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public interface IFileWriter
    {
        Task Write(string filename, byte[] bytes);
    }
}
