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
        // GET: api/Professor
        public IEnumerable<Professores> Get()
        {
            Professores professor = new Professores();
            return professor.ListaProfessores();
        }

        // GET: api/Professor/5
        public Professores Get(int id)
        {
            Professores professor = new Professores();
            return professor.ListaProfessores().Where(x => x.Id == id).FirstOrDefault();
        }

        //Get: api/Professor/Id/5
        public Professores BuscarGraduacao(int id)
        {
            
            Professores professor = new Professores();
            if (professor != null)
            {
                if (professor != null)
                {
                    return professor.ListaProfessores().Where(t => t.Id == id).FirstOrDefault();
                }
                return new Professores(professor.Titulacao);
            }
            else 
                return null;
        }

        // POST: api/Professor
        public List<Professores> Post(Professores professor)
        {
            Professores _professor = new Professores();
            _professor.Inserir(professor);
            return _professor.ListaProfessores();
        }

        // PUT: api/Professor/5
        public List<Professores> Put(int id, Professores professor)
        {
            Professores _professor = new Professores();
            _professor.Atualizar(id, professor);
            return _professor.ListaProfessores();

        }

        // DELETE: api/Professor/5
        public void Delete(int id)
        {
            Professores _professor = new Professores();
            _professor.Deletar(id);


        }

    }
}
