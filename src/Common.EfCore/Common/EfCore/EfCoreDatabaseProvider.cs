using System;
using System.Collections.Generic;
using System.Text;

namespace Common.EfCore
{
    public enum EfCoreDatabaseProvider
    {
        SqlServer,
        MySql,
        Oracle,
        PostgreSql,
        Sqlite,
        InMemory,
        Cosmos,
        Firebird
    }
}
