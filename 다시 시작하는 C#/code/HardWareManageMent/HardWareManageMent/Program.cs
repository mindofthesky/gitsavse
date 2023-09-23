using HardWareManageMent.ManageMentAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HardWareManageMent.Program;

namespace HardWareManageMent
{
    internal class Program
    {
        const int Batch_Size = 5;
        static void Main(string[] args)
        {
            CustomQueue<HardWareItem> customQueue = new CustomQueue<HardWareItem>();

            customQueue.CustomQueueEvent += CustomQueue_CustomQueueEvent;
            System.Threading.Thread.Sleep(2000);

            //comes into stock - device scans a bar code or QR code
            customQueue.AddItem(new Drill { id = 1, name = "Drill 1", Type = "Drill", UnitValue = 20.00m, Quantity = 10 });

            System.Threading.Thread.Sleep(1000);

            customQueue.AddItem(new Drill { id = 2, name = "Drill 2", Type = "Drill", UnitValue = 30.00m, Quantity = 20 });

            System.Threading.Thread.Sleep(2000);

            customQueue.AddItem(new Ladder { id = 3, name = "Ladder 1", Type = "Ladder", UnitValue = 100.00m, Quantity = 5 });

            System.Threading.Thread.Sleep(1000);

            customQueue.AddItem(new Hammer { id = 4, name = "Hammer 1", Type = "Hammer", UnitValue = 10.00m, Quantity = 80 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new PaintBrush { id = 5, name = "Paint Brush 1", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new PaintBrush { id = 6, name = "Paint Brush 2", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new PaintBrush { id = 7, name = "Paint Brush 3", Type = "PaintBrush", UnitValue = 5.00m, Quantity = 100 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new Hammer { id = 8, name = "Hammer 2", Type = "Hammer", UnitValue = 11.00m, Quantity = 80 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new Hammer { id = 9, name = "Hammer 3", Type = "Hammer", UnitValue = 13.00m, Quantity = 80 });
            System.Threading.Thread.Sleep(3000);

            customQueue.AddItem(new Hammer { id = 10, name = "Hammer 4", Type = "Hammer", UnitValue = 14.00m, Quantity = 80 });
            System.Threading.Thread.Sleep(3000);

            Console.ReadKey();

        }
        private static void CustomQueue_CustomQueueEvent(CustomQueue<HardWareItem> sender, QueueEventArgs e)
        {
            Console.Clear();

            Console.WriteLine(MainHeading());
            Console.WriteLine();
            Console.WriteLine(RealTimeUpdateHeading());

            if (sender.QueueLength > 0)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(ItemsInQueueHeading());
                Console.WriteLine(FieldHeadings());

                WriteValuesInQueueToScreen(sender);

                if (sender.QueueLength == Batch_Size)
                {
                    ProcessItems(sender);

                }

            }
            else
            {
                Console.WriteLine("상태 :모든 프로세스가 사용중입니다.");
            }
        }
        private static void ProcessItems(CustomQueue<HardWareItem> customQueue)
        {
            while (customQueue.QueueLength > 0)
            {
                System.Threading.Thread.Sleep(3000);
                HardWareItem hardWareItem = customQueue.GetItem();

            }

        }
        private static void WriteValuesInQueueToScreen(CustomQueue<HardWareItem> hardwareItems)
        {
            foreach (var hardwareItem in hardwareItems)
            {
                Console.WriteLine($"{hardwareItem.id,-6}{hardwareItem.name,-15}{hardwareItem.Type,-20}{hardwareItem.Quantity,10}{hardwareItem.UnitValue,10}");
            }
        }

        //Headings
        private static string FieldHeadings()
        {
            return UnderLine($"{"Id",-6}{"Name",-15}{"Type",-20}{"Quantity",10}{"Value",10}");
        }

        private static string RealTimeUpdateHeading()
        {
            return UnderLine("Real-time Update");
        }

        private static string ItemsInQueueHeading()
        {
            return UnderLine("Items Queued for Processing");
        }

        private static string MainHeading()
        {
            return UnderLine("Warehouse Management System");
        }

        private static string UnderLine(string heading)
        {
            return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
        }
        public abstract class HardWareItem : IEntitiyPrimaryProperties, IEntityAdditionalProperties
        {
            public int id { get ; set; }
            public string name { get; set; }
            public string Type { get; set; }
            public int Quantity { get; set; }
            public decimal UnitValue { get; set; }
        }
        public interface IDrill
        {
            string DrillBrandName { get; set; }
        }
        public class Drill : HardWareItem, IDrill
        {
            public string DrillBrandName { get; set; }

        }
        public interface ILadder
        {
            string LadderBrandName { get; set; }
        }
        public class Ladder : HardWareItem, ILadder
        {
            public string LadderBrandName { get; set; }

        }
        public interface IPaintBrush
        {
            string PaintBrushBrandName { get; set; }
        }
        public class PaintBrush : HardWareItem, IPaintBrush
        {
            public string PaintBrushBrandName { get; set; }

        }
        public interface IHammer
        {
            string HammerBrandName { get; set; }
        }
        public class Hammer : HardWareItem, IHammer
        {
            public string HammerBrandName { get; set; }

        }
    }
}
