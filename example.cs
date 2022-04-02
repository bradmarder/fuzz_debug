public interface I0
{
    I0 M44(ref short arg0);
}

public class C0
{
    public sbyte F0;
    public byte F1;
    public bool F2;
    public C0(sbyte f0, byte f1, bool f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }

    public sbyte M3(int arg0, C0 arg1)
    {
        arg1.F0 = (sbyte)(~this.F0);
        return 74;
    }

    public ushort M6(I0 arg0)
    {
        return default(ushort);
    }

    public bool[][] M15()
    {
        return default(bool[][]);
    }

    public C0 M16(short arg0, long arg1)
    {
        S1[] var0 = default(S1[]);
        var0 = new S1[]{new S1(-14561, 5889688523210053171L, -3072), new S1(-9783, -4899826503515042342L, 0), new S1(-32768, -3324412429448948601L, -32767)};
        return this;
    }

    public ref S1 M34()
    {
        ulong var1 = default(ulong);
        uint var2 = default(uint);
        ushort var3 = default(ushort);
        for (int var0 = 0; var0 < 2; var0++)
        {
            {
                {
                    Program.s_9 &= this.F2;
                }
            }

            var1 = 18446744073709551614UL;
            var2 = 349304091U;
        }

        var3 = Program.s_5[0][0, 0, 0].F1;
        return ref Program.s_18;
    }

    public C0 M43(int arg0)
    {
        uint var0 = default(uint);
        new S0(0UL, 1, 39, -107, 3342914360151086373L, 112, -9223372036854775808L, 2577107182113856273UL, 1L).M44(ref Program.s_35[0]);
        var0 = Program.s_12;
        return new C0(-15, 218, true);
    }

    public int M52(sbyte arg0, uint arg1, sbyte[] arg2, ref uint arg3, ref C1[] arg4)
    {
        uint var0 = default(uint);
        ulong[] var1 = default(ulong[]);
        short var2 = default(short);
        S1 var3 = default(S1);
        var0 = 4294967295U;
        var1 = new ulong[]{17576536420138109601UL, 10489629195504734386UL, 42468460218580163UL, 15100719149699457725UL, 5712504227263182199UL, 12053170746624711883UL, 0UL};
        try
        {
            {
                arg4[0].F2 = (ushort)(arg4[0].F2 | arg4[0].F0);
            }
        }
        finally
        {
            this.F1 = this.F1;
            arg4[0].F2 = arg4[0].F2++;
            try
            {
                Program.s_44 = this.F2;
            }
            finally
            {
                arg4[0].F0 = arg4[0].F0;
            }

            arg2[0] = Program.s_6.F1;
            arg4 = arg4;
            {
                this.F2 = this.F2;
                var2 = arg4[0].F0;
                {
                    new S0(18446744073709551614UL, 1, 14, 2, -1L, 222, -5452536353291259235L, 14593216024145337575UL, 1L).M53();
                    Program.M56();
                    this.F1 = Program.s_16.F1;
                    arg0 = arg0;
                    arg4[0].F2 = Program.s_13;
                    Program.M58(Program.s_36);
                }
            }
        }

        Program.s_42 = new S0[]{new S0(15214185446548972204UL, -128, 10, -127, 3857390832174469580L, 254, -1689464654467055939L, 12715605715772476981UL, 1015623120700034704L), new S0(18446744073709551614UL, -103, 255, -59, -9223372036854775807L, 222, 1L, 0UL, -3584790969427555714L), new S0(12720867903401252430UL, 4, 132, 126, -9223372036854775808L, 83, -9223372036854775807L, 4455441907066615957UL, 1L), new S0(0UL, -102, 240, -98, 7408707486941982339L, 131, 1L, 1UL, 5837436750117524471L), new S0(721510468648073903UL, 126, 214, -92, 0L, 1, -1L, 7591767173606511551UL, 6791907607492481495L), new S0(18446744073709551615UL, -127, 9, 0, 0L, 106, 0L, 8766858427287236774UL, 4114606343792172623L)};
        Program.M56();
        var3 = Program.s_42[0].M55();
        return -1984154809;
    }

    public S1 M61(ref long arg0, I0[, ] arg1)
    {
        bool var0 = default(bool);
        S1 var2 = default(S1);
        if (this.F2)
        {
            Program.s_54 = new uint[]{2899608444U, 4294967294U, 4294967294U, 10U, 3415434709U, 10U, 3748880625U, 3054616304U, 4294967295U};
        }
        else
        {
            var0 = this.F2;
        }

        ref C1 var1 = ref Program.s_32[0];
        Program.s_41 = new sbyte[][][,, ]{new sbyte[][,, ]{new sbyte[,, ]{{{50, -10, 0}, {-41, -128, 1}, {-128, 1, 122}, {1, -57, 1}}}}};
        if (-32767 != var1.F2)
        {
            var1.F2 = var1.F1--;
            Program.s_55 = arg1[0, 0];
        }

        Program.M62(Program.s_54[0]++, new S0(14434278683344847921UL, -1, 2, 0, 10L, 144, 0L, 14053791396555390992UL, -2774190459497323353L), this.F0, ref Program.s_38, arg1[0, 0], new I0[]{new S0(10UL, 2, 0, 1, -4907183227587062054L, 82, 1L, 13675527335157147262UL, -6206220362234724388L), new S0(3544239794054892100UL, -128, 26, -98, 1L, 1, 3085144657007281553L, 11682739259476887730UL, 9223372036854775806L), new S0(0UL, -110, 8, 126, -7654863778975084550L, 1, -2L, 13143075593618976349UL, 5672920190738661823L), new S0(4315954345943136420UL, -10, 232, 0, 0L, 138, 9223372036854775806L, 15492376715622517055UL, -4577554800687876888L), new S0(0UL, -128, 2, 2, -2755227501603428088L, 154, -1094867784063821502L, 6853921301877474162UL, 9223372036854775806L), new S0(0UL, 10, 63, 2, -9127248999998840803L, 1, 4504925782773049562L, 1UL, 9223372036854775806L), new S0(7636149287057462058UL, 10, 254, 11, -7400817372521423566L, 186, 10L, 17862790380185008610UL, 9223372036854775807L), new S0(18446744073709551614UL, 75, 1, -31, -9223372036854775808L, 2, 1301423013412697257L, 6357911223519245271UL, -9223372036854775808L)});
        Program.M62(3343545398U, arg1[0, 0], this.F0, ref Program.s_38, arg1[0, 0], new I0[]{new S0(5330586095925213823UL, 1, 1, 54, 0L, 1, 5014285392908318455L, 1UL, 1L), new S0(1UL, 108, 255, 0, 9025425982237681805L, 113, -9223372036854775807L, 15829537249636084101UL, 1105754772120105822L), new S0(18446744073709551615UL, 10, 67, -128, -4454945284464983969L, 4, 9223372036854775806L, 0UL, 35062524679648032L), new S0(6710460801903910513UL, 1, 125, 0, 1502588428120438198L, 1, 6342763500111052263L, 18446744073709551614UL, 9223372036854775807L), new S0(1UL, -69, 215, -118, 2L, 0, -1L, 18446744073709551614UL, 9223372036854775806L), new S0(7918591515438807517UL, 126, 254, -127, -486701940718427692L, 169, -8897017896364248342L, 5347965679947699085UL, 0L), new S0(3541358380578549495UL, 72, 201, 2, -8428857832140651980L, 54, -5173402498760326898L, 1UL, 1L), new S0(1UL, -53, 1, 1, 5485463244890540529L, 154, 7768368079898386759L, 1UL, 2406778118519900663L)});
        if (1 == arg0)
        {
            var2 = Program.s_1[0];
            var2.F1 = arg0;
            arg1 = arg1;
            ref I0 var3 = ref Program.s_39;
        }

        return new S1(32766, -2L, -32767);
    }

    public S0[] M72(short arg0)
    {
        sbyte var1 = default(sbyte);
        byte var2 = default(byte);
        ulong var3 = default(ulong);
        byte[] var4 = default(byte[]);
        short var5 = default(short);
        uint var6 = default(uint);
        short var7 = default(short);
        C1[][] var8 = default(C1[][]);
        uint var9 = default(uint);
        int[] var10 = default(int[]);
        C0 var12 = default(C0);
        for (int var0 = 0; var0 < 2; var0++)
        {
            arg0 = arg0;
            {
                {
                    if (Program.s_16.F2)
                    {
                        Program.s_60 = (short)(-Program.s_18.F2);
                        arg0 = Program.s_8[0];
                    }

                    var1 = Program.s_16.F0;
                    Program.M73();
                    var2 = this.F1;
                    Program.M73();
                    Program.s_50.F2 = this.F2;
                    var2 *= 94;
                    Program.M73();
                    {
                        var1 = var1;
                        var3 = Program.s_36.F7;
                    }
                }
            }

            var4 = Program.s_45;
            this.F1 = 148;
            this.F1 ^= this.F1;
        }

        var5 = arg0;
        var6 = 2U;
        Program.M73();
        if (this.F2)
        {
            var7 = 10;
            {
                if (this.F2)
                {
                    var6 = (uint)Program.M73();
                    var5 = Program.s_18.F0;
                    var8 = new C1[][]{new C1[]{new C1(-11416, 0, 40930), new C1(-32767, 65535, 65534)}, new C1[]{new C1(-32767, 65535, 5990)}, new C1[]{new C1(-32767, 11823, 65534)}, new C1[]{new C1(0, 65534, 64254)}, new C1[]{new C1(-10, 55842, 0)}, new C1[]{new C1(4161, 0, 65534), new C1(-2, 1, 24567)}};
                    var8[0][0] = Program.s_53;
                }
                else
                {
                    var9 = 1U;
                }

                Program.M73();
                Program.M73();
            }

            new S0(0UL, -127, 10, 72, 0L, 0, 7607382457509562155L, 1697402099653869702UL, 1L).M74(ref Program.s_27, Program.s_42[0].F8++);
            Program.s_1[0].F1 = Program.s_37;
            var10 = new int[]{900310696, -1, 2147483646, 0, -2147483647, -1452276627};
            if (this.F2)
            {
                for (int var11 = 0; var11 < 2; var11++)
                {
                    arg0 = (short)(this.F1 % (sbyte)(this.F0 | 1));
                    var6 = var6++;
                }
            }
            else
            {
                this.F1 = this.F1;
            }
        }
        else
        {
            var6 = ~Program.s_30;
        }

        var12 = this;
        --this.F0;
        return Program.s_42;
    }

    public S0 M76(ref ushort arg0)
    {
        return default(S0);
    }

    public int M88()
    {
        long[] var0 = default(long[]);
        int var1 = default(int);
        int var2 = default(int);
        this.F2 = this.F2;
        this.F2 = true;
        this.F0 &= Program.s_16.F0--;
        Program.s_88 = new C1[]{new C1(2, 0, 1), new C1(1, 1, 41647), new C1(1, 13247, 1), new C1(1, 0, 0), new C1(-23722, 1, 65534), new C1(-2, 65534, 1), new C1(0, 7266, 1), new C1(9785, 0, 30696)};
        Program.s_64 = this.F1;
        --Program.s_28.F1;
        var0 = new long[]{4290971908168571097L, 7018756022454146881L, 9223372036854775807L, 9223372036854775806L, 9223372036854775806L, 1466459919429337633L};
        this.F2 = true;
        var1 = Program.s_38;
        if (!this.F2)
        {
            Program.s_42[0].F0 = 15924240858610018368UL;
        }

        var0[0] -= -1L;
        {
            var2 = Program.s_6.F5 >> Program.s_50.F0++;
        }

        if (this.F2)
        {
            var0 = new long[]{1L, -4000862842014554451L, 1L, 1L};
        }
        else
        {
            Program.M89(0L, Program.s_83);
            {
                Program.s_21[0][0, 0].F2 |= true;
            }
        }

        return var1;
    }

    public I0 M94()
    {
        return default(I0);
    }

    public sbyte M105(sbyte arg0, S1[] arg1, byte arg2)
    {
        for (int var0 = 0; var0 < 2; var0++)
        {
            if (this.F2)
            {
                Program.s_94 = Program.s_84.F2;
                Program.s_57[0] = 0;
            }
        }

        return arg0;
    }

    public S0 M108(uint arg0, uint arg1)
    {
        bool var0 = default(bool);
        C1 var3 = default(C1);
        byte var5 = default(byte);
        sbyte var6 = default(sbyte);
        long var7 = default(long);
        C1[] var8 = default(C1[]);
        int var9 = default(int);
        Program.M109(ref Program.s_74, ref Program.s_67);
        if (this.F2)
        {
            {
                Program.s_85 = (ushort)(~Program.s_53.F2);
                Program.s_99 = Program.s_99;
                Program.M109(ref Program.s_38, ref Program.s_67);
            }

            var0 = this.F2;
            if (var0)
            {
                Program.M109(ref Program.s_74, ref Program.s_67);
                ref ulong var1 = ref Program.s_42[0].F7;
            }

            Program.M109(ref Program.s_76, ref Program.s_67);
            var0 = this.F2;
            Program.M109(ref Program.s_76, ref Program.s_67);
            arg1 = Program.s_12;
        }
        else
        {
            {
                try
                {
                    this.F1 = (byte)(126 << Program.s_57[0]);
                    for (int var2 = 0; var2 < 2; var2++)
                    {
                        this.F1 = 254;
                    }

                    Program.M109(ref Program.s_38, ref Program.s_67);
                    arg0 = arg1;
                    if (Program.s_2[0])
                    {
                        var3 = Program.s_88[0];
                        var3 = var3;
                        Program.M109(ref Program.s_58, ref Program.s_67);
                        var3.F2 = 48696;
                        ref short var4 = ref var3.F0;
                    }
                    else
                    {
                        this.F1 = (byte)(~this.F1);
                        Program.M109(ref Program.s_92, ref Program.s_67);
                    }

                    arg1 = arg0;
                }
                finally
                {
                    var5 = this.F1;
                    if (Program.M110(ref arg1))
                    {
                        var5 = this.F1;
                        var6 = this.F0;
                        arg1 >>= (short)(-31724 & this.F1) % (int)(-2147483648 | 1);
                        arg0 = 1006115833U;
                        var6 = Program.s_6.F1;
                        var7 = 9223372036854775806L;
                        if (this.F2)
                        {
                            arg1 = arg1;
                        }

                        var8 = new C1[]{new C1(32767, 17655, 21116), new C1(0, 62676, 58404), new C1(27685, 65534, 65534), new C1(1, 1, 65534), new C1(6215, 0, 57395), new C1(26392, 45102, 52786)};
                        var9 = (int)(11457289863137353600UL >> (short)(~var8[0].F0));
                        var8[0].F2 = var8[0].F2;
                    }
                }
            }
        }

        return Program.M111(0, new ulong[]{1UL, 4761058664259163893UL, 1UL, 12031371889732686595UL, 12423723927031059617UL, 1UL, 16477171919598878143UL, 7222900295557127465UL, 6735527426156785400UL}, this.F2, Program.s_53, ref Program.s_95, new bool[]{false}, Program.s_51);
    }

