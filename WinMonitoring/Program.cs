using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using WinMonitoring.BaseBoard;
using WinMonitoring.Battery;
using WinMonitoring.Bios;
using WinMonitoring.Bus;
using WinMonitoring.CDRom;
using WinMonitoring.Disk;
using WinMonitoring.DMAChannel;
using WinMonitoring.Fan;

namespace WinMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseBoard.BaseBoard bb = new BaseBoard.BaseBoard();
            //Console.WriteLine(bb.BBoard());

            //Battery.Battery bt = new Battery.Battery();
            //Console.WriteLine(bt.Batery());

            //Bios.Bios bos = new Bios.Bios();
            //Console.WriteLine(bos.BiOs());

            //Bus.Bus buss = new Bus.Bus();
            //Console.WriteLine(buss.WBus());
            
            //CDRom.CDRom cdrom = new CDRom.CDRom();
            //Console.WriteLine(cdrom.CRom());

            //Disk.Disk disk = new Disk.Disk();
            //Console.WriteLine(disk.DDisk());

            //DMAChannel.DMAChannel dma = new DMAChannel.DMAChannel();
            //Console.WriteLine(dma.DChan());

            //Fan.Fan fan = new Fan.Fan();
            //Console.WriteLine(fan.FaN());
            
            Console.ReadLine();
            
        }
    }
}
