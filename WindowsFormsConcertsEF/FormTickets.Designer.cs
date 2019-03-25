namespace WindowsFormsConcertsEF
{
    partial class FormTickets
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
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelArtist = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketConcertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.ticketStateIDDataGridViewTextBoxColumn,
            this.ticketConcertIDDataGridViewTextBoxColumn,
            this.ticketSeatIDDataGridViewTextBoxColumn,
            this.ticketIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataSource = typeof(ConcertsDataBase.Tickets);
            // 
            // LabelArtist
            // 
            this.LabelArtist.AutoSize = true;
            this.LabelArtist.Location = new System.Drawing.Point(26, 29);
            this.LabelArtist.Name = "LabelArtist";
            this.LabelArtist.Size = new System.Drawing.Size(86, 17);
            this.LabelArtist.TabIndex = 1;
            this.LabelArtist.Text = "Виконавець";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(187, 29);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(121, 22);
            this.textBoxArtist.TabIndex = 2;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(26, 96);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(88, 17);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "Стан квитка";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Вільно",
            "Заброньовано",
            "Куплено"});
            this.comboBoxState.Location = new System.Drawing.Point(187, 92);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxState.TabIndex = 5;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(27, 64);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(128, 17);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "Місце проведення";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(187, 61);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(121, 22);
            this.textBoxPlace.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(466, 44);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 56);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataSource = typeof(ConcertsDataBase.Seats);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ticket_Seat_ID";
            this.Column1.DataSource = this.seatsBindingSource;
            this.Column1.DisplayMember = "Seat_Number";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "Seat_ID";
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            // 
            // ticketStateIDDataGridViewTextBoxColumn
            // 
            this.ticketStateIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_State_ID";
            this.ticketStateIDDataGridViewTextBoxColumn.HeaderText = "Ticket_State_ID";
            this.ticketStateIDDataGridViewTextBoxColumn.Name = "ticketStateIDDataGridViewTextBoxColumn";
            this.ticketStateIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketConcertIDDataGridViewTextBoxColumn
            // 
            this.ticketConcertIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Concert_ID";
            this.ticketConcertIDDataGridViewTextBoxColumn.HeaderText = "Ticket_Concert_ID";
            this.ticketConcertIDDataGridViewTextBoxColumn.Name = "ticketConcertIDDataGridViewTextBoxColumn";
            this.ticketConcertIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketSeatIDDataGridViewTextBoxColumn
            // 
            this.ticketSeatIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Seat_ID";
            this.ticketSeatIDDataGridViewTextBoxColumn.HeaderText = "Ticket_Seat_ID";
            this.ticketSeatIDDataGridViewTextBoxColumn.Name = "ticketSeatIDDataGridViewTextBoxColumn";
            this.ticketSeatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.LabelArtist);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTickets";
            this.Text = "Білети";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.Label LabelArtist;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketConcertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketSeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
    }
}