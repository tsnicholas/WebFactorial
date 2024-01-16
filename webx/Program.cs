using logic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int result = Factorial.getFactorial(5);

app.MapGet("/", () => "5! = " + result);

app.Run();
