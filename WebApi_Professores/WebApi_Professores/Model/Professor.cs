using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Professores.Model
{
    public class Professores
    {
        public int Mid { get; set; }

        public string Mnome { get; set; }

        public string Mcredencial { get; set; }

        public string Mdisciplina { get; set; }

        public string Mhorario { get; set; }


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
            var maxId = ListaProfessores.Max(professor => professor.Mid);
            Professor.Mid = maxId + 1;
            ListaProfessores.Add(Professor);
            ReescreverArquivo(ListaProfessores);
            return Professor;
        }

        public Professores Atualizar(int Mid, Professores Professor)
        {
            var ListaProfessores = this.ListaProfessores();
            var itemIndex = ListaProfessores.FindIndex(p => p.Mid == Mid);
            if (itemIndex >= 0)
            {
                Professor.Mid = Mid;
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
            var itemIndex = ListaProfessores.FindIndex(p => p.Mid == id);
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
