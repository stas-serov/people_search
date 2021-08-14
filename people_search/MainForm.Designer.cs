
namespace people_search
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_patronomic = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_patronomic = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_information = new System.Windows.Forms.Button();
            this.richTextBox_full_information = new System.Windows.Forms.RichTextBox();
            this.panel_input = new System.Windows.Forms.Panel();
            this.label_language = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.panel_output = new System.Windows.Forms.Panel();
            this.button_next_person = new System.Windows.Forms.Button();
            this.button_prev_person = new System.Windows.Forms.Button();
            this.label_photo = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label_person = new System.Windows.Forms.Label();
            this.panel_input.SuspendLayout();
            this.panel_output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(13, 47);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.Location = new System.Drawing.Point(12, 12);
            this.label_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(68, 18);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Surname";
            // 
            // label_patronomic
            // 
            this.label_patronomic.AutoSize = true;
            this.label_patronomic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_patronomic.Location = new System.Drawing.Point(13, 81);
            this.label_patronomic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_patronomic.Name = "label_patronomic";
            this.label_patronomic.Size = new System.Drawing.Size(85, 18);
            this.label_patronomic.TabIndex = 2;
            this.label_patronomic.Text = "Patronomic";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(99, 44);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(117, 24);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TabStop = false;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.Location = new System.Drawing.Point(99, 9);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(117, 24);
            this.textBox_surname.TabIndex = 4;
            this.textBox_surname.TabStop = false;
            this.textBox_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_surname_KeyPress);
            // 
            // textBox_patronomic
            // 
            this.textBox_patronomic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_patronomic.Location = new System.Drawing.Point(99, 78);
            this.textBox_patronomic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_patronomic.Name = "textBox_patronomic";
            this.textBox_patronomic.Size = new System.Drawing.Size(117, 24);
            this.textBox_patronomic.TabIndex = 5;
            this.textBox_patronomic.TabStop = false;
            this.textBox_patronomic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_patronomic_KeyPress);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(227, 12);
            this.button_update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(116, 32);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update DB";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Brown;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(228, 61);
            this.button_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(116, 32);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_information
            // 
            this.button_information.BackColor = System.Drawing.Color.Orchid;
            this.button_information.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_information.Location = new System.Drawing.Point(227, 108);
            this.button_information.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_information.Name = "button_information";
            this.button_information.Size = new System.Drawing.Size(116, 32);
            this.button_information.TabIndex = 8;
            this.button_information.Text = "Information ";
            this.button_information.UseVisualStyleBackColor = false;
            this.button_information.Click += new System.EventHandler(this.button_info_Click);
            // 
            // richTextBox_full_information
            // 
            this.richTextBox_full_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_full_information.Location = new System.Drawing.Point(17, 28);
            this.richTextBox_full_information.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_full_information.Name = "richTextBox_full_information";
            this.richTextBox_full_information.Size = new System.Drawing.Size(180, 247);
            this.richTextBox_full_information.TabIndex = 9;
            this.richTextBox_full_information.Text = "";
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.Silver;
            this.panel_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_input.Controls.Add(this.label_language);
            this.panel_input.Controls.Add(this.comboBox_language);
            this.panel_input.Controls.Add(this.textBox_name);
            this.panel_input.Controls.Add(this.label_name);
            this.panel_input.Controls.Add(this.textBox_surname);
            this.panel_input.Controls.Add(this.button_information);
            this.panel_input.Controls.Add(this.label_surname);
            this.panel_input.Controls.Add(this.button_search);
            this.panel_input.Controls.Add(this.label_patronomic);
            this.panel_input.Controls.Add(this.button_update);
            this.panel_input.Controls.Add(this.textBox_patronomic);
            this.panel_input.Location = new System.Drawing.Point(12, 12);
            this.panel_input.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(372, 163);
            this.panel_input.TabIndex = 10;
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_language.Location = new System.Drawing.Point(12, 117);
            this.label_language.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(72, 18);
            this.label_language.TabIndex = 15;
            this.label_language.Text = "Language";
            // 
            // comboBox_language
            // 
            this.comboBox_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            "Русский",
            "Українська",
            "English"});
            this.comboBox_language.Location = new System.Drawing.Point(99, 114);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(117, 26);
            this.comboBox_language.TabIndex = 14;
            // 
            // panel_output
            // 
            this.panel_output.BackColor = System.Drawing.Color.Silver;
            this.panel_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_output.Controls.Add(this.button_next_person);
            this.panel_output.Controls.Add(this.button_prev_person);
            this.panel_output.Controls.Add(this.label_photo);
            this.panel_output.Controls.Add(this.pictureBox_photo);
            this.panel_output.Controls.Add(this.label_person);
            this.panel_output.Controls.Add(this.richTextBox_full_information);
            this.panel_output.Location = new System.Drawing.Point(12, 181);
            this.panel_output.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_output.Name = "panel_output";
            this.panel_output.Size = new System.Drawing.Size(372, 288);
            this.panel_output.TabIndex = 11;
            // 
            // button_next_person
            // 
            this.button_next_person.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_next_person.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next_person.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_next_person.Location = new System.Drawing.Point(284, 243);
            this.button_next_person.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_next_person.Name = "button_next_person";
            this.button_next_person.Size = new System.Drawing.Size(60, 32);
            this.button_next_person.TabIndex = 15;
            this.button_next_person.Text = "Next";
            this.button_next_person.UseVisualStyleBackColor = false;
            this.button_next_person.Visible = false;
            this.button_next_person.Click += new System.EventHandler(this.button_next_person_Click);
            // 
            // button_prev_person
            // 
            this.button_prev_person.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_prev_person.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_prev_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev_person.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_prev_person.Location = new System.Drawing.Point(212, 243);
            this.button_prev_person.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_prev_person.Name = "button_prev_person";
            this.button_prev_person.Size = new System.Drawing.Size(60, 32);
            this.button_prev_person.TabIndex = 14;
            this.button_prev_person.Text = "Prev";
            this.button_prev_person.UseVisualStyleBackColor = false;
            this.button_prev_person.Visible = false;
            this.button_prev_person.Click += new System.EventHandler(this.button_prev_person_Click);
            // 
            // label_photo
            // 
            this.label_photo.AutoSize = true;
            this.label_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_photo.Location = new System.Drawing.Point(257, 23);
            this.label_photo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(48, 18);
            this.label_photo.TabIndex = 13;
            this.label_photo.Text = "Photo";
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_photo.Location = new System.Drawing.Point(212, 49);
            this.pictureBox_photo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(132, 182);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 13;
            this.pictureBox_photo.TabStop = false;
            // 
            // label_person
            // 
            this.label_person.AutoSize = true;
            this.label_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_person.Location = new System.Drawing.Point(80, 2);
            this.label_person.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_person.Name = "label_person";
            this.label_person.Size = new System.Drawing.Size(56, 18);
            this.label_person.TabIndex = 12;
            this.label_person.Text = "Person";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 480);
            this.Controls.Add(this.panel_output);
            this.Controls.Add(this.panel_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People search";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel_output.ResumeLayout(false);
            this.panel_output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_patronomic;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_patronomic;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_information;
        private System.Windows.Forms.RichTextBox richTextBox_full_information;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Panel panel_output;
        private System.Windows.Forms.Label label_photo;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_person;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Button button_next_person;
        private System.Windows.Forms.Button button_prev_person;
    }
}

