﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Cynosura.Studio.Core.Solution
{
    public class Project
    {
        public string Path { get; }
        public string Namespace { get; }
        public Solution Solution { get; }

        internal Project(Solution solution, string path, string projectFile)
        {
            Solution = solution;
            Path = path;
            Namespace = Regex.Replace(projectFile, "^.*\\\\([^\\\\]+?).csproj", "$1");
        }

        public string[] GetFiles(string path)
        {
            var absolutePath = System.IO.Path.Combine(Path, path);
            if (!Directory.Exists(absolutePath))
            {
                return new string[] {};
            }
            return Directory.GetFiles(absolutePath);
        }
    }
}
