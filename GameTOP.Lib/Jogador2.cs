using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Marado estas pateando \n";
        }

        public string Corre()
        {
            return "Marado estas corendo \n";
        }

        public string Passa()
        {
            return "Marado estas passeando \n";
        }
    }
}