using ex6.Classes;

ContaCorrente conta = new ContaCorrente(1234, 999, new Cliente("rodolfo", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.FISICA));

ContaCorrente conta2 = new ContaCorrente(1235, 998, new Cliente("rodolfa", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.FISICA));

conta.Depositar(200);
conta.Transferir(conta2, 150);
conta.ExibirSaldo();
conta2.ExibirSaldo();

