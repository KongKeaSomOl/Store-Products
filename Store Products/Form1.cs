namespace Store_Products
{
    public partial class Form1 : Form
    {
        Products objpd;
        bool EditMode;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an item for want to Delete.",
                    "No Item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            objpd = new Products();
            objpd = (Products)listView1.SelectedItems[0].Tag;
            txtid.Text = objpd.ID.ToString();
            textBox2.Text = objpd.Quantity.ToString();
            startEditing();
        }
        private void startEditing()
        {

            button2.Visible = false;
            //button3.Enabled = false;
            button7.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button1.Text = "&Save";
            button4.Text = "&Cancel";
            EditMode = true;
        }
        private void EndEditing()
        {

            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button1.Text = "&Add";
            button4.Text = "&Delete";
            EditMode = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = comboBox1.SelectedItem.ToString();


            switch (selectedProduct)
            {
                case "Clear Men":
                    textBox3.Text = "3$";
                    textBox5.Text = "1.50$";
                    textBox6.Text = "1.50$";
                    //TBST.Text = "30 Item";
                    break;
                case "Dove":
                    textBox3.Text = "6$";
                    textBox5.Text = "4$";
                    textBox6.Text = "2$";
                    //TBST.Text = "67 Item";
                    break;
                case "Sunsilk":
                    textBox3.Text = "6.50";
                    textBox5.Text = "4.50$";
                    textBox6.Text = "2$";
                    //TBST.Text = "70 Item";
                    break;
                case "Pond":
                    textBox3.Text = "2$";
                    textBox5.Text = "1$";
                    textBox6.Text = "1$";
                    //TBST.Text = "90 Item";
                    break;
                case "Nivea":
                    textBox3.Text = "3$";
                    textBox5.Text = "2$";
                    textBox6.Text = "1$";
                    //TBST.Text = "33 Item";
                    break;
                case "Vaseline":
                    textBox3.Text = "3.50$";
                    textBox5.Text = "2$";
                    textBox6.Text = "1.50$";
                    //TBST.Text = "58 Item";
                    break;
                case "Citra":
                    textBox3.Text = "7$";
                    textBox5.Text = "5.50$";
                    textBox6.Text = "2.50$";
                    //TBST.Text = "41 Item";
                    break;

                default:
                    textBox3.Text = "0$";
                    break;
            }

            textBox2.Text = "";
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && double.TryParse(textBox2.Text, out double quantity))
            {
                try
                {
                    double price = double.Parse(textBox3.Text.Substring(0, textBox3.Text.Length - 1));
                    double total = price * quantity;
                    txtResult.Text = total.ToString("C2");
                }
                catch (FormatException)
                {

                    MessageBox.Show(" Please Input number.");
                    txtResult.Text = "";
                }
            }
            else
            {
                txtResult.Text = "";
            }
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.2);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.2);
            listView1.Columns[4].Width = (int)(listView1.Width * 0.2);
            listView1.Columns[5].Width = (int)(listView1.Width * 0.2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save function -- EDIT MODE IS TRUE
            if (EditMode)
            {
                if (save())
                {
                    ClearInput();
                    EndEditing();
                }
                return;
            }


            //Add function --edit mode is false
            if (Add())
                ClearInput();


        }
        private bool save()
        {
            if (string.IsNullOrEmpty(txtid.Text) ||
               String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Please Enter All Data!",
                    "Incomplete", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }


            // Access the text values from the controls, handling potential parsing errors:
            try
            {
                objpd.ID = txtid.Text;
                objpd.Quantity = int.Parse(textBox2.Text);


                // Remove the dollar sign and parse as double:
                var totalText = txtResult.Text.TrimStart('$');
                objpd.Total = double.Parse(totalText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check the values and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method to prevent further processing
            }
            // Assign values without potential errors:
            objpd.Name = comboBox1.Text;

            objpd.Date = dateTimePicker1.Value;
            objpd.Expire = dateTimePicker2.Value;

            String[] prc = new string[6]; // Array size adjusted to accommodate 7 elements
            prc[0] = objpd.ID.ToString(); // Convert ID to string before storing
            prc[1] = objpd.Name;
            prc[2] = objpd.Quantity.ToString(); // Convert Quantity to string
            prc[3] = objpd.Total.ToString() + ("$"); // Convert Total to string
            prc[4] = objpd.Date.ToString(); // Convert Date to string
            prc[5] = objpd.Expire.ToString(); // Convert Expire to string


            ListViewItem item = new ListViewItem(prc);
            item.Tag = objpd;
            listView1.Items[listView1.SelectedItems[0].Index] = item;
            return true;
        }
        private bool Add()
        {
            if (string.IsNullOrEmpty(txtid.Text) ||
                String.IsNullOrEmpty(textBox2.Text) ||
                 String.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Please Enter All Data!",
                    "Incomplete", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }
            Products myProduct = new Products();

            // Access the text values from the controls, handling potential parsing errors:
            try
            {
                myProduct.ID = txtid.Text;
                myProduct.Quantity = int.Parse(textBox2.Text);


                // Remove the dollar sign and parse as double:
                var totalText = txtResult.Text.TrimStart('$');
                myProduct.Total = double.Parse(totalText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check the values and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method to prevent further processing
            }
            // Assign values without potential errors:
            myProduct.Name = comboBox1.Text;

            myProduct.Date = dateTimePicker1.Value;
            myProduct.Expire = dateTimePicker2.Value;

            String[] prc = new string[6]; // Array size adjusted to accommodate 7 elements
            prc[0] = myProduct.ID.ToString(); // Convert ID to string before storing
            prc[1] = myProduct.Name;
            prc[2] = myProduct.Quantity.ToString(); // Convert Quantity to string
            prc[3] = myProduct.Total.ToString() + ("$"); // Convert Total to string
            prc[4] = myProduct.Date.ToString(); // Convert Date to string
            prc[5] = myProduct.Expire.ToString(); // Convert Expire to string


            ListViewItem item = new ListViewItem(prc);
            item.Tag = myProduct;
            listView1.Items.Add(item);
            return true;

        }
        private void ClearInput()
        {
            txtid.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            txtResult.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            confirm = MessageBox.Show("You Want to Clear Items ???", "Pretty Sure??", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //check before clear
            if (confirm == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cancel function --- EDIt mode id true
            if (EditMode)
            {
                EndEditing();
                ClearInput();
                return;
            }
            //delete function -- edit mode is false
            // check if product selected
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please Select an item for you want to delete.",
                    "No! item Selected", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);
                return;
            }
            // confirm message
            DialogResult confirm = MessageBox.Show("Are you pretty sure " +
                "trust to delete?", "Okay?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //check comfirm before delete
            if (confirm == DialogResult.Yes)
            {
                //list view.item remove.selectItem
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listView1.Items.Remove(listView1.SelectedItems[i]);
                }
            }
        }
    }
}