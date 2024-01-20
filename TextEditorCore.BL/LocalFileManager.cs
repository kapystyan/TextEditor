using System.IO;
using System.Text;

namespace TextEditorCore.BL
{
	public class LocalFileManager : IFileManager<string>
	{
		/// <summary>
		/// Представляет кодировку по умолчанию
		/// </summary>
		private readonly Encoding _defaultEncoding = Encoding.UTF8;
		/// <summary>
		/// Проверяет существование файла, указанном в path
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <returns>true когда файл существует в path, false при отсутствии файла в path, даже при path = null</returns>
		public bool IsExists(string path)
		{
			return File.Exists(path);
		}
		/// <summary>
		/// Читает файл указанный в path в кодировке по умолчанию
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <returns>Текст файла</returns>
		public string GetContent(string path)
		{
			return GetContent(path, _defaultEncoding);
		}
		/// <summary>
		/// Читает файл указанный в path в кодировке, указанной в encoding
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		/// <param name="encoding">Кодировка файла</param>
		/// <returns>Текст файла</returns>
		public string GetContent(string path, Encoding encoding)
		{
			return File.ReadAllText(path, encoding);
		}
		/// <summary>
		/// Считает количество символов в content
		/// </summary>
		/// <param name="content">Строка сомволов</param>
		/// <returns>Количество символов в content</returns>
		public int GetSymbolCount(string content)
		{
			return content.Length;
		}
		/// <summary>
		/// Сохраняет строку в файл, указанный в path в кодировке по умолчанию
		/// </summary>
		/// <param name="content">Содержание файла</param>
		/// <param name="path">Путь к файлу</param>
		public void SaveContent(string content, string path)
		{
			SaveContent(content, path, _defaultEncoding);
		}
		/// <summary>
		/// Сохраняет строку в файл, указанный в path в кодировке, указанной в encoding
		/// </summary>
		/// <param name="content">Содержание файла</param>
		/// <param name="path">Путь к файлу</param>
		/// <param name="encoding">Кодировка файла</param>
		public void SaveContent(string content, string path, Encoding encoding)
		{
			File.WriteAllText(path, content, encoding);
		}
	}
}