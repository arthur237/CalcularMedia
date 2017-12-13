using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Text;
using Android.Views;

namespace App8.Droid
{
    [Activity(Label = "App8", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText nota1;
        EditText nota2;
        EditText nota3;
        EditText nota4;
        Button calcular;
        TextView mediafinal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            calcular = FindViewById<Button>(Resource.Id.button1);
            nota1 = FindViewById<EditText>(Resource.Id.text1);
            nota2 = FindViewById<EditText>(Resource.Id.text2);
            nota3 = FindViewById<EditText>(Resource.Id.text3);
            nota4 = FindViewById<EditText>(Resource.Id.text4);
            mediafinal = FindViewById<TextView>(Resource.Id.textView1);

            calcular.Click += (sender, e) =>
            {
                try
                {
                    if (Convert.ToDouble(nota1.Text) > 10 || Convert.ToDouble(nota2.Text) > 10 || Convert.ToDouble(nota3.Text) > 10 || Convert.ToDouble(nota4.Text) > 10)
                    {
                        mediafinal.Text = "De 10 não passa";
                    }
                    else if (Convert.ToDouble(nota1.Text) < 0 || Convert.ToDouble(nota2.Text) < 0 || Convert.ToDouble(nota3.Text) < 0 || Convert.ToDouble(nota4.Text) < 0)
                    {
                        mediafinal.Text = "Você colocou nota menor que 0";
                    }
                    else
                    {
                        double medias = Math.Round(((Convert.ToDouble(nota1.Text) + Convert.ToDouble(nota2.Text) + Convert.ToDouble(nota3.Text) + Convert.ToDouble(nota4.Text)) / 4), 2);
                        mediafinal.Text = "Média: " + medias.ToString();
                    }
                }
                catch (Exception)
                {
                    mediafinal.Text = "Preencha todos os campos com  as notas";
                }
            };
        }
    }
}

