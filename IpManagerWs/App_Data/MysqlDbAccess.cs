﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

namespace IpManagerWs
{
    public class MysqlDbAccess : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static MySqlConnection _conn = null;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object _lock = new object();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string ConnectionString
        {
            get
            {
                lock (_lock)
                {
                    return @"server=localhost;userid=hikmetyarbasi;password=Computer67.;database=hukukportal";
                }
            }
        }


        public MysqlDbAccess()
        {
        }

        private MySqlConnection CheckConnection()
        {
            lock (_lock)
            {
                if (_conn!=null)
                {
                    _conn.Open();
                    return _conn;
               
                }

                _conn = new MySqlConnection(ConnectionString);
                _conn.Open();
                return _conn;
            }
        }

        private void CloseConnection(MySqlConnection conn)
        {
            conn.Close();
        }

        private MySqlCommand CreateCommand(MySqlConnection conn)
        {
            return conn.CreateCommand();
        }

        public List<T> QueryList<T>(string procName, List<SqlParameter> parameter) where T : new()
        {
            lock (_lock)
            {
                using (var conn = CheckConnection())
                {

                    var comm = CreateCommand(conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = string.Format(procName);
                    comm.CommandTimeout = 1000000;
                    foreach (var o in parameter)
                    {
                        comm.Parameters.Add(o);
                    }
                    var list = MapData<T>(comm.ExecuteReader());
                    CloseConnection(conn);
                    return list;
                }
            }
        }
        public T QueryItem<T>(string procName, List<MySqlParameter> parameter) where T : new()
        {
            lock (_lock)
            {
                var item = new T();
                using (var conn = CheckConnection())
                {
                    var comm = CreateCommand(conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = string.Format(procName);
                    foreach (var o in parameter)
                    {
                        comm.Parameters.Add(o.ParameterName, o.Value);
                    }
                    var list = MapData<T>(comm.ExecuteReader());
                    if (list.Count > 0) item = list[0];
                    CloseConnection(conn);
                    return item;
                }
            }
        }
        public void ExecuteNonQuery(string procName, List<MySqlParameter> parameters)
        {
            lock (_lock)
            {
                using (var conn = CheckConnection())
                {
                    var comm = CreateCommand(conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = string.Format(procName);
                    foreach (var o in parameters)
                    {
                        comm.Parameters.Add(o.ParameterName, o.Value);
                    }
                    comm.ExecuteNonQuery();
                    CloseConnection(conn);
                }
            }
        }
        public object ExecuteScalar(string procName, List<MySqlParameter> parameters)
        {
            lock (_lock)
            {
                using (var conn = CheckConnection())
                {
                    var comm = CreateCommand(conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = string.Format(procName);
                    var parm = new MySqlParameter()
                    {
                        Direction = ParameterDirection.ReturnValue,
                        MySqlDbType = MySqlDbType.Int32
                    };
                    comm.Parameters.Add(parm);
                    foreach (var o in parameters)
                    {
                        comm.Parameters.Add(o.ParameterName, o.Value);
                    }
                    comm.ExecuteScalar();
                    CloseConnection(conn);
                    return comm.Parameters[0].Value.ToString();
                }
            }
        }

        private static List<T> MapData<T>(IDataReader dr) where T : new()
        {
            var pocoType = typeof(T);
            var entitys = new List<T>();
            var hashtable = new Hashtable();
            var properties = pocoType.GetProperties();
            foreach (var info in properties)
            {
                hashtable[info.Name.ToUpper()] = info;
            }
            while (dr.Read())
            {
                var newObject = new T();
                for (var index = 0; index < dr.FieldCount; index++)
                {
                    var name = dr.GetName(index).ToUpper();
                    var info = (PropertyInfo)hashtable[name];
                    if ((info == null) || !info.CanWrite) continue;
                    var value = dr.GetValue(index);
                    if (dr.GetValue(index) == null || dr.GetValue(index) == DBNull.Value) continue;
                    if (dr.GetValue(index) is long)
                    {
                        value = Convert.ToInt32(dr.GetValue(index));
                    }
                    info.SetValue(newObject, value, null);
                }
                entitys.Add(newObject);
            }
            dr.Close();
            return entitys;
        }
        public DataSet DataSetQuery(string procName, List<MySqlParameter> parameters)
        {
            DataSet ds = new DataSet();
            lock (_lock)
            {
                using (_conn = CheckConnection())
                {
                    var comm = CreateCommand(_conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = string.Format(procName);


                    foreach (var o in parameters)
                    {
                        comm.Parameters.Add(o);
                    }
                    comm.Transaction = _conn.BeginTransaction();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = comm;

                    da.Fill(ds);
                    comm.Transaction.Commit();
                    CloseConnection(_conn);
                }
            }
            return ds;
        }
        public void Dispose()
        {
            _conn.Close();
        }
    }

  
}
