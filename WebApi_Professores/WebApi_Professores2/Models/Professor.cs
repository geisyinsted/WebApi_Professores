using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebApi_Professores2.Models
{
    public interface IVerificaProf
    {
        string VerificaId(Professores p);
        string VerificaNome(Professores p);
        string VerificaCredencial(Professores p);
        string VerificaDisciplina(Professores p);
        string VerificaHorario(Professores p);
    }
    public class Professores : IVerificaProf
    {
        public Professores(string titulacao)
        {
            Titulacao = titulacao;
        }

        public Professores()
        {
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Credencial { get; set; }

        public string Disciplina { get; set; }

        public string Horario { get; set; }

        public string Titulacao { get; set; }

        public string VerificaId(Professores p)
        {
            if (p.Id < 1)
            {
                return "Erro!! ID Inexistente";
            }
            else
                return "";

        }

        public string VerificaNome(Professores p)
        {
            if (p.Nome == null)
            {
                return "Erro!! Nome Inexistente";
            }
            else
                return "";

        }

        public string VerificaCredencial(Professores p)
        {
            if (p.Credencial == null)
            {
                return "Erro!! Credencial Inexistente";
            }
            else
                return "";

        }

        public string VerificaDisciplina(Professores p)
        {
            if (p.Disciplina == null)
            {
                return "Erro!! Disciplina Inexistente";
            }
            else
                return "";

        }
        public string VerificaHorario(Professores p)
        {
            if (p.Horario == "matutino" || p.Horario == "vespertino" || p.Horario == "noturno")
            {
                return "";
            }
            else
                return "Erro!! Horário Inexistente";

        }
        public string VerificaTitulacao(Professores p)
        {
            if (p.Titulacao == "pós graduado" || p.Horario == "mestre" || p.Horario == "doutor")
            {
                return "";
            }
            else
                return "Erro!! Titulação Inexistente";

        }


        public List<Professores> ListaProfessores()
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\Base.json");
            var json = File.ReadAllText(caminhoArquivo);
            var ListaProfessores = JsonConvert.DeserializeObject<List<Professores>>(json);

            return ListaProfessores;
        }
        public bool ReescreverArquivo(List<Professores> listaProfessores)
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\base.json");
            var json = JsonConvert.SerializeObject(listaProfessores, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, json);
            return true;
        }

        public Professores Inserir(Professores Professor)
        {
            var ListaProfessores = this.ListaProfessores();
            var maxId = ListaProfessores.Max(professor => professor.Id);
            Professor.Id = maxId + 1;
            ListaProfessores.Add(Professor);
            ReescreverArquivo(ListaProfessores);
            return Professor;
        }

        public Professores Atualizar(int Mid, Professores Professor)
        {
            var ListaProfessores = this.ListaProfessores();
            var itemIndex = ListaProfessores.FindIndex(p => p.Id == Mid);
            if (itemIndex >= 0)
            {
                Professor.Id = Mid;
                ListaProfessores[itemIndex] = Professor;

            }
            else
            {
                return null;
            }
            ReescreverArquivo(ListaProfessores);
            return Professor;
        }

        public bool Deletar(int id)
        {
            var ListaProfessores = this.ListaProfessores();
            var itemIndex = ListaProfessores.FindIndex(p => p.Id == id);
            if (itemIndex >= 0)
            {
                ListaProfessores.RemoveAt(itemIndex);

            }
            else
            {
                return false;
            }
            ReescreverArquivo(ListaProfessores);
            return true;
        }
    }
}