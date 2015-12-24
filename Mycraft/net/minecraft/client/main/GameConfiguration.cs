using System;
using com.mojang.authlib.properties;
using java.io;
using java.net;
using Mycraft.net.minecraft.util;

namespace Mycraft.net.minecraft.client.main
{
    public class GameConfiguration
    {
        public readonly GameConfiguration.UserInformation field_178745_a;
        public readonly GameConfiguration.DisplayInformation field_178743_b;
        public readonly GameConfiguration.FolderInformation field_178744_c;
        public readonly GameConfiguration.GameInformation field_178741_d;
        public readonly GameConfiguration.ServerInformation field_178742_e;
        private static readonly String __OBFID = "CL_00001918";
        public GameConfiguration(GameConfiguration.UserInformation p_i45491_1_, GameConfiguration.DisplayInformation p_i45491_2_, GameConfiguration.FolderInformation p_i45491_3_, GameConfiguration.GameInformation p_i45491_4_, GameConfiguration.ServerInformation p_i45491_5_)
        {
            this.field_178745_a = p_i45491_1_;
            this.field_178743_b = p_i45491_2_;
            this.field_178744_c = p_i45491_3_;
            this.field_178741_d = p_i45491_4_;
            this.field_178742_e = p_i45491_5_;
        }
        public  class DisplayInformation
        {
            public  int field_178764_a;
            public  int field_178762_b;
            public  bool field_178763_c;
            public  bool field_178761_d;
            private static readonly String __OBFID = "CL_00001917";

            public DisplayInformation(int p_i45490_1_, int p_i45490_2_, bool p_i45490_3_, bool p_i45490_4_)
            {
                this.field_178764_a = p_i45490_1_;
                this.field_178762_b = p_i45490_2_;
                this.field_178763_c = p_i45490_3_;
                this.field_178761_d = p_i45490_4_;
            }
        }
        public  class FolderInformation
        {
            public  File field_178760_a;
        public  File field_178758_b;
        public  File field_178759_c;
        public  String field_178757_d;
        private static readonly String __OBFID = "CL_00001916";

        public FolderInformation(File p_i45489_1_, File p_i45489_2_, File p_i45489_3_, String p_i45489_4_)
            {
                this.field_178760_a = p_i45489_1_;
                this.field_178758_b = p_i45489_2_;
                this.field_178759_c = p_i45489_3_;
                this.field_178757_d = p_i45489_4_;
            }
        }
        public  class GameInformation
        {
            public  bool field_178756_a;
        public readonly String field_178755_b;
        private static readonly String __OBFID = "CL_00001915";

        public GameInformation(bool p_i45488_1_, String p_i45488_2_)
            {
                this.field_178756_a = p_i45488_1_;
                this.field_178755_b = p_i45488_2_;
            }
        }
        public  class ServerInformation
        {
            public readonly String field_178754_a;
        public  int field_178753_b;
            private static readonly String __OBFID = "CL_00001914";

        public ServerInformation(String p_i45487_1_, int p_i45487_2_)
            {
                this.field_178754_a = p_i45487_1_;
                this.field_178753_b = p_i45487_2_;
            }
        }
        public  class UserInformation
        {
            public  Session field_178752_a;
        public  PropertyMap field_178750_b;
        public  Proxy field_178751_c;
        private static readonly String __OBFID = "CL_00001913";

        public UserInformation(Session p_i45486_1_, PropertyMap p_i45486_2_, Proxy p_i45486_3_)
            {
                this.field_178752_a = p_i45486_1_;
                this.field_178750_b = p_i45486_2_;
                this.field_178751_c = p_i45486_3_;
            }
        }
    }
}
