using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class Login : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die ab.
        /// </summary>
        private SqlConnection _connection;
        /// <summary>
        /// Dieser string stellt die Verbindungszeichungsfolge zu der Datenbank Datei (mdf).
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Instanz von DataManager
        /// </summary>
        private readonly DataManager<Person> _dataManager = new DataManager<Person>();
        
        /// <summary>
        /// Für das Form Login wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            _connectionString = _dataManager.ConnectionString;
        }
        /// <summary>
        /// Ein Eventhandler wenn man das Textbox Username rein geht, dann wird das BackColor von Textbox geandert
        /// und auch ein Panel von Textbox Username
        /// </summary>
        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
            panel2.BackColor = Color.White;
            pictureBoxUsername.BackColor= Color.White;
            panel3.BackColor = SystemColors.Control;
            textBoxPassword.BackColor = SystemColors.Control;
            pictureBoxShowpassword.BackColor= SystemColors.Control;
        }
        /// <summary>
        /// Ein Eventhandler wenn man das Textbox Password rein geht, dann wird das BackColor von Textbox geandert
        /// und auch ein Panel von Textbox Password
        /// </summary>
        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            panel3.BackColor = Color.White;
            pictureBoxShowpassword.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBoxUsername.BackColor = SystemColors.Control;
            pictureBoxUsername.BackColor = SystemColors.Control;
        }
        /// <summary>
        /// Ein Event wenn man das PictureBox(Vorhängeschloss) drückt dann wird das Password character angezeigt (Show Password)
        /// </summary>
        private void pictureBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }
        /// <summary>
        /// Ein Event wenn man das PictureBox(Vorhängeschloss) verlässt dann wird das Password character
        /// wieder als schwarzer Punkt angezeigt.
        /// </summary>
        private void pictureBoxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == @"Password")
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Ein Event wenn man das Button anklicken dann wird zur Methode getLoginData weiterleiten um
        /// das Login Verfahren zu bekommen
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            getLoginData();
        }

        /// <summary>
        /// Rüft die Username und Password von der Datenbank. Er stellt eine Verbindung mit dem DatenBank und zwar MySql 
        /// und die Daten für jeweiligen TextBox Username und Password mit dem Datenbank Tabelle bei
        /// PersonSet_Worker vergleichen.
        /// </summary>
        private void getLoginData()
        {
            var query = "SELECT * FROM PersonSet_Worker a WHERE a.Username  = '" + textBoxUsername.Text + "'and a.Password='" +
                        textBoxPassword.Text + "'";
            using (_connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, _connection))
            using (SqlDataAdapter adatpe = new SqlDataAdapter(command))
            {
                DataSet ds = new DataSet();
                adatpe.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show(@"Falsche Username und oder Password");
                    textBoxUsername.Text = @"Username";
                    textBoxPassword.Text = @"Password";
                    textBoxPassword.UseSystemPasswordChar = false;
                }
            }
        }

        /// <summary>
        /// Ein Event wenn man im TextBox rein geht dann wird das Username Text weg und die Farbe auch nach Schwarz
        /// gewechselt so als Watermark
        /// </summary>
        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == @"Username")
                textBoxUsername.Text = "";

            textBoxUsername.ForeColor = Color.Black;
        }
        /// <summary>
        /// Ein Event wenn man im TextBox verlässt mit leer Text wieder zurück zur Username
        /// </summary>
        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
                textBoxUsername.Text = @"Username";

            textBoxUsername.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Ein Event wenn man im TextBox rein geht dann wird das Password Text weg und die Farbe auch nach Schwarz
        /// gewechselt so als Watermark
        /// </summary>
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == @"Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
            }
            
            textBoxPassword.ForeColor = Color.Black;
        }
        /// <summary>
        /// Ein Event wenn man im TextBox verlässt mit leer Text wieder zurück zur Password
        /// </summary>
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = @"Password";
                textBoxPassword.UseSystemPasswordChar = false;
            }
            textBoxPassword.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Ein Event wenn man das Enter drückt dann wird zur Methode getLoginData weiterleiten um
        /// das Login Verfahren zu bekommen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               getLoginData();
            }

        }
    }
}
