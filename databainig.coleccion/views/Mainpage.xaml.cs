using databainig.coleccion.models;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace databainig.coleccion.views;

public partial class Mainpage : ContentPage

{

    public ObservableCollection<OrigenDePaquete> Origenes { get; }
    private OrigenDePaquete? _origenSeleccionado = null;
    private string? _nombreDelOrigen = string.Empty;
    private string? _rutaDelOrigen = string.Empty;


    public OrigenDePaquete? OrigenSeleccionado
    {
        get => _origenSeleccionado;
        set
        {
            if (_origenSeleccionado != value)
            {
                _origenSeleccionado = value;
                OnPropertyChanged(nameof(OrigenSeleccionado));
            }
        }
    }
    public string NombreDelOrigen
    {
        get => _nombreDelOrigen;
        set
        {
            if (_nombreDelOrigen != value)
            {

                _nombreDelOrigen = value;
                OnPropertyChanged(nameof(NombreDelOrigen));
            }
        }
    }
    public string RutaDeOrigen
    {
        get => _rutaDelOrigen;
        set
        {
            if (_rutaDelOrigen != value)
            {

                _rutaDelOrigen = value;
                OnPropertyChanged(nameof(RutaDeOrigen));
            }
        }
    }
    public Mainpage()
    {
        InitializeComponent();

        OrigenSeleccionado = null;

        OrigenDePaquete? origenSeleccionado = null;

        Origenes = new ObservableCollection<OrigenDePaquete>();
        CargarDatos();
        BindingContext = this;
        OrigenesLisView.ItemsSource = Origenes;
        if (Origenes.Count > 0)
        {
            origenSeleccionado = Origenes[0];
        }

        //       OrigenesLisView.ItemsSource = _origenes;
        //     OrigenesLisView.SelectedItem = origenSeleccionado;

    }
    private void CargarDatos()
    {
        Origenes.Add(new OrigenDePaquete()
        {
            Nombre = "Nuger.org",
            Origen = "https://api.nuget.org/v3/index/json",
            EstaHabilitado = true



        });
        Origenes.Add(new OrigenDePaquete()
        {
            Nombre = "Microsoft Visual Studio Offline Packages",
            Origen = "C:\\Program Files(x86)\\Microsoft SDKs\\NugetPackages",
            EstaHabilitado = false



        });


    }

    private void OnAgregarButton_Clicked(object sender, EventArgs e)
    {
        var origen = new OrigenDePaquete

        {
            Nombre = "Origen del paquete",
            Origen = "URL o ruta origen del paquete",
            EstaHabilitado = false



        };
        Origenes.Add(origen);
        OrigenSeleccionado = origen;
    }

    private void OnDeleteButton_Clicked(object sender, EventArgs e)
    {
        OrigenDePaquete seleccionado = (OrigenDePaquete)OrigenesLisView.SelectedItem;

        {


            if (OrigenSeleccionado != null)
            {
                var indice = Origenes.IndexOf(OrigenSeleccionado);
                OrigenDePaquete? nuevoseleccionado;
                if (Origenes.Count > 1)
                {
                    //Hay mas de un elemento
                    if (indice < Origenes.Count - 1)
                    {
                        //El elemento seleccionado no es el ultimo
                        nuevoseleccionado = Origenes[indice + 1];


                    }
                    else
                    {
                        //El elemento seleccionado es el ultimo
                        nuevoseleccionado = Origenes[indice - 1];

                    }

                }
                else
                {
                    //Solo hay un elemento
                    nuevoseleccionado = null;

                }
                Origenes.Remove(OrigenSeleccionado);
                OrigenSeleccionado = nuevoseleccionado;


            }
        }
    }


    private void OrigenesLisView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //origenpaquete origenseleccionado = origeneslisview.selecteditem as origenpaquete;
        //otra manera de escribirlo:
        //origenpaquete origenseleccionado = (origenpaquete)origeneslisview.selecteditem;

        if (OrigenSeleccionado != null)
        {

            NombreDelOrigen = OrigenSeleccionado.Nombre;
            RutaDeOrigen = OrigenSeleccionado.Origen;

        }
        else
        {
            NombreDelOrigen = string.Empty;
            RutaDeOrigen = string.Empty;
        }

    }

    private void OnActualizarButton_Clicked(object sender, EventArgs e)
    {

        if (OrigenSeleccionado != null)
        {
            OrigenSeleccionado.Nombre = NombreDelOrigen;
            OrigenSeleccionado.Origen = RutaDeOrigen;



        }
    }
}


// commit -m "ejemplo de databindig en una collecion de objetos"