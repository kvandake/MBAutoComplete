// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Sample
{
	public partial class MyTableViewController : UITableViewController
	{
		public MyTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

				}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			AutoCompleteTextField.Setup(this, new List<string>() { "test", "test2", "nederland", "engeland", "duitsland", "nog een land" });

		}
	}
}
