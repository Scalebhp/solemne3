using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    enum Operacion
    {
        SUMA,RESTA,MULTIPLICAR,DIVIDIR
    }
    public partial class index : System.Web.UI.Page
    {
        
        private static int valorAnterior = 0;
        private static Operacion op;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void prepararNumero(int n)
        {
            lblResultado.Text = lblResultado.Text[0] == '0' ? lblResultado.Text.Substring(1) : lblResultado.Text;
            lblResultado.Text +=""+n;
        }
        

        protected void BtnSiete_Click(object sender, EventArgs e)
        {

            prepararNumero(7);
        }

        protected void BtnOcho_Click(object sender, EventArgs e)
        {

            prepararNumero(8);
        }

        protected void BtnNueve_Click(object sender, EventArgs e)
        {

            prepararNumero(9);
        }

        protected void BtnCuatro_Click(object sender, EventArgs e)
        {

            prepararNumero(4);
        }

        protected void BtnCinco_Click(object sender, EventArgs e)
        {

            prepararNumero(5);
        }

        protected void BtnSeis_Click(object sender, EventArgs e)
        {

            prepararNumero(6);
        }

        protected void BtnTres_Click(object sender, EventArgs e)
        {

            prepararNumero(3);
        }

        protected void BtnDos_Click(object sender, EventArgs e)
        {

            prepararNumero(2);
        }

        protected void BtnUno_Click(object sender, EventArgs e)
        {
            prepararNumero(1);

        }

        protected void BtnCero_Click(object sender, EventArgs e)
        {
           prepararNumero(0);
        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {

            prepararNumero(0);
            valorAnterior ='0';
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            ServicioAritmetica.IService sc = new ServicioAritmetica.ServiceCliente();
            int valorNuevo = int.Parse(lblResultado.Text);
            ServicioAritmetica.Aritmetica ar = new ServicioAritmetica.Aritmetica();

            ar.FactorA = valorAnterior;
            ar.FactorB = valorNuevo;

            switch (op)
            {
                case Operacion.SUMA:
                    lblResultado.Text = ""+sc.Adiccion(ar);
                    break;
                case Operacion.RESTA:
                    lblResultado.Text = "" + sc.Sustraccion(ar);
                    break;
                case Operacion.MULTIPLICAR:
                    lblResultado.Text = "" + sc.Producto(ar);
                    break;
                case Operacion.DIVIDIR:
                    lblResultado.Text = "" + sc.Division(ar);
                    break;
                default:
                     BtnBorrar_Click(sender,e);
                    break;
            }

        }

        protected void prepararOperacion()
        {
            valorAnterior = int.Parse(lblResultado.Text);
            lblAnterior.Text = "" + valorAnterior;
            lblResultado.Text = "0";
        }

        protected void BtnAdiccion_Click(object sender, EventArgs e)
        {
            prepararOperacion();
            op = Operacion.SUMA;
        }

        protected void BtnSustraccion_Click(object sender, EventArgs e)
        {
            prepararOperacion();
            op = Operacion.RESTA;
        }

        protected void BtnProducto_Click(object sender, EventArgs e)
        {
            prepararOperacion();
            op = Operacion.MULTIPLICAR;
        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            prepararOperacion();
            op = Operacion.DIVIDIR;
        }

       
    }
}