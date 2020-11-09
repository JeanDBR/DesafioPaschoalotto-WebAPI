namespace DesafioPaschoalotto_WebAPI.Models
{
    public class Divida
    {
        public Divida() { }

        public Divida(int div_id, string div_vlrOriginal, int div_diasAtraso, string div_jurosTipo, int div_contato)
        {
            string valorOriginal = div_vlrOriginal;
            valorOriginal = valorOriginal.Replace(".", "");
            valorOriginal = valorOriginal.Replace(",", ".");
            this.Div_id = div_id;
            this.Div_vlrOriginal = double.Parse(valorOriginal);
            this.Div_diasAtraso = div_diasAtraso;
            this.Div_jurosTipo = div_jurosTipo;
            this.Div_vlrJuros = (double.Parse(valorOriginal) * 0.002) * 10;
            this.Div_vlrFinal = double.Parse(valorOriginal) + this.Div_vlrJuros;
            this.Div_contato = div_contato;
        }

        public int Div_id { get; set; }
        public double Div_vlrOriginal { get; set; }
        public int Div_diasAtraso { get; set; }
        public string Div_jurosTipo { get; set; }
        public double Div_vlrJuros { get; set; }
        public double Div_vlrFinal { get; set; }
        public int Div_contato { get; set; }
    }
}