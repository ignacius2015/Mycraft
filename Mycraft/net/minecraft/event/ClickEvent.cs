using System;
using com.google.common.collect;
using java.util;
using System.Collections.Generic;
using System.Collections;

namespace Mycraft.net.minecraft.@event
{
    public class ClickEvent
    {
        private readonly ClickEvent.Action action;
        private readonly string value;
        private const string __OBFID = "CL_00001260";
        public ClickEvent(ClickEvent.Action p_i45156_1_, string p_i45156_2_)
        {
            this.action = p_i45156_1_;
            this.value = p_i45156_2_;
        }
        /// <summary>
		/// Gets the action to perform when this event is raised.
		/// </summary>
		public virtual ClickEvent.Action getAction()
        {
            return this.action;
        }
        /// <summary>
		/// Gets the value to perform the action on when this event is raised.  For example, if the action is "open URL",
		/// this would be the URL to open.
		/// </summary>
		public virtual string Value
        {
            get
            {
                return this.value;
            }
        }
        public override bool Equals(object p_equals_1_)
        {
            if (this == p_equals_1_)
            {
                return true;
            }
            else if (p_equals_1_ != null && this.GetType() == p_equals_1_.GetType())
            {
                ClickEvent var2 = (ClickEvent)p_equals_1_;

                if (this.action != var2.action)
                {
                    return false;
                }
                else
                {
                    if (this.value != null)
                    {
                        if (!this.value.Equals(var2.value))
                        {
                            return false;
                        }
                    }
                    else if (var2.value != null)
                    {
                        return false;
                    }

                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "ClickEvent{action=" + this.action + ", value=\'" + this.value + '\'' + '}';
        }

        public override int GetHashCode()
        {
            int var1 = this.action.GetHashCode();
            var1 = 31 * var1 + (this.value != null ? this.value.GetHashCode() : 0);
            return var1;
        }
        public sealed class Action
		{
			public static readonly Action OPEN_URL = new Action("OPEN_URL", InnerEnum.OPEN_URL, "OPEN_URL", 0, "open_url", true);
			public static readonly Action OPEN_FILE = new Action("OPEN_FILE", InnerEnum.OPEN_FILE, "OPEN_FILE", 1, "open_file", false);
			public static readonly Action RUN_COMMAND = new Action("RUN_COMMAND", InnerEnum.RUN_COMMAND, "RUN_COMMAND", 2, "run_command", true);
			public static readonly Action TWITCH_USER_INFO = new Action("TWITCH_USER_INFO", InnerEnum.TWITCH_USER_INFO, "TWITCH_USER_INFO", 3, "twitch_user_info", false);
			public static readonly Action SUGGEST_COMMAND = new Action("SUGGEST_COMMAND", InnerEnum.SUGGEST_COMMAND, "SUGGEST_COMMAND", 4, "suggest_command", true);

			private static readonly IList<Action> valueList = new List<Action>();

			public enum InnerEnum
			{
				OPEN_URL,
				OPEN_FILE,
				RUN_COMMAND,
				TWITCH_USER_INFO,
				SUGGEST_COMMAND
			}

			private readonly string nameValue;
			private readonly int ordinalValue;
			private readonly InnerEnum innerEnumValue;
			private static int nextOrdinal = 0;
			internal static readonly Map nameMapping = Maps.newHashMap();
			internal readonly bool allowedInChat;
			internal readonly string canonicalName;

			internal static readonly ClickEvent.Action[] VALUES = new ClickEvent.Action[]{OPEN_URL, OPEN_FILE, RUN_COMMAND, TWITCH_USER_INFO, SUGGEST_COMMAND};
			internal const string __OBFID = "CL_00001261";

			internal Action(string name, InnerEnum innerEnum, string p_i45155_1_, int p_i45155_2_, string p_i45155_3_, bool p_i45155_4_)
			{
				this.canonicalName = p_i45155_3_;
				this.allowedInChat = p_i45155_4_;

				nameValue = name;
				ordinalValue = nextOrdinal++;
				innerEnumValue = innerEnum;
			}

			public bool shouldAllowInChat()
			{
				return this.allowedInChat;
			}

			public string CanonicalName
			{
				get
				{
					return this.canonicalName;
				}
			}

			public static ClickEvent.Action getValueByCanonicalName(string p_150672_0_)
			{
				return (ClickEvent.Action)nameMapping.get(p_150672_0_);
			}

			static Action()
			{
                Action[] var0 = values();
				int var1 = var0.Length;

				for (int var2 = 0; var2 < var1; ++var2)
				{
					ClickEvent.Action var3 = var0[var2];
					nameMapping.put(var3.CanonicalName, var3);
                }

				valueList.Add(OPEN_URL);
				valueList.Add(OPEN_FILE);
				valueList.Add(RUN_COMMAND);
				valueList.Add(TWITCH_USER_INFO);
				valueList.Add(SUGGEST_COMMAND);
			}

			public static IList<Action> values()
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

			public static Action valueOf(string name)
			{
				foreach (Action enumInstance in Action.values())
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

    
