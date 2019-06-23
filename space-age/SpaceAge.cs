public class SpaceAge
{
    #region Fields

    private readonly double _seconds;
    private const double Earth = 31557600;
    private const double Mercury = Earth * 0.2408467;
    private const double Venus = Earth * 0.61519726;
    private const double Mars = Earth * 1.8808158;
    private const double Jupiter = Earth * 11.862615;
    private const double Saturn = Earth * 29.447498;
    private const double Uranus = Earth * 84.016846;
    private const double Neptune = Earth * 164.79132;

    #endregion

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth() => YearsOn(Earth);

    public double OnMercury() => YearsOn(Mercury);

    public double OnVenus() => YearsOn(Venus);

    public double OnMars() => YearsOn(Mars);

    public double OnJupiter() => YearsOn(Jupiter);

    public double OnSaturn() => YearsOn(Saturn);

    public double OnUranus() => YearsOn(Uranus);

    public double OnNeptune() => YearsOn(Neptune);

    private double YearsOn(double factor) => _seconds / factor;
}
