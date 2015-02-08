using System;
using System.Threading.Tasks;
using Windows.Storage;
using DependencyInjection.Domain;

namespace DependencyInjection.WindowsStore
{
    internal class FileWriterImpl : IFileWriter
    {
        public async Task Write(string filename, byte[] bytes)
        {
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename);
            await FileIO.WriteBytesAsync(file, bytes);
        }
    }
}
