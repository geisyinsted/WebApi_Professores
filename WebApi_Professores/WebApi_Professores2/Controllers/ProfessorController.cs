using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Professores2.Models;

namespace WebApi_Professores2.Controllers
{
    
    public class ProfessorController : ApiController
    {
        // GET: api/Pessoa
        public IEnumerable<Professores> Get()
        {
            Professores professor = new Professores();
            return professor.ListaProfessores();
        }

        // GET: api/Pessoa/5
        public Professores Get(int id)
        {
            Professores professor = new Professores();
            return professor.ListaProfessores().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Pessoa
        public List<Professores> Post(Professores professor)
        {
            Professores _professor = new Professores();
            _professor.Inserir(professor);
            return _professor.ListaProfessores();
        }

        // PUT: api/Pessoa/5
        public List<Professores> Put(int id, Professores professor)
        {
            Professores _professor = new Professores();
            _professor.Atualizar(id, professor);
            return _professor.ListaProfessores();

        }

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
            Professores _professor = new Professores();
            _professor.Deletar(id);


        }

    }
}
