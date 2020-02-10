using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List <string> _mensagemValidacao { get; set; }

        private List <string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao ()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica (string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        public bool EhValidado
        {
            get { return !mensagemValidacao.Any(); }
        }


    }
}
