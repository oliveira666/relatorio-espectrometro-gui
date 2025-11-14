using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;


namespace relatorio_espectrometro_gui.Forms
{
    internal class Communications
    {
        private readonly Config config = new();
        private readonly string _fileType = "*.txt";

        // Acesso à pasta destino
        public bool HasAcessoPastaDestino => DirectoryHelper.ValidateDirectory(config.DestinationFolder);

        // Contagem de arquivos pendentes
        public int CountPendentes => Directory.GetFiles(config.RootFolder, _fileType, SearchOption.TopDirectoryOnly).Length;

        // Contagem de arquivos não processados
        public int CountNaoProcessados => Directory.GetFiles(config.NotProcessedFolder, _fileType, SearchOption.TopDirectoryOnly).Length;

    }  
}
