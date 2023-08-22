using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // Bu metot Password'ün Hash'ini Oluşturmaya yarıyor.
        public static void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt)  
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // Bu metot sonradan sisteme girmek isteyen bir kişinin password'ünün veri kaynağımızdaki Hash'le eşleşip eşleşmediğine bakıyor.
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));      // computedHash = Hesaplanan Hash

                for (int i = 0; i < computedHash.Length; i++)  
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
               
                return true;
            }

            
        }
    }
}
