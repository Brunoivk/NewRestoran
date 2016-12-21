
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;

		internal static void Initialize(Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false))
			{
				Stetic.Gui.initialized = true;
				global::Gtk.IconFactory w1 = new global::Gtk.IconFactory();
				global::Gtk.IconSet w2 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.table4chairs.png"));
				w1.Add("table4chairs", w2);
				global::Gtk.IconSet w3 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.table2chairs.png"));
				w1.Add("table2chairs", w3);
				global::Gtk.IconSet w4 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.table6chairs.png"));
				w1.Add("table6chairs", w4);
				global::Gtk.IconSet w5 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.table8chairs.png"));
				w1.Add("table8chairs", w5);
				global::Gtk.IconSet w6 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.logo.png"));
				w1.Add("logo", w6);
				global::Gtk.IconSet w7 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.Pice.png"));
				w1.Add("Pice", w7);
				global::Gtk.IconSet w8 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.Ostalo.png"));
				w1.Add("Ostalo", w8);
				global::Gtk.IconSet w9 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("NewRestoran.images.Hrana.png"));
				w1.Add("Hrana", w9);
				w1.AddDefault();
			}
		}
	}

	internal class IconLoader
	{
		public static Gdk.Pixbuf LoadIcon(Gtk.Widget widget, string name, Gtk.IconSize size)
		{
			Gdk.Pixbuf res = widget.RenderIcon(name, size, null);
			if ((res != null))
			{
				return res;
			}
			else {
				int sz;
				int sy;
				global::Gtk.Icon.SizeLookup(size, out sz, out sy);
				try
				{
					return Gtk.IconTheme.Default.LoadIcon(name, sz, 0);
				}
				catch (System.Exception)
				{
					if ((name != "gtk-missing-image"))
					{
						return Stetic.IconLoader.LoadIcon(widget, "gtk-missing-image", size);
					}
					else {
						Gdk.Pixmap pmap = new Gdk.Pixmap(Gdk.Screen.Default.RootWindow, sz, sz);
						Gdk.GC gc = new Gdk.GC(pmap);
						gc.RgbFgColor = new Gdk.Color(255, 255, 255);
						pmap.DrawRectangle(gc, true, 0, 0, sz, sz);
						gc.RgbFgColor = new Gdk.Color(0, 0, 0);
						pmap.DrawRectangle(gc, false, 0, 0, (sz - 1), (sz - 1));
						gc.SetLineAttributes(3, Gdk.LineStyle.Solid, Gdk.CapStyle.Round, Gdk.JoinStyle.Round);
						gc.RgbFgColor = new Gdk.Color(255, 0, 0);
						pmap.DrawLine(gc, (sz / 4), (sz / 4), ((sz - 1)
										- (sz / 4)), ((sz - 1)
										- (sz / 4)));
						pmap.DrawLine(gc, ((sz - 1)
										- (sz / 4)), (sz / 4), (sz / 4), ((sz - 1)
										- (sz / 4)));
						return Gdk.Pixbuf.FromDrawable(pmap, pmap.Colormap, 0, 0, 0, 0, sz, sz);
					}
				}
			}
		}
	}

	internal class ActionGroups
	{
		public static Gtk.ActionGroup GetActionGroup(System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup(type.FullName);
		}

		public static Gtk.ActionGroup GetActionGroup(string name)
		{
			return null;
		}
	}
}
