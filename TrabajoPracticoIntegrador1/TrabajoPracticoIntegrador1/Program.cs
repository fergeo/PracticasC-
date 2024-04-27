using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace TrabajoPracticoIntegrador1
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string mail;
        private string periodoPago;
        private DateTime fechaAlta;


        //GETTER Y SETTER NOMBRE
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //GETTER Y SETTER APELLIDO
        public void setApellido(string apellido)
        {
           this.apellido = apellido;
        }
        public string getApellido()
        {
            return this.apellido;
        }

        //GETTER Y STTER DNI
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return this.dni;
        }

        //GETTER Y STTER MAIL
        public void setMail(string mail)
        {
            this.mail = mail;
        }
        public string getMail()
        {
            return this.mail;
        }

        //GETTER Y SETTER PERIODO DE PAGO
        public void setPeriodoPago(string periodoPago)
        {
            this.periodoPago = periodoPago;
        }
        public string getPeriodoPago()
        {
            return this.periodoPago;
        }

                //GETTER Y STTER FECHA ALTA
        public void setFechaAlta(DateTime fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }
        public DateTime getFechaAlta()
        {
            return this.fechaAlta;
        }


    }

    public class Socio : Cliente
    {
        private int nroSocio;

        //GETTER Y STTER NRO. SOCIO
        public void setNroSocio(int nroSocio)
        {
            this.nroSocio = nroSocio;
        }
        public int getNroSocio()
        {
            return this.nroSocio;
        }


        public void registrarSocio()
        {
            //Ingreso de nombre
            Console.WriteLine("Ingresa el Nombre: ");
            string nombre = Console.ReadLine();
            this.setNombre(nombre);

            //Ingreso de apellido
            Console.WriteLine("Ingresa el Apellido: ");
            string apellido = Console.ReadLine();
            this.setApellido(apellido);

            //Ingreso de dni
            Console.WriteLine("Ingresa el D.N.I.: ");
            string ingDni = Console.ReadLine();
            int dni = int.Parse(ingDni);
            this.setDni(dni);

            //Ingreso de mail
            Console.WriteLine("Ingresa el Mail: ");
            string mail = Console.ReadLine();
            this.setMail(mail);

            //Ingreso de periodo de pago
            Console.WriteLine("Ingresa el el perdiodo de pago: ");
            string peridoPago = Console.ReadLine();
            this.setPeriodoPago(peridoPago);

            //Ingreso de fecha de alta
            DateTime fechaAlta = DateTime.Now;
            this.setFechaAlta(fechaAlta);

            //Ingreso de Nro. de Socio
            Random random = new Random();
            int nroSocio = random.Next(5000);
            this.setNroSocio(nroSocio);

        }

        public void imprimirCarnet(Socio socio)
        {
            //Imprime el nombre
            Console.WriteLine("Nombre: " + socio.getNombre());
            //Imprime el apellido
            Console.WriteLine("Apellido: " + socio.getApellido());
            //Imprime el dni
            Console.WriteLine("D.N.I.: " + socio.getDni());
            //Imprime el mail
            Console.WriteLine("Mail: " + socio.getMail());
            //Imprime el perdiodo de Pago
            Console.WriteLine("Periodo de Pago: " + socio.getPeriodoPago());
            //Imprime el perdiodo la fecha de alta
            Console.WriteLine("Fecha de Alta: " + socio.getFechaAlta());
            //Imprime el nro. de socio
            Console.WriteLine("Nro. de Socio: " + socio.getNroSocio());

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Socio socio = new Socio();
            
            Console.WriteLine("Bienvenido a mi CLub");

            socio.registrarSocio();
            socio.imprimirCarnet(socio);
        }
    }
}
