using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarGame.Model;
using WarGame.Exceptions;
using System.Collections.Generic;

namespace WarGame.Test
{
    [TestClass]
    public class MovimentoTest
    {
        private Jogador _jogadorA, _jogadorB;

        [TestInitialize]
        public void StartUp()
        {
            this._jogadorA = new Jogador("Jogador A", null);
            this._jogadorB = new Jogador("Jogador B", null);
        }

        [TestMethod]
        public void MovimentoSemFronteira()
        {
            Territorio territorioA = new Territorio("Territorio A");
            Territorio territorioB = new Territorio("Territorio A");

            var movimento = new Movimento(null, territorioA, territorioB, 0);
            Assert.AreEqual(Movimento.ResultadoMovimento.SEM_FRONTEIRA, movimento.validarMovimento());
        }

        [TestMethod]
        public void MovimentoQuantidadeExercitosInvalida()
        {
            Assert.Fail();
        }
    }
}
