using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Professores.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_Professores.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProfessorController : ControllerBase
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
            return professor.ListaProfessores().Where(x => x.Mid == id).FirstOrDefault();
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

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
            Professores _pessoa = new Professores();
            _pessoa.Deletar(id);


        }
    }
}
