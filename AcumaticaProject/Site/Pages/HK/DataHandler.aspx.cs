using Hackathon20;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
public partial class Pages_HK_DataHandler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public override void ProcessRequest(HttpContext context)
    {
        using (new PXLoginScope("admin"))
        {
            var deviceid = context.Request["deviceid"];
            var temperature = context.Request["temperature"];
            var humidity = context.Request["humidity"];

            var graph = PXGraph.CreateInstance<DeviceTempEntry>();
            var reading = new DeviceTemperature();
            reading.DeviceID = deviceid;
            reading.Temperature = Convert.ToDecimal(temperature);
            reading.Humidity = Convert.ToDecimal(humidity);
            graph.readings.Insert(reading);
            graph.Save.Press();

            //var assign = new PXDataFieldAssign("temperature", temperature);

            //PXDatabase.Insert(typeof(DeviceTemperature), 
            //    assign,
            //    new PXDataFieldAssign("deviceid", deviceid),
            //    new PXDataFieldAssign("noteid", Guid.NewGuid()),
            //    new PXDataFieldAssign("CreatedDateTime", DateTime.Now),
            //    new PXDataFieldAssign("humidity", humidity));
            //base.ProcessRequest(context);
        }
    }
}