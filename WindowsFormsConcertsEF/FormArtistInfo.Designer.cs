namespace WindowsFormsConcertsEF
{
    partial class FormArtistInfo
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
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.concertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertArtistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataSource = typeof(ConcertsDataBase.Artists);
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataSource = typeof(ConcertsDataBase.Concerts);
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataSource = typeof(ConcertsDataBase.Places);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertIDDataGridViewTextBoxColumn,
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.concertArtistIDDataGridViewTextBoxColumn,
            this.concertPlaceIDDataGridViewTextBoxColumn,
            this.artistsDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn,
            this.ticketsDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.concertsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // concertIDDataGridViewTextBoxColumn
            // 
            this.concertIDDataGridViewTextBoxColumn.DataPropertyName = "Concert_ID";
            this.concertIDDataGridViewTextBoxColumn.HeaderText = "Concert_ID";
            this.concertIDDataGridViewTextBoxColumn.Name = "concertIDDataGridViewTextBoxColumn";
            this.concertIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // concertTimeDateDataGridViewTextBoxColumn
            // 
            this.concertTimeDateDataGridViewTextBoxColumn.DataPropertyName = "Concert_TimeDate";
            this.concertTimeDateDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.concertTimeDateDataGridViewTextBoxColumn.Name = "concertTimeDateDataGridViewTextBoxColumn";
            // 
            // concertArtistIDDataGridViewTextBoxColumn
            // 
            this.concertArtistIDDataGridViewTextBoxColumn.DataPropertyName = "Concert_Artist_ID";
            this.concertArtistIDDataGridViewTextBoxColumn.HeaderText = "Concert_Artist_ID";
            this.concertArtistIDDataGridViewTextBoxColumn.Name = "concertArtistIDDataGridViewTextBoxColumn";
            this.concertArtistIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // concertPlaceIDDataGridViewTextBoxColumn
            // 
            this.concertPlaceIDDataGridViewTextBoxColumn.DataPropertyName = "Concert_Place_ID";
            this.concertPlaceIDDataGridViewTextBoxColumn.HeaderText = "Concert_Place_ID";
            this.concertPlaceIDDataGridViewTextBoxColumn.Name = "concertPlaceIDDataGridViewTextBoxColumn";
            this.concertPlaceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistsDataGridViewTextBoxColumn
            // 
            this.artistsDataGridViewTextBoxColumn.DataPropertyName = "Artists";
            this.artistsDataGridViewTextBoxColumn.HeaderText = "Artists";
            this.artistsDataGridViewTextBoxColumn.Name = "artistsDataGridViewTextBoxColumn";
            this.artistsDataGridViewTextBoxColumn.Visible = false;
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "Places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "Places";
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            this.placesDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketsDataGridViewTextBoxColumn
            // 
            this.ticketsDataGridViewTextBoxColumn.DataPropertyName = "Tickets";
            this.ticketsDataGridViewTextBoxColumn.HeaderText = "Tickets";
            this.ticketsDataGridViewTextBoxColumn.Name = "ticketsDataGridViewTextBoxColumn";
            this.ticketsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Concert_Place_ID";
            this.Column1.DataSource = this.placesBindingSource;
            this.Column1.DisplayMember = "Place_Name";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ValueMember = "Place_ID";
            // 
            // FormArtistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormArtistInfo";
            this.Text = "FormArtistInfo";
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private System.Windows.Forms.BindingSource concertsBindingSource;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertArtistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertPlaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
    }
}