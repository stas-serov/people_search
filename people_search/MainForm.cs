using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace people_search
{
    public partial class MainForm : Form
    {
        List<Person> person { get; set; }
        public int index_displayed_person { get; set; }
        public string path_person { get; set; }
        public string path_photo1 { get; set; }
        public string path_photo2 { get; set; }
        public string link_person { get; set; }
        public string link_photo1 { get; set; }
        public string link_photo2 { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var info = new FileInfo("..\\..\\..\\people_search\\config.txt");
            if(!info.Exists)
            {
                MessageBox.Show("Settings file are not exists! Shutdown!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if(info.Length == 0 )
            {
                MessageBox.Show("Settings file are empty! Shutdown!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            string [] s = File.ReadAllLines("..\\..\\..\\people_search\\config.txt");
            if(s.Length < 6)
            {
                MessageBox.Show("the settings file is not complete! Please, check that and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            path_person = s[0];
            path_photo1 = s[1];
            path_photo2 = s[2];
            link_person = s[3];
            link_photo1 = s[4];
            link_photo2 = s[5];
            if(!File.Exists(path_person) || !File.Exists(path_photo1) || !File.Exists(path_photo2))
            {
                MessageBox.Show("System can't find database! You can download that!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_name.Enabled = false;
                textBox_surname.Enabled = false;
                textBox_patronomic.Enabled = false;
            }
            comboBox_language.SelectedIndex = 0;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            if((textBox_name.Text == "") || (textBox_surname.Text == "") || (textBox_patronomic.Text == ""))
            {
                MessageBox.Show("Incorrect person's data! Please, check and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(comboBox_language.SelectedIndex == 0)
            {
                person = Operations.searching_rus(textBox_surname.Text.ToUpper(), textBox_name.Text.ToUpper(), textBox_patronomic.Text.ToUpper(), path_person);
                if(person.Count == 0)
                {
                    MessageBox.Show("The system could not find such a person. Check input data and thy again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txt", false);
                    return;
                }
                richTextBox_full_information.Text = "Имя (укр): " + person[0].first_name_u + "\n" + "Фамилия (укр): " + person[0].last_name_u + "\n" + "Отчество (укр): " + person[0].middle_name_u + "\n" +
                    "Имя (рус): " + person[0].first_name_r + "\n" + "Фамилия (рус): " + person[0].last_name_r + "\n" + "Отчество (рус): " + person[0].middle_name_r + "\n" +
                    "Имя (англ): " + person[0].first_name_e + "\n" + "Фамилия (англ): " + person[0].last_name_e + "\n" + "Отчество (англ): " + person[0].middle_name_e + "\n" +
                    "Дата исчезновения: " + person[0].lost_date.ToString() + "\n" + "Место исчезновения: " + person[0].lost_place + "\n" + "Дата рождения: " + person[0].birth_date.ToString() + "\n" + 
                    "Пол: " + person[0].sex + "\n" + "Контактная информация: " + person[0].contact;
                pictureBox_photo.Image = Operations.person_photo(person[0].photoid, path_photo1, path_photo2);
                Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txt", true);
                if(person.Count > 1)
                {
                    button_prev_person.Visible = true;
                    button_next_person.Visible = true;
                    index_displayed_person = 0;
                }
            }
            if(comboBox_language.SelectedIndex == 1)
            {
                person = Operations.searching_ukr(textBox_surname.Text.ToUpper(), textBox_name.Text.ToUpper(), textBox_patronomic.Text.ToUpper(), path_person);
                if (person.Count == 0)
                {
                    MessageBox.Show("The system could not find such a person. Check input data and thy again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txt", false);
                    return;
                }
                richTextBox_full_information.Text = "Имя (укр): " + person[0].first_name_u + "\n" + "Фамилия (укр): " + person[0].last_name_u + "\n" + "Отчество (укр): " + person[0].middle_name_u + "\n" +
                    "Имя (рус): " + person[0].first_name_r + "\n" + "Фамилия (рус): " + person[0].last_name_r + "\n" + "Отчество (рус): " + person[0].middle_name_r + "\n" +
                    "Имя (англ): " + person[0].first_name_e + "\n" + "Фамилия (англ): " + person[0].last_name_e + "\n" + "Отчество (англ): " + person[0].middle_name_e + "\n" +
                    "Дата исчезновения: " + person[0].lost_date.ToString() + "\n" + "Место исчезновения: " + person[0].lost_place + "\n" + "Дата рождения: " + person[0].birth_date.ToString() + "\n" +
                    "Пол: " + person[0].sex + "\n" + "Контактная информация: " + person[0].contact;
                pictureBox_photo.Image = Operations.person_photo(person[0].photoid, path_photo1, path_photo2);
                Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txt", true);
                if (person.Count > 1)
                {
                    button_prev_person.Visible = true;
                    button_next_person.Visible = true;
                    index_displayed_person = 0;
                }
            }
            if(comboBox_language.SelectedIndex == 2)
            {
                person = Operations.searching_eng(textBox_surname.Text.ToUpper(), textBox_name.Text.ToUpper(), textBox_patronomic.Text.ToUpper(), path_person);
                if (person.Count == 0)
                {
                    MessageBox.Show("The system could not find such a person. Check input data and thy again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txtt", false);
                    return;
                }
                richTextBox_full_information.Text = "Имя (укр): " + person[0].first_name_u + "\n" + "Фамилия (укр): " + person[0].last_name_u + "\n" + "Отчество (укр): " + person[0].middle_name_u + "\n" +
                    "Имя (рус): " + person[0].first_name_r + "\n" + "Фамилия (рус): " + person[0].last_name_r + "\n" + "Отчество (рус): " + person[0].middle_name_r + "\n" +
                    "Имя (англ): " + person[0].first_name_e + "\n" + "Фамилия (англ): " + person[0].last_name_e + "\n" + "Отчество (англ): " + person[0].middle_name_e + "\n" +
                    "Дата исчезновения: " + person[0].lost_date.ToString() + "\n" + "Место исчезновения: " + person[0].lost_place + "\n" + "Дата рождения: " + person[0].birth_date.ToString() + "\n" +
                    "Пол: " + person[0].sex + "\n" + "Контактная информация: " + person[0].contact;
                pictureBox_photo.Image = Operations.person_photo(person[0].photoid, path_photo1, path_photo2);
                Operations.write_results(textBox_surname.Text, textBox_name.Text, textBox_patronomic.Text, "..\\..\\..\\people_search\\config.txt true", true);
                if (person.Count > 1)
                {
                    button_prev_person.Visible = true;
                    button_next_person.Visible = true;
                    index_displayed_person = 0;
                }
            }
        }
        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == ',') || (e.KeyChar == '-')) & (e.KeyChar != '.')) e.KeyChar = (char)Keys.None;
        }

        private void textBox_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == ',') || (e.KeyChar == '-')) & (e.KeyChar != '.')) e.KeyChar = (char)Keys.None;
        }

        private void textBox_patronomic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) || (e.KeyChar == ',') || (e.KeyChar == '-')) & (e.KeyChar != '.')) e.KeyChar = (char)Keys.None;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Operations.update_db(link_person, path_person, link_photo1, path_photo1, link_photo2, path_photo2);
            textBox_name.Enabled = true;
            textBox_surname.Enabled = true;
            textBox_patronomic.Enabled = true;
            MessageBox.Show("Database was succesfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_prev_person_Click(object sender, EventArgs e)
        {
            if(index_displayed_person > 0)
            {
                index_displayed_person--;
                richTextBox_full_information.Text = "Имя (укр):" + person[index_displayed_person].first_name_u + "\n" + "Фамилия (укр):" + person[index_displayed_person].last_name_u + "\n" + "Отчество (укр):" + person[index_displayed_person].middle_name_u + "\n" +
                    "Имя (рус):" + person[index_displayed_person].first_name_r + "\n" + "Фамилия (рус):" + person[index_displayed_person].last_name_r + "\n" + "Отчество (рус):" + person[index_displayed_person].middle_name_r + "\n" +
                    "Имя (англ):" + person[index_displayed_person].first_name_e + "\n" + "Фамилия (англ):" + person[index_displayed_person].last_name_e + "\n" + "Отчество (англ):" + person[index_displayed_person].middle_name_e + "\n" +
                    "Дата исчезновения:" + person[index_displayed_person].lost_date.ToString() + "\n" + "Место исчезновения:" + person[index_displayed_person].lost_place + "\n" + "Дата рождения:" + person[index_displayed_person].birth_date.ToString() + "\n" +
                    "Пол:" + person[index_displayed_person].sex + "\n" + "Контактная информация:" + person[index_displayed_person].contact;
                pictureBox_photo.Image = Operations.person_photo(person[index_displayed_person].photoid, path_photo1, path_photo2);
            }
        }

        private void button_next_person_Click(object sender, EventArgs e)
        {
            if ((index_displayed_person + 1) < person.Count)
            {
                index_displayed_person++;
                richTextBox_full_information.Text = "Имя (укр):" + person[index_displayed_person].first_name_u + "\n" + "Фамилия (укр):" + person[index_displayed_person].last_name_u + "\n" + "Отчество (укр):" + person[index_displayed_person].middle_name_u + "\n" +
                    "Имя (рус):" + person[index_displayed_person].first_name_r + "\n" + "Фамилия (рус):" + person[index_displayed_person].last_name_r + "\n" + "Отчество (рус):" + person[index_displayed_person].middle_name_r + "\n" +
                    "Имя (англ):" + person[index_displayed_person].first_name_e + "\n" + "Фамилия (англ):" + person[index_displayed_person].last_name_e + "\n" + "Отчество (англ):" + person[index_displayed_person].middle_name_e + "\n" +
                    "Дата исчезновения:" + person[index_displayed_person].lost_date.ToString() + "\n" + "Место исчезновения:" + person[index_displayed_person].lost_place + "\n" + "Дата рождения:" + person[index_displayed_person].birth_date.ToString() + "\n" +
                    "Пол:" + person[index_displayed_person].sex + "\n" + "Контактная информация:" + person[index_displayed_person].contact;
                pictureBox_photo.Image = Operations.person_photo(person[index_displayed_person].photoid, path_photo1, path_photo2);
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            InformationForm IF = new InformationForm();
            IF.ShowDialog();
        }
    }
}
