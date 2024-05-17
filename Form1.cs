namespace pryPeriottiEtapa3
{
    public partial class Form1 : Form
    {
        clsVehiculo objVehiculo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearVhiculo_Click(object sender, EventArgs e)
        {
            string Nombre;
            string Tipo;
            if (rbAuto.Checked)
            {
                objVehiculo = new clsVehiculo();
                objVehiculo.crearAuto();
                objVehiculo.imgAuto.Location = new Point(90, 10);
                Controls.Add(objVehiculo.imgAuto);
                Nombre = lblNombre.Text;
                Tipo = lblTipo.Text;
                lblNombre.Text = "Zentorno";
                lblTipo.Text = "Auto";
            }
            else if (rbMoto.Checked)
            {
                objVehiculo.imgAuto.Dispose();
                objVehiculo = new clsVehiculo();
                objVehiculo.crearMoto();
                objVehiculo.imgMoto.Location = new Point(90, 10);
                Controls.Add(objVehiculo.imgMoto);
                Nombre = lblNombre.Text;
                Tipo = lblTipo.Text;
                lblNombre.Text = "Bati-801";
                lblTipo.Text = "Moto";
            }
            else if (rbAvion.Checked)
            {
                objVehiculo.imgMoto.Dispose();
                objVehiculo = new clsVehiculo();
                objVehiculo.crearAvion();
                objVehiculo.imgAvion.Location = new Point(90, 10);
                Controls.Add(objVehiculo.imgAvion);
                Nombre = lblNombre.Text;
                Tipo = lblTipo.Text;
                lblNombre.Text = "Besra";
                lblTipo.Text = "Avion";
            }
        }


    }
}
