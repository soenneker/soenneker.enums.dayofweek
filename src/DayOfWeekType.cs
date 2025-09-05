using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.DayOfWeek;

/// <summary>
/// An enumerator for describing the day of the week (Mon, Tues, ..)
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public partial class DayOfWeekType
{
    public static readonly DayOfWeekType Sunday = new(nameof(Sunday));
    public static readonly DayOfWeekType Monday = new(nameof(Monday));
    public static readonly DayOfWeekType Tuesday = new(nameof(Tuesday));
    public static readonly DayOfWeekType Wednesday = new(nameof(Wednesday));
    public static readonly DayOfWeekType Thursday = new(nameof(Thursday));
    public static readonly DayOfWeekType Friday = new(nameof(Friday));
    public static readonly DayOfWeekType Saturday = new(nameof(Saturday));
}