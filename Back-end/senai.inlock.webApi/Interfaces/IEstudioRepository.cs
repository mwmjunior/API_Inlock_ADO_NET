using senai.inlock.webApi.Domains;


namespace senai.inlock.webApi.Interfaces
{
    public interface IEstudioRepository
    {
        /// <summary>
        /// Iterface responsavel por cadastrar novos estudios 
        /// </summary>
        /// <param name="novoEstudio">Novo objeto que será cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);



        /// <summary>
        /// Iterface responsavel por listar os estudios cadastrados
        /// </summary>
        /// <returns>Lista com objetos cadastrados</returns>
        List<EstudioDomain> ListarTodos();




        /// <summary>
        /// Iterface responsavel para apagar um estudio digitando seu id 
        /// </summary>
        /// <param name="id">Id do objeto que será deletado</param>
        void Deletar(int id);
    }
}
