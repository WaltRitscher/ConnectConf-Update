using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Tours.Standard.BizNew;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tours.Standard.UWP
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();

     _allTours = Tours.Standard.BizNew.Tours.Current.GetTours();
      _toursCVS = new CollectionViewSource();
      _toursCVS.IsSourceGrouped = true;

      var regions = from t in _allTours
                   group t by t.Region;
      _toursCVS.Source = regions;
      this.cvs.Source = regions;
    }

    private List<Tour> _allTours;

    public List<Tour> AllTours
      {
      get { return _allTours; }
      set { _allTours = value; }
    }
    private CollectionViewSource _toursCVS;

    public CollectionViewSource ToursCVS {
      get { return _toursCVS; }
      set { _toursCVS = value; }
    }

  }
}
