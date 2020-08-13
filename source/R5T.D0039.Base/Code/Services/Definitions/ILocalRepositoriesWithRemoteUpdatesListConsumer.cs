using System;
using System.Threading.Tasks;

using R5T.T0010;


namespace R5T.D0039
{
    public interface ILocalRepositoriesWithRemoteUpdatesListConsumer
    {
        Task ConsumeLocalRepositoriesWithRemoteUpdatesList(LocalRepositoriesWithRemoteUpdatesList localRepositoriesWithRemoteUpdatesList);
    }
}
