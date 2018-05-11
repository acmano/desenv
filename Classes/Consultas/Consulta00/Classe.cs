using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.Consulta00
{
  public class Classe
  {

    public class Variaveis
    {

      #region Privadas

      #region Linha 1
      private String _codigoClassificacaoFiscal;
      private String _codigoIncidenciaIcms;
      private String _codigoIncidenciaIpi;
      private Double _aliquotaIpi;
      #endregion

      #region Linha 2
      private String _codigoContenedor;
      private String _descricaoContenedor;
      private Int32 _quantidadeItensContenedor;
      private Int32 _quantidadeEmpilhamentoMaximo;
      private String _codigoPainel;
      private String _codigoPainelFisico;
      #endregion

      #region Linha 3
      private String _codigoTipoItem;
      private String _descricaoTipoItem;
      private String _codigoFamilia;
      private String _descricaoFamilia;
      private DateTime _dataCadastro;
      private String _produtoChave;
      #endregion

      #region Linha 4
      private String _codigoGrupoControleEstoque;
      private String _descricaoGrupoControleEstoque;
      private String _codigoSituacao0022;
      private String _descricaoSituacao0022;
      private String _codigoSituacao0770;
      private String _descricaoSituacao0770;
      #endregion

      #region Linha 5
      private Boolean _estoque;
      private String _codigoLocalEstoque;
      private String _descricaoLocalEstoque;
      private String _codigoLocalProducao;
      private String _descricaoLocalProducao;
      #endregion

      #region Linha 6
      private Boolean _inspecao;
      private String _codigoLocalInspecao;
      private String _descricaoLocalInspecao;
      private Boolean _iesForcaApontamento;
      private Boolean _iesSofreBaixa;
      private String _iesAberturaLiberacao;
      private String _iesPlanejamento;
      #endregion

      #region Linha 7
      private Double _quantidadeEstoqueSeguranca;
      private Int32 _quantidadeDiasEstoqueSeguranca;
      private Int32 _quantidadeDiasRessuprimento;
      private String _codigoProgramador;
      private String _nomeProgramador;
      #endregion

      #region Linha 8
      private Double _quantidadeProgramacaoMinima;
      private Double _quantidadeProgramacaoMaxima;
      private String _codigoComprador;
      private String _nomeComprador;
      #endregion

      #region Linha 9
      private Double _quantidadeProgramacaoMultipla;
      private Double _quantidadeProgramacaoFixa;
      #endregion

      #region Linha 10
      private String _codigoLinhaProduto;
      private String _descricaoLinhaProduto;
      #endregion

      #region Linha 11
      private String _codigoLinhaReceita;
      private String _descricaoLinhaReceita;
      #endregion

      #region Linha 12
      private String _codigoSegmentoMercado;
      private String _descricaoSegmentoMercado;
      #endregion

      #region Linha 13
      private String _codigoClasseUso;
      private String _descricaoClasseUso;
      #endregion

      #endregion

      #region Públicas
      #region Linha 1
      public string CodigoClassificacaoFiscal
      {
        get { return _codigoClassificacaoFiscal; }
        private set { _codigoClassificacaoFiscal = value; }
      }

      public String CodigoIncidenciaIcms
      {
        get { return _codigoIncidenciaIcms; }
        private set { _codigoIncidenciaIcms = value; }
      }

      public String CodigoIncidenciaIpi
      {
        get { return _codigoIncidenciaIpi; }
        private set { _codigoIncidenciaIpi = value; }
      }

      public Double AliquotaIpi
      {
        get { return _aliquotaIpi; }
        private set { _aliquotaIpi = value; }
      }
      #endregion
      
      #region Linha 2
      public string CodigoContenedor
      {
        get { return _codigoContenedor; }
        private set { _codigoContenedor = value; }
      }

      public string DescricaoContenedor
      {
        get { return _descricaoContenedor; }
        private set { _descricaoContenedor = value; }
      }

      public int QuantidadeItensContenedor
      {
        get { return _quantidadeItensContenedor; }
        private set { _quantidadeItensContenedor = value; }
      }

      public int QuantidadeEmpilhamentoMaximo
      {
        get { return _quantidadeEmpilhamentoMaximo; }
        private set { _quantidadeEmpilhamentoMaximo = value; }
      }

      public string CodigoPainel
      {
        get { return _codigoPainel; }
        private set { _codigoPainel = value; }
      }

      public string CodigoPainelFisico
      {
        get { return _codigoPainelFisico; }
        private set { _codigoPainelFisico = value; }
      }
      #endregion

      #region Linha 3
      public string CodigoTipoItem
      {
        get { return _codigoTipoItem; }
        private set { _codigoTipoItem = value; }
      }

      public string DescricaoTipoItem
      {
        get { return _descricaoTipoItem; }
        private set { _descricaoTipoItem = value; }
      }

      public string CodigoFamilia
      {
        get { return _codigoFamilia; }
        private set { _codigoFamilia = value; }
      }

      public string DescricaoFamilia
      {
        get { return _descricaoFamilia; }
        private set { _descricaoFamilia = value; }
      }

      public DateTime DataCadastro
      {
        get { return _dataCadastro; }
        private set { _dataCadastro = value; }
      }

      public string ProdutoChave
      {
        get { return _produtoChave; }
        private set { _produtoChave = value; }
      }

      #endregion

      #region Linha 4
      public String CodigoGrupoControleEstoque
      {
        get { return _codigoGrupoControleEstoque; }
        private set { _codigoGrupoControleEstoque = value; }
      }

      public String DescricaoGrupoControleEstoque
      {
        get { return _descricaoGrupoControleEstoque; }
        private set { _descricaoGrupoControleEstoque = value; }
      }

      public String CodigoSituacao0022
      {
        get { return _codigoSituacao0022; }
        private set { _codigoSituacao0022 = value; }
      }

      public String DescricaoSituacao0022
      {
        get { return _descricaoSituacao0022; }
        private set { _descricaoSituacao0022 = value; }
      }

      public String CodigoSituacao0770
      {
        get { return _codigoSituacao0770; }
        private set { _codigoSituacao0770 = value; }
      }

      public String DescricaoSituacao0770
      {
        get { return _descricaoSituacao0770; }
        private set { _descricaoSituacao0770 = value; }
      }
      #endregion

      #region Linha 5
      public bool Estoque
      {
        get { return _estoque; }
        private set { _estoque = value; }
      }

      public string CodigoLocalEstoque
      {
        get { return _codigoLocalEstoque; }
        private set { _codigoLocalEstoque = value; }
      }

      public string DescricaoLocalEstoque
      {
        get { return _descricaoLocalEstoque; }
        private set { _descricaoLocalEstoque = value; }
      }

      public string CodigoLocalProducao
      {
        get { return _codigoLocalProducao; }
        private set { _codigoLocalProducao = value; }
      }

      public string DescricaoLocalProducao
      {
        get { return _descricaoLocalProducao; }
        set { _descricaoLocalProducao = value; }
      }
      #endregion

      #region Linha 6
      public bool Inspecao
      {
        get { return _inspecao; }
        private set { _inspecao = value; }
      }

      public string CodigoLocalInspecao
      {
        get { return _codigoLocalInspecao; }
        private set { _codigoLocalInspecao = value; }
      }

      public string DescricaoLocalInspecao
      {
        get { return _descricaoLocalInspecao; }
        private set { _descricaoLocalInspecao = value; }
      }

      public Boolean IesForcaApontamento
      {
        get { return _iesForcaApontamento; }
        private set { _iesForcaApontamento = value; }
      }

      public Boolean IesSofreBaixa
      {
        get { return _iesSofreBaixa; }
        private set { _iesSofreBaixa = value; }
      }

      public String IesAberturaLiberacao
      {
        get { return _iesAberturaLiberacao; }
        private set { _iesAberturaLiberacao = value; }
      }

      public String IesPlanejamento
      {
        get { return _iesPlanejamento; }
        private set { _iesPlanejamento = value; }
      }
      #endregion

      #region Linha 7
      public Double QuantidadeEstoqueSeguranca
      {
        get { return _quantidadeEstoqueSeguranca; }
        private set { _quantidadeEstoqueSeguranca = value; }
      }

      public Int32 QuantidadeDiasEstoqueSeguranca
      {
        get { return _quantidadeDiasEstoqueSeguranca; }
        private set { _quantidadeDiasEstoqueSeguranca = value; }
      }

      public Int32 QuantidadeDiasRessuprimento
      {
        get { return _quantidadeDiasRessuprimento; }
        private set { _quantidadeDiasRessuprimento = value; }
      }

      public String CodigoProgramador
      {
        get { return _codigoProgramador; }
        private set { _codigoProgramador = value; }
      }

      public String NomeProgramador
      {
        get { return _nomeProgramador; }
        private set { _nomeProgramador = value; }
      }
      #endregion

      #region Linha 8
      public Double QuantidadeProgramacaoMinima
      {
        get { return _quantidadeProgramacaoMinima; }
        private set { _quantidadeProgramacaoMinima = value; }
      }

      public Double QuantidadeProgramacaoMaxima
      {
        get { return _quantidadeProgramacaoMaxima; }
        private set { _quantidadeProgramacaoMaxima = value; }
      }

      public String CodigoComprador
      {
        get { return _codigoComprador; }
        private set { _codigoComprador = value; }
      }

      public String NomeComprador
      {
        get { return _nomeComprador; }
        private set { _nomeComprador = value; }
      }
      #endregion

      #region Linha 9
      public Double QuantidadeProgramacaoMultipla
      {
        get { return _quantidadeProgramacaoMultipla; }
        private set { _quantidadeProgramacaoMultipla = value; }
      }

      public Double QuantidadeProgramacaoFixa
      {
        get { return _quantidadeProgramacaoFixa; }
        private set { _quantidadeProgramacaoFixa = value; }
      }
      #endregion

      #region Linha 10
      public String CodigoLinhaProduto
      {
        get { return _codigoLinhaProduto; }  
        private set { _codigoLinhaProduto = value; }
      }

      public String DescricaoLinhaProduto
      {
        get { return _descricaoLinhaProduto; }
        private set { _descricaoLinhaProduto = value; }
      }
      #endregion

      #region Linha 11
      public String CodigoLinhaReceita
      {
        get { return _codigoLinhaReceita; }
        private set { _codigoLinhaReceita = value; }
      }

      public String DescricaoLinhaReceita
      {
        get { return _descricaoLinhaReceita; }
        private set { _descricaoLinhaReceita = value; }
      }
      #endregion

      #region Linha 12
      public String CodigoSegmentoMercado
      {
        get { return _codigoSegmentoMercado; }
        private set { _codigoSegmentoMercado = value; }
      }

      public String DescricaoSegmentoMercado
      {
        get { return _descricaoSegmentoMercado; }
        private set { _descricaoSegmentoMercado = value; }
      }
      #endregion

      #region Linha 13

      public String CodigoClasseUso
      {
        get { return _codigoClasseUso; }
        private set { _codigoClasseUso = value; }
      }

      public String DescricaoClasseUso
      {
        get { return _descricaoClasseUso; }
        private set { _descricaoClasseUso = value; }
      }
      #endregion

      #endregion

      private void Clear ( )
      {

      #region Linha1
      CodigoClassificacaoFiscal = String.Empty;
      CodigoIncidenciaIcms = String.Empty;
      CodigoIncidenciaIpi = String.Empty;
      AliquotaIpi = 0.0;
      #endregion

      #region Linha2
      CodigoContenedor = String.Empty;
      DescricaoContenedor = String.Empty;
      QuantidadeItensContenedor = 0;
      QuantidadeEmpilhamentoMaximo = 0;
      CodigoPainel = String.Empty;
      CodigoPainelFisico = String.Empty;
      #endregion

      #region Linha3
      CodigoTipoItem = String.Empty;
      DescricaoTipoItem = String.Empty;
      CodigoFamilia = String.Empty;
      DescricaoFamilia = String.Empty;
      DataCadastro = DateTime.MinValue;
      ProdutoChave = String.Empty;
      #endregion

      #region Linha4
      CodigoGrupoControleEstoque = String.Empty;
      DescricaoGrupoControleEstoque = String.Empty;
      CodigoSituacao0022 = String.Empty;
      DescricaoSituacao0022 = String.Empty;
      CodigoSituacao0770 = String.Empty;
      DescricaoSituacao0770 = String.Empty;
      #endregion

      #region Linha5
      Estoque = false;
      CodigoLocalEstoque = String.Empty;
      DescricaoLocalEstoque = String.Empty;
      CodigoLocalProducao = String.Empty;
      DescricaoLocalProducao = String.Empty;
      #endregion

      #region Linha6
      Inspecao = false;
      CodigoLocalInspecao = String.Empty;
      DescricaoLocalInspecao = String.Empty;
      IesForcaApontamento = false;
      IesSofreBaixa = false;
      IesAberturaLiberacao = String.Empty;
      IesPlanejamento = String.Empty;
      #endregion

      #region Linha7
      QuantidadeEstoqueSeguranca = 0.0;
      QuantidadeDiasEstoqueSeguranca = 0;
      QuantidadeDiasRessuprimento = 0;
      CodigoProgramador = String.Empty;
      NomeProgramador = String.Empty;
      #endregion

      #region Linha8
      QuantidadeProgramacaoMinima = 0.0;
      QuantidadeProgramacaoMaxima = 0.0;
      CodigoComprador = String.Empty;
      NomeComprador = String.Empty;
      #endregion

      #region Linha9
      QuantidadeProgramacaoMultipla = 0.0;
      QuantidadeProgramacaoFixa = 0.0;
      #endregion

      #region Linha10
      CodigoLinhaProduto = String.Empty;
      DescricaoLinhaProduto = String.Empty;
      #endregion

      #region Linha11
      CodigoLinhaReceita = String.Empty;
      DescricaoLinhaReceita = String.Empty;
      #endregion

      #region Linha12
      CodigoSegmentoMercado = String.Empty;
      DescricaoSegmentoMercado = String.Empty;
      #endregion

      #region Linha13
      CodigoClasseUso = String.Empty;
      DescricaoClasseUso = String.Empty;
      #endregion
        
      }

      public Variaveis()
      {
        Clear();
      }

      public Variaveis(DataRow dataRow)
      {

        #region Linha1
        CodigoClassificacaoFiscal = DbConvert.GetString ( dataRow, "CodigoClassificacaoFiscal" );
        CodigoIncidenciaIcms = DbConvert.GetString ( dataRow, "CodigoIncidenciaIcms" );
        CodigoIncidenciaIpi = DbConvert.GetString ( dataRow, "CodigoIncidenciaIpi" );
        AliquotaIpi = DbConvert.GetDouble(dataRow, "AliquoptaIpi");
        #endregion

        #region Linha2
        CodigoContenedor = DbConvert.GetString ( dataRow, "CodigoContenedor" );
        DescricaoContenedor = DbConvert.GetString ( dataRow, "DescricaoContenedor" );
        QuantidadeItensContenedor = DbConvert.GetInt32 ( dataRow, "QuantidadeItensContenedor" );
        QuantidadeEmpilhamentoMaximo = DbConvert.GetInt32 ( dataRow, "QuantidadeEmpilhamentoMaximo" );
        CodigoPainel = DbConvert.GetString ( dataRow, "CodigoPainel" );
        CodigoPainelFisico = DbConvert.GetString ( dataRow, "CodigoPainelFisico" );
        #endregion

        #region Linha3
        CodigoTipoItem = DbConvert.GetString ( dataRow, "CodigoTipoItem" );
        DescricaoTipoItem = DbConvert.GetString ( dataRow, "DescricaoTipoItem" );
        CodigoFamilia = DbConvert.GetString ( dataRow, "CodigoFamilia" );
        DescricaoFamilia = DbConvert.GetString ( dataRow, "DescricaoFamilia" );
        DataCadastro = DbConvert.GetDateTime ( dataRow, "DataCadastro" );
        ProdutoChave = DbConvert.GetString ( dataRow, "ProdutoChave" );
        #endregion

        #region Linha4
        CodigoGrupoControleEstoque = DbConvert.GetString ( dataRow, "CodigoGrupoControleEstoque" );
        DescricaoGrupoControleEstoque = DbConvert.GetString ( dataRow, "DescricaoGrupoControleEstoque" );
        CodigoSituacao0022 = DbConvert.GetString ( dataRow, "CodigoSituacao0022" );
        DescricaoSituacao0022 = DbConvert.GetString ( dataRow, "DescricaoSituacao0022" );
        CodigoSituacao0770 = DbConvert.GetString ( dataRow, "CodigoSituacao0770" );
        DescricaoSituacao0770 = DbConvert.GetString ( dataRow, "DescricaoSituacao0770" );
        #endregion

        #region Linha5
        Estoque = DbConvert.GetBoolean ( dataRow, "Estoque" );
        CodigoLocalEstoque = DbConvert.GetString ( dataRow, "CodigoLocalEstoque" );
        DescricaoLocalEstoque = DbConvert.GetString ( dataRow, "DescricaoLocalEstoque" );
        CodigoLocalProducao = DbConvert.GetString ( dataRow, "CodigoLocalProducao" );
        DescricaoLocalProducao = DbConvert.GetString ( dataRow, "DescricaoLocalProducao" );
        #endregion

        #region Linha6
        Inspecao = DbConvert.GetBoolean ( dataRow, "Inspecao" );
        CodigoLocalInspecao = DbConvert.GetString ( dataRow, "CodigoLocalInspecao" );
        DescricaoLocalInspecao = DbConvert.GetString ( dataRow, "DescricaoLocalInspecao" );
        IesForcaApontamento = DbConvert.GetBoolean ( dataRow, "IesForcaApontamento" );
        IesSofreBaixa = DbConvert.GetBoolean ( dataRow, "IesSofreBaixa" );
        IesAberturaLiberacao = DbConvert.GetString ( dataRow, "IesAberturaLiberacao" );
        IesPlanejamento = DbConvert.GetString ( dataRow, "IesPlanejamento" );
        #endregion

        #region Linha7
        QuantidadeEstoqueSeguranca = DbConvert.GetDouble ( dataRow, "QuantidadeEstoqueSeguranca" );
        QuantidadeDiasEstoqueSeguranca = DbConvert.GetInt32 ( dataRow, "QuantidadeDiasEstoqueSeguranca" );
        QuantidadeDiasRessuprimento = DbConvert.GetInt32 ( dataRow, "QuantidadeDiasRessuprimento" );
        CodigoProgramador = DbConvert.GetString ( dataRow, "CodigoProgramador" );
        NomeProgramador = DbConvert.GetString ( dataRow, "NomeProgramador" );
        #endregion

        #region Linha8
        QuantidadeProgramacaoMinima = DbConvert.GetDouble ( dataRow, "QuantidadeProgramacaoMinima" );
        QuantidadeProgramacaoMaxima = DbConvert.GetDouble ( dataRow, "QuantidadeProgramacaoMaxima" );
        CodigoComprador = DbConvert.GetString ( dataRow, "CodigoComprador" );
        NomeComprador = DbConvert.GetString ( dataRow, "NomeComprador" );
        #endregion

        #region Linha9
        QuantidadeProgramacaoMultipla = DbConvert.GetDouble ( dataRow, "QuantidadeProgramacaoMultipla" );
        QuantidadeProgramacaoFixa = DbConvert.GetDouble ( dataRow, "QuantidadeProgramacaoFixa" );
        #endregion

        #region Linha10
        CodigoLinhaProduto = DbConvert.GetString ( dataRow, "CodigoLinhaProduto" );
        DescricaoLinhaProduto = DbConvert.GetString ( dataRow, "DescricaoLinhaProduto" );
        #endregion

        #region Linha11
        CodigoLinhaReceita = DbConvert.GetString ( dataRow, "CodigoLinhaReceita" );
        DescricaoLinhaReceita = DbConvert.GetString ( dataRow, "DescricaoLinhaReceita" );
        #endregion

        #region Linha12
        CodigoSegmentoMercado = DbConvert.GetString ( dataRow, "CodigoSegmentoMercado" );
        DescricaoSegmentoMercado = DbConvert.GetString ( dataRow, "DescricaoSegmentoMercado" );
        #endregion

        #region Linha13
        CodigoClasseUso = DbConvert.GetString ( dataRow, "CodigoClasseUso" );
        DescricaoClasseUso = DbConvert.GetString ( dataRow, "DescricaoClasseUso" );
        #endregion
      
      }

      public Variaveis ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {
          #region Linha1
          CodigoClassificacaoFiscal = DbConvert.GetString ( dataReader, "CodigoClassificacaoFiscal" );
          CodigoIncidenciaIcms = DbConvert.GetString ( dataReader, "CodigoIncidenciaIcms" );
          CodigoIncidenciaIpi = DbConvert.GetString ( dataReader, "CodigoIncidenciaIpi" );
          AliquotaIpi = DbConvert.GetDouble(dataReader, "AliquotaIpi" );
          #endregion

          #region Linha2
          CodigoContenedor = DbConvert.GetString ( dataReader, "CodigoContenedor" );
          DescricaoContenedor = DbConvert.GetString ( dataReader, "DescricaoContenedor" );
          QuantidadeItensContenedor = DbConvert.GetInt32 ( dataReader, "QuantidadeItensContenedor" );
          QuantidadeEmpilhamentoMaximo = DbConvert.GetInt32 ( dataReader, "QuantidadeEmpilhamentoMaximo" );
          CodigoPainel = DbConvert.GetString ( dataReader, "CodigoPainel" );
          CodigoPainelFisico = DbConvert.GetString ( dataReader, "CodigoPainelFisico" );
          #endregion

          #region Linha3
          CodigoTipoItem = DbConvert.GetString ( dataReader, "CodigoTipoItem" );
          DescricaoTipoItem = DbConvert.GetString ( dataReader, "DescricaoTipoItem" );
          CodigoFamilia = DbConvert.GetString ( dataReader, "CodigoFamilia" );
          DescricaoFamilia = DbConvert.GetString ( dataReader, "DescricaoFamilia" );
          DataCadastro = DbConvert.GetDateTime ( dataReader, "DataCadastro" );
          ProdutoChave = DbConvert.GetString ( dataReader, "ProdutoChave" );
          #endregion

          #region Linha4
          CodigoGrupoControleEstoque = DbConvert.GetString ( dataReader, "CodigoGrupoControleEstoque" );
          DescricaoGrupoControleEstoque = DbConvert.GetString ( dataReader, "DescricaoGrupoControleEstoque" );
          CodigoSituacao0022 = DbConvert.GetString ( dataReader, "CodigoSituacao0022" );
          DescricaoSituacao0022 = DbConvert.GetString ( dataReader, "DescricaoSituacao0022" );
          CodigoSituacao0770 = DbConvert.GetString ( dataReader, "CodigoSituacao0770" );
          DescricaoSituacao0770 = DbConvert.GetString ( dataReader, "DescricaoSituacao0770" );
          #endregion

          #region Linha5
          Estoque = DbConvert.GetBoolean ( dataReader, "Estoque" );
          CodigoLocalEstoque = DbConvert.GetString ( dataReader, "CodigoLocalEstoque" );
          DescricaoLocalEstoque = DbConvert.GetString ( dataReader, "DescricaoLocalEstoque" );
          CodigoLocalProducao = DbConvert.GetString ( dataReader, "CodigoLocalProducao" );
          DescricaoLocalProducao = DbConvert.GetString ( dataReader, "DescricaoLocalProducao" );
          #endregion

          #region Linha6
          Inspecao = DbConvert.GetBoolean ( dataReader, "Inspecao" );
          CodigoLocalInspecao = DbConvert.GetString ( dataReader, "CodigoLocalInspecao" );
          DescricaoLocalInspecao = DbConvert.GetString ( dataReader, "DescricaoLocalInspecao" );
          IesForcaApontamento = DbConvert.GetBoolean ( dataReader, "IesForcaApontamento" );
          IesSofreBaixa = DbConvert.GetBoolean ( dataReader, "IesSofreBaixa" );
          IesAberturaLiberacao = DbConvert.GetString ( dataReader, "IesAberturaLiberacao" );
          IesPlanejamento = DbConvert.GetString ( dataReader, "IesPlanejamento" );
          #endregion

          #region Linha7
          QuantidadeEstoqueSeguranca = DbConvert.GetDouble ( dataReader, "QuantidadeEstoqueSeguranca" );
          QuantidadeDiasEstoqueSeguranca = DbConvert.GetInt32 ( dataReader, "QuantidadeDiasEstoqueSeguranca" );
          QuantidadeDiasRessuprimento = DbConvert.GetInt32 ( dataReader, "QuantidadeDiasRessuprimento" );
          CodigoProgramador = DbConvert.GetString ( dataReader, "CodigoProgramador" );
          NomeProgramador = DbConvert.GetString ( dataReader, "NomeProgramador" );
          #endregion

          #region Linha8
          QuantidadeProgramacaoMinima = DbConvert.GetDouble ( dataReader, "QuantidadeProgramacaoMinima" );
          QuantidadeProgramacaoMaxima = DbConvert.GetDouble ( dataReader, "QuantidadeProgramacaoMaxima" );
          CodigoComprador = DbConvert.GetString ( dataReader, "CodigoComprador" );
          NomeComprador = DbConvert.GetString ( dataReader, "NomeComprador" );
          #endregion

          #region Linha9
          QuantidadeProgramacaoMultipla = DbConvert.GetDouble ( dataReader, "QuantidadeProgramacaoMultipla" );
          QuantidadeProgramacaoFixa = DbConvert.GetDouble ( dataReader, "QuantidadeProgramacaoFixa" );
          #endregion

          #region Linha10
          CodigoLinhaProduto = DbConvert.GetString ( dataReader, "CodigoLinhaProduto" );
          DescricaoLinhaProduto = DbConvert.GetString ( dataReader, "DescricaoLinhaProduto" );
          #endregion

          #region Linha11
          CodigoLinhaReceita = DbConvert.GetString ( dataReader, "CodigoLinhaReceita" );
          DescricaoLinhaReceita = DbConvert.GetString ( dataReader, "DescricaoLinhaReceita" );
          #endregion

          #region Linha12
          CodigoSegmentoMercado = DbConvert.GetString ( dataReader, "CodigoSegmentoMercado" );
          DescricaoSegmentoMercado = DbConvert.GetString ( dataReader, "DescricaoSegmentoMercado" );
          #endregion

          #region Linha13
          CodigoClasseUso = DbConvert.GetString ( dataReader, "CodigoClasseUso" );
          DescricaoClasseUso = DbConvert.GetString ( dataReader, "DescricaoClasseUso" );
          #endregion
        }
        else
        {
          Clear ( );
        }
      }
    
    }

    public class Campos
    {

      #region Privadas

      #region Estrutura
      private RelativeLayout _rloConsulta00;
      private LinearLayout _lloConsulta00Botoes;
      #endregion

      #region Linha 1
      private TextView _txtConsulta00CodigoClassificacaoFiscal;
      private TextView _txtConsulta00CodigoIncidenciaIcms;
      private TextView _txtConsulta00CodigoIncidenciaIpi;
      private TextView _txtConsulta00AliquotaIpi;
      #endregion

      #region Linha 2
      private TextView _txtConsulta00CodigoContenedor;
      private TextView _txtConsulta00DescricaoContenedor;
      private TextView _txtConsulta00QuantidadeItensContenedor;
      private TextView _txtConsulta00QuantidadeEmpilhamentoMaximo;
      private TextView _txtConsulta00CodigoPainel;
      private TextView _txtConsulta00CodigoPainelFisico;
      #endregion

      #region Linha 3
      private TextView _txtConsulta00CodigoTipoItem;
      private TextView _txtConsulta00DescricaoTipoItem;
      private TextView _txtConsulta00CodigoFamilia;
      private TextView _txtConsulta00DescricaoFamilia;
      private TextView _txtConsulta00DataCadastro;
      private TextView _txtConsulta00ProdutoChave;
      #endregion

      #region Linha 4
      private TextView _txtConsulta00CodigoGrupoControleEstoque;
      private TextView _txtConsulta00DescricaoGrupoControleEstoque;
      private TextView _txtConsulta00CodigoSituacao0022;
      private TextView _txtConsulta00DescricaoSituacao0022;
      private TextView _txtConsulta00CodigoSituacao0770;
      private TextView _txtConsulta00DescricaoSituacao0770;
      #endregion

      #region Linha 5
      private CheckBox _cbxConsulta00Estoque;
      private TextView _txtConsulta00CodigoLocalEstoque;
      private TextView _txtConsulta00DescricaoLocalEstoque;
      private TextView _txtConsulta00CodigoLocalProducao;
      private TextView _txtConsulta00DescricaoLocalProducao;
      #endregion

      #region Linha 6
      private CheckBox _cbxConsulta00Inspecao;
      private TextView _txtConsulta00CodigoLocalInspecao;
      private TextView _txtConsulta00DescricaoLocalInspecao;
      private CheckBox _cbxConsulta00IesForcaApontamento;
      private CheckBox _cbxConsulta00IesSofreBaixa;
      private TextView _txtConsulta00IesAberturaLiberacao;
      private TextView _txtConsulta00IesPlanejamento;
      #endregion

      #region Linha 7
      private TextView _txtConsulta00QuantidadeEstoqueSeguranca;
      private TextView _txtConsulta00QuantidadeDiasEstoqueSeguranca;
      private TextView _txtConsulta00QuantidadeDiasRessuprimento;
      private TextView _txtConsulta00CodigoProgramador;
      private TextView _txtConsulta00NomeProgramador;
      #endregion

      #region Linha 8
      private TextView _txtConsulta00QuantidadeProgramacaoMinima;
      private TextView _txtConsulta00QuantidadeProgramacaoMaxima;
      private TextView _txtConsulta00CodigoComprador;
      private TextView _txtConsulta00NomeComprador;
      #endregion

      #region Linha 9
      private TextView _txtConsulta00QuantidadeProgramacaoMultipla;
      private TextView _txtConsulta00QuantidadeProgramacaoFixa;
      #endregion

      #region Linha 10
      private TextView _txtConsulta00CodigoLinhaProduto;
      private TextView _txtConsulta00DescricaoLinhaProduto;
      #endregion

      #region Linha 11
      private TextView _txtConsulta00CodigoLinhaReceita;
      private TextView _txtConsulta00DescricaoLinhaReceita;
      #endregion

      #region Linha 12
      private TextView _txtConsulta00CodigoSegmentoMercado;
      private TextView _txtConsulta00DescricaoSegmentoMercado;
      #endregion

      #region Linha 13
      private TextView _txtConsulta00CodigoClasseUso;
      private TextView _txtConsulta00DescricaoClasseUso;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsulta00
      {
        get { return _rloConsulta00; }
        set { _rloConsulta00 = value;}
      }

      public LinearLayout LloConsulta00Botoes
      {
        get { return _lloConsulta00Botoes; }
        set { _lloConsulta00Botoes = value; }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsulta00CodigoClassificacaoFiscal
      {
        get
        {
          return _txtConsulta00CodigoClassificacaoFiscal;
        }
        private set
        {
          _txtConsulta00CodigoClassificacaoFiscal = value;
        }
      }

      public TextView TxtConsulta00CodigoIncidenciaIcms
      {
        get
        {
          return _txtConsulta00CodigoIncidenciaIcms;
        }
        private set
        {
          _txtConsulta00CodigoIncidenciaIcms = value;
        }
      }

      public TextView TxtConsulta00CodigoIncidenciaIpi
      {
        get
        {
          return _txtConsulta00CodigoIncidenciaIpi;
        }
        private set
        {
          _txtConsulta00CodigoIncidenciaIpi = value;
        }
      }

      public TextView TxtConsulta00AliquotaIpi
      {
        get
        {
          return _txtConsulta00AliquotaIpi;
        }
        private set
        {
          _txtConsulta00AliquotaIpi = value;
        }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsulta00CodigoContenedor
      {
        get
        {
          return _txtConsulta00CodigoContenedor;
        }
        private set
        {
          _txtConsulta00CodigoContenedor = value;
        }
      }

      public TextView TxtConsulta00DescricaoContenedor
      {
        get
        {
          return _txtConsulta00DescricaoContenedor;
        }
        private set
        {
          _txtConsulta00DescricaoContenedor = value;
        }
      }

      public TextView TxtConsulta00QuantidadeItensContenedor
      {
        get
        {
          return _txtConsulta00QuantidadeItensContenedor;
        }
        private set
        {
          _txtConsulta00QuantidadeItensContenedor = value;
        }
      }

      public TextView TxtConsulta00QuantidadeEmpilhamentoMaximo
      {
        get
        {
          return _txtConsulta00QuantidadeEmpilhamentoMaximo;
        }
        private set
        {
          _txtConsulta00QuantidadeEmpilhamentoMaximo = value;
        }
      }

      public TextView TxtConsulta00CodigoPainel
      {
        get
        {
          return _txtConsulta00CodigoPainel;
        }
        private set
        {
          _txtConsulta00CodigoPainel = value;
        }
      }

      public TextView TxtConsulta00CodigoPainelFisico
      {
        get
        {
          return _txtConsulta00CodigoPainelFisico;
        }
        private set
        {
          _txtConsulta00CodigoPainelFisico = value;
        }
      }
      #endregion

      #region Linha 3
      public TextView TxtConsulta00CodigoTipoItem
      {
        get
        {
          return _txtConsulta00CodigoTipoItem;
        }
        private set
        {
          _txtConsulta00CodigoTipoItem = value;
        }
      }

      public TextView TxtConsulta00DescricaoTipoItem
      {
        get
        {
          return _txtConsulta00DescricaoTipoItem;
        }
        private set
        {
          _txtConsulta00DescricaoTipoItem = value;
        }
      }

      public TextView TxtConsulta00CodigoFamilia
      {
        get
        {
          return _txtConsulta00CodigoFamilia;
        }
        private set
        {
          _txtConsulta00CodigoFamilia = value;
        }
      }

      public TextView TxtConsulta00DescricaoFamilia
      {
        get
        {
          return _txtConsulta00DescricaoFamilia;
        }
        private set
        {
          _txtConsulta00DescricaoFamilia = value;
        }
      }

      public TextView TxtConsulta00DataCadastro
      {
        get
        {
          return _txtConsulta00DataCadastro;
        }
        private set
        {
          _txtConsulta00DataCadastro = value;
        }
      }

      public TextView TxtConsulta00ProdutoChave
      {
        get
        {
          return _txtConsulta00ProdutoChave;
        }
        private set
        {
          _txtConsulta00ProdutoChave = value;
        }
      }
      #endregion

      #region Linha 4
      public TextView TxtConsulta00CodigoGrupoControleEstoque
      {
        get
        {
          return _txtConsulta00CodigoGrupoControleEstoque;
        }
        private set
        {
          _txtConsulta00CodigoGrupoControleEstoque = value;
        }
      }

      public TextView TxtConsulta00DescricaoGrupoControleEstoque
      {
        get
        {
          return _txtConsulta00DescricaoGrupoControleEstoque;
        }
        private set
        {
          _txtConsulta00DescricaoGrupoControleEstoque = value;
        }
      }

      public TextView TxtConsulta00CodigoSituacao0022
      {
        get
        {
          return _txtConsulta00CodigoSituacao0022;
        }
        private set
        {
          _txtConsulta00CodigoSituacao0022 = value;
        }
      }

      public TextView TxtConsulta00DescricaoSituacao0022
      {
        get
        {
          return _txtConsulta00DescricaoSituacao0022;
        }
        private set
        {
          _txtConsulta00DescricaoSituacao0022 = value;
        }
      }

      public TextView TxtConsulta00CodigoSituacao0770
      {
        get
        {
          return _txtConsulta00CodigoSituacao0770;
        }
        private set
        {
          _txtConsulta00CodigoSituacao0770 = value;
        }
      }

      public TextView TxtConsulta00DescricaoSituacao0770
      {
        get
        {
          return _txtConsulta00DescricaoSituacao0770;
        }
        private set
        {
          _txtConsulta00DescricaoSituacao0770 = value;
        }
      }
      #endregion

      #region Linha 5
      public CheckBox CbxConsulta00Estoque
      {
        get
        {
          return _cbxConsulta00Estoque;
        }
        private set
        {
          _cbxConsulta00Estoque = value;
        }
      }

      public TextView TxtConsulta00CodigoLocalEstoque
      {
        get
        {
          return _txtConsulta00CodigoLocalEstoque;
        }
        private set
        {
          _txtConsulta00CodigoLocalEstoque = value;
        }
      }

      public TextView TxtConsulta00DescricaoLocalEstoque
      {
        get
        {
          return _txtConsulta00DescricaoLocalEstoque;
        }
        private set
        {
          _txtConsulta00DescricaoLocalEstoque = value;
        }
      }

      public TextView TxtConsulta00CodigoLocalProducao
      {
        get
        {
          return _txtConsulta00CodigoLocalProducao;
        }
        private set
        {
          _txtConsulta00CodigoLocalProducao = value;
        }
      }

      public TextView TxtConsulta00DescricaoLocalProducao
      {
        get
        {
          return _txtConsulta00DescricaoLocalProducao;
        }
        set
        {
          _txtConsulta00DescricaoLocalProducao = value;
        }
      }
      #endregion

      #region Linha 6
      public CheckBox CbxConsulta00Inspecao
      {
        get
        {
          return _cbxConsulta00Inspecao;
        }
        private set
        {
          _cbxConsulta00Inspecao = value;
        }
      }

      public TextView TxtConsulta00CodigoLocalInspecao
      {
        get
        {
          return _txtConsulta00CodigoLocalInspecao;
        }
        private set
        {
          _txtConsulta00CodigoLocalInspecao = value;
        }
      }

      public TextView TxtConsulta00DescricaoLocalInspecao
      {
        get
        {
          return _txtConsulta00DescricaoLocalInspecao;
        }
        private set
        {
          _txtConsulta00DescricaoLocalInspecao = value;
        }
      }

      public CheckBox CbxConsulta00IesForcaApontamento
      {
        get
        {
          return _cbxConsulta00IesForcaApontamento;
        }
        private set
        {
          _cbxConsulta00IesForcaApontamento = value;
        }
      }

      public CheckBox CbxConsulta00IesSofreBaixa
      {
        get
        {
          return _cbxConsulta00IesSofreBaixa;
        }
        private set
        {
          _cbxConsulta00IesSofreBaixa = value;
        }
      }

      public TextView TxtConsulta00IesAberturaLiberacao
      {
        get
        {
          return _txtConsulta00IesAberturaLiberacao;
        }
        private set
        {
          _txtConsulta00IesAberturaLiberacao = value;
        }
      }

      public TextView TxtConsulta00IesPlanejamento
      {
        get
        {
          return _txtConsulta00IesPlanejamento;
        }
        private set
        {
          _txtConsulta00IesPlanejamento = value;
        }
      }
      #endregion

      #region Linha 7
      public TextView TxtConsulta00QuantidadeEstoqueSeguranca
      {
        get
        {
          return _txtConsulta00QuantidadeEstoqueSeguranca;
        }
        private set
        {
          _txtConsulta00QuantidadeEstoqueSeguranca = value;
        }
      }

      public TextView TxtConsulta00QuantidadeDiasEstoqueSeguranca
      {
        get
        {
          return _txtConsulta00QuantidadeDiasEstoqueSeguranca;
        }
        private set
        {
          _txtConsulta00QuantidadeDiasEstoqueSeguranca = value;
        }
      }

      public TextView TxtConsulta00QuantidadeDiasRessuprimento
      {
        get
        {
          return _txtConsulta00QuantidadeDiasRessuprimento;
        }
        private set
        {
          _txtConsulta00QuantidadeDiasRessuprimento = value;
        }
      }

      public TextView TxtConsulta00CodigoProgramador
      {
        get
        {
          return _txtConsulta00CodigoProgramador;
        }
        private set
        {
          _txtConsulta00CodigoProgramador = value;
        }
      }

      public TextView TxtConsulta00NomeProgramador
      {
        get
        {
          return _txtConsulta00NomeProgramador;
        }
        private set
        {
          _txtConsulta00NomeProgramador = value;
        }
      }
      #endregion

      #region Linha 8
      public TextView TxtConsulta00QuantidadeProgramacaoMinima
      {
        get
        {
          return _txtConsulta00QuantidadeProgramacaoMinima;
        }
        private set
        {
          _txtConsulta00QuantidadeProgramacaoMinima = value;
        }
      }

      public TextView TxtConsulta00QuantidadeProgramacaoMaxima
      {
        get
        {
          return _txtConsulta00QuantidadeProgramacaoMaxima;
        }
        private set
        {
          _txtConsulta00QuantidadeProgramacaoMaxima = value;
        }
      }

      public TextView TxtConsulta00CodigoComprador
      {
        get
        {
          return _txtConsulta00CodigoComprador;
        }
        private set
        {
          _txtConsulta00CodigoComprador = value;
        }
      }

      public TextView TxtConsulta00NomeComprador
      {
        get
        {
          return _txtConsulta00NomeComprador;
        }
        private set
        {
          _txtConsulta00NomeComprador = value;
        }
      }
      #endregion

      #region Linha 9
      public TextView TxtConsulta00QuantidadeProgramacaoMultipla
      {
        get
        {
          return _txtConsulta00QuantidadeProgramacaoMultipla;
        }
        private set
        {
          _txtConsulta00QuantidadeProgramacaoMultipla = value;
        }
      }

      public TextView TxtConsulta00QuantidadeProgramacaoFixa
      {
        get
        {
          return _txtConsulta00QuantidadeProgramacaoFixa;
        }
        private set
        {
          _txtConsulta00QuantidadeProgramacaoFixa = value;
        }
      }
      #endregion

      #region Linha 10
      public TextView TxtConsulta00CodigoLinhaProduto
      {
        get
        {
          return _txtConsulta00CodigoLinhaProduto;
        }
        private set
        {
          _txtConsulta00CodigoLinhaProduto = value;
        }
      }

      public TextView TxtConsulta00DescricaoLinhaProduto
      {
        get
        {
          return _txtConsulta00DescricaoLinhaProduto;
        }
        private set
        {
          _txtConsulta00DescricaoLinhaProduto = value;
        }
      }
      #endregion

      #region Linha 11
      public TextView TxtConsulta00CodigoLinhaReceita
      {
        get
        {
          return _txtConsulta00CodigoLinhaReceita;
        }
        private set
        {
          _txtConsulta00CodigoLinhaReceita = value;
        }
      }

      public TextView TxtConsulta00DescricaoLinhaReceita
      {
        get
        {
          return _txtConsulta00DescricaoLinhaReceita;
        }
        private set
        {
          _txtConsulta00DescricaoLinhaReceita = value;
        }
      }
      #endregion

      #region Linha 12
      public TextView TxtConsulta00CodigoSegmentoMercado
      {
        get
        {
          return _txtConsulta00CodigoSegmentoMercado;
        }
        private set
        {
          _txtConsulta00CodigoSegmentoMercado = value;
        }
      }

      public TextView TxtConsulta00DescricaoSegmentoMercado
      {
        get
        {
          return _txtConsulta00DescricaoSegmentoMercado;
        }
        private set
        {
          _txtConsulta00DescricaoSegmentoMercado = value;
        }
      }
      #endregion

      #region Linha 13
      public TextView TxtConsulta00CodigoClasseUso
      {
        get
        {
          return _txtConsulta00CodigoClasseUso;
        }
        private set
        {
          _txtConsulta00CodigoClasseUso = value;
        }
      }

      public TextView TxtConsulta00DescricaoClasseUso
      {
        get
        {
          return _txtConsulta00DescricaoClasseUso;
        }
        private set
        {
          _txtConsulta00DescricaoClasseUso = value;
        }
      }
      #endregion
      
      #endregion

      public Campos( Activity activity )
      {
        Bind ( activity );
      }

      private void Bind ( Activity activity )
      {

        #region Estrutura
        BindEstrutura(activity);
        #endregion

        #region Linha 1
        BindCodigoClassificacaoFiscal (  activity );
        BindCodigoIncidenciaIcms (  activity );
        BindCodigoIncidenciaIpi (  activity );
        BindAliquotaIpi (  activity );
        #endregion

        #region Linha 2
        BindCodigoContenedor (  activity );
        BindDescricaoContenedor (  activity );
        BindQuantidadeItensContenedor (  activity );
        BindQuantidadeEmpilhamentoMaximo (  activity );
        BindCodigoPainel (  activity );
        BindCodigoPainelFisico (  activity );
        #endregion

        #region Linha 3
        BindCodigoTipoItem (  activity );
        BindDescricaoTipoItem (  activity );
        BindCodigoFamilia (  activity );
        BindDescricaoFamilia (  activity );
        BindDataCadastro (  activity );
        BindProdutoChave (  activity );
        #endregion

        #region Linha 4
        BindCodigoGrupoControleEstoque (  activity );
        BindDescricaoGrupoControleEstoque (  activity );
        BindCodigoSituacao0022 (  activity );
        BindDescricaoSituacao0022 (  activity );
        BindCodigoSituacao0770 (  activity );
        BindDescricaoSituacao0770 (  activity );
        #endregion

        #region Linha 5
        BindEstoque (  activity );
        BindCodigoLocalEstoque (  activity );
        BindDescricaoLocalEstoque (  activity );
        BindCodigoLocalProducao (  activity );
        BindDescricaoLocalProducao (  activity );
        #endregion

        #region Linha 6
        BindInspecao (  activity );
        BindCodigoLocalInspecao (  activity );
        BindDescricaoLocalInspecao (  activity );
        BindIesForcaApontamento (  activity );
        BindIesSofreBaixa (  activity );
        BindIesAberturaLiberacao (  activity );
        BindIesPlanejamento (  activity );
        #endregion

        #region Linha 7
        BindQuantidadeEstoqueSeguranca (  activity );
        BindQuantidadeDiasEstoqueSeguranca (  activity );
        BindQuantidadeDiasRessuprimento (  activity );
        BindCodigoProgramador (  activity );
        BindNomeProgramador (  activity );
        #endregion

        #region Linha 8
        BindQuantidadeProgramacaoMinima (  activity );
        BindQuantidadeProgramacaoMaxima (  activity );
        BindCodigoComprador (  activity );
        BindNomeComprador (  activity );
        #endregion

        #region Linha 9
        BindQuantidadeProgramacaoMultipla (  activity );
        BindQuantidadeProgramacaoFixa (  activity );
        #endregion

        #region Linha 10
        BindCodigoLinhaProduto (  activity );
        BindDescricaoLinhaProduto (  activity );
        #endregion

        #region Linha 11
        BindCodigoLinhaReceita (  activity );
        BindDescricaoLinhaReceita (  activity );
        #endregion

        #region Linha 12
        BindCodigoSegmentoMercado (  activity );
        BindDescricaoSegmentoMercado (  activity );
        #endregion

        #region Linha 13
        BindCodigoClasseUso (  activity );
        BindDescricaoClasseUso (  activity );
        #endregion
      }

      #region Estrutura - Bind
      private void BindEstrutura(Activity activity)
      {
        RloConsulta00 = activity.FindViewById<RelativeLayout>(Resource.Id.consulta00);
        LloConsulta00Botoes = activity.FindViewById<LinearLayout>(Resource.Id.consulta00botoes);
      }
      #endregion

      #region Linha 1 - Bind
      private void BindCodigoClassificacaoFiscal ( Activity activity )
      {
        TxtConsulta00CodigoClassificacaoFiscal = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoClassificacaoFiscal );
      }

      private void BindCodigoIncidenciaIcms ( Activity activity )
      {
        TxtConsulta00CodigoIncidenciaIcms = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoIncidenciaIcms );
      }

      private void BindCodigoIncidenciaIpi ( Activity activity )
      {
        TxtConsulta00CodigoIncidenciaIpi = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoIncidenciaIpi );
      }

      private void BindAliquotaIpi ( Activity activity )
      {
        TxtConsulta00AliquotaIpi = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00AliquotaIpi );
      }
      #endregion

      #region Linha 2 - Bind
      private void BindCodigoContenedor ( Activity activity )
      {
        TxtConsulta00CodigoContenedor = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoContenedor );
      }

      private void BindDescricaoContenedor ( Activity activity )
      {
        TxtConsulta00DescricaoContenedor = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoContenedor );
      }

      private void BindQuantidadeItensContenedor ( Activity activity )
      {
        TxtConsulta00QuantidadeItensContenedor = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeItensContenedor );
      }

      private void BindQuantidadeEmpilhamentoMaximo ( Activity activity )
      {
        TxtConsulta00QuantidadeEmpilhamentoMaximo = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeEmpilhamentoMaximo );
      }

      private void BindCodigoPainel ( Activity activity )
      {
        TxtConsulta00CodigoPainel = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoPainel );
      }

      private void BindCodigoPainelFisico ( Activity activity )
      {
        TxtConsulta00CodigoPainelFisico = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoPainelFisico );
      }
      #endregion

      #region Linha 3 - Bind
      private void BindCodigoTipoItem ( Activity activity )
      {
        TxtConsulta00CodigoTipoItem = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoTipoItem );
      }

      private void BindDescricaoTipoItem ( Activity activity )
      {
        TxtConsulta00DescricaoTipoItem = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoTipoItem );
      }

      private void BindCodigoFamilia ( Activity activity )
      {
        TxtConsulta00CodigoFamilia = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoFamilia );
      }

      private void BindDescricaoFamilia ( Activity activity )
      {
        TxtConsulta00DescricaoFamilia = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoFamilia );
      }

      private void BindDataCadastro ( Activity activity )
      {
        TxtConsulta00DataCadastro = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DataCadastro );
      }

      private void BindProdutoChave ( Activity activity )
      {
        TxtConsulta00ProdutoChave = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00ProdutoChave );
      }
      #endregion

      #region Linha 4 - Bind
      private void BindCodigoGrupoControleEstoque ( Activity activity )
      {
        TxtConsulta00CodigoGrupoControleEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoGrupoControleEstoque );
      }

      private void BindDescricaoGrupoControleEstoque ( Activity activity )
      {
        TxtConsulta00DescricaoGrupoControleEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoGrupoControleEstoque );
      }

      private void BindCodigoSituacao0022 ( Activity activity )
      {
        TxtConsulta00CodigoSituacao0022 = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoSituacao0022 );
      }

      private void BindDescricaoSituacao0022 ( Activity activity )
      {
        TxtConsulta00DescricaoSituacao0022 = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoSituacao0022 );
      }

      private void BindCodigoSituacao0770 ( Activity activity )
      {
        TxtConsulta00CodigoSituacao0770 = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoSituacao0770 );
      }

      private void BindDescricaoSituacao0770 ( Activity activity )
      {
        TxtConsulta00DescricaoSituacao0770 = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoSituacao0770 );
      }
      #endregion

      #region Linha 5 - Bind
      private void BindEstoque ( Activity activity )
      {
        CbxConsulta00Estoque = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsulta00Estoque );
      }

      private void BindCodigoLocalEstoque ( Activity activity )
      {
        TxtConsulta00CodigoLocalEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoLocalEstoque );
      }

      private void BindDescricaoLocalEstoque ( Activity activity )
      {
        TxtConsulta00DescricaoLocalEstoque = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoLocalEstoque );
      }

      private void BindCodigoLocalProducao ( Activity activity )
      {
        TxtConsulta00CodigoLocalProducao = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoLocalProducao );
      }

      private void BindDescricaoLocalProducao ( Activity activity )
      {
        TxtConsulta00DescricaoLocalProducao = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoLocalProducao );
      }
      #endregion

      #region Linha 6 - Bind
      private void BindInspecao ( Activity activity )
      {
        CbxConsulta00Inspecao = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsulta00Inspecao );
      }

      private void BindCodigoLocalInspecao ( Activity activity )
      {
        TxtConsulta00CodigoLocalInspecao = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoLocalInspecao );
      }

      private void BindDescricaoLocalInspecao ( Activity activity )
      {
        TxtConsulta00DescricaoLocalInspecao = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoLocalInspecao );
      }

      private void BindIesForcaApontamento ( Activity activity )
      {
        CbxConsulta00IesForcaApontamento = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsulta00IesForcaApontamento );
      }

      private void BindIesSofreBaixa ( Activity activity )
      {
        CbxConsulta00IesSofreBaixa = activity.FindViewById<CheckBox> ( Resource.Id.cbxConsulta00IesSofreBaixa );
      }

      private void BindIesAberturaLiberacao ( Activity activity )
      {
        TxtConsulta00IesAberturaLiberacao = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00IesAberturaLiberacao );
      }

      private void BindIesPlanejamento ( Activity activity )
      {
        TxtConsulta00IesPlanejamento = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00IesPlanejamento );
      }
      #endregion

      #region Linha 7 - Bind
      private void BindQuantidadeEstoqueSeguranca ( Activity activity )
      {
        TxtConsulta00QuantidadeEstoqueSeguranca = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeEstoqueSeguranca );
      }

      private void BindQuantidadeDiasEstoqueSeguranca ( Activity activity )
      {
        TxtConsulta00QuantidadeDiasEstoqueSeguranca = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeDiasEstoqueSeguranca );
      }

      private void BindQuantidadeDiasRessuprimento ( Activity activity )
      {
        TxtConsulta00QuantidadeDiasRessuprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeDiasRessuprimento );
      }

      private void BindCodigoProgramador ( Activity activity )
      {
        TxtConsulta00CodigoProgramador = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoProgramador );
      }

      private void BindNomeProgramador ( Activity activity )
      {
        TxtConsulta00NomeProgramador = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00NomeProgramador );
      }
      #endregion

      #region Linha 8 - Bind
      private void BindQuantidadeProgramacaoMinima ( Activity activity )
      {
        TxtConsulta00QuantidadeProgramacaoMinima = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeProgramacaoMinima );
      }

      private void BindQuantidadeProgramacaoMaxima ( Activity activity )
      {
        TxtConsulta00QuantidadeProgramacaoMaxima = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeProgramacaoMaxima );
      }

      private void BindCodigoComprador ( Activity activity )
      {
        TxtConsulta00CodigoComprador = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoComprador );
      }

      private void BindNomeComprador ( Activity activity )
      {
        TxtConsulta00NomeComprador = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00NomeComprador );
      }
      #endregion

      #region Linha 9 - Bind
      private void BindQuantidadeProgramacaoMultipla ( Activity activity )
      {
        TxtConsulta00QuantidadeProgramacaoMultipla = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeProgramacaoMultipla );
      }

      private void BindQuantidadeProgramacaoFixa ( Activity activity )
      {
        TxtConsulta00QuantidadeProgramacaoFixa = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00QuantidadeProgramacaoFixa );
      }
      #endregion

      #region Linha 10 - Bind
      private void BindCodigoLinhaProduto ( Activity activity )
      {
        TxtConsulta00CodigoLinhaProduto = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoLinhaProduto );
      }

      private void BindDescricaoLinhaProduto ( Activity activity )
      {
        TxtConsulta00DescricaoLinhaProduto = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoLinhaProduto );
      }
      #endregion

      #region Linha 11 - Bind
      private void BindCodigoLinhaReceita ( Activity activity )
      {
        TxtConsulta00CodigoLinhaReceita = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoLinhaReceita );
      }

      private void BindDescricaoLinhaReceita ( Activity activity )
      {
        TxtConsulta00DescricaoLinhaReceita = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoLinhaReceita );
      }
      #endregion

      #region Linha 12 - Bind
      private void BindCodigoSegmentoMercado ( Activity activity )
      {
        TxtConsulta00CodigoSegmentoMercado = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoSegmentoMercado );
      }

      private void BindDescricaoSegmentoMercado ( Activity activity )
      {
        TxtConsulta00DescricaoSegmentoMercado = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoSegmentoMercado );
      }
      #endregion

      #region Linha 13 - Bind
      private void BindCodigoClasseUso ( Activity activity )
      {
        TxtConsulta00CodigoClasseUso = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00CodigoClasseUso );
      }

      private void BindDescricaoClasseUso ( Activity activity )
      {
        TxtConsulta00DescricaoClasseUso = activity.FindViewById<TextView> ( Resource.Id.txtConsulta00DescricaoClasseUso );
      }
      #endregion

      public void Clear ( )
      {
        #region Linha1
        TxtConsulta00CodigoClassificacaoFiscal.Text = String.Empty;
        TxtConsulta00CodigoIncidenciaIcms.Text = String.Empty;
        TxtConsulta00CodigoIncidenciaIpi.Text = String.Empty;
        TxtConsulta00AliquotaIpi.Text = String.Empty;
        #endregion

        #region Linha2
        TxtConsulta00CodigoContenedor.Text = String.Empty;
        TxtConsulta00DescricaoContenedor.Text = String.Empty;
        TxtConsulta00QuantidadeItensContenedor.Text = String.Empty;
        TxtConsulta00QuantidadeEmpilhamentoMaximo.Text = String.Empty;
        TxtConsulta00CodigoPainel.Text = String.Empty;
        TxtConsulta00CodigoPainelFisico.Text = String.Empty;
        #endregion

        #region Linha3
        TxtConsulta00CodigoTipoItem.Text = String.Empty;
        TxtConsulta00DescricaoTipoItem.Text = String.Empty;
        TxtConsulta00CodigoFamilia.Text = String.Empty;
        TxtConsulta00DescricaoFamilia.Text = String.Empty;
        TxtConsulta00DataCadastro.Text = String.Empty;
        TxtConsulta00ProdutoChave.Text = String.Empty;
        #endregion

        #region Linha4
        TxtConsulta00CodigoGrupoControleEstoque.Text = String.Empty;
        TxtConsulta00DescricaoGrupoControleEstoque.Text = String.Empty;
        TxtConsulta00CodigoSituacao0022.Text = String.Empty;
        TxtConsulta00DescricaoSituacao0022.Text = String.Empty;
        TxtConsulta00CodigoSituacao0770.Text = String.Empty;
        TxtConsulta00DescricaoSituacao0770.Text = String.Empty;
        #endregion

        #region Linha5
        CbxConsulta00Estoque.Checked = false;
        TxtConsulta00CodigoLocalEstoque.Text = String.Empty;
        TxtConsulta00DescricaoLocalEstoque.Text = String.Empty;
        TxtConsulta00CodigoLocalProducao.Text = String.Empty;
        TxtConsulta00DescricaoLocalProducao.Text = String.Empty;
        #endregion

        #region Linha6
        CbxConsulta00Inspecao.Checked = false;
        TxtConsulta00CodigoLocalInspecao.Text = String.Empty;
        TxtConsulta00DescricaoLocalInspecao.Text = String.Empty;
        CbxConsulta00IesForcaApontamento.Checked = false;
        CbxConsulta00IesSofreBaixa.Checked = false;
        TxtConsulta00IesAberturaLiberacao.Text = String.Empty;
        TxtConsulta00IesPlanejamento.Text = String.Empty;
        #endregion

        #region Linha7
        TxtConsulta00QuantidadeEstoqueSeguranca.Text = String.Empty;
        TxtConsulta00QuantidadeDiasEstoqueSeguranca.Text = String.Empty;
        TxtConsulta00QuantidadeDiasRessuprimento.Text = String.Empty;
        TxtConsulta00CodigoProgramador.Text = String.Empty;
        TxtConsulta00NomeProgramador.Text = String.Empty;
        #endregion

        #region Linha8
        TxtConsulta00QuantidadeProgramacaoMinima.Text = String.Empty;
        TxtConsulta00QuantidadeProgramacaoMaxima.Text = String.Empty;
        TxtConsulta00CodigoComprador.Text = String.Empty;
        TxtConsulta00NomeComprador.Text = String.Empty;
        #endregion

        #region Linha9
        TxtConsulta00QuantidadeProgramacaoMultipla.Text = String.Empty;
        TxtConsulta00QuantidadeProgramacaoFixa.Text = String.Empty;
        #endregion

        #region Linha10
        TxtConsulta00CodigoLinhaProduto.Text = String.Empty;
        TxtConsulta00DescricaoLinhaProduto.Text = String.Empty;
        #endregion

        #region Linha11
        TxtConsulta00CodigoLinhaReceita.Text = String.Empty;
        TxtConsulta00DescricaoLinhaReceita.Text = String.Empty;
        #endregion

        #region Linha12
        TxtConsulta00CodigoSegmentoMercado.Text = String.Empty;
        TxtConsulta00DescricaoSegmentoMercado.Text = String.Empty;
        #endregion

        #region Linha13
        TxtConsulta00CodigoClasseUso.Text = String.Empty;
        TxtConsulta00DescricaoClasseUso.Text = String.Empty;
        #endregion
      }

      public void AtualizaCampos ( Variaveis valor )
      {
        #region Linha 1
        TxtConsulta00CodigoClassificacaoFiscal.Text = valor.CodigoClassificacaoFiscal.Trim();
        TxtConsulta00CodigoIncidenciaIcms.Text = valor.CodigoIncidenciaIcms.Trim();
        TxtConsulta00CodigoIncidenciaIpi.Text = valor.CodigoIncidenciaIpi.Trim();
        TxtConsulta00AliquotaIpi.Text = valor.AliquotaIpi.ToString("##0.00").Trim();
        #endregion

        #region Linha 2
        TxtConsulta00CodigoContenedor.Text = valor.CodigoContenedor.Trim();
        TxtConsulta00DescricaoContenedor.Text = valor.DescricaoContenedor.Trim();
        TxtConsulta00QuantidadeItensContenedor.Text = valor.QuantidadeItensContenedor.ToString("###0").Trim();
        TxtConsulta00QuantidadeEmpilhamentoMaximo.Text = valor.QuantidadeEmpilhamentoMaximo.ToString("###0").Trim();
        TxtConsulta00CodigoPainel.Text = valor.CodigoPainel.Trim();
        TxtConsulta00CodigoPainelFisico.Text = valor.CodigoPainelFisico.Trim();
        #endregion

        #region Linha 3
        TxtConsulta00CodigoTipoItem.Text = valor.CodigoTipoItem.Trim();
        TxtConsulta00DescricaoTipoItem.Text = valor.DescricaoTipoItem.Trim();
        TxtConsulta00CodigoFamilia.Text = valor.CodigoFamilia.Trim();
        TxtConsulta00DescricaoFamilia.Text = valor.DescricaoFamilia.Trim();
        TxtConsulta00DataCadastro.Text = valor.DataCadastro.ToString("d");
        TxtConsulta00ProdutoChave.Text = valor.ProdutoChave.Trim();
        #endregion

        #region Linha 4
        TxtConsulta00CodigoGrupoControleEstoque.Text = valor.CodigoGrupoControleEstoque.Trim();
        TxtConsulta00DescricaoGrupoControleEstoque.Text = valor.DescricaoGrupoControleEstoque.Trim();
        TxtConsulta00CodigoSituacao0022.Text = valor.CodigoSituacao0022.Trim();
        TxtConsulta00DescricaoSituacao0022.Text = valor.DescricaoSituacao0022.Trim();
        TxtConsulta00CodigoSituacao0770.Text = valor.CodigoSituacao0770.Trim();
        TxtConsulta00DescricaoSituacao0770.Text = valor.DescricaoSituacao0770.Trim();
        #endregion

        #region Linha 5
        CbxConsulta00Estoque.Checked = valor.Estoque;
        TxtConsulta00CodigoLocalEstoque.Text = valor.CodigoLocalEstoque.Trim();
        TxtConsulta00DescricaoLocalEstoque.Text = valor.DescricaoLocalEstoque.Trim();
        TxtConsulta00CodigoLocalProducao.Text = valor.CodigoLocalProducao.Trim();
        TxtConsulta00DescricaoLocalProducao.Text = valor.DescricaoLocalProducao.Trim();
        #endregion

        #region Linha 6
        CbxConsulta00Inspecao.Checked = valor.Inspecao;
        TxtConsulta00CodigoLocalInspecao.Text = valor.CodigoLocalInspecao.Trim();
        TxtConsulta00DescricaoLocalInspecao.Text = valor.DescricaoLocalInspecao.Trim();
        CbxConsulta00IesForcaApontamento.Checked = valor.IesForcaApontamento;
        CbxConsulta00IesSofreBaixa.Checked = valor.IesSofreBaixa;
        TxtConsulta00IesAberturaLiberacao.Text = valor.IesAberturaLiberacao.Trim();
        TxtConsulta00IesPlanejamento.Text = valor.IesPlanejamento.Trim();
        #endregion

        #region Linha 7
        TxtConsulta00QuantidadeEstoqueSeguranca.Text = valor.QuantidadeEstoqueSeguranca.ToString("####0.000").Trim();
        TxtConsulta00QuantidadeDiasEstoqueSeguranca.Text = valor.QuantidadeDiasEstoqueSeguranca.ToString("###0").Trim();
        TxtConsulta00QuantidadeDiasRessuprimento.Text = valor.QuantidadeDiasRessuprimento.ToString("###0").Trim();
        TxtConsulta00CodigoProgramador.Text = valor.CodigoProgramador.Trim();
        TxtConsulta00NomeProgramador.Text = valor.NomeProgramador.Trim();
        #endregion

        #region Linha 8
        TxtConsulta00QuantidadeProgramacaoMinima.Text = valor.QuantidadeProgramacaoMinima.ToString("####0.000").Trim();
        TxtConsulta00QuantidadeProgramacaoMaxima.Text = valor.QuantidadeProgramacaoMaxima.ToString("####0.000").Trim();
        TxtConsulta00CodigoComprador.Text = valor.CodigoComprador.Trim();
        TxtConsulta00NomeComprador.Text = valor.NomeComprador.Trim();
        #endregion

        #region Linha 9
        TxtConsulta00QuantidadeProgramacaoMultipla.Text = valor.QuantidadeProgramacaoMultipla.ToString("####0.000").Trim();
        TxtConsulta00QuantidadeProgramacaoFixa.Text = valor.QuantidadeProgramacaoFixa.ToString("####0.000").Trim();
        #endregion

        #region Linha 10
        TxtConsulta00CodigoLinhaProduto.Text = valor.CodigoLinhaProduto.Trim();
        TxtConsulta00DescricaoLinhaProduto.Text = valor.DescricaoLinhaProduto.Trim();
        #endregion

        #region Linha 11
        TxtConsulta00CodigoLinhaReceita.Text = valor.CodigoLinhaReceita.Trim();
        TxtConsulta00DescricaoLinhaReceita.Text = valor.DescricaoLinhaReceita.Trim();
        #endregion

        #region Linha 12
        TxtConsulta00CodigoSegmentoMercado.Text = valor.CodigoSegmentoMercado.Trim();
        TxtConsulta00DescricaoSegmentoMercado.Text = valor.DescricaoSegmentoMercado.Trim();
        #endregion

        #region Linha 13
        TxtConsulta00CodigoClasseUso.Text = valor.CodigoClasseUso.Trim();
        TxtConsulta00DescricaoClasseUso.Text = valor.DescricaoClasseUso.Trim ( );
        #endregion
      }

    }

    private readonly Config         _bcoSql;
    private readonly AcessoSql      _acessoSql;
    private Boolean                 _ok;
    private Tabela                  _consulta00;
    private List<Coluna>            _colunas;
    private Variaveis               _variaveis;
    private Campos                  _camposTela;
    private Item.Classe             _item;

    public Tabela Tabela
    {
      get
      {
        return _consulta00;
      }
      set
      {
        _consulta00 = value;
      }
    }

    public Boolean Ok
    {
      get
      {
        return _ok;
      }
      set
      {
        _ok = value;
      }
    }

    public List<Coluna> Colunas
    {
      get
      {
        return _colunas;
      }
      set
      {
        _colunas = value;
      }
    }

    public Config BcoSql
    {
      get { return _bcoSql; }
    }

    public AcessoSql AcessoSql
    {
      get { return _acessoSql; }
    }

    public Item.Classe Item
    {
      get { return _item; }
      set { _item = value; }
    }

    public Campos CamposTela
    {
      get { return _camposTela; }
      set { _camposTela = value; }
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, Item.Classe item )
    {
      _ok = true;
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _item = item;
      ClasseComum ( activity );
    }

    private void ClasseComum ( Activity activity  )
    {
      _ok = false;
      CriaColunas ( );
      _variaveis = new Variaveis();
      CamposTela = new Campos(activity);
      CamposTela.LloConsulta00Botoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear();
      if (_item.Ok)
      {
        PopulaRecord(_item);
      }
    }

    public void Show()
    {
      _camposTela.RloConsulta00.Visibility = ViewStates.Visible;
    }

    public void Hide()
    {
      _camposTela.RloConsulta00.Visibility = ViewStates.Gone;
    }

    private void CriaColunas ( )
    {
      _colunas = new List<Coluna>();

      #region Item
      _colunas.Add( new Coluna( 0, "CodigoItem", "", typeof(String), true, false, false));
      _colunas.Add( new Coluna( 1, "DescricaoItem", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 2, "CodigoUnidadeMedida", "", typeof(String), false, false, false));
      #endregion

      #region Linha1
      _colunas.Add( new Coluna( 3, "CodigoClassificacaoFiscal", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 4, "CodigoIncidenciaIcms", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 5, "CodigoIncidenciaIpi", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 6, "AliquotaIpi", "", typeof(Double), false, false, false));
      #endregion
      
      #region Linha2
      _colunas.Add( new Coluna( 7, "CodigoContenedor", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 8, "DescricaoContenedor", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna( 9, "QuantidadeItensContenedor", "", typeof(Int32), false, false, false));
      _colunas.Add( new Coluna(10, "QuantidadeEmpilhamentoMaximo", "", typeof(Int32), false, false, false));
      _colunas.Add( new Coluna(11, "CodigoPainel", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(12, "CodigoPainelFisico", "", typeof(String), false, false, false));
      #endregion

      #region Linha3
      _colunas.Add( new Coluna(13, "CodigoTipoItem", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(14, "DescricaoTipoItem", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(15, "CodigoFamilia", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(16, "DescricaoFamilia", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(17, "DataCadastro", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(18, "ProdutoChave", "", typeof(String), false, false, false));
      #endregion

      #region Linha4
      _colunas.Add( new Coluna(19, "CodigoGrupoControleEstoque", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(20, "DescricaoGrupoControleEstoque", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(21, "CodigoSituacao0022", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(22, "DescricaoSituacao0022", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(23, "CodigoSituacao0770", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(24, "DescricaoSituacao0770", "", typeof(String), false, false, false));
      #endregion

      #region Linha5
      _colunas.Add( new Coluna(25, "Estoque", "", typeof(Boolean), false, false, false));
      _colunas.Add( new Coluna(26, "CodigoLocalEstoque", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(27, "DescricaoLocalEstoque", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(28, "CodigoLocalProducao", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(29, "DescricaoLocalProducao", "", typeof(String), false, false, false));
      #endregion

      #region Linha6
      _colunas.Add( new Coluna(30, "Inspecao", "", typeof(Boolean), false, false, false));
      _colunas.Add( new Coluna(31, "CodigoLocalInspecao", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(32, "DescricaoLocalInspecao", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(33, "IesForcaApontamento", "", typeof(Boolean), false, false, false));
      _colunas.Add( new Coluna(34, "IesSofreBaixa", "", typeof(Boolean), false, false, false));
      _colunas.Add( new Coluna(35, "IesAberturaLiberacao", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(36, "IesPlanejamento", "", typeof(String), false, false, false));
      #endregion

      #region Linha7
      _colunas.Add( new Coluna(37, "QuantidadeEstoqueSeguranca", "", typeof(Double), false, false, false));
      _colunas.Add( new Coluna(38, "QuantidadeDiasEstoqueSeguranca", "", typeof(Int32), false, false, false));
      _colunas.Add( new Coluna(39, "QuantidadeDiasRessuprimento", "", typeof(Int32), false, false, false));
      _colunas.Add( new Coluna(40, "CodigoProgramador", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(41, "NomeProgramador", "", typeof(String), false, false, false));
      #endregion

      #region Linha8
      _colunas.Add( new Coluna(42, "QuantidadeProgramacaoMinima", "", typeof(Double), false, false, false));
      _colunas.Add( new Coluna(43, "QuantidadeProgramacaoMaxima", "", typeof(Double), false, false, false));
      _colunas.Add( new Coluna(44, "CodigoComprador", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(45, "NomeComprador", "", typeof(String), false, false, false));
      #endregion

      #region Linha9
      _colunas.Add( new Coluna(46, "QuantidadeProgramacaoMultipla", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(47, "QuantidadeProgramacaoFixa", "", typeof(String), false, false, false));
      #endregion

      #region Linha10
      _colunas.Add( new Coluna(48, "CodigoLinhaProduto", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(49, "DescricaoLinhaProduto", "", typeof(String), false, false, false));
      #endregion

      #region Linha11
      _colunas.Add( new Coluna(51, "CodigoLinhaReceita", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(52, "DescricaoLinhaReceita", "", typeof(String), false, false, false));
      #endregion

      #region Linha12
      _colunas.Add( new Coluna(53, "CodigoSegmentoMercado", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(54, "DescricaoSegmentoMercado", "", typeof(String), false, false, false));
      #endregion

      #region Linha13
      _colunas.Add( new Coluna(55, "CodigoClasseUso", "", typeof(String), false, false, false));
      _colunas.Add( new Coluna(56, "DescricaoClasseUso", "", typeof(String), false, false, false));
      #endregion

    }

    private void PopulaRecord(Item.Classe item)
    {
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.QueryItem, _acessoSql.OpenQuery, item.Variaveis.CodigoEmpresa, item.Variaveis.CodigoItem );
      var banco = new Msde ( _acessoSql );
      banco.Open ( );
      SqlDataReader reader = banco.DataReader ( query.ToString ( ) );
      while ( reader.Read ( ) )
      {
        _variaveis = new Variaveis(reader);
        CamposTela.AtualizaCampos(_variaveis);
        break;
      }
      reader.Close ( );
      reader.Dispose ( );
      banco.Close ( );
    }

  }
}
