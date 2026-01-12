using System;
using System.Drawing;
using System.Windows.Forms;

namespace relatorio_espectrometro_gui.Forms
{
    public enum LogType
    {
        Info,
        Success,
        Warning,
        Error
    }

    public class ConsoleLogger
    {
        private readonly RichTextBox _box;
        private readonly Color _defaultForeColor;
        private readonly Font _defaultFont;

        public ConsoleLogger(RichTextBox richTextBox)
        {
            _box = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));

            // Salvar estilo padrão
            _defaultForeColor = _box.ForeColor;
            _defaultFont = _box.Font;

            // Ajustar estilo do "terminal"
            _box.BackColor = Color.Black;
            _box.ForeColor = Color.White;
            _box.Font = new Font("Consolas", 10, FontStyle.Regular);
            _box.BorderStyle = BorderStyle.None;
            _box.ReadOnly = true;
        }

        public void Log(string msg, LogType tipo = LogType.Info)
        {
            if (_box.InvokeRequired)
            {
                _box.Invoke(new Action(() => Write(msg, tipo)));
            }
            else
            {
                Write(msg, tipo);
            }
        }

        private void Write(string msg, LogType tipo)
        {
            Color color;
            FontStyle style = FontStyle.Regular;

            switch (tipo)
            {
                case LogType.Success:
                    color = Color.Lime;
                    break;

                case LogType.Error:
                    color = Color.Red;
                    style = FontStyle.Bold;
                    break;

                case LogType.Warning:
                    color = Color.Yellow;
                    style = FontStyle.Bold;
                    break;

                default:
                    color = Color.White;
                    break;
            }

            _box.SelectionStart = _box.TextLength;
            _box.SelectionLength = 0;

            _box.SelectionColor = color;
            _box.SelectionFont = new Font(_defaultFont, style);

            _box.AppendText(msg + Environment.NewLine);

            _box.SelectionColor = _defaultForeColor;
            _box.SelectionFont = _defaultFont;

            _box.ScrollToCaret();
        }
    }
}
