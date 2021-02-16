using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DiscordRPC;

namespace Goblox
{
    public partial class Form1 : Form
    {
        private delegate void SetTextCallback(string text);
        private bool launched;
        private bool debounce;
        private bool processed;
        public DiscordRpcClient client;
        public DiscordRPC.Button addbotButton;
        public DiscordRPC.Button testButton;

        private void SetTextGenerateBTN(string text)
        {
            if (GenerateBTN.InvokeRequired)
            {
                var d = new SetTextCallback(SetTextGenerateBTN);
                GenerateBTN.Invoke(d, new object[] { text });
            }
            else
            {
                GenerateBTN.Text = text;
            }
        }
        private void SetTextAkun(string text)
        {
            if (akunPengguna.InvokeRequired)
            {
                var d = new SetTextCallback(SetTextAkun);
                akunPengguna.Invoke(d, new object[] { text });
            }
            else
            {
                akunPengguna.Text = text;
            }
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public Form1()
        {
            debounce = true;
            InitializeComponent();
            client = new DiscordRpcClient("800007556810407946");
            //client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sendere, ee) =>
            {
                debounce = false;
                SetTextAkun("Terhubung dengan, " + client.CurrentUser.ToString());
                Console.WriteLine("Discord rich presence siap, {0}", ee.User.Username);
            };
            client.OnError += (err, something) =>
            {
                processed = false;
                SetTextGenerateBTN("Gagal diperbarui..");
                wait(850);
                SetTextGenerateBTN("Perbarui");
                debounce = false;
            };
            client.OnPresenceUpdate += (embed, something) =>
            {
                processed = false;
                SetTextGenerateBTN("Berhasil diperbarui!");
                wait(650);
                SetTextGenerateBTN("Perbarui");
                debounce = false;
            };
            client.Initialize();
            addbotButton = new DiscordRPC.Button()
            {
                Url = "https://discord.com/api/oauth2/authorize?client_id=777756503028400138&permissions=11265&scope=bot",
                Label = "Add Bot"
            };
            testButton = new DiscordRPC.Button()
            {
                Url = "https://blackerz.herokuapp.com/servers/784909921522810930",
                Label = "Fuck me"
            };
        }
      
        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            if (debounce == true) return;
            debounce = true;
            DiscordRPC.Button[] tombol = { addbotButton, testButton };
            client.SetPresence(new RichPresence()
            {
                Details = InputDetail.Text == "" ? "Menjadi tolol" : InputDetail.Text,
                State = InputState.Text,
                Timestamps = DiscordRPC.Timestamps.Now,
                Buttons = tombol,
                Assets = new Assets()
                {
                    LargeImageKey = "indihum2",
                    LargeImageText = "Indihum helps me doin' funny things"
                    //SmallImageKey = "indihum2"
                }
            });
            processed = true;
            if (launched != true)
            {
                launched = true;
                var timer = new System.Timers.Timer(500);
                timer.Elapsed += (sendere, args) => { client.Invoke(); };
                timer.Start();
            }

            string titik = "";
            do
            {
                if (processed == false) break;
                if (titik.Length >= 4) titik = "";
                titik += ".";
                GenerateBTN.Text = "Memproses" + titik;
                wait(175);
                if (processed == false) break;
            } while (processed == true);
        }

    }
}
