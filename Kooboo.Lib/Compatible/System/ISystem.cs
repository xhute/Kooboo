﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Kooboo.Lib.Compatible
{
    public interface ISystem
    {
        List<string> GetTryPaths();

        int GetPort(int port);

        bool IsPortInUsed(int port);

        string GetUpgradeUrl(string convertApiUrl);

        int GetEndLine(string source, int index);

        string GetSlash();

        int GetLastSlash(string path);

        string CombinePath(string root, string relativePath);

        string CombineRelativePath(string relativePath, string path);

        string JoinPath(string[] segments);

        List<string> GetSegments(string input);

    }
}
