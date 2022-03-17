using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace BlockchainAssignment
{
    class Transaction
    {
        public String hash,signature;
        public String senderAddress, recipientAddress;
        DateTime timestamp;
        public double amount,fee;



        public Transaction(String from, String to, double amount, double fee, String privateKey)
        {
            senderAddress = from;
            recipientAddress = to;
            this.amount = amount;
            this.fee = fee;

            timestamp = DateTime.Now;

            hash = CreateHash();
            signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);

        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher;
            hasher = SHA256Managed.Create();

            /*Hash all properties from the transaction*/
            String input = timestamp.ToString() + senderAddress + recipientAddress + amount.ToString() + fee.ToString();

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));


            // The code bellow ise used
            // to convert a Hash from a byte array to a string
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }


            return hash;


        }

        public override string ToString()
        {
            return "Transaction Hash: " + hash + "\nDigital Signture:" + signature 
                + "\nTime Stamp:" + timestamp.ToString() 
                + "\nTransferred amount:" + amount.ToString() 
                + "\nTransferred fee:" + fee.ToString() 
                + "\nSender Address:" + senderAddress 
                + "\nReceiver Address:" + recipientAddress;
        }
    }
}

