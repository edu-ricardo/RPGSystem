﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.DAO {    
    public class DBAcces {
        string StrCon = ConfigurationManager.ConnectionStrings["RPGSystem"].ConnectionString;
        
        public int ExecQueryReturning(string Query, List<string> ParamsName, List<object> Parameters) {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = StrCon;
            Conexao.Open();

            SqlCommand Command = new SqlCommand();
            Command.Connection = Conexao;
            Command.CommandText = Query + ";SELECT SCOPE_IDENTITY();";

            // Adiciona parametros
            for (int i = 0; i < Parameters.Count; i++) {
                Command.Parameters.AddWithValue(ParamsName[i], Parameters[i]);
            }
            int mod = Command.ExecuteNonQuery();
            return mod;
        }

        public SqlCommand ExecQuery(string Query) {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = StrCon;
            Conexao.Open();
            

            SqlCommand Command = new SqlCommand();
            Command.Connection = Conexao;
            Command.CommandText = Query;
            Command.ExecuteNonQuery();

            return Command;
        }

        /*
            Executa uma query com parametros
        */
        public SqlCommand ExecQuery(string Query, List<string> ParamsName, List<object> Parameters) {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = StrCon;
            Conexao.Open();

            SqlCommand Command = new SqlCommand();
            Command.Connection = Conexao;
            Command.CommandText = Query;

            // Adiciona parametros
            for (int i = 0; i < Parameters.Count; i++) {
                Command.Parameters.AddWithValue(ParamsName[i],Parameters[i]);
            }
            Command.ExecuteNonQuery();
            return Command;
        }

        public SqlDataReader Query(string Query) {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = StrCon;
            Conexao.Open();

            SqlCommand Command = new SqlCommand();
            Command.Connection = Conexao;
            Command.CommandText = Query;            
            SqlDataReader DataReader = Command.ExecuteReader();
            return DataReader;
        }

        /*
            Executa uma query com parametros
        */
        public SqlDataReader Query(string Query, List<string> ParamsName, List<object> Parameters) {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = StrCon;
            Conexao.Open();

            SqlCommand Command = new SqlCommand();
            Command.Connection = Conexao;
            Command.CommandText = Query;

            // Adiciona parametros
            for (int i = 0; i < Parameters.Count; i++) {
                Command.Parameters.AddWithValue(ParamsName[i],Parameters[i]);
            }
            SqlDataReader DataReader = Command.ExecuteReader();
            return DataReader;
        }
    }
}
