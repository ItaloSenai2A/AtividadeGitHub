namespace AtividadeGitHub
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int Teste1 { get; set; }

        public int Teste2 { get; set; }

        public string Teste3 { get; set; }
    }
}
