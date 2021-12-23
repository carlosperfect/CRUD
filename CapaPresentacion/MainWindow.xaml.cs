using CapaNegocio;
using System;
using System.Windows;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Controls;

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        lista objetoCN = new lista();
        private string idproducto = "0";
        private bool Editar = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MostrarProductos()
        {
            lista objeto = new lista();
            dglista.ItemsSource = objeto.MostrarProd().DefaultView;
          
        }

        private void dglista_Loaded(object sender, RoutedEventArgs e)
        {
            MostrarProductos();
        }

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                objetoCN.InsertarProd(textnombre.Text, textdescri.Text, textmarca.Text, textprecio.Text, textstock.Text);
                MessageBox.Show("Registro Grabado Correctamente");
                MostrarProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede grabar el registro");
            }
        }



        private void eliminar_Click(object sender, RoutedEventArgs e)
         {
             if (dglista.SelectedItems.Count > 0)
             {
                //idproducto = dglista.CurrentCell.Item;
                //idproducto = dglista.SelectedItem["Id"];
                //idproducto= dglista.CurrentItem.["id"].Value.ToString();


                
                 objetoCN.EliminarProd(idproducto);
                 MessageBox.Show("Registro Eliminado Correctamente");
                 MostrarProductos();
             }
             else
             {
                 MessageBox.Show("No se puede eliminar el registro");
             }
         }

        /*private void editar_Click(object sender, RoutedEventArgs e)
        {
            if(dglista.SelectedItems.Count>0)
            {
                textnombre.Text = dglista;
            }
        }*/

    }
}
