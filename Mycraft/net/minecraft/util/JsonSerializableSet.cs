using System;
using com.google.common.collect;
using com.google.gson;
using java.util;

namespace Mycraft.net.minecraft.util
{
    public class JsonSerializableSet:ForwardingSet,IJsonSerializable
    {
        /** The set for this ForwardingSet to forward methods to. */
         private  Set underlyingSet = Sets.newHashSet();
         static readonly String __OBFID = "CL_00001482";
        public void func_152753_a(JsonElement p_152753_1_)
        {
            if (p_152753_1_.isJsonArray())
            {
                Iterator var2 = p_152753_1_.getAsJsonArray().iterator();

                while (var2.hasNext())
                {
                    JsonElement var3 = (JsonElement)var2.next();
                    this.add(var3.getAsString());
                }
            }
        }
        /**
     * Gets the JsonElement that can be serialized.
     */
        public JsonElement getSerializableElement()
        {
            JsonArray var1 = new JsonArray();
            Iterator var2 = this.iterator();

            while (var2.hasNext())
            {
                String var3 = (String)var2.next();
                var1.add(new JsonPrimitive(var3));
            }

            return var1;
        }

        protected Set @delegate()
        {
            return this.underlyingSet;
        }
    }
}
