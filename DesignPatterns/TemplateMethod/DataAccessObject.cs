using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// The 'AbstractClass'
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            connectionString =
                "we need a connection string here!";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        //The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
