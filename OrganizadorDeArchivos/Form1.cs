using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace OrganizadorDeArchivos
{
    public partial class Form1 : Form
    {
        private string rutaOrigen = "";
        private List<string> archivos;
        string comando = "";
        Thread t;
        const string pattern = @"\bdesktop\.ini\b";
        public Form1()
        {
            InitializeComponent();
        }
        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            if (archivos != null && archivos.Count > 0)
            {
                foreach (string archivo in archivos)
                {
                    listBox1.Items.Add(Path.GetFileName(archivo));
                }
            }
        }
        private void LlamarComando()
        {
            ExecuteCommand(comando);
        }
        public void ExecuteCommand(string comand)
        {
            // Crear un proceso de la l�nea de comandos
            Process cmdProcess = new Process();

            // Configurar las propiedades del proceso
            cmdProcess.StartInfo.FileName = "cmd.exe"; // El ejecutable de la l�nea de comandos
            cmdProcess.StartInfo.RedirectStandardInput = true; // Redirigir la entrada est�ndar
            cmdProcess.StartInfo.RedirectStandardOutput = true; // Redirigir la salida est�ndar
            cmdProcess.StartInfo.UseShellExecute = false; // No utilizar el shell de Windows
            cmdProcess.StartInfo.CreateNoWindow = true; // No crear una ventana para el proceso

            // Iniciar el proceso
            cmdProcess.Start();

            // Obtener el flujo de entrada est�ndar del proceso
            var standardInput = cmdProcess.StandardInput;

            // Ejecutar comandos en la l�nea de comandos
            standardInput.WriteLine(comand);

            // Cerrar la entrada est�ndar para indicar que no se enviar�n m�s comandos
            standardInput.Close();

            // Leer la salida est�ndar del proceso
            string output = cmdProcess.StandardOutput.ReadToEnd();

            // Esperar a que el proceso termine
            cmdProcess.WaitForExit();

            // Mostrar la salida en la consola de C#

            this.comando = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rutaOrigen = dialog.SelectedPath;

                // Actualiza el ListBox con los nombres de los archivos
                archivos = new List<string>(Directory.GetFiles(rutaOrigen));
                ActualizarListBox();
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string extension = "";
            string carpetaDestino = "";
            string nomArchivo = "";
            string rutaDestino = "";
            if (archivos == null || archivos.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una carpeta antes de ordenar los archivos.",
                    "Carpeta no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                foreach (string archivo in archivos)
                {

                    if (Regex.IsMatch(archivo, pattern))
                    {
                    }
                    extension = Path.GetExtension(archivo);
                    carpetaDestino = Path.Combine(rutaOrigen, "Otros");
                    carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                    checkDirectoryExist(carpetaDestino);
                    if (extension.ToLower() == ".docx" || extension.ToLower() == ".xlsx" || extension.ToLower() == ".pptx" || extension.ToLower() == ".doc")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Office");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);

                    }
                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png" || extension.ToLower() == ".gif" || extension.ToLower() == ".jfif" || extension.ToLower() == ".webp" || extension.ToLower() == ".wbmp" || extension.ToLower() == ".raw" || extension.ToLower() == ".psd"
                            || extension.ToLower() == ".tiff" || extension.ToLower() == ".eps")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Imagenes");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);
                    }

                    if (extension.ToLower() == ".mp4" || extension.ToLower() == ".avi" || extension.ToLower() == ".mkv" || extension.ToLower() == ".mov" || extension.ToLower() == ".wmv" || extension.ToLower() == ".flv" || extension.ToLower() == ".webm" || extension.ToLower() == ".mpg" || extension.ToLower() == ".3gp")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Videos");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);
                    }

                    if (extension.ToLower() == ".zip" || extension.ToLower() == ".rar" || extension.ToLower() == ".7z" || extension.ToLower() == ".tar" || extension.ToLower() == ".gz" || extension.ToLower() == ".bz2" || extension.ToLower() == ".xz" || extension.ToLower() == ".cab" || extension.ToLower() == ".z"
                            || extension.ToLower() == ".iso")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Comprimido");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);
                    }

                    if (extension.ToLower() == ".exe" || extension.ToLower() == ".app" || extension.ToLower() == ".dmg" || extension.ToLower() == ".bin" || extension.ToLower() == ".bat" || extension.ToLower() == ".sh" || extension.ToLower() == ".jar" || extension.ToLower() == ".apk" || extension.ToLower() == ".msi"
                            || extension.ToLower() == ".cmd")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Ejecutables");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);
                    }

                    if (extension.ToLower() == ".mp3" || extension.ToLower() == ".wav" || extension.ToLower() == ".flac" || extension.ToLower() == ".aac" || extension.ToLower() == ".ogg" || extension.ToLower() == ".wma" || extension.ToLower() == ".aiff" || extension.ToLower() == ".m4a" || extension.ToLower() == ".mid"
                                            || extension.ToLower() == ".opus")
                    {
                        carpetaDestino = Path.Combine(rutaOrigen, "Música");
                        carpetaDestino = Path.Combine(carpetaDestino, extension.TrimStart('.'));
                        checkDirectoryExist(carpetaDestino);
                    }                  

                    nomArchivo = Path.GetFileName(archivo);
                    rutaDestino = Path.Combine(carpetaDestino, nomArchivo);
                    moveFile(rutaDestino, nomArchivo, carpetaDestino, archivo);
                }

                MessageBox.Show("Los archivos se han ordenado exitosamente.", "Ordenamiento completado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error al intentar ordenar los archivos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarListBox();
        }

        private void moveFile(string path, string nomArchivo, string carpetaDestino, string archivo)
        {
            bool existio = false;
            string nombreAntiguo = nomArchivo;
            while (File.Exists(path))
            {
                existio = true;
                nomArchivo = nomArchivo.Replace(".", "1.");
                path = Path.Combine(carpetaDestino, nomArchivo);
                File.Move(archivo, Path.Combine(rutaOrigen, nomArchivo));
                archivo = archivo.Replace(".", "1.");
            }
            if (existio)
            {
                listBox2.Items.Add(nombreAntiguo + " -> " + Path.GetFileName(archivo));
            }
            File.Move(archivo, Path.Combine(carpetaDestino, nomArchivo));
        }

        private void checkDirectoryExist(string path)
        {
            if (!(Directory.Exists(path)))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void Attrib_Click(object sender, EventArgs e)
        {
            try
            {
                if ((rutaOrigen.Length > 0))
                {
                    comando = rutaOrigen[0] + rutaOrigen[1] + "\n" + "cd " + "\"" + rutaOrigen + "\"" + "\n" + "attrib -s -h -r /s /d *.*" + "\n";
                    if (comando.Contains("126"))
                    {
                        comando = comando.Replace("126", "");
                    }
                    t = new Thread(LlamarComando);
                    t.Start();
                    MessageBox.Show("COMANDO ATTRIB EJECUTANDOSE", "INFORMACI�N", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona una ruta primero");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HUBO UN ERROR XD");
            }
        }
    }
}