    public S1[] M112(ref ushort[][] arg0, bool arg1, ref S0[, ] arg2)
    {
        C0 var0 = default(C0);
        I0[] var1 = default(I0[]);
        ushort var2 = default(ushort);
        int var3 = default(int);
        this.F1 = this.F1;
        if (!(Program.s_28.F2 == Program.s_75[0, 0, 0]))
        {
            if (arg1)
            {
                {
                    var0 = this;
                    var1 = Program.s_67;
                }

                Program.s_84.F0 = Program.s_73.F3;
                arg2[0, 0].F4 = arg2[0, 0].F4--;
                var2 = Program.s_46[0].F1;
            }

            arg2[0, 0].F0 = 17781142413093092259UL;
        }

        {
            var3 = 982552562;
            {
                Program.M113(ref arg0[0][0], this);
                {
                    arg2 = ref arg2;
                }

                arg0[0][0] = (ushort)Program.M113(ref arg0[0][0], this);
                arg2[0, 0].F4 = (long)Program.M113(ref arg0[0][0], this);
            }

            Program.M114(ref this.F2, new I0[]{new S0(0UL, 42, 50, 127, -3368125158820498508L, 21, 0L, 3024438599921333134UL, -4286163123182844648L), new S0(0UL, 1, 0, -34, 6361197265841675876L, 168, 0L, 0UL, 2L), new S0(0UL, 1, 64, 0, 0L, 216, -6511898739851598422L, 0UL, -1L)}, (sbyte)(~Program.s_7), new uint[, ]{{3693531144U, 1U, 0U, 4294967295U, 0U, 0U}, {0U, 3046126297U, 1U, 4294967294U, 1U, 1513993098U}, {2598399107U, 1U, 4294967295U, 1U, 3398935191U, 4294967295U}, {1487567240U, 1U, 1858636727U, 2044166757U, 0U, 3340657644U}}, 0);
        }

        return new S1[]{new S1(28738, 3950710755092725258L, 30942), new S1(-29664, 1L, -16705), new S1(-27411, 7662316038023772099L, 2330), new S1(1, 192879573362824474L, -10), new S1(-9964, 1L, -12337), new S1(0, 4492542763766687391L, -27395), new S1(16392, -5218358533292656038L, 13702), new S1(15878, 4315202414250973302L, -10793), new S1(-32250, -2248014800265210239L, 0), new S1(-25649, 896145200216775710L, 0)};
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
    public S0(ulong f0, sbyte f1, byte f2, sbyte f3, long f4, byte f5, long f6, ulong f7, long f8)
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

    public long M7(S1 arg0)
    {
        return default(long);
    }

    public long[] M27(ushort arg0, bool arg1, S1 arg2, C1[] arg3, uint arg4, ref long[] arg5, byte arg6)
    {
        S1 var1 = default(S1);
        sbyte var2 = default(sbyte);
        byte[] var3 = default(byte[]);
        bool var4 = default(bool);
        C1 var5 = default(C1);
        ushort var7 = default(ushort);
        C1 var8 = default(C1);
        S1 var9 = default(S1);
        bool[] var10 = default(bool[]);
        ushort var11 = default(ushort);
        C0 var12 = default(C0);
        int var13 = default(int);
        I0 var14 = default(I0);
        S0 var15 = default(S0);
        C0 var16 = default(C0);
        for (int var0 = 0; var0 < 2; var0++)
        {
            var1 = arg2;
            {
                try
                {
                    arg5[0] = 1798327864495113260L;
                }
                finally
                {
                    if (!arg1)
                    {
                        var2 = this.F3;
                        arg2.F1 = arg5[0];
                        var3 = new byte[]{0, 1, 132, 31, 2, 0, 0};
                    }
                    else
                    {
                        this.F3 = (sbyte)(~this.F1);
                        var4 = arg1;
                        Program.s_19 = arg3[0].F1++;
                        arg2 = arg2;
                        Program.s_1[0] = Program.s_18;
                        arg3[0].M28();
                        var1 = new S1(1, 5158514456529994885L, 24725);
                        if (arg1)
                        {
                            new C0(-128, 0, false).M34() = new S1(0, -7896020701766610495L, -2);
                            arg0 = arg3[0].F1;
                            var5 = arg3[0];
                        }

                        try
                        {
                            this.F5 = (byte)Program.M35(ref this.F2);
                            new C0(-2, 172, false).M34() = Program.s_28;
                            ref byte var6 = ref this.F2;
                            var7 = arg3[0].F2;
                            Program.M40(Program.s_32[0].F0);
                        }
                        finally
                        {
                            var8 = arg3[0];
                            var9 = var1;
                        }

                        Program.s_21[0][0, 0].F0 += this.F3;
                        Program.s_27[0].F2 = arg1;
                    }

                    var10 = new bool[]{true, false, false, true, false, false, true, true, true, false};
                    var11 = arg0;
                    var11 = Program.s_19;
                }

                var12 = Program.s_27[0];
            }
        }

        if (arg1)
        {
            Program.s_36 = new S0(1UL, -1, 122, 126, 1L, 1, 2L, 11121547783260682408UL, -1496147350332932508L);
            arg3[0].F0 = arg2.F0--;
            if (arg1)
            {
                Program.s_27[0].F0 = this.F1++;
            }

            var13 = 514644322;
            if (arg1)
            {
                Program.M33();
                Program.s_4 = Program.s_36.F0;
                var14 = this;
                var15 = this;
                new S1(0, 0L, 22889).M37(ref arg3[0], Program.s_36.F4);
            }

            new C0(0, 1, false).M34() = Program.s_28;
        }

        arg2.M37(ref arg3[0], this.F4);
        Program.s_23 = new C0(1, 10, true);
        var16 = Program.s_16.M43(0);
        new C0(1, 114, false).M34() = new S1(10, 0L, 0);
        return new long[]{1L, -1706405095976566969L, 0L, -2165899968144586854L, 1L, 1L};
    }

    public short M36(long arg0, ref uint[][] arg1, I0 arg2)
    {
        this.F5 = new S1(10, 5054604445126639016L, 0).M37(ref Program.s_5[0][0, 0, 0], this.F4);
        new S0(5718224841816132531UL, -6, 1, -127, -6762926671395305686L, 140, 7700132951987558511L, 2669718628277691026UL, -2369349753610740008L).M38(new ulong[]{1UL, 18446744073709551615UL}, 2);
        return Program.s_18.F2;
    }

    public ushort M38(ulong[] arg0, ushort arg1)
    {
        uint[] var3 = default(uint[]);
        try
        {
            ref long var0 = ref this.F8;
        }
        finally
        {
            if (Program.s_22)
            {
                ref sbyte var1 = ref Program.s_7;
            }
            else
            {
                Program.s_23 = Program.s_16;
            }
        }

        this.F2 = Program.s_16.F1;
        this.F0 = this.F0;
        for (int var2 = 0; var2 < 2; var2++)
        {
            if (Program.s_22)
            {
                this.F2 = this.F5;
                Program.s_5[0][0, 0, 0] = new C1(32766, 54282, 52473);
                Program.M39();
            }
            else
            {
                if (!Program.s_23.F2)
                {
                    this.F4 = Program.s_6.F6++;
                    try
                    {
                        var3 = new uint[]{1U, 449983641U, 1609267378U, 0U, 1686721275U, 990726639U, 4018483876U, 0U, 4294967295U};
                    }
                    finally
                    {
                        this.F2 = this.F5;
                        this.F3 = Program.s_16.F0;
                    }

                    return arg1;
                }

                this.F8 = this.F6;
                ref S0 var4 = ref this;
            }
        }

        this.F8 = this.F4;
        this.F3 = this.F1;
        this.F3 = (sbyte)(Program.s_6.F6 >> (byte)(18000170519460592326UL & arg0[0]));
        this.F7 = ~Program.s_6.F0;
        this = new S0(1UL, -120, 0, 10, -9223372036854775808L, 108, 1L, 1UL, 2538939456161972969L);
        return 11936;
    }

    public I0 M44(ref short arg0)
    {
        new S1(-20181, 4945753991742763672L, 16441).M45();
        this.F5 = 0;
        {
            this.F6 = (long)(184 + arg0--);
        }

        return this;
    }

    public short M53()
    {
        ushort[] var0 = default(ushort[]);
        sbyte var2 = default(sbyte);
        C1 var3 = default(C1);
        {
            var0 = new ushort[]{1, 0, 34207, 30317, 53115, 1, 1};
            this.F4 = ~this.F6;
            Program.M54(ref this.F2, Program.s_18, Program.s_46[0].F2, ref this);
            {
                this.F8 = (long)Program.M56();
                Program.M54(ref this.F5, new S1(-31243, 1L, -7951), Program.M59(), ref this);
            }

            if (Program.s_22)
            {
                for (int var1 = 0; var1 < 2; var1++)
                {
                    this.F4 = this.F4;
                }

                var0[0] = Program.M59();
            }
        }

        {
            this.F8 = -7042109289306699078L;
            var2 = (sbyte)Program.M59();
            var3 = Program.s_5[0][0, 0, 0];
        }

        this.F8 >>= -1;
        return 1;
    }

    public S1 M55()
    {
        S0[, ] var0 = default(S0[, ]);
        Program.M56();
        var0 = new S0[, ]{{new S0(893060457768719818UL, -21, 110, -5, 9223372036854775806L, 1, -3045740391901813445L, 0UL, 1L), new S0(9591503660606568125UL, 75, 5, 1, -6783040196720167019L, 29, -9223372036854775807L, 9040364023587819021UL, -2L), new S0(1UL, -2, 255, 26, -9223372036854775807L, 49, -9223372036854775807L, 18446744073709551614UL, 2633997794563652835L), new S0(18446744073709551615UL, 1, 0, -128, -3750683363512243095L, 134, -4177486285698028211L, 2665652529389053269UL, 9223372036854775806L), new S0(1UL, 127, 35, -38, -4133489671242008947L, 0, 5458402020457096765L, 10556320955215533170UL, -9223372036854775807L), new S0(18446744073709551615UL, 0, 207, 0, 0L, 25, 0L, 12384656560951833903UL, 10L), new S0(2490658750298516995UL, -87, 94, 127, -1L, 255, -4092262429349582600L, 14484754788787678314UL, -6979206794368623232L), new S0(18446744073709551614UL, 97, 166, -67, 1L, 1, -9223372036854775807L, 14581269033440123784UL, 9223372036854775806L)}, {new S0(1478736953534625980UL, 2, 192, 2, -1944360884191409898L, 153, 1702768067129980412L, 2UL, 5797052773193763911L), new S0(17454536429092134289UL, 0, 254, 126, 4331086384726504189L, 2, -8543903572162182197L, 18446744073709551614UL, -2L), new S0(17413091680920937785UL, 0, 1, 0, -7128346711723922835L, 124, 8058621471405667747L, 2948503682458514509UL, -539513981908134127L), new S0(2929865643238673655UL, 1, 239, 13, 1472841173550754645L, 254, -9223372036854775807L, 7691910424721771026UL, -6978068083447630009L), new S0(18446744073709551614UL, 127, 90, 10, -5354340313852806505L, 1, 7262474566222478112L, 18446744073709551614UL, 1714098873338501254L), new S0(7441012686120742650UL, 0, 173, -79, -7755179537850421579L, 16, 1363610667743942272L, 0UL, 5253575842432072299L), new S0(1963453754246820007UL, 1, 0, 64, 5362876743687973684L, 83, 4396010720767412790L, 2910553388619411528UL, 10L), new S0(4966566786030137427UL, 69, 0, -2, -7220444204768312382L, 254, 0L, 4781278411072187575UL, 1903581745599070104L)}};
        Program.M56();
        return new S1(23648, 2L, -8752);
    }

    public short M74(ref C0[] arg0, long arg1)
    {
        long var0 = default(long);
        var0 = -10L;
        Program.s_18 = new S1(1, 908405631824207838L, -4941);
        {
            arg0[0].F1 = arg0[0].F1;
            arg1 = -1198725193290149068L;
        }

        return Program.s_17.F0;
    }

    public int M78()
    {
        Program.M79(Program.s_32[0].F2--);
        Program.s_20 = Program.s_26[0]++;
        return ~Program.s_58;
    }

    public ref bool M82(int arg0, sbyte[] arg1, ref uint arg2)
    {
        sbyte[] var0 = default(sbyte[]);
        I0[][] var1 = default(I0[][]);
        return ref Program.s_44;
    }

    public short[] M83()
    {
        short var0 = default(short);
        I0 var1 = default(I0);
        bool[] var2 = default(bool[]);
        var0 = Program.M84(Program.s_27[0].F1, Program.s_30++, this, !!Program.s_31.F2);
        this.M85(new C1(-32768, 0, 0), this.F7);
        var1 = this;
        this.F7--;
        Program.M84(this.F2, 0U, new S0(18446744073709551614UL, 38, 20, 1, -7557520967113927321L, 0, -1697857809321343787L, 18446744073709551614UL, 1400785712320450098L), true);
        {
            var1 = new S0(this.F0, this.F1, this.F2, this.F3, -1407435257052361536L, 0, (long)Program.M84(1, 0U, var1, false), (ulong)Program.M84((byte)(~this.F5), Program.s_30, var1, Program.s_23.F2), Program.s_75[0, 0, 0] / (long)(this.F6 | 1));
            Program.s_69 = this.F5;
            var2 = new bool[]{true, true, true, false, true, false, true};
        }

        return new short[]{-31229};
    }

    public C1 M85(C1 arg0, ulong arg1)
    {
        C1 var1 = default(C1);
        for (int var0 = 0; var0 < 2; var0++)
        {
            var1 = arg0;
            Program.s_84 = new C0(108, 1, false);
        }

        return arg0;
    }

    public sbyte M91(int arg0)
    {
        C1 var0 = default(C1);
        ushort var1 = default(ushort);
        S0 var2 = default(S0);
        long var3 = default(long);
        sbyte var4 = default(sbyte);
        sbyte var5 = default(sbyte);
        I0 var6 = default(I0);
        S1 var7 = default(S1);
        sbyte[] var8 = default(sbyte[]);
        C1 var10 = default(C1);
        S1 var11 = default(S1);
        Program.s_31 = Program.s_21[0][0, 0];
        {
            if (Program.s_50.F2)
            {
                this = new S0(18446744073709551615UL, -10, 23, 41, 2654334464883265452L, 2, 9223372036854775807L, 18446744073709551615UL, 4470573569987931585L);
                if (Program.s_31.F2)
                {
                    var0 = new C1(-30212, 1, 20364);
                    Program.s_20 = var0.F1;
                    arg0 = -464384686;
                    --this.F8;
                }
                else
                {
                    var1 = 28677;
                    this.F5 = this.F5;
                    this.F4 = 445414684 / (long)(this.F8 | 1);
                }
            }

            var2 = this;
            if (1UL >= this.F2)
            {
                var3 = var2.F6;
                var4 = -10;
                var5 = var2.F1;
            }
            else
            {
                Program.s_19 = 0;
                var6 = this;
                {
                    {
                        this.F4 = this.F4;
                        this.F4 = this.F6++;
                        var7 = new S1(19242, 9088881520221136215L, 32766);
                    }

                    var8 = new sbyte[]{-100, -128, 126, 0, 1, 70, 109, -1, -2, -10};
                    ref I0 var9 = ref var6;
                    var10 = Program.s_53;
                    var11 = new S1(-31048, -2L, 15514);
                    var9 = ref Program.s_63;
                    Program.s_88 = new C1[]{new C1(-1, 6249, 7691), new C1(-10, 59315, 48689), new C1(-10, 10688, 1), new C1(32767, 6357, 25246), new C1(-2430, 1, 21855), new C1(32766, 65534, 61107), new C1(-18859, 1, 25846), new C1(13215, 0, 1), new C1(-11493, 23395, 14399), new C1(0, 65534, 0)};
                    Program.M92();
                    var6 = var6;
                }

                var2 = var2;
                new C1(25451, 64169, 0).M99((uint)new S1(18513, 0L, 5185).M107(ref Program.s_51)) = (short)new S0(15524266224145203985UL, -10, 1, 127, -10L, 255, 1L, 1UL, -2121012124853068298L).M97(new S1(1, -6118471144167618534L, -32768));
                Program.s_109 = new long[]{1L, 153315057660803245L, 1L, -3681935996591755788L, 0L, 9223372036854775806L, 3033514851760944311L, 2823912693774738768L};
                --var2.F5;
                Program.s_110 = var2.F3;
                Program.s_86.F1 = (byte)(-var2.F2);
            }
        }

        this.F5 = Program.s_64--;
        return this.F3;
    }

    public int M97(S1 arg0)
    {
        int var0 = default(int);
        ulong var1 = default(ulong);
        S0 var2 = default(S0);
        long var3 = default(long);
        S0 var4 = default(S0);
        C0 var5 = default(C0);
        int var6 = default(int);
        bool var7 = default(bool);
        S0 var8 = default(S0);
        long[] var9 = default(long[]);
        long var10 = default(long);
        ulong var11 = default(ulong);
        var0 = Program.s_58--;
        if (arg0.F0 > 10)
        {
            this.F1 = this.F3;
            if (var0 >= ~var0)
            {
                arg0.M98(new S1(-17602, 997095437453008718L, -27450), 0, new uint[, ]{{3382542077U, 1U, 1148339725U, 1U, 1U, 4294967295U}, {2107568547U, 2U, 0U, 1335912391U, 829521602U, 1U}, {2218528233U, 2049060810U, 399588880U, 0U, 1U, 3428584356U}, {1U, 1839868600U, 1U, 3795480119U, 1712887351U, 0U}, {1U, 1552887893U, 1U, 4144842931U, 1U, 4294967294U}, {0U, 4211229906U, 0U, 1U, 4256049825U, 3840464300U}, {4294967294U, 0U, 1U, 0U, 4131158444U, 4250755882U}, {0U, 1U, 3375619244U, 0U, 3169212744U, 3395665067U}, {2040549927U, 0U, 75194629U, 1044903703U, 3730563098U, 0U}, {4294967295U, 782937648U, 3820629420U, 0U, 2502268349U, 4294967295U}}, Program.s_36.F0++, Program.s_58);
                Program.M101();
                var1 = this.F0;
                arg0.F1 = Program.M101();
                var2 = this;
                {
                    Program.s_24.F8 = this.F8;
                    arg0.M102();
                }
            }

            {
                if (!!!Program.s_27[0].F2)
                {
                    var3 = 7322993961193597806L;
                    {
                        {
                            Program.M100(Program.s_79.F0);
                            Program.s_96 = this.F5;
                        }

                        var4 = new S0(this.F7, 11, 0, this.F3, this.F6, Program.s_73.F5, (long)Program.M100(Program.s_47), this.F7, this.F8);
                        var4 = new S0(18217939362389108931UL, 32, 0, 1, 8279630364542332847L, 135, -2716715750669677523L, 1163590324102799857UL, 1L);
                        var5 = new C0(-116, 46, false);
                        if (Program.s_40)
                        {
                            var6 = var0;
                            var7 = !var5.F2;
                        }
                        else
                        {
                            Program.s_63 = new C1(0, 65006, 47425).M106();
                            new S1(-12916, -6218585568946180549L, 10).M103();
                            var8 = arg0.M103();
                            Program.M104().M99(Program.s_54[0]++);
                            Program.M101();
                            arg0.M102();
                            new C1(-32767, 8497, 8929).M106();
                            var9 = new long[]{-2L, -437237828667368144L, 0L, -9204383557279379057L, -8829531192468763200L, 8463198317038735754L, 1L};
                        }

                        Program.s_97 &= arg0.M102();
                    }

                    return -(int)Program.M101();
                }
            }

            Program.M104();
            if (Program.s_29[0, 0, 0])
            {
                {
                    arg0.M98(arg0, (short)Program.M100((short)Program.M100(-17826)), new uint[, ]{{983167356U}, {0U}, {2397635437U}, {2154895027U}, {433325993U}, {4086589508U}, {1U}}, this.F7, var0);
                    var0++;
                    this.F2 = Program.s_36.F5;
                    var10 = arg0.F1;
                    Program.s_84.F0 = new C0(2, 204, false).M105(this.F1, Program.s_1, this.F5);
                    new C1(32766, 0, 1).M106();
                    {
                        return arg0.M107(ref arg0);
                    }
                }
            }

            this.F4 = (long)(1 | this.F1);
        }

        var11 = this.F7;
        return -2056583308;
    }
}

public struct S1
{
    public short F0;
    public long F1;
    public short F2;
    public S1(short f0, long f1, short f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }

