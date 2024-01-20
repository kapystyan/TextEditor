using System.Text;

namespace TextEditorCore.BL
{
	/// <summary>
	/// Интерфейс управления файлами
	/// </summary>
	public interface IFileManager<T>
	{
		/// <summary>
		/// Проверяет существование файла, указанном в path
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <returns>true когда файл существует в path, false при отсутствии файла в path, даже при path = null</returns>
		bool IsExists(T path);
		/// <summary>
		/// Читает файл указанный в path в кодировке по умолчанию
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <returns>Текст файла</returns>
		string GetContent(T path);
		/// <summary>
		/// Читает файл указанный в path в кодировке, указанной в encoding
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <param name="encoding">Кодировка файла</param>
		/// <returns>Текст файла</returns>
		string GetContent(T path, Encoding encoding);
		/// <summary>
		/// Считает количество символов в content
		/// </summary>
		/// <param name="content">Строка сомволов</param>
		/// <returns>Количество символов в content</returns>
		int GetSymbolCount(string content);
		/// <summary>
		/// Сохраняет строку в файл, указанный в path в кодировке по умолчанию
		/// </summary>
		/// <param name="content">Содержание файла</param>
		/// <param name="path">Путь к файлу</param>
		void SaveContent(string content, T path);
		/// <summary>
		/// Сохраняет строку в файл, указанный в path в кодировке, указанной в encoding
		/// </summary>
		/// <param name="content">Содержание файла</param>
		/// <param name="path">Путь к файлу</param>
		/// <param name="encoding">Кодировка файла</param>
		void SaveContent(string content, T path, Encoding encoding);
	}
}
