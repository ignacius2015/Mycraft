﻿using System;
using java.io;
using java.security;
using java.security.spec;
using javax.crypto;
using javax.crypto.spec;

namespace Mycraft.net.minecraft.util
{
    public class CryptManager
    {
        private static readonly String __OBFID = "CL_00001483";

    /**
     * Generate a new shared secret AES key from a secure random source
     */
        public static SecretKey createNewSharedKey()
        {
            try
            {
                KeyGenerator var0 = KeyGenerator.getInstance("AES");
                var0.init(128);
                return var0.generateKey();
            }
            catch (NoSuchAlgorithmException var1)
            {
                throw new java.lang.Error(var1);
            }
        }
        public static KeyPair createNewKeyPair()
        {
            try
            {
                KeyPairGenerator var0 = KeyPairGenerator.getInstance("RSA");
                var0.initialize(1024);
                return var0.generateKeyPair();
            }
            catch (NoSuchAlgorithmException var1)
            {
                var1.printStackTrace();
                java.lang.System.err.println("Key pair generation failed!");
                return null;
            }
        }
        /**
     * Compute a serverId hash for use by sendSessionRequest()
     */
        public static byte[] getServerIdHash(String p_75895_0_, PublicKey p_75895_1_, SecretKey p_75895_2_)
        {
            try
            {
                System.Text.Encoding enc = System.Text.Encoding.Unicode;
                return digestOperation("SHA-1", new byte[][] { enc.GetBytes(p_75895_0_), p_75895_2_.getEncoded(), p_75895_1_.getEncoded() });
            }
            catch (UnsupportedEncodingException var4)
            {
                var4.printStackTrace();
                return null;
            }
        }
        /**
     * Compute a message digest on arbitrary byte[] data
     */
        private static byte[] digestOperation(string p_75893_0_, params byte[][] p_75893_1_)
        {
            try
            {
                MessageDigest var2 = MessageDigest.getInstance(p_75893_0_);
                byte[][] var3 = p_75893_1_;
                int var4 = p_75893_1_.Length;

                for (int var5 = 0; var5 < var4; ++var5)
                {
                    byte[] var6 = var3[var5];
                    var2.update(var6);
                }

                return var2.digest();
            }
            catch (NoSuchAlgorithmException var7)
            {
                var7.printStackTrace();
                return null;
            }
        }
        /**
     * Create a new PublicKey from encoded X.509 data
     */
        public static PublicKey decodePublicKey(byte[] p_75896_0_)
        {
            try
            {
                X509EncodedKeySpec var1 = new X509EncodedKeySpec(p_75896_0_);
                KeyFactory var2 = KeyFactory.getInstance("RSA");
                return var2.generatePublic(var1);
            }
            catch (NoSuchAlgorithmException var3)
            {
                
            }
            catch (InvalidKeySpecException var4)
            {
                
            }

            java.lang.System.err.println("Public key reconstitute failed!");
            return null;
        }
        /**
     * Decrypt shared secret AES key using RSA private key
     */
        public static SecretKey decryptSharedKey(PrivateKey p_75887_0_, byte[] p_75887_1_)
        {
            return new SecretKeySpec(decryptData(p_75887_0_, p_75887_1_), "AES");
        }

        /**
         * Encrypt byte[] data with RSA public key
         */
        public static byte[] encryptData(Key p_75894_0_, byte[] p_75894_1_)
        {
            return cipherOperation(1, p_75894_0_, p_75894_1_);
        }

        /**
         * Decrypt byte[] data with RSA private key
         */
        public static byte[] decryptData(Key p_75889_0_, byte[] p_75889_1_)
        {
            return cipherOperation(2, p_75889_0_, p_75889_1_);
        }
        /**
     * Encrypt or decrypt byte[] data using the specified key
     */
        private static byte[] cipherOperation(int p_75885_0_, Key p_75885_1_, byte[] p_75885_2_)
        {
            try
            {
                return createTheCipherInstance(p_75885_0_, p_75885_1_.getAlgorithm(), p_75885_1_).doFinal(p_75885_2_);
            }
            catch (IllegalBlockSizeException var4)
            {
                var4.printStackTrace();
            }
            catch (BadPaddingException var5)
            {
                var5.printStackTrace();
            }

            java.lang.System.err.println("Cipher data failed!");
            return null;
        }
        /**
             * Creates the Cipher Instance.
             */
        private static Cipher createTheCipherInstance(int p_75886_0_, String p_75886_1_, Key p_75886_2_)
        {
            try
            {
                Cipher var3 = Cipher.getInstance(p_75886_1_);
                var3.init(p_75886_0_, p_75886_2_);
                return var3;
            }
            catch (InvalidKeyException var4)
            {
                var4.printStackTrace();
            }
            catch (NoSuchAlgorithmException var5)
            {
                var5.printStackTrace();
            }
            catch (NoSuchPaddingException var6)
            {
                var6.printStackTrace();
            }

            java.lang.System.err.println("Cipher creation failed!");
            return null;
        }
        public static Cipher func_151229_a(int p_151229_0_, Key p_151229_1_)
        {
            try
            {
                Cipher var2 = Cipher.getInstance("AES/CFB8/NoPadding");
                var2.init(p_151229_0_, p_151229_1_, new IvParameterSpec(p_151229_1_.getEncoded()));
                return var2;
            }
            catch (GeneralSecurityException var3)
            {
                throw new java.lang.RuntimeException(var3);
            }
        }
    }
}