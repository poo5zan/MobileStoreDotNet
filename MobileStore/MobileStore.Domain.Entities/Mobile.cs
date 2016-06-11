using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Domain.Entities
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string CommonName { get; set; }
        public string UniqueName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string NetworkTechnology { get; set; }
        public DateTime LaunchDate { get; set; }
        public string LaunchStatus { get; set; }
        public double DimensionLength { get; set; }
        public double DimensionBreadth { get; set; }
        public double DimensionHeight { get; set; }
        public double DimensionUnit { get; set; }
        public double WeightValue { get; set; }
        public string WeightUnit { get; set; }
        public string DisplayType { get; set; }
        public double ScreenToBodyRatio { get; set; }
        public double PpiPixelDensity { get; set; }
        public double ResolutionLength { get; set; }
        public double ResolutionBreadth { get; set; }
        public string ResolutionUnit { get; set; }
        public bool MultiTouch { get; set; }
        public int MultiTouchNumberOfFingers { get; set; }
        public double DisplaySize { get; set; }
        public string DisplaySizeUnit { get; set; }
        public string PlatformOS { get; set; }
        public string PlatformChipset { get; set; }
        public string PlatformCpu { get; set; }
        public string PlatformGpu { get; set; }
        public string MemoryCardSlot { get; set; }
        public string MemoryInternal { get; set; }
        public string CameraPrimary { get; set; }
        public string CameraFeatures { get; set; }
        public string CameraVideo { get; set; }
        public string CameraSecondary { get; set; }
        public string SoundAlertTypes { get; set; }
        public string SoundLoudSpeaker { get; set; }
        public string SoundThreePointFivemmJack { get; set; }
        public string CommunicationWlan { get; set; }
        public string CommunicationBluetooth { get; set; }
        public string CommunicationGps { get; set; }
        public string CommunicationNfc { get; set; }
        public string CommunicationRadio { get; set; }
        public string CommunicationUsb { get; set; }
        public string Sensors { get; set; }
        public string Messaging { get; set; }
        public string Browser { get; set; }
        public string Java { get; set; }
        public string Battery { get; set; }
        public string Color { get; set; }
        public string SarEu { get; set; }
        public string PriceGroup { get; set; }


    }
}
