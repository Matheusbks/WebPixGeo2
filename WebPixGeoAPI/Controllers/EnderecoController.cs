using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebPixGeo.Dominio;
using WebPixGeo.Entidade;
using System.Threading.Tasks;

namespace WebPixGeoAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class EnderecoController : Controller
    {

        [HttpGet]
        public IList<Endereco> GetAll()
        {
            return EnderecoBO.GetList();
        }

        [HttpGet("{idUsuario}", Name = "GetEnderecoByUsuario")]
        public Endereco GetEnderecoByUsuario(int idUsuario)
        {
            return EnderecoBO.GetEnderecoByUsuario(idUsuario);
        }

        [HttpGet("{id}", Name = "GetAllByID")]
        public Endereco GetAllByID(int id)
        {
            return EnderecoBO.GetAllByID(id);
        }

        [HttpPost]
        public string Save([FromBody]Endereco obj)
        {
            try
            {
                EnderecoBO.Save(obj);
                return "Endereco cadastrado com sucesso";
            }
            catch (Exception e)
            {
                return "Houve uma falha ao salvar, aguarde uns instante ou entre em contato com o suporte";
            }

        }

        [HttpPost]
        public string Remove([FromBody]Endereco obj)
        {
            EnderecoBO Endereco = new EnderecoBO();
            try
            {
                //Status de remoção
                EnderecoBO.Remove(obj);
                return "Endereco removido com sucesso";
            }
            catch (Exception e)
            {
                return "Houve uma falha ao salvar, aguarde uns instante ou entre em contato com o suporte";
            }
        }

        [HttpGet("{cep}")]
        public async Task<object> GetEnderecoByCepAsync(string cep)
        {
            try
            {
                Object retorno = await EnderecoBO.GetEnderecoByCepAsync(cep);
                return retorno;
            }
            catch
            {
                return new {
                    Menssagem = "Houve uma falha"
                };
            }
        }
    }
}