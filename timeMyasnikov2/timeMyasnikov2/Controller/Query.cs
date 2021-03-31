using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace timeMyasnikov2.Controller
{
    class Query
    {
        OleDbConnection connection;
        OleDbConnection command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Query(string Conn);
        {
        connection = new OleDbConnection(Conn);
        bufferTable = new DataTable();

        }
    public Datatable UpdatePerson()
    {
        Connection.Open();
        dataAdapter = new OleDbDataAdapter("SELECT * FROM Person",connection);
        bufferTable.Clear();
        dateAdapter.Fill(bufferTable
    }
            

    }
}
