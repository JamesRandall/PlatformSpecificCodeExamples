using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public class BasicDomainImplementation
    {
        private readonly IFileWriter _fileWriter;

        public BasicDomainImplementation(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public async Task WriteBytes()
        {
            await _fileWriter.Write("somebytes.txt", Encoding.UTF8.GetBytes("Hello World"));
        }
    }
}
