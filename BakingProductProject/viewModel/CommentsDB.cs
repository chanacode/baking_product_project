using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class CommentsDB : BaseDB
    {

        public override BaseEntity creatModel()
        {
            Comments item = new Comments();
            int recipeCode = Convert.ToInt32(reader["recipeCode"]);
            item.recipeCode = MyDB.recipeDB.GetRecipes().FirstOrDefault(x => x.recipeCode == recipeCode);
            item.serialCode = Convert.ToInt32(reader["serialCode"]);

            item.comment = reader["comment"].ToString();


            return item;
        }
        public override string GetTableName()
        {
            return "Comments";
        }
        public List<Comments> GetCommentsDB()
        {
            return list.Cast<Comments>().ToList();
        }
        //מושלם
       
    }
    }

