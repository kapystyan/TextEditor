namespace TextEditor
{
	/// <summary>
	/// Интерфейс для информирования пользователя о действиях
	/// </summary>
	public interface IMessageService
	{
		void ShowMessage(string message);
		void ShowExclamation(string exclamation);
		void ShowError(string error);
	}
}
