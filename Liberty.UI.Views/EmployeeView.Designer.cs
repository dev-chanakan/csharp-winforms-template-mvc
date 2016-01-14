namespace Liberty.UI.Views
{
    partial class EmployeeView
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdFamele = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.listEmployee = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.grbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grbSex);
            this.grpDetails.Controls.Add(this.txtDepartment);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(12, 13);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Size = new System.Drawing.Size(698, 165);
            this.grpDetails.TabIndex = 35;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Register new sales:";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdFamele);
            this.grbSex.Controls.Add(this.rdMale);
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(20, 99);
            this.grbSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSex.Name = "grbSex";
            this.grbSex.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSex.Size = new System.Drawing.Size(322, 59);
            this.grbSex.TabIndex = 29;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Sex";
            // 
            // rdFamele
            // 
            this.rdFamele.Location = new System.Drawing.Point(185, 21);
            this.rdFamele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFamele.Name = "rdFamele";
            this.rdFamele.Size = new System.Drawing.Size(78, 27);
            this.rdFamele.TabIndex = 6;
            this.rdFamele.Text = "Famele";
            // 
            // rdMale
            // 
            this.rdMale.Location = new System.Drawing.Point(104, 21);
            this.rdMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(60, 27);
            this.rdMale.TabIndex = 5;
            this.rdMale.Text = "Male";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(477, 68);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(208, 30);
            this.txtDepartment.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(373, 71);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(101, 27);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Department:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(477, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 30);
            this.txtID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(373, 39);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 27);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(123, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(19, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 27);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(123, 33);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(19, 39);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(99, 27);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name:";
            // 
            // listEmployee
            // 
            this.listEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listEmployee.FullRowSelect = true;
            this.listEmployee.GridLines = true;
            this.listEmployee.Location = new System.Drawing.Point(0, 185);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(864, 376);
            this.listEmployee.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listEmployee.TabIndex = 36;
            this.listEmployee.UseCompatibleStateImageBehavior = false;
            this.listEmployee.View = System.Windows.Forms.View.Details;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(730, 68);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 35);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "&Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(730, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "&Add New";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listEmployee);
            this.Controls.Add(this.grpDetails);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmployeeView";
            this.Text = "Sales Management";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbSex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grbSex;
        internal System.Windows.Forms.RadioButton rdFamele;
        internal System.Windows.Forms.RadioButton rdMale;
        internal System.Windows.Forms.TextBox txtDepartment;
        internal System.Windows.Forms.Label lblDepartment;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.ListView listEmployee;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnAdd;

    }
}