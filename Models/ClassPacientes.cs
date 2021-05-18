using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTasyFake.Models
{
    public class ClassPacientes
    {
        public int Idpaciente { get; set; }
        public int iNumeroProntuario { get; set; }
        public string sNomePaciente { get; set; }
        public DateTime dtNascPaciente { get; set; }
        public string sCPFPaciente { get; set; }
        public string sEmailPaciente { get; set; }
        public DateTime dtCadastro { get; set; }
        public string sCodUltimoAtendimento { get; set; }
        public DateTime dtUltimoAtendimento { get; set; }
        public int idEstabelecimento { get; set; }


    }
}