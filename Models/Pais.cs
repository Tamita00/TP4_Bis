public class Pais{
    public string nombre{get; set;}
    public string imgBandera{get; set;}
    public int poblacion{get; set;}
    public DateTime fechaIndependencia{get; set;}
    public string atractivosTuristico{get; set;}
    
    public string urlHimno{get; set;}

    public Pais (string nombreReci, string imgBanderaReci, int poblacionReci, DateTime fechaIndependenciaReci, string atractivosTuristicoReci, string urlHimnoReci)
    {
        nombre = nombreReci;
        imgBandera = imgBanderaReci;
        poblacion = poblacionReci;
        fechaIndependencia = fechaIndependenciaReci;
        atractivosTuristico = atractivosTuristicoReci;
        urlHimno = urlHimnoReci;
    }
    public Pais(){}
}

