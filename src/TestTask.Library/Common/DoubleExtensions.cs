namespace TestTask.Library.Common;

internal static class DoubleExtensions
{
    internal static readonly double ERROR = 1e-7;

    internal static bool IsEqualToWithAnError(this double thisNumber, double otherNumber)
    {
        return Math.Abs(thisNumber - otherNumber) <= ERROR;
    }
}
