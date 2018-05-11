using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lor0138.Classes.Consultas.Item;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.ConsultaDimensionais
{
  public class Classe
  {

    public class Variaveis
    {

      #region Privadas 

      #region Linha 1
      private Int32 _quantidadePecasItem;
      private Int32 _quantidadeItensCaixa;
      #endregion

      #region Linha 2
      private Double _produtoComprimento;
      private Double _produtoLargura;
      private Double _produtoAltura;
      #endregion

      #region Linha 3
      private Double _produtoPeso;
      private Double _produtoVolume;
      private Double _produtoVolumeAdicional;
      #endregion

      #region Linha 4
      private Int32 _QuantidadeEmbalagensVendaVarejo;
      #endregion

      #region Linha 5
      private Double _embalagemComprimento;
      private Double _embalagemLargura;
      private Double _embalagemAltura;
      #endregion

      #region Linha 6
      private Double _embalagemPesoVazia;
      private Double _embalagemPesoCheia;
      private Double _embalagemVolume;
      #endregion

      #region Linha 7
      private Int32 _paleteQuantidadeCaixasCamada;
      private Int32 _paleteQuantidadeCamadas;
      #endregion

      #region Linha 8
      private Int32 _paleteQuantidadeCaixasColetivas;
      #endregion

      #region Linha 9
      private Int32 _paleteQuantidadeEmlagensVendaVarejo;
      private Double _paletePeso;
      #endregion

      #endregion

      #region Públicas

      #region Linha 1
      public Int32 QuantidadePecasItem
      {
        get
        {
          return _quantidadePecasItem;
        }
        private set
        {
          _quantidadePecasItem = value;
        }
      }

      public Int32 QuantidadeItensCaixa
      {
        get
        {
          return _quantidadeItensCaixa;
        }
        private set
        {
          _quantidadeItensCaixa = value;
        }
      }
      #endregion

      #region Linha 2
      public Double ProdutoComprimento
      {
        get
        {
          return _produtoComprimento;
        }
        private set
        {
          _produtoComprimento = value;
        }
      }

      public Double ProdutoLargura
      {
        get
        {
          return _produtoLargura;
        }
        private set
        {
          _produtoLargura = value;
        }
      }

      public Double ProdutoAltura
      {
        get
        {
          return _produtoAltura;
        }
        private set
        {
          _produtoAltura = value;
        }
      }
      #endregion

      #region Linha 3
      public Double ProdutoPeso
      {
        get
        {
          return _produtoPeso;
        }
        private set
        {
          _produtoPeso = value;
        }
      }

      public Double ProdutoVolume
      {
        get
        {
          return _produtoVolume;
        }
        private set
        {
          _produtoVolume = value;
        }
      }

      public Double ProdutoVolumeAdicional
      {
        get
        {
          return _produtoVolumeAdicional;
        }
        private set
        {
          _produtoVolumeAdicional = value;
        }
      }
      #endregion

      #region Linha 4
      public Int32 QuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _QuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _QuantidadeEmbalagensVendaVarejo = value;
        }
      }
      #endregion

      #region Linha 5
      public Double EmbalagemComprimento
      {
        get
        {
          return _embalagemComprimento;
        }
        private set
        {
          _embalagemComprimento = value;
        }
      }

      public Double EmbalagemLargura
      {
        get
        {
          return _embalagemLargura;
        }
        private set
        {
          _embalagemLargura = value;
        }
      }

      public Double EmbalagemAltura
      {
        get
        {
          return _embalagemAltura;
        }
        private set
        {
          _embalagemAltura = value;
        }
      }
      #endregion

      #region Linha 6
      public Double EmbalagemPesoVazia
      {
        get
        {
          return _embalagemPesoVazia;
        }
        private set
        {
          _embalagemPesoVazia = value;
        }
      }

      public Double EmbalagemPesoCheia
      {
        get
        {
          return _embalagemPesoCheia;
        }
        private set
        {
          _embalagemPesoCheia = value;
        }
      }

      public Double EmbalagemVolume
      {
        get
        {
          return _embalagemVolume;
        }
        private set
        {
          _embalagemVolume = value;
        }
      }
      #endregion

      #region Linha 7
      public Int32 PaleteQuantidadeCaixasCamada
      {
        get
        {
          return _paleteQuantidadeCaixasCamada;
        }
        private set
        {
          _paleteQuantidadeCaixasCamada = value;
        }
      }

      public Int32 PaleteQuantidadeCamadas
      {
        get
        {
          return _paleteQuantidadeCamadas;
        }
        private set
        {
          _paleteQuantidadeCamadas = value;
        }
      }
      #endregion

      #region Linha 8
      public Int32 PaleteQuantidadeCaixasColetivas
      {
        get
        {
          return _paleteQuantidadeCaixasColetivas;
        }
        private set
        {
          _paleteQuantidadeCaixasColetivas = value;
        }
      }
      #endregion

      #region Linha 9
      public Int32 PaleteQuantidadeEmlagensVendaVarejo
      {
        get
        {
          return _paleteQuantidadeEmlagensVendaVarejo;
        }
        private set
        {
          _paleteQuantidadeEmlagensVendaVarejo = value;
        }
      }

      public Double PaletePeso
      {
        get
        {
          return _paletePeso;
        }
        private set
        {
          _paletePeso = value;
        }
      }
      #endregion

      #endregion

      private void Clear ( )
      {

        #region Linha 1
        QuantidadePecasItem = 0;
        QuantidadeItensCaixa = 0;
        #endregion

        #region Linha 2
        ProdutoComprimento = 0.0f;
        ProdutoLargura = 0.0f;
        ProdutoAltura = 0.0f;
        #endregion

        #region Linha 3
        ProdutoPeso = 0.0f;
        ProdutoVolume = 0.0f;
        ProdutoVolumeAdicional = 0.0f;
        #endregion

        #region Linha 4
        QuantidadeEmbalagensVendaVarejo = 0;
        #endregion

        #region Linha 5
        EmbalagemComprimento = 0.0f;
        EmbalagemLargura = 0.0f;
        #endregion

        #region Linha 6
        EmbalagemPesoVazia = 0.0f;
        EmbalagemPesoCheia = 0.0f;
        EmbalagemVolume = 0.0f;
        #endregion

        #region Linha 7
        PaleteQuantidadeCaixasCamada = 0;
        PaleteQuantidadeCamadas = 0;
        #endregion

        #region Linha 8
        PaleteQuantidadeCaixasColetivas = 0;
        #endregion

        #region Linha 9
        PaleteQuantidadeEmlagensVendaVarejo = 0;
        PaletePeso = 0;
        #endregion

      }

      public Variaveis ( )
      {
        Clear ( );
      }

      public Variaveis ( DataRow dataRow )
      {

        #region Linha 1
        QuantidadePecasItem = DbConvert.GetInt32 ( dataRow, "QuantidadePecasItem" );
        QuantidadeItensCaixa = DbConvert.GetInt32 ( dataRow, "QuantidadeItensCaixa" );
        #endregion

        #region Linha 2
        ProdutoComprimento = DbConvert.GetDouble ( dataRow, "ProdutoComprimento" );
        ProdutoLargura = DbConvert.GetDouble ( dataRow, "ProdutoLargura" );
        ProdutoAltura = DbConvert.GetDouble ( dataRow, "ProdutoAltura" );
        #endregion

        #region Linha 3
        ProdutoPeso = DbConvert.GetDouble ( dataRow, "ProdutoPeso" );
        ProdutoVolume = DbConvert.GetDouble ( dataRow, "ProdutoVolume" );
        ProdutoVolumeAdicional = DbConvert.GetDouble ( dataRow, "ProdutoVolumeAdicional" );
        #endregion

        #region Linha 4
        QuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataRow, "QuantidadeEmbalagensVendaVarejo" );
        #endregion

        #region Linha 5
        EmbalagemComprimento = DbConvert.GetDouble ( dataRow, "EmbalagemComprimento" );
        EmbalagemLargura = DbConvert.GetDouble ( dataRow, "EmbalagemLargura" );
        #endregion

        #region Linha 6
        EmbalagemPesoVazia = DbConvert.GetDouble ( dataRow, "EmbalagemPesoVazia" );
        EmbalagemPesoCheia = DbConvert.GetDouble ( dataRow, "EmbalagemPesoCheia" );
        EmbalagemVolume = DbConvert.GetDouble ( dataRow, "EmbalagemVolume" );
        #endregion

        #region Linha 7
        PaleteQuantidadeCaixasCamada = DbConvert.GetInt32 ( dataRow, "PaleteQuantidadeCaixasCamada" );
        PaleteQuantidadeCamadas = DbConvert.GetInt32 ( dataRow, "PaleteQuantidadeCamadas" );
        #endregion

        #region Linha 8
        PaleteQuantidadeCaixasColetivas = DbConvert.GetInt32 ( dataRow, "PaleteQuantidadeCaixasColetivas" );
        #endregion

        #region Linha 9
        PaleteQuantidadeEmlagensVendaVarejo = DbConvert.GetInt32 ( dataRow, "PaleteQuantidadeEmlagensVendaVarejo" );
        PaletePeso = DbConvert.GetDouble ( dataRow, "PaletePeso" );
        #endregion

      }

      public Variaveis ( SqlDataReader dataReader = null )
      {
        if ( dataReader != null )
        {

          #region Linha 1
          QuantidadePecasItem = DbConvert.GetInt32 ( dataReader, "QuantidadePecasItem" );
          QuantidadeItensCaixa = DbConvert.GetInt32 ( dataReader, "QuantidadeItensCaixa" );
          #endregion

          #region Linha 2
          ProdutoComprimento = DbConvert.GetDouble ( dataReader, "ProdutoComprimento" );
          ProdutoLargura = DbConvert.GetDouble ( dataReader, "ProdutoLargura" );
          ProdutoAltura = DbConvert.GetDouble ( dataReader, "ProdutoAltura" );
          #endregion

          #region Linha 3
          ProdutoPeso = DbConvert.GetDouble ( dataReader, "ProdutoPeso" );
          ProdutoVolume = DbConvert.GetDouble ( dataReader, "ProdutoVolume" );
          ProdutoVolume = DbConvert.GetDouble ( dataReader, "ProdutoVolume" );
          #endregion

          #region Linha 4
          QuantidadeEmbalagensVendaVarejo = DbConvert.GetInt32 ( dataReader, "QuantidadeEmbalagensVendaVarejo" );
          #endregion

          #region Linha 5
          EmbalagemComprimento = DbConvert.GetDouble ( dataReader, "EmbalagemComprimento" );
          EmbalagemLargura = DbConvert.GetDouble ( dataReader, "EmbalagemLargura" );
          #endregion

          #region Linha 6
          EmbalagemPesoVazia = DbConvert.GetDouble ( dataReader, "EmbalagemPesoVazia" );
          EmbalagemPesoCheia = DbConvert.GetDouble ( dataReader, "EmbalagemPesoCheia" );
          EmbalagemVolume = DbConvert.GetDouble ( dataReader, "EmbalagemVolume" );
          #endregion

          #region Linha 7
          PaleteQuantidadeCaixasCamada = DbConvert.GetInt32 ( dataReader, "PaleteQuantidadeCaixasCamada" );
          PaleteQuantidadeCamadas = DbConvert.GetInt32 ( dataReader, "PaleteQuantidadeCamadas" );
          #endregion

          #region Linha 8
          PaleteQuantidadeCaixasColetivas = DbConvert.GetInt32 ( dataReader, "PaleteQuantidadeCaixasColetivas" );
          #endregion

          #region Linha 9
          PaleteQuantidadeEmlagensVendaVarejo = DbConvert.GetInt32 ( dataReader, "PaleteQuantidadeEmlagensVendaVarejo" );
          PaletePeso = DbConvert.GetDouble ( dataReader, "PaletePeso" );
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
      private RelativeLayout _rloConsultaDimensionais;
      private LinearLayout _lloConsultaDimensionaisBotoes;
      #endregion

      #region Linha 1
      private TextView _txtConsultaDimensionaisQuantidadePecasItem;
      private TextView _txtConsultaDimensionaisQuantidadeItensCaixa;
      #endregion

      #region Linha 2
      private TextView _txtConsultaDimensionaisProdutoComprimento;
      private TextView _txtConsultaDimensionaisProdutoLargura;
      private TextView _txtConsultaDimensionaisProdutoAltura;
      #endregion

      #region Linha 3
      private TextView _txtConsultaDimensionaisProdutoPeso;
      private TextView _txtConsultaDimensionaisProdutoVolume;
      private TextView _txtConsultaDimensionaisProdutoVolumeAdicional;
      #endregion

      #region Linha 4
      private TextView _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo;
      #endregion

      #region Linha 5
      private TextView _txtConsultaDimensionaisEmbalagemComprimento;
      private TextView _txtConsultaDimensionaisEmbalagemLargura;
      private TextView _txtConsultaDimensionaisEmbalagemAltura;
      #endregion

      #region Linha 6
      private TextView _txtConsultaDimensionaisEmbalagemPesoVazia;
      private TextView _txtConsultaDimensionaisEmbalagemPesoCheia;
      private TextView _txtConsultaDimensionaisEmbalagemVolume;
      #endregion

      #region Linha 7
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada;
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCamadas;
      #endregion

      #region Linha 8
      private TextView _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas;
      #endregion

      #region Linha 9
      private TextView _txtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo;
      private TextView _txtConsultaDimensionaisPaletePeso;
      #endregion

      #endregion

      #region Públicas

      #region Estrutura
      public RelativeLayout RloConsultaDimensionais
      {
        get { return _rloConsultaDimensionais; }
        set { _rloConsultaDimensionais = value; }
      }
      public LinearLayout LloConsultaDimensionaisBotoes
      {
        get
        {
          return _lloConsultaDimensionaisBotoes;
        }
        set
        {
          _lloConsultaDimensionaisBotoes = value;
        }
      }
      #endregion

      #region Linha 1
      public TextView TxtConsultaDimensionaisQuantidadePecasItem
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadePecasItem;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadePecasItem = value;
        }
      }

      public TextView TxtConsultaDimensionaisQuantidadeItensCaixa
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadeItensCaixa;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadeItensCaixa = value;
        }
      }
      #endregion

      #region Linha 2
      public TextView TxtConsultaDimensionaisProdutoComprimento
      {
        get
        {
          return _txtConsultaDimensionaisProdutoComprimento;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoComprimento = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoLargura
      {
        get
        {
          return _txtConsultaDimensionaisProdutoLargura;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoLargura = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoAltura
      {
        get
        {
          return _txtConsultaDimensionaisProdutoAltura;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoAltura = value;
        }
      }
      #endregion

      #region Linha 3
      public TextView TxtConsultaDimensionaisProdutoPeso
      {
        get
        {
          return _txtConsultaDimensionaisProdutoPeso;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoPeso = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoVolume
      {
        get
        {
          return _txtConsultaDimensionaisProdutoVolume;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoVolume = value;
        }
      }

      public TextView TxtConsultaDimensionaisProdutoVolumeAdicional
      {
        get
        {
          return _txtConsultaDimensionaisProdutoVolumeAdicional;
        }
        private set
        {
          _txtConsultaDimensionaisProdutoVolumeAdicional = value;
        }
      }
      #endregion

      #region Linha 4
      public TextView TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo
      {
        get
        {
          return _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo;
        }
        private set
        {
          _txtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo = value;
        }
      }
      #endregion

      #region Linha 5
      public TextView TxtConsultaDimensionaisEmbalagemComprimento
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemComprimento;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemComprimento = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemLargura
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemLargura;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemLargura = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemAltura
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemAltura;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemAltura = value;
        }
      }
      #endregion

      #region Linha 6
      public TextView TxtConsultaDimensionaisEmbalagemPesoVazia
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemPesoVazia;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemPesoVazia = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemPesoCheia
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemPesoCheia;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemPesoCheia = value;
        }
      }

      public TextView TxtConsultaDimensionaisEmbalagemVolume
      {
        get
        {
          return _txtConsultaDimensionaisEmbalagemVolume;
        }
        private set
        {
          _txtConsultaDimensionaisEmbalagemVolume = value;
        }
      }
      #endregion

      #region Linha 7
      public TextView TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCaixasCamada = value;
        }
      }

      public TextView TxtConsultaDimensionaisPaleteQuantidadeCamadas
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCamadas;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCamadas = value;
        }
      }
      #endregion

      #region Linha 8
      public TextView TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas = value;
        }
      }
      #endregion

      #region Linha 9
      public TextView TxtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo
      {
        get
        {
          return _txtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo;
        }
        private set
        {
          _txtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo = value;
        }
      }

      public TextView TxtConsultaDimensionaisPaletePeso
      {
        get
        {
          return _txtConsultaDimensionaisPaletePeso;
        }
        private set
        {
          _txtConsultaDimensionaisPaletePeso = value;
        }
      }
      #endregion

      #endregion

      public Campos ( Activity activity )
      {
        Bind ( activity );
      }

      private void Bind ( Activity activity )
      {

        #region Estrutura
        BindEstrutura ( activity );
        #endregion

        #region Linha 1
        BindQuantidadePecasItem ( activity );
        BindQuantidadeItensCaixa ( activity );
        #endregion

        #region Linha 2
        BindProdutoComprimento ( activity );
        BindProdutoLargura ( activity );
        BindProdutoAltura ( activity );
        #endregion

        #region Linha 3
        BindProdutoPeso ( activity );
        BindProdutoVolume ( activity );
        BindProdutoVolumeAdicional  ( activity );
        #endregion

        #region Linha 
        BindQuantidadeEmbalagensVendaVarejo ( activity );
        #endregion

        #region Linha 5
        BindEmbalagemComprimento ( activity );
        BindEmbalagemLargura ( activity );
        BindEmbalagemAltura ( activity );
        #endregion

        #region Linha 6
        BindEmbalagemPesoVazia ( activity );
        BindEmbalagemPesoCheia ( activity );
        BindEmbalagemVolume ( activity );
        #endregion

        #region Linha 7
        BindPaleteQuantidadeCaixasCamada ( activity );
        BindPaleteQuantidadeCamadas ( activity );
        #endregion

        #region Linha 8
        BindPaleteQuantidadeCaixasColetivas ( activity );
        #endregion

        #region Linha 9
        BindPaleteQuantidadeEmlagensVendaVarejo ( activity );
        BindPaletePeso ( activity );
        #endregion
      }

      #region Bind - Estrutura
      private void BindEstrutura ( Activity activity )
      {
        RloConsultaDimensionais = activity.FindViewById<RelativeLayout> ( Resource.Id.consultaDimensionais );
        LloConsultaDimensionaisBotoes = activity.FindViewById<LinearLayout> ( Resource.Id.consultaDimensionaisbotoes );
      }
      #endregion

      #region Bind - Linha 1
      private void BindQuantidadePecasItem ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadePecasItem = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisQuantidadePecasItem );
      }

      private void BindQuantidadeItensCaixa ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadeItensCaixa = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisQuantidadeItensCaixa );
      }
      #endregion

      #region Bind - Linha 2
      private void BindProdutoComprimento ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoComprimento = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoComprimento );
      }

      private void BindProdutoLargura ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoLargura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoLargura );
      }

      private void BindProdutoAltura ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoAltura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoAltura );
      }
      #endregion

      #region Bind - Linha 3
      private void BindProdutoPeso ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoPeso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoPeso );
      }

      private void BindProdutoVolume ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoVolume = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoVolume );
      }

      private void BindProdutoVolumeAdicional ( Activity activity )
      {
        TxtConsultaDimensionaisProdutoVolumeAdicional = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisProdutoVolumeAdicional );
      }
      #endregion

      #region Bind - Linha 4
      private void BindQuantidadeEmbalagensVendaVarejo ( Activity activity )
      {
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo );
      }
      #endregion

      #region Bind - Linha 5
      private void BindEmbalagemComprimento ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemComprimento = activity.FindViewById<CheckBox> ( Resource.Id.txtConsultaDimensionaisEmbalagemComprimento );
      }

      private void BindEmbalagemLargura ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemLargura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemLargura );
      }

      private void BindEmbalagemAltura ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemAltura = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemAltura );
      }
      #endregion

      #region Bind - Linha 6
      private void BindEmbalagemPesoVazia ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemPesoVazia = activity.FindViewById<CheckBox> ( Resource.Id.txtConsultaDimensionaisEmbalagemPesoVazia );
      }

      private void BindEmbalagemPesoCheia ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemPesoCheia = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemPesoCheia );
      }

      private void BindEmbalagemVolume ( Activity activity )
      {
        TxtConsultaDimensionaisEmbalagemVolume = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisEmbalagemVolume );
      }
      #endregion

      #region Bind - Linha 7
      private void BindPaleteQuantidadeCaixasCamada ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCaixasCamada );
      }

      private void BindPaleteQuantidadeCamadas ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCamadas = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCamadas );
      }
      #endregion

      #region Bind - Linha 8
      private void BindPaleteQuantidadeCaixasColetivas ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeCaixasColetivas );
      }
      #endregion

      #region Bind - Linha 9
      private void BindPaleteQuantidadeEmlagensVendaVarejo ( Activity activity )
      {
        TxtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaleteQuantidadeEmbalagensVendaVarejo );
      }

      private void BindPaletePeso ( Activity activity )
      {
        TxtConsultaDimensionaisPaletePeso = activity.FindViewById<TextView> ( Resource.Id.txtConsultaDimensionaisPaletePeso );
      }
      #endregion

      public void Clear ( )
      {

        #region Linha 1
        TxtConsultaDimensionaisQuantidadePecasItem.Text = String.Empty;
        TxtConsultaDimensionaisQuantidadeItensCaixa.Text = String.Empty;
        #endregion

        #region Linha 2
        TxtConsultaDimensionaisProdutoComprimento.Text = String.Empty;
        TxtConsultaDimensionaisProdutoLargura.Text = String.Empty;
        #endregion

        #region Linha 3
        TxtConsultaDimensionaisProdutoPeso.Text = String.Empty;
        TxtConsultaDimensionaisProdutoVolume.Text = String.Empty;
        TxtConsultaDimensionaisProdutoVolumeAdicional.Text = String.Empty;
        #endregion

        #region Linha 4
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo.Text = String.Empty;
        #endregion

        #region Linha 5
        TxtConsultaDimensionaisEmbalagemComprimento.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemLargura.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemAltura.Text = String.Empty;
        #endregion

        #region Linha 6
        TxtConsultaDimensionaisEmbalagemPesoVazia.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemPesoCheia.Text = String.Empty;
        TxtConsultaDimensionaisEmbalagemVolume.Text = String.Empty;
        #endregion

        #region Linha 7
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada.Text = String.Empty;
        TxtConsultaDimensionaisPaleteQuantidadeCamadas.Text = String.Empty;
        #endregion

        #region Linha 8
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas.Text = String.Empty;
        #endregion

        #region Linha 9
        TxtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo.Text = String.Empty;
        TxtConsultaDimensionaisPaletePeso.Text = String.Empty;
        #endregion

      }

      public void AtualizaCampos ( Variaveis valor )
      {

        #region Linha 1
        TxtConsultaDimensionaisQuantidadePecasItem.Text = valor.QuantidadePecasItem.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisQuantidadeItensCaixa.Text = valor.QuantidadeItensCaixa.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 2
        TxtConsultaDimensionaisProdutoComprimento.Text = valor.ProdutoComprimento.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisProdutoLargura.Text = valor.ProdutoLargura.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 3
        TxtConsultaDimensionaisProdutoPeso.Text = valor.ProdutoPeso.ToString ( "####0.000" ).Trim ( );
        TxtConsultaDimensionaisProdutoVolume.Text = valor.ProdutoVolume.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisProdutoVolumeAdicional.Text = valor.ProdutoVolumeAdicional.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 4
        TxtConsultaDimensionaisQuantidadeEmbalagensVendaVarejo.Text = valor.QuantidadeEmbalagensVendaVarejo.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 5
        TxtConsultaDimensionaisEmbalagemComprimento.Text = valor.EmbalagemComprimento.ToString ( "#0.00000" ).Trim();
        TxtConsultaDimensionaisEmbalagemLargura.Text = valor.EmbalagemLargura.ToString ( "#0.00000" ).Trim ( );
        TxtConsultaDimensionaisEmbalagemAltura.Text = valor.EmbalagemAltura.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 6
        TxtConsultaDimensionaisEmbalagemPesoVazia.Text = valor.EmbalagemPesoVazia.ToString ( "####0.000" ).Trim();
        TxtConsultaDimensionaisEmbalagemPesoCheia.Text = valor.EmbalagemPesoCheia.ToString ( "####0.000" ).Trim ( );
        TxtConsultaDimensionaisEmbalagemVolume.Text = valor.EmbalagemVolume.ToString ( "#0.00000" ).Trim ( );
        #endregion

        #region Linha 7
        TxtConsultaDimensionaisPaleteQuantidadeCaixasCamada.Text = valor.PaleteQuantidadeCaixasCamada.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisPaleteQuantidadeCamadas.Text = valor.PaleteQuantidadeCamadas.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 8
        TxtConsultaDimensionaisPaleteQuantidadeCaixasColetivas.Text = valor.PaleteQuantidadeCaixasColetivas.ToString ( "###0" ).Trim ( );
        #endregion

        #region Linha 9
        TxtConsultaDimensionaisPaleteQuantidadeEmlagensVendaVarejo.Text = valor.PaleteQuantidadeEmlagensVendaVarejo.ToString ( "###0" ).Trim ( );
        TxtConsultaDimensionaisPaletePeso.Text = valor.PaletePeso.ToString ( "####0.000" ).Trim ( );
        #endregion

      }

    }

    #region Privadas
    private readonly Config         _bcoSql;
    private readonly AcessoSql      _acessoSql;
    private Boolean                 _ok;
    private Tabela                  _consultaDimensionais;
    private List<Coluna>            _colunas;
    private Variaveis               _variaveis;
    private Campos                  _camposTela;
    private Item.Classe               _item;
    #endregion

    #region Publicas
    public Tabela Tabela
    {
      get
      {
        return _consultaDimensionais;
      }
      set
      {
        _consultaDimensionais = value;
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
      get
      {
        return _bcoSql;
      }
    }

    public AcessoSql AcessoSql
    {
      get
      {
        return _acessoSql;
      }
    }

    public Item.Classe Item
    {
      get
      {
        return _item;
      }
      set
      {
        _item = value;
      }
    }

    public Campos CamposTela
    {
      get
      {
        return _camposTela;
      }
      set
      {
        _camposTela = value;
      }
    }
    #endregion

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, Item.Classe item )
    {
      _ok = true;
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _item = item;
      ClasseComum ( activity );
    }

    private void ClasseComum ( Activity activity )
    {
      _ok = false;
      CriaColunas ( );
      _variaveis = new Variaveis ( );
      CamposTela = new Campos ( activity );
      CamposTela.LloConsultaDimensionaisBotoes.Visibility = ViewStates.Invisible;
      CamposTela.Clear ( );
      if ( _item.Ok )
      {
        PopulaRecord ( _item );
      }
    }

    public void Show ( )
    {
      _camposTela.RloConsultaDimensionais.Visibility = ViewStates.Visible;
    }

    public void Hide ( )
    {
      _camposTela.RloConsultaDimensionais.Visibility = ViewStates.Gone;
    }

    private void CriaColunas ( )
    {
      _colunas = new List<Coluna> ( );

      #region Linha 1
      _colunas.Add ( new Coluna ( 3, "QuantidadePecasItem", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 4, "QuantidadeItensCaixa", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 2
      _colunas.Add ( new Coluna ( 7, "ProdutoComprimento", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 8, "ProdutoLargura", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 9, "ProdutoAltura", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 3
      _colunas.Add ( new Coluna ( 13, "ProdutoPeso", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 14, "ProdutoVolume", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 15, "ProdutoVolumeAdicional", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 4
      _colunas.Add ( new Coluna ( 19, "QuantidadeEmbalagemVarejo", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 5
      _colunas.Add ( new Coluna ( 25, "EmbalagemComprimento", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 26, "EmbalagemLargura", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 27, "EmbalagemAltura", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 6
      _colunas.Add ( new Coluna ( 30, "EmbalagemPesoVazia", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 31, "EmbalagemPesoCheia", "", typeof ( Double ), false, false, false ) );
      _colunas.Add ( new Coluna ( 32, "EmbalagemVolume", "", typeof ( Double ), false, false, false ) );
      #endregion

      #region Linha 7
      _colunas.Add ( new Coluna ( 37, "PaleteQuantidadeCaixasCamada", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 38, "PaleteQuantidadeCamadas", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 8
      _colunas.Add ( new Coluna ( 42, "PaleteQuantidadeCaixasColetivas", "", typeof ( Int32 ), false, false, false ) );
      #endregion

      #region Linha 9
      _colunas.Add ( new Coluna ( 46, "PaleteQuantidadeEmlagensVendaVarejo", "", typeof ( Int32 ), false, false, false ) );
      _colunas.Add ( new Coluna ( 47, "PaletePeso", "", typeof ( Double ), false, false, false ) );
      #endregion

    }

    private void PopulaRecord ( Item.Classe item )
    {
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.Query, _acessoSql.OpenQuery, item.Variaveis.CodigoEmpresa, item.Variaveis.CodigoItem );
      var banco = new Msde ( _acessoSql );
      banco.Open ( );
      SqlDataReader reader = banco.DataReader ( query.ToString ( ) );
      while ( reader.Read ( ) )
      {
        _variaveis = new Variaveis ( reader );
        CamposTela.AtualizaCampos ( _variaveis );
        break;
      }
      reader.Close ( );
      reader.Dispose ( );
      banco.Close ( );
    }

  }
}
