using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {

        private Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            UpdateText("New blockchain initialised!");
        }

        private void UpdateText(string text)
        {
            UpdateText(text, output);
        }

        private void UpdateText(String text, RichTextBox output)
        {
            output.Text = text;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(Int32.TryParse(textBox1.Text,out index))
            {

                output.Text = blockchain.getBlockAsString(index);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Wallet.Wallet.ValidatePrivateKey(privateKey.Text,publicKey.Text))
            {
                output.Text = "Keys are Valid";
            }
            else
            {
                output.Text = "Keys are not valid";
            }
        }





        private void CreateTransaction_Click_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            /* TODO: Validate transaction */
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        private void newBlock_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.GetPendingTransactions();
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions,publicKey.Text );
            blockchain.Blocks.Add(newBlock);
            output.Text = blockchain.ToString();

        }



        private void validateChain_Click(object sender, EventArgs e)
        {
            // CASE: Genesis Block - Check only hash as no transactions are currently present
            if (blockchain.Blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.Blocks[0])) // Recompute Hash to check validity
                    UpdateText("Blockchain is invalid");
                else
                    UpdateText("Blockchain is valid");
                return;
            }

            for (int i = 1; i < blockchain.Blocks.Count - 1; i++)
            {
                if (
                    blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash || // Check hash "chain"
                    !Blockchain.ValidateHash(blockchain.Blocks[i]) ||  // Check each blocks hash
                    !Blockchain.ValidateMerkleRoot(blockchain.Blocks[i]) // Check transaction integrity using Merkle Root
                )
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }


        private void checkBalance_Click(object sender, EventArgs e)
        {
            output.Text = "Assigment Coin :" + blockchain.GetBalance(publicKey.Text).ToString() ;
        }


        private void PrintPendingTransactions_Click_1(object sender, EventArgs e)
        {
            UpdateText(String.Join("\n", blockchain.transactionPool));

        }

        private void print_all_blocks_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());

        }
    }


}
