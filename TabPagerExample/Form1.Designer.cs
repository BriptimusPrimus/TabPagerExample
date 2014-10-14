namespace TabPagerExample
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetUsersDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetPenetrationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionDataGridViewTextBoxColumn1,
            this.symbolDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.populationDataGridViewTextBoxColumn1,
            this.internetUsersDataGridViewTextBoxColumn1,
            this.internetPenetrationDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.countryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(658, 489);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // regionDataGridViewTextBoxColumn1
            // 
            this.regionDataGridViewTextBoxColumn1.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn1.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn1.Name = "regionDataGridViewTextBoxColumn1";
            // 
            // symbolDataGridViewTextBoxColumn1
            // 
            this.symbolDataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn1.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn1.Name = "symbolDataGridViewTextBoxColumn1";
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            // 
            // populationDataGridViewTextBoxColumn1
            // 
            this.populationDataGridViewTextBoxColumn1.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn1.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn1.Name = "populationDataGridViewTextBoxColumn1";
            // 
            // internetUsersDataGridViewTextBoxColumn1
            // 
            this.internetUsersDataGridViewTextBoxColumn1.DataPropertyName = "InternetUsers";
            this.internetUsersDataGridViewTextBoxColumn1.HeaderText = "InternetUsers";
            this.internetUsersDataGridViewTextBoxColumn1.Name = "internetUsersDataGridViewTextBoxColumn1";
            // 
            // internetPenetrationDataGridViewTextBoxColumn1
            // 
            this.internetPenetrationDataGridViewTextBoxColumn1.DataPropertyName = "InternetPenetration";
            this.internetPenetrationDataGridViewTextBoxColumn1.HeaderText = "Internet Penetration";
            this.internetPenetrationDataGridViewTextBoxColumn1.Name = "internetPenetrationDataGridViewTextBoxColumn1";
            this.internetPenetrationDataGridViewTextBoxColumn1.Width = 130;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataSource = typeof(TabPagerExample.Country);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(TabPagerExample.Country);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetUsersDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetPenetrationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