    public C0 M5()
    {
        C1[] var0 = default(C1[]);
        C0 var1 = default(C0);
        uint[] var2 = default(uint[]);
        if (!!!!(true || !(false && (this.F2 != 0))))
        {
            if (!!!!(127 < (byte)(~(byte)(-(byte)(~(byte)(0 - (byte)(-(byte)(0 - (byte)(~(byte)(~(byte)(~(byte)(0 << (ushort)(~Program.s_23.M6(new S0(16710841568026751707UL, 127, 1, -2, 1L, 253, -9223372036854775808L, 13492877270247485878UL, -10L)))))))))))))))
            {
                {
                    var0 = Program.s_88;
                    var0[0].F2 = var0[0].F2;
                }

                this.F2 %= (short)(this.F2 | 1);
                Program.M73();
                var1 = this.M45();
            }
            else
            {
                Program.s_50.F1 = (byte)new S1(14787, -9223372036854775808L, 3116).M12();
            }

            Program.s_50 = new C0(-66, 99, false);
            var2 = Program.s_54;
            return new C0(-115, 87, false);
        }

        return new C0(-86, 254, true);
    }

    public C1 M9()
    {
        C1 var0 = default(C1);
        ulong[][] var1 = default(ulong[][]);
        this.F0 = this.F0;
        var0 = new C1(-18988, 1, 65534);
        var0.F1 = (ushort)(new C1(140, 49740, 11437).M10() % (int)(-525216884 | 1));
        Program.s_1[0].F1 = Program.s_1[0].F1;
        var1 = new ulong[][]{new ulong[]{1UL, 0UL, 1UL}, new ulong[]{0UL, 1UL, 14652115768533088549UL}, new ulong[]{1UL, 18117528223174721510UL, 8821313281349164304UL, 0UL}, new ulong[]{2UL, 7431421266471640506UL}, new ulong[]{13694848625026531811UL, 17570003313047749228UL}, new ulong[]{10781057612978004685UL, 7301878137508480664UL, 537092836704193368UL, 1846645740525240753UL}, new ulong[]{15870488931721676779UL}, new ulong[]{0UL}};
        this.F2 = var0.F0;
        var0.F1 = 9774;
        if (!!(127 < (byte)(Program.M11(true, new bool[][]{new bool[]{true}, new bool[]{false, true, false}, new bool[]{true, false, true}}, new ushort[]{0, 33872, 6074, 41615, 21477, 1}, 2810356540U) << var0.F0)))
        {
            ref bool[] var2 = ref Program.s_2;
        }

        return new C1(-15540, 39250, 40831);
    }

    public uint M12()
    {
        this.F1--;
        if (Program.s_2[0])
        {
            this.F0 = this.F2;
        }

        this.F2 = (short)((byte)(0 >> (ushort)(139 << (byte)(4294967294U / (long)(this.F1 | 1)))) >> (sbyte)(~Program.s_3--));
        this.M13((int)(2237942011U | (ushort)(+Program.s_5[0][0, 0, 0].F1)));
        return 4235785921U;
    }

    public short[] M13(int arg0)
    {
        C1 var2 = default(C1);
        C0 var3 = default(C0);
        try
        {
            if (!new C1(-12690, 20772, 1).M14())
            {
                ref ulong var0 = ref Program.s_4;
                new C1(2, 0, 4592).M14();
            }
        }
        finally
        {
            this.F1 = this.F1;
            try
            {
                Program.s_1[0] = new S1(18064, -8470170597013217231L, 2);
                if (1 > Program.s_3)
                {
                    Program.s_1[0].F2 = this.F2;
                    ref C1[][,, ] var1 = ref Program.s_5;
                    this = this;
                    var1[0][0, 0, 0] = var1[0][0, 0, 0];
                }
            }
            finally
            {
                var2 = new C1(-26393, 45865, 1);
            }

            var3 = new C0(-128, 22, false);
        }

        this.F1 = this.F1++;
        new C1(-32768, 0, 2).M14();
        return new short[]{32767, -16361, 17825, 25768, -32767, -3666, 13887};
    }

    public sbyte M29(short arg0, sbyte arg1)
    {
        return default(sbyte);
    }

    public byte M37(ref C1 arg0, long arg1)
    {
        uint var0 = default(uint);
        ulong var1 = default(ulong);
        I0 var3 = default(I0);
        ushort var4 = default(ushort);
        C1[] var5 = default(C1[]);
        sbyte[] var6 = default(sbyte[]);
        if (!Program.s_9)
        {
            Program.s_1[0].F1 = arg1;
            {
                arg1 = arg1;
                var0 = Program.s_12;
                var1 = 14546322000298747641UL;
            }
        }
        else
        {
            {
                Program.s_8[0] = this.F0;
                ref ulong var2 = ref Program.s_6.F0;
                if (167 >= Program.s_6.F7)
                {
                    this.F1 = this.F1;
                    Program.s_5[0][0, 0, 0].F1 = arg0.F2--;
                    {
                        {
                            Program.s_6.M38(new ulong[]{10UL, 1UL, 8102319478660417502UL, 1UL, 18446744073709551615UL, 1UL, 7511185167815260917UL, 4256129219536778545UL}, arg0.F1);
                        }
                    }

                    var3 = new S0(7979408252113698718UL, 3, 1, -53, 9223372036854775807L, 1, 0L, 1UL, 7489709748087903123L);
                    var4 = 0;
                    var2 = var2;
                    var3 = var3;
                    Program.s_24 = Program.s_24;
                    var5 = new C1[]{new C1(5869, 0, 2), new C1(2260, 65535, 65535), new C1(21766, 18614, 31340), new C1(-31623, 1, 63730), new C1(32766, 65535, 56213), new C1(-2, 0, 31932), new C1(1, 0, 0), new C1(27882, 28005, 0)};
                }
            }

            this = this;
        }

        try
        {
            {
                Program.M39();
                var6 = new sbyte[]{1, 25, 0, -128, 127, 10};
                return Program.s_16.F1;
            }
        }
        finally
        {
            this.F2 = this.F0;
        }

        {
            this.F0 = arg0.F0;
            Program.s_1[0] = this;
            if (!!Program.s_16.F2)
            {
                arg0.F0 = (short)((ulong)Program.s_6.M38(new ulong[]{11777605647834569597UL, 1UL, 1UL, 18446744073709551614UL}, arg0.F1) ^ arg0.F2);
                this.F1 = 0L;
                ref C0 var7 = ref Program.s_23;
            }
            else
            {
                this.F0 = (short)new S0(17958531878922985033UL, -128, 49, 127, -5335354815140191269L, 120, -5858547034448468337L, 18446744073709551614UL, 9223372036854775807L).M38(new ulong[]{1UL, 18446744073709551615UL, 4497418640053424382UL, 2665688238221298811UL, 1UL, 0UL, 18446744073709551614UL}, new S0(404133801963698194UL, 60, 0, 52, -6371420883443764891L, 159, -105995814957166599L, 1UL, 7973328607383288104L).M38(new ulong[]{18446744073709551614UL, 1UL, 1UL}, 46076));
            }
        }

        this.F2 = (short)(arg0.F2 + -10);
        return 0;
    }

    public C0 M45()
    {
        this.F1 <<= -(-~(int)(-2850237518354844144L & Program.s_3));
        this.F1 += ~this.F1;
        return new C0(21, 152, true);
    }

    public bool M50(C1 arg0, uint arg1)
    {
        short[] var2 = default(short[]);
        I0[] var3 = default(I0[]);
        ulong[] var4 = default(ulong[]);
        int var5 = default(int);
        I0 var6 = default(I0);
        C1 var7 = default(C1);
        uint var8 = default(uint);
        C1 var9 = default(C1);
        ushort var10 = default(ushort);
        C1 var11 = default(C1);
        this = this;
        arg0.F1 = arg0.F1++;
        try
        {
            if (!((Program.s_36.F7 >= 1) && false))
            {
                ref I0 var0 = ref Program.s_34;
                this.F1 = this.F1;
                if (1U > Program.s_6.F1++)
                {
                    this.M51(Program.s_27[0]);
                    arg0 = new C1(3831, 65534, 0);
                    ref uint var1 = ref arg1;
                    Program.s_43 = Program.s_36.F6--;
                    var0 = new S0(1UL, -66, 18, 0, 2L, 98, 0L, 8326237490336487502UL, 10L);
                    var2 = new short[]{-10, 22798, 20466, 4502};
                    this.F0 = -12270;
                }
                else
                {
                    new S1(-6282, 1576135624808866051L, 0).M51(this.M51(new C0(1, 0, true)));
                }

                if (0 > Program.s_38++)
                {
                    var3 = new I0[]{new S0(1UL, 123, 255, -128, 0L, 0, 9121987498225977858L, 8566478382448059735UL, 0L)};
                    var4 = new ulong[]{4632368654920900154UL, 1UL, 13390470130418275900UL, 4444153676881789985UL, 0UL, 18446744073709551614UL, 1930854622604462050UL, 1UL, 1UL};
                    var5 = 378210891;
                    Program.s_36.F0 = var4[0];
                }

                arg0.F1 = arg0.F2;
            }

            Program.s_32[0].F1 = arg0.F2;
            var6 = new S0(1UL, 34, 175, 10, 9223372036854775807L, 255, 10L, 1UL, 5236037305576206100L);
            this.F1 = Program.s_6.F4;
            Program.s_17.F2 = 0;
            try
            {
                Program.s_18.M51(Program.s_23);
            }
            finally
            {
                this.M51(new C0(127, 0, true));
            }

            var7 = new C1(2, 4142, 8757);
        }
        finally
        {
            var8 = 1U;
            var9 = new C1(-4914, 1, 1);
            if (Program.s_23.F2)
            {
                this = this;
                try
                {
                    try
                    {
                        var10 = var9.F2;
                    }
                    finally
                    {
                        this.F2 = arg0.F0++;
                        var8 = Program.s_25[0][0]--;
                        Program.s_36.F1 %= (sbyte)((sbyte)(-(sbyte)((uint)(-18 & new C0(-10, 1, false).M52(Program.s_42[0].F3, arg1, new sbyte[]{18, -23}, ref arg1, ref Program.s_46)) & 5909184475865761644UL)) | 1);
                    }
                }
                finally
                {
                    var9 = Program.s_5[0][0, 0, 0];
                }

                var11 = Program.s_32[0];
            }
        }

        return Program.s_9;
    }

