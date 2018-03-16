using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace test1
{
    public partial class MainForm : Form
    {
        string table = "";
        int lastRowsCount = -1;
        OracleCommand cmd = new OracleCommand();
        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Member");
            comboBox1.Items.Add("Book");
            comboBox1.Items.Add("Librarian");
            cmd.Connection = Connection.Conn;
        }
        /*Get all the available books*/
        private void availableBooksButton_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = "all the available books";
            Connection.GetDataByQueryString("select name_of_book, code_of_book from book where book.available = 'yes'", dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    table = "Member";
                    break;
                case 1:
                    table = "Book";
                    break;
                case 2:
                    table = "Librarian";
                    break;
            }

            if (table == "")
                dataGridView1.DataSource = null;
            else
                Connection.GetDataByQueryString("select * from "+table, dataGridView1);
            lastRowsCount = dataGridView1.Rows.Count;
        }

        /*
         * Get all librarians are veteran X years
         */
        private void librariansVeteranButton_Click(object sender, EventArgs e)
        {
            librarians_veteran f = new librarians_veteran();
            f.Show();
        }
        /*
         * Get all the members whose age is greater than X.
         */
        private void memberGTxButton_Click(object sender, EventArgs e)
        {
            memberGTx f = new memberGTx();
            f.Show();
        }

        private void UpdateEligibilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand callProcCommand = new OracleCommand();
                if (Connection.Conn.State != ConnectionState.Open)
                    Connection.Conn.Open();
                callProcCommand.Connection = Connection.Conn;
                callProcCommand.CommandType = CommandType.StoredProcedure;
                callProcCommand.CommandText = "updateEligibility";
                callProcCommand.Parameters.Add("id", OracleType.Number);
                callProcCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Conn.Close();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            if (table == "")
                dataGridView1.DataSource = null;
            else
            {
                bool succesed = true;
                if (Connection.Conn.State != ConnectionState.Open)
                    Connection.Conn.Open();
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //Member
                        for (int i = lastRowsCount - 1; i < dataGridView1.Rows.Count - 1; ++i)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string date_of_birth = dataGridView1.Rows[i].Cells["date_of_birth"].Value.ToString();
                            string first_name = dataGridView1.Rows[i].Cells["first_name"].Value.ToString();
                            string last_name = dataGridView1.Rows[i].Cells["last_name"].Value.ToString();
                            string address = dataGridView1.Rows[i].Cells["address"].Value.ToString();
                            int years_of_subscription = int.Parse(dataGridView1.Rows[i].Cells["years_of_subscription"].Value.ToString());
                            int num_of_books = int.Parse(dataGridView1.Rows[i].Cells["num_of_books"].Value.ToString());
                            cmd.CommandText = String.Format("insert into member (first_name, last_name, address, date_of_birth, years_of_subscription, num_of_books, id) values ('{0}', '{1}', '{2}', to_date('{3}', 'dd/mm/yyyy HH24:MI:SS'), {4}, {5}, {6})",
                                first_name, last_name, address, date_of_birth, years_of_subscription, num_of_books, id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    case 1: //book
                        for (int i = lastRowsCount - 1; i < dataGridView1.Rows.Count - 1; ++i)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string name_of_book = dataGridView1.Rows[i].Cells["name_of_book"].Value.ToString();
                            string name_of_author = dataGridView1.Rows[i].Cells["name_of_author"].Value.ToString();
                            string available = dataGridView1.Rows[i].Cells["available"].Value.ToString();
                            string date_of_publishing = dataGridView1.Rows[i].Cells["date_of_publishing"].Value.ToString();
                            int code_of_book = int.Parse(dataGridView1.Rows[i].Cells["code_of_book"].Value.ToString());
                            cmd.CommandText = String.Format("insert into book (name_of_book, name_of_author, available, date_of_publishing, code_of_book, id) values ('{0}', '{1}', '{2}', to_date('{3}', 'dd/mm/yyyy HH24:MI:SS'), {4}, {5})",
                                name_of_book, name_of_author, available, date_of_publishing, code_of_book, id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    case 2: //Librarian
                        for (int i = lastRowsCount - 1; i < dataGridView1.Rows.Count - 1; ++i)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string date_of_birth = dataGridView1.Rows[i].Cells["date_of_birth"].Value.ToString();
                            string first_name = dataGridView1.Rows[i].Cells["first_name"].Value.ToString();
                            string last_name = dataGridView1.Rows[i].Cells["last_name"].Value.ToString();
                            string address = dataGridView1.Rows[i].Cells["address"].Value.ToString();
                            int seniority = int.Parse(dataGridView1.Rows[i].Cells["seniority"].Value.ToString());
                            cmd.CommandText = String.Format("insert into librarian (first_name, last_name, seniority, date_of_birth, address, id) values ('{0}', '{1}', {2}, to_date('{3}', 'dd/mm/yyyy HH24:MI:SS'), '{4}', {5})",
                                first_name, last_name, seniority, date_of_birth, address, id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    default:
                        MessageBox.Show("No table selected");
                        break;
                }
                Connection.GetDataByQueryString("select * from " + table, dataGridView1);
                //connection.Conn.Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (table == "")
                dataGridView1.DataSource = null;
            else
            {
                bool succesed = true;
                string primary_key = "";
                if (Connection.Conn.State != ConnectionState.Open)
                    Connection.Conn.Open();
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //Member
                        primary_key = "id";
                        break;
                    case 1: //Book
                        primary_key = "code_of_book";
                        break;
                    case 2: //Librarian
                        primary_key = "id";
                        break;                        
                    default:
                        MessageBox.Show("No table selected");
                        break;
                }
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = int.Parse(row.Cells[primary_key].Value.ToString());
                    cmd.CommandText = String.Format("delete from {0} where id = {1}", table, id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        succesed = false;
                    }
                }
                if (succesed)
                    MessageBox.Show("The operation succesed");
                Connection.GetDataByQueryString("select * from "+table, dataGridView1);
                //connection.Conn.Close();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (table == "")
                dataGridView1.DataSource = null;
            else
            {
                bool succesed = true;
                if (Connection.Conn.State != ConnectionState.Open)
                    Connection.Conn.Open();
                string Query = "select * from "+table;
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //Member
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string date_of_birth = dataGridView1.Rows[i].Cells["date_of_birth"].Value.ToString();
                            string first_name = dataGridView1.Rows[i].Cells["first_name"].Value.ToString();
                            string last_name = dataGridView1.Rows[i].Cells["last_name"].Value.ToString();
                            string address = dataGridView1.Rows[i].Cells["address"].Value.ToString();
                            int years_of_subscription = int.Parse(dataGridView1.Rows[i].Cells["years_of_subscription"].Value.ToString());
                            int num_of_books = int.Parse(dataGridView1.Rows[i].Cells["num_of_books"].Value.ToString());
                            cmd.CommandText = String.Format("update member set date_of_birth = to_date('{0}', 'dd/mm/yyyy HH24:MI:SS'), first_name = '{1}', last_name = '{2}', address = '{3}', years_of_subscription = {4}, num_of_books = {5} where id = {6}",
                                date_of_birth,first_name,last_name,address,years_of_subscription,num_of_books,id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    case 1: //book
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string name_of_book = dataGridView1.Rows[i].Cells["name_of_book"].Value.ToString();
                            string name_of_author = dataGridView1.Rows[i].Cells["name_of_author"].Value.ToString();
                            string available = dataGridView1.Rows[i].Cells["available"].Value.ToString();
                            string date_of_publishing = dataGridView1.Rows[i].Cells["date_of_publishing"].Value.ToString();
                            int code_of_book = int.Parse(dataGridView1.Rows[i].Cells["code_of_book"].Value.ToString());
                            cmd.CommandText = String.Format("update book set date_of_publishing = to_date('{0}', 'dd/mm/yyyy HH24:MI:SS'), name_of_book = '{1}', name_of_author = '{2}', available = '{3}', id = {4} where code_of_book = {5}",
                                date_of_publishing, name_of_book, name_of_author, available, id, code_of_book);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    case 2: //Librarian
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            int id = int.Parse(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                            string date_of_birth = dataGridView1.Rows[i].Cells["date_of_birth"].Value.ToString();
                            string first_name = dataGridView1.Rows[i].Cells["first_name"].Value.ToString();
                            string last_name = dataGridView1.Rows[i].Cells["last_name"].Value.ToString();
                            string address = dataGridView1.Rows[i].Cells["address"].Value.ToString();
                            int seniority = int.Parse(dataGridView1.Rows[i].Cells["seniority"].Value.ToString());
                            cmd.CommandText = String.Format("update librarian set date_of_birth = to_date('{0}', 'dd/mm/yyyy HH24:MI:SS'), first_name = '{1}', last_name = '{2}', address = '{3}', seniority = {4} where id = {5}",
                                date_of_birth, first_name, last_name, address, seniority,id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                succesed = false;
                            }
                        }
                        if (succesed)
                            MessageBox.Show("The operation succesed");
                        break;
                    default:
                        MessageBox.Show("No table selected");
                        break;
                }
                Connection.Conn.Close();
                Connection.GetDataByQueryString(Query, dataGridView1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
