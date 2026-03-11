using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroducaoDotnet.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        Mensagem = "Mensagem do Servidor";
    }

    public void OnPost(string nomeDoCliente)
    {
        Mensagem = "Olá cliente " + nomeDoCliente;
    }
    
    public string Mensagem { get; set; } =  string.Empty;
    
    public ArrayList Mensagens { get; private set; } = new ArrayList(){
        "Acabar o Prey",
        "Jogar Resident Evil 9",
        "Mario Kart World"
    };
}