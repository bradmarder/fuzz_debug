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