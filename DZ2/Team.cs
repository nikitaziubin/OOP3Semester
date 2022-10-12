
namespace DZ2
{
    internal class Team 
    {
        private string name;
        List<Worker> workersInformationList = new List<Worker>();

        public Team(string name)
        {
            this.name = name;
        }
        public void addWorker(Worker worker)
        {
            workersInformationList.Add(worker);
        }
        public void getTeamInformation()
        {
            Console.WriteLine(name);
            foreach (var a in workersInformationList)
            {
                Console.WriteLine(a.Name);
            }
        }
        public void getFullTeamInformation()
        {
            Console.WriteLine(name);
            foreach (var a in workersInformationList)
            {
                Console.WriteLine($"{a.Name}-{a.Position}-{a.workday}");
            }
        }
    }
}
