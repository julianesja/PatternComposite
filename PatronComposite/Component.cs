namespace PatronComposite
{
    public abstract class Component
    {
        public string Name { get; set; }        
        public TypeComponent TypeComponent {get; set;}

        public Component(string name, TypeComponent typeComponent)
        {
            this.Name = name;
            
            this.TypeComponent = typeComponent;
        }
    }
}