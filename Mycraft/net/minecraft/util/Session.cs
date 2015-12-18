using System.Collections;
using System.Collections.Generic;
using com.google.common.collect;
using com.mojang.authlib;
using com.mojang.util;
using java.util;
using String = System.String;

namespace Mycraft.net.minecraft.util
{
    public class Session
    {
        private  String username;
        private  String playerID;
        private  Session.Type field_152429_d;
        private static readonly String __OBFID = "CL_00000659";
        public Session(String p_i1098_1_, String p_i1098_2_, String p_i1098_3_, String p_i1098_4_)
        {
            this.username = p_i1098_1_;
            this.playerID = p_i1098_2_;
            this.token = p_i1098_3_;
            this.field_152429_d = Session.Type.func_152421_a(p_i1098_4_);
        }

        public String getSessionID()
        {
            return "token:" + this.token + ":" + this.playerID;
        }
        public String getPlayerID()
        {
            return this.playerID;
        }

        public String getUsername()
        {
            return this.username;
        }

        public String getToken()
        {
            return this.token;
        }
        public GameProfile func_148256_e()
        {
            try
            {
                UUID var1 = UUIDTypeAdapter.fromString(this.getPlayerID());
                return new GameProfile(var1, this.getUsername());
            }
            catch (java.lang.IllegalArgumentException var2)
            {
                return new GameProfile((UUID)null, this.getUsername());
            }
        }

        public Session.Type func_152428_f()
        {
            return this.field_152429_d;
        }
        public sealed class Type
        {
            public static readonly Type LEGACY = new Type("LEGACY", InnerEnum.LEGACY, "LEGACY", 0, "legacy");
            public static readonly Type MOJANG = new Type("MOJANG", InnerEnum.MOJANG, "MOJANG", 1, "mojang");

            private static readonly IList<Type> valueList = new List<Type>();

            public enum InnerEnum
            {
                LEGACY,
                MOJANG
            }

            private readonly string nameValue;
            private readonly int ordinalValue;
            private readonly InnerEnum innerEnumValue;
            private static int nextOrdinal = 0;
            private static readonly Map field_152425_c = Maps.newHashMap();
            private readonly string field_152426_d;

            private static readonly Session.Type[] VALUES = new Session.Type[]{LEGACY, MOJANG};
        private const string __OBFID = "CL_00001851";

        private Type(string name, InnerEnum innerEnum, string p_i1096_1_, int p_i1096_2_, string p_i1096_3_)
        {
            this.field_152426_d = p_i1096_3_;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public static Session.Type func_152421_a(string p_152421_0_)
        {
            return (Session.Type)field_152425_c[p_152421_0_.ToLower()];
        }

        static Type()
        {
                Type[] var0 = values();
            int var1 = var0.Length;

            for (int var2 = 0; var2 < var1; ++var2)
            {
                Session.Type var3 = var0[var2];
                field_152425_c[var3.field_152426_d] = var3;
            }

            valueList.Add(LEGACY);
            valueList.Add(MOJANG);
        }

        public static IList<Type> values()
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

        public static Type valueOf(string name)
        {
            foreach (Type enumInstance in Type.values())
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
}
