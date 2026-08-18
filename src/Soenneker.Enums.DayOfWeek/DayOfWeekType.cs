using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DayOfWeek;

/// <summary>
/// Identifies a named day in the seven-day calendar week.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class DayOfWeekType
{
    /// <summary>
    /// Sunday.
    /// </summary>
    public static readonly DayOfWeekType Sunday = new(nameof(Sunday));
    /// <summary>
    /// Monday.
    /// </summary>
    public static readonly DayOfWeekType Monday = new(nameof(Monday));
    /// <summary>
    /// Tuesday.
    /// </summary>
    public static readonly DayOfWeekType Tuesday = new(nameof(Tuesday));
    /// <summary>
    /// Wednesday.
    /// </summary>
    public static readonly DayOfWeekType Wednesday = new(nameof(Wednesday));
    /// <summary>
    /// Thursday.
    /// </summary>
    public static readonly DayOfWeekType Thursday = new(nameof(Thursday));
    /// <summary>
    /// Friday.
    /// </summary>
    public static readonly DayOfWeekType Friday = new(nameof(Friday));
    /// <summary>
    /// Saturday.
    /// </summary>
    public static readonly DayOfWeekType Saturday = new(nameof(Saturday));
}
