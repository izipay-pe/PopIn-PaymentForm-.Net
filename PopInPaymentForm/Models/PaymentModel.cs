using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopInPaymentForm.Models
{
    public class PaymentModel
    {
        //Usuario
        private const string _usuario = "XXXXXXXXXXXXXXXXXXXXXXXXX";
        //Clave API REST de TEST o PRODUCCIÓN
        private const string _contraseña = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        //Clave JavaScript de TEST o PRODUCCIÓN
        private const string _clave_JS = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        //Clave HMAC-SHA-256 de TEST o PRODUCCIÓN
        private const string _clave_SHA256 = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        //URL de servidor de IZIPAY
        private const string _servidor_API = "https://api.micuentaweb.pe/";

        public string KEY_USER => _usuario;
        public string KEY_PASSWORD => _contraseña;
        public string KEY_JS => _clave_JS;
        public string KEY_SHA256 => _clave_SHA256;
        public string URL_BASE => _servidor_API;
    }
}