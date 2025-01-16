namespace ProgettoTPS_sistema_prenotazione_sale_chirurgiche_
{
    public partial class Form1 : Form
    {
        SalaInvasiva salainvasiva;
        SalaSpecializzata salaspecializzata;
        SalaGenerale salagenerale;
        bool prenota;
        List<Prenotazione> prenotazioni;
        DateTime data_salagenerale;
        DateTime data_salaspecializzata;
        DateTime data_salainvasiva;
        Semaphore semaforo;
        Queue<DateTime> coda;
        Thread prenotare_salagenerale;
        Thread prenotare_salainvasiva;
        Thread prenotare_salaspecializzata;
        public Form1()
        {
            InitializeComponent();
            salainvasiva = new SalaInvasiva("salainvasiva");
            prenotazioni = new List<Prenotazione>();
            salaspecializzata = new SalaSpecializzata("salaspecializzata");
            salagenerale = new SalaGenerale("salagenerale");
            semaforo = new Semaphore(1,1); //Permette solo un thread alla volta
            coda= new Queue<DateTime>();
            prenotare_salagenerale =new Thread(Thread_salagenerale);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("SALA GENERALE");
            comboBox2.Items.Add("SALA SPECIALIZZATA");
            comboBox2.Items.Add("SALA INVASIVA");

            comboBox1.Items.Add("MOLTO URGENTE");
            comboBox1.Items.Add("URGENTE");
            comboBox1.Items.Add("NORMALE");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            prenota = true;
            DateTime data_nonvalida = new DateTime(1, 1, 1);
            if (comboBox2.SelectedIndex == 0 && data_salagenerale != data_nonvalida)
            {
                coda.Enqueue(data_salagenerale);
                ThreadPool.QueueUserWorkItem(Thread_salagenerale);
            }
            else
                if (comboBox2.SelectedIndex == 1 && data_salaspecializzata != data_nonvalida)
            {
                salaspecializzata.prenotazionii.Add(data_salaspecializzata);
                salaspecializzata.prenotazioni.Add(data_salaspecializzata);
                Prenotazione appuntamento = new Prenotazione(data_salaspecializzata, textBox1.Text);
                prenotazioni.Add(appuntamento);
            }
            else
            {
                if (data_salainvasiva != data_nonvalida)
                {
                    salainvasiva.prenotazionii.Add(data_salainvasiva);
                    salainvasiva.prenotazioni.Add(data_salainvasiva);
                    Prenotazione appuntamento = new Prenotazione(data_salainvasiva, textBox1.Text);
                    prenotazioni.Add(appuntamento);
                }
            }
            /* for (int i = 0; i < prenotazioni.Count; i++)
             {
                 MessageBox.Show(prenotazioni[i].Data.ToString(), prenotazioni[i].Chirurgico);
             }*/

        }
        private void Thread_salagenerale(object state)
        {
            semaforo.WaitOne();
            try
            {
                DateTime primarichiesta = coda.Dequeue();
                salagenerale.prenotazionii.Add(primarichiesta);
                salagenerale.prenotazioni.Add(primarichiesta);
                Prenotazione appuntamento = new Prenotazione(primarichiesta, textBox1.Text);
                prenotazioni.Add(appuntamento);
            }
            finally
            {
                semaforo.Release();
            }
            /*salagenerale.prenotazionii.Add(data_salagenerale);
            salagenerale.prenotazioni.Add(data_salagenerale);
            Prenotazione appuntamento = new Prenotazione(data_salagenerale, textBox1.Text);
            prenotazioni.Add(appuntamento);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                    data_salagenerale = salagenerale.DataUrgentissima();
                else
                    if (comboBox1.SelectedIndex == 1)
                    data_salagenerale = salagenerale.DataUrgente();
                else
                    if (comboBox1.SelectedIndex == 2)
                    data_salagenerale = salagenerale.DataNormale();
                salagenerale.stampa();
            }
            else
                if (comboBox2.SelectedIndex == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                    data_salaspecializzata = salaspecializzata.DataUrgentissima();
                else
                    if (comboBox1.SelectedIndex == 1)
                    data_salaspecializzata = salaspecializzata.DataUrgente();
                else
                        if (comboBox1.SelectedIndex == 2)
                    data_salaspecializzata = salaspecializzata.DataNormale();
                salaspecializzata.stampa();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                    data_salainvasiva = salainvasiva.DataUrgentissima();
                else
                    if (comboBox1.SelectedIndex == 1)
                    data_salainvasiva = salainvasiva.DataUrgente();
                else
                         if (comboBox1.SelectedIndex == 2)
                    data_salainvasiva = salainvasiva.DataNormale();
                salainvasiva.stampa();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime data_nonvalida = new DateTime(1, 1, 1);
            if (comboBox2.SelectedIndex == 0 && data_salagenerale != data_nonvalida)
            {
                MessageBox.Show(data_salagenerale.ToString());
                salagenerale.altredate.Add(data_salagenerale);
                button1_Click(sender, e);
            }
            else
                if (comboBox2.SelectedIndex == 1 && data_salaspecializzata != data_nonvalida)
            {
                MessageBox.Show(data_salaspecializzata.ToString());
                salaspecializzata.altredate.Add(data_salaspecializzata);
                button1_Click(sender, e);
            }
            else
            {
                if (data_salainvasiva != data_nonvalida)
                {
                    MessageBox.Show(data_salainvasiva.ToString());
                    salainvasiva.altredate.Add(data_salainvasiva);
                    button1_Click(sender, e);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text= "seleziona un grado ";
           textBox2.Text= " ";
            comboBox2.Text= "seleziona una sala";
            salagenerale.altredate.Clear();
            salaspecializzata.altredate.Clear();
            salainvasiva.altredate.Clear();
        }
    }
}
