using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        /*
      create database HotelManagementSystem
      use HotelManagementSystem
      create table roomTable
      (
      id int identity(0,1) primary key,
      房间号 int,
      房间类型 nvarchar(10),
      所在楼层 nvarchar(10),
      价格 decimal,    
      房间状态 nvarchar(10),
      备注 nvarchar(50)     
        )
        create table register
        (
        id int identity(0,1) primary key,
        房间号 int,
        房间类型 nvarchar(10),
        入住人 nvarchar(10),
        身份证号 varchar(30),
        联系方式 varchar(30),
        交易码 varchar(30),
        实收 decimal,
        房间状态 nvarchar(10),
        入住时间 datetime,
        退房时间 datetime,
        备注 nvarchar(50)      
        )
        create table account
        (
        id int identity(0,1) primary key,
        username varchar(30),
        pwd varchar(30),
        权限 nvarchar(10),
        备注 nvarchar(50)      
        )
        create table money
        (
        id int identity(0,1) primary key,
        收入金额 decimal,
        收入时间 datetime,
        房间号 int,
        入住人 nvarchar(10),
        身份证号 varchar(30),
        联系方式 varchar(30),
        备注 nvarchar(50)     
        )
         create table registerHistory
        (
        id int identity(0,1) primary key,
        房间号 int,
        房间类型 nvarchar(10),
        入住人 nvarchar(10),
        身份证号 varchar(30),
        联系方式 varchar(30),
        交易码 varchar(30),
        实收 decimal,
        入住时间 datetime,
        退房时间 datetime,
        备注 nvarchar(50)      
        )
         */
    }
}
