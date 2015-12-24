using System;
using java.io;
using java.lang.reflect;
using java.util;
using Mycraft.net.minecraft.client.main;

namespace Mycraft
{
    public class Start
    {
        public static void main(String[] args)
        {
            Main.main(concat(new String[] { "--version", "mcp", "--accessToken", "0", "--assetsDir", "assets", "--assetIndex", "1.8", "--userProperties", "{}" }, args));
        }
        public static T[] concat<T>(T[] first, T[] second)
        {
            T[] result = Arrays.CopyOf(first, first.Length + second.Length);
            System.Array.Copy(second, 0, result, first.Length, second.Length);
            return result;
        }
        internal static class Arrays
        {
            internal static T[] CopyOf<T>(T[] original, int newLength)
            {
                T[] dest = new T[newLength];
                System.Array.Copy(original, dest, newLength);
                return dest;
            }

            internal static T[] CopyOfRange<T>(T[] original, int fromIndex, int toIndex)
            {
                int length = toIndex - fromIndex;
                T[] dest = new T[length];
                System.Array.Copy(original, fromIndex, dest, 0, length);
                return dest;
            }

            internal static void Fill<T>(T[] array, T value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = value;
                }
            }

            internal static void Fill<T>(T[] array, int fromIndex, int toIndex, T value)
            {
                for (int i = fromIndex; i < toIndex; i++)
                {
                    array[i] = value;
                }
            }
        }


    }
}
