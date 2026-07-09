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
            txtMainText.Text = GetClipboardText();
            UpdateLineCount();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMainText.Clear();
            UpdateLineCount();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var mainLines = ConvertToLines(txtMainText.Text);
            var removeLines = ConvertToLines(txtRemoveLines.Text);
            var resultLines = FilterLines(mainLines, removeLines);
            txtResultText.Text = ConvertToText(resultLines);
            UpdateLineCount();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultText.Text))
                Clipboard.SetText(txtResultText.Text);
        }

        private void txtMainText_TextChanged(object sender, EventArgs e)
        {
            UpdateLineCount();
        }

        private void txtRemoveLines_TextChanged(object sender, EventArgs e)
        {
            UpdateLineCount();
        }

        private void txtResultText_TextChanged(object sender, EventArgs e)
        {
            UpdateLineCount();
        }


        // Clipboard

        private string GetClipboardText()
        {
            return Clipboard.ContainsText() ? Clipboard.GetText() : string.Empty;
        }


        // Text Processing

        private List<string> ConvertToLines(string text)
        {
            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        private List<string> FilterLines(List<string> mainLines, List<string> removeLines)
        {
            var removeSet = new HashSet<string>(removeLines.Select(Normalize));

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


        // Line Counter

        private void UpdateLineCount()
        {
            var mainLineCount = GetLineCount(txtMainText.Text);
            var removeLineCount = GetLineCount(txtRemoveLines.Text);
            var resultLineCount = GetLineCount(txtResultText.Text);

            txtNumberOfMainlines.Text = mainLineCount.ToString();
            txtNumberOfRemoveLines.Text = removeLineCount.ToString();
            txtNumberOfResultLines.Text = resultLineCount.ToString();
        }

        private int GetLineCount(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
        }

        private void RemoveLines_Load(object sender, EventArgs e)
        {
            UpdateLineCount();
        }
    }
}
