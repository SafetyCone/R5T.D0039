using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0039.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValuedSourceControlRootDirectoryPathProvider"/> implementation of <see cref="ISourceControlRootDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedSourceControlRootDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<ISourceControlRootDirectoryPathProvider, StaticValuedSourceControlRootDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedSourceControlRootDirectoryPathProvider"/> implementation of <see cref="ISourceControlRootDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISourceControlRootDirectoryPathProvider> AddStaticValuedSourceControlRootDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ISourceControlRootDirectoryPathProvider>(() => services.AddStaticValuedSourceControlRootDirectoryPathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathProvider"/> implementation of <see cref="ILocalRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathsProvider(this IServiceCollection services,
            IServiceAction<ISourceControlRootDirectoryPathProvider> sourceControlRootDirectoryPathProviderAction)
        {
            services
                .AddSingleton<ILocalRepositoryDirectoryPathsProvider, SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathProvider>()
                .Run(sourceControlRootDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathProvider"/> implementation of <see cref="ILocalRepositoryDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalRepositoryDirectoryPathsProvider> AddSourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathsProviderAction(this IServiceCollection services,
            IServiceAction<ISourceControlRootDirectoryPathProvider> sourceControlRootDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<ILocalRepositoryDirectoryPathsProvider>(() => services.AddSourceControlRootDirectorySubDirectoriesLocalRepositoryDirectoryPathsProvider(
                sourceControlRootDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
