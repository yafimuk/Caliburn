using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace CaliburnMicroApp {
    public class AppViewModel : PropertyChangedBase {

        private int _count = 100;

        public int Count {
            get { return _count; }
            set {
                _count = value;
                NotifyOfPropertyChange(() => Count);
            }
        }
        public void IncrementCount(int delta) {
            Count+=delta;
        }
        public bool CanIncrementCount {
            get { return Count < 200; }
            set { NotifyOfPropertyChange(() => CanIncrementCount); }
        }
    }
}