public interface I0
{
}

public class C0
{
    public C0(sbyte f0, byte f1, bool f2)
    {
    }
}

public struct S0 : I0
{
    public ulong F0;
    public sbyte F1;
    public byte F2;
    public sbyte F3;
    public long F4;
    public byte F5;
    public long F6;
    public ulong F7;
    public long F8;
    public S0(ulong f0, sbyte f1, byte f2, sbyte f3, long f4, byte f5, long f6, ulong f7, long f8): this()
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
    }
}

public struct S1
{
    public short F0;
    public long F1;
    public short F2;
    public S1(short f0, long f1, short f2): this()
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }

    public bool M81()
    {
        return default(bool);
    }
}

public class C1
{
    public C1(short f0, ushort f1, ushort f2)
    {
    }

    public ushort M10()
    {
        return default(ushort);
    }

    public short M28()
    {
        return default(short);
    }
}

public class Program
{
    public static short[] s_8 = new short[]{27419};
    public static byte s_10 = 169;
    public static uint s_12 = 10U;
    public static I0 s_65 = new S0(0UL, 105, 45, 0, -334850926330292064L, 1, -10L, 1UL, -9223372036854775807L);
    public static C1 s_121 = new C1(32766, 1, 0);
    public static void Main()
    {
    }

    public static S0 M4(S0 arg0)
    {
        return default(S0);
    }

    public static long M92()
    {
        return default(long);
    }

    public static S0 M108(C0 argThis, uint arg0, uint arg1)
    {
        return default(S0);
    }

    public static S1 M55(S0 argThis)
    {
        return default(S1);
    }
}