    public C0 M51(C0 arg0)
    {
        ulong var0 = default(ulong);
        var0 = Program.s_24.F0--;
        this.F2 = Program.s_28.F2--;
        this = this;
        return new C0(30, 127, true);
    }

    public ulong[] M63(byte arg0, sbyte arg1, C0 arg2)
    {
        ushort var0 = default(ushort);
        var0 = 27618;
        return new ulong[]{0UL};
    }

    public bool M81()
    {
        short var0 = default(short);
        long var1 = default(long);
        short var3 = default(short);
        long[] var4 = default(long[]);
        byte var5 = default(byte);
        S0 var6 = default(S0);
        this.F2 = Program.s_5[0][0, 0, 0].F0++;
        if (Program.s_70)
        {
            var0 = this.F2++;
            var1 = this.F1;
        }

        for (int var2 = 0; var2 < 2; var2++)
        {
            var3 = (short)(~(short)(-Program.s_79.F0++));
        }

        this = this;
        this.F1 = -4226080582381613214L;
        this = this;
        {
            this.F2 = this.F0;
            var4 = new long[]{4213667947905514265L, 1L, 1L, 1L, 5039513101181534091L, 1L, -7670280859064141677L, 652613047218037460L};
            {
                new S0(0UL, -69, 0, -127, 2637663292773152396L, 254, -623482689134514590L, 7399509591241038032UL, -9223372036854775807L).M82(Program.s_76, new sbyte[]{126, 103, 1, -128, -59, 1, 41, 10, -98, -62}, ref Program.s_83[0]);
                Program.s_68[0] = -3419545018266510512L;
                Program.s_25[0] = Program.s_83;
                var4 = new long[]{-9223372036854775807L, 2106770454011132271L, -9223372036854775808L, -1L};
                new S0(18446744073709551614UL, 127, 45, -54, 7122539586913310025L, 206, -4265048553885117005L, 0UL, 1L).M85(Program.s_46[0], (ulong)Program.M84((byte)Program.M84((byte)Program.M84(Program.s_64, (uint)(var4[0] & 699741512), new S0(0UL, 1, 1, -128, 0L, 170, 1L, 0UL, -1990687056433173049L), true), Program.s_75[0, 0, 0]++, Program.s_56, false), 3332634161U, new S0(10583340966854742747UL, 127, 1, 123, -7438882555865087765L, 1, -9223372036854775807L, 7546075989298633956UL, 9223372036854775806L), true));
            }

            var4[0] = var4[0];
            var5 = (byte)(-2L - this.F2);
        }

        {
            Program.s_70 |= false;
            var6 = new S0(11352905392693089600UL, -127, 49, -96, -10L, 0, 806355153002011669L, 7571860003821174952UL, 9223372036854775807L);
            var6.F2 = var6.F5;
        }

        return new S0(12098276009336188650UL, -127, 0, -127, 1807990074341582259L, 1, -9223372036854775807L, 16122335656427765293UL, 0L).M82(Program.s_38--, new sbyte[]{-10, 126, 26}, ref Program.s_75[0, 0, 0]);
    }

    public ref C0 M87(ref byte arg0)
    {
        bool var0 = default(bool);
        bool var1 = default(bool);
        this.F0 = this.F2;
        var0 = true;
        if (var0)
        {
            var1 = var0;
            new C0(95, 210, false).M88();
            if (var1)
            {
                this.F1 = this.F1;
            }
        }

        return ref Program.s_84;
    }

    public ref int M98(S1 arg0, short arg1, uint[, ] arg2, ulong arg3, int arg4)
    {
        long var1 = default(long);
        S1 var2 = default(S1);
        ulong var3 = default(ulong);
        byte[, ] var4 = default(byte[, ]);
        long var5 = default(long);
        S0[] var6 = default(S0[]);
        byte var7 = default(byte);
        int var11 = default(int);
        sbyte[] var13 = default(sbyte[]);
        S0 var14 = default(S0);
        ulong var15 = default(ulong);
        return ref Program.s_74;
    }

    public uint M102()
    {
        this = this;
        Program.s_79.M103();
        return (uint)(1 % (sbyte)((sbyte)(1 / (sbyte)(Program.s_36.F1 | 1)) | 1));
    }

    public S0 M103()
    {
        return default(S0);
    }

    public int M107(ref S1 arg0)
    {
        if (Program.s_9)
        {
            Program.s_89.F8 = Program.s_6.F6;
        }

        return -Program.s_38;
    }

    public uint[, ] M116(short arg0, short arg1, ref sbyte arg2)
    {
        return default(uint[, ]);
    }
}

public class C1
{
    public short F0;
    public ushort F1;
    public ushort F2;
    public C1(short f0, ushort f1, ushort f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }

    public bool M1(sbyte arg0, short arg1, C1 arg2)
    {
        C1[] var0 = default(C1[]);
        C1 var1 = default(C1);
        var0 = new C1[]{new C1(-1348, 18390, 57856), new C1(32766, 58567, 55571), new C1(32767, 1, 53506), new C1(-32767, 1, 63126), new C1(9717, 52966, 1), new C1(-29053, 6061, 1)};
        Program.M2(!Program.M23(ref Program.s_1), var0, ref Program.M101());
        arg2.F0 = 1;
        var1 = this;
        return true;
    }

    public ushort M10()
    {
        if (2U > (ulong)((ushort)(1 / (uint)((uint)((byte)(~(byte)(9223372036854775807L + (byte)(this.F1 / (short)(Program.s_1[0].F0 | 1)))) / (sbyte)(-128 | 1)) | 1)) + (sbyte)(~(sbyte)(~(sbyte)(~(sbyte)(958230132 + (byte)(1 | (sbyte)(0 | Program.s_1[0].F1))))))))
        {
            {
                this.F0 = (short)(175 << this.F1);
            }
        }

        this.F2 = 64458;
        return 65535;
    }

    public bool M14()
    {
        this.F2 = this.F1;
        ref bool var0 = ref Program.s_2[0];
        return var0;
    }

    public bool M18(bool[] arg0, byte arg1)
    {
        return default(bool);
    }

    public ref C1 M19(ref byte arg0)
    {
        uint var0 = default(uint);
        I0[] var1 = default(I0[]);
        short[] var2 = default(short[]);
        if (Program.s_2[0])
        {
            var0 = 1U;
        }
        else
        {
            if (Program.s_2[0])
            {
                var1 = new I0[]{new S0(6134716082547842957UL, 127, 145, -102, 3782464668090688438L, 19, 3154751169797485466L, 0UL, 9223372036854775807L), new S0(18446744073709551615UL, -2, 254, 36, -9223372036854775807L, 0, -6335897990959546307L, 17469816857894812883UL, -8475453496173408334L)};
                Program.M20(Program.M20(this));
            }
            else
            {
                var2 = new short[]{2, -13580, 3112, 32767, -24104, 21734};
                this.F0 = var2[0];
            }
        }

        return ref Program.s_5[0][0, 0, 0];
    }

    public C0 M21()
    {
        C0[] var0 = default(C0[]);
        var0 = new C0[]{new C0(126, 142, true), new C0(0, 194, false), new C0(-74, 10, false), new C0(127, 1, true), new C0(91, 0, true), new C0(70, 1, true)};
        return var0[0];
    }

    public bool M22(I0 arg0)
    {
        ulong var1 = default(ulong);
        S0 var2 = default(S0);
        uint var3 = default(uint);
        byte[][] var4 = default(byte[][]);
        S0 var5 = default(S0);
        if (Program.s_2[0])
        {
            if (Program.s_9)
            {
                Program.s_11 = Program.s_11;
                try
                {
                    Program.M23(ref Program.s_1);
                    Program.M25(Program.s_12, this.F1);
                }
                finally
                {
                    ref C0 var0 = ref Program.s_16;
                    arg0 = arg0;
                }

                var1 = 1UL;
                var1 = var1;
            }

            if (Program.s_6.F3 != ~Program.s_12++)
            {
                Program.s_17 = Program.s_1[0];
                Program.M25(0U, 54290);
                this.F1 = 44033;
                this.F2 = this.F1;
                Program.s_10 = 103;
                var2 = new S0(13331004114361410253UL, -110, 81, -3, 0L, 153, -4223282101510619290L, 10724372000476034417UL, -2L);
            }
        }

        var3 = 1U;
        Program.M25(var3--, (ushort)(~this.F2)) = new S1(-24645, -9223372036854775808L, -13702);
        var4 = new byte[][]{new byte[]{1, 114, 65}, new byte[]{12, 0, 207, 1, 190, 245, 1, 246, 249, 1}};
        var5 = new S0(18446744073709551614UL, -42, 10, 121, 9223372036854775807L, 1, 1L, 2169734914499557307UL, 2239247498138057324L);
        return Program.M24();
    }

    public short M28()
    {
        sbyte var0 = default(sbyte);
        bool var1 = default(bool);
        var0 = Program.s_3++;
        try
        {
            var1 = false;
        }
        finally
        {
            Program.s_7 = var0;
            Program.s_5[0][0, 0, 0].F2 = this.F2;
        }

        var0 = 1;
        if (!!!Program.s_2[0])
        {
            var0 += new S1(32363, 0L, 22880).M29(-28250, (sbyte)Program.M33());
        }

        this.F2--;
        this.F1 = (ushort)((ushort)(~Program.s_13) | (byte)(-(byte)(-Program.s_27[0].F1)));
        return this.F0;
    }

    public long[, ] M31()
    {
        return default(long[, ]);
    }

    public ulong M49(byte arg0)
    {
        return default(ulong);
    }

    public bool M60()
    {
        Program.s_32 = new C1[]{new C1(18674, 64890, 43744), new C1(-25475, 29092, 26201), new C1(-11894, 0, 11020), new C1(-31901, 10470, 55681)};
        return false;
    }

    public sbyte M64()
    {
        return default(sbyte);
    }

    public ushort M65()
    {
        uint var0 = default(uint);
        var0 = (uint)(-Program.s_30--);
        var0 = Program.s_12--;
        Program.M71(Program.s_42[0], 3566411060U, new C1(0, 65534, 1), (sbyte)Program.M70(this.F0), new long[][]{new long[]{-6418261715812037661L}, new long[]{-9223372036854775807L}, new long[]{0L, 5970627056432606438L, 9223372036854775807L, 0L}, new long[]{-6772126501113167211L, -2L, 9223372036854775806L, -656376225051150099L}, new long[]{-10L, -9223372036854775808L, -2L, 9223372036854775807L}}, var0, ref Program.s_75).M66(new ushort[]{65535, 29878, 52088, 40762, 0, 21126}, this.F0, this);
        return (ushort)(22 * Program.s_74--);
    }

    public ref sbyte M66(ushort[] arg0, short arg1, C1 arg2)
    {
        short var0 = default(short);
        sbyte var1 = default(sbyte);
        S1[] var2 = default(S1[]);
        S1 var3 = default(S1);
        I0 var4 = default(I0);
        I0 var5 = default(I0);
        try
        {
            var0 = 32766;
            var1 = 1;
        }
        finally
        {
            if (Program.s_22)
            {
                Program.s_56 = new S0(18446744073709551614UL, 0, 52, 64, -10L, 1, -9223372036854775807L, 0UL, 1L);
                Program.M67(Program.M79(Program.s_13--), arg2.F1, new C0[][]{new C0[]{new C0(10, 1, true)}, new C0[]{new C0(1, 1, false)}, new C0[]{new C0(2, 203, false), new C0(-121, 84, true)}, new C0[]{new C0(127, 254, true), new C0(-52, 254, true)}});
            }
            else
            {
                var2 = new S1[]{new S1(12900, -1234938095328549785L, -1), new S1(-31087, -9127186660482885222L, -13033), new S1(32766, 8755249871489906977L, -14485)};
                var3 = var2[0];
                Program.s_78 = Program.M68((ushort)(409393658 ^ var2[0].F0));
                var3 = Program.s_17;
            }

            if (Program.M68(arg2.F2))
            {
                Program.s_18.F1 -= 2943733625132261607L;
                arg0[0] = Program.s_33;
                var4 = new S0(3037876970559400094UL, -33, 111, 0, 2569226957575102089L, 5, 581182869339204749L, 1UL, 0L);
                var5 = var4;
            }
            else
            {
                this.F2 = (ushort)(~(ushort)new S0(1UL, 126, 0, 0, 1897884505177702295L, 118, 10L, 9892214294530090945UL, -7780450165846256914L).M74(ref Program.s_27, ~(9223372036854775807L << Program.s_11[0, 0]++)));
            }
        }

        return ref Program.s_73.F3;
    }

    public int[] M69()
    {
        ushort[] var0 = default(ushort[]);
        this.F0 = -14436;
        {
            this.F1 >>= Program.s_45[0]++ - Program.s_58++;
            var0 = Program.s_57;
            this.F1 = 21046;
        }

        this.F2 = Program.s_33;
        Program.s_59 &= 5834743038940284895UL;
        Program.M70(32767);
        return new int[]{-721472967, 0, -1554646115, -624860241, 2147483647, -2147483647};
    }

    public ref short M99(uint arg0)
    {
        short var0 = default(short);
        Program.s_24.F5 = (byte)((ushort)(~this.F2) >> Program.s_6.F1);
        {
            this.F1 = this.F2;
        }

        var0 = this.F0;
        Program.s_42[0].F3 = 1;
        return ref this.F0;
    }

