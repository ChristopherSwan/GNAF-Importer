using System;
using System.ComponentModel;

namespace Gnaf2ElasticSearch
{
    class Program
    {
        //public static BackgroundWorker indexingWorker;

        static void Main(string[] args)
        {
            var fileLoader = new GnafFileLoader();

            fileLoader.LoadFiles();


            //indexingWorker = new BackgroundWorker();
            //indexingWorker.WorkerReportsProgress = true;
            //indexingWorker.ProgressChanged += new ProgressChangedEventHandler(indexingWorker_DoWork_ProgressChanged);

            //PopulateElasticSearch populate = new PopulateElasticSearch();
            //populate.Delete();
            //Console.WriteLine("populate.Delete() completed");
         
            Console.WriteLine("Completed.");
           
        }

        private static void indexingWorker_DoWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PopulateWorkerProgressEventArgs args = (PopulateWorkerProgressEventArgs)e.UserState;
            Console.WriteLine(args.progress);
        }

    }
}

