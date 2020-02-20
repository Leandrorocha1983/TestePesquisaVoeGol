using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TesteVoeGol
{
    [Binding]
    public class ConsultarSteps
    {
        IWebDriver Browser;
        private string url = "https://www.voegol.com.br/pt";

        [BeforeScenario]
        public void Init()
        {
            this.Browser = new ChromeDriver();
        }

        [AfterScenario]
        public void Close()
        {
            this.Browser.Close();
            this.Browser.Dispose();
        }
        [Given(@"Um Visitante acessou a tela inicial viajar de")]
        public void DadoUmVisitanteAcessouATelaInicialViajarDe()
        {
            this.Browser.Navigate().GoToUrl(url);
        }
        
        [Given(@"Um Visitante acessou a tela inicial para")]
        public void DadoUmVisitanteAcessouATelaInicialPara()
        {
            
        }
        
        [Given(@"Um Visitante clicou IDA")]
        public void DadoUmVisitanteClicouIDA()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Um Visitante clicou VOLTA")]
        public void DadoUmVisitanteClicouVOLTA()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Um Visitante clicou ADULTOS")]
        public void DadoUmVisitanteClicouADULTOS()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Um Visitante clicou COMPRE AQUI")]
        public void DadoUmVisitanteClicouCOMPREAQUI()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no combo box selecionar sua origem recente")]
        public void QuandoClicarNoComboBoxSelecionarSuaOrigemRecente()
        {
            var chosenplaceholderorigin = this.Browser.FindElement(By.Id("chosenplaceholderorigin"));
            chosenplaceholderorigin.Click();

        }
        
        [When(@"Clicar no combo box selecionar seus distinos recentes")]
        public void QuandoClicarNoComboBoxSelecionarSeusDistinosRecentes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no background IDA selecionar uma data dispónivel")]
        public void QuandoClicarNoBackgroundIDASelecionarUmaDataDisponivel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no background VOLTA selecionar uma data dispónivel")]
        public void QuandoClicarNoBackgroundVOLTASelecionarUmaDataDisponivel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar e Selicionar ADULTOS")]
        public void QuandoClicarESelicionarADULTOS()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"selecionar mais de uma pessoa")]
        public void QuandoSelecionarMaisDeUmaPessoa()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no Botão COMPRE AQUI")]
        public void QuandoClicarNoBotaoCOMPREAQUI()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"carregarar a página com a consulta desejado")]
        public void QuandoCarregararAPaginaComAConsultaDesejado()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"será exibido e preenchido com o campo: Rio de Janeiro - Santos Dumont - SDU")]
        public void EntaoSeraExibidoEPreenchidoComOCampoRioDeJaneiro_SantosDumont_SDU()
        {
            try
            { 
            var txtNome = this.Browser.FindElement(By.Id("txtNome"));
            }
            catch (NoSuchElementException)
            {
                Assert.Fail();
            }
        }
        
        [Then(@"será exibido e preenchido com o campo: São Paulo - Guarulhos - GRU")]
        public void EntaoSeraExibidoEPreenchidoComOCampoSaoPaulo_Guarulhos_GRU()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"será exibido o calendario com as datas dispóniveis: Mês, Ano e Dias da Semanas")]
        public void EntaoSeraExibidoOCalendarioComAsDatasDisponiveisMesAnoEDiasDaSemanas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"será exibido quantidade de pessoa que vão viajar: ADULTOS, número, anos, butão menos e mais")]
        public void EntaoSeraExibidoQuantidadeDePessoaQueVaoViajarADULTOSNumeroAnosButaoMenosEMais()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"será carregado e exibido a consulta do voo de IDA e VOLTA disponiveis para compras pelo o site: opções de voo de IDA e opções de VOLTA")]
        public void EntaoSeraCarregadoEExibidoAConsultaDoVooDeIDAEVOLTADisponiveisParaComprasPeloOSiteOpcoesDeVooDeIDAEOpcoesDeVOLTA()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"trazendo todo o historico da sua consulta: tempo de sessão, sua compra e subtotal")]
        public void EntaoTrazendoTodoOHistoricoDaSuaConsultaTempoDeSessaoSuaCompraESubtotal()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
