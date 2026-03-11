using IntroducaoDotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroducaoDotnet.Pages;

public class Equacao2grau : PageModel
{
    public void OnGet()
    {
        
    }

    /// <summary>
    /// Dados enviados pelo cliente, e recebidos no método POST
    /// </summary>
    [BindProperty]
    public Equacao2grauModel? EquacaoModel { get; set; }
    
    /// <summary>
    /// Resultado da primeira Raiz
    /// </summary>
    public string Raiz1 { get; set; }
    
    /// <summary>
    /// Resultado da segunda Raiz
    /// </summary>
    public string Raiz2 { get; set; }
    
    public void OnPost()
    {
        // se o utilizador envia um ponto na string, fazemos replace para vírgula
        EquacaoModel.A = EquacaoModel.A.Replace(".", ",");
        EquacaoModel.B = EquacaoModel.B.Replace(".", ",");
        EquacaoModel.C = EquacaoModel.C.Replace(".", ",");
        
        //
        float.TryParse(EquacaoModel.A, out float a);
        float.TryParse(EquacaoModel.B, out float b);
        float.TryParse(EquacaoModel.C, out float c);

        // Calcular Raízes
        float delta = b*b-4*a*c;

        float x1 = (-b + MathF.Sqrt(delta))/(2*a);
        float x2 = (-b - MathF.Sqrt(delta))/(2*a);

        // enviar os dados calculados para a View
        Raiz1 = x1.ToString();
        Raiz2 = x2.ToString();
    }
}