using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StackExchange.Redis;

namespace IVRDataService
{
    public class Dao
    {

        private ConnectionMultiplexer m_Redis = null;
        private ConnectionMultiplexer redis
        {
            get
            {
                if (m_Redis == null) m_Redis = ConnectionMultiplexer.Connect("localhost");
                    return m_Redis;
            }
        }
        
        public bool checkUserTel(string tel_no)
        {
            bool response = false;
            IDatabase db = redis.GetDatabase();
            if (db.SetContains("user_tel_key", tel_no))
            {
                 response = true;
            }
            else
            {
                 response = false;
            }
            return response;
        }
    }
}