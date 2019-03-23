namespace WindowsFormsConcertsEF
{
    partial class ConcertsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabConcerts = new System.Windows.Forms.TabControl();
            this.tabArtists = new System.Windows.Forms.TabPage();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabConcert = new System.Windows.Forms.TabPage();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.concertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertArtistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketConcertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicketState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ticketStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPlaces = new System.Windows.Forms.TabPage();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSectors = new System.Windows.Forms.TabPage();
            this.dataGridViewSectors = new System.Windows.Forms.DataGridView();
            this.sectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Places = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSeats = new System.Windows.Forms.TabPage();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.seatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatSectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sectors = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonSaveArtists = new System.Windows.Forms.Button();
            this.buttonDeleteArtists = new System.Windows.Forms.Button();
            this.buttonSaveConcerts = new System.Windows.Forms.Button();
            this.buttonDeleteConcerts = new System.Windows.Forms.Button();
            this.buttonDeleteTickets = new System.Windows.Forms.Button();
            this.buttonSaveTickets = new System.Windows.Forms.Button();
            this.buttonSavePlaces = new System.Windows.Forms.Button();
            this.buttonDeletePlaces = new System.Windows.Forms.Button();
            this.buttonDeleteSectors = new System.Windows.Forms.Button();
            this.buttonSaveSectors = new System.Windows.Forms.Button();
            this.buttonSaveSeats = new System.Windows.Forms.Button();
            this.buttonDeleteSeats = new System.Windows.Forms.Button();
            this.tabConcerts.SuspendLayout();
            this.tabArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            this.tabConcert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.tabPlaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            this.tabSectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.tabSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConcerts
            // 
            this.tabConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConcerts.Controls.Add(this.tabArtists);
            this.tabConcerts.Controls.Add(this.tabConcert);
            this.tabConcerts.Controls.Add(this.tabTickets);
            this.tabConcerts.Controls.Add(this.tabPlaces);
            this.tabConcerts.Controls.Add(this.tabSectors);
            this.tabConcerts.Controls.Add(this.tabSeats);
            this.tabConcerts.Location = new System.Drawing.Point(12, 12);
            this.tabConcerts.Name = "tabConcerts";
            this.tabConcerts.SelectedIndex = 0;
            this.tabConcerts.Size = new System.Drawing.Size(1029, 468);
            this.tabConcerts.TabIndex = 0;
            // 
            // tabArtists
            // 
            this.tabArtists.Controls.Add(this.buttonDeleteArtists);
            this.tabArtists.Controls.Add(this.buttonSaveArtists);
            this.tabArtists.Controls.Add(this.dataGridViewArtists);
            this.tabArtists.Location = new System.Drawing.Point(4, 25);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtists.Size = new System.Drawing.Size(1021, 439);
            this.tabArtists.TabIndex = 0;
            this.tabArtists.Text = "Виконавці";
            this.tabArtists.UseVisualStyleBackColor = true;
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
            this.artistGenreDataGridViewTextBoxColumn});
            this.dataGridViewArtists.DataSource = this.artistsBindingSource;
            this.dataGridViewArtists.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowTemplate.Height = 24;
            this.dataGridViewArtists.Size = new System.Drawing.Size(1009, 367);
            this.dataGridViewArtists.TabIndex = 0;
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
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataSource = typeof(ConcertsDataBase.Artists);
            // 
            // tabConcert
            // 
            this.tabConcert.Controls.Add(this.buttonDeleteConcerts);
            this.tabConcert.Controls.Add(this.buttonSaveConcerts);
            this.tabConcert.Controls.Add(this.dataGridViewConcerts);
            this.tabConcert.Location = new System.Drawing.Point(4, 25);
            this.tabConcert.Name = "tabConcert";
            this.tabConcert.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcert.Size = new System.Drawing.Size(1021, 439);
            this.tabConcert.TabIndex = 1;
            this.tabConcert.Text = "Концерти";
            this.tabConcert.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConcerts
            // 
            this.dataGridViewConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConcerts.AutoGenerateColumns = false;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertIDDataGridViewTextBoxColumn,
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.concertArtistIDDataGridViewTextBoxColumn,
            this.concertPlaceIDDataGridViewTextBoxColumn,
            this.Artist,
            this.Place});
            this.dataGridViewConcerts.DataSource = this.concertsBindingSource;
            this.dataGridViewConcerts.Location = new System.Drawing.Point(-3, 44);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.RowTemplate.Height = 24;
            this.dataGridViewConcerts.Size = new System.Drawing.Size(1018, 379);
            this.dataGridViewConcerts.TabIndex = 0;
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
            // Artist
            // 
            this.Artist.DataPropertyName = "Concert_Artist_ID";
            this.Artist.DataSource = this.artistsBindingSource;
            this.Artist.DisplayMember = "Artist_Name";
            this.Artist.HeaderText = "Виконавець";
            this.Artist.Name = "Artist";
            this.Artist.ValueMember = "Artist_ID";
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Concert_Place_ID";
            this.Place.DataSource = this.placesBindingSource;
            this.Place.DisplayMember = "Place_Name";
            this.Place.HeaderText = "Місце проведення";
            this.Place.Name = "Place";
            this.Place.ValueMember = "Place_ID";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataSource = typeof(ConcertsDataBase.Places);
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataSource = typeof(ConcertsDataBase.Concerts);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.buttonSaveTickets);
            this.tabTickets.Controls.Add(this.buttonDeleteTickets);
            this.tabTickets.Controls.Add(this.dataGridViewTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Size = new System.Drawing.Size(1021, 439);
            this.tabTickets.TabIndex = 2;
            this.tabTickets.Text = "Білети";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketStateIDDataGridViewTextBoxColumn,
            this.ticketConcertIDDataGridViewTextBoxColumn,
            this.ticketSeatIDDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.Seat,
            this.TicketState});
            this.dataGridViewTickets.DataSource = this.ticketsBindingSource;
            this.dataGridViewTickets.Location = new System.Drawing.Point(4, 44);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1014, 369);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Visible = false;
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
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            // 
            // Seat
            // 
            this.Seat.DataPropertyName = "Ticket_Seat_ID";
            this.Seat.DataSource = this.seatsBindingSource;
            this.Seat.DisplayMember = "Seat_Number";
            this.Seat.HeaderText = "Місце";
            this.Seat.Name = "Seat";
            this.Seat.ValueMember = "Seat_ID";
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataSource = typeof(ConcertsDataBase.Seats);
            // 
            // TicketState
            // 
            this.TicketState.DataPropertyName = "Ticket_State_ID";
            this.TicketState.DataSource = this.ticketStatesBindingSource;
            this.TicketState.DisplayMember = "Name";
            this.TicketState.HeaderText = "Стан квитка";
            this.TicketState.Name = "TicketState";
            this.TicketState.ValueMember = "State_ID";
            // 
            // ticketStatesBindingSource
            // 
            this.ticketStatesBindingSource.DataSource = typeof(ConcertsDataBase.Ticket_States);
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataSource = typeof(ConcertsDataBase.Tickets);
            // 
            // tabPlaces
            // 
            this.tabPlaces.Controls.Add(this.buttonDeletePlaces);
            this.tabPlaces.Controls.Add(this.buttonSavePlaces);
            this.tabPlaces.Controls.Add(this.dataGridViewPlaces);
            this.tabPlaces.Location = new System.Drawing.Point(4, 25);
            this.tabPlaces.Name = "tabPlaces";
            this.tabPlaces.Size = new System.Drawing.Size(1021, 439);
            this.tabPlaces.TabIndex = 3;
            this.tabPlaces.Text = "Місця проведення";
            this.tabPlaces.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaces.AutoGenerateColumns = false;
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeIDDataGridViewTextBoxColumn,
            this.placeNameDataGridViewTextBoxColumn,
            this.placeAddressDataGridViewTextBoxColumn});
            this.dataGridViewPlaces.DataSource = this.placesBindingSource;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(4, 42);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(1014, 384);
            this.dataGridViewPlaces.TabIndex = 0;
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "Place_Name";
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "Місце проведення";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            // 
            // placeAddressDataGridViewTextBoxColumn
            // 
            this.placeAddressDataGridViewTextBoxColumn.DataPropertyName = "Place_Address";
            this.placeAddressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.placeAddressDataGridViewTextBoxColumn.Name = "placeAddressDataGridViewTextBoxColumn";
            // 
            // tabSectors
            // 
            this.tabSectors.Controls.Add(this.buttonSaveSectors);
            this.tabSectors.Controls.Add(this.buttonDeleteSectors);
            this.tabSectors.Controls.Add(this.dataGridViewSectors);
            this.tabSectors.Location = new System.Drawing.Point(4, 25);
            this.tabSectors.Name = "tabSectors";
            this.tabSectors.Size = new System.Drawing.Size(1021, 439);
            this.tabSectors.TabIndex = 4;
            this.tabSectors.Text = "Сектори";
            this.tabSectors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSectors
            // 
            this.dataGridViewSectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSectors.AutoGenerateColumns = false;
            this.dataGridViewSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectorIDDataGridViewTextBoxColumn,
            this.sectorNameDataGridViewTextBoxColumn,
            this.sectorPlaceIDDataGridViewTextBoxColumn,
            this.Places});
            this.dataGridViewSectors.DataSource = this.sectorsBindingSource;
            this.dataGridViewSectors.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewSectors.Name = "dataGridViewSectors";
            this.dataGridViewSectors.RowTemplate.Height = 24;
            this.dataGridViewSectors.Size = new System.Drawing.Size(1018, 376);
            this.dataGridViewSectors.TabIndex = 0;
            // 
            // sectorIDDataGridViewTextBoxColumn
            // 
            this.sectorIDDataGridViewTextBoxColumn.DataPropertyName = "Sector_ID";
            this.sectorIDDataGridViewTextBoxColumn.HeaderText = "Sector_ID";
            this.sectorIDDataGridViewTextBoxColumn.Name = "sectorIDDataGridViewTextBoxColumn";
            this.sectorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectorNameDataGridViewTextBoxColumn
            // 
            this.sectorNameDataGridViewTextBoxColumn.DataPropertyName = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.HeaderText = "Сектор";
            this.sectorNameDataGridViewTextBoxColumn.Name = "sectorNameDataGridViewTextBoxColumn";
            // 
            // sectorPlaceIDDataGridViewTextBoxColumn
            // 
            this.sectorPlaceIDDataGridViewTextBoxColumn.DataPropertyName = "Sector_Place_ID";
            this.sectorPlaceIDDataGridViewTextBoxColumn.HeaderText = "Sector_Place_ID";
            this.sectorPlaceIDDataGridViewTextBoxColumn.Name = "sectorPlaceIDDataGridViewTextBoxColumn";
            this.sectorPlaceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Places
            // 
            this.Places.DataPropertyName = "Sector_Place_ID";
            this.Places.DataSource = this.placesBindingSource;
            this.Places.DisplayMember = "Place_Name";
            this.Places.HeaderText = "Місце проведення";
            this.Places.Name = "Places";
            this.Places.ValueMember = "Place_ID";
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataSource = typeof(ConcertsDataBase.Sectors);
            // 
            // tabSeats
            // 
            this.tabSeats.Controls.Add(this.buttonDeleteSeats);
            this.tabSeats.Controls.Add(this.buttonSaveSeats);
            this.tabSeats.Controls.Add(this.dataGridViewSeats);
            this.tabSeats.Location = new System.Drawing.Point(4, 25);
            this.tabSeats.Name = "tabSeats";
            this.tabSeats.Size = new System.Drawing.Size(1021, 439);
            this.tabSeats.TabIndex = 5;
            this.tabSeats.Text = "Місця";
            this.tabSeats.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeats
            // 
            this.dataGridViewSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeats.AutoGenerateColumns = false;
            this.dataGridViewSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatIDDataGridViewTextBoxColumn,
            this.seatLinenumberDataGridViewTextBoxColumn,
            this.seatNumberDataGridViewTextBoxColumn,
            this.seatSectorIDDataGridViewTextBoxColumn,
            this.Sectors});
            this.dataGridViewSeats.DataSource = this.seatsBindingSource;
            this.dataGridViewSeats.Location = new System.Drawing.Point(4, 42);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(1014, 375);
            this.dataGridViewSeats.TabIndex = 0;
            this.dataGridViewSeats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeats_CellContentClick);
            // 
            // seatIDDataGridViewTextBoxColumn
            // 
            this.seatIDDataGridViewTextBoxColumn.DataPropertyName = "Seat_ID";
            this.seatIDDataGridViewTextBoxColumn.HeaderText = "Seat_ID";
            this.seatIDDataGridViewTextBoxColumn.Name = "seatIDDataGridViewTextBoxColumn";
            this.seatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // seatLinenumberDataGridViewTextBoxColumn
            // 
            this.seatLinenumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Line_number";
            this.seatLinenumberDataGridViewTextBoxColumn.HeaderText = "Номер ряду";
            this.seatLinenumberDataGridViewTextBoxColumn.Name = "seatLinenumberDataGridViewTextBoxColumn";
            // 
            // seatNumberDataGridViewTextBoxColumn
            // 
            this.seatNumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Number";
            this.seatNumberDataGridViewTextBoxColumn.HeaderText = "Номер сидіння";
            this.seatNumberDataGridViewTextBoxColumn.Name = "seatNumberDataGridViewTextBoxColumn";
            // 
            // seatSectorIDDataGridViewTextBoxColumn
            // 
            this.seatSectorIDDataGridViewTextBoxColumn.DataPropertyName = "Seat_Sector_ID";
            this.seatSectorIDDataGridViewTextBoxColumn.HeaderText = "Seat_Sector_ID";
            this.seatSectorIDDataGridViewTextBoxColumn.Name = "seatSectorIDDataGridViewTextBoxColumn";
            this.seatSectorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Sectors
            // 
            this.Sectors.DataPropertyName = "Seat_Sector_ID";
            this.Sectors.DataSource = this.sectorsBindingSource;
            this.Sectors.DisplayMember = "Sector_Name";
            this.Sectors.HeaderText = "Сектор";
            this.Sectors.Name = "Sectors";
            this.Sectors.ValueMember = "Sector_ID";
            // 
            // buttonSaveArtists
            // 
            this.buttonSaveArtists.Location = new System.Drawing.Point(23, 6);
            this.buttonSaveArtists.Name = "buttonSaveArtists";
            this.buttonSaveArtists.Size = new System.Drawing.Size(83, 32);
            this.buttonSaveArtists.TabIndex = 1;
            this.buttonSaveArtists.Text = "Зберегти";
            this.buttonSaveArtists.UseVisualStyleBackColor = true;
            this.buttonSaveArtists.Click += new System.EventHandler(this.buttonSaveArtists_Click);
            // 
            // buttonDeleteArtists
            // 
            this.buttonDeleteArtists.Location = new System.Drawing.Point(124, 6);
            this.buttonDeleteArtists.Name = "buttonDeleteArtists";
            this.buttonDeleteArtists.Size = new System.Drawing.Size(91, 34);
            this.buttonDeleteArtists.TabIndex = 2;
            this.buttonDeleteArtists.Text = "Видалити";
            this.buttonDeleteArtists.UseVisualStyleBackColor = true;
            this.buttonDeleteArtists.Click += new System.EventHandler(this.buttonDeleteArtists_Click);
            // 
            // buttonSaveConcerts
            // 
            this.buttonSaveConcerts.Location = new System.Drawing.Point(20, 6);
            this.buttonSaveConcerts.Name = "buttonSaveConcerts";
            this.buttonSaveConcerts.Size = new System.Drawing.Size(83, 32);
            this.buttonSaveConcerts.TabIndex = 2;
            this.buttonSaveConcerts.Text = "Зберегти";
            this.buttonSaveConcerts.UseVisualStyleBackColor = true;
            this.buttonSaveConcerts.Click += new System.EventHandler(this.buttonSaveConcerts_Click);
            // 
            // buttonDeleteConcerts
            // 
            this.buttonDeleteConcerts.Location = new System.Drawing.Point(125, 6);
            this.buttonDeleteConcerts.Name = "buttonDeleteConcerts";
            this.buttonDeleteConcerts.Size = new System.Drawing.Size(91, 34);
            this.buttonDeleteConcerts.TabIndex = 3;
            this.buttonDeleteConcerts.Text = "Видалити";
            this.buttonDeleteConcerts.UseVisualStyleBackColor = true;
            this.buttonDeleteConcerts.Click += new System.EventHandler(this.buttonDeleteConcerts_Click);
            // 
            // buttonDeleteTickets
            // 
            this.buttonDeleteTickets.Location = new System.Drawing.Point(122, 3);
            this.buttonDeleteTickets.Name = "buttonDeleteTickets";
            this.buttonDeleteTickets.Size = new System.Drawing.Size(91, 34);
            this.buttonDeleteTickets.TabIndex = 3;
            this.buttonDeleteTickets.Text = "Видалити";
            this.buttonDeleteTickets.UseVisualStyleBackColor = true;
            this.buttonDeleteTickets.Click += new System.EventHandler(this.buttonDeleteTickets_Click);
            // 
            // buttonSaveTickets
            // 
            this.buttonSaveTickets.Location = new System.Drawing.Point(23, 3);
            this.buttonSaveTickets.Name = "buttonSaveTickets";
            this.buttonSaveTickets.Size = new System.Drawing.Size(83, 32);
            this.buttonSaveTickets.TabIndex = 4;
            this.buttonSaveTickets.Text = "Зберегти";
            this.buttonSaveTickets.UseVisualStyleBackColor = true;
            this.buttonSaveTickets.Click += new System.EventHandler(this.buttonSaveTickets_Click);
            // 
            // buttonSavePlaces
            // 
            this.buttonSavePlaces.Location = new System.Drawing.Point(23, 4);
            this.buttonSavePlaces.Name = "buttonSavePlaces";
            this.buttonSavePlaces.Size = new System.Drawing.Size(83, 32);
            this.buttonSavePlaces.TabIndex = 3;
            this.buttonSavePlaces.Text = "Зберегти";
            this.buttonSavePlaces.UseVisualStyleBackColor = true;
            this.buttonSavePlaces.Click += new System.EventHandler(this.buttonSavePlaces_Click);
            // 
            // buttonDeletePlaces
            // 
            this.buttonDeletePlaces.Location = new System.Drawing.Point(137, 4);
            this.buttonDeletePlaces.Name = "buttonDeletePlaces";
            this.buttonDeletePlaces.Size = new System.Drawing.Size(91, 34);
            this.buttonDeletePlaces.TabIndex = 4;
            this.buttonDeletePlaces.Text = "Видалити";
            this.buttonDeletePlaces.UseVisualStyleBackColor = true;
            this.buttonDeletePlaces.Click += new System.EventHandler(this.buttonDeletePlaces_Click);
            // 
            // buttonDeleteSectors
            // 
            this.buttonDeleteSectors.Location = new System.Drawing.Point(118, 3);
            this.buttonDeleteSectors.Name = "buttonDeleteSectors";
            this.buttonDeleteSectors.Size = new System.Drawing.Size(91, 34);
            this.buttonDeleteSectors.TabIndex = 4;
            this.buttonDeleteSectors.Text = "Видалити";
            this.buttonDeleteSectors.UseVisualStyleBackColor = true;
            this.buttonDeleteSectors.Click += new System.EventHandler(this.buttonDeleteSectors_Click);
            // 
            // buttonSaveSectors
            // 
            this.buttonSaveSectors.Location = new System.Drawing.Point(19, 5);
            this.buttonSaveSectors.Name = "buttonSaveSectors";
            this.buttonSaveSectors.Size = new System.Drawing.Size(83, 32);
            this.buttonSaveSectors.TabIndex = 5;
            this.buttonSaveSectors.Text = "Зберегти";
            this.buttonSaveSectors.UseVisualStyleBackColor = true;
            this.buttonSaveSectors.Click += new System.EventHandler(this.buttonSaveSectors_Click);
            // 
            // buttonSaveSeats
            // 
            this.buttonSaveSeats.Location = new System.Drawing.Point(24, 4);
            this.buttonSaveSeats.Name = "buttonSaveSeats";
            this.buttonSaveSeats.Size = new System.Drawing.Size(83, 32);
            this.buttonSaveSeats.TabIndex = 4;
            this.buttonSaveSeats.Text = "Зберегти";
            this.buttonSaveSeats.UseVisualStyleBackColor = true;
            this.buttonSaveSeats.Click += new System.EventHandler(this.buttonSaveSeats_Click);
            // 
            // buttonDeleteSeats
            // 
            this.buttonDeleteSeats.Location = new System.Drawing.Point(138, 3);
            this.buttonDeleteSeats.Name = "buttonDeleteSeats";
            this.buttonDeleteSeats.Size = new System.Drawing.Size(91, 34);
            this.buttonDeleteSeats.TabIndex = 5;
            this.buttonDeleteSeats.Text = "Видалити";
            this.buttonDeleteSeats.UseVisualStyleBackColor = true;
            this.buttonDeleteSeats.Click += new System.EventHandler(this.buttonDeleteSeats_Click);
            // 
            // ConcertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 501);
            this.Controls.Add(this.tabConcerts);
            this.Name = "ConcertsForm";
            this.Text = "Концерти";
            this.tabConcerts.ResumeLayout(false);
            this.tabArtists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            this.tabConcert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            this.tabTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.tabPlaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            this.tabSectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            this.tabSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConcerts;
        private System.Windows.Forms.TabPage tabArtists;
        private System.Windows.Forms.TabPage tabConcert;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabPlaces;
        private System.Windows.Forms.TabPage tabSectors;
        private System.Windows.Forms.TabPage tabSeats;
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewConcerts;
        private System.Windows.Forms.BindingSource concertsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSectors;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSeats;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketStatesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertArtistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertPlaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Artist;
        private System.Windows.Forms.DataGridViewComboBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketConcertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketSeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Seat;
        private System.Windows.Forms.DataGridViewComboBoxColumn TicketState;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorPlaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Places;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatLinenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatSectorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sectors;
        private System.Windows.Forms.Button buttonDeleteArtists;
        private System.Windows.Forms.Button buttonSaveArtists;
        private System.Windows.Forms.Button buttonDeleteConcerts;
        private System.Windows.Forms.Button buttonSaveConcerts;
        private System.Windows.Forms.Button buttonSaveTickets;
        private System.Windows.Forms.Button buttonDeleteTickets;
        private System.Windows.Forms.Button buttonDeletePlaces;
        private System.Windows.Forms.Button buttonSavePlaces;
        private System.Windows.Forms.Button buttonSaveSectors;
        private System.Windows.Forms.Button buttonDeleteSectors;
        private System.Windows.Forms.Button buttonDeleteSeats;
        private System.Windows.Forms.Button buttonSaveSeats;
    }
}

