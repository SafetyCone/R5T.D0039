using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using R5T.D0031;
using R5T.T0010;using R5T.T0064;


namespace R5T.D0039.D0031
{[ServiceImplementationMarker]
    public class TextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer : ILocalRepositoriesWithRemoteUpdatesListConsumer,IServiceImplementation
    {
        private IOutputFilePathProvider OutputFilePathProvider { get; }


        public TextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer(IOutputFilePathProvider outputFilePathProvider)
        {
            this.OutputFilePathProvider = outputFilePathProvider;
        }

        public async Task ConsumeLocalRepositoriesWithRemoteUpdatesList(LocalRepositoriesWithRemoteUpdatesList localRepositoriesWithRemoteUpdatesList)
        {
            var outputFilePath = await this.OutputFilePathProvider.GetOutputFilePath();

            var lines = localRepositoriesWithRemoteUpdatesList.LocalRepositoryDirectoryPaths
                .Select(x => x.Value);

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
