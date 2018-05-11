using System;
using Lor0138.Classes.Resources;

namespace Lor0138.Classes.Comum
{
  public class AcessoSql
  {
    
    private readonly String _openQuery;
    private readonly String _server;
    private readonly String _userName;
    private readonly String _password;

    public enum AcessoTipo
    {
      Desenvolvimento
    , Producao
    }

    public string OpenQuery
    {
      get { return _openQuery; }
    }

    public string Server
    {
      get { return _server; }
    }

    public string UserName
    {
      get { return _userName; }
    }

    public string Password
    {
      get { return _password; }
    }

    public AcessoSql(AcessoTipo acessoTipo)
    {
      switch (acessoTipo)
      {
        case AcessoTipo.Desenvolvimento:
          _openQuery = BancoSQLDesenv.OpenQuery;
          _server = BancoSQLDesenv.Server;
          _userName = BancoSQLDesenv.Username;
          _password = BancoSQLDesenv.Password;
          break;
        case AcessoTipo.Producao:
          _openQuery = BancoSQLProd.OpenQuery;
          _server = BancoSQLProd.Server;
          _userName = BancoSQLProd.Username;
          _password = BancoSQLProd.Password;
          break;
      }
    }
  }
}