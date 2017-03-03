using UE4.Core.Memory;

namespace UE4.Core.UnrealStructures
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
