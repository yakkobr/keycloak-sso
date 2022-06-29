﻿namespace Cadastro.MVC.Models.Request
{
    public class EnderecoRequest
    {
        public string Rua { get; set; }
        public int? Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
