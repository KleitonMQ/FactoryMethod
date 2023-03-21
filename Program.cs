using FactoryMethod;

//Variavel de controle para criação de objetos do tipo brinquedo e eletronico.
Criador criadorBrinquedo = new CriadorBrinquedo();
Criador criadorEletronico = new CriadorEletronico();

//Variavel que vai receber o objeto instanciado para utilizar os produtos, brinquedo e eletronico
Produto produtoEletronico = criadorEletronico.CriarProduto();
Produto produtoBrinquedo = criadorBrinquedo.CriarProduto();

produtoBrinquedo.Utilizar();
produtoEletronico.Utilizar();