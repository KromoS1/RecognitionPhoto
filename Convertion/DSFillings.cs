using System;
using System.Data;
using Data;


namespace Convertion
{
    public class DSFillings
    {
        private DataSet dataSet = new DataSet("DataFilings");
        private DataTable dataTable = new DataTable("Fillings");

        public void CreateTableFillings()
        {
            dataSet.Tables.Add(dataTable);

            DataColumn idColumn = new DataColumn("Id");
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;

            DataColumn numberFilling = new DataColumn("Number Fillings", Type.GetType("System.String"));
            numberFilling.AllowDBNull = false;

            DataColumn installationDate = new DataColumn("Installation Date", Type.GetType("System.DateTime"));
            installationDate.AllowDBNull = false;

            DataColumn contract = new DataColumn("Contract", Type.GetType("System.String"));
            contract.AllowDBNull = false;

            DataColumn businessTrip = new DataColumn("Business Trip");
            businessTrip.AllowDBNull = false;

            DataColumn typeFillings = new DataColumn("Type Fillings", Type.GetType("System.String"));
            businessTrip.AllowDBNull = false;

            DataColumn instalationLocation = new DataColumn("Instalation Location", Type.GetType("System.String"));
            instalationLocation.AllowDBNull = false;

            dataTable.Columns.Add(idColumn);
            dataTable.Columns.Add(numberFilling);
            dataTable.Columns.Add(installationDate);
            dataTable.Columns.Add(contract);
            dataTable.Columns.Add(businessTrip);
            dataTable.Columns.Add(typeFillings);
            dataTable.Columns.Add(instalationLocation);

            dataTable.PrimaryKey = new DataColumn[] {dataTable.Columns["Id"]};

            DataRow row = dataTable.NewRow();
            DateTime time = new DateTime(2020, 10, 28);
            
            row.ItemArray = new object[] {1,1253675, time, "930/70",
                160, "П", "KK"};

            dataTable.Rows.Add(row);


        }

        

    }
}
