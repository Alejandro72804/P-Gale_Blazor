namespace Juego.Modelos
{
    public class ModeloCuadrado{

        private bool isShow;
        public int Id { get; set; }
        public string Style { get; set; }
        public bool IsShow {
            get => isShow;
            set{
                isShow = value;
                if (isShow){
                    Style = "mole";
                    Console.WriteLine($"Se cambió a mole {Id}");
                }else { Style = ""; }
            }
        } 

    }
}
