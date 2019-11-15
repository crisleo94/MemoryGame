using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MemoryGame
{
    class BD_Connection
    {
        string message = "";
        string strCon = ConfigurationManager.ConnectionStrings["strDesm"].ToString();
        SqlConnection Connection;
        SqlCommand Command;

        public string Message { get => message; set => message = value; }
        public string StrCon { get => strCon; set => strCon = value; }
        public SqlConnection Connection1 { get => Connection; set => Connection = value; }
        public SqlCommand Command1 { get => Command; set => Command = value; }

        public void Connect()
        {
            try
            {
                Connection1 = new SqlConnection(StrCon);
                Connection1.Open();
            }
            catch (Exception ex)
            {
                Message = "Se ha presentado un error conectando con la base de datos " + ex;
            }
        }

        public int RegisterPlayer(Player player)
        {            
            Connect();
            Command1 = new SqlCommand("sp_IPlayer", Connection1);
            Command1.CommandType = CommandType.StoredProcedure;
            Command1.Parameters.AddWithValue("@player_name", player.Name);
            Command1.Parameters.AddWithValue("@nickname", player.Nickname);
            Command1.Parameters.AddWithValue("@pass", player.Pass);

            int res = Command1.ExecuteNonQuery();
            Connection1.Close();
            return res;
        }

       /* public int GetScoreWins(Player player)
        {
            Connect();
            Command1 = new SqlCommand("select score, wins from Player where player_nickname='"+player.Nickname+"'", Connection1);
            SqlDataReader r = Command1.ExecuteReader();

            while (r.Read())
            {
                int scor = r.GetInt32(4);
                int wins = r.GetInt32(5);
            }

            int res = Command1.ExecuteNonQuery();
            Connection1.Close();
            return res;
        }*/

        public Player RecuperarUser(string nombre, string pass)
        {
            Connect();
            Command1 = new SqlCommand("select * from Player where player_name='"+nombre+"' and pass='"+pass+"'", Connection);
            SqlDataReader r = Command1.ExecuteReader();
            Player player = null;
            while (r.Read())
            {
                player = new Player();
                player.Name = r.GetString(0);
                player.Nickname = r.GetString(1);
                player.Pass = r.GetString(2);
                player.Score = r.GetInt32(3);
                player.Wins = r.GetInt32(4);
            }
            Connection1.Close();
            return player;
        }

        public List<Player> RecuperarUsers()
        {
            Connect();
            Command1 = new SqlCommand("select * from Player order by score desc", Connection);
            SqlDataReader r = Command1.ExecuteReader();
            Player player = null;
            List<Player> listPs = new List<Player>();
            while (r.Read())
            {
                player = new Player();
                player.Name = r.GetString(0);
                player.Nickname = r.GetString(1);
                player.Pass = r.GetString(2);
                player.Score = r.GetInt32(3);
                player.Wins = r.GetInt32(4);
                listPs.Add(player);
            }
            Connection1.Close();
            return listPs;
        }

        public int RegisterScoreWins(Player player)
        {
            Connect();
            Command1 = new SqlCommand("update Player set score="+player.Score+", wins="+player.Wins+
                " where nickname='"+player.Nickname+"'", Connection1);
            Command1.Parameters.AddWithValue("score", player.Score);
            Command1.Parameters.AddWithValue("wins", player.Wins);

            int res = Command1.ExecuteNonQuery();
            Connection1.Close();
            return res;
        }
    }
}
