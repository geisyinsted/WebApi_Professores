using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using WebApi_Professores2.Models;

namespace ProfessorDataDrivenTest
{
    [TestClass]
    public class ProfessorTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "IdTeste", DataAccessMethod.Sequential)]
        public void TesteIdDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Id = Convert.ToInt32(TestContext.DataRow["id"] );

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaId(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var idEsperado = mock.Object.VerificaId(Larissa);
            var id = verifica.VerificaId(Larissa);

            //Assert
            Assert.AreEqual(id, idEsperado);
        }
        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "NomeTeste", DataAccessMethod.Sequential)]
        public void TesteNomeDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Nome = Convert.ToString(TestContext.DataRow["nome"]);

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaNome(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var nomeEsperado = mock.Object.VerificaNome(Larissa);
            var nome = verifica.VerificaNome(Larissa);

            //Assert
            Assert.AreEqual(nome, nomeEsperado);
        }
        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "CredencialTeste", DataAccessMethod.Sequential)]
        public void TesteCredencialDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Credencial = Convert.ToString(TestContext.DataRow["credencial"]);

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaCredencial(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var credencialEsperado = mock.Object.VerificaCredencial(Larissa);
            var credencial = verifica.VerificaCredencial(Larissa);

            //Assert
            Assert.AreEqual(credencial, credencialEsperado);
        }
        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "DisciplinaTeste", DataAccessMethod.Sequential)]
        public void TesteDisciplinaDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Disciplina = Convert.ToString(TestContext.DataRow["disciplina"]);

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaDisciplina(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var disciplinaEsperado = mock.Object.VerificaDisciplina(Larissa);
            var disciplina = verifica.VerificaDisciplina(Larissa);

            //Assert
            Assert.AreEqual(disciplina, disciplinaEsperado);
        }
        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "HorarioTeste", DataAccessMethod.Sequential)]
        public void TesteHorarioDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Horario = Convert.ToString(TestContext.DataRow["horario"]);

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaHorario(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var horarioEsperado = mock.Object.VerificaHorario(Larissa);
            var horario = verifica.VerificaHorario(Larissa);

            //Assert
            Assert.AreEqual(horario, horarioEsperado);
        }
        [TestMethod]
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-JE31I3J\SQLEXPRESS;Initial Catalog=TesteProfessor;Integrated Security=True", "TitulacaoTeste", DataAccessMethod.Sequential)]
        public void TesteTitulacaoDB()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Titulacao = Convert.ToString(TestContext.DataRow["titulacao"]);

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaTitulacao(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var titulacaoEsperado = mock.Object.VerificaTitulacao(Larissa);
            var titulacao = verifica.VerificaTitulacao(Larissa);

            //Assert
            Assert.AreEqual(titulacao, titulacaoEsperado);
        }
    }
}
