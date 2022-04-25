string? configPath = Environment.GetEnvironmentVariable("EDGE_CONFIG");

if (string.IsNullOrWhiteSpace(configPath))
{
    Console.WriteLine("Config YAML not found");
    return;
}

string? content = File.ReadAllText(configPath);

if (string.IsNullOrWhiteSpace(content))
{
    Console.WriteLine("Config YAML was empty");
    return;
}

Console.WriteLine(content);