using System;
using System.Drawing;
using System.Windows.Forms;

public static class LogHelper
{
    private static RichTextBox? _box;

    // janela pequena -> por padrão já é compacto
    public static bool ShowTimestamp { get; set; } = false;
    public static bool AutoScroll { get; set; } = true;

    public static void Init(RichTextBox consoleBox)
    {
        _box = consoleBox ?? throw new ArgumentNullException(nameof(consoleBox));

        _box.ReadOnly = true;
        _box.HideSelection = false;
        _box.DetectUrls = false;
        // _box.BackColor = Color.Black;
        _box.ForeColor = Color.Black;
        _box.Font = new Font("Consolas", 10f);
    }

    public static void Clear()
    {
        if (_box == null) return;

        if (_box.InvokeRequired)
        {
            _box.BeginInvoke(new Action(Clear));
            return;
        }

        _box.Clear();
    }

    // ---- logs curtos ----
    public static void Info(string msg) => WriteLine(msg, Color.Gainsboro);
    public static void Ok(string msg = "OK") => WriteLine(msg, Color.LightGreen);
    public static void Warn(string msg) => WriteLine(msg, Color.Khaki);
    public static void Error(string msg) => WriteLine("X " + msg, Color.LightCoral);

    // exceção em PT-BR e 1 linha só
    public static void Error(Exception ex, string contextoCurto)
    {
        var friendly = ex switch
        {
            System.Collections.Generic.KeyNotFoundException => "arquivo inválido, verifique o arquivo.",
            FormatException => "formato inválido (data/valor)",
            IndexOutOfRangeException => "linha incompleta",
            UnauthorizedAccessException => "sem permissão",
            System.IO.IOException => "falha de I/O",
            _ => "erro inesperado"
        };

        Error($"{contextoCurto}: {friendly}");
    }

    private static void WriteLine(string msg, Color color)
    {
        if (_box == null) return;
        msg = (msg ?? "").Replace(Environment.NewLine, " ").Trim();
        if (msg.Length == 0) return;

        if (_box.InvokeRequired)
        {
            _box.BeginInvoke(new Action(() => WriteLine(msg, color)));
            return;
        }

        var prefix = ShowTimestamp ? $"[{DateTime.Now:HH:mm:ss}] " : "";
        var line = prefix + msg + Environment.NewLine;

        _box.SelectionStart = _box.TextLength;
        _box.SelectionLength = 0;
        _box.SelectionColor = color;
        _box.AppendText(line);
        _box.SelectionColor = _box.ForeColor;

        if (AutoScroll)
        {
            _box.SelectionStart = _box.TextLength;
            _box.ScrollToCaret();
        }
    }
}
