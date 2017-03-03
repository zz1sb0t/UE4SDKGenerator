namespace ConanExiles.UnrealClasses
{
    public class UField:UObject
    {
        public UField Next => SafeGet<UField>(0x28);
    }
}
