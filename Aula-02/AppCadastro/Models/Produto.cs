using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace MVC2026;

public class Produto
{
    public Guid Id {get;set;}
    public string Nome {get;set;}
    public int Quantidade {get;set;}
}


