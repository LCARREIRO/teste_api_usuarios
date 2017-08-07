using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using RestSharp;
using System.Configuration;
using TesteListagemDeUsuarios.Dominio.Entidade;

namespace TesteListagemDeUsuarios.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Listar(int? page)
        {
            RestClient client = new RestClient(
                ConfigurationManager.AppSettings["UrlBase"]);

            RestRequest requisicao = new RestRequest(
                ConfigurationManager.AppSettings["CaminhoRecurso"],
                Method.GET);

            IRestResponse<List<UsuarioModel>> resposta =
                client.Execute<List<UsuarioModel>>(requisicao);
            List<UsuarioModel> usuarios = resposta.Data;

            int pageSize = 3;
            int pageNumber = (page ?? 1);

            return View(usuarios.ToPagedList(pageNumber, pageSize));
        }
    }
}