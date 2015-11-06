using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SharpDX;
using SharpDX.Windows;
using SharpDX.Direct3D9;

namespace DirectXApp
{
    class Directx
    {
        public static object sync = new object();

        const int NumMas = 15000000;
        const int NumVect = 1280;
        const int NumChanel = 4;
        public static double[,] mas = new double[NumChanel, NumMas]; public static Int64 GlobalIndex = 0;
        public static Vector2[] vector = new Vector2[NumVect];
        public static Vector2[] vector2 = new Vector2[NumVect];
        public static Vector2[][] vectormas = new Vector2[NumChanel][];
        public RenderForm form;
        public Device device;
        public Line[] linemas = new Line[NumChanel];
        public ColorBGRA[] colormas = new ColorBGRA[NumChanel];

        public void Sin()
        {
            for (int i = 0; i < NumChanel; i++)
            {
                vectormas[i] = new Vector2[NumVect];
            }         

            form = new RenderForm("DirectX Rendered Window");
            //form.AllowUserResizing = false;
            form.UserResized += new EventHandler<EventArgs>(onResize);
            PresentParameters presentParams = new PresentParameters(form.ClientSize.Width, form.ClientSize.Height);
            device = new Device(new Direct3D(), 0, DeviceType.Hardware, form.Handle, CreateFlags.HardwareVertexProcessing, presentParams);

            //Line[] linemas = new Line[NumChanel];
            for (int i = 0; i < NumChanel; i++)
            {
                linemas[i] = new Line(device);
                linemas[i].Width = 1;
            }

            /*Line line = new Line(device);
            line.Width = 1;
            Line line2 = new Line(device);
            line2.Width = 3;*/

            //ColorBGRA[] colormas = new ColorBGRA[NumChanel];
            Random randColor = new Random();

            for (int i = 0; i < NumChanel; i++)
            {
                colormas[i].B = (byte)randColor.Next(0, 255);
                colormas[i].G = (byte)randColor.Next(0, 255);
                colormas[i].R = (byte)randColor.Next(0, 255);
                colormas[i].A = 255;
            }

            var timer = new System.Timers.Timer(1);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(onTick);
            timer.Enabled = true;

            /*double x = 0;
            for (int i = 0; i < NumVect; i++)
            {          
                x+=0.1;
                double y = 100*Math.Sin(x * Math.PI / 15.0)+300;
                vector[i] = new Vector2((float)x,(float)y);
            }*/

            RenderLoop.Run(form, () =>
            {
                device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Black, 1.0f, 0);
                //device.SoftwareVertexProcessing = true;
                device.BeginScene();

                //line.Antialias = true;
                //line2.Antialias = true;
                //line.GLLines = true;
                //line2.GLLines = true;
                //line.PatternScale = (float)5;
                //line.Pattern = 0xFFFFFF;

                //line.Draw(vector, color);
                //line2.Draw(vector2, color2);

                for (int i = 0; i < NumChanel; i++)
                {
                    linemas[i].Draw(vectormas[i], colormas[i]);
                    linemas[i].Antialias = true;
                }

                device.EndScene();
                device.Present();                 
            });
        }

        private void Form_UserResized(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onResize(Object source, EventArgs e) //Переделать
        {
            PresentParameters presentParams = new PresentParameters(form.ClientSize.Width, form.ClientSize.Height);
            device = new Device(new Direct3D(), 0, DeviceType.Hardware, form.Handle, CreateFlags.HardwareVertexProcessing, presentParams);         

            for (int i = 0; i < NumChanel; i++)
            {
                linemas[i] = new Line(device);
                linemas[i].Width = 1;
            }
        }

        private static void onTick(Object source, System.Timers.ElapsedEventArgs e)
        {
            lock(sync)
            {
                double x = 0;
                x = GlobalIndex * 0.1;
                double y = 100 * Math.Sin(x * Math.PI / 10.0) + 150;

                if (GlobalIndex < NumMas)
                {
                    for (int i = 0; i < NumChanel; i++)
                    {
                        mas[i, GlobalIndex] = y;
                    }
                       
                    for (int i = 0; i < NumVect; i++)
                    {
                        if (GlobalIndex - i >= 0)
                        {
                            for (int j = 0; j < NumChanel; j++)
                                vectormas[j][NumVect - 1 - i] = new Vector2((NumVect - 1 - i), (float)mas[j, GlobalIndex - i] + j * 400 / NumChanel);
                            //vector[NumVect - 1 - i] = new Vector2((float)(NumVect - 1 - i), (float)mas[0, GlobalIndex - i]);
                            //vector2[NumVect - 1 - i] = new Vector2((float)(NumVect - 1 - i), (float)mas[1, GlobalIndex - i]+200);
                        }
                    }
                }
                GlobalIndex++;
            }
        }

        public void onDevice(ref double [,]masDevice, int maxindex)
        {      
            if (GlobalIndex < NumMas)
            {
                for(int i = 0; i < maxindex; i++)
                {
                    mas[1, GlobalIndex] = masDevice[1, i];
                    mas[0, GlobalIndex] = masDevice[0, i];
                    GlobalIndex++;
                }  
                for (int i = 0; i < NumVect; i++)
                {
                    if (GlobalIndex - i >= 0)
                    {
                        vector[NumVect - 1 - i] = new Vector2((float)(NumVect - 1 - i), (float)mas[0, GlobalIndex - i]);
                        vector2[NumVect - 1 - i] = new Vector2((float)(NumVect - 1 - i), (float)mas[1, GlobalIndex - i] + 200);
                    }
                }
            }
        }
    }
}
