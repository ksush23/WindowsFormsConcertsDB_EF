namespace WindowsFormsConcertsEF
{
    partial class FormArtists
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
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtists
            // 
            this.dataGridViewArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtists.AutoGenerateColumns = false;
            this.dataGridViewArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn,
            this.concertsDataGridViewTextBoxColumn});
            this.dataGridViewArtists.DataSource = this.artistsBindingSource;
            this.dataGridViewArtists.Location = new System.Drawing.Point(34, 103);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowTemplate.Height = 24;
            this.dataGridViewArtists.Size = new System.Drawing.Size(720, 313);
            this.dataGridViewArtists.TabIndex = 1;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Indi rock",
            "Народна музика",
            "Rap"});
            this.comboBoxGenre.Location = new System.Drawing.Point(387, 51);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGenre.TabIndex = 2;
            this.comboBoxGenre.SelectedValueChanged += new System.EventHandler(this.comboBoxGenre_SelectedValueChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(160, 51);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(45, 17);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Жанр";
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "Artist_ID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "Artist_ID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            this.artistIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Виконавець";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            // 
            // concertsDataGridViewTextBoxColumn
            // 
            this.concertsDataGridViewTextBoxColumn.DataPropertyName = "Concerts";
            this.concertsDataGridViewTextBoxColumn.HeaderText = "Concerts";
            this.concertsDataGridViewTextBoxColumn.Name = "concertsDataGridViewTextBoxColumn";
            this.concertsDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataSource = typeof(ConcertsDataBase.Artists);
            // 
            // FormArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.dataGridViewArtists);
            this.Name = "FormArtists";
            this.Text = "Пошук за жанром";
            this.Load += new System.EventHandler(this.FormArtists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertsDataGridViewTextBoxColumn;
    }
}