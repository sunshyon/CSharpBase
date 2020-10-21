using DP.Facade.Subsystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Facade.Facade
{
    public class EncryptFacade : AbstractFacade
    {
        private FileReader reader;
        private NewCipherMachine cipher;
        private FileWriter writer;
        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new NewCipherMachine();
            writer = new FileWriter();
        }
        public override void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}
