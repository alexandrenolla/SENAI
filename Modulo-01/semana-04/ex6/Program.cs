using ex6.Classes;

ContaCorrente conta = new ContaCorrente(1234, 999, new Cliente("rodolfo", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.FISICA));

ContaCorrente conta2 = new ContaCorrente(1235, 998, new Cliente("rodolfa", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.FISICA));

conta.Depositar(200);
conta.Transferir(conta2, 150);
conta.ExibirSaldo();
conta2.ExibirSaldo();

conta.Sacar(30);
conta.ExibirSaldo();


ContaEmpresarial conta3 = new ContaEmpresarial(1234, 999, new Cliente("rodolfo", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.JURIDICA), 10000, 50, 0, "88888");

ContaEmpresarial conta4 = new ContaEmpresarial(1235, 998, new Cliente("rodolfa", DateTime.Parse("1999-05-05"), "cantor", "amante", TipoPessoaEnum.JURIDICA), 10000, 50, 0, "88888");


conta3.Depositar(200);
conta3.Transferir(conta4, 150);
conta3.ExibirSaldo();
conta4.ExibirSaldo();

conta3.Sacar(30);
conta3.ExibirSaldo();

conta3.FazerEmprestimo(160);
conta3.ExibirSaldo();
conta3.PagarEmprestimo();
