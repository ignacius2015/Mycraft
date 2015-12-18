using System.Collections.Generic;

public class Util
{
    private  string __OBFID = "CL_00001633";

    public static Util.EnumOS OSType
    {
        get
        {
            string var0 = java.lang.System.getProperty("os.name").ToLower();
            return var0.Contains("win") ? Util.EnumOS.WINDOWS : (var0.Contains("mac") ? Util.EnumOS.OSX : (var0.Contains("solaris") ? Util.EnumOS.SOLARIS : (var0.Contains("sunos") ? Util.EnumOS.SOLARIS : (var0.Contains("linux") ? Util.EnumOS.LINUX : (var0.Contains("unix") ? Util.EnumOS.LINUX : Util.EnumOS.UNKNOWN)))));
        }
    }

    public sealed class EnumOS
    {
        public static readonly EnumOS LINUX = new EnumOS("LINUX", InnerEnum.LINUX, "LINUX", 0);
        public static readonly EnumOS SOLARIS = new EnumOS("SOLARIS", InnerEnum.SOLARIS, "SOLARIS", 1);
        public static readonly EnumOS WINDOWS = new EnumOS("WINDOWS", InnerEnum.WINDOWS, "WINDOWS", 2);
        public static readonly EnumOS OSX = new EnumOS("OSX", InnerEnum.OSX, "OSX", 3);
        public static readonly EnumOS UNKNOWN = new EnumOS("UNKNOWN", InnerEnum.UNKNOWN, "UNKNOWN", 4);

        private static readonly IList<EnumOS> valueList = new List<EnumOS>();

        static EnumOS()
        {
            valueList.Add(LINUX);
            valueList.Add(SOLARIS);
            valueList.Add(WINDOWS);
            valueList.Add(OSX);
            valueList.Add(UNKNOWN);
        }

        public enum InnerEnum
        {
            LINUX,
            SOLARIS,
            WINDOWS,
            OSX,
            UNKNOWN
        }

        private readonly string nameValue;
        private readonly int ordinalValue;
        private readonly InnerEnum innerEnumValue;
        private static int nextOrdinal = 0;

        internal static readonly Util.EnumOS[] VALUES = new Util.EnumOS[]{LINUX, SOLARIS, WINDOWS, OSX, UNKNOWN
    };
    internal const string __OBFID = "CL_00001660";

    internal EnumOS(string name, InnerEnum innerEnum, string p_i1357_1_, int p_i1357_2_)
    {

        nameValue = name;
        ordinalValue = nextOrdinal++;
        innerEnumValue = innerEnum;
    }

    public static IList<EnumOS> values()
    {
        return valueList;
    }

    public InnerEnum InnerEnumValue()
    {
        return innerEnumValue;
    }

    public int ordinal()
    {
        return ordinalValue;
    }

    public override string ToString()
    {
        return nameValue;
    }

    public static EnumOS valueOf(string name)
    {
        foreach (EnumOS enumInstance in EnumOS.values())
        {
            if (enumInstance.nameValue == name)
            {
                return enumInstance;
            }
        }
        throw new System.ArgumentException(name);
    }
}
}
