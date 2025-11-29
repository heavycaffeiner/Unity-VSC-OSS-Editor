/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.IO;
using Unity.CodeEditor;
using IOPath = System.IO.Path;

namespace Microsoft.Unity.VSCodeUniversal.Editor
{
    internal interface IInstallation
    {
        string Name { get; }
        string Path { get; }
        bool SupportsAnalyzers { get; }
        Version LatestLanguageVersionSupported { get; }
        string[] GetAnalyzers();
        bool Open(string path, int line, int column, string solutionPath);
        IGenerator ProjectGenerator { get; }
        void CreateExtraFiles(string projectDirectory);
    }

    internal abstract class Installation : IInstallation
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Version Version { get; set; }
        public bool IsPrerelease { get; set; }

        public abstract bool SupportsAnalyzers { get; }
        public abstract Version LatestLanguageVersionSupported { get; }
        public abstract string[] GetAnalyzers();
        public abstract IGenerator ProjectGenerator { get; }
        public abstract void CreateExtraFiles(string projectDirectory);
        public abstract bool Open(string path, int line, int column, string solutionPath);
    }
}
