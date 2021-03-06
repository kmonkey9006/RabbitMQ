﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ
{
    public class RabbitProducerConfig
    {
        public string UserName { get; set; } //连接帐号
        public string Password { get; set; } //连接密码
        public string VirtualHost { get; set; }      //虚拟主机名   
        public string ServerAddress { get; set; }      //服务器地址 
        public string Exchange { get; set; }      //交换机名称 
        public string ExchangeType { get; set; }      //交换类型   
        public string RoutingKey { get; set; }      //路由关键字 
        public RabbitProducerConfig(string exchange, string exchangetype, string routingkey)
        {
            ServerAddress = ConfigurationManager.AppSettings["serveraddress"];
            VirtualHost = ConfigurationManager.AppSettings["virtualhost"];
            UserName = ConfigurationManager.AppSettings["username"];
            Password = ConfigurationManager.AppSettings["password"];
            Exchange = exchange;


            RoutingKey = routingkey;

            ExchangeType = exchangetype;

        }
        public RabbitProducerConfig()
        {

        }
        public override string ToString()
        {
            return "UserName:" + UserName + ",Password:" + Password + ",VirtualHost:" + VirtualHost + ",ServerAddress:" + ServerAddress + ",Exchange:" + Exchange + ",ExchangeType:" + ExchangeType + ",RoutingKey:" + RoutingKey;
        }
    }
}
