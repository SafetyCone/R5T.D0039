using System;
using System.Threading.Tasks;

using R5T.T0010;


namespace R5T.D0039.Default
{
    public class StaticValuedSourceControlRootDirectoryPathProvider : ISourceControlRootDirectoryPathProvider
    {
        public static SourceControlRootDirectoryPath SourceControlRootDirectoryPath { get; set; }


        public Task<SourceControlRootDirectoryPath> GetSourceControlRootDirectoryPath()
        {
            return Task.FromResult(StaticValuedSourceControlRootDirectoryPathProvider.SourceControlRootDirectoryPath);
        }
    }
}
