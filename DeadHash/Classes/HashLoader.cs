using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DeadHash.Classes
{
    /// <summary>
    /// Static class for loading the hash(es) of a file or text
    /// </summary>
    internal static class HashLoader
    {
        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the MD5 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The MD5 hash of a file</returns>
        internal static string GetMD5FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (MD5 md5 = new MD5CryptoServiceProvider())
                {
                    return HashToString(md5.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the MD5 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into an MD5 hash</param>
        /// <returns>The MD5 hash of a string</returns>
        internal static string GetMD5FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                return HashToString(md5.ComputeHash(bytes));
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-1 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The SHA-1 hash of a file</returns>
        internal static string GetSHA1FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (SHA1 sha = new SHA1Managed())
                {
                    return HashToString(sha.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-1 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a SHA-1 hash</param>
        /// <returns>The SHA-1 hash of a string</returns>
        internal static string GetSHA1FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (SHA1 sha = new SHA1Managed())
            {
                return HashToString(sha.ComputeHash(bytes));
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-256 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The SHA-256 hash of a file</returns>
        internal static string GetSHA256FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (SHA256 sha = new SHA256Managed())
                {
                    return HashToString(sha.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-256 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a SHA-256 hash</param>
        /// <returns>The SHA-256 hash of a string</returns>
        internal static string GetSHA256FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (SHA256 sha = new SHA256Managed())
            {
                return HashToString(sha.ComputeHash(bytes));
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-384 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The SHA-284 hash of a file</returns>
        internal static string GetSHA384FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (SHA384 sha = new SHA384Managed())
                {
                    return HashToString(sha.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-384 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a SHA-384 hash</param>
        /// <returns>The SHA-384 hash of a string</returns>
        internal static string GetSHA384FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (SHA384 sha = new SHA384Managed())
            {
                return HashToString(sha.ComputeHash(bytes));
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-512 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The SHA-512 hash of a file</returns>
        internal static string GetSHA512FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (SHA512 sha = new SHA512Managed())
                {
                    return HashToString(sha.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the SHA-512 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a SHA-512 hash</param>
        /// <returns>The SHA-512 hash of a string</returns>
        internal static string GetSHA512FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (SHA512 sha = new SHA512Managed())
            {
                return HashToString(sha.ComputeHash(bytes));
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the RIPEMD-160 hash of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The RIPEMD-160 hash of a file</returns>
        internal static string GetRIPEMD160FromFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (RIPEMD160 ripemd160 = new RIPEMD160Managed())
                {
                    return HashToString(ripemd160.ComputeHash(fs));
                }
            }
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the RIPEMD-160 hash of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a RIPEMD-160 hash</param>
        /// <returns>The RIPEMD-160 hash of a string</returns>
        internal static string GetRIPEMD160FromString(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (RIPEMD160 ripemd160 = new RIPEMD160Managed())
            {
                return HashToString(ripemd160.ComputeHash(bytes));
            }
        }

        /// <summary>
        /// Convert a hexadecimal byte collection into humanly readable text
        /// </summary>
        /// <param name="hash">A hexadecimal byte collection</param>
        /// <returns>A humanly readable string that represents the hash</returns>
        private static string HashToString(IEnumerable<byte> hash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte t in hash)
            {
                sb.Append(t.ToString("x2"));
            }
            return sb.ToString();
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the CRC32 checksum of a file
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        /// <returns>The CRC32 checksum of a file</returns>
        internal static string GetCRC32FromFile(string path)
        {
            Crc32 crc32 = new Crc32();
            string hash = string.Empty;

            using (FileStream fs = File.OpenRead(path))
            {
                foreach (byte b in crc32.ComputeHash(fs))
                {
                    hash += b.ToString("x2").ToLower();
                }
            }
            return hash;
        }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// Get the CRC32 checksum of a string
        /// </summary>
        /// <param name="text">The string that needs to be converted into a CRC32 checksum</param>
        /// <returns>The CRC32 checksum of a string</returns>
        internal static string GetCRC32FromString(string text)
        {
            Crc32 crc32 = new Crc32();
            string hash = string.Empty;
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            foreach (byte b in crc32.ComputeHash(bytes))
            {
                hash += b.ToString("x2").ToLower();
            }
            return hash;
        }
    }
}
