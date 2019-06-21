using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;
        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            this._jogador1 = jogador1;

            this._jogador2 = jogador2;

        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Passa());
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write("\n");
            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Passa());
            System.Console.Write(_jogador2.Chuta());
        }
    }
}