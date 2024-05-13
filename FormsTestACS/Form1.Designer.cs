namespace FormsTestACS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_Registration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(303, 166);
            this.txt_Name.MaxLength = 16;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(184, 22);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(303, 194);
            this.txt_Age.MaxLength = 3;
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(184, 22);
            this.txt_Age.TabIndex = 1;
            this.txt_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Age_KeyPress);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(303, 222);
            this.txt_User.MaxLength = 16;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(184, 22);
            this.txt_User.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(303, 250);
            this.txt_Password.MaxLength = 16;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(184, 22);
            this.txt_Password.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(202, 166);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 16);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_age.Location = new System.Drawing.Point(202, 197);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(35, 16);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "Age:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_user.Location = new System.Drawing.Point(202, 225);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(39, 16);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "User:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_password.Location = new System.Drawing.Point(202, 253);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 16);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 452);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(303, 332);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(184, 46);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Dni.Location = new System.Drawing.Point(207, 281);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(30, 16);
            this.lbl_Dni.TabIndex = 11;
            this.lbl_Dni.Text = "Dni:";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(303, 281);
            this.txt_Dni.MaxLength = 8;
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(184, 22);
            this.txt_Dni.TabIndex = 12;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Registration.Font = new System.Drawing.Font("MS Reference Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration.Location = new System.Drawing.Point(197, 32);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(385, 73);
            this.lbl_Registration.TabIndex = 13;
            this.lbl_Registration.Text = "Registration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Registration);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Label lbl_Registration;
    }
}

