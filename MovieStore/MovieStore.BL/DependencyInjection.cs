using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.DL.Interfaces;

namespace MovieStore.BL
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            DependencyInjection.RegisterRepositories();

            services.AddSingleton<IMovieService, MovieService>();
        }
    }
}