    public I0 M106()
    {
        C1[] var0 = default(C1[]);
        this.F2 = this.F2;
        this.F1 = 1;
        var0 = new C1[]{new C1(-32007, 2, 42169), new C1(8733, 1, 37943), new C1(32766, 8819, 23811), new C1(-21252, 1, 0), new C1(1, 2635, 20497), new C1(-26197, 10, 18602), new C1(1, 10, 1), new C1(6769, 39166, 0), new C1(-10815, 53913, 33647)};
        Program.s_11[0, 0] = 2;
        Program.s_19 = var0[0].F1;
        return Program.s_89;
    }
}

public class Program
{
    public static S1[] s_1 = new S1[]{new S1(-32767, 6991602872010577642L, 1), new S1(1, 0L, 0), new S1(32767, 0L, -1)};
    public static bool[] s_2 = new bool[]{false, false};
    public static sbyte s_3 = 0;
    public static ulong s_4 = 18446744073709551615UL;
    public static C1[][,, ] s_5 = new C1[][,, ]{new C1[,, ]{{{new C1(-32768, 50821, 1), new C1(-6008, 10, 17640), new C1(32767, 1210, 1), new C1(0, 65535, 1), new C1(-1, 2, 65534)}}, {{new C1(-32767, 24673, 1), new C1(32767, 5674, 43970), new C1(-10, 0, 1), new C1(0, 1, 1), new C1(32767, 1, 65534)}}, {{new C1(-32768, 0, 14340), new C1(-20586, 1, 0), new C1(1, 0, 62083), new C1(1, 18620, 17626), new C1(29021, 0, 61874)}}, {{new C1(1, 0, 36730), new C1(-31696, 48810, 63066), new C1(32766, 33072, 26250), new C1(32766, 1, 1967), new C1(1847, 1, 59032)}}, {{new C1(22712, 65534, 1), new C1(-26131, 1, 15247), new C1(8446, 20347, 0), new C1(-13388, 7830, 10), new C1(0, 29146, 65535)}}}, new C1[,, ]{{{new C1(-32767, 44077, 17102), new C1(15869, 44898, 1), new C1(31721, 2, 1), new C1(28199, 8566, 30055), new C1(0, 21832, 24409)}}, {{new C1(18582, 1, 1), new C1(-19783, 2, 65534), new C1(-5175, 50896, 2), new C1(-10532, 65534, 0), new C1(32767, 0, 65535)}}, {{new C1(26672, 0, 2), new C1(14448, 5046, 52479), new C1(-2, 1, 0), new C1(-6257, 44029, 16647), new C1(30233, 18137, 46349)}}, {{new C1(0, 1, 10655), new C1(-6510, 17534, 2), new C1(-25138, 4418, 51452), new C1(15377, 0, 65535), new C1(0, 21983, 3936)}}, {{new C1(32766, 64135, 59625), new C1(-14774, 0, 1), new C1(-949, 51681, 0), new C1(-32767, 48185, 0), new C1(-2519, 42290, 0)}}}};
    public static S0 s_6 = new S0(18446744073709551614UL, -2, 154, -10, 1L, 1, -9223372036854775807L, 18446744073709551614UL, -9223372036854775808L);
    public static sbyte s_7 = 21;
    public static short[] s_8 = new short[]{27419, 17464, 0, 1, -32767, 20312, 0, 1748};
    public static bool s_9 = true;
    public static byte s_10 = 169;
    public static sbyte[, ] s_11 = new sbyte[, ]{{1, 42, 115, -128}, {-58, 126, 0, -64}};
    public static uint s_12 = 10U;
    public static ushort s_13 = 65535;
    public static long[] s_14 = new long[]{-3235889898169334130L, 3175875571006764764L, 4527238102054581977L, 5296052990837719826L, -9223372036854775808L, -9223372036854775808L, 0L, 9223372036854775807L};
    public static long s_15 = 1L;
    public static C0 s_16 = new C0(1, 0, false);
    public static S1 s_17 = new S1(-10, -3594555077427817712L, -32768);
    public static S1 s_18 = new S1(32767, -9223372036854775808L, -2655);
    public static ushort s_19 = 34174;
    public static ushort s_20 = 0;
    public static C0[][, ] s_21 = new C0[][, ]{new C0[, ]{{new C0(-127, 2, false), new C0(-2, 0, false), new C0(0, 188, true), new C0(-54, 134, true), new C0(126, 104, true), new C0(1, 110, false), new C0(-105, 254, false)}, {new C0(-128, 0, false), new C0(-33, 255, false), new C0(54, 0, true), new C0(-77, 75, true), new C0(-59, 1, true), new C0(-106, 68, false), new C0(0, 1, true)}, {new C0(0, 0, false), new C0(-82, 10, true), new C0(0, 243, true), new C0(-94, 255, false), new C0(0, 1, false), new C0(1, 47, false), new C0(10, 71, true)}, {new C0(-121, 145, false), new C0(39, 95, false), new C0(126, 1, true), new C0(0, 1, true), new C0(80, 1, false), new C0(-30, 1, true), new C0(-63, 0, true)}, {new C0(85, 10, false), new C0(69, 210, false), new C0(1, 245, false), new C0(-42, 129, true), new C0(0, 255, false), new C0(-86, 80, false), new C0(-59, 255, true)}}, new C0[, ]{{new C0(1, 0, false), new C0(-63, 187, false), new C0(-84, 255, false), new C0(57, 0, true), new C0(-127, 0, true), new C0(1, 1, true), new C0(1, 1, false)}, {new C0(-59, 207, true), new C0(59, 2, true), new C0(0, 0, false), new C0(-32, 0, false), new C0(33, 226, false), new C0(-80, 1, true), new C0(-25, 1, false)}, {new C0(113, 10, false), new C0(1, 0, true), new C0(-127, 176, true), new C0(127, 2, false), new C0(-1, 165, true), new C0(-127, 1, true), new C0(126, 1, true)}, {new C0(-1, 254, false), new C0(30, 69, true), new C0(-121, 137, false), new C0(127, 25, false), new C0(98, 1, false), new C0(126, 103, false), new C0(-5, 248, false)}, {new C0(21, 151, true), new C0(-40, 1, true), new C0(-123, 223, true), new C0(1, 0, true), new C0(127, 0, false), new C0(127, 255, false), new C0(0, 1, true)}}};
    public static bool s_22 = true;
    public static C0 s_23 = new C0(126, 1, true);
    public static S0 s_24 = new S0(17022445003158247856UL, -118, 168, -23, 0L, 92, -919301281209292180L, 10UL, 8899625699192458175L);
    public static uint[][] s_25 = new uint[][]{new uint[]{0U}, new uint[]{1U, 4294967295U}, new uint[]{4294967295U}, new uint[]{1341688007U}, new uint[]{1U}, new uint[]{536021606U, 4294967294U, 0U}, new uint[]{4294435381U, 1U, 400995510U}, new uint[]{456693663U, 3385524944U, 4294967294U}, new uint[]{983837203U, 1U}, new uint[]{0U, 2400379327U}};
    public static ushort[] s_26 = new ushort[]{65535, 60337, 1, 48311, 6512};
    public static C0[] s_27 = new C0[]{new C0(127, 0, false)};
    public static S1 s_28 = new S1(1, 9223372036854775806L, -25898);
    public static bool[,, ] s_29 = new bool[,, ]{{{true, false}}, {{true, true}}, {{false, true}}, {{true, false}}};
    public static uint s_30 = 570715902U;
    public static C0 s_31 = new C0(-55, 1, false);
    public static C1[] s_32 = new C1[]{new C1(2, 0, 1), new C1(32767, 65534, 1), new C1(2, 59744, 30685), new C1(-14267, 22857, 36246), new C1(-32767, 0, 1)};
    public static ushort s_33 = 1;
    public static I0 s_34 = new S0(1UL, 0, 255, -10, -8692512112910169047L, 10, 0L, 1UL, 9223372036854775806L);
    public static short[] s_35 = new short[]{1, 0};
    public static S0 s_36 = new S0(2293070236441507447UL, -57, 71, -128, -4193091118156916983L, 254, 7529471248942075496L, 0UL, 1L);
    public static long s_37 = -1L;
    public static int s_38 = 2147483647;
    public static I0 s_39 = new S0(13571561995326592099UL, -10, 117, -28, 5257993810154541865L, 1, 9223372036854775806L, 3097589648269808892UL, 5608191560381646062L);
    public static bool s_40 = true;
    public static sbyte[][][,, ] s_41 = new sbyte[][][,, ]{new sbyte[][,, ]{new sbyte[,, ]{{{10, -69, -127, 41, 127}}}}, new sbyte[][,, ]{new sbyte[,, ]{{{-109, -51, -97, 1, 0}}, {{17, 127, 1, -38, 1}}, {{74, -55, -15, 126, -127}}}}, new sbyte[][,, ]{new sbyte[,, ]{{{-118, -127, -29, -15, -1}}, {{-121, 0, -128, 127, -21}}}}};
    public static S0[] s_42 = new S0[]{new S0(1297223133967724776UL, 1, 133, 28, 2L, 244, 3411396978420026657L, 1UL, 3632752365305052619L), new S0(11340142773323514328UL, -127, 192, -2, -9223372036854775808L, 254, 9223372036854775807L, 6750094779817563168UL, 2L), new S0(16323575814072976047UL, 111, 1, 0, 9223372036854775806L, 0, -1949358624432747592L, 2231322650130112671UL, 8688421700483786893L)};
    public static long s_43 = 0L;
    public static bool s_44 = true;
    public static byte[] s_45 = new byte[]{0, 0, 134, 0};
    public static C1[] s_46 = new C1[]{new C1(2, 299, 26803), new C1(19385, 65534, 21391), new C1(-4801, 0, 26339), new C1(-24272, 0, 0), new C1(-10937, 1, 1), new C1(2, 23907, 10), new C1(24570, 1, 1), new C1(7661, 65535, 35093), new C1(-1, 36494, 65535)};
    public static short s_47 = -30911;
    public static byte s_48 = 15;
    public static ushort s_49 = 65535;
    public static C0 s_50 = new C0(-127, 223, false);
    public static S1 s_51 = new S1(32702, 8524093905351601002L, 22163);
    public static long s_52 = -9223372036854775808L;
    public static C1 s_53 = new C1(32767, 1, 32338);
    public static uint[] s_54 = new uint[]{1618314826U, 1753177408U, 745498512U, 3189153749U, 3536952636U, 10U, 4193786015U, 1651605298U};
    public static I0 s_55 = new S0(4802318849691653702UL, 8, 92, -90, 0L, 0, -2022969234867157827L, 15697020553927164642UL, 6469607282464593739L);
    public static I0 s_56 = new S0(18446744073709551614UL, 1, 132, 33, -10L, 245, -10L, 1UL, -9223372036854775807L);
    public static ushort[] s_57 = new ushort[]{0};
    public static int s_58 = 0;
    public static ulong s_59 = 0UL;
    public static short s_60 = 32767;
    public static byte s_61 = 213;
    public static long s_62 = 3450109003570809601L;
    public static I0 s_63 = new S0(12741365010049380137UL, 126, 6, -26, -9223372036854775808L, 255, -9223372036854775808L, 2UL, 0L);
    public static byte s_64 = 154;
    public static I0 s_65 = new S0(0UL, 105, 45, 0, -334850926330292064L, 1, -10L, 1UL, -9223372036854775807L);
    public static I0 s_66 = new S0(10396391937080161607UL, -51, 0, 120, 1L, 0, -9223372036854775807L, 7157634449643856490UL, -8763045057417948900L);
    public static I0[] s_67 = new I0[]{new S0(1100113200654027875UL, 10, 197, -27, 8562718340090732541L, 72, -9223372036854775807L, 1022115569242823497UL, -5685060495408861034L), new S0(18446744073709551615UL, 5, 0, 0, 649638448368452016L, 165, 1L, 9600479585785654076UL, -776509785305338174L), new S0(4790813584193502350UL, -127, 46, 56, 9223372036854775807L, 41, 9223372036854775806L, 14275442362039055079UL, -7689322852965229839L), new S0(0UL, 125, 140, 108, 10L, 0, 1L, 11071929219756405879UL, 2L)};
    public static long[] s_68 = new long[]{345238644128058833L, -1L, 4293195031250022143L, 9223372036854775806L, -9223372036854775807L, 9223372036854775807L, -8274530035824396399L, -9223372036854775807L};
    public static byte s_69 = 0;
    public static bool s_70 = true;
    public static byte s_71 = 255;
    public static byte s_72 = 193;
    public static S0 s_73 = new S0(2134764970183774349UL, 10, 1, -58, -8660834534396881441L, 32, 6189427515657808735L, 17508676445134262746UL, -3233504022532958838L);
    public static int s_74 = 0;
    public static uint[,, ] s_75 = new uint[,, ]{{{2799543763U}, {646099769U}}, {{1287749422U}, {4294967295U}}, {{0U}, {0U}}, {{2847398731U}, {975873689U}}, {{0U}, {988370266U}}, {{1U}, {0U}}, {{1382255721U}, {2566371976U}}, {{0U}, {4294967294U}}, {{0U}, {0U}}, {{1U}, {0U}}};
    public static int s_76 = 1608492795;
    public static ulong s_77 = 1UL;
    public static bool s_78 = true;
    public static S1 s_79 = new S1(-9228, 0L, 173);
    public static long s_80 = -2L;
    public static uint s_81 = 734942400U;
    public static byte s_82 = 48;
    public static uint[] s_83 = new uint[]{1U, 2655373533U, 835595548U, 2403703764U, 196422896U, 0U};
    public static C0 s_84 = new C0(0, 0, false);
    public static ushort s_85 = 32017;
    public static C0 s_86 = new C0(-10, 0, false);
    public static long s_87 = 9112962096752835741L;
    public static C1[] s_88 = new C1[]{new C1(-32767, 0, 12688), new C1(-8784, 38163, 28219), new C1(32767, 65534, 48114), new C1(1, 5316, 31671), new C1(18852, 1, 0), new C1(25661, 10990, 1), new C1(-32768, 29724, 1362), new C1(32766, 21558, 1)};
    public static S0 s_89 = new S0(18040337835588713289UL, -127, 254, -127, 2L, 97, -9223372036854775808L, 5885023230872522507UL, -9223372036854775808L);
    public static ulong s_90 = 11451526383626783489UL;
    public static long s_91 = -9223372036854775808L;
    public static int s_92 = -1256023144;
    public static long s_93 = -3655764008904754113L;
    public static bool s_94 = true;
    public static byte[] s_95 = new byte[]{0, 71, 1, 133, 0, 1, 0};
    public static byte s_96 = 0;
    public static uint s_97 = 1637596950U;
    public static ulong s_98 = 0UL;
    public static short[] s_99 = new short[]{1, 0, 1};
    public static ushort[][] s_100 = new ushort[][]{new ushort[]{65534, 65130, 46802}, new ushort[]{0, 2, 44207, 31181, 57937}, new ushort[]{44758, 0}};
    public static S0[, ] s_101 = new S0[, ]{{new S0(10UL, -106, 1, 127, 1L, 10, 0L, 15357392491071761068UL, -9223372036854775807L), new S0(7582499825360048142UL, -52, 202, 75, 6587411729760640096L, 1, 7927129599092570997L, 1UL, 1L)}, {new S0(0UL, -127, 89, 79, 7537003421398718316L, 105, 1L, 12489921964058926046UL, 5114854941004466496L), new S0(6790611685756065380UL, 114, 0, 1, -2889970330751557171L, 1, 1L, 1UL, -1L)}, {new S0(3110225246666185528UL, 0, 112, 1, -7524009584978761754L, 146, -4071328420423011258L, 1UL, 1L), new S0(0UL, -71, 1, 0, 0L, 255, 4970263648579436785L, 0UL, 3945521196282148483L)}, {new S0(0UL, 0, 100, 104, 2L, 0, -3571130399060002284L, 774830042938444859UL, 1L), new S0(1UL, 54, 71, -81, -3627798195894483204L, 0, -7583124358264129246L, 0UL, -1608104493603191693L)}, {new S0(179889711863145001UL, 72, 176, -10, -5481156005772903090L, 10, 9223372036854775806L, 0UL, 9223372036854775806L), new S0(2142891965220822699UL, 0, 0, 127, -9223372036854775807L, 0, 0L, 4306500810632292850UL, -6270404992366265253L)}, {new S0(18446744073709551614UL, 60, 22, 126, -5014382623446892904L, 185, -1311619564475978173L, 0UL, -8730188132721853026L), new S0(17235760484804114846UL, 0, 255, -128, -5983449936965652357L, 0, 6978897506400962862L, 18446744073709551614UL, 1L)}, {new S0(979314267114699542UL, 127, 85, -128, -1315942198524100509L, 1, -9223372036854775807L, 3969980651192071983UL, 9223372036854775806L), new S0(18446744073709551615UL, -16, 163, -76, 1107876824308129511L, 1, 4469260620709659322L, 0UL, -9223372036854775808L)}};
    public static bool s_102 = true;
    public static ulong s_103 = 15780061626666752982UL;
    public static sbyte s_104 = 119;
    public static ushort s_105 = 0;
    public static C1 s_106 = new C1(-3859, 49232, 30311);
    public static uint s_107 = 10U;
    public static ulong s_108 = 9429829039228540382UL;
    public static long[] s_109 = new long[]{-1315386625713342941L, -9223372036854775807L, 3534276412798540744L, 9223372036854775807L, 6034754700724062153L, -1428810267709976409L, 1L, 1L, -7300326768563795452L};
    public static sbyte s_110 = 10;
    public static ulong[,, ] s_111 = new ulong[,, ]{{{1UL, 9483559061744684831UL, 2095536658282602655UL, 18446744073709551615UL, 1UL, 1893045707900365448UL, 0UL, 1UL, 4512098188148168243UL, 18446744073709551615UL}, {7356107832898618561UL, 3159694684141428941UL, 13623592957414183692UL, 0UL, 1UL, 9239371208855605967UL, 0UL, 1UL, 14050029548127588584UL, 2UL}}};
    public static int s_112 = 10;
    public static bool[][] s_113 = new bool[][]{new bool[]{true, false, false, false, false, false, false, false, true}, new bool[]{true, false, true}, new bool[]{true, false, false, false, true, true, false, false}, new bool[]{true}, new bool[]{false, false, true, false, true, true, true, false, false, true}, new bool[]{true, false, false, true, false}, new bool[]{false, false, false, true, false, false, true, false}, new bool[]{false, false, true, true, true, true, false}};
    public static byte s_114 = 123;
    public static I0 s_115 = new S0(1UL, -128, 0, 126, -9223372036854775807L, 76, -1L, 1UL, 8978782410355997383L);
    public static long s_116 = 0L;
    public static C0 s_117 = new C0(0, 250, false);
    public static S1 s_118 = new S1(19672, 2652223722121338040L, 22295);
    public static I0 s_119 = new S0(0UL, 0, 239, 127, 5925603666154642598L, 2, -3200466341736079978L, 18446744073709551614UL, -5561489936944913568L);
    public static long s_120 = 4759035667626076428L;
    public static C1 s_121 = new C1(32766, 1, 0);
    public static ushort[] s_122 = new ushort[]{1, 1, 1, 47209, 36767, 1};
    public static short s_123 = 32266;
    public static ushort s_124 = 10547;
    public static short[] s_125 = new short[]{19447, 10499, -19068, 0, -29388, 2};
    public static ushort[][][][] s_126 = new ushort[][][][]{new ushort[][][]{new ushort[][]{new ushort[]{0}, new ushort[]{44971}, new ushort[]{0}, new ushort[]{47103}, new ushort[]{13306}}, new ushort[][]{new ushort[]{42090}, new ushort[]{0}, new ushort[]{65534}, new ushort[]{27085}}, new ushort[][]{new ushort[]{2}, new ushort[]{4027}}, new ushort[][]{new ushort[]{56422}}}, new ushort[][][]{new ushort[][]{new ushort[]{10425}}, new ushort[][]{new ushort[]{65534}, new ushort[]{39585}, new ushort[]{65535}, new ushort[]{0}}, new ushort[][]{new ushort[]{26267}, new ushort[]{1}, new ushort[]{65534}, new ushort[]{10}, new ushort[]{0}, new ushort[]{44173}, new ushort[]{0}}, new ushort[][]{new ushort[]{0}, new ushort[]{43964}, new ushort[]{1009}, new ushort[]{0}, new ushort[]{55112}, new ushort[]{49945}, new ushort[]{54230}, new ushort[]{0}}}};
    public static S0 s_127 = new S0(9289586087489662991UL, -128, 1, 23, 1435995287825718515L, 10, -9223372036854775807L, 1478027990473450840UL, 2608813403934341423L);
    public static C0 s_128 = new C0(0, 0, true);
    public static I0[] s_129 = new I0[]{new S0(12444694831690217141UL, 1, 161, 2, 0L, 0, 1L, 0UL, 6856055706624261599L), new S0(7048011260245946769UL, -110, 52, 50, 9223372036854775806L, 255, 9001955799701032929L, 0UL, 9223372036854775807L), new S0(1UL, -128, 0, 109, 1L, 1, -1715119737491142451L, 11507931472575451690UL, 0L), new S0(387701944586521752UL, -128, 253, -106, 213600365257182757L, 0, -9223372036854775807L, 0UL, 1L), new S0(2UL, 0, 191, 127, 9223372036854775806L, 254, -9223372036854775808L, 0UL, -1280950966420618903L), new S0(9954113156146031449UL, 1, 0, 1, 1610210323683085288L, 0, -2867833979171076349L, 18446744073709551615UL, -9223372036854775808L), new S0(2869067993811839865UL, 64, 0, -87, -3874052851729711959L, 101, 4364512665494682571L, 0UL, 1L), new S0(0UL, 70, 44, 126, 0L, 2, 4935200118547786904L, 14964333343955589096UL, 8630977752205734367L), new S0(15756997396828801876UL, 0, 254, -2, 1L, 10, -3609092373046278904L, 12997714342529935837UL, 1L)};
    public static short s_130 = 25477;
    public static byte s_131 = 37;
    public static void Main()
    {
        M0();
    }

