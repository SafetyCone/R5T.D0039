using System;
using System.Threading.Tasks;

using R5T.T0010;
using R5T.T0064;


namespace R5T.D0039
{
    [ServiceDefinitionMarker]
    public interface ILocalRepositoriesWithRemoteUpdatesListConsumer : IServiceDefinition
    {
        Task ConsumeLocalRepositoriesWithRemoteUpdatesList(LocalRepositoriesWithRemoteUpdatesList localRepositoriesWithRemoteUpdatesList);
    }
}
