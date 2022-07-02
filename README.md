# ConsoleExtensions

ConsoleExtensions is a C# library built to add more features to the default console class.

## Installation (NOT AVAILABLE YET)

Use the package manager [nuget](https://www.nuget.org/) to install ConsoleExtensions.

```bash
Install-Package ConsoleExtensions
```

## Usage

### To use the ConsoleExtensions library, first add the namespace 'ConsoleExtensions' to the top of your C# script.
```csharp
using ConsoleExtensions;
```

## Features

### The following list of methods are available in this library:
```csharp
void SetConsoleTextColour(ConsoleColor colour);
void SetConsoleBackgroundColour(ConsoleColor colour);

// Returns true if the user enters 'y' and returns false if the user enters 'n'.
bool LogInput(string content);

void LogInfo(string content);
void LogInfoLine(string content);

void LogWarning(string content);
void LogWarningLine(string content);

void LogError(string content);
void LogErrorLine(string content);

void Exit();
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
