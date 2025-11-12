using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Windows.Forms;

namespace relatorio_espectrometro_gui.Forms
{
    internal static class DirectoryHelper
    {
        /// <summary>
        /// Valida se o diretório existe ou está acessível (inclusive em rede).
        /// </summary>
        public static bool ValidateDirectory(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return false;

            try
            {
                // Caminho de rede
                if (path.StartsWith(@"\\"))
                {
                    if (!Directory.Exists(path))
                    {
                        MessageBox.Show(
                            $"A pasta de rede '{path}' não está acessível.\n" +
                            "Verifique a conexão com a rede ou se o servidor está ligado.",
                            "Conexão de rede perdida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }
                // Caminho local
                else
                {
                    if (!Directory.Exists(path))
                    {
                        MessageBox.Show(
                            $"A pasta '{path}' não existe!",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }

                // Tudo certo
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show(
                    $"Não foi possível acessar '{path}'. Pode estar desconectado.",
                    "Erro de rede",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    $"Sem permissão para acessar '{path}'.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro inesperado ao validar caminho:\n{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
