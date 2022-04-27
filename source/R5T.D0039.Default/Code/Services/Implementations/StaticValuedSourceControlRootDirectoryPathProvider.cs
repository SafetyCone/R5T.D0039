using System;
using System.Threading.Tasks;

using R5T.T0010;using R5T.T0064;


namespace R5T.D0039.Default
{[ServiceImplementationMarker]
    public class StaticValuedSourceControlRootDirectoryPathProvider : ISourceControlRootDirectoryPathProvider,IServiceImplementation
    {
        public static SourceControlRootDirectoryPath SourceControlRootDirectoryPath { get; set; }


        public Task<SourceControlRootDirectoryPath> GetSourceControlRootDirectoryPath()
        {
            return Task.FromResult(StaticValuedSourceControlRootDirectoryPathProvider.SourceControlRootDirectoryPath);
        }
    }
}
