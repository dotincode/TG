using TelegramBotBase.Form;

namespace TelegramBotBase.Interfaces
{
    public interface IFormFactory
    {
        TForm CreateForm<TForm>()
            where TForm : FormBase;
    }
}