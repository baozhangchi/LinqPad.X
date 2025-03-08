using System;
using System.IO;
using System.Text.Json;

namespace LinqPad.X
{
    internal class GlobalCache
    {
        private AppSettings? appSettings;

        private GlobalCache()
        { }

        public static GlobalCache Instance { get; } = new GlobalCache();

        public string DataFolder
        {
            get
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LinqPad.X");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return path;
            }
        }

        public string SettingsFile { get; } = Path.Combine(GlobalCache.Instance.DataFolder, "settings.json");

        public AppSettings AppSettings
        {
            get
            {
                if (appSettings == null)
                {
                    if (File.Exists(SettingsFile))
                    {
                        appSettings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(SettingsFile));
                    }
                    else
                    {
                        appSettings = new AppSettings();
                    }
                }
                return appSettings;
            }
        }
    }

    internal class AppSettings
    {
        private string queryFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LinqPad.X", "Queries");
        private string extensionFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LinqPad.X", "Extensions");

        public string QueryFolder
        {
            get
            {
                if (!Directory.Exists(queryFolder))
                {
                    Directory.CreateDirectory(queryFolder);
                }
                return queryFolder;
            }
            set => queryFolder = value;
        }

        public string ExtensionFolder
        {
            get
            {
                if (!Directory.Exists(extensionFolder))
                {
                    Directory.CreateDirectory(extensionFolder);
                }
                return extensionFolder;
            }
            set => extensionFolder = value;
        }
    }
}