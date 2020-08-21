using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0010;

using R5T.Lombardy;


namespace R5T.D0039.Default
{
    public class SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathsListProvider : ILocalRepositoryDirectoryPathsListProvider
    {
        private ISourceControlRootDirectoryPathProvider SourceControlRootDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathsListProvider(
            ISourceControlRootDirectoryPathProvider sourceControlRootDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.SourceControlRootDirectoryPathProvider = sourceControlRootDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<LocalRepositoryDirectoryPathsList> GetLocalRepositoryDirectoryPathsList()
        {
            var sourceControlRootDirectoryPath = await this.SourceControlRootDirectoryPathProvider.GetSourceControlRootDirectoryPath();

            var repositoryDirectoryPaths = Directory.EnumerateDirectories(sourceControlRootDirectoryPath.Value)
                .Select(x => this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(x))
                .Select(x => LocalRepositoryDirectoryPath.From(x))
                .ToList();

            var localRepositoryDirectoryPathsList = new LocalRepositoryDirectoryPathsList(repositoryDirectoryPaths);
            return localRepositoryDirectoryPathsList;
        }
    }
}
