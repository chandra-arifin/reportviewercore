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
	public class LoadReportDefinitionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public ExecutionInfo Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (ExecutionInfo)results[0];
			}
		}

		public Warning[] warnings
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (Warning[])results[1];
			}
		}

		internal LoadReportDefinitionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
			: base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
