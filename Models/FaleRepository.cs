using MySqlConnector;
namespace PI_MVC.Models
{
    public class FaleRepository
    {
       private const string DadosConexao = "Server=MYSQL5040.site4now.net;Database=db_a8f98a_mostre;Uid=a8f98a_mostre;Pwd=rootmt01";

       public void Inserir(Fale F)
        { 
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO fale_conosco (Nome,Email,Mensagem) VALUES (@Nome , @Email , @Mensagem)";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Nome" , F.Nome);

            Comando.Parameters.AddWithValue("@Email" , F.Email);

            Comando.Parameters.AddWithValue("@Mensagem" , F.Mensagem);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
         
    }
}