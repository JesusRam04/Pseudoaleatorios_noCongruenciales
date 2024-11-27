using Pseudoaleatorios_noCongruenciales.Algoritmos;

namespace Pseudoaleatorios_noCongruenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") ||
                    (textBox2.Text == "") ||
                    (textBox3.Text == ""))
            {
                MessageBox.Show("Los números tienen que ser diferente de VACÍOS");
                return;
            }
            int seed1 = Convert.ToInt32(textBox1.Text);
            int seed2 = Convert.ToInt32(textBox2.Text);
            int cantidad = Convert.ToInt32(textBox3.Text);

            if (seed1 <= 0 || seed2 <= 0 || cantidad <= 0)
            {
                MessageBox.Show("Todos los numeros tienen que ser enteros positivos diferentes a 0");
                return;
            }

            List<int> values = new List<int>();
            ProductoMedio aleatorios = new ProductoMedio();
            values = aleatorios.GetValues(seed1, seed2, cantidad);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;
                    aleatorios.EscribirEnCSV(values, rutaArchivo);
                    MessageBox.Show($"La simulación se ha guardado en {rutaArchivo}");
                }
            }
        }
    }
}
