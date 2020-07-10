using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode.Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton<T> where T:new()
    {
        private static T instance;
        private static object _lock = new object();

        public static T Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            
        }
        ~Singleton()
        {
            instance = default(T);
            _lock = null;
        }
    }
}
