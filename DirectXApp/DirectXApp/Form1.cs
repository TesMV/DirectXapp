using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DirectXApp
{
    public partial class Form1 : Form
    {
        Directx Render = new Directx();

        public Form1()
        {
            InitializeComponent();
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;

            refDevice = new usbReferenceDevice(0x0451, 0x3211);

            refDevice.usbEvent += new usbReferenceDevice.usbEventsHandler(usbEventReciver);

            refDevice.usbEventDraw += new usbReferenceDevice.usbEventsHandlerDraw(Render.onDevice);

            refDevice.findTargetDevice();

            Thread trg=new Thread(new ThreadStart(Render.Sin));
            trg.Start();
        }

        private usbReferenceDevice refDevice;

        private void usbEventReciver(object o, EventArgs e)
        {
            if(refDevice.isDeviceAttached)
            {
                labelDeviceStatus.Text = "USB device is attached";
                buttonStart.Enabled = true;
            }
            else
            {
                labelDeviceStatus.Text = "USB device is dettached";
                buttonStart.Enabled = false;
                buttonStart.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            refDevice.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;            
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            refDevice.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            
        }
    }
}
