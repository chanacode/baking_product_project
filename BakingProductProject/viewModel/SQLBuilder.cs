using BakingProductProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.viewModel
{

    public static class SQLBuilder
    {
        public static string InsertSQL(BaseEntity entity)
        {
            Type type = entity.GetType();
            string command = "InsertInto" + entity.GetTableName() + " (";
            string values = " values (";
            foreach (var item in type.GetProperties())
            {
                if(item.CanWrite)
                { 
                object value = item.GetValue(entity);
                command += item.Name + " , ";
                value += PutValue(value) + " , ";
                }
            }
            command = command.Substring(0, command.Length - 2) + " )";
            values = values.Substring(0, command.Length - 2) + " )";
            return command + values;
        }
        public static string UpdateSQL(BaseEntity entity)
        {
            Type type = entity.GetType();
            string command = "Update" + entity.GetTableName() + " set ";
            foreach (var item in type.GetProperties())
            {
                if(item.CanWrite)
                { 
                object value = item.GetValue(entity);
                command += item.Name + " , " + PutValue(value) + " , ";
                }
            }
            string where = "";
            foreach (var item in entity.GetKeyFields())
            {

                if (where != "")
                    where += "End";
                object value = entity.GetType().GetProperty(item).GetValue(entity);
                where += item + " = " + PutValue(value);
            }
            command = command.Substring(0, command.Length - 2) + "where" + where;
            return command;
        }

        public static string DeleteSQL(BaseEntity entity)
        {
            Type type = entity.GetType();
            string command = "Delete from" + entity.GetTableName() + "where";
            string where = "";
            foreach (var item in entity.GetKeyFields())
            {

                if (where != "")
                    where += "End";
                var value = entity.GetType().GetProperty(item).GetValue(entity);
                where += item + "=" + PutValue(value);

            }
            command += where;
            return command;
        }

        private static string PutValue(object value)
        {
            if (value == null)
                return " '' ";
            if (value is BaseEntity)
            {
                BaseEntity entity1 = value as BaseEntity;
                string k = entity1.GetKeyFields()[0];
                value = value.GetType().GetProperty(k).GetValue(value);
            }
            if (value is string || value is DateTime)
            {
                return "'" + value + "'";
                
            }
            return value.ToString();
        }
    }
}
