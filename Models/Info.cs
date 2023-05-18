
public static class Info{

    public static List<Pais> listaPaises = new List<Pais>();   

    private static void InicializarLista ()
    {
        Pais Argentina = new Pais("Argentina", "arg.png", 47000000, new DateTime(1816,07,09), "Cataratas Iguazu", "https://www.youtube.com/watch?v=1D6IRDZmOXA");
        Pais Guyana = new Pais ("Guyana", "guy.png", 804567, new DateTime(1966,05,26),"Selva Tropical", "https://www.youtube.com/watch?v=0EGq5axuyyU");
        Pais Peru = new Pais ("Peru", "pru.png", 33720000, new DateTime(1821,07,28), "Machu Pichu", "https://www.youtube.com/watch?v=yozoiNu0CYo");
        Pais SantaLucia = new Pais ("SantaLucia", "sla.png", 179651, new DateTime(1979,02,22), "Paraiso Tropical", "https://www.youtube.com/watch?v=8utAa8-AOb0");
        Pais Venezuela = new Pais ("Venezuela", "vnz.png", 28200000, new DateTime(1811,07,25), "Isla Margarita", "https://www.youtube.com/watch?v=usyDbeY-2_w");
        
        listaPaises.Add(Argentina);
        listaPaises.Add(Guyana);
        listaPaises.Add(Peru);
        listaPaises.Add(SantaLucia);
        listaPaises.Add(Venezuela);
    }

    public static List<Pais> ListarPaises(){
        if(listaPaises.Count() == 0) InicializarLista();
        return listaPaises;
    }

    public static Pais DetallePais(string nombre){
        foreach (Pais pais in listaPaises)
        {
            if(nombre == pais.nombre) return pais;
        }
        return null;
    }
}