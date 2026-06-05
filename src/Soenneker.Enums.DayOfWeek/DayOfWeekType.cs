using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DayOfWeek;

/// <summary>
/// An enumerator for describing the day of the week (Mon, Tues, ..)
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class DayOfWeekType
{
    /// <summary>
    /// The sunday.
    /// </summary>
    public static readonly DayOfWeekType Sunday = new(nameof(Sunday));
    /// <summary>
    /// The monday.
    /// </summary>
    public static readonly DayOfWeekType Monday = new(nameof(Monday));
    /// <summary>
    /// The tuesday.
    /// </summary>
    public static readonly DayOfWeekType Tuesday = new(nameof(Tuesday));
    /// <summary>
    /// The wednesday.
    /// </summary>
    public static readonly DayOfWeekType Wednesday = new(nameof(Wednesday));
    /// <summary>
    /// The thursday.
    /// </summary>
    public static readonly DayOfWeekType Thursday = new(nameof(Thursday));
    /// <summary>
    /// The friday.
    /// </summary>
    public static readonly DayOfWeekType Friday = new(nameof(Friday));
    /// <summary>
    /// The saturday.
    /// </summary>
    public static readonly DayOfWeekType Saturday = new(nameof(Saturday));
}