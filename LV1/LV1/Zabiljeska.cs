using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1 {
    class Zabiljeska {
        private String tekst;
        private String autor;
        private int vaznost;

        public string getTekst() { return this.tekst; }
        public string getAutor() { return this.autor; }
        public int getVaznost() {
            if (vaznost > 0 & vaznost < 5)
                return this.vaznost;
            throw new ArgumentOutOfRangeException("Razina vaznosti u rasponu 1 - 5!");
        }
        public void setTekst(string tekst) { this.tekst = tekst; }
        private void setAutor(string autor) { this.autor = autor; }
        public void setVaznost(int vaznost) { this.vaznost = vaznost; }


        public Zabiljeska() {
            this.tekst = "Korisnik je unio prvu zabiljesku";
            this.autor = "Domagoj";
            this.vaznost = 3;
        }
        public Zabiljeska(string tekst, string autor, int vaznost) {
            this.tekst = tekst;
            this.autor = autor;
            this.vaznost = vaznost;
        }
        public string Tekst {
            get { return this.tekst; }
            set { this.tekst = value; }
        }
        private string Autor {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public int Vaznost {
            get {
                if (vaznost > 0 & vaznost < 5)
                    return this.vaznost;
                throw new ArgumentOutOfRangeException("Razina vaznosti u rasponu 1 - 5!");
            }
            set {
                this.vaznost = value;
            }
        }
        public override string ToString() {
            return this.Tekst + ", " + this.Autor + ", " + Vaznost;
        }
    }
}
