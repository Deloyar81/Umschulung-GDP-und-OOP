using Aufgabe_2022_02_02__Polymorphie__Devices;

void Main()
{
    //Liste erstellen
    //List<Device> devices = new List<Device>();

    DeviceList devices = new DeviceList();
    

    //Objekte initialisieren und Liste befüllen 
    Device device = new Device(1, "Hersteller");
    //devices.Add(device);
    devices.PushFront(device);

    AudioDevice hifi = new AudioDevice(2, "Yamaha", "DOOM-Hammer");
    //devices.Add(hifi);
    devices.PushFront(hifi);

    VideoDevice videokassette = new VideoDevice(3, "Samsung", 34);
    //devices.Add(videokassette);
    devices.PushFront(videokassette);

    //Ausgabe
    //foreach ( Device dev in devices)
    //{
    //    Console.WriteLine();
    //    Console.WriteLine(dev.ToString());
    //}
    devices.Display();
    devices.Display();
    Console.ReadKey();
}

Main();