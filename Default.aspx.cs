﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace ContosoFashions
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        System.Diagnostics.Trace.WriteLine("Verbose message, in the Page_Load method for Default.aspx");
        System.Diagnostics.Trace.TraceError("Error message, in the Page_Load method for Default.aspx");
        System.Diagnostics.Trace.TraceWarning("Warning  message, in the Page_Load method for Default.aspx");
        System.Diagnostics.Trace.TraceInformation("Information message, in the Page_Load method for Default.aspx");
        }
    }
}