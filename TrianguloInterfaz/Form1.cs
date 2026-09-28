namespace TrianguloInterfaz
{
    public partial class Form1 : Form
    {
        private Triangulo triangulo = new Triangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool LeerDatos()
        {
            if (float.TryParse(textAltura.Text, out float h) &&
                float.TryParse(textBase.Text, out float b) &&
                h > 0 && b > 0)
            {
                triangulo.Altura = h;
                triangulo.Base = b;
                return true;
            }
            MessageBox.Show("Ingresa altura y base con números mayores a 0.");
            return false;
        }

        private void botonArea_Click(object sender, EventArgs e)
        {
            if (LeerDatos())
                textResultado.Text = triangulo.Area().ToString("F2");
        }

        private void botonPerimetro_Click(object sender, EventArgs e)
        {
            if (LeerDatos())
                textResultado.Text = triangulo.Perimetro().ToString("F2");
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textAltura.Clear();
            textBase.Clear();
            textResultado.Clear();
            textAltura.Focus();
        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Close();        }
    }
}