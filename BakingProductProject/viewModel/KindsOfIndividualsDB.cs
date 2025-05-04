using BakingProductProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.viewModel
{
    public class KindsOfIndividualsDB:BaseDB
    {

        public override BaseEntity creatModel()
        {
            KindsOfIndividuals item = new KindsOfIndividuals();
            item.unitTypeCode = Convert.ToInt32(reader["unitTypeCode"]);
            item.unitTypeName = reader["unitTypeName"].ToString();
            return item;  
        }
        public override string GetTableName()
        {
            return "KindsOfIndividuals";
        }
        public List<KindsOfIndividuals>GetKindsOfIndividuals()
        {
            return list.Cast<KindsOfIndividuals>().ToList();
        }
        //מושלם
        public override bool Add(BaseEntity entity)
        {
            if (entity is KindsOfIndividuals)
            {
                if (list.Count == 0)
                    (entity as KindsOfIndividuals).unitTypeCode = 1;
                else
                    (entity as KindsOfIndividuals).unitTypeCode = GetKindsOfIndividuals().Max(X => X.unitTypeCode) + 1;
                return base.Add(entity);
            }
            return false;
        }
    }
}
