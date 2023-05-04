using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class UploadService
    {


        private UploadService()
        {

        }

        private int Id { get;  set; }

        private static UploadService _instance;
        private static readonly object __lock = new object();
       public static UploadService Instance(int id)
        {
            if (_instance == null)
            {
                //what if both threads triggers to get the instance of this class?
                //in such case we use locking to allow only one thread to execute the object creation.
                lock (__lock)
                {
                    if(_instance == null)
                    {
                        _instance = new UploadService();
                        _instance.Id = id;  
                    }
                }

            }
            return _instance;
        }

    }
}
