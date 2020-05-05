using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        int xo, yo, tam; //Variables para valor inicial de "x", de "y" y de tamaño.
        bool ec = false; //Bandera booleana en falso.
        bool estado = false; //Estado de inicializado en falso.
        int n = 0, i = 1; //Inicialización de variables.

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtNumero.Text); //Capturamos el valor ingresado.

                Array.Resize<int>(ref Arreglo_numeros, i + 1); //Incrementamos el arreglo en base al nuevo valor ingresado.
                Arreglo_numeros[i] = num; //Asignamos ese valor a la posición i del arreglo.
                Array.Resize<Button>(ref Arreglo, i + 1); //Incrementamos el arreglo de botones.
                Arreglo[i] = new Button(); //Creamos un nuevo botón i.
                Arreglo[i].Text = Arreglo_numeros[i].ToString(); //Texto del botón será el valor ingresado de posición i.
                Arreglo[i].Height = 50; //Alto de botón 50.
                Arreglo[i].Width = 50; //Ancho de botón 50.
                Arreglo[i].BackColor = Color.Aqua; //Color GreenYellow para botón.
                Arreglo[i].Location = new Point(xo, yo) + new Size(-20, 0); //Punto de ubicación.

                //Para poder dibujar el arbol y crear los niveles.
                if ((i + 1) == Math.Pow(2, n + 1))
                { //Para saber nivel en base a los nodos (si tenemos que cambiar de nivel).
                    n++; //Incrementamos n.
                    tam = tam / 2; //Dividimos de nuevo tam.
                    xo = tam; //El valor inicial de xo será el nuevo tam.
                    yo += 60; //Incrementamos el y en 60 para que el siguiente nivel se dibuje 60 espacios más abajo en y.
                }
                else
                {
                    xo += (2 * tam); //Si no hay que cambiar de nivel solo movemos el valor de x.
                }

                i++; //Incrementamos i.
                estado = true; //Pasamos estado a true;
                ec = false;
                tabPage2.Refresh(); //Refrescamos el tabpage.
                txtNumero.Clear(); //Limpiamos el textbox.
                txtNumero.Focus(); //Cursor nuevamente ahí.
                btnEliminarNodo.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Valor no válido"); //Error.
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             //Limpiamos pantalla y reinicializamos a valores inicialies.
            n = 0;
            i = 1;
            tam = tabPage2.Width / 2;
            xo = tam;
            yo = 20;
            tabPage2.Controls.Clear();
            tabPage2.Refresh();
            Array.Resize<int>(ref Arreglo_numeros, 1);
            Array.Resize<Button>(ref Arreglo, 1);
            btnEliminarNodo.Enabled = false;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                MessageBox.Show("No hay elementos que ordenar");
            }
            else
            {
                cboOrdenamiento.Enabled = false;
                btnAgregar.Enabled = false; //Mientras se ordena deshabilitamos botones para que no interfiera.
                btnLimpiar.Enabled = false;
                btnOrdenar.Enabled = false;
                btnEliminarNodo.Enabled = false;
                this.Cursor = Cursors.WaitCursor; //Hacemos que el cursor espere y mostramos que está procesando.

                if (!ec)
                {

                    Heap_Num(); //Llamamos el heap num.

                }
                else
                {

                    HPN(); //Llamamos hpn.
                }

                btnAgregar.Enabled = true; //Habilitamos todo de nuevo.
                btnLimpiar.Enabled = true;
                btnOrdenar.Enabled = true;
                cboOrdenamiento.Enabled = true;
                btnEliminarNodo.Enabled = true;
                this.Cursor = Cursors.Default; //Cursor a la normalidad.

            }
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                //Limpiamos pantalla y reinicializamos a valores inicialies.
                n = 0;
                i = 1;
                tam = tabPage2.Width / 2;
                xo = tam;
                yo = 20;
                tabPage2.Controls.Clear();
                tabPage2.Refresh();
                Array.Resize<int>(ref Arreglo_numeros, 1);
                Array.Resize<Button>(ref Arreglo, 1);
                btnEliminarNodo.Enabled = false;

            }
            else if (i > 2)
            {
                int cantidadElementos = Arreglo_numeros.Length;

                int auxiliar = Arreglo_numeros[1];
                Arreglo_numeros[1] = Arreglo_numeros[cantidadElementos - 1];
                Arreglo_numeros[cantidadElementos - 1] = auxiliar;
                Arreglo[1].Text = Arreglo_numeros[1].ToString(); //Texto del botón será el valor ingresado de posición i.
                tabPage2.Refresh();
                Array.Resize<int>(ref Arreglo_numeros, cantidadElementos - 1); //Decrementamos el arreglo en base al nuevo valor ingresado.
                Array.Resize<Button>(ref Arreglo, cantidadElementos - 1); //Decrementamos el arreglo de botones.

                if ((i) == Math.Pow(2, (n - 1) + 1))
                { //Para saber nivel en base a los nodos (si tenemos que cambiar de nivel).
                    n--; //Decrementamos n.
                    tam = tam * 2; //Multiplicamos  tam.
                                   //  xo = tam; //Si no hay que cambiar de nivel solo movemos el valor de x.
                    xo = Arreglo[cantidadElementos - 2].Location.X + (tam * 2);
                    yo -= 60;
                }
                else
                {
                    xo -= (2 * tam);
                }

                i--;

                //   estado = true; //Pasamos estado a true;
                tabPage2.Controls.Clear();
                estado = true;
                //   xo -= (2 * tam);

                tabPage2.Refresh(); //Refrescamos el tabpage.
                ec = false;
                btnEliminarNodo.Enabled = false;
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int[] Arreglo_numeros; //Arreglo de números ingresados.



        Button[] Arreglo; //Arreglo de botones para simular valores ingresados.
        
        public Form1()
        {
            InitializeComponent();
            tam = tabPage2.Width / 2; //tam será la mitad del ancho del tabpage.
            xo = tam; //El valor inicial de x será la mitad del ancho del tabpage.
            yo = 20; //El valor inicial en y será de 20.
            txtNumero.Focus(); //Cursor en textbox.
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ec = false;
            btnEliminarNodo.Enabled = false;
        }

        public void HPN()
        {
            int temp; //Variable temporal.
            int x = Arreglo_numeros.Length; //Longitud de arreglo valores ingresados.

            for (int i = x - 1; i >= 1; i--)
            { //Desde un valor menos de la longitud total decrementamos.
                intercambio(ref Arreglo, i, 1); // Intercambio.
                temp = Arreglo_numeros[i]; //El elemento i del arreglo a temporal.
                Arreglo_numeros[i] = Arreglo_numeros[1]; //El elemento 1 a la posición i.
                Arreglo_numeros[1] = temp; //El que estaba en temporal a la posición 1.
                x--;
            }
        }

        //Para número máximo en heap.
        public void Max_Num(int[] a, int x, int indice, ref Button[] botones)
        {
            int izquierdo = (indice) * 2;
            int derecho = (indice) * 2 + 1;
            int mayor = 0;

            // MessageBox.Show(indice.ToString());

            if (izquierdo < x && a[izquierdo] > a[indice])
            {
                mayor = izquierdo;

            }
            else
            {
                mayor = indice;
            }

            if (derecho < x && a[derecho] > a[mayor])
            {
                mayor = derecho;

            }

            if (mayor != indice)
            { //Si mayor es distinto de índice.

                int temp = a[indice]; //Valor cón índice a temporal.
                a[indice] = a[mayor]; //El mayor se almacena en posición del índice.
                a[mayor] = temp; //El temporal se almacena en mayor.

                intercambio(ref Arreglo, mayor, indice); //Se llama a intercambio.
                Max_Num(a, x, mayor, ref botones); //Llamada recursiva a Max_Num.
            }

        }

        //
        public void Min_Num(int[] a, int x, int indice, ref Button[] botones)
        {
            int izquierdo = (indice) * 2;
            int derecho = (indice) * 2 + 1;
            int menor = 0;

            // MessageBox.Show(indice.ToString());

            if (izquierdo < x && a[izquierdo] < a[indice])
            {
                menor = izquierdo;

            }
            else
            {
                menor = indice;
            }

            if (derecho < x && a[derecho] < a[menor])
            {
                menor = derecho;

            }

            if (menor != indice)
            { //Si menor es distinto de índice.

                int temp = a[indice]; //Valor cón índice a temporal.
                a[indice] = a[menor]; //El menor se almacena en posición del índice.
                a[menor] = temp; //El temporal se almacena en mayor.

                intercambio(ref Arreglo, menor, indice); //Se llama a intercambio.
                Min_Num(a, x, menor, ref botones); //Llamada recursiva a Max_Num.
            }


        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {

            if (estado)
            { //Si estado es verdadero.
                try
                {
                    Dibujar_Arreglo(ref Arreglo, ref tabPage2); //Dibujar arreglo.
                    dibujar_Ramas(ref Arreglo, ref tabPage2, e); //Dibujar ramas.
                }
                catch
                {

                }
                estado = false; //Pasar estado a falso.
            }
        }

        public void Dibujar_Arreglo(ref Button[] botones, ref TabPage tb)
        {
            for (int j = 1; j < botones.Length; j++)
            {
                tb.Controls.Add(this.Arreglo[j]);
            }
        }

        //Método para dibujar ramas.
        public void dibujar_Ramas(ref Button[] botones, ref TabPage tb, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Gray, 1.5f);
            Graphics g;
            g = e.Graphics;

            for (int j = 1; j < Arreglo.Length; j++)
            { //Para todos los elementos del arreglo.

                if (Arreglo[(2 * j)] != null)
                { //Mientras el arreglo no esté vacío.
                    g.DrawLine(lapiz, Arreglo[j].Location.X, Arreglo[j].Location.Y + 20, Arreglo[(2 * j)].Location.X + 20, Arreglo[(2 * j)].Location.Y);
                }

                if (Arreglo[(2 * j) + 1] != null)
                { //Mientras no haya solo un elemento.
                    g.DrawLine(lapiz, Arreglo[j].Location.X + 40, Arreglo[j].Location.Y + 20, Arreglo[(2 * j) + 1].Location.X + 20, Arreglo[(2 * j) + 1].Location.Y);
                }

            }

        }

        //método heap maximizante.
        public void Heap_Num()
        {
            ec = true; //Pasamos bandera a true.

            int x = Arreglo.Length; //Tomamos la longitud del arreglo.

            if (cboOrdenamiento.SelectedIndex == 0)
            { //Maximizante.

                for (int i = (x) / 2; i > 0; i--)
                { //Desde la mitad de la longitud decrementamos.
                    Max_Num(Arreglo_numeros, x, i, ref Arreglo);
                }


            }
            else if (cboOrdenamiento.SelectedIndex == 1)
            { //Minimizante.
                for (int i = (x) / 2; i > 0; i--)
                { //Desde la mitad de la longitud decrementamos.
                    Min_Num(Arreglo_numeros, x, i, ref Arreglo);
                }
            }



        }

        public void intercambio(ref Button[] botones, int a, int b)
        {

            string temp = botones[a].Text; //Dejamos valores en un temporal.

            Point pa = botones[a].Location; //Sacamos ubicación de a.
            Point pb = botones[b].Location; //Sacamos ubicación de b.

            int diferenciaX = Math.Abs(pa.X - pb.X); //Sacamos la distancia entre sus x.
            int diferenciaY = Math.Abs(pa.Y - pb.Y); //Sacamos la distancia entre sus y.

            int x = 10;
            int y = 10;
            int t = 70;

            while (y != diferenciaY + 10)
            { //Mientras no llegue a la posición esperada en y.
                Thread.Sleep(t); //Suspendemos durante 70 ms.
                botones[a].Location += new Size(0, -10); //Movemos a -10.
                botones[b].Location += new Size(0, +10); //Movemos b +10.
                y += 10;
            }

            while (x != diferenciaX - diferenciaX % 10 + 10)
            { //Mientras no llegue a la posición esperada en x.
                if (pa.X < pb.X)
                { //Si X de a es menor que X de b.
                    Thread.Sleep(t); //Dormir durante 70 ms.
                    botones[a].Location += new Size(+10, 0); //Movemos +10 a.
                    botones[b].Location += new Size(-10, 0); //Movemos -10 a b.
                    x += 10;

                }
                else
                {
                    Thread.Sleep(t); //Dormir durante 70 milisegundos.
                    botones[a].Location += new Size(-10, 0); //Movemos a -10 en x.
                    botones[b].Location += new Size(+10, 0); //Movemos b +10 en x.
                    x += 10;
                }
            }

            botones[a].Text = botones[b].Text; //Valor de b se muestra en a.
            botones[b].Text = temp; //El valor temporal almacenado se mostrará en b.
            botones[b].Location = pb; //Nuevo pb, se almacenará ubicación.
            botones[a].Location = pa; //Nuevo pa, se almacenará ubicación.
            estado = true; //Estado en true.

            tabPage2.Refresh(); //Se refresca tabpage.

        }
    }
}
