using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PracticaFormativa2
{
    class SuperHeroe
    {
        string nombre;
        int fuerza;
        int resistencia;
        int superpoderes;

        // GETTERS            
        public string getNombre() 
        { 
            return nombre; 
        }

        public int getFuerza() 
        {
            return fuerza;
        }  

        public int getResistencia()
        { 
            return resistencia;
        }

        public int getSuperpoderes() 
        {
            return superpoderes;
        }

        //SETTERS
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setFuerza(int fuerza)
        {  
            if ((fuerza >= 0) && (fuerza <= 100))
                this.fuerza = fuerza;
            else if(fuerza < 0)
                this.fuerza = 0;
            else if(fuerza > 100)
                    this.fuerza = 100;
        }

        public void setResistancia(int recistancia)
        {
            if ((recistancia >= 0) && (recistancia <= 100))
                this.resistencia = recistancia;
            else if(recistancia < 0) 
                this.resistencia = 0;
            else if(recistancia > 100)
                this.resistencia = 100;
        }

        public void setSuperpoderes(int superpoderes)
        {
            if ((superpoderes >= 0) && (superpoderes <= 100))
                this.superpoderes = superpoderes;
            else if(superpoderes < 0) 
                this.superpoderes = 0;
            else if (superpoderes > 100)
                this.superpoderes = 100;
        }

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            setNombre(nombre);
            setFuerza(fuerza);
            setResistancia(resistencia);
            setSuperpoderes(superpoderes);
        }   

        public string competir(SuperHeroe heroe2) 
        {
            int superHeroe1 = 0;
            int superHeroe2 = 0;

            if (this.fuerza > heroe2.fuerza)
                superHeroe1++;
            else if (this.fuerza < heroe2.fuerza)
                superHeroe2++;

            if (this.resistencia > heroe2.resistencia)
                superHeroe1++;
            else if (this.resistencia < heroe2.resistencia)
                superHeroe2++;

            if (this.superpoderes > heroe2.superpoderes)
                superHeroe1++;
            else if (this.superpoderes < heroe2.superpoderes)
                superHeroe2++;

            if (superHeroe2 > superHeroe1)
                return "DERROTA";
            else if (superHeroe1 > superHeroe2)
                return "TRIUNFO";
            else if (superHeroe1 == superHeroe2)
                return "EMPATE";

            return "";
        }
    }
}
