using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCd
{
    internal class brano
    {
        public string titolo;
        public string autore;
        public int durata;
        public brano(string titolo, string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getAutore()
        {
            return autore;
        }
        public double getDurata()
        {
            return durata;
        }
        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }
        public void setAutore(string autore)
        {
            this.autore = autore;
        }
        public void setDurata(int durata)
        {
            this.durata = durata;
        }
        public string toString()
        {
            return ("Il brano ha il titolo: " + this.titolo+"\n L'autore è: "+ this.autore +"\n Dura: "+ this.durata);
        }
        public bool shortSong(int durataInput)
        {
            if(durataInput < this.durata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
