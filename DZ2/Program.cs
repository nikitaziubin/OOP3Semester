
using DZ2;
using System.Xml.Linq;

abstract class Worker
{
    private string name;
    protected string position;
    protected int WorkDay;  
    public Worker(string name)
    {
        this.name = name;
    }
    public int workday { get => WorkDay; set => WorkDay = value; }
    public string Name { get => name; }
    public string Position { get => position; }
    public void Call()
    {

    }
    public void WriteCode()
    {

    }
    public void Relax()
    {

    }
    public abstract void FillWorkDay();
}

internal class Program
{
    private static void Main(string[] args)
    {
        string name, teamName, chose, position;
        int workDay;
        Console.Write("Write Team name: ");
        teamName = Console.ReadLine();
        Team team = new Team(teamName);
        do
        {
            Console.Write("Write name: ");
            name = Console.ReadLine();
            Console.Write("Write position(Manager(M)/Developer(D)): ");
            position = Console.ReadLine();
            Console.Write("Write Workday: ");
            workDay = Convert.ToInt32(Console.ReadLine()); 
            if (position == "M")
            {
                Manager manager = new Manager(name);
                manager.workday = workDay;
                team.addWorker(manager);
            }
            else
            {
                Developer developer = new Developer(name);
                developer.workday = workDay;
                team.addWorker(developer);
            }
            
            Console.Write("Would you like to countinue(Yes/No): ");
            chose = Console.ReadLine();
        }

        while (chose != "No");
        Console.Write("getFullTeamInformation(Full)/getTeamInformation(Not Full): ");
        chose= Console.ReadLine();
        if (chose == "Full")
        {
            team.getFullTeamInformation();
        }
        else
        {
            team.getTeamInformation();
        }

        //Console.WriteLine(name);
    }
}