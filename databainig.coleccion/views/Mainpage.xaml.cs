using databainig.coleccion.models;
using System.Collections.ObjectModel;

namespace databainig.coleccion.views;

public partial class Mainpage : ContentPage
{
    public ObservableCollection<OrigenDePaquete> Origenes { get; }
    public Mainpage()
    {
        InitializeComponent();
        OrigenDePaquete? origenSeleccionado = null;

        Origenes = new ObservableCollection<OrigenDePaquete>();
        CargarDatos();
        OrigenesListView.ItemsSource = Origenes;
        if (Origenes.Count > 0)
        {
            origenSeleccionado = Origenes[0];

        }
        BindingContext = this;
        //////OrigenesListView.ItemsSource = _origenes;
        //////OrigenesListView.SelectedItem = origenSeleccionado;

    }

    private void CargarDatos()
    {
        Origenes.Add(new OrigenDePaquete
        {
            nombre = "nuget.org",
            origen = "https://api.nuget.org/v3/index.json",
            EstaHabilitado = false
        });

        Origenes.Add(new OrigenDePaquete
        {
            nombre = "Microsoft Visual Studio Offline Packages",
            origen = @"C:\Program Files (x86)\Microsoft SDKs \NuGetPackages",
            EstaHabilitado = false
        });

    }

    private void OnAgregarButtonCliked(object sender, EventArgs e)
    {
        var origen = new OrigenDePaquete
        {
            nombre = "Origen del paquete",
            origen = "URL o ruta del origen del paquete",
            EstaHabilitado = false
        };
        Origenes.Add(origen);

        //OrigenesListView.ItemsSource = null;
        //OrigenesListView.ItemsSource = _origenes;
        //OrigenesListView.SelectedItem = origen;


    }

    private void OnDelateButtonCliked(object sender, EventArgs e)
    {
        //OrigenDePaquete seleccionado = (OrigenDePaquete)OrigenesListView.SelectedItem;
        OrigenDePaquete seleccionado = null;
        if (seleccionado != null)
        {
            var indice = Origenes.IndexOf(seleccionado);
            OrigenDePaquete? nuevoSeleccionado;
            if (Origenes.Count > 1)
            {
                //Hat mas de un elemento
                if (indice < Origenes.Count - 1)
                {//El elemento seleccionado no es el ultimo
                    nuevoSeleccionado = Origenes[indice + 1];
                }
                else
                {//El elemento seleccionadp es el ultimo
                    nuevoSeleccionado = Origenes[indice - 1];

                }
            }
            else
            {//Solo hay un elemento
                nuevoSeleccionado = null;
            }
            Origenes.Remove(seleccionado);

            //OrigenesListView.ItemsSource = null;
            //OrigenesListView.ItemsSource = _origenes;
            //OrigenesListView.SelectedItem = nuevoSeleccionado;
        }

    }

    private void OrigenesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //OrigenDePaquete origenSelecccionado = (OrigenDePaquete)OrigenesListView.SelectedItem;
        //if (origenSelecccionado != null)
        //{
        //    NombreEntry.Text = origenSelecccionado.nombre;
        //    OrigenEntry.Text = origenSelecccionado.origen;
        //}
        //else
        //{
        //    NombreEntry.Text = string.Empty;
        //    OrigenEntry.Text = string.Empty;
        //}
    }

    private void OnActualizarButton_Clicked(object sender, EventArgs e)
    {
        //    OrigenDePaquete origenSeleccionado = OrigenesListView.SelectedItem as OrigenDePaquete;
        //    if (origenSeleccionado != null)
        //    {
        //        origenSeleccionado.nombre = NombreEntry.Text;
        //        origenSeleccionado.origen = OrigenEntry.Text;
        //        OrigenesListView.ItemsSource = null;
        //        OrigenesListView.ItemsSource = _origenes;
        //        OrigenesListView.SelectedItem = origenSeleccionado;
        //    }
        //}}

    }
} 