// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");



Thread t1 = new Thread(() => {


    var instance1 = UploadService.Instance(1);

});


Thread t2 = new Thread(() => {


    var instance2 = UploadService.Instance(2);
});


t1.Start();
t2.Start();
t1.Join();
t2.Join();



