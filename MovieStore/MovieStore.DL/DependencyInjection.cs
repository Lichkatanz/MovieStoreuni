using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore.DL
{
    public static class DependencyInjection
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IMovieRepository, MovieRepository>();
        }
    }
}