    public static void M0()
    {
    }

    public static int M2(bool arg0, C1[] arg1, ref long arg2)
    {
        S0 var1 = default(S0);
        S1 var2 = default(S1);
        try
        {
            for (int var0 = 0; var0 < 2; var0++)
            {
                s_1[0].F0 = -2;
                new C0(-4, 92, false).M3(-var0, new C0(-36, 163, false));
                new C0(-65, 1, true).M3(var0, new C0(-128, 171, true));
                var1 = M4(new S0(8755168123403557558UL, (sbyte)((sbyte)(-new C0(1, 85, false).M3(569481964, new C0(-17, 233, false))) ^ -69), 246, new C0(1, 1, false).M3(var0, new C0(-128, 1, false)), arg2, (byte)(~(byte)new C0(-96, 1, false).M3(var0, new C0(-12, 3, false))), 0L, 1UL, arg2));
                s_1[0].F2 = arg1[0].F0;
                var1.F7 = var1.F0;
                new C0(36, 2, true).M3(var0, new C0(126, 1, false));
            }
        }
        finally
        {
            arg1 = arg1;
            {
                arg1[0].F2 = 1;
                M4(M4(new S0(10UL, -91, 1, 97, -4333731606633849886L, 254, 9223372036854775806L, 0UL, -9223372036854775807L)));
                {
                    arg1[0].F2 = arg1[0].F1;
                    arg1[0].F1 = arg1[0].F2;
                    arg1[0].F2 *= (ushort)new C0(-128, 51, false).M3((int)((uint)new C0(0, 38, false).M3(1289803628, new C0(-127, 236, false)) - (uint)new C0(-37, 0, true).M3(2147483646, s_18.M5())), s_16);
                    s_129 = s_67;
                    M113(ref arg1[0].F2, M75());
                    arg0 = arg0;
                }
            }

            s_89 = new S0(1UL, -57, 147, -2, -6227756998539066434L, 0, -8155196844903433033L, 5725894510795825557UL, -1303521155981145183L);
        }

        arg1[0].F2 = arg1[0].F1;
        if (arg0)
        {
            var2 = M54(ref s_23.F1, new S1(4049, -1373936966631774281L, 10), 65535, ref s_73);
            s_130 = arg1[0].F0;
            if (s_21[0][0, 0].F2)
            {
                {
                    arg1 = M57(s_34, ref s_124);
                }
            }
        }
        else
        {
            arg2 = arg2;
            arg1[0].F0 = M62(55147978U, s_73, 10, ref M47(arg1[0].F2, arg1[0].F0++), s_89, s_129);
        }

        return M47(arg1[0].F2, arg1[0].F0++)++;
    }

    public static S0 M4(S0 arg0)
    {
        arg0.F3 -= arg0.F3;
        s_1 = s_1;
        arg0.F7 = arg0.F7;
        arg0.F0 = arg0.F0;
        arg0.F7 = 6972819312118900736UL;
        return arg0;
    }

    public static long M8(byte arg0, S1[] arg1, ulong[] arg2)
    {
        return default(long);
    }

    public static ushort M11(bool arg0, bool[][] arg1, ushort[] arg2, uint arg3)
    {
        ref long var0 = ref s_1[0].F1;
        return arg2[0];
    }

    public static ushort[] M17()
    {
        int var0 = default(int);
        var0 = -1972432450;
        return new ushort[]{0, 52480, 0, 1, 65534, 56415, 0, 0};
    }

    public static C1 M20(C1 arg0)
    {
        arg0.F0 = arg0.F0;
        arg0.F2 -= arg0.F1;
        return arg0;
    }

    public static bool M23(ref S1[] arg0)
    {
        bool var0 = default(bool);
        I0 var1 = default(I0);
        C0 var4 = default(C0);
        int var5 = default(int);
        I0 var6 = default(I0);
        sbyte var7 = default(sbyte);
        I0 var9 = default(I0);
        uint var10 = default(uint);
        int var11 = default(int);
        short var13 = default(short);
        if (s_2[0])
        {
            var0 = M24();
            var1 = new S0(12145417684074123276UL, -109, 1, -2, 8192309019186042111L, 254, 1744007893337148879L, 2575027296466386469UL, 1L);
            arg0[0].F1 = -10L;
            ref uint var2 = ref s_12;
        }

        for (int var3 = 0; var3 < 2; var3++)
        {
            arg0[0].F1 = arg0[0].F1;
            var4 = new C0(127, 0, false);
            var4.F0 = var4.F0;
            M25(1U, s_5[0][0, 0, 0].F2--);
            var5 = var3;
        }

        try
        {
            try
            {
                var6 = new S0(8638057808099396616UL, 1, 2, 10, -4129497616393413449L, 1, -6459570573739477023L, 12103924788043960768UL, -7459234515689450024L);
                arg0 = arg0;
            }
            finally
            {
                M25(0U, (ushort)(-s_5[0][0, 0, 0].F1--)) = arg0[0];
            }

            var7 = 126;
            s_13 = 64559;
            arg0[0] = s_1[0];
            arg0[0].F0 = arg0[0].F0++;
            arg0[0] = arg0[0];
            ref long[] var8 = ref s_14;
            {
                var7 = var7;
            }

            if (M24())
            {
                var9 = new S0(1738563909135422896UL, 126, 35, -8, 9223372036854775807L, 66, 10L, 18446744073709551614UL, 2252627191508390182L);
                var10 = 4294967294U;
            }

            M25(s_12--, 0) = new S1(-32767, -4335399630712782013L, 16504);
        }
        finally
        {
            if (s_2[0])
            {
                s_6 = new S0(9595474810439814109UL, 89, 255, 0, -1022275211422136585L, 1, 4007951189457290048L, 10466779398311860218UL, -3786215683514903216L);
            }

            M24();
            M24();
        }

        s_15 ^= arg0[0].F1;
        try
        {
            {
                {
                    var11 = 1;
                    M24();
                    ref int var12 = ref var11;
                }

                try
                {
                    arg0[0] = arg0[0];
                }
                finally
                {
                    arg0 = new S1[]{new S1(0, 1L, -10), new S1(20805, 7892125869140020858L, 1), new S1(-32768, 182183316838613494L, 32766)};
                }
            }
        }
        finally
        {
            var13 = arg0[0].F2;
        }

        return true;
    }

    public static bool M24()
    {
        s_1 = s_1;
        M25(2U, 23991);
        return s_4++ == 17391;
    }

    public static ref S1 M25(uint arg0, ushort arg1)
    {
        long var0 = default(long);
        var0 = -10L;
        return ref s_1[0];
    }

    public static S1 M26(I0 arg0)
    {
        return default(S1);
    }

    public static ushort M30(ref C0[][, ] arg0)
    {
        arg0[0][0, 0].F2 = arg0[0][0, 0].F2;
        return (ushort)(~s_20);
    }

    public static ushort M32()
    {
        byte var0 = default(byte);
        I0 var3 = default(I0);
        S1[] var4 = default(S1[]);
        M33();
        M35(ref s_24.F2);
        var0 = s_24.F2;
        var0 = var0;
        new C0(78, 6, true).M34().M37(ref s_5[0][0, 0, 0], 732267441145420425L);
        new C0(-126, 182, true).M34() = s_18;
        var0 = s_24.F5;
        {
            for (int var1 = 0; var1 < 2; var1++)
            {
                s_13 = (ushort)(s_18.F1-- % (byte)(28 | 1));
                s_1 = new S1[]{new S1(-32767, -9223372036854775807L, 10), new S1(13086, -8864163039600854405L, -19269), new S1(30286, 4864758060824513794L, 0), new S1(13410, 1L, -32767), new S1(-32768, 2739474845896148492L, 32767), new S1(32766, -5942072839798632135L, 32766), new S1(-22691, 1L, 26376), new S1(1, 0L, -22837), new S1(-11978, 4879487507454618848L, -10), new S1(0, -2732282349361648870L, 17095)};
                ref C0[] var2 = ref s_27;
                var3 = new S0(18446744073709551614UL, -120, 148, 127, -5589287835395784851L, 0, 10L, 0UL, 1L);
            }
        }

        var0 = s_21[0][0, 0].F1;
        s_2[0] = true;
        var0 = var0;
        var0 = 0;
        var4 = new S1[]{new S1(0, -5255093321959185427L, -32663), new S1(26961, -9223372036854775807L, -5945), new S1(-32768, 3518542210007999927L, 0), new S1(-5925, 9223372036854775806L, -17706), new S1(-32768, -3574282944044110744L, -15812), new S1(8042, -1149302472514792413L, 8061)};
        return 37765;
    }

    public static long M33()
    {
        int var0 = default(int);
        var0 = 0;
        if (!!(1319460995U > s_6.F2))
        {
            s_21[0][0, 0].M34();
            ref short[] var1 = ref s_8;
            s_16.M34();
        }

        return s_6.F8++;
    }

