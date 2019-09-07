namespace PatronComposite
{
    public class Path : Component
    {
        public decimal Weight { get; set; }
        public Path(string name, decimal weight) : base(name,  TypeComponent.File)
        {
            this.Weight = weight;
        }
    }
}
