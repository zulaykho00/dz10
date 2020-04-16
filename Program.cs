using System;

namespace ddzz10
{
     class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
   interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable
    {
        public void Play() {
            Console.WriteLine("Play");
        }
        public void Pause() {
            Console.WriteLine("Pause");
        }
        public void Stop() {
            Console.WriteLine("Stop");
        }
        public void Record() {
            Console.WriteLine("Record");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE#2");
            string pro="pro";
            string exp="exp";
            string c,d;
            Console.WriteLine("ключ:");
            Console.Write("pro:");
            c=Console.ReadLine();
            Console.Write("exp:");
            d=Console.ReadLine();
            if (c==pro)
            {
              Key(2);  
            }
            else
            {
            if(c!=pro && d!=exp)
            {
                Key(1); 
            }
            }
             if(d==exp)
            {
                Key(3); 
            }

            
            Console.WriteLine("ZADANIE#3");
            Player1();
        }

        static public void Key(int input) 
        {
            //int input = Convert.ToInt32(Console.ReadLine());
            DocumentWorker documentWorker;
            switch (input)
            {
                case 1:
                documentWorker = new DocumentWorker();
                break;

                case 2:
                documentWorker = new ProDocumentWorker();
                break;

                case 3:
                documentWorker = new ExpertDocumentWorker();
                break;

                default:
                return;
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
   
        static public void Player1() {
            Player player = new Player();
            player.Play();
            player.Stop();
            player.Pause();
            player.Record();
        }
    }

}
 