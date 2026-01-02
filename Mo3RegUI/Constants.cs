namespace Mo3RegUI
{
    public static class Constants
    {
        public const string GameName = "尤里的复仇";
        public const string EnglishGameName = "Yuri's Revenge";

        public const string AppName = GameName + " 注册机";
        public const string EnglishAppName = "Register for " + EnglishGameName;

        public const string Version = "v2.5.0";
        public const string AssemblyVersion = "2.5.0.0";

        public const string CopyrightYearFrom = "2019";
        public const string CopyrightYearTo = "2026";

        public const string AuthorName = "伤心的笔"; // You are not supposed to remove the name here. Append your name if you have made significant changes.
        public const string EnglishAuthorName = "SadPencil"; // You are not supposed to remove the name here. Append your name if you have made significant changes.
        public const string RepoUri = "https://github.com/SadPencil/Mo3RegUI"; // Change to your repo if you have forked it. Note: this is REQUIRED by GPLv3.

        public const string NeutralResourcesLanguage = "zh-CN";

        public const string GameConfigIniName = "RA2MD.ini";
        public const string LauncherExeName = "CnCNetYRLauncher.exe";
        public const string GameExeName = "gamemd.exe";
        public const string SecondaryGameExeName = "Syringe.exe";

        public static readonly string[] VulnerableAvExes = new string[] {
            "Ares.dll",
            "Phobos.dll",
            "CnCNet-Spawner.dll",
            "Syringe.exe",
            "Resources/ddraw_dxwnd.dll",
        };

        public const bool CheckDirectXRuntime = false;
        public const string CnCDDrawDllName = "cnc-ddraw.dll";
        public const string CnCDDrawIniName = "cnc-ddraw.ini";
        public const bool LauncherExeDpiUnaware = false;

        public const bool RequireBlowfishRegistration = false; // No need for Phobos
    }
}
