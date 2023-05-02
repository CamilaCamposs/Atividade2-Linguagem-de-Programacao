namespace Classes;
public class Futebol : Gastos
{
    private readonly decimal _bonusFutebol = 50m;

    public Futebol(string Cliente, decimal valorInicial, decimal bonusfutebol = 50) : base(Cliente, valorInicial)
    => _bonusFutebol = bonusfutebol;
    public Futebol(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.01m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Futebol");
        if (_bonusFutebol != 0)

        {
        EfetuarTransacao(-_bonusFutebol, DateTime.Now, "Bonus Futebol");
        }
    }
}