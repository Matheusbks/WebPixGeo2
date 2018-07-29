using System;
using System.Collections.Generic;
using System.Linq;
using WebPixGeo.Entidade;
using WebPixGeo.Repositorio;
using WebPixGeo.Servico;
using System.Threading.Tasks;

namespace WebPixGeo.Dominio
{
    public class EnderecoBO
    {
        public static IList<Endereco> GetList()
        {
            return new EnderecoRep().GetAll().Where(x => x.Ativo = true).ToList();
        }
        public static Endereco GetEnderecoByUsuario(int idUsuario)
        {
            return new EnderecoRep().GetAll().Where(endereco => endereco.idUsuario == idUsuario).FirstOrDefault();
        }
        public static Endereco GetAllByID(int ID)
        {
            return new EnderecoRep().GetAll().Where(endereco => endereco.ID == ID).FirstOrDefault();
        }
        public static bool Save(Endereco endereco)
        {
            EnderecoRep rep = new EnderecoRep();


            if (endereco.ID == 0)
            {
                endereco.DataCriacao = DateTime.Now;
                endereco.DataEdicao = DateTime.Now;
                endereco.Ativo = true;
                try
                {
                    rep.Add(endereco);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                endereco.DataEdicao = DateTime.Now;
                try
                {
                    rep.Update(endereco);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        public static bool Remove(Endereco endereco)
        {
            EnderecoRep rep = new EnderecoRep();
            endereco.Ativo = false;
            endereco.DataEdicao = DateTime.Now;
            try
            {
                rep.Update(endereco);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static async Task<object> GetEnderecoByCepAsync(string cep)
        {
            try
            {
                Object retorno = await CorreiosServ.GetEnderecoAsync(cep);
                return retorno;
            }
            catch (Exception e)
            {
                ///Deu pau :)
                return new Object();
            }
        }

    }
}
