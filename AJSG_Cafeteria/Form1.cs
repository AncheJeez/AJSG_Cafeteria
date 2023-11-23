using System.Collections.Generic;

namespace AJSG_Cafeteria
{
    public partial class Form1 : Form
    {
        //@juangarmun
        /*
         * TODO:
         * Cuando añado de un fichero los donuts, no puedo recorrer por q estan desactivados los botones.
         * Cuando modifico un donut la imagen aunque no la toque pone la de por defecto.
         * 
         */
        Boolean create_state = false;
        Boolean modify_state = false;
        Boolean delete_state = false;
        Boolean fileChooserActivated = false;
        int index = 0;

        List<Donut> listaDeDonuts;
        String lastfilePath = "Donuts\\default.png";

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(31, 196, 6);

            editableBoxes(false);
            emptyBoxes();
            listaDeDonuts = ObtenerListaDeDonuts();
            if (listaDeDonuts.Count > 0)
            {
                fillBoxes(listaDeDonuts[0]);
            }
            else
            {
                btnDelete.Enabled = false;
                btnMod.Enabled = false;
            }
            setNumberDonutsBox(listaDeDonuts.Count);
            checkStateSigAnt();
            btnImagen.Enabled = false;
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        static List<Donut> ObtenerListaDeDonuts()
        {
            // metodo para meter datos predeterminados a la lista
            List<Donut> donutsToSave = new List<Donut> {
                //new Donut(1, true, "Fondat", "Donuts\\donuts_choco1.png", 1.20, 'B'),
                //new Donut(2, false, "Glacé", "Donuts\\donuts_classic1.png", 1.80, 'A'),
                //new Donut(3, true, "Bombón", "Donuts\\donuts_foundan2.png", 3.50, 'S'),
                //new Donut(4, false, "Nocilla", "Donuts\\donuts_nocilla.png", 1.10, 'C'),
                //new Donut(5, true, "Galleta cacao", "Donuts\\galleta_cacao.png", 2.80, 'S'),
                //new Donut(6, true, "Galleta fina", "Donuts\\galleta_fina.png", 0.50, 'D'),
                //new Donut(7, false, "Galleta rellena", "Donuts\\galleta_rellena.png", 2.00, 'A')
            };
            return donutsToSave;
        }

        public void emptyBoxes()// metodo vaciar todas las cajas
        {
            txBxId.Text = "";
            txBxNombre.Text = "";
            txBxPrecio.Text = "";
            txBxCalidad.Text = "";
            chBxStock.Checked = false;
            pictureBox.Image = Image.FromFile("Donuts\\default.png");
            // establecer la imagen a una por defecto
        }

        public void fillBoxes(Donut donut)// metodo rellenar las cajas segun un objeto Donut
        {
            txBxId.Text = donut.id.ToString();
            txBxNombre.Text = donut.nombre;
            txBxPrecio.Text = donut.precio.ToString();
            txBxCalidad.Text = donut.calidad.ToString();
            chBxStock.Checked = (donut.inStock == true) ? true : false;
            pictureBox.Image = Image.FromFile(donut.imagen);
            // meter imagen
        }

        // esto para modificar el numero de donuts que estan en la lista
        public void setNumberDonutsBox(int num)
        {
            txBxDonutsRegistr.Text = num.ToString();
        }

        // set enabled or not sig ant
        public void checkStateSigAnt()
        {
            btnAnt.Enabled = false;
            btnSig.Enabled = (listaDeDonuts.Count > 1) ? true : false;
        }
        // set editable boxes
        public void editableBoxes(Boolean editable)
        {
            txBxId.ReadOnly = !editable;
            txBxNombre.ReadOnly = !editable;
            txBxPrecio.ReadOnly = !editable;
            txBxCalidad.ReadOnly = !editable;
            chBxStock.Enabled = editable;
        }

        // boton crear
        private void button3_Click(object sender, EventArgs e)
        {
            if (!create_state)
            {
                editableBoxes(true);
                emptyBoxes();
                create_state = true;
                btnGuardar.Text = "Cancelar";

                // desactivamos o acativamos botones
                btnSig.Enabled = false;
                btnAnt.Enabled = false;
                btnMod.Enabled = false;
                btnDelete.Enabled = false;
                btnCargar.Enabled = false;
                btnImagen.Enabled = true;
            }
            else
            {
                editableBoxes(false);
                //creamos un nuevo donut
                int Id = (int.TryParse(txBxId.Text, out int value)) ? value : listaDeDonuts.Count + 1;
                String Nombre = txBxNombre.Text;
                double precio = (double.TryParse(txBxPrecio.Text, out double val)) ? val : 0;
                char calidad = (char.TryParse(txBxCalidad.Text, out char valu)) ? valu : 'Z';
                bool stock = chBxStock.Checked;
                String image = lastfilePath;

                Donut newDonut = new Donut(Id, stock, Nombre, image, precio, calidad);
                listaDeDonuts.Add(newDonut);
                setNumberDonutsBox(listaDeDonuts.Count);
                //reseteamos la imagen para que la siguiente creacion sea la default.png
                lastfilePath = "Donuts\\default.png";

                // volvemos a mostrar desde el principio
                fillBoxes(listaDeDonuts[0]);
                index = 0;
                btnSig.Enabled = true;
                btnGuardar.Text = "Guardar";
                create_state = false;

                //activamos o desactivamos botones
                btnMod.Enabled = true;
                btnDelete.Enabled = true;
                btnCargar.Enabled = true;
                btnImagen.Enabled = false;
            }
        }

        //boton anterior
        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (0 < index)
            {
                index--;
                fillBoxes(listaDeDonuts[index]);
                btnSig.Enabled = true;
                // desabilitamos el boton siguiente
                if (0 >= index)
                {
                    btnSig.Enabled = true;
                    btnAnt.Enabled = false;
                }
            }
        }

