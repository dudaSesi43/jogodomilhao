namespace jogodomilhao
{
    public class Questao
    {
        public string pergunta;
        public string Resposta01;
        public string Resposta02;
        public string Resposta03;
        public string Resposta04;
        public string Resposta05;
        public int RespostaCorreta;
        public int Nivelresposta;
        Label Labelpergunta;
        Button Button1;
        Button Button2;
        Button Button3;
        Button Button4;
        Button Button5;


        public void ConfiguraEstruturaDesenho(Label labelpergunta, Button buttonresposta01, Button buttonresposta02, Button buttonresposta03, Button buttonresposta04, Button buttonresposta05)
        {
            this.Labelpergunta = labelpergunta;
            this.Button1 = buttonresposta01;
            this.Button2 = buttonresposta02;
            this.Button3 = buttonresposta03;
            this.Button4 = buttonresposta04;
            this.Button5 = buttonresposta05;
        }
        public void Desenhar()
        {
            Labelpergunta.Text = pergunta;
            Button1.Text = Resposta01;
            Button2.Text = Resposta02;
            Button3.Text = Resposta03;
            Button4.Text = Resposta04;
            Button5.Text = Resposta05;
        }

        private Button QualBTN(int RR)
        {
            if (RR==1)
            return Button1;
            else if (RR==2)
            return Button2;
            else if (RR==3)
            return Button3;
            else if (RR==4)
            return Button4;
            else if (RR==5)
            return Button5;
            else 
            return null;
        }
        public bool VerificaResposta(int RR)
        {
           if (RespostaCorreta==RR)
            {
                var BTN= QualBTN(RR);
                BTN.BackgroundColor=Colors.Green;
                return true;

            }
            else
            {
                var BTNCorreto = QualBTN(RespostaCorreta);
                var BTNIncorreto=QualBTN(RR);
                BTNCorreto.BackgroundColor=Colors.Blue;
                BTNIncorreto.BackgroundColor=Colors.Red;
                return false;
            }
        }
            
        
          
        public Questao()
    {
    
    }
        public Questao(Label labelpergunta, Button buttonresposta01, Button buttonresposta02, Button buttonresposta03, Button buttonresposta04, Button buttonresposta05)
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta01;
            Button2 = buttonresposta02;
            Button3 = buttonresposta03;
            Button4 = buttonresposta04;
            Button5 = buttonresposta05;
        }




    }
}