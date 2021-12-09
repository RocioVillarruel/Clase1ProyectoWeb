public class Lenguajes{
    public string Name { get; set; }
    public string Info { get; set; }
    public string Age { get; set; }

    public Lenguajes(string name, string info, string age)
    {
        Name= name;
        Info= info;
        Age= age;
    }

    public string inf()
    {
        return $"Nombre del lenguaje: {Name} \nInformacion: {Info} \nAño de creacion: {Age}";
    }
}