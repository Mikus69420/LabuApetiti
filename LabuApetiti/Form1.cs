using System.Windows.Forms;

namespace LabuApetiti
{
    public partial class Form1 : Form
    {
        private const string DbName = "Produkti.db";

        public Form1()
        {
            InitializeComponent();

            //Ja konfigurācijas failā pirmo reizi nav noradīts DB faila ceļš, to piesķir failam mapē MyDocuments
            if (string.IsNullOrWhiteSpace(Settings1.Default.Path))
            {
                Settings1.Default.Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DbName);
                Settings1.Default.Save();
            }
            //Ja konfigurācijas ceļā norādītais DB fails eksistē, to atver
            if (File.Exists(Settings1.Default.Path))
            {
                dataSet11.ReadXml(Settings1.Default.Path);
            }

            FormClosing += Form1_FormClosing;
        }

        //Saglabā datus DB failā aizverot programmu
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            dataSet11.WriteXml(Settings1.Default.Path);
        }

        //Menu pogas "Atvērt DB failu" notikuma apstrāde
        private void miOpenDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "DB Files|*.db;" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Saglabā konfigurācijas failā DB faila adresi
                Settings1.Default.Path = openFileDialog.FileName;
                Settings1.Default.Save();
                dataSet11.ReadXml(openFileDialog.FileName);
            }
        }

        //Menu pogas "Saglabāt DB failu kā ..." notikuma apstrāde
        private void miSaveDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "DB Files|*.db;" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSet11.WriteXml(saveFileDialog.FileName);
            }
        }

        //Menu pogas "Beigt darbu" notikuma apstrāde
        private void beigtDarbuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Apreķina pirkuma summu, ja mainīta Cenas vai Daudzuma lauka vērtība
        private void dgvIepirkumi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvIepirkumi.Rows[e.RowIndex].Cells["colSumma"].Value =
                    (Decimal)dgvIepirkumi.Rows[e.RowIndex].Cells["colCena"].Value *
                    (Decimal)dgvIepirkumi.Rows[e.RowIndex].Cells["colDaudzums"].Value;
            }
        }
    }
}
