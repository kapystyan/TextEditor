using System;
using TextEditorCore.BL;

namespace TextEditor
{
	public class MainPresenter<T>
	{
		private readonly ITextRedactor<T> _view;
		private readonly IFileManager<T> _manager;
		private readonly IMessageService _messageService;
		private T _currentPath;

		public MainPresenter(ITextRedactor<T> view, IFileManager<T> manager, IMessageService service)
		{
			_view = view;
			_manager = manager;
			_messageService = service;

			_view.SetSymbolsCount(0);
			_view.FileChanged += _view_FileChanged;
			_view.FileOpen += _view_FileOpen;
			_view.FileSave += _view_FileSave;
		}

		private void _view_FileChanged(object sender, EventArgs e)
		{
			_view.SetSymbolsCount(_manager.GetSymbolCount(_view.Content));
		}
		private void _view_FileOpen(object sender, EventArgs e)
		{
			try
			{
				if (!_manager.IsExists(_view.Path))
				{
					_messageService.ShowExclamation("Файл не существует");
					return;
				}
				_currentPath = _view.Path;
				_view.Content = _manager.GetContent(_view.Path);
				_view.SetSymbolsCount(_manager.GetSymbolCount(_manager.GetContent(_view.Path)));
			}
			catch (Exception ex)
			{
				_messageService.ShowError(ex.Message);
			}
		}
		private void _view_FileSave(object sender, EventArgs e)
		{
			try
			{
				_manager.SaveContent(_view.Content, _currentPath);
				_messageService.ShowMessage("Файл сохранен");
			}
			catch (Exception ex)
			{
				_messageService.ShowError(ex.Message);
			}
		}
	}
}
