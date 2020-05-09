using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{

    public enum DIGCF
    {
        DIGCF_DEFAULT = 0x00000001,
        DIGCF_PRESENT = 0x00000002,
        DIGCF_ALLCLASSES = 0x00000004,
        DIGCF_PROFILE = 0x00000008,
        DIGCF_DEVICEINTERFACE = 0x00000010
    }

    public struct DEVICE_INTERFACE_DATA
    {
        public int cbSize;
        public Guid interfaceClassGuid;
        public int flags;
        public int reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class DEVINFO_DATA
    {
        public int cbSize = Marshal.SizeOf(typeof(DEVINFO_DATA));
        public Guid classGuid = Guid.Empty;
        public int devInst = 0;
        public int reserved = 0;
    }

    public partial class Form1 : Form
    {

        static Guid HIDGuid = Guid.Empty;

        /// <summary>
        /// The HidD_GetHidGuid routine returns the device interface GUID for HIDClass devices.
        /// a caller-allocated GUID buffer that the routine uses to return the device interface GUID for HIDClass devices.
        /// </summary>
        /// <param name="HidGuid"></param>
        [DllImport("hid.dll")]
        private static extern void HidD_GetHidGuid(ref Guid HidGuid);


        IntPtr HIDInfoSet = SetupDiGetClassDevs(ref HIDGuid, 0, IntPtr.Zero, DIGCF.DIGCF_PRESENT | DIGCF.DIGCF_DEVICEINTERFACE);
    
        ///
        /// The SetupDiGetClassDevs function returns a handle to a device information set that contains requested device information elements for a local machine.
        ///
        /// GUID for a device setup class or a device interface class.
        /// A pointer to a NULL-terminated string that supplies the name of a PnP enumerator or a PnP device instance identifier.
        /// A handle of the top-level window to be used for a user interface
        /// A variable  that specifies control options that filter the device information elements that are added to the device information set.
        ///
        /// a handle to a device information set
        [DllImport("setupapi.dll", SetLastError = true)]
        private static extern IntPtr SetupDiGetClassDevs(ref Guid ClassGuid, uint Enumerator, IntPtr HwndParent, USBHIDEnum.DIGCF Flags);

        ///
        /// The SetupDiEnumDeviceInterfaces function enumerates the device interfaces that are contained in a device information set.
        ///
        /// A pointer to a device information set that contains the device interfaces for which to return information
        /// A pointer to an SP_DEVINFO_DATA structure that specifies a device information element in DeviceInfoSet
        /// a GUID that specifies the device interface class for the requested interface
        /// A zero-based index into the list of interfaces in the device information set
        /// a caller-allocated buffer that contains a completed SP_DEVICE_INTERFACE_DATA structure that identifies an interface that meets the search parameters
        ///
        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern Boolean SetupDiEnumDeviceInterfaces(IntPtr deviceInfoSet, IntPtr deviceInfoData, ref Guid interfaceClassGuid, UInt32 memberIndex, ref DEVICE_INTERFACE_DATA deviceInterfaceData);


        int requiredSize = 0;

        ///
        /// The SetupDiGetDeviceInterfaceDetail function returns details about a device interface.
        ///
        /// A pointer to the device information set that contains the interface for which to retrieve details
        /// A pointer to an SP_DEVICE_INTERFACE_DATA structure that specifies the interface in DeviceInfoSet for which to retrieve details
        /// A pointer to an SP_DEVICE_INTERFACE_DETAIL_DATA structure to receive information about the specified interface
        /// The size of the DeviceInterfaceDetailData buffer
        /// A pointer to a variable that receives the required size of the DeviceInterfaceDetailData buffer
        /// A pointer buffer to receive information about the device that supports the requested interface
        ///
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr deviceInfoSet, ref DEVICE_INTERFACE_DATA deviceInterfaceData, IntPtr deviceInterfaceDetailData, int deviceInterfaceDetailDataSize, ref int requiredSize, DEVINFO_DATA deviceInfoData);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 字符串转2位16进制字节数组  
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
    }
}
