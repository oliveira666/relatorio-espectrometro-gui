namespace relatorio_espectrometro_gui
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            const string mutexName = @"Global\relatorio-espectrometro-gui-single-instance";
            using var mutex = new Mutex(initiallyOwned: true, name: mutexName, createdNew: out bool createdNew);
            var current = Process.GetCurrentProcess();
            var others = Process.GetProcessesByName(current.ProcessName)
                                .Where(p => p.Id != current.Id)
                                .ToList();
            try
            {
                foreach (var p in others)
                {
                    if (p.MainWindowHandle != IntPtr.Zero)
                    {
                        p.CloseMainWindow();

                        if (p.WaitForExit(2000))
                            continue;
                    }
                    p.Kill(true);
                    p.WaitForExit(3000);
                }
            }
            catch
            {
                
            }
            /*if (!createdNew)
            {
                MessageBox.Show("O programa já está aberto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            ApplicationConfiguration.Initialize();
            Application.Run(new relatorio_espectrometro_gui.Form());
        }
    }
}