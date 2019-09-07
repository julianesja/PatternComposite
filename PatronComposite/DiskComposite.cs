namespace PatronComposite
{
    using System.Collections.Generic;
    public class DiskComposite : Component
    {
        private List<Component> Paths = new List<Component>();
        public decimal Weight
        {
            get
            {
                decimal weight = 0;
                foreach(var path in Paths)
                {
                    if (path.TypeComponent == TypeComponent.Folder)
                    {
                        weight += GetWeight(path);
                    }
                    else
                    {
                        weight += ((Path)path).Weight;
                    }
                }
                return weight;
            }
        }

        public DiskComposite(string name ) : base(name, TypeComponent.Folder)
        {

        }

        private decimal GetWeight(Component component)
        {
            var folder = ((DiskComposite)component);
            decimal weight = 0;
            foreach (var path in folder.Paths)
            {
                if(path.TypeComponent == TypeComponent.Folder)
                {
                    weight += GetWeight(path);
                }
                else
                {
                    weight += ((Path)path).Weight;
                }
            }
            return weight;
        }

        public void Add(Component component)
        {
            Paths.Add(component);
        }
        public void Remove(Component component)
        {
            Paths.Remove(component);
        }
    }
}
