using System;
using Android.App;
using Android.Content;

namespace Lor0138.Classes.Comum
{
  internal class Tools
  {

    public void MessageBox(Activity context, string pMsg)
    {
      var builder = new AlertDialog.Builder(context);
      builder.SetMessage(pMsg);
      builder.SetTitle("");
      builder.SetNegativeButton("OK", delegate { });
      builder.Show();
    }

    public void QuestionMessageBox ( Context context, Func<Boolean> methodBotaoPositivo, string titulo, string mensagem = "", string msgBotaoPositivo = "Confirmar", string msgBotaoNegative = "Cancelar" )
    {
      AlertDialog.Builder dialog = new AlertDialog.Builder ( context );
      AlertDialog alertDialog = dialog.Create ( );
      alertDialog.SetMessage ( mensagem );
      alertDialog.SetCancelable ( false );
      alertDialog.SetTitle ( titulo );
      alertDialog.SetButton (
        msgBotaoPositivo
      , delegate
        {
          methodBotaoPositivo ( );
        }
      );
      alertDialog.SetButton3
      (
        msgBotaoNegative
      , delegate
        {
          ;
        }
      );
      alertDialog.Show ( );
    }

  }
}