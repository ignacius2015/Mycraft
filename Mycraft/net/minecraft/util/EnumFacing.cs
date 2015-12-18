using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycraft.net.minecraft.util
{
    public sealed class EnumFacing
    {
        public static readonly EnumFacing DOWN = new EnumFacing("DOWN", InnerEnum.DOWN, 0, 1, 0, -1, 0);
        public static readonly EnumFacing UP = new EnumFacing("UP", InnerEnum.UP, 1, 0, 0, 1, 0);
        public static readonly EnumFacing NORTH = new EnumFacing("NORTH", InnerEnum.NORTH, 2, 3, 0, 0, -1);
        public static readonly EnumFacing SOUTH = new EnumFacing("SOUTH", InnerEnum.SOUTH, 3, 2, 0, 0, 1);
        public static readonly EnumFacing EAST = new EnumFacing("EAST", InnerEnum.EAST, 4, 5, -1, 0, 0);
        public static readonly EnumFacing WEST = new EnumFacing("WEST", InnerEnum.WEST, 5, 4, 1, 0, 0);

        private static readonly IList<EnumFacing> valueList = new List<EnumFacing>();

        public enum InnerEnum
        {
            DOWN,
            UP,
            NORTH,
            SOUTH,
            EAST,
            WEST
        }

        private readonly string nameValue;
        private readonly int ordinalValue;
        private readonly InnerEnum innerEnumValue;
        private static int nextOrdinal = 0;

        /// <summary>
        /// Face order for D-U-N-S-E-W. </summary>
        private readonly int order_a;

        /// <summary>
        /// Face order for U-D-S-N-W-E. </summary>
        private readonly int order_b;
        private readonly int frontOffsetX;
        private readonly int frontOffsetY;
        private readonly int frontOffsetZ;

        /// <summary>
        /// List of all values in EnumFacing. Order is D-U-N-S-E-W. </summary>
        private static readonly EnumFacing[] faceList = new EnumFacing[6];
        private const string __OBFID = "CL_00001201";

        private EnumFacing(string name, InnerEnum innerEnum, int p_i1367_3_, int p_i1367_4_, int p_i1367_5_, int p_i1367_6_, int p_i1367_7_)
        {
            this.order_a = p_i1367_3_;
            this.order_b = p_i1367_4_;
            this.frontOffsetX = p_i1367_5_;
            this.frontOffsetY = p_i1367_6_;
            this.frontOffsetZ = p_i1367_7_;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        /// <summary>
        /// Returns a offset that addresses the block in front of this facing.
        /// </summary>
        public int FrontOffsetX
        {
            get
            {
                return this.frontOffsetX;
            }
        }

        public int FrontOffsetY
        {
            get
            {
                return this.frontOffsetY;
            }
        }

        /// <summary>
        /// Returns a offset that addresses the block in front of this facing.
        /// </summary>
        public int FrontOffsetZ
        {
            get
            {
                return this.frontOffsetZ;
            }
        }

        /// <summary>
        /// Returns the facing that represents the block in front of it.
        /// </summary>
        public static EnumFacing getFront(int p_82600_0_)
        {
            return faceList[p_82600_0_ % faceList.Length];
        }

        static EnumFacing()
        {
            EnumFacing[] var0 = values();
            int var1 = var0.Length;

            for (int var2 = 0; var2 < var1; ++var2)
            {
                EnumFacing var3 = var0[var2];
                faceList[var3.order_a] = var3;
            }

            valueList.Add(DOWN);
            valueList.Add(UP);
            valueList.Add(NORTH);
            valueList.Add(SOUTH);
            valueList.Add(EAST);
            valueList.Add(WEST);
        }

        public static IList<EnumFacing> values()
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

        public static EnumFacing valueOf(string name)
        {
            foreach (EnumFacing enumInstance in EnumFacing.values())
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
