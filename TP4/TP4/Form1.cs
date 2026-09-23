using System.Linq.Expressions;

namespace TP4 {
    public partial class Form1 : Form {

        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            MessageBox.Show("Antes de cargar un  vehiculo seleccione su tipo", "campo requerido", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void btnCargar_Click(object sender, EventArgs e) {
            string marca = textMarca.Text;
            string mod = textModelo.Text;
            string pat = textPatente.Text;
            string anio = textAnio.Text;
            string kilom = textKilometros.Text;
            string prec = textPrecio.Text;
            string detalle = textDetalle.Text;
            string tipo = string.Empty;
            if (checkAuto.Checked) {
                tipo = "a";
            }
            else {
                tipo = "m";
            }

            try {
                cargarLista(ValidarFormulario(marca, mod, pat, anio, kilom, prec, detalle, tipo));
                MessageBox.Show($"Vehiculo cargado exitosamente", "exitoso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error de carga de vehculo \n {ex.Message}", "error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
        private void checkAuto_CheckedChanged(object sender, EventArgs e) {
            checkMoto.Checked = false;
            lblDetalle.Text = "Numero de puertas";
        }
        private void checkMoto_CheckedChanged(object sender, EventArgs e) {
            checkAuto.Checked = false;
            lblDetalle.Text = "Cilindrada";
        }
        private Vehiculo ValidarFormulario(string mar, string mod, string pat, string anio, string kilom, string prec, string detal, string tipo) {
            int anos, km, detalle;
            decimal presio;

            if (string.IsNullOrWhiteSpace(mar)) {
                throw new ArgumentException("la marca no puede estar vacia");
            }
            if (string.IsNullOrWhiteSpace(mod)) {
                throw new ArgumentException("el modelo no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(pat)) {
                throw new ArgumentException("la patente no puede estar vacio");
            }
            if (int.TryParse(kilom, out km)) {
            }
            else {
                throw new ArgumentException("los kilometros deben ser un numero entero");
            }
            if (int.TryParse(anio, out anos)) {
            }
            else {
                throw new ArgumentException("el año debe ser un numero entero");
            }
            if (tipo == "a") {
                if (int.TryParse(detal, out detalle)) {
                }
                else {
                    throw new ArgumentException("el nnumero de puertas debe ser un entero");
                }
            }
            else {
                if (int.TryParse(detal, out detalle)) {
                }
                else {
                    throw new ArgumentException("la cilindrada debe ser un numero entero");
                }
            }
            
            if (decimal.TryParse(prec, out presio)) {
            }
            else {
                throw new ArgumentException("el precio debe ser un numero decimal");
            }
            if (tipo == "a") {
                Moto veiculo = new Moto(mar, mod, pat, anos, km, presio, detalle);
                return veiculo;
            }
            else {
                Auto veiculo = new Auto(mar, mod, pat, anos, km, presio, detalle);
                return veiculo;
            }
        }
        private void cargarLista( Vehiculo vehi) {
            if (vehiculos.Count() == 0 ) {
                vehiculos.Add(vehi);
            }
            else {
                foreach(Vehiculo veiculo in vehiculos) {
                    if(veiculo.Patente == vehi.Patente) {
                        throw new Exception($"el vehiculo con la patente{vehi.Patente} ya existe");
                    }
                    else {
                        vehiculos.Add(vehi);
                        return;
                    }
                }
            }
        }
        
        

    }
}
