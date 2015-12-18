using System;

namespace Mycraft.net.minecraft.util
{
    public class MovementInput
    {
        /**
         * The speed at which the player is strafing. Postive numbers to the left and negative to the right.
         */
        public float moveStrafe;

        /**
         * The speed at which the player is moving forward. Negative numbers will move backwards.
         */
        public float moveForward;
        public bool jump;
        public bool sneak;
        private static readonly String __OBFID = "CL_00000936";

        public void updatePlayerMoveState() { }
    }
}
