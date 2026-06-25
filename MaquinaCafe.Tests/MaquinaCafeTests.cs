using NUnit.Framework;

[TestFixture]
public class MaquinaCafeTests
{
private MaquinaCafe _maquina;

[SetUp]
public void Inicializar()
{
     _maquina = new MaquinaCafe();
}

// TC-01
[Test]
public void InsertarMoneda_DebeAcumularSaldo()
{
_maquina.InsertarMoneda(25);
Assert.That(_maquina.Saldo, Is.EqualTo(25));
}

// TC-02
[Test]
public void SeleccionarBebida_SaldoSuficiente_RetornaTrue()
{
_maquina.InsertarMoneda(100);
Assert.That(_maquina.SeleccionarBebida("Cafe"), Is.True);
}

// TC-03
[Test]
public void SeleccionarBebida_SaldoInsuficiente_RetornaFalse()
    {
        _maquina.InsertarMoneda(50);
        Assert.That(_maquina.SeleccionarBebida("Cafe"), Is.False);
    }

// TC-04
[Test]
public void  ObtenerCambio_DebeRetornarCambioCorrecto()
    {
        _maquina.InsertarMoneda(150);
        _maquina.SeleccionarBebida("Cafe");

        Assert.That(_maquina.ObtenerCambio(), Is.EqualTo(50));
    }

// TC-05
[Test]                                                                          
public void SeleccionarBebida_Inexistente_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() => 
        _maquina.SeleccionarBebida("Jugo"));
    }

//TC-06
[Test]
public void ObtenerMenu_DebeContenerTresBebidas()
    {
        var menu = _maquina.ObtenerMenu();

        Assert.That(menu.Count, Is.EqualTo(3));
        Assert.That(menu["Cafe"], Is.EqualTo(100));
        Assert.That(menu["Te"], Is.EqualTo(75));
        Assert.That(menu["Agua"], Is.EqualTo(50));
    }

//TC-07
[Test]
public void DevolverMonedas_DebeReiniciarSaldo()
    {
         _maquina.InsertarMoneda(100);
         _maquina.DevolverMonedas();

         Assert.That(_maquina.Saldo, Is.EqualTo(0));
    }
    
//TC-08
[Test]
public void SeleccionarBebida_StockAgotado_RetornaFalse()
{
    _maquina.Stock = 0;

    Assert.That(_maquina.SeleccionarBebida("Cafe"), Is.False);
}

}