        //boton siguiente
        private void btnSig_Click(object sender, EventArgs e)
        {
            if (listaDeDonuts.Count > index + 1)
            {
                index++;
                fillBoxes(listaDeDonuts[index]);
                btnAnt.Enabled = true;
                // desabilitamos el boton siguiente
                if (listaDeDonuts.Count <= index + 1)
                {
                    btnSig.Enabled = false;
                    btnAnt.Enabled = true;
                }
            }
        }

        // el boton guardar tambien lo utilizo como cancelar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (create_state || modify_state || delete_state)
            {
                editableBoxes(false);
                btnGuardar.Text = "Guardar";
                create_state = false;
                modify_state = false;
                delete_state = false;
                fillBoxes(listaDeDonuts[0]);
                index = 0;
                btnSig.Enabled = true;

                //activamos botones
                btnMod.Enabled = true;
                btnCrear.Enabled = true;
                btnDelete.Enabled = true;
                btnCargar.Enabled = true;
                btnImagen.Enabled = false;
            }
            else
            {
                if (listaDeDonuts == null || listaDeDonuts.Count == 0)
                {
                    MessageBox.Show("No hay donuts para guardar.");
                    return;
                }

                // Create a SaveFileDialog to specify the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Donut Files|*.dat|All Files|*.*";
                    saveFileDialog.Title = "Save Donuts File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Save the donuts to the selected file
                        Donut donutInstance = new Donut();// es necesario instanciarlo, por si esta vacio
                        donutInstance.SaveToFile(saveFileDialog.FileName, listaDeDonuts);
                        MessageBox.Show("Donuts saved successfully!");
                    }
                }
            }
        }

        // boton borrar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!delete_state)
            {
                //emptyBoxes();
                delete_state = true;
                btnGuardar.Text = "Cancelar";

                // desactivamos o acativamos botones
                btnSig.Enabled = false;
                btnAnt.Enabled = false;
                btnMod.Enabled = false;
                btnCrear.Enabled = false;
                btnCargar.Enabled = false;
            }
            else
            {
                // BORRAMOS EL DONUT DE LA LISTA
                listaDeDonuts.RemoveAt(index);
                // volvemos a mostrar desde el principio
                if (listaDeDonuts.Count > 0)
                {
                    fillBoxes(listaDeDonuts[0]);
                    btnSig.Enabled = true;
                }
                else
                {
                    emptyBoxes();
                    btnSig.Enabled = false;
                    btnDelete.Enabled = false;
                    btnMod.Enabled = false;
                }
                setNumberDonutsBox(listaDeDonuts.Count);
                index = 0;
                delete_state = false;
                btnGuardar.Text = "Guardar";

                //activamos o desactivamos botones
                btnCrear.Enabled = true;
                btnCargar.Enabled = true;
                btnImagen.Enabled = false;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int oldId = index + 1;
            double oldPrecio = 0;
            char oldCalidad = 'Z';
            if (!modify_state)
            {
                //emptyBoxes();
                editableBoxes(true);
                modify_state = true;
                btnGuardar.Text = "Cancelar";

                // desactivamos o acativamos botones
                btnSig.Enabled = false;
                btnAnt.Enabled = false;
                btnDelete.Enabled = false;
                btnCrear.Enabled = false;
                btnCargar.Enabled = false;
                btnImagen.Enabled = true;
                oldId = int.Parse(txBxId.Text);
                oldPrecio = double.Parse(txBxPrecio.Text);
                oldCalidad = char.Parse(txBxCalidad.Text);
            }
            else
            {
                editableBoxes(false);
                int Id = (int.TryParse(txBxId.Text, out int value)) ? value : oldId;
                String Nombre = txBxNombre.Text;
                double Precio = (double.TryParse(txBxPrecio.Text, out double val)) ? val : oldPrecio;
                char Calidad = (char.TryParse(txBxCalidad.Text, out char valu)) ? valu : oldCalidad;
                bool Stock = chBxStock.Checked;
                if (fileChooserActivated)
                {
                    String Image = lastfilePath;
                    listaDeDonuts[index].imagen = Image;
                    fileChooserActivated = false;
                }
                listaDeDonuts[index].id = Id;
                listaDeDonuts[index].nombre = Nombre;
                listaDeDonuts[index].precio = Precio;
                listaDeDonuts[index].calidad = Calidad;
                listaDeDonuts[index].inStock = Stock;

                // volvemos a mostrar desde el principio
                fillBoxes(listaDeDonuts[0]);
                index = 0;
                btnSig.Enabled = true;
                btnGuardar.Text = "Guardar";
                modify_state = false;

                //activamos o desactivamos botones
                btnMod.Enabled = true;
                btnDelete.Enabled = true;
                btnCrear.Enabled = true;
                btnCargar.Enabled = true;
                btnImagen.Enabled = false;
            }
        }

        // boton file chooser
        private void btnImagen_Click(object sender, EventArgs e)
        {
            fileChooserActivated = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lastfilePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(lastfilePath);
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Donut Files|*.dat|All Files|*.*";
                openFileDialog.Title = "Select a Donut File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listaDeDonuts = Donut.LoadFromFile(openFileDialog.FileName);
                    MessageBox.Show("Donuts loaded successfully!");

                    if(listaDeDonuts.Count > 0)
                    {
                        index = 0;
                        fillBoxes(listaDeDonuts[0]);
                        setNumberDonutsBox(listaDeDonuts.Count);
                        checkStateSigAnt();
                        btnDelete.Enabled = true;
                        btnMod.Enabled = true;
                    }
                }
            }
        }
    }
}
