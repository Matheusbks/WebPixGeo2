using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebPixGeo.Dominio;
using WebPixGeo.Entidade;
using WebPixGeo.Repositorio;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Endereco endereco = new Endereco
            {
                Ativo = true,
                Bairro = "Higienopolis",
                CEP = "01244010",
                Cidade = "São Paulo",
                Complemento = "DO lado da antena da band",
                DataCriacao = DateTime.Now,
                DataEdicao = DateTime.Now,
                Descricao = "teste",
                Estado = "SP",
                ID = 0,
                idUsuario = 1,
                Local = "Rua minas gerais ap 38b",
                Nome = "Casa",
                NumeroLocal = 428,
                Status = 1,
                UsuarioCriacao = 1,
                UsuarioEdicao = 1
            };

            EnderecoBO.Save(endereco);

        }
    }
}
