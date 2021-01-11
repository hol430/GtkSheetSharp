using System;
using Gtk;
using GtkSheet;

namespace GtkSheetTest
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.GtkSheetTest.GtkSheetTest", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = CreateWindow();
            app.AddWindow(win);

            win.ShowAll();
            Application.Run();
        }

        private static Window CreateWindow()
        {
            Sheet sheet = new Sheet(10, 10, "GtkSheet example");
            sheet.SetProperty("grid-visible", new GLib.Value(true));
            ScrolledWindow scroller = new ScrolledWindow();
            scroller.Add(sheet);

            Window win = new Window("GtkSheet Example");
            win.DefaultSize = new Gdk.Size(640, 480);
            win.Destroyed += (_, __) => Application.Quit();
            win.Add(scroller);

            return win;
        }
    }
}
