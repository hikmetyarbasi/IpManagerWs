using IpManagerWs.HukukWs;
using IpManagerWs.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IpManagerWs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class IpManager : IIpManager
    {
        MysqlDbAccess _dbAccess = new MysqlDbAccess();
        HukukWs.HsClientClient hsClient = new HukukWs.HsClientClient();

        public int GetSumOfTwoInts(int Operand1, int Operand2)
        {
            return Operand1 + Operand2;
        }
        public IpModel GetIpContract(int userId, string password, string sirketkodu)
        {
            var ipmodel = new IpModel();
            try
            {
                ipmodel = _dbAccess.QueryItem<IpModel>("PROC_GETIP", new List<MySqlParameter> { new MySqlParameter("P_SIRKETKODU", sirketkodu) });
                ipmodel.SirketKodu = sirketkodu;
                ipmodel.Operation = "GetIpContract";
                var response =hsClient.AuthenticateUser(userId, password);
                ipmodel.Message = response.Messagek__BackingField;

                if ((int)response.Statuk__BackingField == (int)Model.Statu.fail)
                {
                    ipmodel.Statu = Model.Statu.fail;
                }
                else
                {
                    ipmodel.Statu = Model.Statu.success;
                }
            }
            catch (Exception ex)
            {
                ipmodel.Statu = Model.Statu.fail;
                ipmodel.Message = ex.Message;
            }
            return ipmodel;
        }

    }
}
