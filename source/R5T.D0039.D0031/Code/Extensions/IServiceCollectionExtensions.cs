using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0031;

using R5T.Dacia;


namespace R5T.D0039.D0031
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer"/> implementation of <see cref="ILocalRepositoriesWithRemoteUpdatesListConsumer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddTextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer(this IServiceCollection services,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction)
        {
            services
                .AddSingleton<ILocalRepositoriesWithRemoteUpdatesListConsumer, TextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer>()
                .Run(outputFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer"/> implementation of <see cref="ILocalRepositoriesWithRemoteUpdatesListConsumer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalRepositoriesWithRemoteUpdatesListConsumer> AddTextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumerAction(this IServiceCollection services,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<ILocalRepositoriesWithRemoteUpdatesListConsumer>(() => services.AddTextOutputFilePathLocalRepositoriesWithRemoteUpdatesListConsumer(
                outputFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="TextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider"/> implementation of <see cref="ILocalRepositoriesWithRemoteUpdatesListProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddTextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider(this IServiceCollection services,
            IServiceAction<IInputFilePathProvider> inputFilePathProviderAction)
        {
            services
                .AddSingleton<ILocalRepositoriesWithRemoteUpdatesListProvider, TextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider>()
                .Run(inputFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider"/> implementation of <see cref="ILocalRepositoriesWithRemoteUpdatesListProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalRepositoriesWithRemoteUpdatesListProvider> AddTextInputFilePathLocalRepositoriesWithRemoteUpdatesListProviderAction(this IServiceCollection services,
            IServiceAction<IInputFilePathProvider> inputFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<ILocalRepositoriesWithRemoteUpdatesListProvider>(() => services.AddTextInputFilePathLocalRepositoriesWithRemoteUpdatesListProvider(
                inputFilePathProviderAction));

            return serviceAction;
        }
    }
}
