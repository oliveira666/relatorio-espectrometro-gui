using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
public static class LogHelper
{ 
    private static RichTextBox? _box; 
    public static bool ShowTimestamp { get; set; }
    public static bool AutoScroll { get; set; } = true;
    private const int C_SLEEP = 1500; 
    public static void Init(RichTextBox consoleBox) 
    {
        _box = consoleBox ?? throw new ArgumentNullException(nameof(consoleBox));
        _box.ReadOnly = true;
        _box.HideSelection = false;
        _box.DetectUrls = false;
    } 
    public static void Clear()
    {
        if (_box == null) return;
        if (_box.InvokeRequired) { _box.BeginInvoke(new Action(Clear));
            return;
        }
        _box.Clear();
    } 
    public static void Info(string msg)
    {
        WriteLine("INFO:" + msg, Color.Gainsboro);
    } 
    public static void Ok(string msg = "OK") { WriteLine("SUCESSO: " + msg, Color.LightGreen); } 
    public static void Warn(string msg) { WriteLine("AVISO: " + msg, Color.Khaki); } 
    public static void Error(string msg) { WriteLine("ERRO: " + msg, Color.LightCoral); } 
    private static void WriteLine(string msg, Color color) 
    { ShowTimestamp = true;
        if (_box == null) return; msg = (msg ?? "").Replace(Environment.NewLine, " ").Trim();
        if (msg.Length == 0) return; if (_box.InvokeRequired) { _box.BeginInvoke(new Action(() => WriteLine(msg, color))); return; }
        var prefix = ShowTimestamp ? $"[{DateTime.Now:dd/MM/yyy HH:mm:ss}] " : "";
        var line = prefix + msg + Environment.NewLine;
        _box.SelectionStart = _box.TextLength;
        _box.SelectionLength = 0; _box.SelectionColor = color; _box.AppendText(line);

        if (AutoScroll) { _box.SelectionStart = _box.TextLength; _box.ScrollToCaret(); 
        }
    }
}