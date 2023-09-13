using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains 
{ 

    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = " O campo do nome é obrigatório! ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo da descrição é obrigatório! ")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo da data do lançamento é obrigatório! ")]
        public DateTime DataLancamento { get; set; }


        [Required(ErrorMessage = "O campo do valor é obrigatório! ")]
        public float Valor { get; set; }

        //referência - Estudio
        public EstudioDomain? Estudio { get; set; }


    }
}
