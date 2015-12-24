using System;
using com.google.gson;
using com.mojang.authlib.properties;
using java.io;
using java.net;
using java.util;
using joptsimple;
using Mycraft.net.minecraft.client;
using Mycraft.net.minecraft.util;

namespace Mycraft.net.minecraft.client.main
{
    public class Main
    {
        private static readonly String __OBFID = "CL_00001461";
        public static String var25=null;
        public static String var26=null;
        internal class Temp:Authenticator
        {
            private static readonly String __OBFID = "CL_00000828";
            protected override PasswordAuthentication getPasswordAuthentication()
            {
                return new PasswordAuthentication(var25, var26.ToCharArray());
            }
        }
        public static void main(String[] p_main_0_)
        {
            java.lang.System.setProperty("java.net.preferIPv4Stack", "true");
            OptionParser var1 = new OptionParser();
            var1.allowsUnrecognizedOptions();
            var1.accepts("demo");
            var1.accepts("fullscreen");
            var1.accepts("checkGlErrors");
            ArgumentAcceptingOptionSpec var2 = var1.accepts("server").withRequiredArg();
            ArgumentAcceptingOptionSpec var3 = var1.accepts("port").withRequiredArg().ofType(typeof(int?)).defaultsTo(Convert.ToInt32(25565), new int?[0]);
            ArgumentAcceptingOptionSpec var4 = var1.accepts("gameDir").withRequiredArg().ofType(typeof(File)).defaultsTo(new File("."), new File[0]);
            ArgumentAcceptingOptionSpec var5 = var1.accepts("assetsDir").withRequiredArg().ofType(typeof(File));
            ArgumentAcceptingOptionSpec var6 = var1.accepts("resourcePackDir").withRequiredArg().ofType(typeof(File));
            ArgumentAcceptingOptionSpec var7 = var1.accepts("proxyHost").withRequiredArg();
            ArgumentAcceptingOptionSpec var8 = var1.accepts("proxyPort").withRequiredArg().defaultsTo("8080", new string[0]).ofType(typeof(int?));
            ArgumentAcceptingOptionSpec var9 = var1.accepts("proxyUser").withRequiredArg();
            ArgumentAcceptingOptionSpec var10 = var1.accepts("proxyPass").withRequiredArg();
            ArgumentAcceptingOptionSpec var11 = var1.accepts("username").withRequiredArg().defaultsTo("Player" + Minecraft.SystemTime % 1000L, new string[0]);
            ArgumentAcceptingOptionSpec var12 = var1.accepts("uuid").withRequiredArg();
            ArgumentAcceptingOptionSpec var13 = var1.accepts("accessToken").withRequiredArg().required();
            ArgumentAcceptingOptionSpec var14 = var1.accepts("version").withRequiredArg().required();
            ArgumentAcceptingOptionSpec var15 = var1.accepts("width").withRequiredArg().ofType(typeof(int?)).defaultsTo(Convert.ToInt32(854), new int?[0]);
            ArgumentAcceptingOptionSpec var16 = var1.accepts("height").withRequiredArg().ofType(typeof(int?)).defaultsTo(Convert.ToInt32(480), new int?[0]);
            ArgumentAcceptingOptionSpec var17 = var1.accepts("userProperties").withRequiredArg().required();
            ArgumentAcceptingOptionSpec var18 = var1.accepts("assetIndex").withRequiredArg();
            ArgumentAcceptingOptionSpec var19 = var1.accepts("userType").withRequiredArg().defaultsTo("legacy", new string[0]);
            NonOptionArgumentSpec var20 = var1.nonOptions();
            OptionSet var21 = var1.parse(p_main_0_);
            List var22 = var21.valuesOf(var20);
            if (!var22.isEmpty())
            {
                java.lang.System.@out.println("Completely ignored arguments: " + var22);
            }
            String var23 = (String)var21.valueOf(var7);
            Proxy var24 = Proxy.NO_PROXY;
            if (var23 != null)
            {
                try
                {
                    var24 = new Proxy(Proxy.Type.SOCKS, new InetSocketAddress(var23, ((java.lang.Integer)var21.valueOf(var8)).intValue()));
                }
                catch (Exception var43)
                {
                    
                }
            }
             var25 = (String)var21.valueOf(var9);
             var26 = (String)var21.valueOf(var10);
            Temp temp=new Temp();
            if (!var24.equals(Proxy.NO_PROXY) && func_110121_a(var25) && func_110121_a(var26))
            {
                Authenticator.setDefault(temp);
            }
            int var27 = ((java.lang.Integer)var21.valueOf(var15)).intValue();
            int var28 = ((java.lang.Integer)var21.valueOf(var16)).intValue();
            bool var29 = var21.has("fullscreen");
            bool var30 = var21.has("checkGlErrors");
            bool var31 = var21.has("demo");
            String var32 = (String)var21.valueOf(var14);
            PropertyMap var33 = (PropertyMap)(new GsonBuilder()).registerTypeAdapter(PropertyMap.getClass(), new PropertyMap.Serializer()).create().fromJson((string)var21.valueOf(var17), typeof(PropertyMap));
            File var34 = (File)var21.valueOf(var4);
            File var35 = var21.has(var5) ? (File)var21.valueOf(var5) : new File(var34, "assets/");
            File var36 = var21.has(var6) ? (File)var21.valueOf(var6) : new File(var34, "resourcepacks/");
            String var37 = var21.has(var12) ? (String)var12.value(var21) : (String)var11.value(var21);
            String var38 = var21.has(var18) ? (String)var18.value(var21) : null;
            String var39 = (String)var21.valueOf(var2);
            java.lang.Integer var40 = (java.lang.Integer)var21.valueOf(var3);
            Session var41 = new Session((String)var11.value(var21), var37, (String)var13.value(var21), (String)var19.value(var21));
            GameConfiguration var42 = new GameConfiguration(new GameConfiguration.UserInformation(var41, var33, var24), new GameConfiguration.DisplayInformation(var27, var28, var29, var30), new GameConfiguration.FolderInformation(var34, var36, var35, var38), new GameConfiguration.GameInformation(var31, var32), new GameConfiguration.ServerInformation(var39, var40.intValue()));
            Temp2 tt = new Temp2("Client Shutdown Thread");
            java.lang.Runtime.getRuntime().addShutdownHook(tt);
            java.lang.Thread.currentThread().setName("Client thread");
            (new Minecraft(var42)).run();
        }
        internal class Temp2: java.lang.Thread
        {
            public Temp2(String text):base("Client Shutdown Thread")
            { }

            public Temp2()
            {
            }

            private static readonly String __OBFID = "CL_00000829";
            public void run()
            {
                Minecraft.stopIntegratedServer();
            }

        }
        private static bool func_110121_a(String p_110121_0_)
        {
            return p_110121_0_ != null && p_110121_0_.Length > 0;
        }
    }
}
