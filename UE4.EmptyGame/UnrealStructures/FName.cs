using UE4.EmptyGame.Memory;

namespace UE4.EmptyGame.UnrealStructures
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
                if (UnrealGame.Instance.Names.Count > ComparisonIndex)
                {
                    var nameentry = UnrealGame.Instance.Names.Get(ComparisonIndex);
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