    public static ulong M35(ref byte arg0)
    {
        S1[] var1 = default(S1[]);
        S0 var2 = default(S0);
        for (int var0 = 0; var0 < 2; var0++)
        {
            {
                if (false || s_21[0][0, 0].F2)
                {
                    arg0 += 183;
                }
                else
                {
                    arg0 = arg0;
                }

                arg0 = ref arg0;
                arg0 = ref arg0;
            }

            if (!(~s_6.F0-- != 117))
            {
                try
                {
                    var1 = new S1[]{new S1(-32767, -9223372036854775808L, 2), new S1(-32767, 6666012725591215438L, 2), new S1(-32767, -9223372036854775808L, 25887), new S1(23749, -206801100016389516L, 0), new S1(0, -4152912925377653184L, 0), new S1(-24597, 6812517725054106664L, 32766), new S1(18718, -10L, -2822), new S1(-32767, 4497469364179915063L, -32767)};
                }
                finally
                {
                    arg0 = ref arg0;
                    arg0 = ref arg0;
                }
            }

            if (1971791404 <= s_12)
            {
                var2 = new S0(17143588949775007422UL, 103, 0, -128, 1948029775706732197L, 0, 8848931381525013183L, 18446744073709551615UL, 988401422716005724L);
                s_18.F0 = var2.M36(var2.F6, ref s_25, var2);
                new S0(1UL, 0, 113, 4, 6224405405293983934L, 241, -2L, 1UL, 2448475874705098258L).M38(new ulong[]{1UL}, s_19);
                s_5[0][0, 0, 0].F2 = (ushort)(~s_5[0][0, 0, 0].F1--);
                ref long var3 = ref var2.F6;
                var2.F8 = s_18.F0 - 1603277645802907884L;
                M39();
            }

            arg0 ^= M40(s_5[0][0, 0, 0].F0--);
            try
            {
                M41();
            }
            finally
            {
                new S1(-32768, 1L, 1).M37(ref s_5[0][0, 0, 0], s_24.F6++);
            }

            M40((short)(-(short)(-s_5[0][0, 0, 0].F0)));
            {
                ref long var4 = ref s_24.F8;
            }
        }

        return (ulong)new S0(1UL, -64, 0, 126, 3879834267743338790L, 0, 3711799949019897853L, 5037884615743025552UL, -9223372036854775807L).M38(new ulong[]{1UL, 0UL, 5601135541374748867UL, 18446744073709551614UL, 18446744073709551615UL, 8438941526924319230UL, 18446744073709551614UL}, (ushort)(-s_24.M38(new ulong[]{1UL, 16891721090715960200UL}, 9207)));
    }

    public static byte[][][] M39()
    {
        s_6.F0 = s_6.F0;
        return new byte[][][]{new byte[][]{new byte[]{218, 0, 231, 159, 1, 10, 69}}, new byte[][]{new byte[]{65, 0, 104, 0, 0, 0}}, new byte[][]{new byte[]{0, 206, 1, 1}, new byte[]{255, 0, 30, 255}}, new byte[][]{new byte[]{255, 28, 9, 190, 64, 104}}, new byte[][]{new byte[]{16, 102, 174, 152, 144, 10}, new byte[]{254, 142, 1, 1, 255, 250, 2, 187}}, new byte[][]{new byte[]{230, 47, 140, 10, 1, 255, 1, 1, 79}}};
    }

    public static byte M40(short arg0)
    {
        I0 var0 = default(I0);
        byte var2 = default(byte);
        arg0 = arg0++;
        if (s_9)
        {
            var0 = s_6;
            ref C1 var1 = ref s_5[0][0, 0, 0];
            var2 = 1;
        }

        return s_6.F5--;
    }

    public static uint M41()
    {
        bool var0 = default(bool);
        bool var2 = default(bool);
        long var3 = default(long);
        bool var5 = default(bool);
        {
            if (s_21[0][0, 0].F2)
            {
                var0 = s_2[0];
            }
            else
            {
                s_4 = s_6.F7++;
            }

            ref C1 var1 = ref s_5[0][0, 0, 0];
            try
            {
                var1.F1 = var1.F2;
            }
            finally
            {
                var1.F2 = var1.F1;
                try
                {
                    var1 = new C1(2410, 65535, 43040);
                }
                finally
                {
                    var2 = s_9;
                    var3 = -2L;
                }
            }

            for (int var4 = 0; var4 < 2; var4++)
            {
                var5 = false;
            }

            s_26 = s_26;
            var1.F1 = (ushort)(3246 >> s_6.F3++);
        }

        return s_25[0][0]++;
    }

    public static short M42()
    {
        if (!s_23.F2)
        {
            s_24.F0 = ~s_6.F0;
        }

        return 29073;
    }

    public static ulong M46(S0 arg0)
    {
        return default(ulong);
    }

    public static ref int M47(ushort arg0, short arg1)
    {
        arg1 = 32767;
        arg1 -= 5733;
        return ref s_38;
    }

    public static long M48(ref C0 arg0, S1 arg1, int[] arg2, ref I0 arg3)
    {
        s_28.F1 = arg1.F1;
        s_12 = 10U;
        return arg1.F1;
    }

    public static S1 M54(ref byte arg0, S1 arg1, ushort arg2, ref S0 arg3)
    {
        C1[] var0 = default(C1[]);
        sbyte var1 = default(sbyte);
        byte var2 = default(byte);
        I0 var3 = default(I0);
        C0 var5 = default(C0);
        byte var6 = default(byte);
        ulong[] var7 = default(ulong[]);
        C1 var8 = default(C1);
        long var9 = default(long);
        S1 var10 = default(S1);
        long var11 = default(long);
        int var12 = default(int);
        S1 var13 = default(S1);
        {
            arg3.F5 = (byte)(~arg3.F5);
            arg3.M55();
            if (s_22)
            {
                arg0 = arg0++;
                var0 = new C1[]{new C1(-32768, 12181, 43905), new C1(6860, 10926, 1), new C1(28107, 65534, 52452), new C1(-2921, 13488, 11030), new C1(0, 15734, 1), new C1(32766, 28897, 1), new C1(-32767, 0, 34864), new C1(0, 0, 2), new C1(-31026, 0, 0), new C1(-2, 55977, 16337)};
                M58(arg3);
                s_42[0].F8 = -s_14[0];
                var1 = arg3.F1;
                M58(arg3) = M58(arg3);
                var2 = (byte)M59();
                s_47 = (short)M59();
                var3 = arg3;
                {
                    ref short var4 = ref arg1.F2;
                    var0[0] = new C1(32767, 1, 29907);
                    {
                        if (s_40)
                        {
                            var5 = new C0(90, 1, true);
                        }
                        else
                        {
                            arg0 = arg3.F5;
                        }
                    }
                }

                M58(arg3);
            }
        }

        if (s_23.F2)
        {
            var6 = (byte)(-arg3.F2);
            if (s_2[0])
            {
                try
                {
                    var7 = new ulong[]{1UL, 0UL, 13741260739871999393UL, 18446744073709551615UL, 18446744073709551614UL, 1UL, 1UL, 12057142555367401877UL};
                }
                finally
                {
                    s_16.F1 = 155;
                    var8 = s_46[0];
                    var9 = arg3.F6;
                }

                arg2 = M59();
                var10 = new S1(19366, -3796294020363060455L, 32767);
                arg3.F0 = s_6.F0;
            }
            else
            {
                arg1.F2 = arg1.F2;
            }

            if (!!s_27[0].F2)
            {
                var11 = (long)M59();
            }
        }
        else
        {
            {
                var12 = s_38++;
                s_48 *= arg3.F2;
            }

            if (s_31.F2)
            {
                M56();
            }
            else
            {
                arg3.F8 = -1L;
            }

            arg3.F1 = (sbyte)M59();
            var13 = arg1;
        }

        return new S1(-1, -4328605107856437285L, 0);
    }

    public static int M56()
    {
        ulong var0 = default(ulong);
        C1[][] var1 = default(C1[][]);
        ulong var2 = default(ulong);
        if (!(s_22 && s_9))
        {
            var0 = s_4--;
            M57(new S0(0UL, -1, 224, 0, -958368099335183209L, 0, -5481593474604925425L, 18446744073709551614UL, 1L), ref s_26[0]);
            M57(s_24, ref s_5[0][0, 0, 0].F2);
        }
        else
        {
            if (s_9)
            {
                M57(s_6, ref s_19);
            }
            else
            {
                var1 = new C1[][]{new C1[]{new C1(955, 10, 991), new C1(32766, 2457, 1), new C1(-22823, 1, 0), new C1(1, 0, 1), new C1(0, 10, 37818), new C1(-2, 0, 1), new C1(1, 31137, 44005)}};
                var2 = s_42[0].F7;
                M58(new S0(5577201034106620905UL, -128, 1, 10, 5693577582329344107L, 2, 0L, 0UL, -6758693195927299181L));
                s_46 = M57(new S0(10501148712936644410UL, 71, 255, 1, 9223372036854775806L, 146, -1L, 1UL, 0L), ref var1[0][0].F1);
                var1[0][0].F1 = var1[0][0].F1;
            }
        }

        return s_38++;
    }

    public static C1[] M57(I0 arg0, ref ushort arg1)
    {
        s_25[0][0] = s_12;
        try
        {
            arg1 = 61723;
        }
        finally
        {
            for (int var0 = 0; var0 < 2; var0++)
            {
                arg0 = new S0(0UL, -43, 211, -81, 5562343609743880441L, 1, 9223372036854775806L, 1UL, 0L);
            }
        }

        return new C1[]{new C1(8379, 1, 8746), new C1(2, 1165, 0), new C1(1, 55295, 39814), new C1(-6045, 0, 0), new C1(26417, 0, 7233), new C1(-24656, 16276, 21074)};
    }

    public static ref bool[] M58(S0 arg0)
    {
        short var0 = default(short);
        if (s_16.F2)
        {
            M59();
        }
        else
        {
            {
                {
                    arg0.F7 = ~arg0.F0;
                    arg0.F4 = arg0.F8;
                    arg0.F8 = arg0.F6--;
                    var0 = s_8[0]--;
                }
            }

            arg0.F6 = arg0.F6;
        }

        s_45 = s_45;
        return ref s_2;
    }

    public static ref ushort M59()
    {
        s_17 = new S1(2, -9223372036854775807L, -2);
        return ref s_32[0].F2;
    }

    public static short M62(uint arg0, I0 arg1, sbyte arg2, ref int arg3, I0 arg4, I0[] arg5)
    {
        arg3 = s_38;
        arg3 = ref arg3;
        return 13001;
    }

    public static ref C0 M67(S1 arg0, ushort arg1, C0[][] arg2)
    {
        I0 var1 = default(I0);
        int var2 = default(int);
        C1 var3 = default(C1);
        C1[][] var4 = default(C1[][]);
        sbyte var5 = default(sbyte);
        I0[] var6 = default(I0[]);
        ushort var7 = default(ushort);
        ulong[] var8 = default(ulong[]);
        I0[] var9 = default(I0[]);
        byte var11 = default(byte);
        return ref M75();
    }

    public static bool M68(ushort arg0)
    {
        byte var1 = default(byte);
        arg0 = arg0;
        s_6 = new S0(11565631435954528078UL, -41, 2, 126, 8550397067260938734L, 235, -9223372036854775807L, 7458099604766120498UL, 296899958961322694L);
        arg0 = 24082;
        for (int var0 = 0; var0 < 2; var0++)
        {
            arg0 = 1662;
            var1 = (byte)(~s_23.F1++);
            M71(new S0(1UL, 126, 1, 2, -730519734623185007L, 1, -9168846151588967433L, 9604120650059573012UL, -442509082180948840L), 1U, M71(new S0(16374986448636363354UL, 1, 174, 1, -5038700548344443233L, 232, 7018276728189688039L, 8032236896633693093UL, -4282333061117080236L), 2U, M71(s_73, 1193871611U, M71(s_6, (uint)M70(s_17.F0), new C1(-28845, 10, 20672), (sbyte)new S0(6051288814334013225UL, 0, 247, 111, 4939267720178506665L, 209, -8430702406329182669L, 0UL, 0L).M74(ref s_27, -9223372036854775808L), new long[][]{new long[]{2L, 0L, -6433308844885986339L}, new long[]{-1314811486573368909L, -2302884926039200917L}, new long[]{-9223372036854775808L, -2L}, new long[]{3504481512117643434L, -7794300818938582191L, -3951871111471368006L}, new long[]{6198453033414139766L, -4404836994244013901L}, new long[]{7134860449648463138L, 0L, 1L}, new long[]{0L, 9223372036854775806L, -2L}, new long[]{0L, 9223372036854775806L, -8973545070205351996L}}, 4294967294U, ref s_75), 127, new long[][]{new long[]{3359386926375374800L}, new long[]{-9223372036854775807L, 0L, 10L, -1492674845120002746L, 9223372036854775806L}, new long[]{7205925950845321304L, 0L, 7123605538039948767L, -5380034533283062874L, -6666857591515718196L, -1475231222771169133L, 5400040002434382135L}, new long[]{-1015695478720879078L, 7934998769076483770L, 3454894413058450423L, 8652507365996245880L}, new long[]{-888468272749788559L, -5412661081335761006L, 9223372036854775806L, 6049757820996767450L, 1L, -7112372324317666159L}, new long[]{0L, 9223372036854775806L, -3103599550071379837L, -2332742417926475990L, 1L, -9223372036854775807L, 0L}, new long[]{3894129615299641830L, 8215782122372381110L, -6435075293617196860L, 9187039527896649217L, -9223372036854775808L, -9223372036854775807L, -9223372036854775807L}, new long[]{-6543190704268498922L, -9223372036854775807L, 643255713250541409L}, new long[]{-410272336369689861L, -5062563911127543949L, 2571399204353953396L, 2808917532002289445L, 4413142478905118435L, 539401638063248527L, -491542319352227131L}}, 0U, ref s_75), -120, new long[][]{new long[]{-9223372036854775808L, 1841124467301844634L}, new long[]{0L}, new long[]{-9223372036854775807L, 7649138929636531913L}, new long[]{-4390856140302607785L}, new long[]{9223372036854775807L}, new long[]{6386895878386260908L, -4292462299989650645L}, new long[]{-1L}, new long[]{6377261383897095605L}}, 2204085076U, ref s_75), (sbyte)M73(), new long[][]{new long[]{0L, 6072234425882467936L}, new long[]{7857830283461827930L}, new long[]{0L, 9223372036854775806L, -1240494489398442314L}, new long[]{8602043874359283871L, -5199362719490281109L, -3294626852055832314L, 9223372036854775807L}}, 0U, ref s_75).M69();
        }

        return !(new S0(1UL, -97, 86, 126, -6571482835052724994L, 0, 7091167804258412061L, 1UL, 1L).M78() < -6854025044808317474L);
    }

