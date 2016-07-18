
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/02/2013 10:02:01
-- Generated from EDMX file: D:\Desenvolvimento\Projetos\CMaster 2013\Canaan.Dados\CanaanModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Canaan];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GrupoEmpresaFilial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Filial] DROP CONSTRAINT [FK_GrupoEmpresaFilial];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Estado] DROP CONSTRAINT [FK_PaisEstado];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoCidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cidade] DROP CONSTRAINT [FK_EstadoCidade];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadeFilial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Filial] DROP CONSTRAINT [FK_CidadeFilial];
GO
IF OBJECT_ID(N'[dbo].[FK_BancoAgencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agencia] DROP CONSTRAINT [FK_BancoAgencia];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadeAgencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agencia] DROP CONSTRAINT [FK_CidadeAgencia];
GO
IF OBJECT_ID(N'[dbo].[FK_AgenciaConta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Conta] DROP CONSTRAINT [FK_AgenciaConta];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadeCliFor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CliFor] DROP CONSTRAINT [FK_CidadeCliFor];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido] DROP CONSTRAINT [FK_FilialPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_CliForPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido] DROP CONSTRAINT [FK_CliForPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_CliForCliForReferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CliForReferencia] DROP CONSTRAINT [FK_CliForCliForReferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioUsuarioFilial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioFilial] DROP CONSTRAINT [FK_UsuarioUsuarioFilial];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialUsuarioFilial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioFilial] DROP CONSTRAINT [FK_FilialUsuarioFilial];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioGrupoUsuarioFilial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioFilial] DROP CONSTRAINT [FK_UsuarioGrupoUsuarioFilial];
GO
IF OBJECT_ID(N'[dbo].[FK_ConvenioParceria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parceria] DROP CONSTRAINT [FK_ConvenioParceria];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialParceria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parceria] DROP CONSTRAINT [FK_FilialParceria];
GO
IF OBJECT_ID(N'[dbo].[FK_ParceriaCupom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cupom] DROP CONSTRAINT [FK_ParceriaCupom];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialAgenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agenda] DROP CONSTRAINT [FK_FilialAgenda];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioCupom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cupom] DROP CONSTRAINT [FK_UsuarioCupom];
GO
IF OBJECT_ID(N'[dbo].[FK_CupomAgendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agendamento] DROP CONSTRAINT [FK_CupomAgendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_AgendaAgendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agendamento] DROP CONSTRAINT [FK_AgendaAgendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_AgendamentoAgendamentoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AgendamentoMov] DROP CONSTRAINT [FK_AgendamentoAgendamentoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioAgendamentoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AgendamentoMov] DROP CONSTRAINT [FK_UsuarioAgendamentoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_CliForModelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Modelo] DROP CONSTRAINT [FK_CliForModelo];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloModeloResp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeloResp] DROP CONSTRAINT [FK_ModeloModeloResp];
GO
IF OBJECT_ID(N'[dbo].[FK_AgendamentoAtendimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Atendimento] DROP CONSTRAINT [FK_AgendamentoAtendimento];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioAtendimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Atendimento] DROP CONSTRAINT [FK_UsuarioAtendimento];
GO
IF OBJECT_ID(N'[dbo].[FK_CliForAtendimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Atendimento] DROP CONSTRAINT [FK_CliForAtendimento];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialAtendimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Atendimento] DROP CONSTRAINT [FK_FilialAtendimento];
GO
IF OBJECT_ID(N'[dbo].[FK_AtendimentoAtendimentoModelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AtendimentoModelo] DROP CONSTRAINT [FK_AtendimentoAtendimentoModelo];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloAtendimentoModelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AtendimentoModelo] DROP CONSTRAINT [FK_ModeloAtendimentoModelo];
GO
IF OBJECT_ID(N'[dbo].[FK_AtendimentoVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido_Venda] DROP CONSTRAINT [FK_AtendimentoVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_AtendimentoSessao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessao] DROP CONSTRAINT [FK_AtendimentoSessao];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioSessao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessao] DROP CONSTRAINT [FK_UsuarioSessao];
GO
IF OBJECT_ID(N'[dbo].[FK_SessaoFoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Foto] DROP CONSTRAINT [FK_SessaoFoto];
GO
IF OBJECT_ID(N'[dbo].[FK_TabelaProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [FK_TabelaProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoProdutoServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutoServico] DROP CONSTRAINT [FK_ProdutoProdutoServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoProdutoServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutoServico] DROP CONSTRAINT [FK_ServicoProdutoServico];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaVendaItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaItem] DROP CONSTRAINT [FK_VendaVendaItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoVendaItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaItem] DROP CONSTRAINT [FK_ProdutoVendaItem];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraCompraItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraItem] DROP CONSTRAINT [FK_CompraCompraItem];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaPgtoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido] DROP CONSTRAINT [FK_FormaPgtoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaEntradaVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido_Venda] DROP CONSTRAINT [FK_FormaEntradaVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaVendaMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaMov] DROP CONSTRAINT [FK_VendaVendaMov];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioVendaMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaMov] DROP CONSTRAINT [FK_UsuarioVendaMov];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoCompraMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraMov] DROP CONSTRAINT [FK_PedidoCompraMov];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioCompraMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraMov] DROP CONSTRAINT [FK_UsuarioCompraMov];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaVendaFoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaFoto] DROP CONSTRAINT [FK_VendaVendaFoto];
GO
IF OBJECT_ID(N'[dbo].[FK_FotoVendaFoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaFoto] DROP CONSTRAINT [FK_FotoVendaFoto];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaOrdemServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServico] DROP CONSTRAINT [FK_VendaOrdemServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoOrdemServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServico] DROP CONSTRAINT [FK_ServicoOrdemServico];
GO
IF OBJECT_ID(N'[dbo].[FK_MolduraOrdemServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServico] DROP CONSTRAINT [FK_MolduraOrdemServico];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbumOrdemServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServico] DROP CONSTRAINT [FK_AlbumOrdemServico];
GO
IF OBJECT_ID(N'[dbo].[FK_OrdemServicoOrdemServicoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServicoMov] DROP CONSTRAINT [FK_OrdemServicoOrdemServicoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioOrdemServicoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServicoMov] DROP CONSTRAINT [FK_UsuarioOrdemServicoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_OrdemServicoOrdemServicoItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServicoItem] DROP CONSTRAINT [FK_OrdemServicoOrdemServicoItem];
GO
IF OBJECT_ID(N'[dbo].[FK_FotoOrdemServicoItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServicoItem] DROP CONSTRAINT [FK_FotoOrdemServicoItem];
GO
IF OBJECT_ID(N'[dbo].[FK_EfeitoDigitalOrdemServicoItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdemServicoItem] DROP CONSTRAINT [FK_EfeitoDigitalOrdemServicoItem];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPedidoLancamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoLancamento] DROP CONSTRAINT [FK_PedidoPedidoLancamento];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialContaCaixa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContaCaixa] DROP CONSTRAINT [FK_FilialContaCaixa];
GO
IF OBJECT_ID(N'[dbo].[FK_ContaContaCaixa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContaCaixa] DROP CONSTRAINT [FK_ContaContaCaixa];
GO
IF OBJECT_ID(N'[dbo].[FK_CliForLancamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lancamento] DROP CONSTRAINT [FK_CliForLancamento];
GO
IF OBJECT_ID(N'[dbo].[FK_FilialLancamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lancamento] DROP CONSTRAINT [FK_FilialLancamento];
GO
IF OBJECT_ID(N'[dbo].[FK_ContaCaixaLancamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lancamento] DROP CONSTRAINT [FK_ContaCaixaLancamento];
GO
IF OBJECT_ID(N'[dbo].[FK_LancamentoLancamentoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LancamentoMov] DROP CONSTRAINT [FK_LancamentoLancamentoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioLancamentoMov]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LancamentoMov] DROP CONSTRAINT [FK_UsuarioLancamentoMov];
GO
IF OBJECT_ID(N'[dbo].[FK_LancamentoExtrato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Extrato] DROP CONSTRAINT [FK_LancamentoExtrato];
GO
IF OBJECT_ID(N'[dbo].[FK_ContaCaixaExtrato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Extrato] DROP CONSTRAINT [FK_ContaCaixaExtrato];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioExtrato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Extrato] DROP CONSTRAINT [FK_UsuarioExtrato];
GO
IF OBJECT_ID(N'[dbo].[FK_LancamentoLancamentoHist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LancamentoHist] DROP CONSTRAINT [FK_LancamentoLancamentoHist];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioLancamentoHist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LancamentoHist] DROP CONSTRAINT [FK_UsuarioLancamentoHist];
GO
IF OBJECT_ID(N'[dbo].[FK_AtendimentoAtendimentoHist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AtendimentoHist] DROP CONSTRAINT [FK_AtendimentoAtendimentoHist];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioAtendimentoHist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AtendimentoHist] DROP CONSTRAINT [FK_UsuarioAtendimentoHist];
GO
IF OBJECT_ID(N'[dbo].[FK_Venda_inherits_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido_Venda] DROP CONSTRAINT [FK_Venda_inherits_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_Compra_inherits_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedido_Compra] DROP CONSTRAINT [FK_Compra_inherits_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaFisica_inherits_CliFor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CliFor_PessoaFisica] DROP CONSTRAINT [FK_PessoaFisica_inherits_CliFor];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaJuridica_inherits_CliFor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CliFor_PessoaJuridica] DROP CONSTRAINT [FK_PessoaJuridica_inherits_CliFor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GrupoEmpresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GrupoEmpresa];
GO
IF OBJECT_ID(N'[dbo].[Filial]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filial];
GO
IF OBJECT_ID(N'[dbo].[Pais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pais];
GO
IF OBJECT_ID(N'[dbo].[Estado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estado];
GO
IF OBJECT_ID(N'[dbo].[Cidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cidade];
GO
IF OBJECT_ID(N'[dbo].[Banco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Banco];
GO
IF OBJECT_ID(N'[dbo].[Agencia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agencia];
GO
IF OBJECT_ID(N'[dbo].[Conta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Conta];
GO
IF OBJECT_ID(N'[dbo].[CliFor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CliFor];
GO
IF OBJECT_ID(N'[dbo].[Pedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedido];
GO
IF OBJECT_ID(N'[dbo].[CliForReferencia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CliForReferencia];
GO
IF OBJECT_ID(N'[dbo].[UsuarioGrupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioGrupo];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[dbo].[UsuarioFilial]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioFilial];
GO
IF OBJECT_ID(N'[dbo].[Convenio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Convenio];
GO
IF OBJECT_ID(N'[dbo].[Parceria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parceria];
GO
IF OBJECT_ID(N'[dbo].[Cupom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cupom];
GO
IF OBJECT_ID(N'[dbo].[Agenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agenda];
GO
IF OBJECT_ID(N'[dbo].[Agendamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agendamento];
GO
IF OBJECT_ID(N'[dbo].[AgendamentoMov]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AgendamentoMov];
GO
IF OBJECT_ID(N'[dbo].[Atendimento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Atendimento];
GO
IF OBJECT_ID(N'[dbo].[Modelo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Modelo];
GO
IF OBJECT_ID(N'[dbo].[ModeloResp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeloResp];
GO
IF OBJECT_ID(N'[dbo].[AtendimentoModelo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AtendimentoModelo];
GO
IF OBJECT_ID(N'[dbo].[Sessao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sessao];
GO
IF OBJECT_ID(N'[dbo].[Foto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Foto];
GO
IF OBJECT_ID(N'[dbo].[Tabela]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tabela];
GO
IF OBJECT_ID(N'[dbo].[Produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produto];
GO
IF OBJECT_ID(N'[dbo].[Servico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servico];
GO
IF OBJECT_ID(N'[dbo].[ProdutoServico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutoServico];
GO
IF OBJECT_ID(N'[dbo].[Album]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Album];
GO
IF OBJECT_ID(N'[dbo].[Moldura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moldura];
GO
IF OBJECT_ID(N'[dbo].[EfeitoDigital]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EfeitoDigital];
GO
IF OBJECT_ID(N'[dbo].[VendaItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendaItem];
GO
IF OBJECT_ID(N'[dbo].[CompraItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompraItem];
GO
IF OBJECT_ID(N'[dbo].[FormaPgto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaPgto];
GO
IF OBJECT_ID(N'[dbo].[FormaEntrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaEntrada];
GO
IF OBJECT_ID(N'[dbo].[VendaMov]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendaMov];
GO
IF OBJECT_ID(N'[dbo].[CompraMov]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompraMov];
GO
IF OBJECT_ID(N'[dbo].[VendaFoto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendaFoto];
GO
IF OBJECT_ID(N'[dbo].[OrdemServico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdemServico];
GO
IF OBJECT_ID(N'[dbo].[OrdemServicoMov]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdemServicoMov];
GO
IF OBJECT_ID(N'[dbo].[OrdemServicoItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdemServicoItem];
GO
IF OBJECT_ID(N'[dbo].[PedidoLancamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoLancamento];
GO
IF OBJECT_ID(N'[dbo].[Lancamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lancamento];
GO
IF OBJECT_ID(N'[dbo].[ContaCaixa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContaCaixa];
GO
IF OBJECT_ID(N'[dbo].[LancamentoMov]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LancamentoMov];
GO
IF OBJECT_ID(N'[dbo].[Extrato]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Extrato];
GO
IF OBJECT_ID(N'[dbo].[LancamentoHist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LancamentoHist];
GO
IF OBJECT_ID(N'[dbo].[AtendimentoHist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AtendimentoHist];
GO
IF OBJECT_ID(N'[dbo].[Pedido_Venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedido_Venda];
GO
IF OBJECT_ID(N'[dbo].[Pedido_Compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedido_Compra];
GO
IF OBJECT_ID(N'[dbo].[CliFor_PessoaFisica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CliFor_PessoaFisica];
GO
IF OBJECT_ID(N'[dbo].[CliFor_PessoaJuridica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CliFor_PessoaJuridica];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GrupoEmpresa'
CREATE TABLE [dbo].[GrupoEmpresa] (
    [IdGrupoEmpresa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Descricao] nvarchar(250)  NULL,
    [IsFranquia] bit  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Filial'
CREATE TABLE [dbo].[Filial] (
    [IdFilial] int IDENTITY(1,1) NOT NULL,
    [IdGrupoEmpresa] int  NOT NULL,
    [IdCidade] int  NOT NULL,
    [RazaoSocial] nvarchar(100)  NOT NULL,
    [NomeFantasia] nvarchar(100)  NOT NULL,
    [Cnpj] nvarchar(20)  NOT NULL,
    [Endereco] nvarchar(150)  NOT NULL,
    [Numero] nvarchar(50)  NULL,
    [Complemento] nvarchar(50)  NULL,
    [Bairro] nvarchar(100)  NULL,
    [Cep] nvarchar(20)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [Telefone] nvarchar(20)  NULL,
    [Celular] nvarchar(20)  NULL,
    [Fax] nvarchar(20)  NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Pais'
CREATE TABLE [dbo].[Pais] (
    [IdPais] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [IdEstado] int IDENTITY(1,1) NOT NULL,
    [IdPais] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Abreviatura] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'Cidade'
CREATE TABLE [dbo].[Cidade] (
    [IdCidade] int IDENTITY(1,1) NOT NULL,
    [IdEstado] int  NOT NULL,
    [Nome] nvarchar(150)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Banco'
CREATE TABLE [dbo].[Banco] (
    [IdBanco] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Abreviacao] nvarchar(20)  NULL,
    [Numero] nvarchar(20)  NOT NULL,
    [Digito] nvarchar(20)  NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Agencia'
CREATE TABLE [dbo].[Agencia] (
    [IdAgencia] int IDENTITY(1,1) NOT NULL,
    [IdBanco] int  NOT NULL,
    [IdCidade] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Telefone] nvarchar(20)  NOT NULL,
    [Celular] nvarchar(20)  NULL,
    [Gerente] nvarchar(100)  NULL,
    [Email] nvarchar(100)  NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Conta'
CREATE TABLE [dbo].[Conta] (
    [IdConta] int IDENTITY(1,1) NOT NULL,
    [IdAgencia] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [ContaNumero] nvarchar(20)  NOT NULL,
    [ContaDigito] nvarchar(10)  NOT NULL,
    [CarteiraNumero] nvarchar(20)  NULL,
    [CarteiraDigito] nvarchar(10)  NULL,
    [CedenteNome] nvarchar(100)  NULL,
    [CedenteCnjp] nvarchar(20)  NULL,
    [CedenteNumero] nvarchar(20)  NULL,
    [CedenteDigito] nvarchar(10)  NULL,
    [ConvenioNumero] nvarchar(20)  NULL,
    [ConvenioDigito] nvarchar(10)  NULL,
    [TipoConta] int  NOT NULL,
    [TipoCobranca] int  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'CliFor'
CREATE TABLE [dbo].[CliFor] (
    [IdCliFor] int IDENTITY(1,1) NOT NULL,
    [IdCidade] int  NOT NULL,
    [Tipo] int  NOT NULL,
    [Email] nvarchar(100)  NULL,
    [Endereco] nvarchar(200)  NOT NULL,
    [Numero] nvarchar(50)  NULL,
    [Complemento] nvarchar(50)  NULL,
    [Bairro] nvarchar(100)  NULL,
    [Cep] nvarchar(20)  NULL,
    [Telefone] nvarchar(20)  NOT NULL,
    [Telefone2] nvarchar(20)  NOT NULL,
    [Telefone3] nvarchar(20)  NOT NULL,
    [Celular] nvarchar(20)  NOT NULL,
    [Celular2] nvarchar(20)  NULL,
    [Celular3] nvarchar(20)  NULL,
    [Fax] nvarchar(20)  NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Pedido'
CREATE TABLE [dbo].[Pedido] (
    [IdPedido] int IDENTITY(1,1) NOT NULL,
    [IdFilial] int  NOT NULL,
    [IdCliFor] int  NOT NULL,
    [IdFormaPgto] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [DataEmissao] datetime  NOT NULL,
    [ClasseContabil] int  NOT NULL,
    [ValorBruto] decimal(18,0)  NOT NULL,
    [ValorDesconto] decimal(18,0)  NOT NULL,
    [ValorAcrescimo] decimal(18,0)  NOT NULL,
    [ValorLiquido] decimal(18,0)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'CliForReferencia'
CREATE TABLE [dbo].[CliForReferencia] (
    [IdReferencia] int IDENTITY(1,1) NOT NULL,
    [IdCliFor] int  NOT NULL,
    [Tipo] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Endereco] nvarchar(150)  NULL,
    [Telefone] nvarchar(20)  NOT NULL,
    [Celular] nvarchar(20)  NULL
);
GO

-- Creating table 'UsuarioGrupo'
CREATE TABLE [dbo].[UsuarioGrupo] (
    [IdUsuarioGrupo] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [IsAdmin] bit  NOT NULL,
    [IsGerente] bit  NOT NULL,
    [IsSupervisor] bit  NOT NULL,
    [IsFinanceiro] bit  NOT NULL,
    [IsComercial] bit  NOT NULL,
    [IsProducao] bit  NOT NULL,
    [IsMarketing] bit  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Sobrenome] nvarchar(100)  NOT NULL,
    [Email] nvarchar(100)  NULL,
    [Telefone] nvarchar(20)  NULL,
    [Celular] nvarchar(20)  NULL,
    [Username] nvarchar(50)  NOT NULL,
    [Password] nvarchar(15)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'UsuarioFilial'
CREATE TABLE [dbo].[UsuarioFilial] (
    [IdUsuarioFilial] int IDENTITY(1,1) NOT NULL,
    [IdUsuario] int  NOT NULL,
    [IdFilial] int  NOT NULL,
    [IdUsuarioGrupo] int  NOT NULL
);
GO

-- Creating table 'Convenio'
CREATE TABLE [dbo].[Convenio] (
    [IdConvenio] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Tipo] int  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Parceria'
CREATE TABLE [dbo].[Parceria] (
    [IdParceria] int IDENTITY(1,1) NOT NULL,
    [IdConvenio] int  NOT NULL,
    [IdFilial] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [DataInicio] datetime  NULL,
    [DataFim] datetime  NULL,
    [DataRetirada] datetime  NULL,
    [ContatoNome] nvarchar(100)  NULL,
    [ContatoTel] nvarchar(20)  NULL,
    [ContatoCel] nvarchar(20)  NULL,
    [ContatoEmail] nvarchar(100)  NULL,
    [IsRetirada] bit  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Cupom'
CREATE TABLE [dbo].[Cupom] (
    [IdCupom] int IDENTITY(1,1) NOT NULL,
    [IdParceria] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [DataPreenchimento] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Email] nvarchar(100)  NULL,
    [Endereco] nvarchar(max)  NULL,
    [Telefone] nvarchar(20)  NOT NULL,
    [Celular] nvarchar(20)  NULL,
    [Obs] nvarchar(max)  NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Agenda'
CREATE TABLE [dbo].[Agenda] (
    [IdAgenda] int IDENTITY(1,1) NOT NULL,
    [IdFilial] int  NOT NULL,
    [Distancia] int  NOT NULL,
    [SegInicio] time  NOT NULL,
    [SegFim] time  NOT NULL,
    [TerInicio] time  NOT NULL,
    [TerFim] time  NOT NULL,
    [QuaInicio] time  NOT NULL,
    [QuaFim] time  NOT NULL,
    [QuiInicio] time  NOT NULL,
    [QuiFim] time  NOT NULL,
    [SexInicio] time  NOT NULL,
    [SexFim] time  NOT NULL,
    [SabInicio] time  NOT NULL,
    [SabFim] time  NOT NULL,
    [DomInicio] time  NOT NULL,
    [DomFim] time  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Agendamento'
CREATE TABLE [dbo].[Agendamento] (
    [IdAgendamento] int IDENTITY(1,1) NOT NULL,
    [IdCupom] int  NOT NULL,
    [IdAgenda] int  NOT NULL,
    [Status] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Hora] time  NOT NULL
);
GO

-- Creating table 'AgendamentoMov'
CREATE TABLE [dbo].[AgendamentoMov] (
    [IdAgendamentoMov] int IDENTITY(1,1) NOT NULL,
    [IdAgendamento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Status] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Hora] time  NOT NULL
);
GO

-- Creating table 'Atendimento'
CREATE TABLE [dbo].[Atendimento] (
    [IdAtendimento] int IDENTITY(1,1) NOT NULL,
    [IdFilial] int  NOT NULL,
    [IdCliFor] int  NOT NULL,
    [IdAgendamento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Modelo'
CREATE TABLE [dbo].[Modelo] (
    [IdModelo] int IDENTITY(1,1) NOT NULL,
    [IdCliFor] int  NOT NULL,
    [IdCidade] nvarchar(max)  NOT NULL,
    [NomeCompleto] nvarchar(max)  NOT NULL,
    [Sexo] int  NOT NULL,
    [Nascimento] datetime  NOT NULL,
    [Cpf] nvarchar(20)  NOT NULL,
    [Rg] nvarchar(50)  NULL,
    [Email] nvarchar(100)  NULL,
    [Telefone] nvarchar(20)  NULL,
    [Celular] nvarchar(20)  NULL,
    [Endereco] nvarchar(200)  NOT NULL,
    [Numero] nvarchar(50)  NULL,
    [Complemento] nvarchar(50)  NULL,
    [Bairro] nvarchar(100)  NULL,
    [Cep] nvarchar(20)  NULL,
    [IsEmancipado] nvarchar(max)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'ModeloResp'
CREATE TABLE [dbo].[ModeloResp] (
    [IdModeloResp] int IDENTITY(1,1) NOT NULL,
    [IdModelo] int  NOT NULL,
    [Tipo] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Cpf] nvarchar(20)  NOT NULL,
    [Rg] nvarchar(50)  NULL,
    [Telefone] nvarchar(20)  NULL,
    [Celular] nvarchar(20)  NULL
);
GO

-- Creating table 'AtendimentoModelo'
CREATE TABLE [dbo].[AtendimentoModelo] (
    [IdAtendimentoModelo] int IDENTITY(1,1) NOT NULL,
    [IdAtendimento] int  NOT NULL,
    [IdModelo] int  NOT NULL
);
GO

-- Creating table 'Sessao'
CREATE TABLE [dbo].[Sessao] (
    [IdSessao] int IDENTITY(1,1) NOT NULL,
    [IdAtendimento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Tipo] int  NOT NULL,
    [Genero] int  NOT NULL,
    [NumSessao] int  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Foto'
CREATE TABLE [dbo].[Foto] (
    [IdFoto] int IDENTITY(1,1) NOT NULL,
    [IdSessao] int  NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Url] nvarchar(100)  NOT NULL,
    [Tamanho] int  NOT NULL,
    [MimeType] nvarchar(50)  NOT NULL,
    [IsAtivo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tabela'
CREATE TABLE [dbo].[Tabela] (
    [IdTabela] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Competencia] int  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Produto'
CREATE TABLE [dbo].[Produto] (
    [IdProduto] int IDENTITY(1,1) NOT NULL,
    [IdTabela] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Custo] decimal(18,0)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Servico'
CREATE TABLE [dbo].[Servico] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [PrevisaoEntrega] int  NOT NULL,
    [HasAlbum] bit  NOT NULL,
    [HasMoldura] bit  NOT NULL,
    [HasVoltagem] nvarchar(max)  NOT NULL,
    [IsBrindeCpc] bit  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'ProdutoServico'
CREATE TABLE [dbo].[ProdutoServico] (
    [IdComposicao] int IDENTITY(1,1) NOT NULL,
    [IdProduto] int  NOT NULL,
    [IdServico] int  NOT NULL,
    [Quantidade] int  NOT NULL
);
GO

-- Creating table 'Album'
CREATE TABLE [dbo].[Album] (
    [IdAlbum] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'Moldura'
CREATE TABLE [dbo].[Moldura] (
    [IdMoldura] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'EfeitoDigital'
CREATE TABLE [dbo].[EfeitoDigital] (
    [IdEfeito] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'VendaItem'
CREATE TABLE [dbo].[VendaItem] (
    [IdItem] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdProduto] int  NOT NULL,
    [Quant] decimal(18,0)  NOT NULL,
    [ValorUnitario] decimal(18,0)  NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'CompraItem'
CREATE TABLE [dbo].[CompraItem] (
    [IdItem] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [Produto] nvarchar(50)  NOT NULL,
    [Quant] decimal(18,0)  NOT NULL,
    [ValorUnitario] decimal(18,0)  NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'FormaPgto'
CREATE TABLE [dbo].[FormaPgto] (
    [IdFormaPgto] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [NumParcela] int  NOT NULL,
    [DistParcela] int  NOT NULL,
    [DistEntrada] int  NOT NULL,
    [Juros] decimal(18,0)  NOT NULL,
    [Desconto] decimal(18,0)  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'FormaEntrada'
CREATE TABLE [dbo].[FormaEntrada] (
    [IdFormaEntrada] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Parcelas] int  NOT NULL
);
GO

-- Creating table 'VendaMov'
CREATE TABLE [dbo].[VendaMov] (
    [IdMov] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'CompraMov'
CREATE TABLE [dbo].[CompraMov] (
    [IdMov] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'VendaFoto'
CREATE TABLE [dbo].[VendaFoto] (
    [IdVendaFoto] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdFoto] int  NOT NULL
);
GO

-- Creating table 'OrdemServico'
CREATE TABLE [dbo].[OrdemServico] (
    [IdOrdemServico] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [IdServico] int  NOT NULL,
    [IdAlbum] int  NOT NULL,
    [IdMoldura] int  NOT NULL,
    [NomeAbertura] nvarchar(100)  NULL,
    [Data] datetime  NOT NULL,
    [DataPrevista] datetime  NOT NULL,
    [Observacao] nvarchar(max)  NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'OrdemServicoMov'
CREATE TABLE [dbo].[OrdemServicoMov] (
    [IdMov] int IDENTITY(1,1) NOT NULL,
    [IdOrdemServico] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'OrdemServicoItem'
CREATE TABLE [dbo].[OrdemServicoItem] (
    [IdItem] int IDENTITY(1,1) NOT NULL,
    [IdOrdemServico] int  NOT NULL,
    [IdFoto] int  NOT NULL,
    [IdEfeito] int  NOT NULL,
    [Quantidade] int  NOT NULL,
    [Observacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidoLancamento'
CREATE TABLE [dbo].[PedidoLancamento] (
    [IdLancamento] int IDENTITY(1,1) NOT NULL,
    [IdPedido] int  NOT NULL,
    [Vencimento] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [IsEntrada] bit  NOT NULL
);
GO

-- Creating table 'Lancamento'
CREATE TABLE [dbo].[Lancamento] (
    [IdLancamento] int IDENTITY(1,1) NOT NULL,
    [IdCliFor] int  NOT NULL,
    [IdFilial] int  NOT NULL,
    [IdContaCaixa] int  NOT NULL,
    [Tipo] int  NOT NULL,
    [Status] int  NOT NULL,
    [ClasseContabil] int  NOT NULL,
    [DataEmissao] datetime  NOT NULL,
    [DataVencimento] datetime  NOT NULL,
    [DataBaixa] datetime  NULL,
    [DataAgendamento] datetime  NULL,
    [ValorOriginal] decimal(18,0)  NOT NULL,
    [ValorJuros] decimal(18,0)  NOT NULL,
    [ValorMulta] decimal(18,0)  NOT NULL,
    [ValorDesconto] decimal(18,0)  NOT NULL,
    [ValorAcrescimo] decimal(18,0)  NOT NULL,
    [ValorLiquido] decimal(18,0)  NOT NULL,
    [ValorBaixado] decimal(18,0)  NULL,
    [NossoNumero] nvarchar(100)  NULL,
    [Ipte] nvarchar(100)  NULL,
    [CodigoBarras] nvarchar(100)  NULL,
    [IsEntrada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ContaCaixa'
CREATE TABLE [dbo].[ContaCaixa] (
    [IdContaCaixa] int IDENTITY(1,1) NOT NULL,
    [IdFilial] int  NOT NULL,
    [IdConta] int  NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [IsCaixa] bit  NOT NULL,
    [IsPadrao] bit  NOT NULL,
    [IsAtivo] bit  NOT NULL
);
GO

-- Creating table 'LancamentoMov'
CREATE TABLE [dbo].[LancamentoMov] (
    [IdMov] int IDENTITY(1,1) NOT NULL,
    [IdLancamento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Status] int  NOT NULL
);
GO

-- Creating table 'Extrato'
CREATE TABLE [dbo].[Extrato] (
    [IdExtrato] int IDENTITY(1,1) NOT NULL,
    [IdLancamento] int  NOT NULL,
    [IdContaCaixa] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [TipoPgto] int  NOT NULL,
    [Status] int  NOT NULL,
    [ValorLiquido] decimal(18,0)  NOT NULL,
    [ValorPago] decimal(18,0)  NOT NULL,
    [ValorTroco] decimal(18,0)  NOT NULL,
    [ValorBaixado] decimal(18,0)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Hora] time  NOT NULL
);
GO

-- Creating table 'LancamentoHist'
CREATE TABLE [dbo].[LancamentoHist] (
    [IdHist] int IDENTITY(1,1) NOT NULL,
    [IdLancamento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Observacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AtendimentoHist'
CREATE TABLE [dbo].[AtendimentoHist] (
    [IdHist] int IDENTITY(1,1) NOT NULL,
    [IdAtendimento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Observacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pedido_Venda'
CREATE TABLE [dbo].[Pedido_Venda] (
    [IdAtendimento] int  NOT NULL,
    [IdFormaEntrada] int  NOT NULL,
    [Status] int  NOT NULL,
    [ValorEntrada] decimal(18,0)  NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [IsFaturado] bit  NOT NULL,
    [DataFaturamento] datetime  NULL,
    [IsLiberado] bit  NOT NULL,
    [DataLiberacao] datetime  NULL,
    [IdPedido] int  NOT NULL
);
GO

-- Creating table 'Pedido_Compra'
CREATE TABLE [dbo].[Pedido_Compra] (
    [NumNota] nvarchar(max)  NOT NULL,
    [DataEntrada] datetime  NULL,
    [DataStatus] datetime  NULL,
    [Status] int  NOT NULL,
    [IdPedido] int  NOT NULL
);
GO

-- Creating table 'CliFor_PessoaFisica'
CREATE TABLE [dbo].[CliFor_PessoaFisica] (
    [NomeCompleto] nvarchar(150)  NOT NULL,
    [Nascimento] datetime  NOT NULL,
    [Cpf] nvarchar(20)  NOT NULL,
    [Rg] nvarchar(50)  NULL,
    [NomePai] nvarchar(150)  NULL,
    [NomeMae] nvarchar(150)  NULL,
    [Sexo] int  NOT NULL,
    [EstadoCivil] int  NOT NULL,
    [Conjuge] nvarchar(150)  NULL,
    [IdCliFor] int  NOT NULL
);
GO

-- Creating table 'CliFor_PessoaJuridica'
CREATE TABLE [dbo].[CliFor_PessoaJuridica] (
    [RazaoSocial] nvarchar(150)  NOT NULL,
    [NomeFantasia] nvarchar(150)  NOT NULL,
    [Cnpj] nvarchar(20)  NOT NULL,
    [InscSocial] nvarchar(50)  NULL,
    [IdCliFor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdGrupoEmpresa] in table 'GrupoEmpresa'
ALTER TABLE [dbo].[GrupoEmpresa]
ADD CONSTRAINT [PK_GrupoEmpresa]
    PRIMARY KEY CLUSTERED ([IdGrupoEmpresa] ASC);
GO

-- Creating primary key on [IdFilial] in table 'Filial'
ALTER TABLE [dbo].[Filial]
ADD CONSTRAINT [PK_Filial]
    PRIMARY KEY CLUSTERED ([IdFilial] ASC);
GO

-- Creating primary key on [IdPais] in table 'Pais'
ALTER TABLE [dbo].[Pais]
ADD CONSTRAINT [PK_Pais]
    PRIMARY KEY CLUSTERED ([IdPais] ASC);
GO

-- Creating primary key on [IdEstado] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([IdEstado] ASC);
GO

-- Creating primary key on [IdCidade] in table 'Cidade'
ALTER TABLE [dbo].[Cidade]
ADD CONSTRAINT [PK_Cidade]
    PRIMARY KEY CLUSTERED ([IdCidade] ASC);
GO

-- Creating primary key on [IdBanco] in table 'Banco'
ALTER TABLE [dbo].[Banco]
ADD CONSTRAINT [PK_Banco]
    PRIMARY KEY CLUSTERED ([IdBanco] ASC);
GO

-- Creating primary key on [IdAgencia] in table 'Agencia'
ALTER TABLE [dbo].[Agencia]
ADD CONSTRAINT [PK_Agencia]
    PRIMARY KEY CLUSTERED ([IdAgencia] ASC);
GO

-- Creating primary key on [IdConta] in table 'Conta'
ALTER TABLE [dbo].[Conta]
ADD CONSTRAINT [PK_Conta]
    PRIMARY KEY CLUSTERED ([IdConta] ASC);
GO

-- Creating primary key on [IdCliFor] in table 'CliFor'
ALTER TABLE [dbo].[CliFor]
ADD CONSTRAINT [PK_CliFor]
    PRIMARY KEY CLUSTERED ([IdCliFor] ASC);
GO

-- Creating primary key on [IdPedido] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [PK_Pedido]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdReferencia] in table 'CliForReferencia'
ALTER TABLE [dbo].[CliForReferencia]
ADD CONSTRAINT [PK_CliForReferencia]
    PRIMARY KEY CLUSTERED ([IdReferencia] ASC);
GO

-- Creating primary key on [IdUsuarioGrupo] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [PK_UsuarioGrupo]
    PRIMARY KEY CLUSTERED ([IdUsuarioGrupo] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdUsuarioFilial] in table 'UsuarioFilial'
ALTER TABLE [dbo].[UsuarioFilial]
ADD CONSTRAINT [PK_UsuarioFilial]
    PRIMARY KEY CLUSTERED ([IdUsuarioFilial] ASC);
GO

-- Creating primary key on [IdConvenio] in table 'Convenio'
ALTER TABLE [dbo].[Convenio]
ADD CONSTRAINT [PK_Convenio]
    PRIMARY KEY CLUSTERED ([IdConvenio] ASC);
GO

-- Creating primary key on [IdParceria] in table 'Parceria'
ALTER TABLE [dbo].[Parceria]
ADD CONSTRAINT [PK_Parceria]
    PRIMARY KEY CLUSTERED ([IdParceria] ASC);
GO

-- Creating primary key on [IdCupom] in table 'Cupom'
ALTER TABLE [dbo].[Cupom]
ADD CONSTRAINT [PK_Cupom]
    PRIMARY KEY CLUSTERED ([IdCupom] ASC);
GO

-- Creating primary key on [IdAgenda] in table 'Agenda'
ALTER TABLE [dbo].[Agenda]
ADD CONSTRAINT [PK_Agenda]
    PRIMARY KEY CLUSTERED ([IdAgenda] ASC);
GO

-- Creating primary key on [IdAgendamento] in table 'Agendamento'
ALTER TABLE [dbo].[Agendamento]
ADD CONSTRAINT [PK_Agendamento]
    PRIMARY KEY CLUSTERED ([IdAgendamento] ASC);
GO

-- Creating primary key on [IdAgendamentoMov] in table 'AgendamentoMov'
ALTER TABLE [dbo].[AgendamentoMov]
ADD CONSTRAINT [PK_AgendamentoMov]
    PRIMARY KEY CLUSTERED ([IdAgendamentoMov] ASC);
GO

-- Creating primary key on [IdAtendimento] in table 'Atendimento'
ALTER TABLE [dbo].[Atendimento]
ADD CONSTRAINT [PK_Atendimento]
    PRIMARY KEY CLUSTERED ([IdAtendimento] ASC);
GO

-- Creating primary key on [IdModelo] in table 'Modelo'
ALTER TABLE [dbo].[Modelo]
ADD CONSTRAINT [PK_Modelo]
    PRIMARY KEY CLUSTERED ([IdModelo] ASC);
GO

-- Creating primary key on [IdModeloResp] in table 'ModeloResp'
ALTER TABLE [dbo].[ModeloResp]
ADD CONSTRAINT [PK_ModeloResp]
    PRIMARY KEY CLUSTERED ([IdModeloResp] ASC);
GO

-- Creating primary key on [IdAtendimentoModelo] in table 'AtendimentoModelo'
ALTER TABLE [dbo].[AtendimentoModelo]
ADD CONSTRAINT [PK_AtendimentoModelo]
    PRIMARY KEY CLUSTERED ([IdAtendimentoModelo] ASC);
GO

-- Creating primary key on [IdSessao] in table 'Sessao'
ALTER TABLE [dbo].[Sessao]
ADD CONSTRAINT [PK_Sessao]
    PRIMARY KEY CLUSTERED ([IdSessao] ASC);
GO

-- Creating primary key on [IdFoto] in table 'Foto'
ALTER TABLE [dbo].[Foto]
ADD CONSTRAINT [PK_Foto]
    PRIMARY KEY CLUSTERED ([IdFoto] ASC);
GO

-- Creating primary key on [IdTabela] in table 'Tabela'
ALTER TABLE [dbo].[Tabela]
ADD CONSTRAINT [PK_Tabela]
    PRIMARY KEY CLUSTERED ([IdTabela] ASC);
GO

-- Creating primary key on [IdProduto] in table 'Produto'
ALTER TABLE [dbo].[Produto]
ADD CONSTRAINT [PK_Produto]
    PRIMARY KEY CLUSTERED ([IdProduto] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [PK_Servico]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdComposicao] in table 'ProdutoServico'
ALTER TABLE [dbo].[ProdutoServico]
ADD CONSTRAINT [PK_ProdutoServico]
    PRIMARY KEY CLUSTERED ([IdComposicao] ASC);
GO

-- Creating primary key on [IdAlbum] in table 'Album'
ALTER TABLE [dbo].[Album]
ADD CONSTRAINT [PK_Album]
    PRIMARY KEY CLUSTERED ([IdAlbum] ASC);
GO

-- Creating primary key on [IdMoldura] in table 'Moldura'
ALTER TABLE [dbo].[Moldura]
ADD CONSTRAINT [PK_Moldura]
    PRIMARY KEY CLUSTERED ([IdMoldura] ASC);
GO

-- Creating primary key on [IdEfeito] in table 'EfeitoDigital'
ALTER TABLE [dbo].[EfeitoDigital]
ADD CONSTRAINT [PK_EfeitoDigital]
    PRIMARY KEY CLUSTERED ([IdEfeito] ASC);
GO

-- Creating primary key on [IdItem] in table 'VendaItem'
ALTER TABLE [dbo].[VendaItem]
ADD CONSTRAINT [PK_VendaItem]
    PRIMARY KEY CLUSTERED ([IdItem] ASC);
GO

-- Creating primary key on [IdItem] in table 'CompraItem'
ALTER TABLE [dbo].[CompraItem]
ADD CONSTRAINT [PK_CompraItem]
    PRIMARY KEY CLUSTERED ([IdItem] ASC);
GO

-- Creating primary key on [IdFormaPgto] in table 'FormaPgto'
ALTER TABLE [dbo].[FormaPgto]
ADD CONSTRAINT [PK_FormaPgto]
    PRIMARY KEY CLUSTERED ([IdFormaPgto] ASC);
GO

-- Creating primary key on [IdFormaEntrada] in table 'FormaEntrada'
ALTER TABLE [dbo].[FormaEntrada]
ADD CONSTRAINT [PK_FormaEntrada]
    PRIMARY KEY CLUSTERED ([IdFormaEntrada] ASC);
GO

-- Creating primary key on [IdMov] in table 'VendaMov'
ALTER TABLE [dbo].[VendaMov]
ADD CONSTRAINT [PK_VendaMov]
    PRIMARY KEY CLUSTERED ([IdMov] ASC);
GO

-- Creating primary key on [IdMov] in table 'CompraMov'
ALTER TABLE [dbo].[CompraMov]
ADD CONSTRAINT [PK_CompraMov]
    PRIMARY KEY CLUSTERED ([IdMov] ASC);
GO

-- Creating primary key on [IdVendaFoto] in table 'VendaFoto'
ALTER TABLE [dbo].[VendaFoto]
ADD CONSTRAINT [PK_VendaFoto]
    PRIMARY KEY CLUSTERED ([IdVendaFoto] ASC);
GO

-- Creating primary key on [IdOrdemServico] in table 'OrdemServico'
ALTER TABLE [dbo].[OrdemServico]
ADD CONSTRAINT [PK_OrdemServico]
    PRIMARY KEY CLUSTERED ([IdOrdemServico] ASC);
GO

-- Creating primary key on [IdMov] in table 'OrdemServicoMov'
ALTER TABLE [dbo].[OrdemServicoMov]
ADD CONSTRAINT [PK_OrdemServicoMov]
    PRIMARY KEY CLUSTERED ([IdMov] ASC);
GO

-- Creating primary key on [IdItem] in table 'OrdemServicoItem'
ALTER TABLE [dbo].[OrdemServicoItem]
ADD CONSTRAINT [PK_OrdemServicoItem]
    PRIMARY KEY CLUSTERED ([IdItem] ASC);
GO

-- Creating primary key on [IdLancamento] in table 'PedidoLancamento'
ALTER TABLE [dbo].[PedidoLancamento]
ADD CONSTRAINT [PK_PedidoLancamento]
    PRIMARY KEY CLUSTERED ([IdLancamento] ASC);
GO

-- Creating primary key on [IdLancamento] in table 'Lancamento'
ALTER TABLE [dbo].[Lancamento]
ADD CONSTRAINT [PK_Lancamento]
    PRIMARY KEY CLUSTERED ([IdLancamento] ASC);
GO

-- Creating primary key on [IdContaCaixa] in table 'ContaCaixa'
ALTER TABLE [dbo].[ContaCaixa]
ADD CONSTRAINT [PK_ContaCaixa]
    PRIMARY KEY CLUSTERED ([IdContaCaixa] ASC);
GO

-- Creating primary key on [IdMov] in table 'LancamentoMov'
ALTER TABLE [dbo].[LancamentoMov]
ADD CONSTRAINT [PK_LancamentoMov]
    PRIMARY KEY CLUSTERED ([IdMov] ASC);
GO

-- Creating primary key on [IdExtrato] in table 'Extrato'
ALTER TABLE [dbo].[Extrato]
ADD CONSTRAINT [PK_Extrato]
    PRIMARY KEY CLUSTERED ([IdExtrato] ASC);
GO

-- Creating primary key on [IdHist] in table 'LancamentoHist'
ALTER TABLE [dbo].[LancamentoHist]
ADD CONSTRAINT [PK_LancamentoHist]
    PRIMARY KEY CLUSTERED ([IdHist] ASC);
GO

-- Creating primary key on [IdHist] in table 'AtendimentoHist'
ALTER TABLE [dbo].[AtendimentoHist]
ADD CONSTRAINT [PK_AtendimentoHist]
    PRIMARY KEY CLUSTERED ([IdHist] ASC);
GO

-- Creating primary key on [IdPedido] in table 'Pedido_Venda'
ALTER TABLE [dbo].[Pedido_Venda]
ADD CONSTRAINT [PK_Pedido_Venda]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdPedido] in table 'Pedido_Compra'
ALTER TABLE [dbo].[Pedido_Compra]
ADD CONSTRAINT [PK_Pedido_Compra]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdCliFor] in table 'CliFor_PessoaFisica'
ALTER TABLE [dbo].[CliFor_PessoaFisica]
ADD CONSTRAINT [PK_CliFor_PessoaFisica]
    PRIMARY KEY CLUSTERED ([IdCliFor] ASC);
GO

-- Creating primary key on [IdCliFor] in table 'CliFor_PessoaJuridica'
ALTER TABLE [dbo].[CliFor_PessoaJuridica]
ADD CONSTRAINT [PK_CliFor_PessoaJuridica]
    PRIMARY KEY CLUSTERED ([IdCliFor] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdGrupoEmpresa] in table 'Filial'
ALTER TABLE [dbo].[Filial]
ADD CONSTRAINT [FK_GrupoEmpresaFilial]
    FOREIGN KEY ([IdGrupoEmpresa])
    REFERENCES [dbo].[GrupoEmpresa]
        ([IdGrupoEmpresa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GrupoEmpresaFilial'
CREATE INDEX [IX_FK_GrupoEmpresaFilial]
ON [dbo].[Filial]
    ([IdGrupoEmpresa]);
GO

-- Creating foreign key on [IdPais] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [FK_PaisEstado]
    FOREIGN KEY ([IdPais])
    REFERENCES [dbo].[Pais]
        ([IdPais])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisEstado'
CREATE INDEX [IX_FK_PaisEstado]
ON [dbo].[Estado]
    ([IdPais]);
GO

-- Creating foreign key on [IdEstado] in table 'Cidade'
ALTER TABLE [dbo].[Cidade]
ADD CONSTRAINT [FK_EstadoCidade]
    FOREIGN KEY ([IdEstado])
    REFERENCES [dbo].[Estado]
        ([IdEstado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoCidade'
CREATE INDEX [IX_FK_EstadoCidade]
ON [dbo].[Cidade]
    ([IdEstado]);
GO

-- Creating foreign key on [IdCidade] in table 'Filial'
ALTER TABLE [dbo].[Filial]
ADD CONSTRAINT [FK_CidadeFilial]
    FOREIGN KEY ([IdCidade])
    REFERENCES [dbo].[Cidade]
        ([IdCidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadeFilial'
CREATE INDEX [IX_FK_CidadeFilial]
ON [dbo].[Filial]
    ([IdCidade]);
GO

-- Creating foreign key on [IdBanco] in table 'Agencia'
ALTER TABLE [dbo].[Agencia]
ADD CONSTRAINT [FK_BancoAgencia]
    FOREIGN KEY ([IdBanco])
    REFERENCES [dbo].[Banco]
        ([IdBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BancoAgencia'
CREATE INDEX [IX_FK_BancoAgencia]
ON [dbo].[Agencia]
    ([IdBanco]);
GO

-- Creating foreign key on [IdCidade] in table 'Agencia'
ALTER TABLE [dbo].[Agencia]
ADD CONSTRAINT [FK_CidadeAgencia]
    FOREIGN KEY ([IdCidade])
    REFERENCES [dbo].[Cidade]
        ([IdCidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadeAgencia'
CREATE INDEX [IX_FK_CidadeAgencia]
ON [dbo].[Agencia]
    ([IdCidade]);
GO

-- Creating foreign key on [IdAgencia] in table 'Conta'
ALTER TABLE [dbo].[Conta]
ADD CONSTRAINT [FK_AgenciaConta]
    FOREIGN KEY ([IdAgencia])
    REFERENCES [dbo].[Agencia]
        ([IdAgencia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgenciaConta'
CREATE INDEX [IX_FK_AgenciaConta]
ON [dbo].[Conta]
    ([IdAgencia]);
GO

-- Creating foreign key on [IdCidade] in table 'CliFor'
ALTER TABLE [dbo].[CliFor]
ADD CONSTRAINT [FK_CidadeCliFor]
    FOREIGN KEY ([IdCidade])
    REFERENCES [dbo].[Cidade]
        ([IdCidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CidadeCliFor'
CREATE INDEX [IX_FK_CidadeCliFor]
ON [dbo].[CliFor]
    ([IdCidade]);
GO

-- Creating foreign key on [IdFilial] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_FilialPedido]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialPedido'
CREATE INDEX [IX_FK_FilialPedido]
ON [dbo].[Pedido]
    ([IdFilial]);
GO

-- Creating foreign key on [IdCliFor] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_CliForPedido]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CliForPedido'
CREATE INDEX [IX_FK_CliForPedido]
ON [dbo].[Pedido]
    ([IdCliFor]);
GO

-- Creating foreign key on [IdCliFor] in table 'CliForReferencia'
ALTER TABLE [dbo].[CliForReferencia]
ADD CONSTRAINT [FK_CliForCliForReferencia]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CliForCliForReferencia'
CREATE INDEX [IX_FK_CliForCliForReferencia]
ON [dbo].[CliForReferencia]
    ([IdCliFor]);
GO

-- Creating foreign key on [IdUsuario] in table 'UsuarioFilial'
ALTER TABLE [dbo].[UsuarioFilial]
ADD CONSTRAINT [FK_UsuarioUsuarioFilial]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioUsuarioFilial'
CREATE INDEX [IX_FK_UsuarioUsuarioFilial]
ON [dbo].[UsuarioFilial]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdFilial] in table 'UsuarioFilial'
ALTER TABLE [dbo].[UsuarioFilial]
ADD CONSTRAINT [FK_FilialUsuarioFilial]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialUsuarioFilial'
CREATE INDEX [IX_FK_FilialUsuarioFilial]
ON [dbo].[UsuarioFilial]
    ([IdFilial]);
GO

-- Creating foreign key on [IdUsuarioGrupo] in table 'UsuarioFilial'
ALTER TABLE [dbo].[UsuarioFilial]
ADD CONSTRAINT [FK_UsuarioGrupoUsuarioFilial]
    FOREIGN KEY ([IdUsuarioGrupo])
    REFERENCES [dbo].[UsuarioGrupo]
        ([IdUsuarioGrupo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupoUsuarioFilial'
CREATE INDEX [IX_FK_UsuarioGrupoUsuarioFilial]
ON [dbo].[UsuarioFilial]
    ([IdUsuarioGrupo]);
GO

-- Creating foreign key on [IdConvenio] in table 'Parceria'
ALTER TABLE [dbo].[Parceria]
ADD CONSTRAINT [FK_ConvenioParceria]
    FOREIGN KEY ([IdConvenio])
    REFERENCES [dbo].[Convenio]
        ([IdConvenio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConvenioParceria'
CREATE INDEX [IX_FK_ConvenioParceria]
ON [dbo].[Parceria]
    ([IdConvenio]);
GO

-- Creating foreign key on [IdFilial] in table 'Parceria'
ALTER TABLE [dbo].[Parceria]
ADD CONSTRAINT [FK_FilialParceria]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialParceria'
CREATE INDEX [IX_FK_FilialParceria]
ON [dbo].[Parceria]
    ([IdFilial]);
GO

-- Creating foreign key on [IdParceria] in table 'Cupom'
ALTER TABLE [dbo].[Cupom]
ADD CONSTRAINT [FK_ParceriaCupom]
    FOREIGN KEY ([IdParceria])
    REFERENCES [dbo].[Parceria]
        ([IdParceria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ParceriaCupom'
CREATE INDEX [IX_FK_ParceriaCupom]
ON [dbo].[Cupom]
    ([IdParceria]);
GO

-- Creating foreign key on [IdFilial] in table 'Agenda'
ALTER TABLE [dbo].[Agenda]
ADD CONSTRAINT [FK_FilialAgenda]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialAgenda'
CREATE INDEX [IX_FK_FilialAgenda]
ON [dbo].[Agenda]
    ([IdFilial]);
GO

-- Creating foreign key on [IdUsuario] in table 'Cupom'
ALTER TABLE [dbo].[Cupom]
ADD CONSTRAINT [FK_UsuarioCupom]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioCupom'
CREATE INDEX [IX_FK_UsuarioCupom]
ON [dbo].[Cupom]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdCupom] in table 'Agendamento'
ALTER TABLE [dbo].[Agendamento]
ADD CONSTRAINT [FK_CupomAgendamento]
    FOREIGN KEY ([IdCupom])
    REFERENCES [dbo].[Cupom]
        ([IdCupom])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CupomAgendamento'
CREATE INDEX [IX_FK_CupomAgendamento]
ON [dbo].[Agendamento]
    ([IdCupom]);
GO

-- Creating foreign key on [IdAgenda] in table 'Agendamento'
ALTER TABLE [dbo].[Agendamento]
ADD CONSTRAINT [FK_AgendaAgendamento]
    FOREIGN KEY ([IdAgenda])
    REFERENCES [dbo].[Agenda]
        ([IdAgenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgendaAgendamento'
CREATE INDEX [IX_FK_AgendaAgendamento]
ON [dbo].[Agendamento]
    ([IdAgenda]);
GO

-- Creating foreign key on [IdAgendamento] in table 'AgendamentoMov'
ALTER TABLE [dbo].[AgendamentoMov]
ADD CONSTRAINT [FK_AgendamentoAgendamentoMov]
    FOREIGN KEY ([IdAgendamento])
    REFERENCES [dbo].[Agendamento]
        ([IdAgendamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgendamentoAgendamentoMov'
CREATE INDEX [IX_FK_AgendamentoAgendamentoMov]
ON [dbo].[AgendamentoMov]
    ([IdAgendamento]);
GO

-- Creating foreign key on [IdUsuario] in table 'AgendamentoMov'
ALTER TABLE [dbo].[AgendamentoMov]
ADD CONSTRAINT [FK_UsuarioAgendamentoMov]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioAgendamentoMov'
CREATE INDEX [IX_FK_UsuarioAgendamentoMov]
ON [dbo].[AgendamentoMov]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdCliFor] in table 'Modelo'
ALTER TABLE [dbo].[Modelo]
ADD CONSTRAINT [FK_CliForModelo]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CliForModelo'
CREATE INDEX [IX_FK_CliForModelo]
ON [dbo].[Modelo]
    ([IdCliFor]);
GO

-- Creating foreign key on [IdModelo] in table 'ModeloResp'
ALTER TABLE [dbo].[ModeloResp]
ADD CONSTRAINT [FK_ModeloModeloResp]
    FOREIGN KEY ([IdModelo])
    REFERENCES [dbo].[Modelo]
        ([IdModelo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloModeloResp'
CREATE INDEX [IX_FK_ModeloModeloResp]
ON [dbo].[ModeloResp]
    ([IdModelo]);
GO

-- Creating foreign key on [IdAgendamento] in table 'Atendimento'
ALTER TABLE [dbo].[Atendimento]
ADD CONSTRAINT [FK_AgendamentoAtendimento]
    FOREIGN KEY ([IdAgendamento])
    REFERENCES [dbo].[Agendamento]
        ([IdAgendamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgendamentoAtendimento'
CREATE INDEX [IX_FK_AgendamentoAtendimento]
ON [dbo].[Atendimento]
    ([IdAgendamento]);
GO

-- Creating foreign key on [IdUsuario] in table 'Atendimento'
ALTER TABLE [dbo].[Atendimento]
ADD CONSTRAINT [FK_UsuarioAtendimento]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioAtendimento'
CREATE INDEX [IX_FK_UsuarioAtendimento]
ON [dbo].[Atendimento]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdCliFor] in table 'Atendimento'
ALTER TABLE [dbo].[Atendimento]
ADD CONSTRAINT [FK_CliForAtendimento]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CliForAtendimento'
CREATE INDEX [IX_FK_CliForAtendimento]
ON [dbo].[Atendimento]
    ([IdCliFor]);
GO

-- Creating foreign key on [IdFilial] in table 'Atendimento'
ALTER TABLE [dbo].[Atendimento]
ADD CONSTRAINT [FK_FilialAtendimento]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialAtendimento'
CREATE INDEX [IX_FK_FilialAtendimento]
ON [dbo].[Atendimento]
    ([IdFilial]);
GO

-- Creating foreign key on [IdAtendimento] in table 'AtendimentoModelo'
ALTER TABLE [dbo].[AtendimentoModelo]
ADD CONSTRAINT [FK_AtendimentoAtendimentoModelo]
    FOREIGN KEY ([IdAtendimento])
    REFERENCES [dbo].[Atendimento]
        ([IdAtendimento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AtendimentoAtendimentoModelo'
CREATE INDEX [IX_FK_AtendimentoAtendimentoModelo]
ON [dbo].[AtendimentoModelo]
    ([IdAtendimento]);
GO

-- Creating foreign key on [IdModelo] in table 'AtendimentoModelo'
ALTER TABLE [dbo].[AtendimentoModelo]
ADD CONSTRAINT [FK_ModeloAtendimentoModelo]
    FOREIGN KEY ([IdModelo])
    REFERENCES [dbo].[Modelo]
        ([IdModelo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloAtendimentoModelo'
CREATE INDEX [IX_FK_ModeloAtendimentoModelo]
ON [dbo].[AtendimentoModelo]
    ([IdModelo]);
GO

-- Creating foreign key on [IdAtendimento] in table 'Pedido_Venda'
ALTER TABLE [dbo].[Pedido_Venda]
ADD CONSTRAINT [FK_AtendimentoVenda]
    FOREIGN KEY ([IdAtendimento])
    REFERENCES [dbo].[Atendimento]
        ([IdAtendimento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AtendimentoVenda'
CREATE INDEX [IX_FK_AtendimentoVenda]
ON [dbo].[Pedido_Venda]
    ([IdAtendimento]);
GO

-- Creating foreign key on [IdAtendimento] in table 'Sessao'
ALTER TABLE [dbo].[Sessao]
ADD CONSTRAINT [FK_AtendimentoSessao]
    FOREIGN KEY ([IdAtendimento])
    REFERENCES [dbo].[Atendimento]
        ([IdAtendimento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AtendimentoSessao'
CREATE INDEX [IX_FK_AtendimentoSessao]
ON [dbo].[Sessao]
    ([IdAtendimento]);
GO

-- Creating foreign key on [IdUsuario] in table 'Sessao'
ALTER TABLE [dbo].[Sessao]
ADD CONSTRAINT [FK_UsuarioSessao]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioSessao'
CREATE INDEX [IX_FK_UsuarioSessao]
ON [dbo].[Sessao]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdSessao] in table 'Foto'
ALTER TABLE [dbo].[Foto]
ADD CONSTRAINT [FK_SessaoFoto]
    FOREIGN KEY ([IdSessao])
    REFERENCES [dbo].[Sessao]
        ([IdSessao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SessaoFoto'
CREATE INDEX [IX_FK_SessaoFoto]
ON [dbo].[Foto]
    ([IdSessao]);
GO

-- Creating foreign key on [IdTabela] in table 'Produto'
ALTER TABLE [dbo].[Produto]
ADD CONSTRAINT [FK_TabelaProduto]
    FOREIGN KEY ([IdTabela])
    REFERENCES [dbo].[Tabela]
        ([IdTabela])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TabelaProduto'
CREATE INDEX [IX_FK_TabelaProduto]
ON [dbo].[Produto]
    ([IdTabela]);
GO

-- Creating foreign key on [IdProduto] in table 'ProdutoServico'
ALTER TABLE [dbo].[ProdutoServico]
ADD CONSTRAINT [FK_ProdutoProdutoServico]
    FOREIGN KEY ([IdProduto])
    REFERENCES [dbo].[Produto]
        ([IdProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoProdutoServico'
CREATE INDEX [IX_FK_ProdutoProdutoServico]
ON [dbo].[ProdutoServico]
    ([IdProduto]);
GO

-- Creating foreign key on [IdServico] in table 'ProdutoServico'
ALTER TABLE [dbo].[ProdutoServico]
ADD CONSTRAINT [FK_ServicoProdutoServico]
    FOREIGN KEY ([IdServico])
    REFERENCES [dbo].[Servico]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoProdutoServico'
CREATE INDEX [IX_FK_ServicoProdutoServico]
ON [dbo].[ProdutoServico]
    ([IdServico]);
GO

-- Creating foreign key on [IdPedido] in table 'VendaItem'
ALTER TABLE [dbo].[VendaItem]
ADD CONSTRAINT [FK_VendaVendaItem]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido_Venda]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaVendaItem'
CREATE INDEX [IX_FK_VendaVendaItem]
ON [dbo].[VendaItem]
    ([IdPedido]);
GO

-- Creating foreign key on [IdProduto] in table 'VendaItem'
ALTER TABLE [dbo].[VendaItem]
ADD CONSTRAINT [FK_ProdutoVendaItem]
    FOREIGN KEY ([IdProduto])
    REFERENCES [dbo].[Produto]
        ([IdProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoVendaItem'
CREATE INDEX [IX_FK_ProdutoVendaItem]
ON [dbo].[VendaItem]
    ([IdProduto]);
GO

-- Creating foreign key on [IdPedido] in table 'CompraItem'
ALTER TABLE [dbo].[CompraItem]
ADD CONSTRAINT [FK_CompraCompraItem]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido_Compra]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraCompraItem'
CREATE INDEX [IX_FK_CompraCompraItem]
ON [dbo].[CompraItem]
    ([IdPedido]);
GO

-- Creating foreign key on [IdFormaPgto] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_FormaPgtoPedido]
    FOREIGN KEY ([IdFormaPgto])
    REFERENCES [dbo].[FormaPgto]
        ([IdFormaPgto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaPgtoPedido'
CREATE INDEX [IX_FK_FormaPgtoPedido]
ON [dbo].[Pedido]
    ([IdFormaPgto]);
GO

-- Creating foreign key on [IdFormaEntrada] in table 'Pedido_Venda'
ALTER TABLE [dbo].[Pedido_Venda]
ADD CONSTRAINT [FK_FormaEntradaVenda]
    FOREIGN KEY ([IdFormaEntrada])
    REFERENCES [dbo].[FormaEntrada]
        ([IdFormaEntrada])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaEntradaVenda'
CREATE INDEX [IX_FK_FormaEntradaVenda]
ON [dbo].[Pedido_Venda]
    ([IdFormaEntrada]);
GO

-- Creating foreign key on [IdPedido] in table 'VendaMov'
ALTER TABLE [dbo].[VendaMov]
ADD CONSTRAINT [FK_VendaVendaMov]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido_Venda]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaVendaMov'
CREATE INDEX [IX_FK_VendaVendaMov]
ON [dbo].[VendaMov]
    ([IdPedido]);
GO

-- Creating foreign key on [IdUsuario] in table 'VendaMov'
ALTER TABLE [dbo].[VendaMov]
ADD CONSTRAINT [FK_UsuarioVendaMov]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioVendaMov'
CREATE INDEX [IX_FK_UsuarioVendaMov]
ON [dbo].[VendaMov]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdPedido] in table 'CompraMov'
ALTER TABLE [dbo].[CompraMov]
ADD CONSTRAINT [FK_PedidoCompraMov]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCompraMov'
CREATE INDEX [IX_FK_PedidoCompraMov]
ON [dbo].[CompraMov]
    ([IdPedido]);
GO

-- Creating foreign key on [IdUsuario] in table 'CompraMov'
ALTER TABLE [dbo].[CompraMov]
ADD CONSTRAINT [FK_UsuarioCompraMov]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioCompraMov'
CREATE INDEX [IX_FK_UsuarioCompraMov]
ON [dbo].[CompraMov]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdPedido] in table 'VendaFoto'
ALTER TABLE [dbo].[VendaFoto]
ADD CONSTRAINT [FK_VendaVendaFoto]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido_Venda]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaVendaFoto'
CREATE INDEX [IX_FK_VendaVendaFoto]
ON [dbo].[VendaFoto]
    ([IdPedido]);
GO

-- Creating foreign key on [IdFoto] in table 'VendaFoto'
ALTER TABLE [dbo].[VendaFoto]
ADD CONSTRAINT [FK_FotoVendaFoto]
    FOREIGN KEY ([IdFoto])
    REFERENCES [dbo].[Foto]
        ([IdFoto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FotoVendaFoto'
CREATE INDEX [IX_FK_FotoVendaFoto]
ON [dbo].[VendaFoto]
    ([IdFoto]);
GO

-- Creating foreign key on [IdPedido] in table 'OrdemServico'
ALTER TABLE [dbo].[OrdemServico]
ADD CONSTRAINT [FK_VendaOrdemServico]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido_Venda]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaOrdemServico'
CREATE INDEX [IX_FK_VendaOrdemServico]
ON [dbo].[OrdemServico]
    ([IdPedido]);
GO

-- Creating foreign key on [IdServico] in table 'OrdemServico'
ALTER TABLE [dbo].[OrdemServico]
ADD CONSTRAINT [FK_ServicoOrdemServico]
    FOREIGN KEY ([IdServico])
    REFERENCES [dbo].[Servico]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoOrdemServico'
CREATE INDEX [IX_FK_ServicoOrdemServico]
ON [dbo].[OrdemServico]
    ([IdServico]);
GO

-- Creating foreign key on [IdMoldura] in table 'OrdemServico'
ALTER TABLE [dbo].[OrdemServico]
ADD CONSTRAINT [FK_MolduraOrdemServico]
    FOREIGN KEY ([IdMoldura])
    REFERENCES [dbo].[Moldura]
        ([IdMoldura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MolduraOrdemServico'
CREATE INDEX [IX_FK_MolduraOrdemServico]
ON [dbo].[OrdemServico]
    ([IdMoldura]);
GO

-- Creating foreign key on [IdAlbum] in table 'OrdemServico'
ALTER TABLE [dbo].[OrdemServico]
ADD CONSTRAINT [FK_AlbumOrdemServico]
    FOREIGN KEY ([IdAlbum])
    REFERENCES [dbo].[Album]
        ([IdAlbum])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumOrdemServico'
CREATE INDEX [IX_FK_AlbumOrdemServico]
ON [dbo].[OrdemServico]
    ([IdAlbum]);
GO

-- Creating foreign key on [IdOrdemServico] in table 'OrdemServicoMov'
ALTER TABLE [dbo].[OrdemServicoMov]
ADD CONSTRAINT [FK_OrdemServicoOrdemServicoMov]
    FOREIGN KEY ([IdOrdemServico])
    REFERENCES [dbo].[OrdemServico]
        ([IdOrdemServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrdemServicoOrdemServicoMov'
CREATE INDEX [IX_FK_OrdemServicoOrdemServicoMov]
ON [dbo].[OrdemServicoMov]
    ([IdOrdemServico]);
GO

-- Creating foreign key on [IdUsuario] in table 'OrdemServicoMov'
ALTER TABLE [dbo].[OrdemServicoMov]
ADD CONSTRAINT [FK_UsuarioOrdemServicoMov]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioOrdemServicoMov'
CREATE INDEX [IX_FK_UsuarioOrdemServicoMov]
ON [dbo].[OrdemServicoMov]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdOrdemServico] in table 'OrdemServicoItem'
ALTER TABLE [dbo].[OrdemServicoItem]
ADD CONSTRAINT [FK_OrdemServicoOrdemServicoItem]
    FOREIGN KEY ([IdOrdemServico])
    REFERENCES [dbo].[OrdemServico]
        ([IdOrdemServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrdemServicoOrdemServicoItem'
CREATE INDEX [IX_FK_OrdemServicoOrdemServicoItem]
ON [dbo].[OrdemServicoItem]
    ([IdOrdemServico]);
GO

-- Creating foreign key on [IdFoto] in table 'OrdemServicoItem'
ALTER TABLE [dbo].[OrdemServicoItem]
ADD CONSTRAINT [FK_FotoOrdemServicoItem]
    FOREIGN KEY ([IdFoto])
    REFERENCES [dbo].[Foto]
        ([IdFoto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FotoOrdemServicoItem'
CREATE INDEX [IX_FK_FotoOrdemServicoItem]
ON [dbo].[OrdemServicoItem]
    ([IdFoto]);
GO

-- Creating foreign key on [IdEfeito] in table 'OrdemServicoItem'
ALTER TABLE [dbo].[OrdemServicoItem]
ADD CONSTRAINT [FK_EfeitoDigitalOrdemServicoItem]
    FOREIGN KEY ([IdEfeito])
    REFERENCES [dbo].[EfeitoDigital]
        ([IdEfeito])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EfeitoDigitalOrdemServicoItem'
CREATE INDEX [IX_FK_EfeitoDigitalOrdemServicoItem]
ON [dbo].[OrdemServicoItem]
    ([IdEfeito]);
GO

-- Creating foreign key on [IdPedido] in table 'PedidoLancamento'
ALTER TABLE [dbo].[PedidoLancamento]
ADD CONSTRAINT [FK_PedidoPedidoLancamento]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPedidoLancamento'
CREATE INDEX [IX_FK_PedidoPedidoLancamento]
ON [dbo].[PedidoLancamento]
    ([IdPedido]);
GO

-- Creating foreign key on [IdFilial] in table 'ContaCaixa'
ALTER TABLE [dbo].[ContaCaixa]
ADD CONSTRAINT [FK_FilialContaCaixa]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialContaCaixa'
CREATE INDEX [IX_FK_FilialContaCaixa]
ON [dbo].[ContaCaixa]
    ([IdFilial]);
GO

-- Creating foreign key on [IdConta] in table 'ContaCaixa'
ALTER TABLE [dbo].[ContaCaixa]
ADD CONSTRAINT [FK_ContaContaCaixa]
    FOREIGN KEY ([IdConta])
    REFERENCES [dbo].[Conta]
        ([IdConta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContaContaCaixa'
CREATE INDEX [IX_FK_ContaContaCaixa]
ON [dbo].[ContaCaixa]
    ([IdConta]);
GO

-- Creating foreign key on [IdCliFor] in table 'Lancamento'
ALTER TABLE [dbo].[Lancamento]
ADD CONSTRAINT [FK_CliForLancamento]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CliForLancamento'
CREATE INDEX [IX_FK_CliForLancamento]
ON [dbo].[Lancamento]
    ([IdCliFor]);
GO

-- Creating foreign key on [IdFilial] in table 'Lancamento'
ALTER TABLE [dbo].[Lancamento]
ADD CONSTRAINT [FK_FilialLancamento]
    FOREIGN KEY ([IdFilial])
    REFERENCES [dbo].[Filial]
        ([IdFilial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FilialLancamento'
CREATE INDEX [IX_FK_FilialLancamento]
ON [dbo].[Lancamento]
    ([IdFilial]);
GO

-- Creating foreign key on [IdContaCaixa] in table 'Lancamento'
ALTER TABLE [dbo].[Lancamento]
ADD CONSTRAINT [FK_ContaCaixaLancamento]
    FOREIGN KEY ([IdContaCaixa])
    REFERENCES [dbo].[ContaCaixa]
        ([IdContaCaixa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContaCaixaLancamento'
CREATE INDEX [IX_FK_ContaCaixaLancamento]
ON [dbo].[Lancamento]
    ([IdContaCaixa]);
GO

-- Creating foreign key on [IdLancamento] in table 'LancamentoMov'
ALTER TABLE [dbo].[LancamentoMov]
ADD CONSTRAINT [FK_LancamentoLancamentoMov]
    FOREIGN KEY ([IdLancamento])
    REFERENCES [dbo].[Lancamento]
        ([IdLancamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LancamentoLancamentoMov'
CREATE INDEX [IX_FK_LancamentoLancamentoMov]
ON [dbo].[LancamentoMov]
    ([IdLancamento]);
GO

-- Creating foreign key on [IdUsuario] in table 'LancamentoMov'
ALTER TABLE [dbo].[LancamentoMov]
ADD CONSTRAINT [FK_UsuarioLancamentoMov]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioLancamentoMov'
CREATE INDEX [IX_FK_UsuarioLancamentoMov]
ON [dbo].[LancamentoMov]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdLancamento] in table 'Extrato'
ALTER TABLE [dbo].[Extrato]
ADD CONSTRAINT [FK_LancamentoExtrato]
    FOREIGN KEY ([IdLancamento])
    REFERENCES [dbo].[Lancamento]
        ([IdLancamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LancamentoExtrato'
CREATE INDEX [IX_FK_LancamentoExtrato]
ON [dbo].[Extrato]
    ([IdLancamento]);
GO

-- Creating foreign key on [IdContaCaixa] in table 'Extrato'
ALTER TABLE [dbo].[Extrato]
ADD CONSTRAINT [FK_ContaCaixaExtrato]
    FOREIGN KEY ([IdContaCaixa])
    REFERENCES [dbo].[ContaCaixa]
        ([IdContaCaixa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContaCaixaExtrato'
CREATE INDEX [IX_FK_ContaCaixaExtrato]
ON [dbo].[Extrato]
    ([IdContaCaixa]);
GO

-- Creating foreign key on [IdUsuario] in table 'Extrato'
ALTER TABLE [dbo].[Extrato]
ADD CONSTRAINT [FK_UsuarioExtrato]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioExtrato'
CREATE INDEX [IX_FK_UsuarioExtrato]
ON [dbo].[Extrato]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdLancamento] in table 'LancamentoHist'
ALTER TABLE [dbo].[LancamentoHist]
ADD CONSTRAINT [FK_LancamentoLancamentoHist]
    FOREIGN KEY ([IdLancamento])
    REFERENCES [dbo].[Lancamento]
        ([IdLancamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LancamentoLancamentoHist'
CREATE INDEX [IX_FK_LancamentoLancamentoHist]
ON [dbo].[LancamentoHist]
    ([IdLancamento]);
GO

-- Creating foreign key on [IdUsuario] in table 'LancamentoHist'
ALTER TABLE [dbo].[LancamentoHist]
ADD CONSTRAINT [FK_UsuarioLancamentoHist]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioLancamentoHist'
CREATE INDEX [IX_FK_UsuarioLancamentoHist]
ON [dbo].[LancamentoHist]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdAtendimento] in table 'AtendimentoHist'
ALTER TABLE [dbo].[AtendimentoHist]
ADD CONSTRAINT [FK_AtendimentoAtendimentoHist]
    FOREIGN KEY ([IdAtendimento])
    REFERENCES [dbo].[Atendimento]
        ([IdAtendimento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AtendimentoAtendimentoHist'
CREATE INDEX [IX_FK_AtendimentoAtendimentoHist]
ON [dbo].[AtendimentoHist]
    ([IdAtendimento]);
GO

-- Creating foreign key on [IdUsuario] in table 'AtendimentoHist'
ALTER TABLE [dbo].[AtendimentoHist]
ADD CONSTRAINT [FK_UsuarioAtendimentoHist]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioAtendimentoHist'
CREATE INDEX [IX_FK_UsuarioAtendimentoHist]
ON [dbo].[AtendimentoHist]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdPedido] in table 'Pedido_Venda'
ALTER TABLE [dbo].[Pedido_Venda]
ADD CONSTRAINT [FK_Venda_inherits_Pedido]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPedido] in table 'Pedido_Compra'
ALTER TABLE [dbo].[Pedido_Compra]
ADD CONSTRAINT [FK_Compra_inherits_Pedido]
    FOREIGN KEY ([IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCliFor] in table 'CliFor_PessoaFisica'
ALTER TABLE [dbo].[CliFor_PessoaFisica]
ADD CONSTRAINT [FK_PessoaFisica_inherits_CliFor]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCliFor] in table 'CliFor_PessoaJuridica'
ALTER TABLE [dbo].[CliFor_PessoaJuridica]
ADD CONSTRAINT [FK_PessoaJuridica_inherits_CliFor]
    FOREIGN KEY ([IdCliFor])
    REFERENCES [dbo].[CliFor]
        ([IdCliFor])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------