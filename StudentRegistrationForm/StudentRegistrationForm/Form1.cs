using System;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentRegistrationForm
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblGender = new Label();
            lblColor = new Label();
            lblBirthdate = new Label();
            lblCountry = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            rdoOther = new RadioButton();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            grpGender = new GroupBox();
            btnPickColor = new Button();
            lblSelectedColor = new Label();
            dtpBirthdate = new DateTimePicker();
            cmbCountry = new ComboBox();
            btnSubmit = new Button();
            lblResult = new Label();
            btnReset = new Button();
            picStudent = new PictureBox();
            btnUpload = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(30, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(30, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(30, 150);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 21);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(30, 190);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(104, 21);
            lblColor.TabIndex = 4;
            lblColor.Text = "Favorite color";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(30, 230);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(73, 21);
            lblBirthdate.TabIndex = 5;
            lblBirthdate.Text = "Birthdate";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(30, 270);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(111, 21);
            lblCountry.TabIndex = 6;
            lblCountry.Text = "Select Country";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 11;
            // 
            // rdoOther
            // 
            rdoOther.AutoSize = true;
            rdoOther.Location = new Point(141, 22);
            rdoOther.Name = "rdoOther";
            rdoOther.Size = new Size(55, 19);
            rdoOther.TabIndex = 14;
            rdoOther.TabStop = true;
            rdoOther.Text = "Other";
            rdoOther.UseVisualStyleBackColor = true;
            rdoOther.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(6, 22);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 15;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(78, 22);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(57, 19);
            rdoFemale.TabIndex = 16;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Famel";
            rdoFemale.UseVisualStyleBackColor = true;
            rdoFemale.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoOther);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(150, 139);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(200, 50);
            grpGender.TabIndex = 17;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(150, 190);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(75, 23);
            btnPickColor.TabIndex = 18;
            btnPickColor.Text = "Choose Color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click_1;
            // 
            // lblSelectedColor
            // 
            lblSelectedColor.AutoSize = true;
            lblSelectedColor.Location = new Point(300, 190);
            lblSelectedColor.Name = "lblSelectedColor";
            lblSelectedColor.Size = new Size(102, 15);
            lblSelectedColor.TabIndex = 19;
            lblSelectedColor.Text = "No Color Selected";
            lblSelectedColor.Click += lblSelectedColor_Click;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(150, 230);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 20;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Yemen", "Egypt", "Oman", "Qatar", "Palestine", "Syria" });
            cmbCountry.Location = new Point(150, 270);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(121, 23);
            cmbCountry.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(150, 320);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Register";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(30, 400);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(41, 15);
            lblResult.TabIndex = 24;
            lblResult.Text = "empty";
            lblResult.Click += lblResult_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(260, 320);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(400, 30);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(120, 120);
            picStudent.TabIndex = 26;
            picStudent.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(400, 160);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 30);
            btnUpload.TabIndex = 27;
            btnUpload.Text = "Upload Picture";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(380, 360);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 29;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(584, 461);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnUpload);
            Controls.Add(picStudent);
            Controls.Add(btnReset);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(cmbCountry);
            Controls.Add(dtpBirthdate);
            Controls.Add(lblSelectedColor);
            Controls.Add(btnPickColor);
            Controls.Add(grpGender);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(lblCountry);
            Controls.Add(lblBirthdate);
            Controls.Add(lblColor);
            Controls.Add(lblGender);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "frmRegistration";
            Text = "Student Registration Form";
            Load += frmRegistration_Load;
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblGender;
        private Label lblColor;
        private Label lblBirthdate;
        private Label lblCountry;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox textBox3;
        private RadioButton rdoOther;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private GroupBox grpGender;
        private Button btnPickColor;
        private Label lblSelectedColor;
        private DateTimePicker dtpBirthdate;
        private ComboBox cmbCountry;
        private Button btnSubmit;
        private Label lblResult;







        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم النقر على اللابل!");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectedColor_Click(object sender, EventArgs e)
        {
        }





        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Validate Name 
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Validate Email (Basic Email Format Check) 
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Validate Password (Min 6 characters) 
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Validate Gender Selection 
            if (!rdoMale.Checked && !rdoFemale.Checked && !rdoOther.Checked)
            {
                MessageBox.Show("Please select a gender!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Country Selection 
            if (cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCountry.Focus();
                return;
            }

            // Validate Favorite Color Selection 
            if (lblSelectedColor.Text == "No Color Selected")
            {
                MessageBox.Show("Please select your favorite color!", "Validation  Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // All validations passed → Proceed with displaying data 
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Other";
            string birthdate = dtpBirthdate.Value.ToShortDateString();
            string country = cmbCountry.SelectedItem.ToString();
            string color = lblSelectedColor.Text.Replace("Selected Color: ", ""); // 

            // Displaying result 
            lblResult.Text = $"Name: {name}\nEmail: {email}\nGender: {gender}\n" +
            $"Birthdate: {birthdate}\nCountry: {country}\nFavorite Color: {color}";
        }


        private void btnPickColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblSelectedColor.Text = $"Selected Color: {colorDialog.Color.Name}";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear text fields 
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            // Uncheck radio buttons 
            rdoMale.Checked = false;

            rdoFemale.Checked = false;
            rdoOther.Checked = false;

            // Reset dropdown list selection 
            cmbCountry.SelectedIndex = -1;

            // Reset Date Picker to current date 
            dtpBirthdate.Value = DateTime.Now;

            // Reset favorite color label 
            lblSelectedColor.Text = "No Color Selected";

            // Clear result label 
            lblResult.Text = "";

            // Set focus back to the first input field 
            txtName.Focus();
            // Clear student picture 
            picStudent.Image = null;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set file filters (allow only image files) 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display selected image in PictureBox 
                picStudent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate fields before saving 
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in at least Name and Email before saving!", "Validation Error", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                return;
            }

            // Prepare data in a structured text format 
            string data = $"{txtName.Text}\n" +          // Name 
                          $"{txtEmail.Text}\n" +         // Email 
                          $"{txtPassword.Text}\n" +      // Password 
                          $"{(rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female"
        : "Other")}\n" + // Gender 
                          $"{dtpBirthdate.Value.ToShortDateString()}\n" + // Birthdate 
                          $"{cmbCountry.SelectedItem?.ToString()}\n" + // Country 
                          $"{lblSelectedColor.Text.Replace("Selected Color: ", "")}\n" + // Favorite Color
                  $"{(picStudent.Image != null ? "student_picture.jpg" : "NoImage")}\n"; // Image Path 

            // Save to text file 
            File.WriteAllText("student_data.txt", data);

            // Save the image if available
            if (picStudent.Image != null)
            {
                picStudent.Image.Save("student_picture.jpg"); // Save image locally 
            }

            MessageBox.Show("Data saved successfully!", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Check if file exists 
            if (!File.Exists("student_data.txt"))
            {
                MessageBox.Show("No saved data found!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read all lines from the text file 
            string[] lines = File.ReadAllLines("student_data.txt");

            // Ensure file has the expected number of lines 
            if (lines.Length < 8)
            {
                MessageBox.Show("Saved data is incomplete or corrupted!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Populate form fields 
            txtName.Text = lines[0];
            txtEmail.Text = lines[1];
            txtPassword.Text = lines[2];

            if (lines[3] == "Male") rdoMale.Checked = true;
            else if (lines[3] == "Female") rdoFemale.Checked = true;
            else rdoOther.Checked = true;

            dtpBirthdate.Value = DateTime.Parse(lines[4]);
            cmbCountry.SelectedItem = lines[5];
            lblSelectedColor.Text = "Selected Color: " + lines[6];

            // Load image if available 
            if (File.Exists("student_picture.jpg") && lines[7] == "student_picture.jpg")
            {
                picStudent.Image = Image.FromFile("student_picture.jpg");
            }
            else
            {
                picStudent.Image = null;
            }

            MessageBox.Show("Data loaded successfully!", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



