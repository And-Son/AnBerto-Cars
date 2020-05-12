using System;
using Xunit;
using AnBertoCars.Dominio;

namespace AnBertoCars.Teste
{
    public class testCliente
    {
        //CALCULAR IDADE POSITIVO (IDADE CORRETA)
        [Fact]
        public void TestIdadePositivo()
        {
            Cliente _cliente = new Cliente();
            _cliente.DataNasc = new DateTime(1999, 5, 27);
            var resultado = _cliente.CalculaIdade();
            Assert.Equal(20, resultado);//resultado é 20 anos
        }


        //CALCULAR IDADE NEGATIVO (IDADE ERRADA)
        [Fact]
        public void TestIdadeNegativo()
        {
            Cliente _cliente = new Cliente();
            _cliente.DataNasc = new DateTime(1999, 5, 27);
            var resultado = _cliente.CalculaIdade();
            Assert.NotEqual(0, resultado);//resultado é 20 anos
        }

        //VALIDAR CPF POSITIVO (CPF VERDADEIRO)
        [Fact]
        public void TestValidaCPFPositivo()
        {
            Cliente _cliente = new Cliente();
            _cliente.CPF = "10085308676";
            var resultado = _cliente.ValidarCPF();
            Assert.Equal(true, resultado);
        }

        
        //VALIDAR CPF NEGATIVO (CPF FALSO)
        [Fact]
        public void TestValidaCPFNegativo()
        {
            Cliente _cliente = new Cliente();
            _cliente.CPF = "10010010010";
            var resultado = _cliente.ValidarCPF();
            Assert.Equal(false, resultado);
        }
    }
}
