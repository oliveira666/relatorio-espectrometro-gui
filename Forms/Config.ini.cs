using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace relatorio_espectrometro_gui.Forms
{
    internal class Config
    {
        // Atributos
        private string _configPath;
        private string _rootFolder;
        private string _destinationFolder;
        private string _processedFolder;
        private string _notProcessedFolder;

        // Atributos da API do Windows para configurar o arquivo ini
        [LibraryImport("kernel32", StringMarshalling = StringMarshalling.Utf16)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string ConfigPath);

        [LibraryImport("kernel32", StringMarshalling = StringMarshalling.Utf16)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string ConfigPath);

        // Métodos Get, Set
        public string ConfigPath { get => _configPath; private set { _configPath = value; } }
        public string RootFolder
        {
            get => _rootFolder; set
            {
                _rootFolder = value;
                Write("ORIGEM", "PATH", value);
            }
        }
        public string DestinationFolder
        {
            get => _destinationFolder; set
            {
                _destinationFolder = value;
                Write("DESTINO", "PATH", value);
            }
        }
        public string ProcessedFolder { get => _processedFolder; private set { _processedFolder = value; } }
        public string NotProcessedFolder { get => _notProcessedFolder; private set => _notProcessedFolder = value; }

        // Construtor
        public Config()
        {
            // Atribue ConfigPath ao local onde o executável está + config.ini
            _configPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            // Cria o arquivo com valores padrão se não existir
            if (!File.Exists(ConfigPath))
            {
                _rootFolder = @"C:\temp\relatorios";
                _destinationFolder = Path.Combine(_rootFolder, "Destino");

                //Escreve no arquivo config.ini
                Write("ORIGEM", "PATH", _rootFolder);
                Write("DESTINO", "PATH", _destinationFolder);
            }
            else
            {
                // Lê do INI
                _rootFolder = Read("ORIGEM", "PATH");
                _destinationFolder = Read("DESTINO", "PATH");
            }
            // Sempre será Child de _rootFolder
            _processedFolder = Path.Combine(_rootFolder, "Processado");
            _notProcessedFolder = Path.Combine(_rootFolder, "Nao Processado");


            // Cria diretórios se não existirem
            foreach (string folder in new[] { _rootFolder, _processedFolder, _notProcessedFolder })
                if (!string.IsNullOrWhiteSpace(folder) && !Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
        }

        // Método para Ler o INI
        public string Read(string section, string key)
        {
            StringBuilder temp = new(2);
            GetPrivateProfileString(section, key, "", temp, 255, ConfigPath);
            return temp.ToString();
        }

        // Método para escrever no INI
        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, ConfigPath);
        }
    }
}
