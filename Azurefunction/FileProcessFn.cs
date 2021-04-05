using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Azurefunction
{
    public static class FileProcessFn
    {
        [FunctionName("FileProcessFn")]
        public static void Run([BlobTrigger("import/{name}", Connection = "ConnectionStrings:AzureWebJobsStorage")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
