using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0010;


namespace R5T.D0039
{
    public interface ILocalRepositoryDirectoryPathsProvider
    {
        Task<List<LocalRepositoryDirectoryPath>> GetLocalRepositoryDirectoryPaths();
    }
}
