using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution
{
	[GeneratedCode("wsdl", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class NavigateDocumentMapCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public int Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (int)results[0];
			}
		}

		internal NavigateDocumentMapCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
			: base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