    public static byte M70(short arg0)
    {
        I0 var0 = default(I0);
        int var1 = default(int);
        short var2 = default(short);
        try
        {
            var0 = s_6;
        }
        finally
        {
            if (!(!s_29[0, 0, 0] || false))
            {
                var1 = 2000526624;
                var1 = s_58;
            }
        }

        var2 = -8522;
        ref short var3 = ref arg0;
        M71(new C0(s_36.F1, 0, s_21[0][0, 0].F2).M76(ref s_13), s_30++, new C1(-18039, 1, 26611), s_42[0].F1--, new long[][]{new long[]{10L, 9223372036854775807L}, new long[]{-9223372036854775808L, 10L}, new long[]{-7934833451102039622L}, new long[]{-9223372036854775808L}, new long[]{0L, -6415422178064369151L, -9223372036854775808L}, new long[]{794646265875991019L, 3541875825470365938L, -8153210331525608353L, -5706923920152193455L, -9223372036854775807L}, new long[]{-9223372036854775808L, 2111746351429276676L, -10L, -3973682575373636835L, 1L}, new long[]{10L, -9223372036854775807L}, new long[]{1L}}, s_12, ref s_75);
        var2 = (short)((byte)new S0(3448508134693652288UL, 0, 232, -98, -4072089871773441492L, 61, -1L, 16611046668562554525UL, 2L).M74(ref s_27, ~s_1[0].F1--) >> s_58--);
        s_76 = 1539330619;
        return s_50.F1;
    }

    public static ref C1 M71(S0 arg0, uint arg1, C1 arg2, sbyte arg3, long[][] arg4, uint arg5, ref uint[,, ] arg6)
    {
        C1 var1 = default(C1);
        ushort var2 = default(ushort);
        long var3 = default(long);
        ulong var4 = default(ulong);
        short[] var5 = default(short[]);
        sbyte var6 = default(sbyte);
        byte var8 = default(byte);
        int var9 = default(int);
        sbyte var10 = default(sbyte);
        I0 var11 = default(I0);
        ushort var12 = default(ushort);
        byte var13 = default(byte);
        int[, ] var14 = default(int[, ]);
        long[][] var15 = default(long[][]);
        ushort var16 = default(ushort);
        bool var17 = default(bool);
        byte var18 = default(byte);
        ushort var19 = default(ushort);
        short[] var21 = default(short[]);
        S1 var22 = default(S1);
        return ref s_46[0];
    }

    public static ref ulong M73()
    {
        C1 var0 = default(C1);
        s_42[0].F4 = 642919092707637929L;
        var0 = new C1(-32767, 1, 36003);
        return ref s_4;
    }

    public static ref C0 M75()
    {
        s_24.F4 = 4383494367824225385L;
        s_30 = 1U;
        s_42 = s_42;
        s_50.M76(ref s_20);
        M77(ref s_16.F0, ref s_17, new S1(0, -975944482475475853L, -11670), (ulong)M77(ref s_11[0, 0], ref s_18, new S1(12279, 9223372036854775806L, 1), (ulong)M77(ref s_27[0].F0, ref s_1[0], s_51, (ulong)((uint)(s_23.F0 << -25511) & (short)(7552624700960793271UL / (byte)(s_69 | 1))), ref s_45), ref s_45), ref s_45);
        return ref s_21[0][0, 0];
    }

    public static ushort M77(ref sbyte arg0, ref S1 arg1, S1 arg2, ulong arg3, ref byte[] arg4)
    {
        sbyte var1 = default(sbyte);
        if (!(true && !(1 == arg1.F1)))
        {
            new S0(12558467987328863510UL, 1, 76, 29, -564775181908821096L, 0, 2421846723931906489L, 2497779465162649652UL, -9223372036854775807L).M78();
            s_68 = new long[]{1L, 1L, 4927749492631743555L, 0L, -94726540926614901L};
            arg0 = ref s_31.F0;
        }

        ref byte var0 = ref arg4[0];
        if (-115 < arg0)
        {
            var1 = arg0;
            arg2.F1 = arg2.F1;
            arg2.F0 = s_17.F0;
        }
        else
        {
            new S0(9263139407297508576UL, 126, 142, -99, -9223372036854775808L, 0, 9223372036854775806L, 7572936615843479271UL, 8974376558292352572L).M78();
        }

        return (ushort)new S0(17685611945483975479UL, 59, 1, -1, -2866168766837499328L, 235, 7203366480007451860L, 10UL, 5889666345585643749L).M78();
    }

    public static S1 M79(ushort arg0)
    {
        s_22 = s_21[0][0, 0].F2;
        arg0 -= arg0;
        ref I0[] var0 = ref s_67;
        var0 = var0;
        var0 = ref var0;
        arg0 = arg0--;
        var0 = var0;
        arg0 = (ushort)((uint)((long)(arg0++ + s_11[0, 0]) / (uint)(s_54[0]++ | 1)) % (short)(s_1[0].F0++ | 1));
        return new S1(32766, -3895066369849649400L, 2);
    }

    public static int M80(ref short arg0, bool[] arg1, S0 arg2)
    {
        sbyte var0 = default(sbyte);
        var0 = -75;
        if (arg1[0])
        {
            s_73 = arg2;
            arg2.F2 = 0;
            s_1[0].F2 = arg0;
        }

        arg2.F6 = arg2.F8-- | var0--;
        return s_58--;
    }

    public static short M84(byte arg0, uint arg1, I0 arg2, bool arg3)
    {
        new S0(3617237372005645969UL, -127, 147, 10, 9223372036854775807L, 1, 1L, 3701406145374787119UL, -2L).M85(new C1(0, 61068, 0), s_42[0].F7);
        return s_18.F0--;
    }

    public static long M86()
    {
        S0 var0 = default(S0);
        if (s_29[0, 0, 0])
        {
            var0 = new S0(1UL, -30, 193, 2, 8166086034723274172L, 0, 8814693838607821631L, 12590091570178166939UL, 5705612624228164973L);
        }
        else
        {
            s_32[0].F2 = 33857;
            s_36.F6 = 7672701535041005452L;
            new S1(8206, 3807452904248185220L, -11994).M87(ref s_73.F2);
        }

        return s_73.F4;
    }

    public static ulong M89(long arg0, uint[] arg1)
    {
        arg1[0] = 4294967295U;
        s_36.F1 = 25;
        M90();
        return s_6.F7;
    }

    public static bool M90()
    {
        return default(bool);
    }

    public static long M92()
    {
        return default(long);
    }

    public static ref short M93(byte[] arg0)
    {
        long var0 = default(long);
        short var1 = default(short);
        uint var5 = default(uint);
        ulong var6 = default(ulong);
        short var8 = default(short);
        S0 var9 = default(S0);
        long[] var10 = default(long[]);
        short var11 = default(short);
        S1 var13 = default(S1);
        ulong var14 = default(ulong);
        uint var15 = default(uint);
        uint var16 = default(uint);
        byte var18 = default(byte);
        C1 var20 = default(C1);
        arg0[0] = arg0[0];
        if (!s_78)
        {
            arg0[0] = arg0[0];
            new C0(-16, 0, true).M94();
            var0 = s_73.F6++;
        }

        var1 = s_88[0].F0--;
        {
            arg0 = s_45;
            for (int var2 = 0; var2 < 2; var2++)
            {
                arg0 = arg0;
                s_90 = 8703786057143513244UL;
                M95(arg0[0], new int[]{-1789270516, 533638841, 10, 0, -2147483647});
            }

            M96();
        }

        arg0 = arg0;
        arg0[0] = s_89.F2--;
        {
            s_91 = ~(long)(0 >> s_26[0]);
            arg0 = new byte[]{117, 178, 1, 1, 250};
            for (int var3 = 0; var3 < 2; var3++)
            {
                M96();
                if (s_31.F2)
                {
                    arg0 = arg0;
                    for (int var4 = 0; var4 < 2; var4++)
                    {
                        var5 = (uint)(-s_81++);
                        arg0 = arg0;
                        var1 = var1++;
                    }

                    var6 = 14650447909255504265UL;
                    try
                    {
                        M96();
                    }
                    finally
                    {
                        s_24.F7 = var6;
                    }

                    if (!!!s_23.F2)
                    {
                        var6 = var6++;
                        var1 = var1;
                        ref short var7 = ref var1;
                    }
                    else
                    {
                        var6 = 0UL;
                        var8 = var1;
                    }

                    {
                        var1 = var1;
                    }

                    var1 = 32767;
                    M95(arg0[0], new int[]{-572326180, 1, 2147483647, 10, 1487549085, -1612655603, -2147483648});
                    var9 = s_73;
                    var9.F2 = arg0[0];
                    var9.F6 = var9.F4;
                }
            }

            var1 = var1;
            arg0 = arg0;
        }

        if (s_31.F2)
        {
            if (!s_27[0].F2)
            {
                s_16.F1 = s_73.F5;
                if (s_50.F2)
                {
                    arg0 = arg0;
                    s_92 = -1117478653;
                    var10 = new long[]{-57851897163110035L, -9223372036854775808L, -3315409728358538894L, 0L, 0L, 0L, 0L};
                    return ref s_32[0].F0;
                }
            }
            else
            {
                var11 = var1--;
                for (int var12 = 0; var12 < 2; var12++)
                {
                    var13 = new S1(25875, 3942964689799706479L, -10);
                    var14 = 1UL;
                    if (s_2[0])
                    {
                        var15 = ~(uint)(38 % (int)(var12 | 1));
                        var1 = var11;
                    }
                }

                var16 = ~(uint)(-9223372036854775808L | (short)(~var11));
                if (67 <= new S1(-9619, 1L, -2).M103().M97(new S1(-32768, 7770680337893836946L, 0)))
                {
                    arg0 = arg0;
                    --M101();
                }

                var11 = var1;
                for (int var17 = 0; var17 < 2; var17++)
                {
                    new S1((short)(-s_47++), (long)(1 >> arg0[0]), 7879).M103();
                }

                var18 = s_69;
            }

            {
                ref C1 var19 = ref s_88[0];
            }

            M95(122, new int[]{-2147483647, -1412467163, -2147483648, 1559656244});
            arg0 = arg0;
        }
        else
        {
            var1 = var1;
            {
                arg0[0] = arg0[0]++;
                s_42[0].F1 = s_42[0].F3--;
            }

            return ref s_8[0];
        }

        var20 = new C1(-278, 7460, 65535);
        s_31 = new C0(1, 0, true);
        return ref var20.F0;
    }

    public static C1 M95(byte arg0, int[] arg1)
    {
        arg0 = arg0;
        return s_53;
    }

    public static I0 M96()
    {
        s_86.F0 = s_3;
        return s_65;
    }

    public static sbyte M100(short arg0)
    {
        M101();
        return s_86.F0--;
    }

    public static ref long M101()
    {
        I0[] var0 = default(I0[]);
        sbyte var2 = default(sbyte);
        if (false || !s_22)
        {
            try
            {
                var0 = new I0[]{new S0(5020889333963331692UL, -127, 168, 1, 1L, 255, 1L, 0UL, 8192003529078272534L)};
            }
            finally
            {
                s_17.M102();
                s_95 = new byte[]{0, 171, 244, 247, 1};
            }

            ref C1 var1 = ref s_32[0];
            return ref s_89.F4;
        }

        s_58 = ~(-s_92);
        s_73.F8 = s_6.F8--;
        var2 = 51;
        return ref s_73.F6;
    }

    public static C1 M104()
    {
        byte var0 = default(byte);
        var0 = s_31.F1--;
        var0 = s_71;
        return new C1(-2, 0, 0);
    }

    public static ushort[] M109(ref int arg0, ref I0[] arg1)
    {
        arg1[0] = arg1[0];
        return s_26;
    }

    public static bool M110(ref uint arg0)
    {
        uint var0 = default(uint);
        var0 = arg0;
        return true;
    }

    public static S0 M111(sbyte arg0, ulong[] arg1, bool arg2, C1 arg3, ref byte[] arg4, bool[] arg5, S1 arg6)
    {
        arg3 = arg3;
        return new S0(18446744073709551614UL, 1, 1, -10, -9223372036854775808L, 163, -1205101632137260351L, 10UL, 1L);
    }

    public static ref ulong M113(ref ushort arg0, C0 arg1)
    {
        M114(ref arg1.F2, s_67, arg1.F0, new uint[, ]{{0U, 1U, 2233031977U, 2069211246U}}, (short)(~s_88[0].F0--));
        arg1.F0 = (sbyte)(-s_42[0].F1--);
        s_18.F2 = 30958;
        return ref s_42[0].F0;
    }

    public static S0 M114(ref bool arg0, I0[] arg1, sbyte arg2, uint[, ] arg3, short arg4)
    {
        C0[] var0 = default(C0[]);
        C0 var1 = default(C0);
        arg1 = arg1;
        var0 = new C0[]{new C0(2, 10, false), new C0(-128, 136, true), new C0(-96, 1, false), new C0(-40, 136, false), new C0(0, 254, false), new C0(0, 0, false), new C0(126, 133, true), new C0(-109, 69, false), new C0(-128, 228, true)};
        var1 = var0[0];
        return new S0(0UL, -115, 254, -87, -9223372036854775808L, 151, -4617124435109528494L, 8902029461306423864UL, 1976727158463114907L);
    }

    public static I0[] M115(uint arg0)
    {
        sbyte[] var0 = default(sbyte[]);
        ushort var1 = default(ushort);
        var0 = new sbyte[]{-125, -47};
        var1 = (ushort)(~~~s_89.F0++ ^ s_73.F2);
        return new I0[]{new S0(13711843214020487388UL, -45, 175, 127, 2749402744792698677L, 160, 4488254413509380902L, 0UL, 91806286193978197L), new S0(4168609344042423094UL, 1, 14, -67, 9223372036854775806L, 255, -2L, 1UL, 2L), new S0(1UL, -60, 10, -111, 0L, 0, 3665102667166421282L, 0UL, 9223372036854775807L), new S0(9675293147688009886UL, 58, 148, 64, 9223372036854775807L, 197, -1146168878237180741L, 14711800068685043059UL, 3246426985887566340L), new S0(8732740862997638783UL, 20, 20, -32, -10L, 213, 9223372036854775806L, 12364137203941103241UL, 8939480571023764393L)};
    }

    public static ref long M117()
    {
        short var0 = default(short);
        s_36.F4 = 3229206664026210217L;
        var0 = M118();
        return ref s_68[0];
    }

    public static short M118()
    {
        C1[][, ] var0 = default(C1[][, ]);
        var0 = new C1[][, ]{new C1[, ]{{new C1(-19967, 1, 0), new C1(-32767, 5282, 64786)}}, new C1[, ]{{new C1(0, 0, 0), new C1(-14389, 0, 31480)}, {new C1(-22288, 23255, 65535), new C1(-13352, 57308, 65535)}, {new C1(3245, 0, 1), new C1(-9992, 0, 18246)}, {new C1(0, 0, 29391), new C1(1, 62595, 65534)}}, new C1[, ]{{new C1(0, 65535, 65534), new C1(-8644, 65534, 30834)}, {new C1(32766, 31587, 65534), new C1(-2, 65534, 63319)}}, new C1[, ]{{new C1(-32768, 1, 65534), new C1(15841, 23771, 65534)}}};
        if (s_23.F2)
        {
            var0[0][0, 0] = new C1(-32767, 40551, 61494);
        }

        return (short)(3148075458U << var0[0][0, 0].F2);
    }
}