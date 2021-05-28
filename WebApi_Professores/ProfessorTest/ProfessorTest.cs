using Moq;
using System;
using WebApi_Professores2.Models;
using Xunit;

namespace ProfessorTest
{
    public class ProfessorTest
    {
        [Fact]
        public void VerificaIdTeste()
        {
            //Arrange
            Professores Larissa = new Professores();
            Larissa.Id = 1;
            
            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaId(Larissa)).Returns("");
            
            Professores verifica = new Professores();

            //Act
            var idEsperado = mock.Object.VerificaId(Larissa);
            var id = verifica.VerificaId(Larissa);

            //Assert
            Assert.Equal(id, idEsperado);
        }

        [Fact]
        public void VerificaNomeTeste()
        {
            Professores Larissa = new Professores();
            Larissa.Nome = "Larissa";

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaNome(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var nomeEsperado = mock.Object.VerificaNome(Larissa);
            var nome = verifica.VerificaNome(Larissa);

            //Assert
            Assert.Equal(nome, nomeEsperado);
        }
        [Fact]
        public void VerificaCredencialTeste()
        {
            Professores Larissa = new Professores();
            Larissa.Credencial = "00000000001";

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaCredencial(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var credencialEsperado = mock.Object.VerificaCredencial(Larissa);
            var credencial = verifica.VerificaCredencial(Larissa);

            //Assert
            Assert.Equal(credencial, credencialEsperado);
        }
        [Fact]
        public void VerificaDisciplinaTeste()
        {
            Professores Larissa = new Professores();
            Larissa.Disciplina = "Artes";

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaDisciplina(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var disciplinaEsperado = mock.Object.VerificaDisciplina(Larissa);
            var disciplina = verifica.VerificaDisciplina(Larissa);

            //Assert
            Assert.Equal(disciplina, disciplinaEsperado);
        }
        [Fact]
        public void VerificaHorarioTeste()
        {
            Professores Larissa = new Professores();
            Larissa.Horario = "vespertino";

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaHorario(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var horarioEsperado = mock.Object.VerificaHorario(Larissa);
            var horario = verifica.VerificaHorario(Larissa);

            //Assert
            Assert.Equal(horario, horarioEsperado);
        }
        [Fact]
        public void VerificaTitulacaoTeste()
        {
            Professores Larissa = new Professores();
            Larissa.Titulacao = "mestre";

            Mock<IVerificaProf> mock = new Mock<IVerificaProf>();
            mock.Setup(m => m.VerificaTitulacao(Larissa)).Returns("");

            Professores verifica = new Professores();

            //Act
            var titulacaoEsperado = mock.Object.VerificaTitulacao(Larissa);
            var titulacao = verifica.VerificaTitulacao(Larissa);

            //Assert
            Assert.Equal(titulacao, titulacaoEsperado);
        }
    }
}
