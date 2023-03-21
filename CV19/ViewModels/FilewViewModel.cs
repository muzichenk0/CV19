﻿using System;
using System.IO;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class FileViewModel : ViewModelBase
    {
        private readonly FileInfo _FileInfo;
        public string Name => _FileInfo.Name;
        public string Path => _FileInfo.FullName;
        public DateTime CreationTime => _FileInfo.CreationTime;
        public FileViewModel(string path) => _FileInfo = new FileInfo(path);
    }
}