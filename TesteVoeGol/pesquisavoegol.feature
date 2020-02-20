#language: pt-br

Funcinalidade: ConsultaAereaGol
	Como um usuário
	Desejo fazer uma pesquisa de compra de passagem aerea para dois adultos
	Assim posso usar a funcionalidade para consultar a menor tarifa do dia
	
	
Cenário: 1) Quando o usuário acessar a página incial do site VoeGol
	Dado Um Visitante acessou a tela inicial viajar de
	Quando Clicar no combo box selecionar sua origem recente
	Então será exibido e preenchido com o campo: Rio de Janeiro - Santos Dumont - SDU

	
	
Cenário: 2) Quando o usuário acessar a página incial do site VoeGol
	Dado Um Visitante acessou a tela inicial para
	Quando Clicar no combo box selecionar seus distinos recentes
	Então será exibido e preenchido com o campo: São Paulo - Guarulhos - GRU 

Cenário: 3) Quando o usuário acessar a página incial do site VoeGol
	Dado Um Visitante clicou IDA
	Quando Clicar no background IDA selecionar uma data dispónivel
	Então será exibido o calendario com as datas dispóniveis: Mês, Ano e Dias da Semanas
	
Cenário: 4) Quando o usuário acessar a página incial do site VoeGol
	Dado Um Visitante clicou VOLTA
	Quando Clicar no background VOLTA selecionar uma data dispónivel
	Então será exibido o calendario com as datas dispóniveis: Mês, Ano e Dias da Semanas

Cenário: 5) Quando o usuário acessar a página inicial do site VoeGol
	Dado Um Visitante clicou ADULTOS
	Quando Clicar e Selicionar ADULTOS
	E selecionar mais de uma pessoa 
	Então será exibido quantidade de pessoa que vão viajar: ADULTOS, número, anos, butão menos e mais 
	
Cenário: 6) Quando o usuário tiver preenchido todas as informações e todos os campos da consulta Comprar passagem VoeGol
	Dado Um Visitante clicou COMPRE AQUI
	Quando Clicar no Botão COMPRE AQUI
	E carregarar a página com a consulta desejado
	Então será carregado e exibido a consulta do voo de IDA e VOLTA disponiveis para compras pelo o site: opções de voo de IDA e opções de VOLTA
	E trazendo todo o historico da sua consulta: tempo de sessão, sua compra e subtotal