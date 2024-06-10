using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mauiapphotel.models
{
    internal class Hospedagem
    {
        public Quarto QuartoSelecionado{ get; set; }
        public int QtdAdultos { get; set; }
        public int Qtdcriancas { get; set;}

        public DateTime Checkin {  get; set; }
        public DateTime Checkout { get; set; }

        public int Estadia 
        {
            get => DataCheckout.subtract(DataChekin).Days;        
        }

        public double ValorTotal 
        {
            get 
            {
                double valor_adultos = QtdAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QtdCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total =(valor_adultos + valor_criancas) =  Estadia;

                return total;
            }
        }

}
