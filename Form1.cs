namespace Mo_telepulesei_GUI
{
    public partial class Form1 : Form
    {
        List<Telepules> telepulesek = new List<Telepules>();
        class Telepules
        {
            public string Helyseg { get; set; }
            public string Jogallas { get; set; }
            public string Megye { get; set; }
            public string Megyeszekhely { get; set; }
            public int Terulet_ha { get; set; }
            public int Nepesseg { get; set; }
            public int Lakasok_szama { get; private set; }
            public int Iranyitoszam { get; set; }
            public Telepules(string s)
            {
                string[] tmp = s.Split(";");
                Helyseg = tmp[0];
                Jogallas = tmp[1];
                Megye = tmp[2];
                Megyeszekhely = tmp[3];
                Terulet_ha = int.Parse(tmp[4]);
                Nepesseg = int.Parse(tmp[5]);
                Lakasok_szama = int.Parse(tmp[6]);
                Iranyitoszam = int.Parse(tmp[7]);
            }
        }
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = File.OpenText("mo_telepulesei.txt");

            while (!sr.EndOfStream) telepulesek.Add(new Telepules(sr.ReadLine()));
            int n = telepulesek.Count;
            toolStripStatusLabel1.Text = n.ToString() + " település";
            int terulet = 0; int nepesség = 0;
            foreach (var i in telepulesek)
            {
                terulet += i.Terulet_ha;
                nepesség += i.Nepesseg;
            }
            toolStripStatusLabel2.Text = "Összterület: " + (terulet / 100).ToString() + " km2";
            toolStripStatusLabel3.Text = "Összlakosság: " + nepesség.ToString() + " fõ";
            HashSet<string> megyek = new HashSet<string>();
            foreach (var i in telepulesek) megyek.Add(i.Megye);
            foreach (var i in megyek) comboBox1.Items.Add(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            comboBox2.Visible = true;
            label21.Visible = true;
            string megye = comboBox1.Text;
            int sz = 0;
            foreach (var i in telepulesek)
            {
                if (i.Megye == megye)
                {
                    comboBox2.Items.Add(i.Helyseg);
                    sz++;
                }
            }
            label21.Text = "Települések: (" + sz.ToString() + " db)";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varos = comboBox2.Text;
            foreach (var i in telepulesek)
            {
                if (i.Helyseg == varos)
                {
                    label19.Text = i.Helyseg;
                    label20.Text = i.Iranyitoszam.ToString();
                    label13.Text = i.Jogallas;
                    label14.Text = i.Megye;
                    label15.Text = i.Megyeszekhely;
                    label16.Text = i.Terulet_ha.ToString();
                    label17.Text = i.Nepesseg.ToString();
                    label18.Text = i.Lakasok_szama.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string keres = textBox1.Text;
            int szam; int szamol = 0;
            if (int.TryParse(keres, out szam))
            {
                foreach (var i in telepulesek)
                {
                    if (i.Iranyitoszam == szam)
                    {
                        listBox1.Items.Add(i.Helyseg);
                        szamol  ++;
                    }
                }
                if(szamol==0) listBox1.Items.Add("Nincs ilyen irányítószám!");
            }
            else 
            {
                int telszamol = 0;
                foreach (var i in telepulesek)
                {
                    if (i.Helyseg.ToLower().Contains(keres))
                    {
                        listBox1.Items.Add(i.Helyseg);
                        telszamol   ++;
                    }
                }
                if (telszamol == 0) listBox1.Items.Add("Nincs ilyen település!");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varos = listBox1.Text;
            foreach (var i in telepulesek )
            {
                if (i.Helyseg == varos)
                {
                    label19.Text = i.Helyseg;
                    label20.Text = i.Iranyitoszam.ToString();
                    label13.Text = i.Jogallas;
                    label14.Text = i.Megye;
                    label15.Text = i.Megyeszekhely;
                    label16.Text = i.Terulet_ha.ToString();
                    label17.Text = i.Nepesseg.ToString();
                    label18.Text = i.Lakasok_szama.ToString();
                }
            }
        }
    }
}
