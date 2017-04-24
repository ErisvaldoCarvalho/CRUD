using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Coluna
    {
        private string nomeColuna;
        private string parametroSQL;
        private bool chavePrimaria;
        private bool aceitaNulo;
        private int quantidadeDeCaracteres;
        private object valor;
        private object valorPadrao;

        public object Valor { get { return valor; } set { valor = value; } }
        public object ValorPadrao { get { return valorPadrao; } set { valorPadrao = value; } }
        public bool ChavePrimaria { get { return chavePrimaria; } set { chavePrimaria = value; AceitaNulo = false; } }
        public string ParametroSQL { get { return parametroSQL; } set { parametroSQL = value; } }
        public int QuantidadeDeCaracteres { get { return quantidadeDeCaracteres; } set { quantidadeDeCaracteres = value; } }
        public bool AceitaNulo { get { return aceitaNulo; } set { aceitaNulo = value; } }
        public string NomeColuna { get { return nomeColuna; } set { nomeColuna = value; ParametroSQL = "@" + value.ToString(); if (value == "@Codigo") ChavePrimaria = true; } }

        public Coluna(string _nomeColuna)
        {
            NomeColuna = _nomeColuna;
        }
    }
}
