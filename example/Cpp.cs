using System.Runtime.InteropServices;

namespace ManagedMain
{
    public class Cpp
    {
        [DllImport(
            "Cpp.dll", 
            EntryPoint = "add",
            ExactSpelling = false
            )]
        public static extern Int32 add(Int32 a, Int32 b);
    }
}