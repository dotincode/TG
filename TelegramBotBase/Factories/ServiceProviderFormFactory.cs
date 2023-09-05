using System;
using Microsoft.Extensions.DependencyInjection;
using TelegramBotBase.Form;
using TelegramBotBase.Interfaces;

namespace TelegramBotBase.Factories
{
    public class ServiceProviderFormFactory : IFormFactory
    {
        private readonly IServiceProvider _provider;

        public ServiceProviderFormFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public TForm CreateForm<TForm>() where TForm : FormBase
        {
            var type = typeof(TForm);
            if (!typeof(FormBase).IsAssignableFrom(type))
                throw new ArgumentException("Form argument must be a FormBase type");
            return (TForm)ActivatorUtilities.CreateInstance(_provider, type);
        }
    }
}