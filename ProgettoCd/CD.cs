using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCd
{
    public class Cd
    {
        public string titolo;
        public string autore;
        public List <brano> listaBrani new List<brano>();
        private int durataTotale;

        public Cd(string TitoloAutore, string NomeAutore, string brano1, string brano2, string brano3)
        {
            titolo = TitoloAutore;
            autore = NomeAutore;

            listaBrani.Add(brano1);
            listaBrani.Add(brano2);
            listaBrani.Add(brano3);

        }
       
        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }
        public void setAutore(string autore)
        {
            this.autore = autore;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getAutore()
        {
            return autore;
        }
        public int toString()
        {
            foreach (var brano in listaBrani)
            {
                durataTotale = durataTotale + brano.getTitolo() + " ";
            }
            return durataTotale;
        }

        public int Durata()
        {
            foreach(var brano in listaBrani)
            {
                durataTotale = durataTotale + brano.getDurata();
            }
            return durataTotale;
        }


    }
}
