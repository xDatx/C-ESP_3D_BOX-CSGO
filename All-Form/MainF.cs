using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GameOverlay;
using Memory;
using System.Threading;
using hazedumper;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Diagnostics;
using GameOverlay.Windows;
using GameOverlay.Drawing;
using SharpDX.DirectWrite;

namespace TGuilit
{
    public partial class Form1 : Form
    {
        #region Setup
        private bool mouseDown;
        private System.Drawing.Point lastLocation;
        private Button but;

        private float r = 1.0f;
        private float g = 1.0f;
        private float b = 1.0f;
       public static Vector2 entpos2D = new Vector2(0, 0); // Khởi tạo giá trị mặc định cho entpos2D
        public static Vector2 enthead2D = new Vector2(0, 0); // Khởi tạo giá trị mặc định cho entpos2D
        public static int WindowHeight = 0;
        public static int WindowWidth = 0;
        public static int red, green, blue;
        public static string client = "client.dll+";
        private string engine = "engine.dll+";

        public static entity player = new entity();
        public static List<entity> entities = new List<entity>();

        public static string WINDOW_NAME = "Counter-Strike: Global Offensive - Direct3D 9";
        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

         public static Factory factory = new Factory();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
         
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lprect);

        [StructLayout(LayoutKind.Sequential)]
        public  struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public int Width;
            public int Height;
        }

        public static RECT rect;


        public static OverlayWindow window;
        public static GameOverlay.Drawing.Graphics graphics;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);


        public static Mem mem = new Mem();
        private int PID;
        public static Matrix4x4 matrix;
      
        public static Vector2 b1_2, b2_2, b3_2, b4_2, t1_2, t2_2, t3_2, t4_2;
        public static string LocalP;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }



        private void End_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            aimCustomForm1.BringToFront();
            DoubleBuffered = true;
            PID = mem.GetProcIdFromName("csgo");
            string processName = "csgo"; // Tên quy trình cần lấy thông tin (ví dụ: notepad)

            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 0)
            {
                Process process = processes[0]; // Lấy quy trình đầu tiên trong danh sách

                IntPtr mainWindowHandle = process.MainWindowHandle;
                if (mainWindowHandle != IntPtr.Zero)
                {
                    if (GetWindowRect(mainWindowHandle, out RECT rect))
                    {
                        WindowWidth = rect.Right - rect.Left;
                        WindowHeight = rect.Bottom - rect.Top;
                    }
                }
            }
            GetWindowRect(handle, out rect);
            rect.Width = WindowWidth;
            rect.Height = WindowHeight;
            window = new OverlayWindow(rect.Left, rect.Top, rect.Width, rect.Height)
            {
                IsTopmost = true,
                IsVisible = true,

            };

            graphics = new GameOverlay.Drawing.Graphics()
            {
                MeasureFPS = true,
                PerPrimitiveAntiAliasing = true,
                TextAntiAliasing = true,
                UseMultiThreadedFactories = false,
                VSync = true,
                Height = window.Height,
                Width = window.Width,
                WindowHandle = IntPtr.Zero,
            };

            window.Create();
            graphics.WindowHandle = window.Handle;
            graphics.Setup();       


            if (PID > 0)
              {
                mem.OpenProcess(PID);
                Thread up = new Thread(UpdateAimbot);
                Thread bh = new Thread(Bhop) { IsBackground = true };
                
                bh.Start();
                up.Start();
                
            }
        }


       


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new System.Drawing.Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BTN_Aim_Click(object sender, EventArgs e)
        {
            but = BTN_Aim;
            SidePanel.Start(); // Bắt đầu chạy timer
            aimCustomForm1.BringToFront();
        }

        private void BTN_Visual_Click(object sender, EventArgs e)
        {
            but = BTN_Visual;
            SidePanel.Start(); // Bắt đầu chạy timer
            visualCustomForm1.BringToFront();
        }

        
        private void BTN_Misc_Click(object sender, EventArgs e)
        {
            but = BTN_Misc;
            SidePanel.Start(); // Bắt đầu chạy timer
            miscCustomForm1.BringToFront();
        }

        private void PN_Setting_Click(object sender, EventArgs e)
        {
            but = PN_Setting;
            SidePanel.Start(); // Bắt đầu chạy timer
            firstCustomControl1.BringToFront();
        }

        private void ChangeTextColor(Control control, System.Drawing.Color color)
        {
            control.ForeColor = color;

            foreach (Control childControl in control.Controls)
            {
                if (childControl is Label || childControl is Button || childControl is TextBox || childControl is RichTextBox)
                {
                    childControl.ForeColor = color;
                }

                // Đệ quy gọi hàm ChangeTextColor cho các panel con
                if (childControl.Controls.Count > 0)
                {
                    ChangeTextColor(childControl, color);
                }
            }
        }



        private void SidePanel_Tick(object sender, EventArgs e)
        {
            int stepSize = 18; // Điều chỉnh kích thước bước di chuyển (tùy chỉnh theo nhu cầu của bạn)
            int targetTop = but.Top;

            if (PN_Slec.Top < targetTop)
            {
                PN_Slec.Top += stepSize;
                if (PN_Slec.Top > targetTop)
                    PN_Slec.Top = targetTop;
            }
            else if (PN_Slec.Top > targetTop)
            {
                PN_Slec.Top -= stepSize;
                if (PN_Slec.Top < targetTop)
                    PN_Slec.Top = targetTop;
            }

            

            // Kiểm tra xem panel đã đạt được vị trí mục tiêu hay chưa
            if (PN_Slec.Top == targetTop)
            {
                SidePanel.Stop(); // Dừng timer khi panel đã đạt vị trí mục tiêu
            }
        }

        


        void UpdateLocalPlayer()
        {
            var localplayer = client + Convert.ToString(signatures.dwLocalPlayer, 16);
            LocalP = localplayer;
            var coords = mem.ReadBytes(localplayer + ",0x" + Convert.ToString(netvars.m_vecOrigin, 16), 12);
            player.feet.X = BitConverter.ToSingle(coords, 0);
            player.feet.Y = BitConverter.ToSingle(coords, 4);
            player.feet.Z = BitConverter.ToSingle(coords, 8);
            player.team = mem.ReadInt(localplayer + ",0x" + Convert.ToString(netvars.m_iTeamNum, 16));
            player.feet.Z += mem.ReadFloat(localplayer + ",0x" + Convert.ToString((netvars.m_vecViewOffset + 0x8), 16));
        }

        void UpdateEntity()
        {
            entities.Clear();
            for (int i = 1; i < 32; i++)
            {
                var entpointer = client + Convert.ToString(signatures.dwEntityList + i * 0x10, 16);
                var team = mem.ReadInt(entpointer + ",0x" + Convert.ToString(netvars.m_iTeamNum, 16));
                var dormant = mem.ReadInt(entpointer + ",0x" + Convert.ToString(signatures.m_bDormant, 16));
                var hp = mem.ReadInt(entpointer + ",0x" + Convert.ToString(netvars.m_iHealth, 16));
                var angleY = mem.ReadFloat(entpointer + ",0x" + Convert.ToString(netvars.m_angEyeAnglesY, 16));
                if (hp < 1 || dormant != 0)
                    continue;

                var ent = new entity
                {
                    feet = CurrentPos(entpointer),
                    head = RecieveHead(entpointer),
                    team = team,
                    health = hp,
                    angleyeY = angleY,
                };
                ent.mag = CalcMag(player.feet, ent.head);
                entities.Add(ent);
            }
        }


        float CalcMag(Vector3 player, Vector3 enemy)
        {
            return (float)(Math.Sqrt(
                Math.Pow(enemy.X - player.X, 2) +
                Math.Pow(enemy.Y - player.Y, 2) +
                Math.Pow(enemy.Z - player.Z, 2)
                ));
        }

        void Aim(entity ent)
        {
            float deltaX = ent.head.X - player.feet.X;
            float deltaY = ent.head.Y - player.feet.Y;
            float deltaZ = ent.head.Z - player.feet.Z;

            float X = (float)(Math.Atan2(deltaY, deltaX) * 180 / Math.PI);

            double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            float Y = -(float)(Math.Atan2(deltaZ, dist) * 180 / Math.PI);

            var buffer = engine + Convert.ToString(signatures.dwClientState,16);
            mem.WriteMemory(buffer + ",0x" + Convert.ToString(signatures.dwClientState_ViewAngles, 16), "float", Y.ToString());
            mem.WriteMemory(buffer + ",0x" + Convert.ToString((signatures.dwClientState_ViewAngles + 0x4), 16), "float", X.ToString());
        }

        
        void UpdateAimbot()
        {
            while (true)
            {
                if (AimCustomForm.Aimbot == true || VisualCustomForm.esp_line == true || VisualCustomForm.recoil_cross == true || VisualCustomForm.esp_2d == true || VisualCustomForm.esp_3d == true)
                {
                    viewmatrix();
                    UpdateLocalPlayer();
                    UpdateEntity();
                    if (AimCustomForm.Aimbot == true)
                    {
                        entities = entities.OrderBy(o => o.mag).ToList();
                        if (GetAsyncKeyState(0x05) < 0)
                        {
                            foreach (var ent in entities.ToList())
                            {
                                if (ent.team == player.team)
                                {
                                    entities.Remove(ent);
                                }
                            }
                            if (entities.Count > 0)
                                Aim(entities[0]);
                        }
                    }

                    graphics.BeginScene();
                    graphics.ClearScene();
                    GameOverlay.Drawing.Color customColor = new GameOverlay.Drawing.Color(red, green, blue); // Yellow
                    IBrush brush = graphics.CreateSolidBrush(customColor);
                    GameOverlay.Drawing.Font fon1 = new GameOverlay.Drawing.Font(factory, "Century_Gothic", 9.75f);
                    if (VisualCustomForm.recoil_cross == true)
                    {
                        DrawRecoilCrossHair(brush, 2, 1, CrosshairStyle.Plus);
                    }
                    if (entities.Count > 0)
                    {
                            foreach (var ent in entities)
                            {
                                if (ent != null)
                                {

                                    if (WorldToScreen(ent.feet, ref entpos2D))
                                    {
                                        if (VisualCustomForm.esp_line == true)
                                        {
                                            DrawLine(brush, entpos2D.X, entpos2D.Y, WindowWidth / 2, WindowHeight, 1);

                                        }
                                        if (WorldToScreen(ent.head, ref enthead2D))
                                        {
                                            graphics.DrawText(fon1, graphics.CreateSolidBrush(GameOverlay.Drawing.Color.Red), entpos2D.X, entpos2D.Y, "HP: " + ent.health.ToString());
                                            if (VisualCustomForm.esp_2d == true)
                                            {
                                                DrawEspBox2D(brush, new Vector2(entpos2D.X, entpos2D.Y), new Vector2(enthead2D.X, enthead2D.Y), 1);
                                            }
                                            if (VisualCustomForm.esp_3d == true)
                                            {
                                                DrawEspBox3D(brush, ent.head, ent.feet, ent.angleyeY, 25, 2);
                                            }
                                        }
                                    }
                                }
                            }                   
                         }
                    fon1.Dispose();
                    brush.Brush.Dispose();
                    graphics.EndScene();
                    }                            
                    else
                    {
                        graphics.BeginScene();
                        graphics.ClearScene();
                        graphics.EndScene();
                    }        
                Thread.Sleep(13);
            }
        }


        void Bhop()
        {
            while (true)
            {
                if (MiscCustomForm.Bunny == true)
                {
                    if (GetAsyncKeyState(0x20) < 0)
                    {
                        var localplayer = client + Convert.ToString(signatures.dwLocalPlayer, 16);
                        var flag = mem.ReadInt(localplayer + ",0x" + Convert.ToString(netvars.m_fFlags, 16));
                        if (flag == 257)
                        {
                            mem.WriteMemory(client + Convert.ToString(signatures.dwForceJump, 16), "int", "6");
                        }
                    }
                }
                Thread.Sleep(3);
            }
        }

        Vector3 RecieveHead(string entpointer)
        {
            var bones = entpointer + ",0x" + Convert.ToString(netvars.m_dwBoneMatrix, 16);
            var bone = mem.ReadBytes(bones + ",0x" + Convert.ToString(0x30 * 8,16), 0x30);
            return new Vector3
            {
                X = BitConverter.ToSingle(bone,0xC),
                Y = BitConverter.ToSingle(bone,0x1C),
                Z = BitConverter.ToSingle(bone,0x2C),
            };
        } 

        Vector3 CurrentPos(string entpointer)
        {
            var coords = mem.ReadBytes(entpointer + ",0x" + Convert.ToString(netvars.m_vecOrigin, 16), 12);
            return new Vector3()
            {
                X = BitConverter.ToSingle(coords, 0),
                Y = BitConverter.ToSingle(coords, 4),
                Z = BitConverter.ToSingle(coords, 8)
            };
        }

        public static Matrix4x4 viewmatrix()
        {
            var buffer = new byte[16 * 4];

            buffer = mem.ReadBytes(client + Convert.ToString(signatures.dwViewMatrix, 16), buffer.Length);

            matrix.M11 = BitConverter.ToSingle(buffer, 0 * 4);
            matrix.M12 = BitConverter.ToSingle(buffer, 1 * 4);
            matrix.M13 = BitConverter.ToSingle(buffer, 2 * 4);
            matrix.M14 = BitConverter.ToSingle(buffer, 3 * 4);


            matrix.M21 = BitConverter.ToSingle(buffer, 4 * 4);
            matrix.M22 = BitConverter.ToSingle(buffer, 5 * 4);
            matrix.M23 = BitConverter.ToSingle(buffer, 6 * 4);
            matrix.M24 = BitConverter.ToSingle(buffer, 7 * 4);

            matrix.M31 = BitConverter.ToSingle(buffer, 8 * 4);
            matrix.M32 = BitConverter.ToSingle(buffer, 9 * 4);
            matrix.M33 = BitConverter.ToSingle(buffer, 10 * 4);
            matrix.M34 = BitConverter.ToSingle(buffer, 11 * 4);

            matrix.M41 = BitConverter.ToSingle(buffer, 12 * 4);
            matrix.M42 = BitConverter.ToSingle(buffer, 13 * 4);
            matrix.M43 = BitConverter.ToSingle(buffer, 14 * 4);
            matrix.M44 = BitConverter.ToSingle(buffer, 15 * 4);

            return matrix;
        }

        public static bool WorldToScreen(Vector3 pos, ref Vector2 screenPos)
        {
         
            Vector4 clipCoords;
            clipCoords.X = pos.X * matrix.M11 + pos.Y * matrix.M12 + pos.Z * matrix.M13 + matrix.M14;
            clipCoords.Y = pos.X * matrix.M21 + pos.Y * matrix.M22 + pos.Z * matrix.M23 + matrix.M24;
            clipCoords.Z = pos.X * matrix.M31 + pos.Y * matrix.M32 + pos.Z * matrix.M33 + matrix.M34;
            clipCoords.W = pos.X * matrix.M41 + pos.Y * matrix.M42 + pos.Z * matrix.M43 + matrix.M44;

            if (clipCoords.W < 0.1f)
            {
                return false;
            }

            Vector3 NDC;
            NDC.X = clipCoords.X / clipCoords.W;
            NDC.Y = clipCoords.Y / clipCoords.W;
            NDC.Z = clipCoords.Z / clipCoords.W;

            screenPos.X = NDC.X * (WindowWidth / 2) + (WindowWidth / 2);
            screenPos.Y = -(NDC.Y * (WindowHeight / 2)) + (WindowHeight / 2);

            return true;
        }

       
        public static void DrawLine(IBrush brush, float x1, float y1, float x2, float y2, float stroke)
        {
            graphics.DrawLine(brush, x1, y1, x2, y2, stroke);
        }
        public static void DrawRecoilCrossHair(IBrush brush, float size, float thickess, CrosshairStyle style)
        {
            if (LocalP != null)
            {
                Vector3 pAngle;
                pAngle.X = mem.ReadFloat(LocalP + ",0x" + Convert.ToString(netvars.m_aimPunchAngle, 16));
                pAngle.Y = mem.ReadFloat(LocalP + ",0x" + Convert.ToString(netvars.m_aimPunchAngle + 0x4, 16));
                float x = WindowWidth / 2 - (WindowWidth / 90 * pAngle.Y);
                float y = WindowHeight / 2 + (WindowHeight / 90 * pAngle.X);
                graphics.DrawCrosshair(brush, x, y, size, thickess, style);

            }
        }
        public static void DrawEspBox2D(IBrush brush, Vector2 top, Vector2 bot, float thickness)
        {
            int height = (int)Math.Abs(top.Y - bot.Y);
            Vector2 tl, tr;
            tl.X = top.X - height / 4;
            tr.X = top.X + height / 4;
            tl.Y = tr.Y = top.Y;

            Vector2 bl, br;
            bl.X = bot.X - height / 4;
            br.X = bot.X + height / 4;
            bl.Y = br.Y = bot.Y;

            DrawLine(brush, tl.X, tl.Y, tr.X, tr.Y, thickness);
            DrawLine(brush, bl.X, bl.Y, br.X, br.Y, thickness);
            DrawLine(brush, tl.X, tl.Y, bl.X, bl.Y, thickness);
            DrawLine(brush, tr.X, tr.Y, br.X, br.Y, thickness);
        }
        public static void DrawEspBox3D(IBrush brush, Vector3 top, Vector3 bot, float a, int width, int thickness)
        {
            int height3D = (int)Math.Abs(top.Z - bot.Z);
            Vector3 b1, b2, b3, b4, t1, t2, t3, t4;
            b1.Z = b2.Z = b3.Z = b4.Z = bot.Z;

            b1.X = (float)(bot.X + Math.Cos(ToRad(a + 45)) * width);
            b1.Y = (float)(bot.Y + Math.Sin(ToRad(a + 45)) * width);

            b2.X = (float)(bot.X + Math.Cos(ToRad(a + 135)) * width);
            b2.Y = (float)(bot.Y + Math.Sin(ToRad(a + 135))  * width);

            b3.X = (float)(bot.X + Math.Cos(ToRad(a + 225)) * width);
            b3.Y = (float)(bot.Y + Math.Sin(ToRad(a + 225)) * width);

            b4.X = (float)(bot.X + Math.Cos(ToRad(a + 315)) * width);
            b4.Y = (float)(bot.Y + Math.Sin(ToRad(a + 315)) * width);


            t1.X = b1.X;
            t1.Y = b1.Y;
            t1.Z = b1.Z + height3D;

            t2.X = b2.X;
            t2.Y = b2.Y;
            t2.Z = b2.Z + height3D;

            t3.X = b3.X;
            t3.Y = b3.Y;
            t3.Z = b3.Z + height3D;

            t4.X = b4.X;
            t4.Y = b4.Y;
            t4.Z = b4.Z + height3D;

            if (WorldToScreen(b1, ref b1_2) && WorldToScreen(b2,ref b2_2) && WorldToScreen(b3, ref b3_2) && WorldToScreen(b4,ref b4_2) && WorldToScreen(t1, ref t1_2) && WorldToScreen(t2, ref t2_2) && WorldToScreen(t3,ref t3_2) && WorldToScreen(t4, ref t4_2))
            {
                DrawLine(brush, t1_2.X, t1_2.Y, b1_2.X, b1_2.Y, 1);
                DrawLine(brush, t2_2.X, t2_2.Y, b2_2.X, b2_2.Y, 1);
                DrawLine(brush, t3_2.X, t3_2.Y, b3_2.X, b3_2.Y, 1);
                DrawLine(brush, t4_2.X, t4_2.Y, b4_2.X, b4_2.Y, 1);

                DrawLine(brush, t1_2.X, t1_2.Y, t2_2.X, t2_2.Y, 1);
                DrawLine(brush, t2_2.X, t2_2.Y, t3_2.X, t3_2.Y, 1);
                DrawLine(brush, t3_2.X, t3_2.Y, t4_2.X, t4_2.Y, 1);
                DrawLine(brush, t4_2.X, t4_2.Y, t1_2.X, t1_2.Y, 1);

                DrawLine(brush, b1_2.X, b1_2.Y, b2_2.X, b2_2.Y, 1);
                DrawLine(brush, b2_2.X, b2_2.Y, b3_2.X, b3_2.Y, 1);
                DrawLine(brush, b3_2.X, b3_2.Y, b4_2.X, b4_2.Y, 1);
                DrawLine(brush, b4_2.X, b4_2.Y, b1_2.X, b1_2.Y, 1);

            }
        }

        public static float ToRad(float x)
        {
            return x * 0.01745329252f;
        }

        private void RainText_Tick(object sender, EventArgs e)
        {
            if (SettingCustomForm.RainbowT == true)
            {
                if (r == 1.0f && g >= 0.0f && b <= 0.0f)
                {
                    g += 0.005f;
                    b = 0.0f;
                }
                if (r <= 1.0f && g >= 1.0f && b == 0.0f)
                {
                    g = 1.0f;
                    r -= 0.005f;
                }
                if (r <= 0.0f && g == 1.0f && b >= 0.0f)
                {
                    r = 0.0f;
                    b += 0.005f;
                }
                if (r == 0.0f && g <= 1.0f && b >= 1.0f)
                {
                    b = 1.0f;
                    g -= 0.005f;
                }
                if (r >= 0.0f && g <= 0.0f && b == 1.0f)
                {
                    g = 0.0f;
                    r += 0.005f;
                }
                if (r >= 1.0f && g >= 0.0f && b <= 1.0f)
                {
                    r = 1.0f;
                    b -= 0.005f;
                }

                 red = (int)(r * 255);
                 green = (int)(g * 255);
                 blue = (int)(b * 255);

                // Giới hạn giá trị của blue trong khoảng từ 0 đến 255
                if (blue < 0)
                    blue = 0;
                else if (blue > 255)
                    blue = 255;

                System.Drawing.Color rainbowColor = System.Drawing.Color.FromArgb(red, green, blue);
                ChangeTextColor(this, rainbowColor);
            }
            else
            {
                System.Drawing.Color rainbowColor = System.Drawing.Color.White;
                ChangeTextColor(this, rainbowColor);

            }
        }
    }
}
