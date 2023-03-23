using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    class Presenter
    {
        private Form1 _view;
        private Model _model;

        public Presenter(Form1 view, Model model)
        {
            this._view = view;
            this._model = model;
        }

        public void OnClickAdd()
        {

        }
    }
}
