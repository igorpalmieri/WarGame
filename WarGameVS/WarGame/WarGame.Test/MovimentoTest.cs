﻿using System;
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

        private void InicializarTerritorios(Territorio tA, Territorio tB, Jogador jogA, Jogador jogB)
        {
            //insere 3 exercitos do Jogador B no territorio A
            tA.AddExercito(new Exercito(jogA));
            tA.AddExercito(new Exercito(jogA));
            tA.AddExercito(new Exercito(jogA));

            //insere 3 exercitos do Jogador B no territorio B
            tB.AddExercito(new Exercito(jogB));
            tB.AddExercito(new Exercito(jogB));
            tB.AddExercito(new Exercito(jogB));
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
        public void MovimentoBatalha()
        {
            Territorio tA = new Territorio("Territorio A");
            Territorio tB = new Territorio("Territorio B");

            InicializarTerritorios(tA, tB, this._jogadorA, this._jogadorB);

            tA.AddFronteira(tB);

            var mov = new Movimento(this._jogadorA, tA, tB, 2);
            Assert.AreEqual(Movimento.ResultadoMovimento.BATALHA, mov.validarMovimento());
        }

        [TestMethod]
        public void MovimentoValido()
        {
            Territorio tA = new Territorio("Territorio A");
            Territorio tB = new Territorio("Territorio B");

            InicializarTerritorios(tA, tB, this._jogadorB, this._jogadorB);

            tA.AddFronteira(tB);

            var mov = new Movimento(this._jogadorB, tA, tB, 2);
            Assert.AreEqual(Movimento.ResultadoMovimento.VALIDO, mov.validarMovimento());
        }

        [TestMethod]
        public void MovimentoQuantidadeExercitosInvalida()
        {
            Assert.Fail();
        }
    }
}
