using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Content;
using Android.Content.PM;

namespace Lor0138.Classes.Tools
{
  public class  AlteraVersao
  {
    readonly Comum _comum = new Comum ( );

    public void AtualizaVersao ( Activity context, ref Boolean pAtualizaVersao )
    {
      //Verifica se Existe Nova Versão da Aplicação
      const string file = "/mnt/sdcard/.sistemas/apks/com.lorenzetti.mixprodutos-Signed.apk";
      const string processo = "com.lorenzetti.mixprodutos";
      PackageManager pm = context.PackageManager;
      ApplicationInfo info = pm.GetApplicationInfo ( processo, 0 );
      String arq = info.SourceDir;
      long installed = new Java.IO.File ( arq ).LastModified ( );
      var dtprocesso = ConvertIntDateTime ( installed );
      if ( File.Exists ( file ) )
      {
        var apkInstalar = new Java.IO.File ( file );
        var apki = apkInstalar.GetHashCode ( );
        var myIntent = new Intent ( Intent.ActionView );
        myIntent.SetDataAndType ( Android.Net.Uri.FromFile ( apkInstalar ), "application/vnd.android.package-archive" );
        long apkdate = new Java.IO.File ( file ).LastModified ( );
        var dtapk = ConvertIntDateTime ( apkdate );
        if ( dtapk > dtprocesso )
        {
          pAtualizaVersao = true;
          context.StartActivity ( myIntent );
          context.Finish ( );
        }
      }
      //EOF
    }

    public static DateTime ConvertIntDateTime ( double d )
    {
      DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime ( new DateTime ( 1970, 1, 1 ) );
      DateTime time = startTime.AddMilliseconds ( d );
      return time;
    }


    public void TrocaVersao ( Activity context, string pProcesso, ref Boolean pAtualizaVersao )
    {
      //Verifica se Existe Nova Versão da Aplicação            
      string file = "/mnt/sdcard/.sistemas/apks/com.lorenzetti.mixprodutos-Signed.apk";
      const string fileMd5 = "/mnt/sdcard/.sistemas/apks/com.lorenzetti.mixprodutos-Signed.md5";
      string processo = "com.lorenzetti.mixprodutos";
      if ( !System.IO.File.Exists ( file ) )
      {
        return;
      }
      if ( pProcesso != "" )
      {
        file = "/mnt/sdcard/.sistemas/apks/" + pProcesso.ToString ( ).Trim ( ) + "-Signed.apk";
        processo = pProcesso;
      }
      string md5Numero = "";
      var md5 = CalculateChecksum ( file );
      if ( System.IO.File.Exists ( fileMd5 ) )
      {
        md5Numero = GetIniProperty ( fileMd5, "MD5" );
      }
      else
      {
        md5Numero = md5;
      }
      PackageManager pm;
      pm = context.PackageManager;
      ApplicationInfo info = pm.GetApplicationInfo ( processo, 0 );
      String arq = info.SourceDir;
      long installed = new Java.IO.File ( arq ).LastModified ( );
      var dtprocesso = ConvertIntDateTime ( installed );
      if ( System.IO.File.Exists ( file ) )
      {
        Android.Net.Uri packageUri = Android.Net.Uri.Parse ( processo );
        Java.IO.File apkInstalar = new Java.IO.File ( file );
        var apki = apkInstalar.GetHashCode ( );
        Intent myIntent = new Intent ( Android.Content.Intent.ActionView, packageUri );
        myIntent.SetDataAndType ( Android.Net.Uri.FromFile ( apkInstalar ), "application/vnd.android.package-archive" );
        long apkdate = new Java.IO.File ( file ).LastModified ( );
        var dtapk = ConvertIntDateTime ( apkdate );
        var tamanhoapkInstalado = new Java.IO.File ( arq ).Length ( );
        var tamanhoapk = new Java.IO.File ( file ).Length ( );
        tamanhoapk = ( tamanhoapk / 1024 );
        tamanhoapkInstalado = ( tamanhoapkInstalado / 1024 );
        if ( dtapk > dtprocesso && md5.ToString ( ).Trim ( ) == md5Numero.ToString ( ).Trim ( ) )
        {
          pAtualizaVersao = true;
          context.StartActivity ( myIntent );
          context.Finish ( );
          ;
        }
        if ( md5.ToString ( ).Trim ( ) != md5Numero.ToString ( ).Trim ( ) )
        {
          _comum.MessageBox ( context, "Atenção. Comunique o erro de instalação ao depto de TI. \n\nSetor de Suporte.\n\nRamal 7332.\n\nProcesso " + processo.ToString ( ) );
        }
      }
      //EOF
    }


    public string GetIniProperty ( string iniFileName, string searchKey )
    {
      string keyValue = null;
      var keyList = new List<string> ( );
      using ( var sr = new StreamReader ( iniFileName ) )
      {
        string inp;
        while ( ( inp = sr.ReadLine ( ) ) != null )
        {
          string[] parts = inp.Split ( new char [ ] { ',', '=' } );
          if ( ( parts.Length == 2 ) && ( parts [ 0 ] == searchKey ) )
          {
            keyValue = parts [ 1 ];
          }
        }
      }
      return keyValue;
    }

    private static string CalculateChecksum ( string file )
    {
      System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create ( );
      using ( FileStream stream = File.OpenRead ( file ) )
      {
        byte[] checksum = md5.ComputeHash ( stream );
        string sum = BitConverter.ToString ( checksum );
        return sum.Substring ( 0, sum.Length - 2 ).Replace ( "-", string.Empty ).ToLower ( );
      }
    }
  }
}