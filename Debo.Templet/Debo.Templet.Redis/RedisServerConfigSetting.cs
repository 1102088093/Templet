using System.Configuration;


namespace Debo.Templet.Redis
{
    public class RedisServerConfigSetting
    {
        public RedisServerConfigSetting()
        {
            _redisServerAddress = ConfigurationManager.AppSettings["RedisServerAddress"];
            _redisMaxWritePool = int.Parse(ConfigurationManager.AppSettings["RedisMaxWritePool"]);
            _redisMaxReadPool = int.Parse(ConfigurationManager.AppSettings["RedisMaxReadPool"]);
            _timeOut = int.Parse(ConfigurationManager.AppSettings["TimeOut"]);
        }
        private string _redisServerAddress;
        private int _redisMaxWritePool;
        private int _redisMaxReadPool;
        private int _timeOut;
        public string RedisServerAddress { get { return this._redisServerAddress; } }
        public int RedisMaxWritePool { get { return this._redisMaxWritePool; } }
        public int RedisMaxReadPool { get { return this._redisMaxReadPool; } }
        public int TimeOut { get { return this._timeOut; } }
    }
}
