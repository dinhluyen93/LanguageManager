# GTA V Mod Language Manager

The GTA V Mod Language Manager is a C# utility designed for seamless integration with Grand Theft Auto V modifications. This tool simplifies the localization of your mod by managing and formatting language strings from an XML file.

## Features

- **Efficient String Management:** The `LanguageManager` class efficiently handles language strings, making it easy to organize and retrieve them.

- **XML File Support:** Store your language strings in an XML file for easy editing and maintenance.

- **Dynamic String Formatting:** Utilize the `GetLocalizedString` method to dynamically format language strings based on provided keys and parameters.

## Usage

1. **Initialization:**
   ```csharp
   LanguageManager languageManager = new LanguageManager("path/to/languagefile.xml");
****
