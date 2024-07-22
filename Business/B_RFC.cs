using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Business
{
    public class B_RFC
    {
        public void Create(E_RFC user)
        {
            D_RFC userCreator = new D_RFC();

            string rfc = GenerateRFC(user);

        }

        public string GenerateRFC(E_RFC user)
        {
            string paternalSurname = user.PaternalSurname;
            string maternalSurname = user.MaternalSurname;
            string names = user.Name;
            string birthDate = user.BirthDate.ToString("yy-MM-dd");

            //TRATAR LOS DATOS PARA GENERAR EL RFC
            // Un metodo para sacar cada parte del RFC
            string firstPosition = pSurnameLetters(paternalSurname); //Hacer todos esos metodos
            string secondPosition = mSurnameLetters(maternalSurname);
            string thirdPosition = nameLetters(names); //Si son dos nombres, partir la cadena en subcadenas, split por espacios
            int fourthPosition = birthdateNumbers(birthDate);

            string rfc = $"{firstPosition}{secondPosition}{thirdPosition}{Convert.ToString(fourthPosition)}";

            // Luego evaluar el RFC entero con otro metodo

            string cleanRfc = rfcCleaner(rfc);
        }
    }
}
