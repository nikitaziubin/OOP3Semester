
namespace DZ2
{
    internal class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            position = "Developer";
        }

        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();

        }
    }
}
