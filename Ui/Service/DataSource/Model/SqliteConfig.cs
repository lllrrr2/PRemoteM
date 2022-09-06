﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1RM.Model.DAO;
using Newtonsoft.Json;

namespace _1RM.Service.DataSource.Model
{
    public class SqliteConfig : DataSourceConfigBase
    {
        private string _path = "";
        public string Path
        {
            get => _path;
            set => SetAndNotifyIfChanged(ref _path, value);
        }

        public SqliteConfig(string name) : base(name)
        {
        }

        public override string GetConnectionString()
        {
            return DbExtensions.GetSqliteConnectionString(Path);
        }

        [JsonIgnore]
        public override DatabaseType DatabaseType => DatabaseType.Sqlite;
        [JsonIgnore]
        public override string Description => Path;
    }
}
