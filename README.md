[![](https://img.shields.io/nuget/v/Soenneker.Enums.DayOfWeek.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DayOfWeek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.dayofweek/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.dayofweek/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.DayOfWeek.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.DayOfWeek/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.dayofweek/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.dayofweek/actions/workflows/codeql.yml)

# Soenneker.Enums.DayOfWeek

A string-backed enum-value type for representing a named day in API and application contracts.

## Install

```bash
dotnet add package Soenneker.Enums.DayOfWeek
```

## Usage

```csharp
using Soenneker.Enums.DayOfWeek;

DayOfWeekType day = DayOfWeekType.Monday;
string wireValue = day.Value; // "Monday"

if (DayOfWeekType.TryFromValue(input, out DayOfWeekType? parsed))
{
    // parsed is one of the shared static instances
}
```

Available values are `Sunday` through `Saturday`, with matching case-sensitive string values. `System.Text.Json` serializes the type as that string and restores recognized values to the corresponding static instance. `FromValue` throws for unknown input; use `TryFromValue` for request values. `FromName` and `TryFromName` are also generated.

`DayOfWeekType` is not `System.DayOfWeek` and does not define numeric values or culture-specific week ordering. Convert deliberately when a BCL API is required:

```csharp
System.DayOfWeek systemDay = Enum.Parse<System.DayOfWeek>(day.Value);

DayOfWeekType contractDay = DayOfWeekType.FromValue(systemDay.ToString());
```

The type identifies a day only. The consuming application still defines the first day of the week, locale-specific display text, time zone, and business-day rules.
