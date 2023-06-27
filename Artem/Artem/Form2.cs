using System;
using System.Windows.Forms;
using ClassLibrary2;

namespace Artem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SizeColumns();
            FilmTable();
        }
        public void SizeColumns()
        {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 120;
        }
        public void FilmTable()
        {
            using (UserContext db = new UserContext())
            {
                var films = db.Films;

                int i = 0;
                foreach (Cinema d in films)
                {
                    if (d != null)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["NameFilm"].Value = d.NameFilm;
                        dataGridView1.Rows[i].Cells["duration"].Value = d.duration;
                        dataGridView1.Rows[i].Cells["genre"].Value = d.genre;
                    }
                    i++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                dataGridView1.Rows.Add();
                Cinema film = new Cinema { NameFilm = "", duration = "", genre = "" };
                db.Films.Add(film);
                db.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = dataGridView1.CurrentRow.Index + 1;
            int i = 0;
            using (UserContext db = new UserContext())
            {
                var films = db.Films;
                i = 0;
                foreach (Cinema d in films)
                {
                    if (s == i + 1)
                    {
                        db.Films.Remove(d);
                    }
                    i++;
                }
                db.SaveChanges();
                dataGridView1.Rows.RemoveAt(s - 1);
                dataGridView1.Refresh();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                var films = db.Films;
                int i = 0;
                foreach (Cinema d in films)
                {
                    if (dataGridView1.Rows[i].Cells["NameFilm"].Value != null)
                        d.NameFilm = dataGridView1.Rows[i].Cells["NameFilm"].Value.ToString();
                    else d.NameFilm = "";
                    if (dataGridView1.Rows[i].Cells["duration"].Value != null)
                        d.duration = dataGridView1.Rows[i].Cells["duration"].Value.ToString();
                    else d.duration = "";
                    if (dataGridView1.Rows[i].Cells["genre"].Value != null)
                        d.genre = dataGridView1.Rows[i].Cells["genre"].Value.ToString();
                    else d.genre = "";
                    i++;
                }
                db.SaveChanges();
            }
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
