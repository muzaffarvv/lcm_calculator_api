using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/vv/muzaffarxomitaliyev23_gmail_com", (string? x, string? y) =>
{
    if (!BigInteger.TryParse(x, out var a) || 
        !BigInteger.TryParse(y, out var b) || 
        a <= 0 || b <= 0)
    {
        return "NaN";
    }

    return FindLcm(a, b).ToString();
});

app.Run();
return;

static BigInteger FindGcd(BigInteger a, BigInteger b)
{
    while (b != 0)
    {
        var temp = a % b;
        a = b;
        b = temp;
    }
    return a;
}

static BigInteger FindLcm(BigInteger a, BigInteger b)
{
    return (a / FindGcd(a, b)) * b;
}