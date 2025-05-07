using System.Text.RegularExpressions;

namespace CvBlazorSite.Helpers;

public static class ProjectHelper
{
    private static string webImagePath = "/img/html.png";
    private static string blazorImagePath = "/img/blazor-logo.png";
    private static string appImagePath = "/img/C Sharp logo.svg";
    private static string godotImagePath = "/img/Godot_icon.svg.png";
    private static string unityImagePath = "/img/unity.png";

    public static string GetImagePath(string type)
    {
        switch (type)
        {
            case "Web Development":
                return webImagePath;
            case "Blazor":
                return blazorImagePath;
            case "C#":
                return appImagePath;
            case "Godot":
                return godotImagePath;
            case "Unity":
                return unityImagePath;
            default:
                return "";
        }
    }

    public static string GetSiteName(string url)
    {
        string pattern = @"https:\/\/(.*?)\/";
        
        Regex regex = new Regex(pattern);

        if (regex.IsMatch(url))
        {
            return regex.Match(url).Groups[1].Value;
        }
        return "";
    }

    public static string GetProjectDateString(short startYear, short endYear)
    {
        if (endYear == 0) return $"{startYear} - ";
        if (startYear == endYear) return $"{startYear}";
        return $"{startYear} - {endYear}";
    }
}