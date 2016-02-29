using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marval.dao;
using System.ComponentModel;

namespace Marval2ElasticSearch
{
    class Program
    {
        public static BackgroundWorker marvalIndexingWorker;

        static void Main(string[] args)
        {
            marvalIndexingWorker = new BackgroundWorker();
            marvalIndexingWorker.WorkerReportsProgress = true;
            marvalIndexingWorker.ProgressChanged += new ProgressChangedEventHandler(marvalindexingWorker_DoWork_ProgressChanged);

            PopulateElasticSearch populate = new PopulateElasticSearch();
            populate.Delete();
            Console.WriteLine("populate.Delete() completed");
            populate.Populate(marvalIndexingWorker, 0);
            populate.Populate(marvalIndexingWorker, 50000);
            populate.Populate(marvalIndexingWorker, 100000);
            populate.Populate(marvalIndexingWorker, 150000);
            populate.Populate(marvalIndexingWorker, 200000);
            populate.Populate(marvalIndexingWorker, 250000);
            populate.Populate(marvalIndexingWorker, 300000);
            populate.Populate(marvalIndexingWorker, 350000);
            populate.Populate(marvalIndexingWorker, 400000);
            populate.Populate(marvalIndexingWorker, 450000);
            populate.Populate(marvalIndexingWorker, 500000);

            Console.WriteLine("Completed.");
           
        }

        private static void marvalindexingWorker_DoWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            marval.dao.PopulateWorkerProgressEventArgs args = (marval.dao.PopulateWorkerProgressEventArgs)e.UserState;
            Console.WriteLine(args.progress);
        }

    }
}

