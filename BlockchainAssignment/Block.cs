using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        public int index;
        DateTime timestamp;
        public String hash;
        public String prevHash;

        public List<Transaction> transactionList = new List<Transaction>();
        public String markleRoot;




        public long nonce = 0;
        public int difficulty = 4;

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = String.Empty;


        /*Creating the Genesis Block Constructor*/
        public Block()
        {
            this.timestamp = DateTime.Now;
            this.index = 0;
            this.prevHash = String.Empty;
            reward = 0;
            transactionList = new List<Transaction>();
            this.hash = Mine();

        }

        public String Mine()
        {
            String hash = CreateHash();


            String re = new String('0', difficulty);

            nonce = 0;


            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }

            return hash;
        }




        public Block(int index, String prevHash)
        {
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = hash;
            this.hash = CreateHash();

        }

        public Block(Block lastBlock)
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.hash = Mine();

        }



        public Block(Block lastBlock, List<Transaction> transactions, String address = "")
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.hash = CreateHash();

            minerAddress = address;




            transactions.Add(CreateRewardTransaction(transactions));
            transactionList = new List<Transaction>(transactions);

            markleRoot = MerkleRoot(transactionList);

            hash = Mine();
        }


        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {

            fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);

            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");

        }

        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher;
            hasher = SHA256Managed.Create();
            String input = index.ToString() + timestamp.ToString() + prevHash + nonce.ToString() + reward.ToString() + markleRoot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));


            // The code bellow ise used
            // to convert a Hash from a byte array to a string
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }


            return hash;


        }


        public static String MerkleRoot(List<Transaction> transactionList)
        {

            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if (hashes.Count == 0)
            {
                return String.Empty;
            }
            if (hashes.Count == 1)
            {
                return HashCode.HashTools.CombineHash(hashes[0], hashes[0]);
            }

            while (hashes.Count != 1)
            {
                List<String> merkleleaves = new List<String>();
                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleleaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i]));
                    }
                    else
                    {
                        merkleleaves.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1]));
                    }
                }
                hashes = merkleleaves;
            }
            return hashes[0];
        }






        public override string ToString()
        {
            return "Index: " + index.ToString() + 
                "\nTime Stamp:" + timestamp.ToString() + 
                "\nPrevious Hash:" + prevHash + 
                "\nHash:" + hash + 
                "\nNonce" + nonce.ToString() +
                "\nDifficulty" + difficulty.ToString() +
                "\nRewards" + reward.ToString() +
                "\nFees" + fees.ToString() +
                "\nMiners Address" + minerAddress +
                "\nTransactions:" + transactionList.Count;
        }

    }
}