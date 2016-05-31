using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPYPRO
{
    public partial class FormularioOpaco : Form
    {
        public string ostipo = "";
        public bool SistemaOperativo;
        public StringBuilder archivoGenerado;
        //Creamos el escritor de archivos y damos la ruta, nombre del archivo y modo de creado
        FileStream archivoGeneradoA;
        string directorio1;

        public FormularioOpaco()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//Codigo para boton salir
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Button bsalirSub = new Button();
            Label Titulo_SubFormulario = new Label();
            Label Informacion = new Label();
            Form Subformulario = new Form();
            //  datos del boton salir
            bsalirSub.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            bsalirSub.Location = new Point(585, 10);
            bsalirSub.Name = "bsalirSub";
            bsalirSub.Size = new System.Drawing.Size(45, 25);
            bsalirSub.Text = "X";
            bsalirSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            bsalirSub.FlatStyle = FlatStyle.Flat;
            //  datos del label titulo
            Titulo_SubFormulario.Name = "Titulo_SubFormulario";
            Titulo_SubFormulario.Text = "I N F O R M A C I O N";
            Titulo_SubFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            Titulo_SubFormulario.Size = new Size(400, 25);//Tamaño del label
            Titulo_SubFormulario.Location = new Point(320 - (Titulo_SubFormulario.Width / 2), 10);//localizacion del label en el formulario
            Titulo_SubFormulario.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            //  datos del label Informacion
            Informacion.Name = "Informacion";
            Informacion.Text = "INSTRUCCIONES DE USO: "+
                "\nLocalice la informacion que desea escribir desde un archivo, pagina web, "
                +"u otro programa, a continuación abra el programa COPYPRO y escriba dentro de la caja de "
                + "texto y al final copie y pegue lo escrito en su editor favorito."
                + "\nAl presionar el boton ExportarTXT se crea un archivo de texto multiple con el historial "
                + "del contenido de la caja de texto."
                + "\n\nSOFTWARE DE ESCRITURA RAPIDA"
            + "\n\nSOFTWARE CREADO POR:\nJUANCARLOS DIAZ MONTIEL\nESTUDIANTE INGENIERIA CIVIL" +
            "\nUNIVERSIDAD DE SUCRE\n2016\nCEL: 3016922644\nCORREO: jucadimon@hotmail.com\nWEB: " +
            "http://ingenieria-civil-y-pi.blogspot.com.co/ ";
            Informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            Informacion.Size = new Size(580, 380);//Tamaño del label
            Informacion.Location = new Point(40, 35);//localizacion del label en el formulario
            Informacion.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            //  datos de la ventana
            Subformulario.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            Subformulario.ClientSize = new System.Drawing.Size(640, 480);
            Subformulario.Opacity = .85;
            Subformulario.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
            Subformulario.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
            Subformulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
            Subformulario.Name = "Subformulario";
            Subformulario.Text = "SUB VENTANA X 1.0";
            Subformulario.CancelButton = bsalirSub;
            Subformulario.StartPosition = FormStartPosition.CenterScreen;
            //
            Subformulario.Controls.Add(bsalirSub);
            Subformulario.Controls.Add(Titulo_SubFormulario);
            Subformulario.Controls.Add(Informacion);
            //
            Subformulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //          EXPORTAR TXT 
            ostipo = Environment.OSVersion.ToString();//saber el sistema operativo que se usa
            SistemaOperativo = ostipo.Contains("Unix");
            
            archivoGenerado = new StringBuilder();//Definimos un comodin estatico
            // string fecha = "";
            // fecha = DateTime.Now.ToString();    //pedimos la hora al sistema y almacenamos en fecha
            
            archivoGenerado.AppendLine(txtCaja.Text);//añadimos la fecha al comodin

			String reg = "";    //creamos un objeto tipo String del espacio de nombres Text
            reg = archivoGenerado.ToString();    //convertimos el comodin a texto
            
            if (SistemaOperativo)
            {
                directorio1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/texto.txt";
                // string directorio2 = Environment.CurrentDirectory + "/texto"+fecha+".txt";
            }
            else
            {
                directorio1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\texto.txt";
                // string directorio2 = Environment.CurrentDirectory + "\\texto"+fecha+".txt";
            }

            archivoGeneradoA = new FileStream(directorio1, FileMode.Append);
            archivoGeneradoA.Write(ASCIIEncoding.ASCII.GetBytes(reg), 0, reg.Length);//escribimos dentro del archivo
            archivoGeneradoA.Close();//Cerra el archivo creado

            MessageBox.Show("Exportación correcta! Revise el archivo en su escritorio.");
        }
    }
}
