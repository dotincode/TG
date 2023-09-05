﻿using System;
using TelegramBotBase.Form;

namespace TelegramBotBase.Factories
{
    public class DefaultStartFormFactory : Interfaces.IStartFormFactory
    {
        private readonly Type _startFormClass;

        public DefaultStartFormFactory(Type startFormClass)
        {
            if (!typeof(FormBase).IsAssignableFrom(startFormClass))
                throw new ArgumentException("startFormClass argument must be a FormBase type");

            _startFormClass = startFormClass;
        }


        public FormBase CreateForm()
        {
            return _startFormClass.GetConstructor(new Type[] { })?.Invoke(new object[] { }) as FormBase;
        }

        public TForm CreateForm<TForm>() where TForm : FormBase
        {
            throw new NotImplementedException();
        }
    }
}
