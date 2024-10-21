using Microsoft.AspNetCore.Mvc;

public class EscanerViewModel
{
    public List<Escaner> Escaneres { get; set; }
}

public class Escaner
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool Activo { get; set; }
}
