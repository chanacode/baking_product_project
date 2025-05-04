using BakingProductProject.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.viewModel
{
    public abstract class BaseDB
    {
        private string connectionString;
        private OleDbConnection connection;
        private OleDbCommand command;
        protected OleDbDataReader reader;
        protected List<BaseEntity> list=new List<BaseEntity>();

        public BaseDB()
        {
            connectionString = @"provider=Microsoft.ACE.OLEDB.12.0;Data source=" + GetCurrentPath() + "Data\\bakingProduct.accdb";
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand();
            command.Connection = connection;
            Select();
        }
        private void Open()
        {
            command.Connection = connection;
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }            

        private void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void Read()
        {
            list.Clear();
            command.CommandText = "select * from " + GetTableName();
            reader = command.ExecuteReader();
             while(reader .Read ())
            {
                list.Add(creatModel());
            }
            if (reader != null)
                reader.Close();
        }

        protected void Select()
        {
            Open();
            Read();
            Close();
        }

        //protected List<BaseEntity> Select()
        //{
        //    List<BaseEntity> list = new List<BaseEntity>();
        //    command.CommandText = "select * from " + GetTableName();
        //    connection.Open();
        //    reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        list.Add(creatModel());
        //    }
        //    return list;

        //}
        public abstract string GetTableName();
        public abstract BaseEntity creatModel();
        public static string GetCurrentPath()//החזר נתיב נוכחי - מחזירה את הנתיב הנוכחי של 
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string[] arr = path.Split('\\');//מחלקת את המשפט הארוך למילים לפי כל פעם שמופיע סלש
            path = "";
            for (int i = 0; i < arr.Length - 2; i++)
            {
                path += arr[i] + "\\";
            }
            return path;

        }
        private bool SaveEntity()
        {
            Open();
            int x = command.ExecuteNonQuery();
            if(x>0)
            {
                Read();
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }
        public virtual bool Add(BaseEntity entity)
        {
            command.CommandText = SQLBuilder.InsertSQL(entity);
            return SaveEntity();
        }
        public bool Update(BaseEntity entity)
        {
            command.CommandText = SQLBuilder.UpdateSQL(entity);
            return SaveEntity();
        }
        public bool Delete(BaseEntity entity)
        {
            command.CommandText = SQLBuilder.DeleteSQL(entity);
            return SaveEntity();
        }
    }
}