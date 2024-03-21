#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using System.Runtime.InteropServices;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void Test()
    {
        Log.Error("AAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        var rect = Owner.Get<Rectangle>("Rectangle1");
        if (rect == null)
            Log.Error("rect null");

        rect.FillColor = new Color(255,0,0,0);
    }
}
