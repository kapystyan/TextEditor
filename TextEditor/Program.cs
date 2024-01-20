using System;
using System.Windows.Forms;
using TextEditorCore.BL;

namespace TextEditor
{
	static class Program
    {
        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
			var form = new TextRedactor();
			var presenter = new MainPresenter<string>(form, new LocalFileManager(), new MessageService());
			Application.Run(form);
		}
    }
}
