using PX.Data;
using System;

namespace Hackathon20
{
    public class DeviceTempEntry : PXGraph<DeviceTempEntry>
    {
        public PXSelect<DeviceTemperature> readings;
        public PXSave<DeviceTemperature> Save;
        public PXCancel<DeviceTemperature> Cancel;

        public override void Persist()
        {
            try
            {
                base.Persist();
            }
            catch(Exception ex)
            {
                var message = ex.Message;
            }
            
        }
    }
}
