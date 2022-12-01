using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Foldrajz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connStr = "server=localhost;user=root;database=foldrajz;port=3306;password=";
        static MySqlConnection conn = new MySqlConnection(connStr);
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mi MADAGASZKÁR fővárosa?\n\n";
            try
            {
                string select = "SELECT `fovaros` FROM `orszagok` WHERE orszag LIKE 'MADAGASZKÁR';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik ország fővárosa OUAGADOUGOU?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok` WHERE `fovaros` LIKE 'OUAGADOUGOU';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik ország autójele a TT?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  WHERE `autojel` LIKE 'TT';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik ország pénzének jele az SGD?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  WHERE `penzjel` LIKE 'SGD';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik ország nemzetközi telefon-hívószáma a 61?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  WHERE `telefon` LIKE 61;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mekkora területű Monaco?\n\n";
            try
            {
                string select = "SELECT `terulet` FROM `orszagok`  WHERE `orszag` LIKE 'Monaco';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hányan laknak Máltán?\n\n";
            try
            {
                string select = "SELECT `nepesseg` FROM `orszagok`  WHERE `orszag` LIKE 'Málta';;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Japán népsűrűsége?\n\n";
            try
            {
                string select = "SELECT `nepesseg`/`terulet` FROM `orszagok`  WHERE `orszag` LIKE 'Japán';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány lakosa van a Földnek?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`) FROM `orszagok`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi az országok területe összesen?\n\n";
            try
            {
                string select = "SELECT SUM(`terulet`) FROM `orszagok`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi az országok átlagos népessége?\n\n";
            try
            {
                string select = "SELECT AVG(`nepesseg`) FROM `orszagok`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi az országok átlagos területe?\n\n";
            try
            {
                string select = "SELECT AVG(`terulet`) FROM `orszagok`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi a Föld népsűrűsége?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`/`terulet`) FROM `orszagok`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány 1.000.000 km2-nél nagyobb területű ország van?\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `terulet` > 1000000;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány 100 km2-nél kisebb területű ország van??\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `terulet` < 100;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány 20.000 főnél kevesebb lakosú ország van?\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `nepesseg` < 20000;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány országra igaz, hogy területe kisebb 100 km2-nél, vagy pedig a lakossága kevesebb 20.000 főnél??\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `nepesseg` < 20000 OR `terulet` < 100;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország területe 50.000 és 150.000 km2 közötti?\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `terulet` BETWEEN 50000 AND 150000s;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország lakossága 8 és 12 millió közötti?\n\n";
            try
            {
                string select = "SELECT COUNT(`orszag`) FROM `orszagok`  WHERE `nepesseg` BETWEEN 8 AND 12;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely fővárosok népesebbek 20 millió főnél?\n\n";
            try
            {
                string select = "SELECT `fovaros` FROM `orszagok`  WHERE `nepesseg` > 20;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely országok népsűrűsége nagyobb 500 fő/km2-nél?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` WHERE (`nepesseg`/`terulet`) > 500;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország államformája köztársaság?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` WHERE `allamforma` LIKE 'köztársaság';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely országok pénzneme a kelet-karib dollár?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok` WHERE `penznem` LIKE 'kelet-karib dollár';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország nevében van benne az \"ORSZÁG\" szó?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` WHERE `orszag` LIKE '%ORSZÁG%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely országokban korona a hivatalos fizetőeszköz?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok` WHERE `penznem` LIKE \"korona\";";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Európa területe?\n\n";
            try
            {
                string select = "SELECT SUM(`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Európa lakossága?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%';;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Európa népsűrűsége?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`/`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország van Afrikában?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Afrika lakossága?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi Afrika népsűrűsége?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`/`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyek a szigetországok?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok` WHERE `foldr_hely` LIKE '%szigetek%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button334_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely országok államformája hercegség, vagy királyság?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok` WHERE `allamforma` LIKE 'hercegség' OR 'királyság';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány országnak nincs autójelzése?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` WHERE `autojel` IS NULL;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mennyi a váltószáma az aprópénznek azokban az országokban, ahol nem 100?\n\n";
            try
            {
                string select = "SELECT `valtopenz` FROM `orszagok` WHERE `valtopenz` NOT LIKE '%100%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hány ország területe kisebb Magyarországénál?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok`  WHERE `terulet` < (SELECT `terulet` FROM `orszagok` WHERE `orszag` LIKE 'Magyarország')";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legnagyobb területű ország, és mennyi a területe?\n\n";
            try
            {
                string select = "SELECT `orszag`,`terulet` FROM `orszagok`  ORDER BY `terulet` DESC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legkisebb területű ország, és mennyi a területe?\n\n";
            try
            {
                string select = "SELECT `orszag`,`terulet` FROM `orszagok`  ORDER BY `terulet` ASC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legnépesebb ország, és hány lakosa van?\n\n";
            try
            {
                string select = "SELECT `orszag`,`nepesseg` FROM `orszagok`  ORDER BY `nepesseg` DESC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legkisebb népességű ország, és hány lakosa van?\n\n";
            try
            {
                string select = "SELECT `orszag`,`nepesseg` FROM `orszagok`  ORDER BY `nepesseg` ASC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legsűrűbben lakott ország, és mennyi a népsűrűsége?\n\n";
            try
            {
                string select = "SELECT `orszag`, `nepesseg`/`terulet` as nepsuruseg FROM `orszagok`  ORDER BY nepsuruseg DESC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legritkábban lakott ország, és mennyi a népsűrűsége?\n\n";
            try
            {
                string select = "SELECT `orszag`, `nepesseg`/`terulet` as nepsuruseg FROM `orszagok`  ORDER BY nepsuruseg ASC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legnagyobb afrikai ország és mekkora?\n\n";
            try
            {
                string select = "SELECT `orszag`,`terulet` FROM `orszagok`  WHERE `foldr_hely` LIKE '%Afrika%' ORDER BY `terulet` DESC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a legkisebb amerikai ország és hányan lakják?\n\n";
            try
            {
                string select = "SELECT `orszag`,`terulet` FROM `orszagok`  WHERE `foldr_hely` LIKE '%Amerika%' ORDER BY `terulet` ASC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik az első három legsűrűbben lakott \"országméretű\" ország (tehát nem város- vagy törpeállam)??\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  WHERE `allamforma` NOT LIKE '%város%'  AND `allamforma` NOT LIKE '%törpeállam%' ORDER BY `nepesseg`/`terulet` DESC LIMIT 3;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a világ hat legnépesebb fővárosa?\n\n";
            try
            {
                string select = "SELECT `fovaros` FROM `orszagok`  ORDER BY `nepesseg` DESC LIMIT 6;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik tíz ország egy főre jutó GDP-je a legnagyobb?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY `gdp`/`nepesseg` DESC LIMIT 10;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik tíz ország össz-GDP-je a legnagyobb?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY `gdp` DESC LIMIT 10;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik országban a legszegényebbek az emberek?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY `gdp`/`nepesseg` ASC LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a 40. legkisebb területű ország?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY (SELECT `orszag` FROM `orszagok` ORDER BY `terulet` ASC LIMIT 40)LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a 15. legkisebb népsűrűségű ország?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY (SELECT `orszag` FROM `orszagok` ORDER BY `terulet` ASC LIMIT 15)LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik a 61. legnagyobb népsűrűségű ország?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  ORDER BY (SELECT `orszag` FROM `orszagok` ORDER BY `terulet` DESC LIMIT 61)LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyik három ország területe hasonlít leginkább Magyaroszág méretéhez?\n\n";
            try
            {
                string select = "SELECT `orszag` FROM `orszagok`  WHERE `terulet` < (SELECT `terulet` FROM `orszagok` WHERE `orszag` LIKE 'Magyarország') LIMIT 3;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Az emberek hányadrésze él Ázsiában?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`) / (SELECT SUM(`nepesseg`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Ázsia%') FROM `orszagok` LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "A szárazföldek mekkora hányadát foglalja el Oroszország?\n\n";
            try
            {
                string select = "SELECT SUM(terulet) / (SELECT SUM(terulet)FROM orszagok WHERE orszag LIKE '%Oroszország%') FROM orszagok;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Az emberek hány százaléka fizet euroval?\n\n";
            try
            {
                string select = "SELECT SUM(`nepesseg`) / (SELECT SUM(`nepesseg`)FROM `orszagok` WHERE `penznem` LIKE '%Euro%') FROM orszagok;;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hányszorosa a leggazdagabb ország egy főre jutó GDP-je a legszegényebb ország egy főre jutó GDP-jének?\n\n";
            try
            {
                string select = "SELECT (SELECT gdp/nepesseg FROM orszagok ORDER BY gdp/nepesseg DESC LIMIT 1) / (SELECT gdp/nepesseg FROM orszagok ORDER BY gdp/nepesseg ASC LIMIT 1) FROM orszagok;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "A világ össz-GDP-jének hány százalékát adja az USA?\n\n";
            try
            {
                string select = "SELECT (SELECT SUM(`gdp`) FROM orszagok) / (SELECT SUM(`gdp`) FROM orszagok WHERE `orszag` LIKE '%Amerika%') FROM orszagok ORDER BY `id` LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "A világ össz-GDP-jének hány százalékát adja az euroövezet?\n\n";
            try
            {
                string select = "SELECT (SELECT SUM(`gdp`) FROM orszagok) / (SELECT SUM(`gdp`) FROM orszagok WHERE penznem LIKE '%euró%') FROM orszagok ORDER BY `id` LIMIT 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Melyek azok az átlagnál gazdagabb országok, amelyek nem az európai vagy az amerikai kontinensen találhatóak??\n\n";
            try
            {
                string select = "SELECT `orszag`, AVG(`gdp`/`nepesseg`) AS atlag FROM `orszagok` WHERE 'atlag' > `gdp`/`nepesseg` AND `foldr_hely` NOT LIKE '%Amerika%' OR `foldr_hely` NOT LIKE '%Európa%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Milyen államformák léteznek Európában?\n\n";
            try
            {
                string select = "SELECT `allamforma` FROM `orszagok`  WHERE `foldr_hely` LIKE '%Európa%' GROUP BY `allamforma`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hányféle államforma létezik a világon?\n\n";
            try
            {
                string select = "SELECT COUNT(`id`) FROM `orszagok` GROUP BY `allamforma`;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Hányféle fizetőeszközt használnak Európában az eurón kívül?\n\n";
            try
            {
                string select = "SELECT COUNT(id) FROM `orszagok`  WHERE `foldr_hely` LIKE '%Európa%' AND `penznem` NOT LIKE '%Euró%';";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely pénznemeket használják több országban is?\n\n";
            try
            {
                string select = "SELECT penznem FROM orszagok GROUP BY penznem HAVING COUNT(penznem) > 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Mely országok államformája egyedi?\n\n";
            try
            {
                string select = "SELECT orszag FROM orszagok GROUP BY allamforma HAVING COUNT(allamforma) = 1;";
                MySqlCommand ki = new MySqlCommand(select, conn);
                MySqlDataReader vissza = ki.ExecuteReader();

                while (vissza.Read())
                {
                    richTextBox1.Text += Convert.ToString(vissza[0] + "\n");
                }
                vissza.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }
    }
}
