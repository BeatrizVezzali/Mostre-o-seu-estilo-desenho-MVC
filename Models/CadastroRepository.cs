using MySqlConnector;

namespace PI_MVC.Models
{
    public class CadastroRepository
    {
        private const string DadosConexao = "Server=MYSQL5040.site4now.net;Database=db_a8f98a_mostre;Uid=a8f98a_mostre;Pwd=rootmt01";

         public void Inserir(Cadastro C)
         {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO cadastro (Nome , Email , Senha , Senha2 , Nascimento) VALUES (@Nome , @Email , @Senha , @Senha2 , @Nascimento)";

            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            Comando.Parameters.AddWithValue("@Nome" , C.Nome);

            Comando.Parameters.AddWithValue("@Email" , C.Email);

            Comando.Parameters.AddWithValue("@Senha" , C.Senha);

            Comando.Parameters.AddWithValue("@Senha2" , C.Senha2);

            Comando.Parameters.AddWithValue("@Nascimento" , C.Nascimento);

            Comando.ExecuteNonQuery();

            Conexao.Close();
         }
    }


}  
        
    
