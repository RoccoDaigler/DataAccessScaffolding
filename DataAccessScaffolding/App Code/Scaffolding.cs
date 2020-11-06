using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessScaffolding
{
    internal class Scaffolding
    {
        private string nl = System.Environment.NewLine;

        public string WriteSQLSP(string table_name)
        {
            Report Report = new Report();
            DataSet ds;
            DataSet ds2;

            string output = "";
            string column_name;
            string column_data_type = "";
            string table_id;

            Report.OpenConnections();
            ds = Report.retrieve_db_table_column_summary(table_name);
            Report.CloseConnections();

            table_id = (string)ds.Tables[0].Rows[0]["COLUMN_NAME"];

            output = output + nl;
            output = output + @"--" + table_name.ToUpper() + nl;
            output = output + nl;

            output = output + nl;
            output = output + @"--" + table_name.ToUpper() + " DROP PROCEDURES" + nl;

            //check if procs need to be dropped
            Report.OpenConnections();
            ds2 = Report.retrieve_stored_procedures_for_table(table_name);
            Report.CloseConnections();

            foreach (DataRow proc in ds2.Tables[0].Rows)
            {
                if (proc["name"].ToString() == (table_name.ToUpper() + "_SP_SAVE"))
                {
                    output = output + @"DROP PROCEDURE " + table_name.ToUpper() + "_SP_SAVE" + nl;
                }
                else if (proc["name"].ToString() == (table_name.ToUpper() + "_SP_DELETE"))
                {
                    output = output + @"DROP PROCEDURE " + table_name.ToUpper() + "_SP_DELETE" + nl;
                }
                else if (proc["name"].ToString() == (table_name.ToUpper() + "_SP_RETRIEVE"))
                {
                    output = output + @"DROP PROCEDURE " + table_name.ToUpper() + "_SP_RETRIEVE" + nl;
                }
            }

            output = output + nl;
            output = output + nl;

            //SAVE INSERT/UPDATE
            output = output + @"SET ANSI_NULLS ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"SET QUOTED_IDENTIFIER ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"-- Author:		Rocco" + nl;
            output = output + @"-- Create date: " + DateTime.Now.ToShortDateString() + " " + nl;
            output = output + @"-- Description:	SAVE INSERT/UPDATE" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"CREATE PROCEDURE " + table_name.ToUpper() + "_SP_SAVE" + nl;

            //parameters
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                column_name = (string)row["COLUMN_NAME"].ToString().ToUpper();

                if ((short)row["DATA_TYPE"] == 2)
                {
                    //numeric
                    column_data_type = "NUMERIC(" + (int)row["PRECISION"] + "," + (short)row["SCALE"] + ")";
                }
                else if ((short)row["DATA_TYPE"] == 12)
                {
                    //varchar
                    column_data_type = "VARCHAR(" + (int)row["PRECISION"] + ")";
                }
                else if ((short)row["DATA_TYPE"] == -1)
                {
                    //varchar(max)
                    column_data_type = "VARCHAR(MAX)";
                }
                else if ((short)row["DATA_TYPE"] == 11)
                {
                    //datetime
                    column_data_type = "DATETIME";
                }
                else if ((short)row["DATA_TYPE"] == -6)
                {
                    //tinyint
                    column_data_type = "TINYINT";
                }

                if (column_name != "")
                {
                    output = output + @"	@" + column_name + " AS " + column_data_type + ", " + nl;
                }
            }

            //remove last comma
            output = output.Substring(0, output.Length - 4);
            output = output + nl;

            output = output + @"AS" + nl;
            output = output + @"BEGIN" + nl;
            output = output + @"	SET NOCOUNT ON;" + nl;
            output = output + @"" + nl;

            //update
            output = output + @"	if @" + table_id.ToUpper() + " > 0" + nl;
            output = output + @"	begin" + nl;
            output = output + @"		update " + table_name + " set" + nl;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                column_name = (string)row["COLUMN_NAME"].ToString();

                if (column_name.ToUpper() != table_id.ToUpper())
                {
                    output = output + @"		" + column_name + " = @" + column_name.ToUpper() + ", " + nl;
                }
            }

            //remove last comma
            output = output.Substring(0, output.Length - 4);
            output = output + nl;

            output = output + @"		where " + table_id + " = @" + table_id.ToUpper() + "" + nl;
            output = output + @"	end" + nl;

            //insert
            output = output + @"	else" + nl;
            output = output + @"	begin" + nl;
            output = output + @"		insert into " + table_name + " " + nl;
            output = output + @"		(" + nl;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                column_name = (string)row["COLUMN_NAME"].ToString();
                if (column_name.ToUpper() != table_id.ToUpper())
                {
                    output = output + @"		" + column_name + ", " + nl;
                }
            }

            //remove last comma
            output = output.Substring(0, output.Length - 4);
            output = output + nl;

            output = output + @"		)" + nl;
            output = output + @"		VALUES" + nl;
            output = output + @"		(" + nl;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                column_name = (string)row["COLUMN_NAME"].ToString();
                if (column_name.ToUpper() != table_id.ToUpper())
                {
                    output = output + @"		@" + column_name.ToUpper() + ", " + nl;
                }
            }

            //remove last comma
            output = output.Substring(0, output.Length - 4);
            output = output + nl;

            output = output + @"		)" + nl;
            output = output + @"" + nl;
            output = output + @"		set @" + table_id.ToUpper() + " = @@IDENTITY" + nl;
            output = output + @"	end " + nl;
            output = output + @"" + nl;
            output = output + @"	select * " + nl;
            output = output + @"    from " + table_name + " " + nl;
            output = output + @"    where " + table_id + " = @" + table_id.ToUpper() + " " + nl;
            output = output + @"" + nl;
            output = output + @"END" + nl;
            output = output + @"GO" + nl;

            output = output + nl;
            output = output + nl;
            output = output + nl;

            //DELETE

            output = output + @"SET ANSI_NULLS ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"SET QUOTED_IDENTIFIER ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"-- Author:		Rocco" + nl;
            output = output + @"-- Create date: " + DateTime.Now.ToShortDateString() + " " + nl;
            output = output + @"-- Description:	DELETE" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"CREATE PROCEDURE " + table_name.ToUpper() + "_SP_DELETE" + nl;
            output = output + @"	@" + table_id.ToUpper() + " AS NUMERIC(18,0)" + nl;
            output = output + @"AS" + nl;
            output = output + @"BEGIN" + nl;
            output = output + @"	SET NOCOUNT ON;" + nl;
            output = output + @"" + nl;
            output = output + @"	delete from " + table_name + "" + nl;
            output = output + @"	where " + table_id + " = @" + table_id.ToUpper() + "" + nl;
            output = output + @"" + nl;
            output = output + @"END" + nl;
            output = output + @"GO" + nl;

            output = output + nl;
            output = output + nl;
            output = output + nl;

            //RETRIEVE

            output = output + @"SET ANSI_NULLS ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"SET QUOTED_IDENTIFIER ON" + nl;
            output = output + @"GO" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"-- Author:		Rocco" + nl;
            output = output + @"-- Create date: " + DateTime.Now.ToShortDateString() + " " + nl;
            output = output + @"-- Description:	RETRIEVE" + nl;
            output = output + @"-- =============================================" + nl;
            output = output + @"CREATE PROCEDURE " + table_name.ToUpper() + "_SP_RETRIEVE" + nl;
            output = output + @"	@" + table_id.ToUpper() + " AS NUMERIC(18,0)" + nl;
            output = output + @"AS" + nl;
            output = output + @"BEGIN" + nl;
            output = output + @"	SET NOCOUNT ON;" + nl;
            output = output + @"" + nl;
            output = output + @"	if @" + table_id.ToUpper() + " > 0" + nl;
            output = output + @"	begin" + nl;
            output = output + @"		select *" + nl;
            output = output + @"		from " + table_name + "" + nl;
            output = output + @"		where " + table_id + " = @" + table_id.ToUpper() + "" + nl;
            output = output + @"	end" + nl;
            output = output + @"	else" + nl;
            output = output + @"	begin" + nl;
            output = output + @"		select *" + nl;
            output = output + @"		from " + table_name + "" + nl;
            output = output + @"	end" + nl;

            output = output + @"END" + nl;
            output = output + @"GO" + nl;

            return output;
        }

        public void buildModel(string table_name, string name_space)
        {
            Report Report = new Report();
            DataSet ds;
            string output = "";
            string column_name;
            string column_data_type = "";
            string file;
            string table_id;

            Report.OpenConnections();
            ds = Report.retrieve_db_table_column_summary(table_name);
            Report.CloseConnections();

            table_id = (string)ds.Tables[0].Rows[0]["COLUMN_NAME"];

            output = output + @"using System;" + nl;
            output = output + @"using System.ComponentModel.DataAnnotations;" + nl;
            output = output + @"using System.ComponentModel.DataAnnotations.Schema;" + nl;
            output = output + @"" + nl;
            output = output + @"namespace " + name_space + ".Models" + nl;
            output = output + @"{" + nl;
            output = output + @"    public class " + CommonLib.GetDisplayName(table_name) + "" + nl;
            output = output + @"    {" + nl;

            //properties
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                column_name = (string)row["COLUMN_NAME"].ToString();

                if ((short)row["DATA_TYPE"] == 2)
                {
                    //numeric
                    column_data_type = "decimal";
                }
                else if ((short)row["DATA_TYPE"] == 12)
                {
                    //varchar
                    column_data_type = "string";
                }
                else if ((short)row["DATA_TYPE"] == -1)
                {
                    //varchar(max)
                    column_data_type = "string";
                }
                else if ((short)row["DATA_TYPE"] == 11)
                {
                    //datetime
                    column_data_type = "DateTime";
                }
                else if ((short)row["DATA_TYPE"] == -6)
                {
                    //tinyint
                    column_data_type = "byte";
                }

                if (column_name == table_id)
                {
                    output = output + @"        [Key]" + nl;
                    output = output + @"        [Display(Name = """ + CommonLib.GetDisplayNameWithSpaces(column_name).Trim() + @""")]" + nl;
                    output = output + @"        public " + column_data_type + " " + column_name + " { get; set; }" + nl;
                    output = output + nl;
                }
                else if (column_name != "")
                {
                    output = output + @"        [Display(Name = """ + CommonLib.GetDisplayNameWithSpaces(column_name).Trim() + @""")]" + nl;
                    output = output + @"        public " + column_data_type + " " + column_name + " { get; set; }" + nl;
                    output = output + nl;
                }
            }

            output = output + @"    }" + nl;
            output = output + @"}" + nl;

            file = @"C:\Scaffolding\Models\" + CommonLib.GetDisplayName(table_name) + ".cs";

            if (System.IO.File.Exists(file))
            {
                System.IO.File.Delete(file);
            }

            System.IO.File.WriteAllText(file, output);
        }

        public void buildDataAccess(string table_name, string name_space)
        {
            Report Report = new Report();
            DataSet ds;
            DataSet ds2;
            DataSet ds3;
            DataRow row;

            string output = "";
            string table_id;
            string column_name;
            string file;
            string proc_name;
            string proc_param_name;
            string proc_param_type;

            Report.OpenConnections();
            ds = Report.retrieve_db_table_column_summary(table_name);
            Report.CloseConnections();

            table_id = (string)ds.Tables[0].Rows[0]["COLUMN_NAME"];

            output = output + @"using System;" + nl;
            output = output + @"using System.Collections.Generic;" + nl;
            output = output + @"using System.Data;" + nl;
            output = output + @"using System.Data.SqlClient;" + nl;
            output = output + @"using System.Linq;" + nl;
            output = output + @"using Dapper;" + nl;
            output = output + @"using " + name_space + ".Models;" + nl;
            output = output + @"using static " + name_space + ".Tools;" + nl;
            output = output + @"" + nl;
            output = output + @"namespace " + name_space + ".Data_Access" + nl;
            output = output + @"{" + nl;
            output = output + @"    public class " + CommonLib.GetDisplayName(table_name) + "DataAccess" + nl;
            output = output + @"    {" + nl;
            output = output + @"        public " + CommonLib.GetDisplayName(table_name) + " Save(" + CommonLib.GetDisplayName(table_name) + " " + table_name + ")" + nl;
            output = output + @"        {" + nl;
            output = output + @"            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))" + nl;
            output = output + @"            {" + nl;
            output = output + @"                string sql = $""EXEC " + table_name.ToUpper() + @"_SP_SAVE "" +" + nl;

            //insert params
            //foreach (DataRow row in ds.Tables[0].Rows)
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                row = ds.Tables[0].Rows[i];
                column_name = (string)row["COLUMN_NAME"].ToString();
                if (i != ds.Tables[0].Rows.Count - 1)
                {
                    if ((short)row["DATA_TYPE"] == 2)
                    {
                        //numeric
                        output = output + @"                    $""{" + table_name + "." + column_name + @"}, "" +" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == 12)
                    {
                        //varchar
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}', "" +" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == -1)
                    {
                        //varchar(max)
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}', "" +" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == 11)
                    {
                        //datetime
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}', "" +" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == -6)
                    {
                        //tinyint
                        output = output + @"                    $""{" + table_name + "." + column_name + @"}, "" +" + nl;
                    }
                }
                else
                {
                    //last row
                    if ((short)row["DATA_TYPE"] == 2)
                    {
                        //numeric
                        output = output + @"                    $""{" + table_name + "." + column_name + @"} "";" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == 12)
                    {
                        //varchar
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}' "";" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == -1)
                    {
                        //varchar(max)
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}' "";" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == 11)
                    {
                        //datetime
                        output = output + @"                    $""'{" + table_name + "." + column_name + @"}' "";" + nl;
                    }
                    else if ((short)row["DATA_TYPE"] == -6)
                    {
                        //tinyint
                        output = output + @"                    $""{" + table_name + "." + column_name + @"} "";" + nl;
                    }
                }
            }

            output = output + @"" + nl;
            output = output + @"                return cnn.Query<" + CommonLib.GetDisplayName(table_name) + ">(sql).FirstOrDefault(); ;" + nl;
            output = output + @"            }" + nl;
            output = output + @"        }" + nl;
            output = output + @"        public List<" + CommonLib.GetDisplayName(table_name) + "> Retrieve()" + nl;
            output = output + @"        {" + nl;
            output = output + @"            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))" + nl;
            output = output + @"            {" + nl;
            output = output + @"                string sql = $""EXEC " + table_name.ToUpper() + @"_SP_RETRIEVE 0 ""; " + nl;
            output = output + @"" + nl;
            output = output + @"                return cnn.Query<" + CommonLib.GetDisplayName(table_name) + ">(sql).ToList();" + nl;
            output = output + @"            }" + nl;
            output = output + @"        }" + nl;
            output = output + @"        public " + CommonLib.GetDisplayName(table_name) + " Retrieve(string " + table_id + ")" + nl;
            output = output + @"        {" + nl;
            output = output + @"            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))" + nl;
            output = output + @"            {" + nl;
            output = output + @"                string sql = $""EXEC " + table_name.ToUpper() + @"_SP_RETRIEVE "" +" + nl;
            output = output + @"                    $""{" + table_id + @"} "";" + nl;
            output = output + @"" + nl;
            output = output + @"                return cnn.Query<" + CommonLib.GetDisplayName(table_name) + ">(sql).FirstOrDefault();" + nl;
            output = output + @"            }" + nl;
            output = output + @"        }" + nl;
            output = output + @"        public void Delete(string " + table_id + ")" + nl;
            output = output + @"        {" + nl;
            output = output + @"            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))" + nl;
            output = output + @"            {" + nl;
            output = output + @"                string sql = $""EXEC " + table_name.ToUpper() + @"_SP_DELETE "" +" + nl;
            output = output + @"                    $""{" + table_id + @"} "";" + nl;
            output = output + @"" + nl;
            output = output + @"                cnn.Execute(sql);" + nl;
            output = output + @"            }" + nl;
            output = output + @"        }" + nl;

            //get the rest of the stored procedures
            Report.OpenConnections();
            ds2 = Report.retrieve_stored_procedures_for_table(table_name);
            Report.CloseConnections();

            foreach (DataRow proc in ds2.Tables[0].Rows)
            {
                proc_name = proc["name"].ToString();

                //get the params for procedure
                Report.OpenConnections();
                ds3 = Report.retrieve_params_for_sp(proc_name);
                Report.CloseConnections();

                output = output + @"        public " + CommonLib.GetDisplayName(table_name) + " " + CommonLib.GetDisplayName(proc_name) + "(";
                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    proc_param_name = ds.Tables[0].Rows[i]["name"].ToString().Replace("@", "").ToLower();
                    proc_param_type = ds.Tables[0].Rows[i]["type"].ToString();

                    if (i != ds.Tables[0].Rows.Count - 1)
                    {
                        output = output + "string " + proc_param_name + ", ";
                    }
                    else
                    {
                        output = output + "string " + proc_param_name + "";
                    }
                }

                output = output + ")" + nl;
                output = output + @"        {" + nl;
                output = output + @"            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))" + nl;
                output = output + @"            {" + nl;
                output = output + @"                string sql = $""exec " + proc_name + @" "" +" + nl;

                //insert params
                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    proc_param_name = ds.Tables[0].Rows[i]["name"].ToString().Replace("@", "").ToLower();
                    proc_param_type = ds.Tables[0].Rows[i]["type"].ToString();

                    if (i != ds.Tables[0].Rows.Count - 1)
                    {
                        if (proc_param_type == "numeric" || proc_param_type == "tinyint")
                        {
                            output = output + @"                    $""{" + proc_param_name + @"}, "" +" + nl;
                        }
                        else
                        {
                            output = output + @"                    $""'{" + proc_param_name + @"}', "" +" + nl;
                        }
                    }
                    else
                    {
                        if (proc_param_type == "numeric" || proc_param_type == "tinyint")
                        {
                            output = output + @"                    $""{" + proc_param_name + @"} "";" + nl;
                        }
                        else
                        {
                            output = output + @"                    $""'{" + proc_param_name + @"}' "";" + nl;
                        }
                    }
                }

                output = output + @"" + nl;
                output = output + @"                return cnn.Query<" + CommonLib.GetDisplayName(table_name) + ">(sql).FirstOrDefault(); ;" + nl;
                output = output + @"            }" + nl;
                output = output + @"        }" + nl;
            }

            output = output + @"    }" + nl;
            output = output + @"}" + nl;

            file = @"C:\Scaffolding\Data Access\" + CommonLib.GetDisplayName(table_name) + "DataAccess.cs";

            if (System.IO.File.Exists(file))
            {
                System.IO.File.Delete(file);
            }

            System.IO.File.WriteAllText(file, output);
        }
    }
}