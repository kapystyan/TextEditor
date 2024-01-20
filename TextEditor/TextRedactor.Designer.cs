using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
	partial class TextRedactor
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextRedactor));
			OpenFile_BT = new Button();
			SelectFile_BT = new Button();
			FilePath_TB = new TextBox();
			label1 = new Label();
			Content_TB = new TextBox();
			label2 = new Label();
			FontSize_NUD = new NumericUpDown();
			Save_BT = new Button();
			Tools_SS = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			SymbolCount_L = new ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)FontSize_NUD).BeginInit();
			Tools_SS.SuspendLayout();
			SuspendLayout();
			// 
			// OpenFile_BT
			// 
			OpenFile_BT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			OpenFile_BT.Location = new Point(827, 12);
			OpenFile_BT.Name = "OpenFile_BT";
			OpenFile_BT.Size = new Size(95, 32);
			OpenFile_BT.TabIndex = 0;
			OpenFile_BT.Text = "Открыть";
			OpenFile_BT.UseVisualStyleBackColor = true;
			// 
			// SelectFile_BT
			// 
			SelectFile_BT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			SelectFile_BT.Location = new Point(726, 12);
			SelectFile_BT.Name = "SelectFile_BT";
			SelectFile_BT.Size = new Size(95, 32);
			SelectFile_BT.TabIndex = 1;
			SelectFile_BT.Text = "Выбрать";
			SelectFile_BT.UseVisualStyleBackColor = true;
			// 
			// FilePath_TB
			// 
			FilePath_TB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			FilePath_TB.Location = new Point(135, 16);
			FilePath_TB.Name = "FilePath_TB";
			FilePath_TB.Size = new Size(585, 26);
			FilePath_TB.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 19);
			label1.Name = "label1";
			label1.Size = new Size(117, 19);
			label1.TabIndex = 3;
			label1.Text = "Выбрать файл";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Content_TB
			// 
			Content_TB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Content_TB.Location = new Point(12, 80);
			Content_TB.Multiline = true;
			Content_TB.Name = "Content_TB";
			Content_TB.ScrollBars = ScrollBars.Both;
			Content_TB.Size = new Size(910, 538);
			Content_TB.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 50);
			label2.Name = "label2";
			label2.Size = new Size(126, 19);
			label2.TabIndex = 5;
			label2.Text = "Размер шрифта";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FontSize_NUD
			// 
			FontSize_NUD.Location = new Point(144, 48);
			FontSize_NUD.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
			FontSize_NUD.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
			FontSize_NUD.Name = "FontSize_NUD";
			FontSize_NUD.Size = new Size(120, 26);
			FontSize_NUD.TabIndex = 6;
			FontSize_NUD.Value = new decimal(new int[] { 14, 0, 0, 0 });
			// 
			// Save_BT
			// 
			Save_BT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			Save_BT.Location = new Point(816, 624);
			Save_BT.Name = "Save_BT";
			Save_BT.Size = new Size(106, 32);
			Save_BT.TabIndex = 7;
			Save_BT.Text = "Сохранить";
			Save_BT.UseVisualStyleBackColor = true;
			// 
			// Tools_SS
			// 
			Tools_SS.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, SymbolCount_L });
			Tools_SS.Location = new Point(0, 659);
			Tools_SS.Name = "Tools_SS";
			Tools_SS.Size = new Size(934, 22);
			Tools_SS.TabIndex = 8;
			Tools_SS.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(130, 17);
			toolStripStatusLabel1.Text = "Количество символов";
			// 
			// SymbolCount_L
			// 
			SymbolCount_L.Name = "SymbolCount_L";
			SymbolCount_L.Size = new Size(0, 17);
			// 
			// TextRedactor
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(934, 681);
			Controls.Add(Tools_SS);
			Controls.Add(Save_BT);
			Controls.Add(FontSize_NUD);
			Controls.Add(label2);
			Controls.Add(Content_TB);
			Controls.Add(label1);
			Controls.Add(FilePath_TB);
			Controls.Add(SelectFile_BT);
			Controls.Add(OpenFile_BT);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			MinimumSize = new Size(550, 450);
			Name = "TextRedactor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Редактор";
			((System.ComponentModel.ISupportInitialize)FontSize_NUD).EndInit();
			Tools_SS.ResumeLayout(false);
			Tools_SS.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button OpenFile_BT;
		private Button SelectFile_BT;
		private TextBox FilePath_TB;
		private Label label1;
		private TextBox Content_TB;
		private Label label2;
		private NumericUpDown FontSize_NUD;
		private Button Save_BT;
		private StatusStrip Tools_SS;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel SymbolCount_L;
	}
}
