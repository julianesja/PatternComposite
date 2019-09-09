namespace PatronComposite
{
    public class File : Component
    {
        public decimal Weight { get; set; }
        public File(string name, decimal weight) : base(name,  TypeComponent.File)
        {
            this.Weight = weight;
        }
    }
}
