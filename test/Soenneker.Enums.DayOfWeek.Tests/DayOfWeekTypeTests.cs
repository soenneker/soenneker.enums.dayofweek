using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.DayOfWeek.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DayOfWeekTypeTests : HostedUnitTest
{
    public DayOfWeekTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
