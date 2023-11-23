using System;
using System.Collections.Generic;
using System.Xml;

public class LanguageManager
{
    private readonly Dictionary<string, string> languageStrings;

    public LanguageManager(string filePath)
    {
        languageStrings = new Dictionary<string, string>();
        LoadLanguageFile(filePath);
    }

    /// <summary>
    /// Load language strings from an XML file.
    /// </summary>
    private void LoadLanguageFile(string filePath)
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList nodes = xmlDoc.SelectNodes("/LanguageStrings/*");
            foreach (XmlNode node in nodes)
            {
                string key = node.Name;
                string value = node.InnerText;
                languageStrings[key] = value;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading language file: {e.Message}");
        }
    }

    /// <summary>
    /// Get a localized string with optional format arguments.
    /// </summary>
    /// <param name="key">The key for the desired localized string.</param>
    /// <param name="args">Format arguments for string interpolation.</param>
    /// <returns>The formatted localized string or a placeholder if the key is missing.</returns>
    public string GetLocalizedString(string key, params object[] args)
    {
        if (languageStrings.TryGetValue(key, out string format))
        {
            return string.Format(format, args);
        }

        return $"[Missing Localization Key: {key}]";
    }
}
