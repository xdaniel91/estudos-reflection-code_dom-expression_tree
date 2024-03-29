﻿namespace csharppt10
{
    [Serializable]
    [FormatoDetalhado("{0, -12}  {1, -12}  {2, 12:c}  {3, -12}  {4, -12}  {5, -12}  {6, -12}  {7, -12}")]
    [FormatoResumido("{0, -12}  {1, -12}  {2, 12:c}  {3, -12}")]

    public class Venda
    {
        public string Data;
        public string Produto;
        public int Preco;
        public string TipoPagamento;
        [NonSerialized]
        public string Nome;
        public string Cidade;
        public string Estado;
        public string Pais;
        public string DataCriacao;
        public string UltimoLogin;
        public double Latitude;
        public double Longitude;
    }

    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoResumidoAttribute : Attribute
    {
        public string Formato { get; }

        public FormatoResumidoAttribute(string formato)
        {
            Formato = formato;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoDetalhadoAttribute : Attribute
    {
        public string Formato { get; }

        public FormatoDetalhadoAttribute(string formato)
        {
            Formato = formato;
        }
    }
}
