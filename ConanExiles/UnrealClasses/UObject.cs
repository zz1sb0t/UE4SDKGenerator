using System;
using System.Collections.Generic;
using ConanExiles.Memory;
using ConanExiles.UnrealStructures;

namespace ConanExiles.UnrealClasses
{
  
    public class UObject:MemoryObject
    {
        public override int ObjectSize => 40;
        public IntPtr VTable => ReadIntPtr(0);
        public int ObjectFlags => ReadInt32(8);
        public int InternalIndex => ReadInt32(12);
        public UClass Class => SafeGet<UClass>(16);
        private FName FName => ReadStruct<FName>(24);
        public UObject Outer => SafeGet<UObject>(32);

        public string Name => FName.ToString();
        public string NameWithPrefix => GetPrefix() + Name;
        public static implicit operator UObject(IntPtr baseAddress)
        {
            return new UObject() {BaseAddress = baseAddress};
        }


        

        public string GetPackageName()
        {
            UObject outer = Outer;
            if (outer == null)
                return null;
            while (outer.Outer != null)
            {
                if (outer.Outer == null)
                    break;
                outer = outer.Outer;
            }
            return outer.FName.ToString();
        }

        public string GetFullName()
        {
            List<string> names = new List<string>();
            UObject outer = Outer;
            if (outer == null)
                return null;
            while (outer.Outer != null)
            {
                if (outer.Outer == null)
                    break;
                if (!string.IsNullOrEmpty(outer.Outer.Name))
                names.Add(outer.Outer.Name.Replace("/",".").TrimStart('.'));
                outer = outer.Outer;
            }
            names.Reverse();
            names.Add(NameWithPrefix);
            return string.Join(".", names);
        }

        public string GetPrefix()
        {
            if (IsA("ScriptStruct"))
                return "F";
          
            if (IsActor())
                return "A";
            return "U";
        }
        public bool IsUStruct()
        {
            if (this.Class == null)
                return false;
            UClass @class = this.Cast<UClass>();
            do
            {
                if (@class == null)
                    return false;
                if (@class.Name == "UStruct")
                    return true;

                if (@class.SuperField == null)
                    break;

                @class = @class.SuperField.Cast<UClass>();
            } while (@class != null);

            return false;
        }
        public bool IsActor()
        {
            if (this.Class == null)
                return false;
            UClass @class = this.Cast<UClass>();
            do
            {
                if (@class == null)
                    return false;
                if (@class.Name == "Actor")
                    return true;

                if (@class.SuperField == null)
                    break;

                @class = @class.SuperField.Cast<UClass>();
            } while (@class != null);

            return false;
        }
        public bool IsA<T>()
        {
            string tname = typeof(T).Name.TrimStart(new char[] {'U', 'F', 'A'});
            if (this.Class == null)
                return false;
            UClass @class = this.Class;
            do
            {
                if (@class == null)
                    return false;
                if (@class.Name == tname)
                    return true;

                if (@class.SuperField == null)
                    break;

                @class = @class.SuperField.Cast<UClass>();
            } while (@class != null);

            return false;
        }
        public bool IsA(string name)
        {
            if (this.Class == null)
                return false;
            UClass @class = this.Class;
            do
            {
                if (@class == null)
                    return false;
                if (@class.Name == name)
                    return true;

                if (@class.SuperField == null)
                    break;

                @class = @class.SuperField.Cast<UClass>();
            } while (@class != null);

            return false;
        }
        public T Cast<T>() where T:UObject,new()
        {
            return new T {BaseAddress = BaseAddress};
        }

    }
}
