// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Persona
{
    protected int id { get; set; }
    protected string Nombre { get; set; }
    protected int años { get; set; }
    public Persona()
    {
        id = 0;
        Nombre = "Default nombre";
        años = 0;
    }
    public Persona(int id, string nombre, int años)
    {
        this.id = id;
        this.Nombre = nombre;
        this.años = años;
    }
    public override string ToString() =>
        $"{this.id} - {this.Nombre} - {this.años}";
}

public class Aluno : Persona
{

    double nota { get; set; }
    string coportamiento { get; set; }
    
    public Aluno(int id, string nombre, int años, double nota, string coportamiento)
    {
        this.id = id;
        this.Nombre = nombre;
        this.años = años;
        this.nota = nota;
        this.coportamiento = coportamiento;

    }
}

public class Profesor : Persona
{
    string evalucion { get; set; }
    public Profesor() { }
    public Profesor(int id, string nombre, int años, string evalucio)
    {
        this.id = id;
        this.Nombre = nombre;
        this.años = años;
        this.evalucion = evalucio;
    }

}

Persona persona = new Persona(88, "Yeral", 35);

Aluno aluno = new Aluno(60, "joan", 17, 90, "bueno");
Profesor profesor = new Profesor(34, "ñunes", 65, "exelente");
Console.WriteLine(persona.ToString());
Console.WriteLine(aluno.ToString());
Console.WriteLine(profesor.ToString());
