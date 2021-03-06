// Generated by Fuzzlyn v1.5 on 2022-04-02 02:34:24
// Run on X64 Windows
// Seed: 9461539929073564863
// Reduced from 248.4 KiB to 0.9 KiB in 00:02:05
// Exits with error:
// Unhandled exception. System.ArgumentException: Cannot bind to the target method because its signature is not compatible with that of the delegate type.
//    at System.Delegate.CreateDelegate(Type type, MethodInfo method, Boolean throwOnBindFailure)
//    at Fuzzlyn.ExecutionServer.Program.<RunPairAsync>g__RunAndGetResultAsync|1_0(Byte[] bytes, <>c__DisplayClass1_0& ) in C:\Fuzzlyn\Fuzzlyn.ExecutionServer\Program.cs:line 115
//    at Fuzzlyn.ExecutionServer.Program.RunPairAsync(AssemblyLoadContext alc, ProgramPair pair) in C:\Fuzzlyn\Fuzzlyn.ExecutionServer\Program.cs:line 86
//    at Fuzzlyn.ExecutionServer.Program.<>c__DisplayClass0_0.<Main>b__0() in C:\Fuzzlyn\Fuzzlyn.ExecutionServer\Program.cs:line 61
//    at System.Threading.Thread.StartCallback()
// 
public class Program
{
    public static void Main()
    {
        CollectibleALC alc = new CollectibleALC();
        System.Reflection.Assembly asm = alc.LoadFromAssemblyPath(System.Reflection.Assembly.GetExecutingAssembly().Location);
        System.Reflection.MethodInfo mi = asm.GetType(typeof(Program).FullName).GetMethod(nameof(MainInner));
        System.Type runtimeTy = asm.GetType(typeof(Runtime).FullName);
        mi.Invoke(null, new object[]{System.Activator.CreateInstance(runtimeTy)});
    }

    public static void MainInner(IRuntime rt)
    {
    }
}

public interface IRuntime
{
    void WriteLine<T>(string site, T value);
}

public class Runtime : IRuntime
{
    public void WriteLine<T>(string site, T value) => System.Console.WriteLine(value);
}

public class CollectibleALC : System.Runtime.Loader.AssemblyLoadContext
{
    public CollectibleALC(): base(true)
    {
    }
}