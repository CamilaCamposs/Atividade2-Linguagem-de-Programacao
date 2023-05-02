using Classes;

var conta1= new Judo("Camila", 0);

conta1.EfetuarTransacao(100, DateTime.Now, "Kimono");
conta1.EfetuarTransacao(50, DateTime.Now, "Faixa");
conta1.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta1.ObterHistoricodeConta());

var conta2 = new Ingles("Camila", 0);

conta2.EfetuarTransacao(200, DateTime.Now, "Livro");
conta2.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta2.ObterHistoricodeConta());

var conta4 = new Futebol("Camila", 0);

conta4.EfetuarTransacao(1000, DateTime.Now, "Camiseta");
conta4.EfetuarTransacao(1000, DateTime.Now, "Shorts");
conta4.EfetuarTransacao(1000, DateTime.Now, "Chuteira");
conta4.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta4.ObterHistoricodeConta());

var conta5 = new Alimentacao("Camila", 0);

conta5.EfetuarTransacao(20, DateTime.Now, "Café");
conta5.EfetuarTransacao(50, DateTime.Now, "Compra de Mantimentos");
conta5.ExecutarTransacaoFimdeMes();

Console.WriteLine(conta5.ObterHistoricodeConta());
