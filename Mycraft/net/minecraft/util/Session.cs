using System;
using System.Collections;
using System.Collections.Generic;
using com.google.common.collect;
using com.mojang.authlib;
using com.mojang.util;
using ikvm.extensions;
using java.util;

namespace Mycraft.net.minecraft.util
{
    public class Session
    {
        private String username;
        private String playerID;
        private String token;
        private Session.Type sessionType;
        private static readonly String __OBFID = "CL_00000659";
        public Session(String p_i1098_1_, String p_i1098_2_, String p_i1098_3_, String p_i1098_4_)
        {
            this.username = p_i1098_1_;
            this.playerID = p_i1098_2_;
            this.token = p_i1098_3_;
            this.sessionType = Session.Type.setSessionType(p_i1098_4_);
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

        public GameProfile getProfile()
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
        public Session.Type getSessionType()
        {
            return this.sessionType;
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
            private readonly string sessionType;
            private string v1;
            private InnerEnum lEGACY;
            private string v2;
            private int v3;
            private string v4;

            public Type(string v1, InnerEnum lEGACY, string v2, int v3, string v4)
            {
                this.v1 = v1;
                this.lEGACY = lEGACY;
                this.v2 = v2;
                this.v3 = v3;
                this.v4 = v4;
            }

            private static readonly Session.Type[] VALUES = new Session.Type[] { LEGACY, MOJANG };
            private const string __OBFID = "CL_00001851";

            private Type(string name, InnerEnum innerEnum, string p_i1096_1_, int p_i1096_2_, string p_i1096_3_)
            {
                this.sessionType = p_i1096_3_;

                nameValue = name;
                ordinalValue = nextOrdinal++;
                innerEnumValue = innerEnum;
            }

            public static Session.Type setSessionType(string p_152421_0_)
            {
                return (Session.Type)field_152425_c.get(p_152421_0_.toLowerCase());
            }

            static Type()
            {
                Type[] var0 = values();
                int var1 = var0.Length;

                for (int var2 = 0; var2 < var1; ++var2)
                {
                    Session.Type var3 = var0[var2];
                    field_152425_c.put(var3.sessionType, var3);
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
