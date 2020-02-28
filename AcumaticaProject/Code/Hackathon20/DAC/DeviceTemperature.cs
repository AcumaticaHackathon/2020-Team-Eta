using PX.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon20
{
    [PXCacheName("DeviceTemperature")]
    [Serializable]
    public class DeviceTemperature : IBqlTable
    {
        #region RefNbr
        public abstract class refNbr : PX.Data.BQL.BqlInt.Field<refNbr> { }

        protected int? _RefNbr;
        [PXDBIdentity(IsKey = true)]
        [PXUIField(DisplayName = "Ref Nbr", Visible = false, Enabled = false)]
        public virtual int? RefNbr
        {
            get
            {
                return this._RefNbr;
            }
            set
            {
                this._RefNbr = value;
            }
        }
        #endregion
        #region CreatedDateTime

        public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
        protected DateTime? _CreatedDateTime;
        [PXDBCreatedDateTime()]
        [PXUIField(Visible =true, Enabled =false, DisplayName ="")]
        public virtual DateTime? CreatedDateTime
        {
            get
            {
                return this._CreatedDateTime;
            }
            set
            {
                this._CreatedDateTime = value;
            }
        }
        #endregion
        #region DeviceID
        public abstract class deviceID : PX.Data.BQL.BqlString.Field<deviceID> { }
        protected String _DeviceID;
        [PXDBString(20, IsUnicode = true)]
        [PXUIField(DisplayName = "Device ID")]
        public virtual String DeviceID
        {
            get
            {
                return this._DeviceID;
            }
            set
            {
                this._DeviceID = value;
            }
        }
        #endregion
        #region Temperature
        public abstract class temperature : PX.Data.BQL.BqlDecimal.Field<temperature> { }
        protected Decimal? _Temperature;
        [PXDBDecimal()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Temperature")]
        public virtual Decimal? Temperature
        {
            get
            {
                return this._Temperature;
            }
            set
            {
                this._Temperature = value;
            }
        }
        #endregion
        #region Humidity
        public abstract class humidity : PX.Data.BQL.BqlDecimal.Field<humidity> { }
        protected Decimal? _Humidity;
        [PXDBDecimal()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Humidity")]
        public virtual Decimal? Humidity
        {
            get
            {
                return this._Humidity;
            }
            set
            {
                this._Humidity = value;
            }
        }
        #endregion
        #region NoteID
        public abstract class noteID : PX.Data.BQL.BqlGuid.Field<noteID> { }
        protected Guid? _NoteID;
        [PXNote()]
        public virtual Guid? NoteID
        {
            get
            {
                return this._NoteID;
            }
            set
            {
                this._NoteID = value;
            }
        }
        #endregion
    }
}
