 public class MaquinaCafe
{

    public int Saldo { get; private set; }
    public int Stock { get; set; } = 10;

    private readonly Dictionary<string, int> _menu = new()
    {
        { "Cafe", 100 },
        { "Te", 75 },
        { "Agua", 50 }
    };

    public void InsertarMoneda(int monto)
    {
        Saldo += monto;
    }

    public bool SeleccionarBebida(string bebida)
    {
        if (!_menu.ContainsKey(bebida))
            throw new ArgumentException("La bebida no existe.");

        if (Stock <= 0)
            return false;

        if (Saldo < _menu[bebida])
            return false;

        Saldo -= _menu[bebida];
        Stock--;

        return true;
    }

    public int ObtenerCambio()
    {
        int cambio = Saldo;
        Saldo = 0;
        return cambio;
    }

    public void DevolverMonedas()
    {
        Saldo = 0;
    }

    public Dictionary<string, int> ObtenerMenu()
    {
        return _menu;
    }
}