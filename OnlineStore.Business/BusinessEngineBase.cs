using System;
using AutoMapper;
using OnlineStore.Core;
using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Mappings;

namespace OnlineStore.Business
{
    public class BusinessEngineBase
    {
        protected IMapper Mapper;
        protected IConfigurationHelper ConfigurationHelper;
        private readonly ILogger _logger;

        public BusinessEngineBase()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                RequestMessagesToEntities.Map(cfg);
                EntitiesToResponseMessages.Map(cfg);
            });

            Mapper = mapperConfiguration.CreateMapper();
            ConfigurationHelper = DependencyContainer.Resolve<IConfigurationHelper>();
            _logger = (ILogger)DependencyContainer.Resolve(typeof (ILogger));
        }

        protected T ExecuteWithExceptionHandledOperation<T>(Func<T> func)
        {
            try
            {
                var result = func.Invoke();

                return result;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message, ex);
                throw;
            }
        }

        protected void ExecuteWithExceptionHandledOperation(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
