using System;
using System.Collections.Generic;
using System.Text;
using GestionPizzeria.Model;

namespace GestionPizzeria.Controller
{
    class CommisController
    {
        private Model.Commis commis;

        public CommisController(Commis _commis)
        {
            this.commis = _commis;
        }

        public void CommisPrepare(Commande commande)
        {
            commande.preparation();
        }

        public void CommisTermine(Commande commande)
        {
            commande.livré();
        }
    }
}
