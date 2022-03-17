namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.reciever = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.validateChain = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.PrintPendingTransactions = new System.Windows.Forms.Button();
            this.print_all_blocks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(657, 314);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate a Wallet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(238, 329);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(288, 20);
            this.privateKey.TabIndex = 5;
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(238, 355);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(288, 20);
            this.publicKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Private";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Public";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Validate the keys";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.Location = new System.Drawing.Point(13, 509);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(84, 44);
            this.CreateTransaction.TabIndex = 10;
            this.CreateTransaction.Text = "Send Transaction";
            this.CreateTransaction.UseVisualStyleBackColor = true;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click_Click);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(103, 533);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(100, 20);
            this.fee.TabIndex = 11;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(103, 509);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 12;
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(316, 533);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(257, 20);
            this.reciever.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Receivers Key";
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(13, 468);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(84, 35);
            this.newBlock.TabIndex = 17;
            this.newBlock.Text = "Create a new block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.newBlock_Click);
            // 
            // validateChain
            // 
            this.validateChain.Location = new System.Drawing.Point(580, 411);
            this.validateChain.Name = "validateChain";
            this.validateChain.Size = new System.Drawing.Size(95, 50);
            this.validateChain.TabIndex = 18;
            this.validateChain.Text = "Validate Chain";
            this.validateChain.UseVisualStyleBackColor = true;
            this.validateChain.Click += new System.EventHandler(this.validateChain_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(580, 460);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(95, 50);
            this.checkBalance.TabIndex = 19;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // PrintPendingTransactions
            // 
            this.PrintPendingTransactions.Location = new System.Drawing.Point(12, 434);
            this.PrintPendingTransactions.Name = "PrintPendingTransactions";
            this.PrintPendingTransactions.Size = new System.Drawing.Size(191, 28);
            this.PrintPendingTransactions.TabIndex = 20;
            this.PrintPendingTransactions.Text = "Read pending transactions";
            this.PrintPendingTransactions.UseVisualStyleBackColor = true;
            this.PrintPendingTransactions.Click += new System.EventHandler(this.PrintPendingTransactions_Click_1);
            // 
            // print_all_blocks
            // 
            this.print_all_blocks.Location = new System.Drawing.Point(13, 365);
            this.print_all_blocks.Name = "print_all_blocks";
            this.print_all_blocks.Size = new System.Drawing.Size(190, 26);
            this.print_all_blocks.TabIndex = 21;
            this.print_all_blocks.Text = "Print All Blocks";
            this.print_all_blocks.UseVisualStyleBackColor = true;
            this.print_all_blocks.Click += new System.EventHandler(this.print_all_blocks_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 562);
            this.Controls.Add(this.print_all_blocks);
            this.Controls.Add(this.PrintPendingTransactions);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validateChain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CreateTransaction;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button validateChain;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Button PrintPendingTransactions;
        private System.Windows.Forms.Button print_all_blocks;
    }
}

