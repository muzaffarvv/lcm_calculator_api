var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/vv/muzaffarxomitaliyev23_gmail_com", (string? x, string? y) =>
{
    if (!long.TryParse(x, out var a) || 
        !long.TryParse(y, out var b) ||
        a <= 0 || b <= 0)  return "NaN";

    return FindLcm(a, b).ToString();
});

app.Run();
return;

static long FindGcd(long a, long b)
{
    while (b != 0)
    {
        var temp = a % b;
        a = b;
        b = temp;
    }

    return a;
}

static long FindLcm(long a, long b)
{
    return a / FindGcd(a, b) * b;
}