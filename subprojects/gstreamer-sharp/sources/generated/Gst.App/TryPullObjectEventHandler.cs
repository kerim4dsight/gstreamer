// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.App {

	using System;

	public delegate void TryPullObjectEventHandler(object o, TryPullObjectEventArgs args);

	public class TryPullObjectEventArgs : GLib.SignalArgs {
		public ulong Timeout{
			get {
				return (ulong) Args [0];
			}
		}

	}
}