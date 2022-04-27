using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0010;using R5T.T0064;


namespace R5T.D0039.Default
{[ServiceImplementationMarker]
    public class SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathProvider : ILocalRepositoryDirectoryPathsProvider,IServiceImplementation
    {
        private ISourceControlRootDirectoryPathProvider SourceControlRootDirectoryPathProvider { get; }


        public SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathProvider(
            ISourceControlRootDirectoryPathProvider sourceControlRootDirectoryPathProvider)
        {
            this.SourceControlRootDirectoryPathProvider = sourceControlRootDirectoryPathProvider;
        }

        public async Task<List<LocalRepositoryDirectoryPath>> GetLocalRepositoryDirectoryPaths()
        {
            var sourceControlRootDirectoryPath = await this.SourceControlRootDirectoryPathProvider.GetSourceControlRootDirectoryPath();

            var repositoryDirectoryPaths = Directory.EnumerateDirectories(sourceControlRootDirectoryPath.Value)
                .Select(x => LocalRepositoryDirectoryPath.From(x))
                .ToList();

            return repositoryDirectoryPaths;
        }
    }
}
