using System;
using com.google.common.@base;
using com.google.common.collect;
using java.lang;
using java.util;
using java.util.function;
using String = System.String;
using Object = System.Object;

namespace Mycraft.net.minecraft.util
{
    public class ObjectIntIdentityMap:IObjectIntIterable
    {
    private IdentityHashMap field_148749_a = new IdentityHashMap(512);
    private List field_148748_b = Lists.newArrayList();
    private static readonly String __OBFID = "CL_00001203";

    public void func_148746_a(Object p_148746_1_, int p_148746_2_)
    {
        this.field_148749_a.put(p_148746_1_, java.lang.Integer.valueOf(p_148746_2_));

        while (this.field_148748_b.size() <= p_148746_2_)
        {
            this.field_148748_b.add((Object)null);
        }

        this.field_148748_b.set(p_148746_2_, p_148746_1_);
    }

    public int func_148747_b(Object p_148747_1_)
    {
            java.lang.Integer var2 = (java.lang.Integer)this.field_148749_a.get(p_148747_1_);
        return var2 == null ? -1 : var2.intValue();
    }

    public Object func_148745_a(int p_148745_1_)
    {
        return p_148745_1_ >= 0 && p_148745_1_ < this.field_148748_b.size() ? this.field_148748_b.get(p_148745_1_) : null;
    }

    public Iterator iterator()
    {
        return Iterators.filter(this.field_148748_b.iterator(), Predicates.notNull());
    }

    public bool func_148744_b(int p_148744_1_)
    {
        return this.func_148745_a(p_148744_1_) != null;
    }

        public void forEach(Consumer action)
        {
            throw new NotImplementedException();
        }

        public void forEach(Iterable value1, Consumer value2)
        {
            throw new NotImplementedException();
        }

        public Spliterator spliterator()
        {
            throw new NotImplementedException();
        }

        public Spliterator spliterator(Iterable value)
        {
            throw new NotImplementedException();
        }
    }

}
