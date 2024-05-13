namespace FormsTestACS
{
    partial class FormularioAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_UserEdit = new System.Windows.Forms.TextBox();
            this.txt_PasswordEdit = new System.Windows.Forms.TextBox();
            this.lbl_UserEdit = new System.Windows.Forms.Label();
            this.lbl_PasswordEdit = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_ReadDni = new System.Windows.Forms.TextBox();
            this.lbl_ReadDni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txt_UserEdit
            // 
            this.txt_UserEdit.Location = new System.Drawing.Point(792, 105);
            this.txt_UserEdit.Name = "txt_UserEdit";
            this.txt_UserEdit.Size = new System.Drawing.Size(138, 22);
            this.txt_UserEdit.TabIndex = 1;
            // 
            // txt_PasswordEdit
            // 
            this.txt_PasswordEdit.Location = new System.Drawing.Point(966, 105);
            this.txt_PasswordEdit.Name = "txt_PasswordEdit";
            this.txt_PasswordEdit.Size = new System.Drawing.Size(138, 22);
            this.txt_PasswordEdit.TabIndex = 2;
            // 
            // lbl_UserEdit
            // 
            this.lbl_UserEdit.AutoSize = true;
            this.lbl_UserEdit.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_UserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEdit.Location = new System.Drawing.Point(835, 67);
            this.lbl_UserEdit.Name = "lbl_UserEdit";
            this.lbl_UserEdit.Size = new System.Drawing.Size(50, 20);
            this.lbl_UserEdit.TabIndex = 3;
            this.lbl_UserEdit.Text = "User:";
            // 
            // lbl_PasswordEdit
            // 
            this.lbl_PasswordEdit.AutoSize = true;
            this.lbl_PasswordEdit.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_PasswordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordEdit.Location = new System.Drawing.Point(996, 67);
            this.lbl_PasswordEdit.Name = "lbl_PasswordEdit";
            this.lbl_PasswordEdit.Size = new System.Drawing.Size(88, 20);
            this.lbl_PasswordEdit.TabIndex = 4;
            this.lbl_PasswordEdit.Text = "Password:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(867, 157);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(154, 58);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_ReadDni
            // 
            this.txt_ReadDni.Location = new System.Drawing.Point(883, 42);
            this.txt_ReadDni.Name = "txt_ReadDni";
            this.txt_ReadDni.ReadOnly = true;
            this.txt_ReadDni.Size = new System.Drawing.Size(138, 22);
            this.txt_ReadDni.TabIndex = 6;
            // 
            // lbl_ReadDni
            // 
            this.lbl_ReadDni.AutoSize = true;
            this.lbl_ReadDni.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_ReadDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadDni.Location = new System.Drawing.Point(919, 19);
            this.lbl_ReadDni.Name = "lbl_ReadDni";
            this.lbl_ReadDni.Size = new System.Drawing.Size(43, 20);
            this.lbl_ReadDni.TabIndex = 7;
            this.lbl_ReadDni.Text = "DNI:";
            // 
            // FormularioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.lbl_ReadDni);
            this.Controls.Add(this.txt_ReadDni);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lbl_PasswordEdit);
            this.Controls.Add(this.lbl_UserEdit);
            this.Controls.Add(this.txt_PasswordEdit);
            this.Controls.Add(this.txt_UserEdit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormularioAdmin";
            this.Text = "FormularioAdmin";
            this.Load += new System.EventHandler(this.FormularioAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_UserEdit;
        private System.Windows.Forms.TextBox txt_PasswordEdit;
        private System.Windows.Forms.Label lbl_UserEdit;
        private System.Windows.Forms.Label lbl_PasswordEdit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txt_ReadDni;
        private System.Windows.Forms.Label lbl_ReadDni;
    }
}