using Juego.Modelos;
using System.Runtime.CompilerServices;

namespace Juego.Pages
{
    public partial class Inicio
    {
        private int pts = 0;
        private int segRes = 30;
        int posicion = 0;
        private string msj = "";
        bool activo = true;
        bool toca = false;

        public List<ModeloCuadrado> Cuadrado { get; set; } = new List<ModeloCuadrado>();

        public Inicio()
        {
            for (int i = 0; i < 9; i++)
            {
                Cuadrado.Add(new ModeloCuadrado
                {
                    Id = i
                });
            }
        }
        private void Click(ModeloCuadrado s)
        {

            if (segRes != 0)
            {
                if (!toca)
                {
                    if (s.Id == posicion)
                    {
                        pts += 1;
                        toca = true;
                    }
                }
            }
        }

        private void Muestra()
        {
            foreach (var item in Cuadrado)
            {
                item.IsShow = false;
            }
            var Aleatorio = new Random().Next(0, 9);
            Cuadrado[Aleatorio].IsShow = true;
            Console.WriteLine(Aleatorio);
            posicion = Aleatorio;
            StateHasChanged();
        }

        private async Task Jugar()
        {
            while (activo)
            {
                segRes--;
                if (segRes == 0)
                {
                    msj = "EL JUEGO TERMINÓ";
                    activo = false;
                }
                /*  else if (segRes < 10 && segRes > 0)
                  {
                      Muestra();
                  }
                  else if (segRes > 10 && segRes < 30)
                  {
                      Muestra();
                  }
                  else
                  {
                      Muestra();
                  }*/
                Muestra();
                await Task.Delay(1000);
                toca = false;
            }
        }
        protected override async void OnInitialized()
        {
            await Jugar();
        }
    }
}
