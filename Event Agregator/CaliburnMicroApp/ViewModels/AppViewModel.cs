using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace CaliburnMicroApp
{
  [Export(typeof(AppViewModel))]
  public class AppViewModel : PropertyChangedBase, IHandle<ColorEvent>
  {
    private SolidColorBrush _Color;

    [ImportingConstructor]
    public AppViewModel(ColorViewModel colorModel, IEventAggregator events)
    {
      ColorModel = colorModel;

      events.Subscribe(this);
    }

    public ColorViewModel ColorModel { get; private set; }

    public SolidColorBrush Color
    {
      get { return _Color; }
      set
      {
        _Color = value;
        NotifyOfPropertyChange(() => Color);
      }
    }

    public void Handle(ColorEvent message)
    {
      Color = message.Color;
    }
  }
}
