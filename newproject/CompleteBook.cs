﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    public partial class CompleteBook : Form
    {
        public CompleteBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        


        }

        private void CompleteBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-HQPD7LE\\PAFKIET;  database = Librarymanagement; Integrated Security= True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = " select * from IssueBook where book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


            cmd.CommandText = " select * from IssueBook where book_return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
