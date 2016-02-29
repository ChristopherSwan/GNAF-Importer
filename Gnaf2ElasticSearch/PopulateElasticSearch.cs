using System;
using System.Collections.Generic;
using System.Text;
using Nest;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;

namespace marval.dao
{
    public class PopulateElasticSearch
    {

        private ElasticClient _client = null;
        private bool _connected = false;
        private string indexName = "gnafFeb2016";
        private string node = "localhost";
        private int port = 9200;

        public void Delete()
        {
            var nodeURI = new Uri("http://" + node + ":" + port.ToString());

            var indexSettings = new IndexSettings();
            
            var connectionSettings = new ConnectionSettings(
                nodeURI
                //defaultIndex: indexName
            );

            _client = new ElasticClient(connectionSettings);
            IIndicesResponse response = _client.DeleteIndex(indexName);
            if (response.Acknowledged)
            {
                Debug.WriteLine("Delete Index succeeded" );
            }
            else
            {
                Debug.WriteLine("Delete Index failed: " + response.ServerError.Error);
            }

        }

        public void Populate(BackgroundWorker worker, int index)
        {
            PopulateWorkerProgressEventArgs args = new PopulateWorkerProgressEventArgs();
            int max = 50000;
            args.count = 0;
            args.progress = "Loading gnaf data from file..." + index + " to " + (index + (max - 1));
            worker.ReportProgress(args.count, args);
            
            //List<request> requests;
            //marval.dao.RequestDAO gdao = new marval.dao.RequestDAO();
            //requests = gdao.Get(worker, index, max);
            //StringBuilder sb = new StringBuilder();

            //args.total = requests.Count;
            //args.progress = "Starting to index " + args.total + " marval requests...";
            //worker.ReportProgress(args.count,args);

            //Connect();
            //foreach (request addr in requests)
            //{
            //    args.count += 1;
            //    //sb.AppendLine(addr.address);
            //    PopulateRow(addr);
            //    if ( args.count % 5000 == 0)
            //    {
            //        args.progress = "Record " + args.count + ": " + addr.requestId + " " + addr.contactName;
            //        worker.ReportProgress(args.count, args);
            //    }
            //}

            args.progress = "Finished indexing gnaf...";
            worker.ReportProgress(args.count, args);
        }

        private void Connect()
        {
            var nodeURI = new Uri("http://" + node + ":" + port.ToString());
      
            var indexSettings = new IndexSettings();
            indexSettings.NumberOfReplicas = 1;
            indexSettings.NumberOfShards = 2;
            //indexSettings.Settings.Add("merge.policy.merge_factor", "10");
            //indexSettings.Settings.Add("search.slowlog.threshold.fetch.warn", "1s");
            //indexSettings.Settings.Add("index.store.type", "memory");

            var connectionSettings = new ConnectionSettings(nodeURI);//, defaultIndex: "gnafFeb2016");

            _client = new ElasticClient(connectionSettings);

            var response = _client.CreateIndex(indexName , c => c.Index(indexName));
            if (response.Acknowledged)
            {
                _connected = true;
            }
            else
            {
                Debug.WriteLine("Client CreateIndex failed: " + response.ServerError.Error);
            }
        }

        //private void PopulateRow(request addr)
        //{
        //    if (_connected)
        //    {
        //        if (!String.IsNullOrEmpty(addr.notes)){
        //            //var document = new HtmlDocument();
        //            //document.LoadHtml(addr.notes);
        //            addr.notes = addr.notes.Replace(System.Environment.NewLine, "<br />");
        //            //addr.notes = document.DocumentNode.InnerText;
        //            //addr.notes = addr.notes.Replace("&nbsp;", " ");
        //            //addr.notes = addr.notes.Replace("<div>", "");
        //            //addr.notes = addr.notes.Replace("</div>", "");
        //            //addr.notes = addr.notes.Replace("<span>", "");
        //            //addr.notes = addr.notes.Replace("</span>", "");
        //            //addr.notes = addr.notes.Replace("<br>", "");
        //        }
             
        //        var index = _client.Index(addr);
        //        Debug.WriteLine(index.ServerError);
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Client not connected");
        //    }
        //}

       	

    }
}
