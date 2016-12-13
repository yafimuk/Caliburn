using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using System.Windows.Media;

namespace CaliburnMicroApp
{
  [Export(typeof(ColorViewModel))]
  public class ColorViewModel
  {
    private readonly IEventAggregator _events;

    [ImportingConstructor]
    public ColorViewModel(IEventAggregator events)
    {
      _events = events;
    }

    public void Red()
    {
      _events.Publish(new ColorEvent(new SolidColorBrush(Colors.Red)));
    }

    public void Green()
    {
      _events.Publish(new ColorEvent(new SolidColorBrush(Colors.Green)));
    }

    public void Blue()
    {
      _events.Publish(new ColorEvent(new SolidColorBrush(Colors.Blue)));
    }
  }
}
