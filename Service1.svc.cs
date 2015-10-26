using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IVRDataService
{
    public class Service1 : IService1
    {
        private Dao m_Dao = null;
        private Dao dao
        {
            get
            {
                if (m_Dao == null) m_Dao = new Dao();
                return m_Dao;
            }
        }

        public string GetUserLogData(string tel_no)
        {
            string response = String.Empty;
            if (string.IsNullOrEmpty(tel_no))
            {
                response = "BAD_REQUEST";
            }
            else
            {
                if (dao.checkUserTel(tel_no)) response = "EXIST"; else response = "NOT_FOUND";

            }
            return response;
        }
    }
}
