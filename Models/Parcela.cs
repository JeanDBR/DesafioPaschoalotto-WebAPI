using System.Collections.Generic;

namespace DesafioPaschoalotto_WebAPI.Models
{
    public class Parcela
    {
         public int Parc_id { get; set; }
        public Divida Div_id { get; set; }
        public int Parc_numOrdem { get; set; }
        public double Parc_vlrFinal { get; set; }
        public Date Parc_dtVencimento { get; set; }

        public Parcela() { }
        public Parcela(int parc_id, Divida div_id, int parc_numOrdem, int qtdParcelas, Date parc_dtVencimento)
        {
            Parc_id = parc_id;
            Div_id = div_id;
            Parc_numOrdem = parc_numOrdem;
            Parc_vlrFinal = div_id.Div_vlrFinal / qtdParcelas;
            Parc_dtVencimento = parc_dtVencimento;
        }   

    }
}