using ConanExiles.Memory;

namespace ConanExiles.UnrealStructures
{
    public class FName:MemoryObject
    {
        public int ComparisonIndex => ReadInt32(0);
        public int Index => ReadInt32(4);

       
        string CleanName(string name)
        {
            return name.Replace(" ", "");
        }
        public string Name
        {
            get
            {
                if (ConanExilesGame.Instance.Names.Count > ComparisonIndex)
                {
                    var nameentry = ConanExilesGame.Instance.Names.Get(ComparisonIndex);
                    if (nameentry?.Value != null)
                        return CleanName(nameentry.Value);
                    return "";
                }
                return "";
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public override int ObjectSize => 4;
    }
}
