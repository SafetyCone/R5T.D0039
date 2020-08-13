using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using R5T.D0031;
using R5T.T0010;


namespace R5T.D0039.D0031
{
    public class TextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider : ILocalRepositoriesWithRemoteUpdatesListProvider
    {
        private IInputFilePathProvider InputFilePathProvider { get; }


        public TextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider(IInputFilePathProvider inputFilePathProvider)
        {
            this.InputFilePathProvider = inputFilePathProvider;
        }

        public async Task<LocalRepositoriesWithRemoteUpdatesList> GetLocalRepositoriesWithRemoteUpdatesList()
        {
            var inputFilePath = await this.InputFilePathProvider.GetInputFilePath();

            var lines = File.ReadAllLines(inputFilePath);

            var output = new LocalRepositoriesWithRemoteUpdatesList();

            var localRepositoryDirectoryPaths = lines
                .Select(x => LocalRepositoryDirectoryPath.From(x));

            output.LocalRepositoryDirectoryPaths.AddRange(localRepositoryDirectoryPaths);

            return output;
        }
    }
}
