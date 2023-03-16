using ex5.Classes;

ContaBancaria conta1 = new ContaBancaria("Trump", 123, 4455, TipoContaEnum.CORRENTE);

ContaBancaria conta2 = new ContaBancaria("Trump", 123, 4466, TipoContaEnum.CORRENTE);

conta1.Depositar(200);
conta1.Transferir(conta2, 50);
conta1.ExibirSaldo();
conta2.ExibirSaldo();