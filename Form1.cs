using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextCleanerApp
{
    public partial class RemoveLines : Form
    {
        public RemoveLines()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PasteToMain();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMainText();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ProcessRemoveLines();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyResult();
        }

        // =============================
        // Core Operations (Orchestrators)

        private void ProcessRemoveLines()
        {
            string mainText = GetMainText();
            string removeText = GetRemoveText();

            List<string> mainLines = ConvertToLines(mainText);
            List<string> removeLines = ConvertToLines(removeText);

            List<string> resultLines = FilterLines(mainLines, removeLines);

            string result = ConvertToText(resultLines);

            ShowResult(result);
        }

        private void PasteToMain()
        {
            txtMainText.Text = GetClipboardText();
        }

        private void ClearMainText()
        {
            txtMainText.Clear();
        }

        private void CopyResult()
        {
            SetClipboardText(txtResultText.Text);
        }

        // =============================
        // Input / Output

        private string GetMainText()
        {
            return txtMainText.Text;
        }

        private string GetRemoveText()
        {
            return txtRemoveLines.Text;
        }

        private void ShowResult(string result)
        {
            txtResultText.Text = result;
        }

        // =============================
        // Clipboard

        private string GetClipboardText()
        {
            return Clipboard.ContainsText() ? Clipboard.GetText() : string.Empty;
        }

        private void SetClipboardText(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                Clipboard.SetText(text);
        }

        // =============================
        // Text Processing

        private List<string> ConvertToLines(string text)
        {
            return text
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.None)
                .ToList();
        }

        private List<string> FilterLines(List<string> mainLines, List<string> removeLines)
        {
            HashSet<string> removeSet = new HashSet<string>(
                removeLines.Select(l => Normalize(l))
            );

            return mainLines
                .Where(line => !removeSet.Contains(Normalize(line)))
                .ToList();
        }

        private string Normalize(string line)
        {
            return line.Trim().ToLower();
        }

        private string ConvertToText(List<string> lines)
        {
            return string.Join(Environment.NewLine, lines);
        }
    }
}
