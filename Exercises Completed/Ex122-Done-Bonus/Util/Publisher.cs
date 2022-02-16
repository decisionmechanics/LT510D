using System;

namespace Util
{
    public abstract class Publisher
    {
		public event EventHandler StateChanged;
		protected void Notify()
		{
			if (StateChanged != null)
			{
				StateChanged(this, EventArgs.Empty);
			}
		}
    }
}
