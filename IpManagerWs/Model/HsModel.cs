using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IpManagerWs.Model
{
    public interface IList { }
    public class Calismalar : IList
    {
        public int ID { get; set; }
        public string Tarih { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }
        public int OnayDurumuID { get; set; }
        public int KullaniciID { get; set; }
        public int ProjeID { get; set; }
        public string Aciklama { get; set; }
        public decimal FaturalananSaat { get; set; }
        public decimal FaturalanmayanSaat { get; set; }
        public decimal SilenenSaat { get; set; }
    }
    [Serializable]
    public class IpModel
    {
        public string Ip { get; set; }
        public string DbName { get; set; }
        public string SirketKodu { get; set; }
        [DataMember]
        public Statu Statu { get; set; }
        [DataMember]
        public string Operation { get; set; }
        [DataMember]
        public string Message { get; set; }
    }

    [Serializable]
    public class HsResponse<T>
    {
        [DataMember]
        public Statu Statu { get; set; }
        [DataMember]
        public string Operation { get; set; }
        [DataMember]
        public string Message { get; set; }
        public List<T> genericList { get; set; }
    }
    public enum Statu
    {
        success = 0,
        fail = 1
    }
}