using System;
using System.Windows.Forms;
using ClassLibrary2;

namespace Artem
{
    public partial class Form1 : Form
    {
        UserContext db = new UserContext();
        string[] ticket;
        public Form1()
        {
            InitializeComponent();
            //delete();
            //BdDataArray();
            SizeColumns();
        }
        public void delete()
        {
            using (UserContext db = new UserContext())
            {
                var films = db.Tickets;
                int i = 0;
                foreach (Ticket d in films)
                {
                    db.Tickets.Remove(d);
                    i++;
                }
                db.SaveChanges();
            }
        }
        public void SizeColumns()
        {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 120;
            dataGridView3.Columns[1].Width = 60;
            dataGridView3.Columns[3].Width = 60;
            dataGridView3.Columns[4].Width = 60;
            dataGridView3.Columns[5].Width = 130;
            dataGridView3.Columns[6].Width = 130;

        }
        public void BdDataArray()
        {
             using (UserContext db = new UserContext())
             {
                Date[] date = new Date[8];

                date[0] = new Date { DateSelect = "10:00" };
                date[1] = new Date { DateSelect = "10:50" };
                date[2] = new Date { DateSelect = "11:50" };
                date[3] = new Date { DateSelect = "12:30" };
                date[4] = new Date { DateSelect = "13:20" };
                date[5] = new Date { DateSelect = "14:40" };
                date[6] = new Date { DateSelect = "15:30" };
                date[7] = new Date { DateSelect = "16:20" };
                for (int i = 0; i < 8; i++)
                 {
                     db.Dates.Add(date[i]);
                 }
                 db.SaveChanges();
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Fill(this.bd3DataSet5.Tickets);
            this.placesTableAdapter.Fill(this.bd3DataSet4.Places);
            this.priceFilmsTableAdapter.Fill(this.bd3DataSet3.PriceFilms);
            this.datesTableAdapter.Fill(this.bd3DataSet2.Dates);
            this.choiceHallAndDatesTableAdapter.Fill(this.bd3DataSet1.ChoiceHallAndDates);
            this.cinemasTableAdapter.Fill(this.bd3DataSet.Cinemas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticket = new string[7];
            int s = dataGridView1.CurrentRow.Index;
            ticket[0] = dataGridView1.Rows[s].Cells["NameFilm"].Value.ToString();
            ticket[1] = dataGridView1.Rows[s].Cells["duration"].Value.ToString();
            ticket[2] = dataGridView1.Rows[s].Cells["genre"].Value.ToString();
            dataGridView3.Visible = false;
            dataGridView2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = dataGridView2.CurrentRow.Index;
            ticket[3] = dataGridView2.Rows[s].Cells["Hall"].Value.ToString();
            int a = dataGridView2.CurrentCell.RowIndex;
            ticket[4] = dataGridView2.Rows[a].Cells["Column1"].Value.ToString();
            int b = dataGridView2.CurrentCell.RowIndex;
            ticket[5] = dataGridView2.Rows[b].Cells["Column2"].Value.ToString();
            int c = dataGridView2.CurrentCell.RowIndex;
            ticket[6] = dataGridView2.Rows[c].Cells["Column3"].Value.ToString();
            Ticket tickets = new Ticket { NameFilm = ticket[0], PriceFilm = ticket[5], Date = ticket[4], Hall = ticket[3], Place = ticket[6], duration = ticket[1], genre = ticket[2] };
            db.Tickets.Add(tickets);
            db.SaveChanges();
            var films = db.Tickets;
            int i = 0;
            dataGridView3.Rows.Clear();
            foreach (Ticket d in films){
                    if (d != null)
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[i].Cells["NameFilm1"].Value = d.NameFilm;
                        dataGridView3.Rows[i].Cells["Column5"].Value = d.PriceFilm;
                        dataGridView3.Rows[i].Cells["Column4"].Value = d.Date;
                        dataGridView3.Rows[i].Cells["Hall1"].Value = d.Hall;
                        dataGridView3.Rows[i].Cells["Column6"].Value = d.Place;
                        dataGridView3.Rows[i].Cells["duration1"].Value = d.duration;
                        dataGridView3.Rows[i].Cells["genre1"].Value = d.genre;
                    }
                    i++;
             }
            dataGridView2.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
            dataGridView3.Visible = true;
            dataGridView3.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = dataGridView3.CurrentRow.Index + 1;
            int i = 0;
            var films = db.Tickets;
            i = 0;
            foreach (Ticket d in films)
                {
                    if (s == i + 1)
                    {
                        db.Tickets.Remove(d);
                    }
                    i++;
             }
                db.SaveChanges();
                dataGridView3.Rows.RemoveAt(s - 1);
                dataGridView3.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                var films = db.Tickets;
                int i = 0;
                dataGridView3.Rows.Clear();
                foreach (Ticket d in films)
                {
                    if (d != null)
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[i].Cells["NameFilm1"].Value = d.NameFilm;
                        dataGridView3.Rows[i].Cells["Column5"].Value = d.PriceFilm;
                        dataGridView3.Rows[i].Cells["Column4"].Value = d.Date;
                        dataGridView3.Rows[i].Cells["Hall1"].Value = d.Hall;
                        dataGridView3.Rows[i].Cells["Column6"].Value = d.Place;
                        dataGridView3.Rows[i].Cells["duration1"].Value = d.duration;
                        dataGridView3.Rows[i].Cells["genre1"].Value = d.genre;
                    }
                    i++;
            }
            dataGridView2.Visible = false;
            button3.Visible = false;
            dataGridView3.Visible = true;
            dataGridView3.Refresh();
        }
    }
}
