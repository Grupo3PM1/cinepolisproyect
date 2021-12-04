using System;
using System.Collections.Generic;
using System.Text;

namespace cinepolisproyect.Models
{
    public class ApiCard
    {
        public string trj_ntarjeta { get; set; }
        public string trj_fchvencimiento { get; set; }
        public string trj_cdgseguridad { get; set; }
        public string us_id { get; set; }
    }

    // Clase que contiene los datos HTTP
    public static class UrlApiCd
    {
        public static string ip = "cinepolishn.000webhostapp.com";
        public static string web = "Cinepolis";


        //Apis clase usuarios
        public static string postEndPoint = "InsertTarjeta.php"; //POST

    }
    public static class UrlApiCard
    {
        public static string POSTCardList = string.Format("http://{0}/{1}/{2}", UrlApiCd.ip, UrlApiCd.web, UrlApiCd.postEndPoint);
    }
}
