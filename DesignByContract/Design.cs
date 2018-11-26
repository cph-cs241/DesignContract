using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignByContract
{
    public partial class form : Form
    {

        private Dictionary<string, Account> Accountcollection;
        private AccountManger am = new AccountManger();
        double number;
        public form()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void Design_Load(object sender, EventArgs e)
        {

            label2.Visible = false;
            label2.Text = " Your input is not valid";
            Accountcollection = am.getDrugsCollection();
            comboBox1.Items.Clear();
            foreach (string name in Accountcollection.Keys)
            {
                comboBox1.Items.Add(name);

            }
            comboBox1.SelectedIndex = 0;

            listView1.Clear();

            foreach (Account name in Accountcollection.Values)
            {


                listView1.Items.Add(name.ToString());

            }

        }
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text) && double.TryParse(textBox1.Text, out number))
            {

                double amount = double.Parse(textBox1.Text);
                if (amount >= 0)
                {
                    string a = comboBox1.Text;
                    Account acount = (Account)Accountcollection[a];
                    acount.Deposit(amount);
                    Design_Load(sender, e);
                }
                else
                {
                    label2.Visible = true;
                }

            }
            else
            {
                System.Diagnostics.Debug.Write("/N this is combobox   :  " + comboBox1.Text);
                label2.Visible = true;
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {

            label2.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text) && double.TryParse(textBox1.Text, out number))
            {

                double amount = double.Parse(textBox1.Text);
                string a = comboBox1.Text;
                Account acount = Accountcollection[a];
                acount.Withdraw(amount);                
                Design_Load(sender, e);

            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
