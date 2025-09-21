using System;
using System.IO;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;

namespace work.ctrl3d.R3RPPrefabs
{
    [InitializeOnLoad]
    public class PackageInstaller
    {
        private const string NuGetForUnityName = "com.github-glitchenzo.nugetforunity";
        private const string NuGetForUnityGitUrl = "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity";
        
        private const string R3Name = "com.cysharp.r3";
        private const string R3GitUrl =
            "https://github.com/Cysharp/R3.git?path=src/R3.Unity/Assets/R3.Unity";

        static PackageInstaller()
        {
            var isNuGetForUnityInstalled = CheckPackageInstalled(NuGetForUnityName);
            if (!isNuGetForUnityInstalled) AddGitPackage(NuGetForUnityName, NuGetForUnityGitUrl);
            
            var isR3Installed = CheckPackageInstalled(R3Name);
            if (!isR3Installed) AddGitPackage(R3Name, R3GitUrl);
        }

        private static void AddGitPackage(string packageName, string gitUrl)
        {
            var path = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            var jsonString = File.ReadAllText(path);

            var indexOfLastBracket = jsonString.IndexOf("}", StringComparison.Ordinal);
            var dependenciesSubstring = jsonString[..indexOfLastBracket];
            var endOfLastPackage = dependenciesSubstring.LastIndexOf("\"", StringComparison.Ordinal);

            jsonString = jsonString.Insert(endOfLastPackage + 1, $", \n \"{packageName}\": \"{gitUrl}\"");

            File.WriteAllText(path, jsonString);
            Client.Resolve();
        }

        private static bool CheckPackageInstalled(string packageName)
        {
            var path = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            var jsonString = File.ReadAllText(path);
            return jsonString.Contains(packageName);
        }
    }
}