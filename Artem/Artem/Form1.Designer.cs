namespace Artem
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd3DataSet = new Artem.bd3DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd3DataSet2 = new Artem.bd3DataSet2();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd3DataSet3 = new Artem.bd3DataSet3();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd3DataSet4 = new Artem.bd3DataSet4();
            this.choiceHallAndDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd3DataSet1 = new Artem.bd3DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.cinemasTableAdapter = new Artem.bd3DataSetTableAdapters.CinemasTableAdapter();
            this.choiceHallAndDatesTableAdapter = new Artem.bd3DataSet1TableAdapters.ChoiceHallAndDatesTableAdapter();
            this.datesTableAdapter = new Artem.bd3DataSet2TableAdapters.DatesTableAdapter();
            this.priceFilmsTableAdapter = new Artem.bd3DataSet3TableAdapters.PriceFilmsTableAdapter();
            this.placesTableAdapter = new Artem.bd3DataSet4TableAdapters.PlacesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.NameFilm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd3DataSet5 = new Artem.bd3DataSet5();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Artem.bd3DataSet5TableAdapters.TicketsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceHallAndDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFilm,
            this.duration,
            this.genre});
            this.dataGridView1.DataSource = this.cinemasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(385, 494);
            this.dataGridView1.TabIndex = 1;
            // 
            // NameFilm
            // 
            this.NameFilm.DataPropertyName = "NameFilm";
            this.NameFilm.HeaderText = "Фильмы";
            this.NameFilm.Name = "NameFilm";
            this.NameFilm.ReadOnly = true;
            this.NameFilm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameFilm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Продолжительность";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataMember = "Cinemas";
            this.cinemasBindingSource.DataSource = this.bd3DataSet;
            // 
            // bd3DataSet
            // 
            this.bd3DataSet.DataSetName = "bd3DataSet";
            this.bd3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Забронировать билеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hall,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.DataSource = this.choiceHallAndDatesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(441, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(404, 111);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            // 
            // Hall
            // 
            this.Hall.DataPropertyName = "Hall";
            this.Hall.HeaderText = "Зал";
            this.Hall.Name = "Hall";
            this.Hall.ReadOnly = true;
            this.Hall.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hall.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Date";
            this.Column1.DataSource = this.datesBindingSource;
            dataGridViewCellStyle1.NullValue = "10:00";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.DisplayMember = "DateSelect";
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Выберите дату сеанса";
            this.Column1.ValueMember = "DateSelect";
            // 
            // datesBindingSource
            // 
            this.datesBindingSource.DataMember = "Dates";
            this.datesBindingSource.DataSource = this.bd3DataSet2;
            // 
            // bd3DataSet2
            // 
            this.bd3DataSet2.DataSetName = "bd3DataSet2";
            this.bd3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Price";
            this.Column2.DataSource = this.priceFilmsBindingSource;
            dataGridViewCellStyle2.NullValue = "120 руб.";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.DisplayMember = "PriceFilmSelect";
            this.Column2.HeaderText = "Стоимость";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Выберите стоимость билета";
            // 
            // priceFilmsBindingSource
            // 
            this.priceFilmsBindingSource.DataMember = "PriceFilms";
            this.priceFilmsBindingSource.DataSource = this.bd3DataSet3;
            // 
            // bd3DataSet3
            // 
            this.bd3DataSet3.DataSetName = "bd3DataSet3";
            this.bd3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Place";
            this.Column3.DataSource = this.placesBindingSource;
            dataGridViewCellStyle3.NullValue = "1";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.DisplayMember = "PlaceSelect";
            this.Column3.HeaderText = "Место";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Выберите место";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.bd3DataSet4;
            // 
            // bd3DataSet4
            // 
            this.bd3DataSet4.DataSetName = "bd3DataSet4";
            this.bd3DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choiceHallAndDatesBindingSource
            // 
            this.choiceHallAndDatesBindingSource.DataMember = "ChoiceHallAndDates";
            this.choiceHallAndDatesBindingSource.DataSource = this.bd3DataSet1;
            // 
            // bd3DataSet1
            // 
            this.bd3DataSet1.DataSetName = "bd3DataSet1";
            this.bd3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Режим редактирования фильмов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cinemasTableAdapter
            // 
            this.cinemasTableAdapter.ClearBeforeFill = true;
            // 
            // choiceHallAndDatesTableAdapter
            // 
            this.choiceHallAndDatesTableAdapter.ClearBeforeFill = true;
            // 
            // datesTableAdapter
            // 
            this.datesTableAdapter.ClearBeforeFill = true;
            // 
            // priceFilmsTableAdapter
            // 
            this.priceFilmsTableAdapter.ClearBeforeFill = true;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Показать билеты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFilm1,
            this.Column5,
            this.Column4,
            this.Hall1,
            this.Column6,
            this.duration1,
            this.genre1});
            this.dataGridView3.Location = new System.Drawing.Point(441, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(648, 291);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.Visible = false;
            // 
            // NameFilm1
            // 
            this.NameFilm1.HeaderText = "Фильм";
            this.NameFilm1.Name = "NameFilm1";
            this.NameFilm1.ReadOnly = true;
            this.NameFilm1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameFilm1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата сеанса";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hall1
            // 
            this.Hall1.HeaderText = "Зал";
            this.Hall1.Name = "Hall1";
            this.Hall1.ReadOnly = true;
            this.Hall1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hall1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Место";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // duration1
            // 
            this.duration1.HeaderText = "Продолжительность";
            this.duration1.Name = "duration1";
            this.duration1.ReadOnly = true;
            this.duration1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.duration1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // genre1
            // 
            this.genre1.HeaderText = "Жанр";
            this.genre1.Name = "genre1";
            this.genre1.ReadOnly = true;
            this.genre1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genre1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bd3DataSet5
            // 
            this.bd3DataSet5.DataSetName = "bd3DataSet5";
            this.bd3DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.bd3DataSet5;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список фильмов";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(753, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Удалить билет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(597, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 31);
            this.button5.TabIndex = 10;
            this.button5.Text = "Показать мои билеты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(711, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кинотеатр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1137, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Кинотеатр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceHallAndDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private bd3DataSet bd3DataSet;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
        private bd3DataSetTableAdapters.CinemasTableAdapter cinemasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private bd3DataSet1 bd3DataSet1;
        private System.Windows.Forms.BindingSource choiceHallAndDatesBindingSource;
        private bd3DataSet1TableAdapters.ChoiceHallAndDatesTableAdapter choiceHallAndDatesTableAdapter;
        private bd3DataSet2 bd3DataSet2;
        private System.Windows.Forms.BindingSource datesBindingSource;
        private bd3DataSet2TableAdapters.DatesTableAdapter datesTableAdapter;
        private bd3DataSet3 bd3DataSet3;
        private System.Windows.Forms.BindingSource priceFilmsBindingSource;
        private bd3DataSet3TableAdapters.PriceFilmsTableAdapter priceFilmsTableAdapter;
        private bd3DataSet4 bd3DataSet4;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private bd3DataSet4TableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private bd3DataSet5 bd3DataSet5;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private bd3DataSet5TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}

