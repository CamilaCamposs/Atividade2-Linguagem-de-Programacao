namespace Classes;
public class Judo : Gastos
{
    public Judo(string nome, decimal valorInicial) : base(nome, valorInicial)
    {    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margem = (ValorAcumulado * 0.02m);
        EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Judo");
    }
}