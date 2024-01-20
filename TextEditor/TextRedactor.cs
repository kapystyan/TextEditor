using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
	public partial class TextRedactor : Form, ITextRedactor<string>
	{
		public string Path
		{
			get => FilePath_TB.Text;
		}
		public string Content
		{
			get => Content_TB.Text;
			set => Content_TB.Text = value;
		}

		public event EventHandler FileOpen;
		public event EventHandler FileSave;
		public event EventHandler FileChanged;

		public TextRedactor()
		{
			InitializeComponent();

			OpenFile_BT.Click += delegate
			{
				if (FileOpen != null)
					FileOpen(this, EventArgs.Empty);
			};
			Save_BT.Click += delegate
			{
				if (FileSave != null)
					FileSave(this, EventArgs.Empty);
			};
			Content_TB.TextChanged += delegate
			{
				if (FileChanged != null)
					FileChanged(this, EventArgs.Empty);
			};

			SelectFile_BT.Click += SelectFile_BT_Click;
			FontSize_NUD.ValueChanged += FontSize_NUD_ValueChanged;
		}

		private void FontSize_NUD_ValueChanged(object sender, EventArgs e)
		{
			Content_TB.Font = new Font("Consolas", (float)FontSize_NUD.Value);
		}
		private void SelectFile_BT_Click(object sender, EventArgs e)
		{
			using (var fDialog = new OpenFileDialog() { Filter = "Текстовые файлы|*.txt|Все файлы|*.*" })
			{
				if (fDialog.ShowDialog() != DialogResult.OK)
					return;
				FilePath_TB.Text = fDialog.FileName;
				if (FileOpen != null)
					FileOpen(this, EventArgs.Empty);
			}
		}

		public void SetSymbolsCount(int count)
		{
			SymbolCount_L.Text = count.ToString();
		}
	}
}
