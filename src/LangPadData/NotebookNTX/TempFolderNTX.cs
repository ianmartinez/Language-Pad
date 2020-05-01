﻿using System;
using System.IO;

namespace LangPadData.NotebookNTX
{
    public class TempFolderNTX
    {
        public readonly string RootFolder;
        public readonly string PagesFolder;
        public readonly string DataFile;
        public readonly string PagesFile;
        public readonly string InfoFile;
        public readonly string CharactersFile;
        public readonly string DictionaryFile;
        public readonly string StylesheetFile;

        public TempFolderNTX(bool createSubdirs)
        {
            RootFolder = TempFolder.GetNewTempFolderRoot();

            PagesFolder = Path.Combine(RootFolder, "pages");
            if (createSubdirs)
                Directory.CreateDirectory(PagesFolder);
            DataFile = Path.Combine(RootFolder, "data.txt");
            PagesFile = Path.Combine(RootFolder, "pages.txt");
            InfoFile = Path.Combine(RootFolder, "info.txt");
            CharactersFile = Path.Combine(RootFolder, "characters.txt");
            DictionaryFile = Path.Combine(RootFolder, "dictionary.txt");
            StylesheetFile = Path.Combine(RootFolder, "style.css");
        }

        public string GetPagePath(int pageIndex)
        {
            return Path.Combine(PagesFolder, pageIndex.ToString() + ".html");
        }
    }
}
