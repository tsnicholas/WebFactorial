using logic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Random random = new Random();
int value = random.Next(0, 20);
int result = Factorial.getFactorial(value);
app.MapGet("/", () => value + "! = " + result);

app.Run();
