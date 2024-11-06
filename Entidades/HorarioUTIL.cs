using System.Collections.Generic;

public static class DiasSemanaUtil
{
    public static readonly Dictionary<string, string> DiasCompletos = new Dictionary<string, string>
    {
        {"LUN", "Lunes"},
        {"MAR", "Martes"},
        {"MIE", "Miércoles"},
        {"JUE", "Jueves"},
        {"VIE", "Viernes"},
        {"SAB", "Sábado"},
        {"DOM", "Domingo"}
    };

    public static readonly Dictionary<string, string> DiasAbreviados = new Dictionary<string, string>
    {
        {"Lunes", "LUN"},
        {"Martes", "MAR"},
        {"Miércoles", "MIE"},
        {"Jueves", "JUE"},
        {"Viernes", "VIE"},
        {"Sábado", "SAB"},
        {"Domingo", "DOM"}
    };

    public static string ObtenerAbreviatura(string diaCompleto)
    {
        return DiasAbreviados.ContainsKey(diaCompleto) ? DiasAbreviados[diaCompleto] : diaCompleto.Substring(0, 3).ToUpper();
    }

    public static string ObtenerDiaCompleto(string abreviatura)
    {
        return DiasCompletos.ContainsKey(abreviatura) ? DiasCompletos[abreviatura] : abreviatura;
    }
}