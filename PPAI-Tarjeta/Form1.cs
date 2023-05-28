namespace PPAI_Tarjeta
{
    public partial class Form1 : Form
    {
        Vista.PantallaRegistrarRespuesta pantalla;
        Controlador.GestorRegistrarRespuesta gestor;
        
        Modelo.Llamada llamda;
        public Form1()
        {
            //this.pantalla = new Vista.PantallaRegistrarRespuesta();

            InitializeComponent();
            //pantalla.Show();
            //Le paso la llamada al gestor y dejo que su metodo la asigne
            Modelo.CambioEstado estado = new Modelo.CambioEstado();
            List<Modelo.CambioEstado> listaEstado = new List<Modelo.CambioEstado>() { estado };
            Modelo.OpcionValidacion opVal = new Modelo.OpcionValidacion(false, "Gato");
            List<Modelo.OpcionValidacion> listaVal = new List<Modelo.OpcionValidacion>();
            listaVal.Add(opVal);
            Modelo.Validacion vali = new Modelo.Validacion("AudioValida", "Nombre valida", listaVal);
            List<Modelo.Validacion> listaVAlida = new List<Modelo.Validacion>();
            listaVAlida.Add(vali);
            Modelo.SubOpcionLlamada sub1 = new Modelo.SubOpcionLlamada("Tengo las datos de la tarjeta", 1);
            List<Modelo.SubOpcionLlamada> listaSub = new List<Modelo.SubOpcionLlamada>() { sub1 };
            Modelo.OpcionLlamada op = new Modelo.OpcionLlamada("Si desea informar un robo y solicitar nueva tarjeta", 1, "Nueva Tarjeta", 1, listaSub);
            
            Modelo.OpcionValidacion op2 = new Modelo.OpcionValidacion(true, "07/02/2004");
            Modelo.OpcionValidacion op4 = new Modelo.OpcionValidacion(true, "5000");
            Modelo.InformacionCliente info1 = new Modelo.InformacionCliente("Fecha de nacimiento",vali,op2);
            Modelo.InformacionCliente info2 = new Modelo.InformacionCliente("Codigo Postal",vali,op4);
            
            List<Modelo.InformacionCliente> listaInfo = new List<Modelo.InformacionCliente>() { info1, info2 };
            Modelo.Cliente clie = new Modelo.Cliente(1231231, "Pepe Argento", 12314134,listaInfo);
            this.llamda = new Modelo.Llamada("Juan Perez", "Registrar robo", TimeSpan.Zero, false, "", listaEstado, clie,op, sub1);
            this.gestor = new Controlador.GestorRegistrarRespuesta(llamda,pantalla);
           
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}