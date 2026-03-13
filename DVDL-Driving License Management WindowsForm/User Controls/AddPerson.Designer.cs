namespace DVDL_Driving_License_Management_WindowsForm.User_Controls
{
    partial class cntAddPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbSecondName = new System.Windows.Forms.TextBox();
            this.txbThirdName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.dtbDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.txbNationalNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.llblRemove = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(170, 40);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(148, 24);
            this.txbFirstName.TabIndex = 1;
            this.txbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.NotNull_Validating);
            // 
            // txbSecondName
            // 
            this.txbSecondName.Location = new System.Drawing.Point(372, 40);
            this.txbSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txbSecondName.Name = "txbSecondName";
            this.txbSecondName.Size = new System.Drawing.Size(148, 24);
            this.txbSecondName.TabIndex = 2;
            this.txbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.NotNull_Validating);
            // 
            // txbThirdName
            // 
            this.txbThirdName.Location = new System.Drawing.Point(556, 40);
            this.txbThirdName.Margin = new System.Windows.Forms.Padding(4);
            this.txbThirdName.Name = "txbThirdName";
            this.txbThirdName.Size = new System.Drawing.Size(148, 24);
            this.txbThirdName.TabIndex = 3;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(736, 40);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(148, 24);
            this.txbLastName.TabIndex = 4;
            this.txbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.NotNull_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(216, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "First";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(415, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(596, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Third";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(780, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(555, 131);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(148, 24);
            this.txbPhone.TabIndex = 9;
            this.txbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txbPhone_Validating);
            // 
            // dtbDateOfBirth
            // 
            this.dtbDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbDateOfBirth.Location = new System.Drawing.Point(555, 85);
            this.dtbDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtbDateOfBirth.Name = "dtbDateOfBirth";
            this.dtbDateOfBirth.Size = new System.Drawing.Size(148, 24);
            this.dtbDateOfBirth.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(366, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Of Birth :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(422, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(408, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Country :";
            // 
            // cmbCountries
            // 
            this.cmbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountries.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(555, 175);
            this.cmbCountries.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(148, 32);
            this.cmbCountries.TabIndex = 15;
            // 
            // txbNationalNo
            // 
            this.txbNationalNo.Location = new System.Drawing.Point(169, 85);
            this.txbNationalNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbNationalNo.Name = "txbNationalNo";
            this.txbNationalNo.Size = new System.Drawing.Size(148, 24);
            this.txbNationalNo.TabIndex = 16;
            this.txbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(4, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "National No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(2, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gender :";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbMale.Location = new System.Drawing.Point(168, 131);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 25);
            this.rbMale.TabIndex = 19;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "0";
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbFemale.Location = new System.Drawing.Point(249, 131);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 25);
            this.rbFemale.TabIndex = 20;
            this.rbFemale.Tag = "1";
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(169, 184);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(148, 24);
            this.txbEmail.TabIndex = 21;
            this.txbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txbEmail_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(8, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(6, 228);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Address :";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(169, 232);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(534, 79);
            this.txbAddress.TabIndex = 24;
            this.txbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.NotNull_Validating);
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Font = new System.Drawing.Font("Tahoma", 10F);
            this.llblSetImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.llblSetImage.Location = new System.Drawing.Point(780, 270);
            this.llblSetImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(86, 21);
            this.llblSetImage.TabIndex = 26;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // llblRemove
            // 
            this.llblRemove.AutoSize = true;
            this.llblRemove.Font = new System.Drawing.Font("Tahoma", 10F);
            this.llblRemove.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.llblRemove.Location = new System.Drawing.Point(766, 302);
            this.llblRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblRemove.Name = "llblRemove";
            this.llblRemove.Size = new System.Drawing.Size(122, 21);
            this.llblRemove.TabIndex = 27;
            this.llblRemove.TabStop = true;
            this.llblRemove.Text = "Remove Image";
            this.llblRemove.Visible = false;
            this.llblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemove_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(430, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 46);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(582, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 46);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.address;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(124, 232);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(38, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 36;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.email;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(124, 175);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 35;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.Country;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(513, 172);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.phone_call;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(513, 128);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.calendar;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(513, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.gender;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(124, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.id_card__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(124, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.id_card;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(124, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.questionPerson;
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(736, 85);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(170, 181);
            this.pbPersonImage.TabIndex = 25;
            this.pbPersonImage.TabStop = false;
            // 
            // cntAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.llblRemove);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNationalNo);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtbDateOfBirth);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbThirdName);
            this.Controls.Add(this.txbSecondName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cntAddPerson";
            this.Size = new System.Drawing.Size(949, 385);
            this.Load += new System.EventHandler(this.cntAddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbSecondName;
        private System.Windows.Forms.TextBox txbThirdName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.DateTimePicker dtbDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.TextBox txbNationalNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llblSetImage;
        private System.Windows.Forms.LinkLabel llblRemove;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
