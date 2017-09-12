using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace PowerShellTools.GoldBarRemover
{
	[ContentType("InBoxPowerShell")]
	[Name("PowerShell Redirect Margin")]
	[MarginContainer("Top")]
	[Export(typeof(IWpfTextViewMarginProvider))]
	[TextViewRole("DOCUMENT")]
	internal sealed class RedirectMarginProvider : IWpfTextViewMarginProvider
	{
		public IWpfTextViewMargin CreateMargin(IWpfTextViewHost wpfTextViewHost, IWpfTextViewMargin marginContainer)
		{
			return null;
		}
	}
}
