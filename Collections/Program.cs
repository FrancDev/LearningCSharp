//Collections 

//String Collections

var Computers = new List<string>();

Computers.Add ("HP");
Computers.Add ("Dell");
Computers.Add ("Lenovo");
Computers.Add ("Toshiba");
Computers.Add ("Acer");
Computers.Add ("Asus");

var GamingPc = new List<string>{"AlienWare", "MSI", "Predator", "Hp_Gaming" };


foreach (var el in Computers)
{
    Console.WriteLine ( el + " ");
}

List<Element> element = CreateList(); 


var query = from el in element where el.AtomicNum != 20 select el;
foreach (Element el in query)
Console.WriteLine ($"Name: {el.Name}, Simbol: {el.Simbol}, Atomic_Number: {el.AtomicNum}");


static List<Element> CreateList()
{
    return new List<Element>
    {
        {new Element() {Simbol = "K", Name = "Potasio", AtomicNum = 19}},
        {new Element() {Simbol = "Ca", Name = "Calcio", AtomicNum = 20}},
        {new Element() {Simbol = "Na", Name = "Sodio", AtomicNum = 11}},

    };
}

public class Element 
{
    public string Name {get; set;}
    public string Simbol {get; set;}

    public int AtomicNum { get; set;}
}


