using System;

namespace TextEditor
{
	public interface ITextRedactor<T>
	{
		T Path { get; }
		string Content { get; set; }
		void SetSymbolsCount(int count);
		event EventHandler FileOpen;
		event EventHandler FileSave;
		event EventHandler FileChanged;
	}
}
