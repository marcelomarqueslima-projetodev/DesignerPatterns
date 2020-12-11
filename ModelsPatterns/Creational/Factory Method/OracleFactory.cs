﻿namespace ModelsPatterns.Creational.Factory_Method
{
    public class OracleFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}
