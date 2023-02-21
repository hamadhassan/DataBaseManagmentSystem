namespace CRUD_Application_Home_Task
{
    partial class frmRegistration
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUnRegister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblSignal = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmbxRegistrationNumber = new System.Windows.Forms.ComboBox();
            this.cmbxCourseName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 419);
            this.dataGridView1.TabIndex = 100;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(161, 201);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 30);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Registration Number";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(85, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Clear";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(10, 201);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(73, 30);
            this.btnLoad.TabIndex = 94;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUnRegister
            // 
            this.btnUnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnRegister.Location = new System.Drawing.Point(123, 167);
            this.btnUnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnRegister.Name = "btnUnRegister";
            this.btnUnRegister.Size = new System.Drawing.Size(111, 30);
            this.btnUnRegister.TabIndex = 97;
            this.btnUnRegister.Text = "unRegister";
            this.btnUnRegister.UseVisualStyleBackColor = true;
            this.btnUnRegister.Click += new System.EventHandler(this.btnUnRegister_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(10, 167);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 30);
            this.btnRegister.TabIndex = 99;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Location = new System.Drawing.Point(11, 142);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(13, 20);
            this.lblSignal.TabIndex = 102;
            this.lblSignal.Text = " ";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            // 
            // cmbxRegistrationNumber
            // 
            this.cmbxRegistrationNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRegistrationNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxRegistrationNumber.FormattingEnabled = true;
            this.cmbxRegistrationNumber.Location = new System.Drawing.Point(10, 53);
            this.cmbxRegistrationNumber.Name = "cmbxRegistrationNumber";
            this.cmbxRegistrationNumber.Size = new System.Drawing.Size(224, 28);
            this.cmbxRegistrationNumber.TabIndex = 103;
            this.cmbxRegistrationNumber.SelectedIndexChanged += new System.EventHandler(this.cmbxRegistrationNumber_SelectedIndexChanged);
            // 
            // cmbxCourseName
            // 
            this.cmbxCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCourseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxCourseName.FormattingEnabled = true;
            this.cmbxCourseName.Location = new System.Drawing.Point(10, 111);
            this.cmbxCourseName.Name = "cmbxCourseName";
            this.cmbxCourseName.Size = new System.Drawing.Size(224, 28);
            this.cmbxCourseName.TabIndex = 103;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 457);
            this.Controls.Add(this.cmbxCourseName);
            this.Controls.Add(this.cmbxRegistrationNumber);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUnRegister);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUnRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbxRegistrationNumber;
        private System.Windows.Forms.ComboBox cmbxCourseName;
    }
}