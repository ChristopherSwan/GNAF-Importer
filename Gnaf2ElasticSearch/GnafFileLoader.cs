using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gnaf2ElasticSearch
{
    public class GnafFileLoader
    {

        public void LoadFiles()
        {

            string path = @"\\Nas1\local\FEB16_GNAF\G-NAF\G-NAF FEBRUARY 2016\Standard\";

            List<AddressAlias> AddressAliases = new List<AddressAlias>();
            foreach (string file in Directory.EnumerateFiles( path, "*.psv", SearchOption.AllDirectories))
            {
                if (file.Contains("_ADDRESS_ALIAS_psv"))
                    AddressAliases.AddRange(from row in File.ReadLines(file).Skip(1).AsEnumerable()
                                            let column = row.Split('|')
                                            select new AddressAlias
                                            {
                                                address_alias_pid = column[0],
                                                date_created = DateTime.Parse(column[1]),
                                                date_retired = string.IsNullOrEmpty(column[2]) ? (DateTime?)null : DateTime.Parse(column[2]),
                                                principal_pid = column[3],
                                                alias_pid = column[4],
                                                alias_type_code = column[5],
                                                alias_comment = column[6],
                                            });
            }


            //var AddressAliases = from row in File.ReadLines(@"ACT_ADDRESS_ALIAS_psv.psv").Skip(1).AsEnumerable()
            //                    let column = row.Split('|')
            //                    select new AddressAlias
            //                    {
            //                        address_alias_pid = column[0],
            //                        date_created = DateTime.Parse(column[1]),
            //                        date_retired = string.IsNullOrEmpty(column[2]) ? (DateTime?)null : DateTime.Parse(column[2]),
            //                        principal_pid = column[3],
            //                        alias_pid = column[4],
            //                        alias_type_code = column[5],
            //                        alias_comment = column[6],
            //                    };

            foreach(var row in AddressAliases)
            {
                System.Diagnostics.Debug.WriteLine("address_alias_pid: " + row.address_alias_pid);
            }


        }

    }
}
