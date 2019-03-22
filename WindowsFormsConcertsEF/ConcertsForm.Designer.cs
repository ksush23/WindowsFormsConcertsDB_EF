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
            this.tabConcert = new System.Windows.Forms.TabPage();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.tabPlaces = new System.Windows.Forms.TabPage();
            this.tabSectors = new System.Windows.Forms.TabPage();
            this.tabSeats = new System.Windows.Forms.TabPage();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.dataGridViewSectors = new System.Windows.Forms.DataGridView();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TicketState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Places = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Sectors = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertArtistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketConcertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatSectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConcerts.SuspendLayout();
            this.tabArtists.SuspendLayout();
            this.tabConcert.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabPlaces.SuspendLayout();
            this.tabSectors.SuspendLayout();
            this.tabSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
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
            this.tabArtists.Controls.Add(this.dataGridViewArtists);
            this.tabArtists.Location = new System.Drawing.Point(4, 25);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtists.Size = new System.Drawing.Size(1021, 439);
            this.tabArtists.TabIndex = 0;
            this.tabArtists.Text = "Виконавці";
            this.tabArtists.UseVisualStyleBackColor = true;
            // 
            // tabConcert
            // 
            this.tabConcert.Controls.Add(this.dataGridViewConcerts);
            this.tabConcert.Location = new System.Drawing.Point(4, 25);
            this.tabConcert.Name = "tabConcert";
            this.tabConcert.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcert.Size = new System.Drawing.Size(1021, 439);
            this.tabConcert.TabIndex = 1;
            this.tabConcert.Text = "Концерти";
            this.tabConcert.UseVisualStyleBackColor = true;
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.dataGridViewTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Size = new System.Drawing.Size(1021, 439);
            this.tabTickets.TabIndex = 2;
            this.tabTickets.Text = "Білети";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // tabPlaces
            // 
            this.tabPlaces.Controls.Add(this.dataGridViewPlaces);
            this.tabPlaces.Location = new System.Drawing.Point(4, 25);
            this.tabPlaces.Name = "tabPlaces";
            this.tabPlaces.Size = new System.Drawing.Size(1021, 439);
            this.tabPlaces.TabIndex = 3;
            this.tabPlaces.Text = "Місця проведення";
            this.tabPlaces.UseVisualStyleBackColor = true;
            // 
            // tabSectors
            // 
            this.tabSectors.Controls.Add(this.dataGridViewSectors);
            this.tabSectors.Location = new System.Drawing.Point(4, 25);
            this.tabSectors.Name = "tabSectors";
            this.tabSectors.Size = new System.Drawing.Size(1021, 439);
            this.tabSectors.TabIndex = 4;
            this.tabSectors.Text = "Сектори";
            this.tabSectors.UseVisualStyleBackColor = true;
            // 
            // tabSeats
            // 
            this.tabSeats.Controls.Add(this.dataGridViewSeats);
            this.tabSeats.Location = new System.Drawing.Point(4, 25);
            this.tabSeats.Name = "tabSeats";
            this.tabSeats.Size = new System.Drawing.Size(1021, 439);
            this.tabSeats.TabIndex = 5;
            this.tabSeats.Text = "Місця";
            this.tabSeats.UseVisualStyleBackColor = true;
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
            this.dataGridViewArtists.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowTemplate.Height = 24;
            this.dataGridViewArtists.Size = new System.Drawing.Size(1009, 407);
            this.dataGridViewArtists.TabIndex = 0;
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
            this.dataGridViewConcerts.Location = new System.Drawing.Point(-3, 0);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.RowTemplate.Height = 24;
            this.dataGridViewConcerts.Size = new System.Drawing.Size(1018, 423);
            this.dataGridViewConcerts.TabIndex = 0;
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
            this.dataGridViewTickets.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1014, 409);
            this.dataGridViewTickets.TabIndex = 0;
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
            this.dataGridViewPlaces.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(1014, 422);
            this.dataGridViewPlaces.TabIndex = 0;
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
            this.dataGridViewSectors.Location = new System.Drawing.Point(0, 4);
            this.dataGridViewSectors.Name = "dataGridViewSectors";
            this.dataGridViewSectors.RowTemplate.Height = 24;
            this.dataGridViewSectors.Size = new System.Drawing.Size(1018, 414);
            this.dataGridViewSectors.TabIndex = 0;
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
            this.dataGridViewSeats.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(1014, 413);
            this.dataGridViewSeats.TabIndex = 0;
            this.dataGridViewSeats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeats_CellContentClick);
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
            // Seat
            // 
            this.Seat.DataPropertyName = "Ticket_Seat_ID";
            this.Seat.DataSource = this.seatsBindingSource;
            this.Seat.DisplayMember = "Seat_Number";
            this.Seat.HeaderText = "Місце";
            this.Seat.Name = "Seat";
            this.Seat.ValueMember = "Seat_ID";
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
            // Places
            // 
            this.Places.DataPropertyName = "Sector_Place_ID";
            this.Places.DataSource = this.placesBindingSource;
            this.Places.DisplayMember = "Place_Name";
            this.Places.HeaderText = "Місце проведення";
            this.Places.Name = "Places";
            this.Places.ValueMember = "Place_ID";
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
            // placesBindingSource
            // 
            this.placesBindingSource.DataSource = typeof(ConcertsDataBase.Places);
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataSource = typeof(ConcertsDataBase.Concerts);
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
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataSource = typeof(ConcertsDataBase.Seats);
            // 
            // ticketStatesBindingSource
            // 
            this.ticketStatesBindingSource.DataSource = typeof(ConcertsDataBase.Ticket_States);
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataSource = typeof(ConcertsDataBase.Tickets);
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
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataSource = typeof(ConcertsDataBase.Sectors);
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
            this.tabConcert.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabPlaces.ResumeLayout(false);
            this.tabSectors.ResumeLayout(false);
            this.tabSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
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
    }
}

