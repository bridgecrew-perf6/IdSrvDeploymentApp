using System;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;

namespace IdSrvDeploymentApp.Shared.Config
{
    public static class AutoMapperConfig
    {
        public static IMapper ConfigureAutoMapper(Action<IMapperConfigurationExpression> externalConfig = null)
        {
            var config = new MapperConfiguration(cfg =>
            {
                externalConfig?.Invoke(cfg);
            });

            return new Mapper(config);
        }
    }
}
