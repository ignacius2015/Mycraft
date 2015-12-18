
using System;
namespace Mycraft.net.minecraft.util
{
    public class ChatComponentTranslationFormatException: java.lang.IllegalArgumentException
    {
    private static readonly String __OBFID = "CL_00001271";

    public ChatComponentTranslationFormatException(ChatComponentTranslation p_i45161_1_, String p_i45161_2_): base(String.Format("Error parsing: %s: %s", new Object[] { p_i45161_1_, p_i45161_2_ }))
    {
       
    }

    public ChatComponentTranslationFormatException(ChatComponentTranslation p_i45162_1_, int p_i45162_2_):base(String.Format("Invalid index %d requested for %s", new Object[] { java.lang.Integer.valueOf(p_i45162_2_), p_i45162_1_ }))
        {
        
    }

    public ChatComponentTranslationFormatException(ChatComponentTranslation p_i45163_1_, java.lang.Throwable p_i45163_2_):base(String.Format("Error while parsing: %s", new Object[] { p_i45163_1_ }), p_i45163_2_)
        {
        
    }
}

}
