using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> Blocks;


        public List<Transaction> transactionPool = new List<Transaction>();

        private int transactionsPerBlock = 5;


        public Blockchain()
        {
            Blocks = new List<Block>()

            {
                new Block()
            };
        }

        public String getBlockAsString(int index)
        {
            return Blocks[index].ToString();
        }

        public Block GetLastBlock()
        {
            return Blocks[Blocks.Count - 1];

        }

        public static bool ValidateHash(Block b)
        {
            String rehash = b.CreateHash();
            return rehash.Equals(b.hash);
        }

        public List<Transaction> GetPendingTransactions()
        {
            int n = Math.Min(transactionsPerBlock, transactionPool.Count);

            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);

            return transactions;
        }


        

        public override string ToString()
        {
            String output = String.Empty;
            Blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }

        public static bool ValidateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.markleRoot);
        }

        public double GetBalance(String address)
        {
            double balance = 0;
            foreach(Block b in Blocks)
            {
                foreach(Transaction t in b.transactionList)
                {
                    if(t.recipientAddress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if(t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }

            return balance;

        }


    }
}
