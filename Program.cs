var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run(async (context) => {
   await context.Response.WriteAsync($"Today is{DateTime.Now.DayOfYear.ToString()} day");
});

app.Run();
