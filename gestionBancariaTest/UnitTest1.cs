using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaTest;

namespace gestionBancariaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        //Pruebas Metodo Reintegro
        [TestMethod]
        public void Prueba1MetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = -1;
            double saldoActual = 0;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void Prueba2MetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = 5;
            double saldoActual = 0;
            double saldoEsperado = 995;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void Prueba3MetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = 2000;
            double saldoActual = 0;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        //Pruebas Metodo ingreso
        [TestMethod]
        public void Prueba1MetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = -1;
            double saldoActual = 0;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            
            cuenta.realizarIngreso(ingreso);
            
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void Prueba2MetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoActual = 0;
            double saldoEsperado = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            
            cuenta.realizarIngreso(ingreso);
            
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void Prueba3MetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 1;
            double saldoActual = 0;
            double saldoEsperado = 1001;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            
            cuenta.realizarIngreso(ingreso);
            
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
