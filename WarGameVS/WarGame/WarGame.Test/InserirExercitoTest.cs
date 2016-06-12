using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarGame.Model;
using WarGame.Exceptions;


namespace WarGame.Test
{
    [TestClass]
    public class InserirExercitoTest
    {
        private Jogador _jogadorA, _jogadorB;

        [TestInitialize]
        public void StartUp()
        {
            this._jogadorA = new Jogador("Jogador A", null);
            this._jogadorB = new Jogador("Jogador B", null);
        }

        private InserirExercito CriarInsercaoExercito(Jogador jogadorTerritorio, Jogador jogadorExercito)
        {
            Territorio territorioDestino = new Territorio("Territorio A");
            territorioDestino.AddExercito(new Exercito(jogadorTerritorio));

            List<Exercito> exercitosInsercao = new List<Exercito>();
            exercitosInsercao.Add(new Exercito(jogadorExercito));

            InserirExercito ie = new InserirExercito(territorioDestino, exercitosInsercao);
            return ie;
        }

        [TestMethod]
        public void ValidarInsercaoComandanteTerritorioExercitosIguais()
        {
            var ie = this.CriarInsercaoExercito(this._jogadorA, this._jogadorA);
            Assert.AreEqual(true, ie.validarMovimento());
        }

        [TestMethod]
        public void ValidarInsercaoComandanteTerritorioExercitosDiferentes()
        {
            var ie = this.CriarInsercaoExercito(this._jogadorA, this._jogadorB);
            Assert.AreEqual(false, ie.validarMovimento());
        }

        [TestMethod]
        public void RealizarInsercaoValida()
        {
            var ie = this.CriarInsercaoExercito(this._jogadorA, this._jogadorA);
            var countExercitosAntesMovimento = ie.TerritorioDestino.CountExercitos();

            Assert.AreEqual(true, ie.validarMovimento());

            ie.realizarMovimento();
            Assert.IsTrue(ie.TerritorioDestino.CountExercitos() > countExercitosAntesMovimento); 
        }

        [TestMethod]
        public void RealizarInsercaoInvalida()
        {
            var ie = this.CriarInsercaoExercito(this._jogadorA, this._jogadorB);
            var countExercitoAntesMovimento = ie.TerritorioDestino.CountExercitos();

            Assert.AreEqual(false, ie.validarMovimento());

            try
            {
                ie.realizarMovimento();
                Assert.Fail();
            }
            catch(JogadaInvalidaException ex)
            {
                Assert.IsTrue(ie.TerritorioDestino.CountExercitos() == countExercitoAntesMovimento);
            }
        }
    }
}
