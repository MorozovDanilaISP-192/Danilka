using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using LiveCharts;
using LiveCharts.Wpf;

namespace DataBase
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source = Baza_dannykh.mdb";

        OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Автомобили]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView2.DataSource = table;
        }

        private void btn_input_t1_Click(object sender, EventArgs e)
        {
            string inpCode = Microsoft.VisualBasic.Interaction.InputBox("Введите код автомобиля");
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите марку автомобиля");
            string inpColor = Microsoft.VisualBasic.Interaction.InputBox("Введите цвет автомобиля");
            string inpPrice1 = Microsoft.VisualBasic.Interaction.InputBox("Введите оптовую цену автомобиля");
            string inpPrice2 = Microsoft.VisualBasic.Interaction.InputBox("Введите розничную цену автомобиля");

            string commandString = $"INSERT INTO [Автомобили] ([Код машины], [марка], [цвет], [цена оптоваая], [цена розничный]) VALUES ('{inpCode}', '{inpName}', '{inpColor}', '{inpPrice1}', '{inpPrice2}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t1_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите марку автомобиля");
            string inpPrice2 = Microsoft.VisualBasic.Interaction.InputBox("Введите розничную цену автомобиля");

            string commandString = $"UPDATE [Автомобили] SET [цена розничный] = '{inpPrice2}' WHERE [марка] = '{inpName}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t1_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите марку автомобиля");

            string commandString = $"DELETE FROM [Автомобили] WHERE [марка] = '{inpName}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_sel_t2_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Клиенты]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btn_inp_t2_Click(object sender, EventArgs e)
        {
            string inpCodeClient = Microsoft.VisualBasic.Interaction.InputBox("Введите код клиента");
            string inpSecName = Microsoft.VisualBasic.Interaction.InputBox("Введите фамилию");
            string inpNameClient = Microsoft.VisualBasic.Interaction.InputBox("Введите имя");
            string inpThirdName = Microsoft.VisualBasic.Interaction.InputBox("Введите отчество");
            string inpAddress = Microsoft.VisualBasic.Interaction.InputBox("Введите адрес");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите телефон");

            string commandString = $"INSERT INTO [Клиенты] ([Код клиента], [Фамилия], [Имя], [Отчество], [Адрес], [Телефон]) VALUES ('{inpCodeClient}', '{inpSecName}', '{inpNameClient}', '{inpThirdName}', '{inpAddress}', '{inpPhone}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t2_Click(object sender, EventArgs e)
        {
            string inpSecName = Microsoft.VisualBasic.Interaction.InputBox("Введите фамилию");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите телефон");

            string commandString = $"UPDATE [Клиенты] SET [Телефон] = '{inpPhone}' WHERE [Фамилия] = '{inpSecName}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t2_Click(object sender, EventArgs e)
        {
            string inpSecName = Microsoft.VisualBasic.Interaction.InputBox("Введите фамилию");

            string commandString = $"DELETE FROM [Клиенты] WHERE [Фамилия] = '{inpSecName}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_sel_t3_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Продажи]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView3.DataSource = table;
        }

        private void btn__inp_t3_Click(object sender, EventArgs e)
        {

            string inpCodeSell = Microsoft.VisualBasic.Interaction.InputBox("Введите код продажи");
            string inpCode = Microsoft.VisualBasic.Interaction.InputBox("Введите код машины");
            string inpClient = Microsoft.VisualBasic.Interaction.InputBox("Введите клиента");
            string inpDate = Microsoft.VisualBasic.Interaction.InputBox("Введите дату продажи");

            string commandString = $"INSERT INTO [Продажи] ([Код продажи], [Код машины], [Клиент], [Дата продажи]) VALUES ('{inpCodeSell}', '{inpCode}', '{inpClient}', '{inpDate}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t3_Click(object sender, EventArgs e)
        {
            string inpClient = Microsoft.VisualBasic.Interaction.InputBox("Введите клиента");
            string inpCodeSell = Microsoft.VisualBasic.Interaction.InputBox("Введите код продажи");

            string commandString = $"UPDATE [Продажи] SET [Код продажи] = '{inpCodeSell}' WHERE [Клиент] = '{inpClient}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t3_Click(object sender, EventArgs e)
        {
            string inpClient = Microsoft.VisualBasic.Interaction.InputBox("Введите клиента");

            string commandString = $"DELETE FROM [Продажи] WHERE [Клиент] = '{inpClient}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartValues<int> parabola = new ChartValues<int>();

            List<string> x_values = new List<string>();
            List<string> y_values = new List<string>();

            int[] x = new int[] { -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < x.Length; i++)
            {
                parabola.Add(x[i] * x[i]);
                x_values.Add(x[i].ToString());
                y_values.Add((x[i] * x[i]).ToString());
            }

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {
                Title = "Ось Х",
                Labels = x_values
            });

            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis()
            {
                Title = "Ось Y",
                Labels = y_values
            });

            LineSeries line = new LineSeries();
            line.Title = "Кривая";
            line.Values = parabola;

            SeriesCollection series = new SeriesCollection();
            series.Add(line);

            cartesianChart1.Series = series;
            cartesianChart1.LegendLocation = LegendLocation.Top;
        }
    }
}
