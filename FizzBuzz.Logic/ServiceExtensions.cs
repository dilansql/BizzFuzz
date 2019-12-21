using FizzBuzz.Common;
using Microsoft.Extensions.DependencyInjection;
using FizzBuzz.Logic;

namespace FizzBuzz.Logic
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddFizzBuzzLogic(this IServiceCollection services)
        {
            services.AddSingleton<IFizzBuzzLogic, FizzBuzzLogic>();
            services.AddSingleton<IOrderListOfNumber, OrderNumberListLogic>();
            services.AddSingleton<IFizzBuzzIterator, FizzBuzzIterator>();


            return services;
        }
    }
}
