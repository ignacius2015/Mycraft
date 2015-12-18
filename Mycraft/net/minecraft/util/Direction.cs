using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycraft.net.minecraft.util
{
    public class Direction
    {
        public static  int[] offsetX = new int[] { 0, -1, 0, 1 };
        public static  int[] offsetZ = new int[] { 1, 0, -1, 0 };
        public static  String[] directions = new String[] {"SOUTH", "WEST", "NORTH", "EAST"};

    /** Maps a Direction value (2D) to a Facing value (3D). */
    public static  int[] directionToFacing = new int[] { 3, 4, 2, 5 };

        /** Maps a Facing value (3D) to a Direction value (2D). */
        public static  int[] facingToDirection = new int[] { -1, -1, 2, 0, 1, 3 };

        /** Maps a direction to that opposite of it. */
        public static  int[] rotateOpposite = new int[] { 2, 3, 0, 1 };

        /** Maps a direction to that to the right of it. */
        public static  int[] rotateRight = new int[] { 1, 2, 3, 0 };

        /** Maps a direction to that to the left of it. */
        public static  int[] rotateLeft = new int[] { 3, 0, 1, 2 };
        public static  int[,] bedDirection = new int[,] { { 1, 0, 3, 2, 5, 4 }, { 1, 0, 5, 4, 2, 3 }, { 1, 0, 2, 3, 4, 5 }, { 1, 0, 4, 5, 3, 2 } };
        private static readonly String __OBFID = "CL_00001506";

    /**
     * Returns the movement direction from a velocity vector.
     */
    public static int getMovementDirection(double p_82372_0_, double p_82372_2_)
        {
            return MathHelper.abs((float)p_82372_0_) > MathHelper.abs((float)p_82372_2_) ? (p_82372_0_ > 0.0D ? 1 : 3) : (p_82372_2_ > 0.0D ? 2 : 0);
        }
    }
}
