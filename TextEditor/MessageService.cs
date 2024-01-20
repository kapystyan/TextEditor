using System.Windows.Forms;

namespace TextEditor
{
	/// <summary>
	/// Содержит методы для трансляции сообщений пользователю
	/// </summary>
	internal class MessageService : IMessageService
	{
		/// <summary>
		/// Транслирует сообщение
		/// </summary>
		/// <param name="message">Текст сообщения</param>
		public void ShowMessage(string message)
		{
			MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		/// <summary>
		/// Транслирует о предупреждении
		/// </summary>
		/// <param name="exclamation">Текст предупреждения</param>
		public void ShowExclamation(string exclamation)
		{
			MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		/// <summary>
		/// Транслирует ошибку
		/// </summary>
		/// <param name="error">Текст ошибки</param>
		public void ShowError(string error)
		{
			MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
